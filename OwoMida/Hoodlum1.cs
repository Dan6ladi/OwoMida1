namespace OwoMida
{
    internal class Hoodlum1
    {
        static void Main(string[] args)
        {
            Hoodlum2 hoodlum2 = new Hoodlum2();

            Console.WriteLine("welcome to OwoMida.\n please enter your first name: ");
            string name = Console.ReadLine();
            Console.WriteLine("welcome {0},what type of vehicle do you drive? \n Bus: 1 \n Keke; 2 \n Minibus; 3\n Okada; 4", name);
            int vehicleType = Convert.ToInt32(Console.ReadLine());
            int x;
            if (vehicleType == 1)
            {
                x = 50;
            }
            else if (vehicleType == 2)
            {
                x = 100;
            }
            else if (vehicleType == 3)
            {
                x = 100;
            }
            else if (vehicleType == 4)
            {
                x = 200;
            }
            else
            {
                x = 0;
            }
            Console.WriteLine("please enter the number of trips");
            int numberOfTrips = Convert.ToInt32(Console.ReadLine());

            int answer = hoodlum2.Amount(x, numberOfTrips);
            Console.WriteLine(answer);
            Console.WriteLine("Are you a registered member of the association? (yes/no)");
            string AssoStatus = Console.ReadLine();
            string AssoStatusLower = AssoStatus.ToLower();
            if (AssoStatusLower == "Yes")
            {
                int answer2 = (int)hoodlum2.discount(answer);
                Console.WriteLine("Hello {0}, you made {1} trips and your toll is {2}. you have qualified for a discount, your new tool is {3}", name, numberOfTrips, answer, answer2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hello {0},you made {1} trips and your toll is {2}", name, numberOfTrips, answer);
            }
        }
    }
}