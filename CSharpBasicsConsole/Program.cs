namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Name: Alex Cueto
             * Favorite day of the week: Friday
             * Least favorite school subject: Math
             * 
             */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            while (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name: ");
                name = Console.ReadLine();
                      
            }
            Console.Clear();

            Console.WriteLine("What is your favorite day of the week? ");
            string dayOfWeek = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(dayOfWeek))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                dayOfWeek= Console.ReadLine();

            }
            Console.Clear();

            Console.Write("What is/was your least favorite subject in school? ");
            string leastFaveSchoolSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(leastFaveSchoolSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                leastFaveSchoolSubject = Console.ReadLine();
            }
            Console.Clear();



            string displayText = "";

            while (input == "" || input.StartsWith("QQ"))
            {
                Console.WriteLine("Enter your name: ");
                input = Console.ReadLine();            
            }

        }
    }

}