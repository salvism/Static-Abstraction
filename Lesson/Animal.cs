﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal abstract class Animal
    {
        public string Name;
        public byte Age;
        public abstract void MakeSound();
        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + " / " + Age);
        }
    }
}
