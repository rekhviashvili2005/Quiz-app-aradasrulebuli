//using QUIZ_Application.MODEL;
//using QUIZ_Application.Services;
//using System.Linq.Expressions;
//using System.Security.Cryptography.X509Certificates;

//internal class Program
//{
//    private static void Main(string[] args)
//    {

//        while (true)
//        {
//            Console.WriteLine("1. Add a question\n2. Get Questions with answers\nFill in your choise: ");

//            string choise = Console.ReadLine();

//            switch (choise)
//            {
//                case "1":
//                    AddQuestion();
//                    break;
//                case "2":
//                    GetQuestions();
//                    break;
//                default:
//                    break;
//            }
//        }
//    }

//    public static void AddQuestion()
//    {
//        Console.WriteLine("How many questions do you want to fill? ");
//        int n = int.Parse(Console.ReadLine());

//        for(int i = 1; i <= n; i++)
//        {
//            Console.WriteLine($"\nFill in {i} Question Text");
//            string questionText = Console.ReadLine();

//            Question question = new Question(questionText);
//            QuestionService.AddQuestion(question);
//            int questionId = question.Id;

//            Console.WriteLine();

//            Console.WriteLine("you should Fill in 4 answers\nWrite Correct one first ");
//            for(int j = 1; j<= 4; j++)
//            {
//                Console.WriteLine($"Answers {j}: ");
//                string answerText = Console.ReadLine();

//                bool isCorrect = j == 1;
//                Answer answer = new Answer(answerText, isCorrect, questionId);

//                AnswerService.AddAnswer(answer);
//            }
//        }

//    }

//    public static void GetQuestions()
//    {
//        List<Question> questions = QuestionService.GetAllQuestions();   
//        List<Answer> answers = AnswerService.GetAllAnswers();
//        Console.WriteLine();
//        foreach (Question question in questions)
//        {
//            Console.WriteLine($"\nQuestion: {question.QuestionText}");
//            Console.WriteLine("answers");
//            int counter = 1;
//            foreach (Answer answer in answers)
//            {
//                if (answer.QuestionId == question.Id) Console.WriteLine($"Answer {counter} : {answer.AnswerText} - {answer.IsCorrect} ");
//                counter++;
              

                
//            }
//        }

//        Console.WriteLine("--------------------");
//    }




//}