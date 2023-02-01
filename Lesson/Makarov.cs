using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Makarov : Gun, IGun, IFireable
    {
        public Makarov(int capacity) : base(capacity)
        {

        }
        int _currentMagazine;
        public int MagazineCapacity
        {
            get => _magazineCapacity;
        }
        public int CurrentMagazine
        {
            set => _currentMagazine = value;
            get => _currentMagazine;
        }

        public void Fire()
        {
            if (_currentMagazine > 0)
                _currentMagazine--;
        }

        public void ReloadMagazine()
        {
            _currentMagazine = _magazineCapacity;
        }
    }
}
