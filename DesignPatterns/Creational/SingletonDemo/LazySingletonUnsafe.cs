using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// 懒汉式，非线程安全
    /// </summary>
    public sealed class LazySingletonUnsafe
    {
        private static LazySingletonUnsafe _instance;

        public static LazySingletonUnsafe Instance
        {
            get
            {
                if (_instance == null)
                {
                    // 在创建实例前加一点延迟，增加线程冲突概率
                    Thread.Sleep(5);
                    _instance = new LazySingletonUnsafe();
                }
                return _instance;
            }
        }

        private LazySingletonUnsafe()
        {
            // 模拟构造耗时，增加线程竞争几率
            Thread.Sleep(10);
        }
    }
}
