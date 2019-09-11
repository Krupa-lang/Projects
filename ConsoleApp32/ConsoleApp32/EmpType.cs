using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    // Ошибка на этапе компиляции! Значение 999 слишком велико для типа byte!
    enum EmpType
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 999
    }

}
