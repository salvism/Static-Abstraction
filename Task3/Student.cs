using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task3
{
    internal class Student
    {
        public int No;
        public string Name;
        public string GroupNo;

        static int _totalCount;
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        public bool CheckGroupNo(string groupNo)
        {
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (char.IsUpper(groupNo[0]) && groupNo.Length == 4 && !string.IsNullOrWhiteSpace(groupNo))
                {
                    for (int j = 1; j < groupNo.Length; j++)
                    {
                        if (char.IsDigit(groupNo[j]))
                            return true;
                    }
                }
            }
            return false;
        }

    }
}
