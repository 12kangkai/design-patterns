using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// 饿汉式单例
    /// </summary>
    public class EagerSingleton
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();
        public static EagerSingleton Instance => _instance;

        private EagerSingleton()
        {
        }
    }
}
