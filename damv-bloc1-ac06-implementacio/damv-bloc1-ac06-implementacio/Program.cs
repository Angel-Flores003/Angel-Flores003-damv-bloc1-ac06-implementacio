using System;

public class Program
{
    public static void Main()
    {
        // PRECONDITION: The user is prompted to input two integers.
        const string Msg_Input1 = "Enter the first integer: ",
            Msg_Input2 = "Enter the second integer: ",
            Msg_Result = "The sum is: ";
        int num1, num2, sum;
        Console.WriteLine(Msg_Input1);
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Msg_Input2);
        num2 = Int32.Parse(Console.ReadLine());
        sum = num1+ num2;
        Console.WriteLine(Msg_Result + sum);
        // POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is displayed.
    }
}
