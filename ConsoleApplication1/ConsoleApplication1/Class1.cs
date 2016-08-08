using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Pseudocode
// create new class named TimeKeeper
//create member variables in timkeeper such as...
//color (string)
//on or off (boolean)
//time (int)
//Create member methods
//change time (add 30 to time)(int)
//turn on/off (boolean)


namespace ConsoleApplication1
{
    
    //giving initial values to the class attributes
    

    //creating a class (object blueprint) called TimeKeeper. Use TimeKeeper to create specific clock colors, on/off, and time
    class Timekeeper
    {
        string color = "";
        bool isOn = "False";
        int Time = 1230;

        public Timekeeper(string Color, bool IsOne, int ChangeTime)
        {
            Color = color;
            IsOne = isOne;
            Time = time;
        }
        public int ChangeTime (int Time)
        {
            int result;
            result = Time + 30;
            return result;
        }

    }

    //creating a constructor asking for arugment input color, on/off, and change time for creating an instance of the Timekeeper clock (creating a unique clock with color, on/off, time)
    

    }
}
