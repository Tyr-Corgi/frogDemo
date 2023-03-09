using System.Diagnostics;

namespace MethodsDemo;
class Program
{


    static void Main(string[] args)
    {
        //intializing and defining variables
        string frog1 = "Frog";
        string frog2 = "frogFrog";
        string frogInput;
        string frogYes = "yes";
        string frogSecret = "here come dat boi";
        var lineCount = 0;
        var cutLine = 10;
        



        //input section

        Console.WriteLine("Do you like frogs? Type yes for frogs.");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        frogInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


        //positive statement, frogInput matches "yes"


        if (frogInput == frogYes)
            while ((++lineCount) < cutLine)
            {

                Console.WriteLine($"{frog1}  {frog2}");
                Thread.Sleep(500);


            }
        //else if statement, easter egg style

        else if (frogInput == frogSecret)
        {
            Console.WriteLine("Not sure how you know about that, but here's frogs anyway");
            Thread.Sleep(3000);
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=CU5ByOf9eP0") { UseShellExecute = true });


        }


        //failure statement
        else
        {
            Console.WriteLine("incorrect answer, no frogs will be typed");


        }
       
    }




}

