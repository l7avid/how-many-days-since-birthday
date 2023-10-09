namespace BirthdayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Enter your birthday in this format: yyyy-mm-dd");
            string birthday = Console.ReadLine();
            DateTime birthdayDateTime;

            if (DateTime.TryParse(birthday, out birthdayDateTime)) 
            {
                TimeSpan daysSinceBirthday = now.Subtract(birthdayDateTime);
                Console.WriteLine($"Since your birthday ({birthday}) have passed {daysSinceBirthday.Days} days");
            } else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}