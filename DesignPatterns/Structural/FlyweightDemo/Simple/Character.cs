using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDemo.Simple
{
    public class Character : ICharacter
    {
        private char _symbol;//内部状态

        public Character(char symbol)
        {
            _symbol = symbol;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"字符_{_symbol} 显示在位置 ({x},{y})");
        }

    }
}
