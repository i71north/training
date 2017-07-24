// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order
// in reverse order
// or in neither order
using System;
using static System.Console;
class DebugFour2
{
   public void Four2() //must change method name can only have one MAIN METHOD. Main is in the original program (program.cs)
   {
        int num1, num2, num3; //added semicolon. error list says somethign about a readline on line 26.
      string snum1, snum2, snum3;
      Write("Enter first number ");
      snum1 = ReadLine();
      num1 = Convert.ToInt32(snum1);
      Write("Enter second number ");
      snum2 = ReadLine();
      num2 = Convert.ToInt32(snum2);
      Write("Enter third number ");
      snum3 = ReadLine();
      num3 = Convert.ToInt32(snum3);
      if(num1 <= num2 && num2 <= num3)  //changed to less than or equal to
         WriteLine("Numbers are in sequential order");
      else
         if(num1 >= num2 && num2 >= num3) //changed to greater than or equal to
            WriteLine("Numbers are in reverse order");
         else
            WriteLine("Numbers are in neither sequential nor reverse order");

        Console.ReadLine(); //add readline
   }
}
