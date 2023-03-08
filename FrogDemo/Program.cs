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
       
        //input section

        Console.WriteLine("Do you like frogs? Type yes for frogs.");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        frogInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


        //positive statement, frogInput matches "yes"

        if (frogInput == frogYes)
        {
            Console.WriteLine(frog1 + frog2 + frog1 + frog2 + frog1 + frog2 + frog1 + frog2 + frog1 + frog2 +
                frog1 + frog2 + frog1 + frog2 + frog1 + frog2 + frog1 + frog2 + frog1 + frog2 +
                frog1 + frog2 + frog1 + frog2);
           


        }
        //failure statement, can be null

        else
        {
            Console.WriteLine("incorrect answer, no frogs will be typed");

        }

    }
  

    
    
}

