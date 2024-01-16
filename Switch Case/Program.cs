namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Please enter your Age");
            string enterAge = Console.ReadLine();
            bool myAge = int.TryParse(enterAge, out age);

            if (myAge)
            {
                switch (age)
                {
                    case 15:
                        Console.WriteLine("Under Age");
                        break;
                    case 30:
                        Console.WriteLine("Over Age");
                        break;
                    case 25:
                        Console.WriteLine("Correct Age");
                        break;
                    default:
                        Console.WriteLine("Not recognized");
                        break;

                }
            }
            else 
            {
                Console.WriteLine("Wrong Age Format");
            }
        }
    }
}
