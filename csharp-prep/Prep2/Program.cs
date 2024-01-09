using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        // create if statements to assign letter grade 
        string letter = "";
        string message = "";
        string sign = "";
        if ( percentage >= 90 )
        {
            letter = "an A";
        }
        else if ( percentage >= 80 )
        {
            letter = "a B";
        }
        else if ( percentage >= 70 )
        {
            letter = "a C";
        }
        else if ( percentage >= 60 )
        {
            letter = "a D";
        }
        else
        {
            letter = "an F";
        }

        // Create pass or fail message 
        if (percentage >= 70 )
        {
            message = "Congratulations! You passed the course.";
        }
        else 
        {
            message = "You did not pass the course. You can try again next semester!";
        }

        //check value of last digit
        
        switch (letter)
        {
            case "an A":
                switch ( percentage % 10)
                {
                    case 0:
                    case 1:
                    case 2:
                        sign = "-";
                        break;   
                }
                break;
                
            case "a B":
            case "a C":
            case "a D":
                switch ( percentage % 10 )
                {
                    case 0:
                    case 1:
                    case 2:
                        sign = "-";
                        break;  
                    case 7:
                    case 8:
                    case 9:
                        sign = "+";
                        break; 
                }
                break;
               default:
                    sign = "";
                    break;
                }
        
        
        Console.Write($"You scored {percentage}%, {letter}{sign}. \n{message}");
    }
}