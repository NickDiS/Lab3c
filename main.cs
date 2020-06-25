using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is your number?");
    int number = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    var answer = "Yes";
    while(i<number)
    {
      if (number % i == 0) 
      {
        answer = "no";
      }  
    i++;
  }
    if (answer == "no")
    {
      Console.WriteLine ("Number is not prime");
    }
    else
    {
      Console.WriteLine ("Number is prime");
    }
    
  }
}