using System;

public class Program
{
    public static void Main()
    {
        // PRECONDITION: The user is prompted to input a temperature in Celsius.
        const string Msg_Input = "Enter temperature in Celsius: ",
            Msg_Result = "Temperature in Kelvin: ";
        double celsius, kelvin;
        Console.WriteLine(Msg_Input);
        celsius = Convert.ToDouble(Console.ReadLine());
        kelvin = celsius + 273.15;
        Console.WriteLine(Msg_Result + kelvin);
        // POSTCONDITION: 'kelvin' contains the converted temperature, and it is displayed.
    }
}