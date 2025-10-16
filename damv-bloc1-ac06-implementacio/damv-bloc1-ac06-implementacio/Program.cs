using System;
using System.Security.AccessControl;

public class Program
{
    public static void Main()
    {
        // PRECONDITION: The user is prompted to input three real numbers.        
        const string Msg_Input1 = "Enter the first number: ",
            Msg_Input2 = "Enter the second number: ",
            Msg_Input3 = "Enter the third number: ",
            Msg_Result = "The average is: ";
        double num1, num2, num3, average; ;
        Console.WriteLine(Msg_Input1);
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input2);
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input3);
        num3 = Convert.ToInt32(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.WriteLine(Msg_Result + average);
        /* POSTCONDITION: 'average' contains the arithmetic mean of the three 
        numbers, and it is displayed. */
    }
}