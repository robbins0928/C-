using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConsole_Applications
{
    class ListExample
    {
        //Instantiate Lists of Strings
        List<string> students = new List<string>() {"Rachel", "Robin", "Lucas", "Matt", "Michael", "David", "Faith", "Jordan", "Alex"};
        List<string> teachers = new List<string>() { "Yashwanth" };

        //Creates a multidimensional List
        List<string>[] classMembers = new List<string>[2];

        public void countClass()
        {

            //print students and teachers
            /*foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            foreach (string student in teachers)
            {
                Console.WriteLine(teachers);
            }*/

            //Adds lists to MultiDimensional List
            classMembers[0] = teachers;
            classMembers[1] = students;
            for (int x = 0; x < classMembers[1].Count; x++) {
                Console.WriteLine(classMembers[1][x]);
            }

        }



    }
}
