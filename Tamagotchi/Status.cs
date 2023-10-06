class TamaStatus
{
    private int hunger;
    private int boredom;
    private string TamaName;
    private bool isAlive()
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
        Console.WriteLine($"{TamaName}\n");

        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Status: {isAlive}");
    }
}