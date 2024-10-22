
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68);
        NegNumber(-9);
        NumOrderMax(4,7,-9);
        NumOrderMin(4,6,-1);
        DivisibleBy5(25);
        DivisibleBy2(60);
        Vowel('y');
        DayOfWeek(1);
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {

        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }
    public static void NegNumber(float num1)
    {
        if(num1>0)
        {
        Console.WriteLine($"{num1} number is positive.");
        }
        else if(num1<0)
        {
        Console.WriteLine($"{num1} number is negetive.");
        }
        else
        {
        Console.WriteLine($"this number is zero.");
        }
    }
    public static void NumOrderMin(int num5,int num6,int num7)
    {

        if (num5 < num6 && num5 < num7 )
        {
            Console.WriteLine($"{num5} is the smallest.");
        }
        else if (num6 < num5 && num6 < num7 )
        {
            Console.WriteLine($"{num6} is the smallest.");
        }
        else if (num7 < num6 && num7 < num5 )
        {
            Console.WriteLine($"{num7} is the smallest.");
        }
    }
        public static void NumOrderMax(int num2,int num3,int num4)
    {

        if (num2 > num3 && num2 > num4 )
        {
            Console.WriteLine($"{num2} is the biggest");
        }
        else if (num3 > num2 && num3 > num4 )
        {
            Console.WriteLine($"{num3} is the biggest");
        }
        else if (num4 > num3 && num4 > num2 )
        {
            Console.WriteLine($"{num4} is the biggest");
        }
        

    }
    public static void DivisibleBy5(int num8)
    {
        int DivNum = num8 % 5;
        if(DivNum == 0)
        {
            Console.WriteLine($"{num8} is divisible by 5.");
        }
        else{
            Console.WriteLine($"{num8} is not divisible by 5");
        }
    }
    public static void DivisibleBy2(int num9)
    {
        int DivNum = num9 % 2;
        if(DivNum == 0)
        {
            Console.WriteLine($"{num9} is even.");
        }
        else{
            Console.WriteLine($"{num9} is odd.");
        }
    }
     public static void Vowel(char letter1)
    {
        switch(letter1)
        {
            case 'a':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'e':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'i':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'o':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'u':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'y':
            Console.WriteLine($"{letter1} is sometimes a vowel");
            break;
             case 'A':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'E':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'I':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'O':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'U':
            Console.WriteLine($"{letter1} is a vowel");
            break;
             case 'Y':
            Console.WriteLine($"{letter1} is sometimes a vowel");
            break;
            default:
            Console.WriteLine($"{letter1} is a constant");
            break;
        }

    }
    public static void DayOfWeek(int DayNum)
    {
        if(DayNum == 1)
        {
            Console.WriteLine("monday");
        }
        if(DayNum == 2)
        {
            Console.WriteLine("tuesday");
        }
        if(DayNum == 3)
        {
            Console.WriteLine("wednesday");
        }
        if(DayNum == 4)
        {
            Console.WriteLine("thursday");
        }
        if(DayNum == 5)
        {
            Console.WriteLine("friday");
        }
        if(DayNum == 6)
        {
            Console.WriteLine("saterday");
        }
        if(DayNum == 7)
        {
            Console.WriteLine("sunday");
        }

    }
}



