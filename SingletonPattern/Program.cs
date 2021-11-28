using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
            () => PrintEmployeeDetails(),
            () => PrintStudentDetails());
        }

        private static void PrintStudentDetails()
        {
            Singleton student = Singleton.GetInstanse;
            student.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton employee = Singleton.GetInstanse;
            employee.PrintDetails("From Employee");
        }
    }
}
