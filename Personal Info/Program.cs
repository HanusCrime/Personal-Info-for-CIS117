using static System.Console;
class Hello
{
    static void Main(string[] args)
    {   //welcoming the user to the program
        System.Console.WriteLine("Now Entering the Matrix");
        // asking for first name then saving the user input into a variable to be used for later.
        System.Console.Write("Please Enter Your First name:");
        string firstname = System.Console.ReadLine();
        // asking for Last Name then saving to variable lastname for future use.
        System.Console.Write("please Enter Your Last name:");
        string lastname = System.Console.ReadLine();
        //calling to firstname and lastname when asking age.
        System.Console.Write("What Year Were You Born " + firstname + " " + lastname+"?:");
        int year = System.Convert.ToInt32(System.Console.ReadLine());
        //displays all user entered information in a contextual way.
        System.Console.WriteLine("" + firstname + " " + lastname + " Born in " + year + " Welcome to the matrix");
    }
}