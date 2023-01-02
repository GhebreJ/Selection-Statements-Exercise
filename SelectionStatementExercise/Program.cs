namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var favNumber = 10;
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < 10)
            {
                Console.WriteLine("too low");
            }
            else if(userInput > 10 )
            {
                Console.WriteLine("too high");
            }
            else 
            {
                Console.WriteLine("You guessed it!!!!");
            }
        }
    }
}
