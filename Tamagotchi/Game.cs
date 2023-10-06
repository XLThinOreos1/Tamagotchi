
class Trivia
{
    Player p = new();

    Question q1 = new()
    {
        Text = "1+4",
        Alternatives = new List<int>() { 5, 3, 1 },
        CorrectAnswer = 0
    };

    Question q2 = new()
    {
        Text = "2-1",
        Alternatives = new List<int>() { 6, -2, 1 },
        CorrectAnswer = 2
    };

    void TriviaGame()
    {
        Console.Clear();
        q1.Ask();
        Console.ReadLine();
    }

    // if (q1.Ask())
    // {
    //     p.Score++;
    // }
}


