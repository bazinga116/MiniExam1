using System;

class MainClass {
  public static void Main (string[] args) {

     int num1, num2;
     
    Console.WriteLine("Enter name ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter height in inches(in) ");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.WriteLine("Enter weight in pounds(lbs) ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
    int result = (730*(num1)/(num2)^2) ;
    Console.WriteLine("Output:((730*{1})/({2}))",
    num1,num2, result);
    
    Console.WriteLine("The BMI for " + name + " is " + result);

    if ((result <0) && (result >= 18.5))
    {
      Console.WriteLine("Health status is underweight");
    }
    else if ((result <= 18.5) && (result >= 24.9))
    {
      Console.WriteLine("Health status is normal and healthy");
    }
    else  
    {
      Console.WriteLine("Health status is overweight");
    }

    Console.ReadLine();



    
  }
}