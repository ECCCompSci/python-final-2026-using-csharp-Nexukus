// ============================================================
// C# Final Project 2026
// Name:Gabriel
// Date:
// Project Title: Survey
// Description: Anwser a small survey
// ============================================================

using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.CompilerServices.RuntimeHelpers;


class Program
{
    //The varibles are set here
    public float YesMeter = 0;
    public float Question = 0;
    public float Finished = 0;

    public void Start()
    {
        //This is the Console telling the user the rules
        Console.WriteLine("You are entering a test where you will awnser yes or no");
        Console.WriteLine("To awnser yes press Y");
        Console.WriteLine("To awnser no press N");

    }
      
    public void Update()
        {
    //This is the first question
    //I don't know why there is a fire cause this is how it worked in unity, so idk?
    if (Question == 0) 
       {
            Console.WriteLine("Have you ever told a lie?");
        if (Console.Write("Yes"));
        {
            Console.WriteLine("Thank you for the response");
            Question += 1;
            YesMeter += 1;
        }
        else if (Console.Write("No"))
        {
            Console.WriteLine("Thank you for the response");
            Question += 1;
        }
        else ();
            {
                Console.WriteLine("That is not a valid anwser");
            }

        }
    //The second question
    if (Question == 1)
        {
            Console.WriteLine("Have you commited a crime?");
            if (Console.Write("Yes"))
            {
                Console.WriteLine("Thank you for the response");
                Question += 1;
                YesMeter += 1;
            }
            else if (Console.Write("No"))
            {
                Console.WriteLine("Thank you for the response");
                Question += 1;
            }
            else ()
            {
                Console.WriteLine("That is not a valid anwser");
            }
        }
    if (Question == 2)
        {
            Console.WriteLine("Thank you for taking this small survey");
            Finished += 1;
            if (Finished == 1)
            {
                //Ends the program
                return;
            }
        }
    }
}