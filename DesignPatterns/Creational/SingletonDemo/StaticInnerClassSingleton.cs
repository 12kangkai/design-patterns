using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// 静态内部类单例
    /// </summary>
    public class StaticInnerClassSingleton
    {
        private StaticInnerClassSingleton()
        {
        }

        private class Holder
        {
            internal static readonly StaticInnerClassSingleton _instance = new StaticInnerClassSingleton();
        }

        public static StaticInnerClassSingleton Instance => Holder._instance;
    }
}
