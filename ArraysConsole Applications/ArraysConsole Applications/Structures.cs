using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArraysConsole_Applications
{
    class Structures
    {
        //utilities for later use
        public string rl()
        {
            return Console.ReadLine();
        }
        //overloaded constructor
        public string rl(bool lower)
        {
            if (lower == true)
            {
                return Console.ReadLine().ToLower();
            }
            else if (lower == false)
            {
                return Console.ReadLine();
            }
            else
            {
                return "please enter a valid entry";
            }
        }

        //----------------------------------------------- Phone Number Example -----------------------------------------------//
        private List<string> Phonelist = new List<string>();
        
        public void addList(string number)
        {
            Phonelist.Add(number);
        }
        public void NumberAdd()
        {
            addList("111-111-111");
            addList("222-222-222");
            addList("333-333-333");
            addList("444-444-444");
            addList("555-555-555");
        }
        public void PhoneReturn()
        {
            foreach (string entry in Phonelist)
            {
                Console.WriteLine(entry);
            }
        }

        public void PhoneNumbersList()
        {
            //add phone numbers to a list
            NumberAdd();

            //writes phone numbers to console
            PhoneReturn();

            //asks for input
            Console.WriteLine("Would you like to add a number? [y/n]");
            string addInto = rl(true);
            if(addInto == "y")
            {
                string contAdd = rl(true);
                addList(contAdd);
                PhoneReturn();
            } else if(addInto == "n")
            {
                rl();
            }

        }

        //-----------------------------------------------  Alphabetic Telephone Example -----------------------------------------------//

        string number = "555-GET-FOOD";
        public string[] translated = new string[10];
        public string[] ABC = new string[3] { "A", "B", "C"};
        public void TeleTranslate()
        {
            translated = number.Split();

            string numberto = null;
            foreach (string number in translated)
            {
                switch (number.ToUpper()) {
                    case "A":
                    case "B":
                    case "C":
                        numberto += "2";
                        break;
                    case "D":
                    case "E":
                    case "F":
                        numberto += "3";
                        break;
                    case "G":
                    case "H":
                    case "I":
                        numberto += "4";
                        break;
                    case "J":
                    case "K":
                    case "L":
                        numberto += "5";
                        break;
                }
                 //Unfinished   

                Console.WriteLine(number);
            }

        }

    }
}
