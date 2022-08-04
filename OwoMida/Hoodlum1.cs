namespace OwoMida
{
    internal class Hoodlum1
    {
        static void Main(string[] args)
        {
            int Total=0;    

            for (int i = 0; i < 5; i++)
            {


                Hoodlum2 hoodlum2 = new Hoodlum2();

                Console.WriteLine("welcome to OwoMida.\n please enter your first name: ");
                string name = Console.ReadLine();
                Console.WriteLine("welcome {0},what type of vehicle do you drive? \n Bus \n Keke \n Minibus \n Okada", name);
                string vehicleType = Console.ReadLine();
                string vehicleTypes = vehicleType.ToLower();
                int x;
                if (vehicleTypes == "bus")
                {
                    x = 50;
                }
                else if (vehicleType == "keke")
                {
                    x = 100;
                }
                else if (vehicleType == "Minibus")
                {
                    x = 100;
                }
                else if (vehicleType == "Okada")
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
                Total+= answer;
               
               
             
            }
           
            Console.WriteLine("Your total payments for the day is {0}", Total);
           
           
        }
    }
}