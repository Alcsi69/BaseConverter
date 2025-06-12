using System;

public class BaseConverter
{
  public static void Main()
  {
    Console.WriteLine("Give a number in Base 10: "); 
    int baseTen = Convert.ToInt16(Console.ReadLine()); //convert the user-given string into an int16

    string baseTwo = ""; //initialize an empty string for the Base 2 conversion

    /*
     * modulo divide the Base 10 number with 2, and add this remainder to the beginning of the string, 
     * then integer divide the given Base 10 number with 2 until it reaches zero
    */
    while (baseTen > 0)
    {
      baseTwo = Convert.ToString(baseTen % 2) + baseTwo;
      baseTen /= (int) 2;
    }
    
    Console.WriteLine("The number you gave in Base 2: " + baseTwo);
  }
}
