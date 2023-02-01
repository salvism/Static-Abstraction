using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
        public int No;
        public string FullName;
        public byte Point;

        static int _totalCount;
        static Student()
        {
            _totalCount = 10;
        }
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
    }
}
