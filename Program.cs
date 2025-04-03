namespace classes_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //creates an object frome the hi class
            hi hi = new hi();
            //calls the welcome methed from the hi class 
            hi.welcome();
            //asks for a name
            Console.WriteLine("what u name is?");
            // makes a string called username and it is set to what the user inputs
            string username = Console.ReadLine();
            //calls the hello methed from the hi class with the username varable used in place of name
            hi.Hello(username);
        }
    }
}
