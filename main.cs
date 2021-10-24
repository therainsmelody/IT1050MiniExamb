using System;

class MainClass {
  

  
  public static void Main (string[] args)
  
   {
   
   Console.WriteLine("Enter the first side of the triangle:");
   double side1 = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Enter the second side of the triangle:");
   double side2 = Convert.ToDouble(Console.ReadLine());

  
   

{
  DetermineHypotenuse();
}
  
  public static void DetermineHypotenuse(ref double side1, ref double side2)
   {
     double hypotenuse=0;
 hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2) );

  Console.WriteLine("The Hypotenuse is = " + hypotenuse);
   
  }
   
  }
}
