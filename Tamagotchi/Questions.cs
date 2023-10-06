public class Question
{
    public string Text;
    public List<int> Alternatives;
    public int CorrectAnswer;
    Random generator = new Random();

    public bool Ask()
    {
        // Ställ frågan
        Console.WriteLine(Text);

        // Visa alternativen (foreach)
        foreach (int i in Alternatives)
        {
            Console.WriteLine(Alternatives[i]);
        }
        // Läs in ett svar

        // om svaret är rätt, returnera true
        return false;
    }
}