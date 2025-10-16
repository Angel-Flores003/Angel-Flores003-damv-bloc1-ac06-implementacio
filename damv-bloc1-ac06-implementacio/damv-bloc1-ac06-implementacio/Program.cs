using System;

public class Program
{
    public static void Main()
    {
        // PRECONDITION: The user is prompted to input an amount in euros.
        const double Exchage_Rate = 1.12;
        const string Msg_Input = "Enter amount in euros: ",            
            Msg_Result = "Amount in dollars: ";
        double euros, dollars;
        Console.WriteLine(Msg_Input);
        euros = Convert.ToInt32(Console.ReadLine());
        dollars = euros * Exchage_Rate;
        Console.WriteLine(Msg_Result + dollars);
        // POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.
    }
}