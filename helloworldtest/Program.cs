
using Hello;
using CsharpDemo;

class Program
{
    static void Main(string[] arg)
    {
        //  Program2 obj = new Program2();
        // obj.loopArgs(arg);

        Log("DataTypes.Demo", DataTypes.Demo);
        Log(" Operators.Demo()",  Operators.Demo);
        Log("Logging.Demo", Logging.Demo);
        
    }

private    static void Log(string name, Action logAction)
        {
            Console.WriteLine("==============================================================================");
            Console.WriteLine($"================================ {name} ================================");
            Console.WriteLine("==============================================================================");
            logAction();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("==============================================================================");

        }

}


 

