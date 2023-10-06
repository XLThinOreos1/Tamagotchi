
public class Question
{
    public string Text;
    public List<string> Alternatives;
    public int CorrectAnswer;

    public bool Ask()
    {
        // Ställ frågan
        Console.WriteLine(Text);

        // Visa alternativen (foreach)

        // Läs in ett svar

        // om svaret är rätt, returnera true
        return false;
    }
}