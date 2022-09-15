namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primesList = { 2 };
            int? num = 0;

            //ask for desired number of prime number from user
            Console.WriteLine("Welcome to the Prime Number Evaluator!");

            while (num == 0)
            {
                Console.WriteLine("Please input the index of the prime you are looking for: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < 1)
                {
                    num = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Input invalid. Try a different number.");
                }
            }
     
            Console.WriteLine("");
            Console.WriteLine("You have selected number: " + num);

            //calculate prime
            Console.WriteLine("Calculating prime number at " + num + "...");



            while (num - 1 > primesList.Length)
            {

            }
            //Reminder: primesList = primesList.Append(3).ToArray();
            

            void CheckPrime(int prime)
            {

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