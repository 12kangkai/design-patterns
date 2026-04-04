using Xunit.Abstractions;
using Xunit.Sdk;

namespace SingletonDemo.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void LazySingleton_Test()
        {
            TestSingletonThreadSafety(() => LazySingleton.Instance, 5, false);
        }

        [Fact]
        public void EagerSingleton_Test()
        {
            TestSingletonThreadSafety(() => EagerSingleton.Instance, 5, false);
        }

        [Fact]
        public void DoubleCheckLockSingleton_Test()
        {
            TestSingletonThreadSafety(() => DoubleCheckLockSingleton.Instance, 5, false);
        }

        [Fact]
        public void StaticInnerClassSingleton_Test()
        {
            TestSingletonThreadSafety(() => StaticInnerClassSingleton.Instance, 5, false);
        }

        [Fact]
        public void LazySingletonUnsafe_Test()
        {
            TestSingletonThreadSafety(() => LazySingletonUnsafe.Instance, 5, true);
        }

        /// <summary>
        /// 通用多线程单例测试方法
        /// </summary>
        /// <typeparam name="T">单例类型</typeparam>
        /// <param name="getInstance">获取单例实例的委托</param>
        /// <param name="threadCount">并发线程数</param>
        /// <param name="expectMultipleInstances">是否期望产生多个实例（线程不安全情况）</param>
        private void TestSingletonThreadSafety<T>(
            Func<T> getInstance,
            int threadCount = 50,
            bool expectMultipleInstances = false
        )
        {
            var instances = new List<T>();
            var tasks = new List<Task>();
            var barrier = new Barrier(threadCount);

            for (int i = 0; i < threadCount; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    barrier.SignalAndWait(); // 等待所有线程同时开始
                    var instance = getInstance();
                    lock (instances)
                    {
                        instances.Add(instance);
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());

            var distinctCount = instances.Distinct().Count();
            _testOutputHelper.WriteLine($"Instances created: {distinctCount}");

            if (expectMultipleInstances)
            {
                Assert.True(distinctCount > 1, "Expected multiple instances due to thread-unsafe singleton");
            }
            else
            {
                Assert.Equal(1, distinctCount);
            }
        }
    }
}
