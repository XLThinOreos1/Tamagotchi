
public class TamagotchiGame
{

    static List<string> GameOptions = new() { "1. Play\n, 2. Feed\n, 3. Check Health\n" };

    private static int hunger = 10;
    private static int boredom = 10;

    private static bool isAlive()
    {
        if (hunger > 0 || boredom > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
    }

    public static void Game()
    {
        Console.WriteLine("What do you want to name your Tamagotchi?\n");
        string TamaName = Console.ReadLine();

        while (true)
        {
            isAlive();
            Console.WriteLine("What do you want to do?");
            for (int i = 0; i < GameOptions.Count; i++)
            {
                Console.WriteLine(GameOptions[i]);
            }
            try
            {
                int PlayerChoice = Convert.ToInt32(Console.ReadLine());

                if (PlayerChoice == 1)
                {

                }
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}

