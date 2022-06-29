//Basic Loops Lab 1.1**************************************************************************
string restart;
do
{
    Console.WriteLine("Hello World! \nWould you like to continue? (y/n)? ");
    restart = Console.ReadLine().ToLower();
}
while (restart == "y");
Console.WriteLine("Goodbye!");
Thread.Sleep(5000);

////Basic loops lab 1.2**************************************************************************
//string restart;
//int input;
//int num1;
//int num2;
//do
//{
//    Console.WriteLine("please enter a number:");
//    input = int.Parse(Console.ReadLine());
//    num1 = input;
//    num2 = input;
//    Console.WriteLine("\n");

//    for (int i = 0; i <= num1; num1--)
//    {
//        Console.WriteLine(num1);
//    }
//    for (int i = 0; i <= num2; i++)
//    {
//        Console.WriteLine(i);
//    }

//    Console.WriteLine("\nwould you like to continue (y/n)?");
//    restart = Console.ReadLine().ToLower();
//}
//while (restart == "y");
//Console.WriteLine("goodbye!");
//Thread.Sleep(5000);

////Basic Loops Lab 1.3***************************************************************************
//Console.WriteLine("Enter Passcode:");
//int passcode = int.Parse(Console.ReadLine());
//while (passcode != 13579)
//{
//    Console.Clear();
//    Console.WriteLine("ACCESS DENIED!\nRe-enter passcode:");
//    passcode = int.Parse(Console.ReadLine());
//}
//Console.Clear();
//Console.WriteLine("ACCESS GRANTED.\nWelcome.");
//Console.ReadLine();

////Basic Loops Lab 1.4****************************************************************************
//Console.WriteLine("Enter Passcode:");
//int passcode = int.Parse(Console.ReadLine());
//int attempts = 5;
//while (passcode != 13579 && attempts > 1)
//{
//    attempts--;
//    Console.Clear();
//    Console.WriteLine("ACCESS DENIED!\nRe-enter passcode:");
//    passcode = int.Parse(Console.ReadLine());
//}
//if (passcode == 13579)
//{
//    Console.WriteLine("\nACCESS GRANTED!\nWELCOME.");
//    Thread.Sleep(5000);
//    Environment.Exit(0);
//}
//Console.WriteLine("\nTOO MANY FAILED ATTEMPTS");
//Console.WriteLine("GOODBYE!");
//Thread.Sleep(5000);

////Basic Loops Lab 1.5****************************************************************************
//Console.WriteLine("Enter Passcode:");
//int passcode = int.Parse(Console.ReadLine());
//int attempts = 5;
//if (passcode == 13579)
//{
//    Console.WriteLine("\nACCESS GRANTED!\nWELCOME.");
//    Thread.Sleep(5000);
//    Environment.Exit(0);
//}
//do
//{
//    attempts--;
//    Console.Clear();
//    Console.WriteLine("ACCESS DENIED!\nRe-enter Passcode.");
//    passcode = int.Parse(Console.ReadLine());
//}
//while (attempts > 1 && passcode != 13579);

//Console.WriteLine("\nTOO MANY FAILED ATTEMPTS");
//Console.WriteLine("GOODBYE!");
//Thread.Sleep(5000);