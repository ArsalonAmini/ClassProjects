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
    public class Timekeeper
    {

       //constructor member variable (attribute) initial setting / calibration
        string color = "blue"; //color set to blue
        bool isOn = false; // logic gate turned to off //clock is off
        int time = 1230; //int data type time set to 1230

       //constructor function //special method called first to set member variables of objects //pass in three data types as args
        public Timekeeper(string Color, bool IsOn, int Time) //call function with 
        {
            color = Color; 
            isOn = IsOn;
            time = Time;
        }
        //function (method) for changing the color
        public string ChangeColor (string Color)
        {
            color = Color;

            return color;
        }
        //Function for changing on/off status (turning it on/off)
        public bool ChangeStatus (bool IsOn)
        {
            isOn = IsOn;
            return isOn;
        }
        //Function for changing Time
        public int ChangeTime(int Time)
        {
            time = Time;
            time = time + 30;
            return time;
        }
        

    }
    
}
