
namespace InventoryManagementSystem
{
    internal class InputHelper
    {

        public static int ReadInt(string message, int min)
        {
            int value;

            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value < min)
            {

                Console.WriteLine($"Invalid input. Please enter a valid number greater than or equal to {min}.");
                Console.Write(message);
            }

            return value;
        }



        public static decimal ReadDec(string message, decimal min)
        {

            decimal value;

            Console.Write(message);

            while (!decimal.TryParse(Console.ReadLine(), out value) || value < min)
            {


                Console.WriteLine($"Invalid input. Please enter a valid number greater than or equal to {min}.");
                Console.Write(message);
            }


            return value;
        }


        public static bool ReadBool(string message)
        {
            bool value;

            Console.Write(message);

            while (!bool.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input, enter true or false: ");
            }

            return value;
        }



        public static string ReadString(string message, bool allowEmpty = false)
        {

            string value;

            while (true)
            {
                Console.Write(message);


                value = Console.ReadLine();

                if(allowEmpty)
                {
                    return value;
                }



                if (!string.IsNullOrWhiteSpace(value))
                {
                    return value;
                }


                Console.WriteLine("Invalid input, enter a valid text");

            }

        }


    }
}
