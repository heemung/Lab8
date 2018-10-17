using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Students
    {
        int studnetNumber;
        string firstName;
        string lastName;
        int age;
        string currentClass;

        public static Students StudentData()
        {
            Students Clayton = new Students();
            Clayton.studnetNumber = 1;
            Clayton.firstName = "Clayton";
            Clayton.lastName = "Cox";
            Clayton.age = 32;
            Clayton.currentClass = "c#";
            return Clayton;
        }
    }


}
