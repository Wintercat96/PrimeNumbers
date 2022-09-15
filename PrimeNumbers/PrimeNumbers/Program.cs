namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialization
            int[] primesList = { 2 , 3 }; //yes im cheating a bit by including two set cases it's easier that way
            int checkNum = 5;
            int? chosenNum = 0;

            //Ask for desired number of prime number from user
            Console.WriteLine("Welcome to the Prime Number Evaluator!");

            while (chosenNum == 0)
            {
                Console.WriteLine("Please input the index of the prime you are looking for: ");
                chosenNum = Convert.ToInt32(Console.ReadLine());

                if(chosenNum < 1)
                {
                    chosenNum = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Input invalid. Try a different number.");
                }
            }
     
            Console.WriteLine("");
            Console.WriteLine("You have selected number: " + chosenNum);

            //Calculate the chosen prime
            Console.WriteLine("Calculating prime number at " + chosenNum + "...");
            while(chosenNum > primesList.Length)
            {
                CheckPrime(checkNum);
            }

            //Completion
            Console.WriteLine("Calculated prime number at position " + chosenNum + ": "+ primesList[primesList.Length - 1]);
            Console.WriteLine("Calculation complete. Thank you for using the Prime Number Evaluator.");
   

            //Functions - just one actually

            //Checks if a certain value is a prime number according to the already generated data in primesList
            void CheckPrime(int num)
            {
                bool valueIsPrime = true;

                for (int i = primesList.Length - 1; i >= 0; i--)
                {
                    if (num % primesList[i] == 0)
                    {
                        valueIsPrime = false;
                        Console.WriteLine("- Position " + primesList.Length + ": " + num + " failed dividing by " + primesList[i]);
                        break;
                    }
                }

                if (valueIsPrime)
                {
                    primesList = primesList.Append(num).ToArray();
                    Console.WriteLine("- Position " + primesList.Length + ": Added " + num);
                }
                checkNum += 2;
            }






            /* game plan, lads
             * 
             * start list with 2, and increase number by 1
             * every time, divide by 2 and see if mod is not zero
             * if not, run backwards through the list and see if any of the rest divide
             * if none of them do, this is another prime number. add it to the list
             * once list.length = desiredNumber, return that index
             * 
             * Remember: definition of prime number = divisible by self and 1 and NOTHING else
             * Inherently divisible by 1 and self so just check previous prime numbers
             */



        }
    }
}