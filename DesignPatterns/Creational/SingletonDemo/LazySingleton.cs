using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// 线程安全单例模式示例，推荐
    /// </summary>
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton Instance => _instance.Value;

        private LazySingleton()
        {
        }
    }
}
