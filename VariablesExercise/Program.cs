namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Victor";
            int age = 30;
            char initial = 'V';
            bool isAlive = true;
            double number = 30.52;
            decimal littleNumber = 0.93745m;

            Console.WriteLine($"My name is {name} I´m {age} years old, my initial is {initial}, Its {isAlive} that I´m Alive, " +
                $"My technical age is {number} and my typing speed is {littleNumber}");
        }
    }
}
