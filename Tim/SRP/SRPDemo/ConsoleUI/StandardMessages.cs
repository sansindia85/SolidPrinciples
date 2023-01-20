namespace ConsoleUI
{
    internal class StandardMessages
    {
        internal static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        internal static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
