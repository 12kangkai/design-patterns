using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// 懒汉式，线程安全，实现方式:双重复检锁
    /// </summary>
    public class DoubleCheckLockSingleton
    {
        private static volatile DoubleCheckLockSingleton _instance;
        private static readonly object _lock = new object();

        private DoubleCheckLockSingleton()
        {
        }

        public static DoubleCheckLockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DoubleCheckLockSingleton();
                    }
                }
                return _instance;
            }
        }
    }
}
