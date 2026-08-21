using System;
class Exercises
{
    static void Main (string[] args)
    {
        // 1.Add/sum two numbers
        int a = 10;
        int b = 29;
        Console.WriteLine($"Tổng của hai số a và b là: {a+b}");

        // 2.Swap values of two variables
        Console.WriteLine($"Before swap số a =  {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swap số a = {a}, b = {b} ");
        
        // 3.Multiply 2 floating point numbers
        float number1 = 3.5f, number2 = 7.5f;
        float number3 = number1 * number2;
        Console.WriteLine($"The result is: {number3}");
        
        // 4.Convert feet to meter
        double feet = 20;
        const double FeetToMeters = 0.3048;
        double Meter = feet * FeetToMeters;
        Console.WriteLine($"Vậy số mét là {Meter}");
        
        // 5.Convert Celsius to Fahrenheit
        double Celsius = 36.4;
        double Fahrenheit = Celsius * 9 / 5 + 32;
        Console.WriteLine($"Độ F sẽ là: {Fahrenheit}");
        
        // 6.Find the size of data types
        Console.WriteLine($"Size of int is:{sizeof(int)}");
        Console.WriteLine($"Size of float is:{sizeof(float)}");
        Console.WriteLine($"Size of double is:{sizeof(double)}");
        Console.WriteLine($"Size of char is:{sizeof(char)}");
        
        // 7.Print ASCII value
        char c = 'H';
        int asciiValue = (int)c;
        Console.WriteLine($"AsciiValue: {asciiValue}");
        
        // 8.Calculate area of circle
        double pi = 3.14;
        double r = 3.5;
        double area_of_cirle = pi * r * r;
        Console.WriteLine($"Area of cirle: {area_of_cirle}");
        
        // 9.Calculate area of square 
        double chv = 5;
        double area_of_square = chv * chv;
        Console.WriteLine($"Area of square: {area_of_square}");
        
        // 10.Convert days to years, weeks and days
        int days = 1000;
        int year = days / 365;
        int remaining_days = days % 365 ;
        int remaining_weeks = remaining_days / 7;
        int day = remaining_weeks % 7;
        Console.WriteLine($"Số năm là {year}, số tuần là {remaining_weeks}, số ngày là {day}");

    }
}
