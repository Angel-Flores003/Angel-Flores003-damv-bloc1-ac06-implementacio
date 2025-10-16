using System;

public class Program
{
    public static void Main()
    {
        // PRECONDITION: The user is prompted to input the width and height of a rectangle.
        const string Msg_Input_Width = "Enter the width of the rectangle: ",
            Msg_Input_Height = "Enter the height of the rectangle: ",
            Msg_Result = "The area of the rectangle is: ";
        double widht, height, area;
        Console.WriteLine(Msg_Input_Height);
        widht = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_Input_Height);
        height = Convert.ToInt32(Console.ReadLine());
        area = widht * height;
        Console.WriteLine(Msg_Result + area);
        /* POSTCONDITION: 'area' contains the product of 'width' and 'height', 
         and it is displayed. */

    }
}