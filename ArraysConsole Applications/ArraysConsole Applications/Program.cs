using System;


namespace ArraysConsole_Applications
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Instantiations
            ArrayExample ae = new ArrayExample();
            ListExample le = new ListExample();
            StringExample se = new StringExample();
            Structures s = new Structures();

            //Comment each in based on what class you wish to use with what function
            //ae.ArrayToEnd();
            //ae.ArrayToEndForEach();
            //ae.binaryArray();
            //le.countClass();
            //se.printstr();
            //s.PhoneNumbersList();
            s.TeleTranslate();

            //Holds console open until you press a key.
            Console.ReadLine();
        }
    }
}
