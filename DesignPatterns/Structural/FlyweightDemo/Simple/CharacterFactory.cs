using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDemo.Simple
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _pool = new();

        public ICharacter GetCharacter(char key)
        {
            if (!_pool.ContainsKey(key))
            {
                _pool[key] = new Character(key);
            }
            return _pool[key];
        }

    }
}
