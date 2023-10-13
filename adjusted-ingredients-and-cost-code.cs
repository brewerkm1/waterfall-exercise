namespace Waterfall_Exercise;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                int servings = 0;
                do
                {
                    Console.WriteLine("(Positive integers only)");
                    Console.WriteLine("Please enter your number of servings: ");
                    servings = Convert.ToInt32(Console.ReadLine());
                } while (servings < 0);

                ScaledIngredients(servings);
                ScaledCost(servings);
            }
            catch (Exception e) { Console.WriteLine("(Whole numbers only)"); }
        }
    }

    public static void ScaledIngredients(int multiplier)
    {
        double flour = 1.5;
        double bakingPowder = 3.5;
        int sugar = 1;
        double salt = 0.25;
        double milk = 1.25;
        int butter = 3;
        int egg = 1;

        Console.WriteLine($"\n---Ingredients ADJUSTED---\nFlour: {flour*multiplier} cup(s)\nBaking Powder: {bakingPowder*multiplier} teaspoon(s)\nSugar: {sugar * multiplier} tablespoon(s)\nSalt: { salt* multiplier} teaspoon(s)\nMilk: {milk * multiplier} cup(s)\nButter: {butter * multiplier} tablespoon(s)\nEggs: { egg* multiplier}\n");
    }

    public static void ScaledCost(int multiplier)
    {
        // prices come from walmart.com

        decimal flour = 2.34m;
        decimal bakingPowder = 3.24m;
        decimal sugar = 3.24m;
        decimal salt = 0.72m;
        decimal milk = 3.33m;
        decimal butter = 3.78m;
        decimal egg = 1.92m;
        decimal total = (flour + bakingPowder + sugar + salt + milk + butter + egg)* multiplier;

        Console.WriteLine($"\n\n---Cost ADJUSTED---\nFlour: ${flour * multiplier}\nBaking Powder: ${bakingPowder * multiplier}\nSugar: ${sugar * multiplier}\nSalt: ${salt * multiplier} \nMilk: ${milk * multiplier}\nButter: ${butter * multiplier} \nEggs: ${egg * multiplier}\nTOTAL: ${total}");

    } 
}
