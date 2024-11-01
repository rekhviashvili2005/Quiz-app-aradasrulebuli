using Quiz_app_2;

internal class Program
{
    private static void Main(string[] args)
    {
        QuizzManager.Run();

        var quiz = QuizzManager.GetQuiz();

        while (true)
        {
            Game.Start(quiz);
        }


    }
}