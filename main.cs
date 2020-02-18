using System;

class Program {
  public static void Main () {
      Console.WriteLine ("CAR INSURANCE APPROVAL");

    Console.WriteLine ("What is your age?: ");
     int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Have you ever had a DUI?: ");
       string option = Console.ReadLine();
  bool confirmed = false;
    if (option == "yes")
    {
        confirmed = true;
    }
       Console.WriteLine ("How many speeding tickets do you have?: ");
     int tickets = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Qualified:");
  Console.WriteLine(age > 15 && confirmed == false && tickets <= 3);

  }
}