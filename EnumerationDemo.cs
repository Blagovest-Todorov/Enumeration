using System;

namespace _08.EnumerationsSetOfValues
{
    class EnumerationDemo
    {

        public enum Day  //this is enumeration
        {
           Monday, 
           Tuesday, 
           Wednesday, 
           Thursday, 
           Friday,
           Saturday, 
           Sunday
        };
        
        static void Main(string[] args)
        {

            Day day = Day.Monday; //We make a variable of rthe type enum Day
            Console.WriteLine(day);

            Day nextDay = day + 1;
            Console.WriteLine(nextDay);

            Day thirdDay = nextDay + 1;
            Console.WriteLine(thirdDay);
            
        }

        
        //ebnumerations are date type, predefinded, example, days of week, colors, 
        // we define enum with enum keyword and name of the enum here in our example Color
        // Complilation error! -We can  use only preddifined values !!!! here -only Red,Green, Blue , Black
            //enum is data type, predifened data type;
        var values = Enum.GetValues(typeof(Day)); //returna an Arrray of type data enum Day
        foreach (var item in values)
	{
            Console.WriteLine(item);
	}

    }
}
        
    

