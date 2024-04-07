namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Celsius value to convert");
            double.TryParse(Console.ReadLine(), out var C2F);
            Console.WriteLine( TempConverter.CelsiusToFahreinhiet(C2F));
            Console.WriteLine("Enter a Fahreinhiet value to convert");
            double.TryParse(Console.ReadLine(), out var F2C);
            Console.WriteLine( TempConverter.FahreinhietToCelsius(F2C));
        }
    }
}
