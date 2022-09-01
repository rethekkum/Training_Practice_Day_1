using System;

class Program
{
    static void Video_1()
    {
        Console.WriteLine("Function 1 is being called");
    }

    static void Video_3()
    {
        // Video #3
        Console.WriteLine("Min int value={0},Max int value={1}", int.MinValue, int.MaxValue);


        //If we want to use escape sequences then we will add @ before string '' and this is called verbatim literals(they make escape sequences normal printable characters)
    }


    static void Video_4()
    {
        //  = assignment 
        int a = 1;
        //   +,*,/,-,% arithmetic operators
        int sum = a + 1;
        Console.WriteLine("Mod Result equals {0}", sum % a);
        // == Comparison operator
        if (sum % a == 0 && a == 1)
        {
            Console.WriteLine("Comparsion && Result:True");
        }
        // comparison operator  ||
        if (sum % a == 0 || a == 2)
        {
            Console.WriteLine("Comparison || Result: True");
        }

        // ternary operator
        int number = 1;

        bool isnumber1 = number == 1 ? true : false;
        Console.WriteLine("Ternary Operator ? : {0}", isnumber1);


    }

    static void Video_2()
    {
        //Video #2

        Console.WriteLine("Enter your name");
        string User_Name = Console.ReadLine();
        Console.WriteLine("The user name is:" + User_Name);
        Console.WriteLine("Hello {0}", User_Name);

        //User of placeholder vs concatenation
        int a = 1;
        string b = "hello";
        string c = "mate";
        Console.WriteLine("{0} {1}, how are you doing today?{2}", b, c, a);
        Console.WriteLine(b + c + ",How are you doing today?" + a);


    }

    static void Video_6()
    {
        string Name = null;
        /// not possible int i = null;

        /// if we want to store null in value type then
        //  there are types nullable value type & non nullable value type
        //  just put a ? next to type

        int? i = null;
        //scenario why we need it

        bool? Major = null;
        //Convert.ToBoolean(Console.ReadLine());
        if (Major == true)
        {

        }
        else if (Major == false)
        {

        }
        else
        {
            Console.WriteLine("No answers");
        }

        //part 2
        int? Ticketsonsale = null;
        int AvailableTickets;
        if (Ticketsonsale == null)
        {
            AvailableTickets = 1;
        }
        else
        {
            AvailableTickets = (int)Ticketsonsale;
        }
        Console.WriteLine("Available tickets : {0}", AvailableTickets);

        //counterpart to part 2
        //we can use null coalescing operator '??' 
        int AvailableTickets2 = Ticketsonsale ?? 0;
        // if ticketsonsale is null then use value after ?? else use ticketsonsale value
        Console.WriteLine("Available tickets2 :: {0}", AvailableTickets2);

    }


    static void Video_7()
    {
        //implicit conversion
        int a = 1;
        float b = a;

        //explicit conversion - type casting-- wont throw exception if the type we are converting to cant hold the value
        float a1 = 1.11F;
        int b1 = (int)a1;
        Console.WriteLine(b1);

        //explicit conversion- convert class function in c# --- we get exception
        int b2 = Convert.ToInt32(b1);
        Console.WriteLine(b2);

        // Parse 

        string strnumber = "100";
        int number = int.Parse(strnumber);

        //Try Parse
        string strnumber1 = "100G";

        int Result = 0;

        bool isConvSucc = int.TryParse(strnumber1, out Result);
        if (isConvSucc)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }


    }

    static void Video_8()
    {
        int[] EvenNumber1 = new int[] { 1, 2, 3 };

        int[] Evennumber2 = { 0, 1, 2 };
        //
        int[] Evennumber3 = new int[3];
        Evennumber3[0] = 01;
    }

    static void Video_9()
    {
        //
        /* 
          
         */
        /// Ctrl K + Ctrl C   
        /// Ctrl K + Ctrl U 

    }

    static void Video_10_ExtraPractice()
    {
        Console.WriteLine("Enter a number");
        int Results = 0;
        string userinput = Console.ReadLine();
        bool check = int.TryParse(userinput, out Results);
        if (check)
        {
            Console.WriteLine("User Provided this input and successfully converted {0}", int.Parse(userinput));
        }
        else
        {
            Console.WriteLine("Not able to parse");
        }

    }

    static void Video_10()
    {
        int a = 1;
        if (a == 1)
        {

        }
        if (a == 2)
        {

        }
        if (a == 3)
        {

        }
        // instead just use if and if else & else so that all conditions are not checked.
        /*
if in condition '|' is used then both conditions will be checked even though first comes true and result will be true.
if in conditions '||' is used then first condition will be checked and if true then second wont be checked and result will be true.

if in condition '&' is used then both conditions will be checked even though first comes false and result will be false.
if in conditions '&&' is used then first condition will be checked and if true then second will be checked and result will be true else if first is false then second wont be checked.

         */
    }


    static void Video_11()
    {
        Console.WriteLine();
        int UserNumber = int.Parse(Console.ReadLine());
        // Here we can use convert function too however that would throw error if out of range, lekin agr aur koi masla hua tou yeh bhi throw karega error.

        switch (UserNumber)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 20:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Case 3");
                break;
        }
        // if 
    }

    static void Video_12()
    {
        int Total_Cost = 0;

        Start:
        Console.WriteLine("Select shoes size: 1-Small, 2-Medium, 3-Large");
        
        int UserChoice = int.Parse(Console.ReadLine());
        switch (UserChoice)
        {
            case 1:
                Console.WriteLine("Small");
                Total_Cost += 10;
                break;
            case 2:
                Console.WriteLine("Medium");
                Total_Cost += 20;
                break;
            case 3:
                Console.WriteLine("Large");
                Total_Cost += 30;
                break;
            default:
                Console.WriteLine("Invalid Choice");
                goto Start;
        }

        Decide:
        Console.WriteLine("do you want another pair of shoes?");
        string userdecision = Console.ReadLine();

        switch (userdecision.ToUpper())
        {
            case "YES":
                goto Start;
                
            case "NO":
                Console.WriteLine("Thanks");
                break;
            default:
                Console.WriteLine("Wrong choice, try again");
                goto Decide;
        }
        
    }


    static void Main()
    {

        Console.WriteLine("Hello, World!");
        //Video_1();
        //Video_2();
        //Video_3();
        //Video_4();
        //Video_6();
        //Video_7();
        //Video_8();
        sample s1;
        //Video_9();
        //Video_10();
        //Video_10_ExtraPractice();
        //Video_11();
        Video_12();
    }
}

/// <summary>
/// This is a sample class along with documentation by rethek
/// </summary>
public class sample
{

}