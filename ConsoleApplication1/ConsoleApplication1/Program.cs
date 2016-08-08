using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a DevCode Camp program assigment to create a Clock, Radio or fan
//It is written by Arsalon N Amini-Hajibashi on August 8, 2016

//namespace is a loose term encompassing lists of all class 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating multiple instances (objects) of the Timekeeper class (clock blueprint)
            Timekeeper radioclock = new Timekeeper("green", false, 1230);
            Timekeeper alarmclock = new Timekeeper("black",true, 130);
            Timekeeper woodenclock = new Timekeeper("yellow", false, 230);

            //Calling function to change color
            //a function (ChangeTime) on the instances (objects) of the Timekeeper class (blueprint)
            string  newColorRadio = radioclock.ChangeColor("red");
            string newColorAlarm = alarmclock.ChangeColor("blue");
            string newColorWooden = woodenclock.ChangeColor("green");

            //call function to change status
            bool newStatusRadio = radioclock.ChangeStatus(true);
            bool newStatusAlarm = alarmclock.ChangeStatus(false);
            bool newStatusWooden = woodenclock.ChangeStatus(true);

            //call function to change time
            int newTimeRadio = radioclock.ChangeTime(1230);
            int newTimeAlarm = alarmclock.ChangeTime(120);
            int newTimeWooden = woodenclock.ChangeTime(340);

            //output result to command window for user
            Console.WriteLine(newColorRadio, newStatusRadio, newTimeRadio);
            Console.WriteLine(newColorAlarm, newStatusAlarm, newTimeAlarm);
            Console.WriteLine(newColorWooden, newStatusWooden, newTimeRadio);

        }
    }
}
