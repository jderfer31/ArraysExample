using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is a container that can hold a bunch of information

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42}; //Inside the {} we can start putting info, elements in an array
                                                          // 0  1  2   3   4   5

            string[] friends = new string[5]; //This array will hold 5 values for friends
            friends[0] = "Jim"; //Input value from new string[], 0-5
            friends[1] = "Kelly"; 
 
            //luckyNumbers[1] = 900; //This is an example on how to change element, changed 8 to 900
            
            Console.WriteLine(luckyNumbers[0]); //The 0 in this case represents the positon of the first element



            
        }
    }
}
