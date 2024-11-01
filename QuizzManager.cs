using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app_2
{
    internal class QuizzManager
    {
        public static Quiz quiz;
        public static void Run()
        {

            Console.WriteLine("Enter quiz name: ");
            string quizName  = Console.ReadLine();
            quiz = new Quiz(quizName);
            while (true)
            {
                Console.WriteLine("1.Add a question\n2.Get Questions with answers\nFill in your choise: ");
                 string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        AddQuestion();
                        break;
                    case "2":
                        GetQuestions(); 
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
            }


        }


        private static bool Iscorrect()
        {
            while (true)
            {
                Console.WriteLine("is this answer correct (yes/no)");
                string input = Console.ReadLine();

                if (input == "yes") { return true; }

                if (input == "no") { return false; }

                else
                {
                    Console.WriteLine("write only yes or no");
                }
            }
        }

        private static void AddQuestion()
        {
            Console.WriteLine("enter a question text: ");
            string questionText = Console.ReadLine();   
            var question = new Question(questionText);

            Console.WriteLine("how many answers for this question");
            int answersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < answersCount; i++)
            {
                Console.Write($"Enter answer {i + 1} text: ");
                string answerText = Console.ReadLine();

               
                bool isCorrect = Iscorrect();
                answers.Add(new Answer(answerText, isCorrect));

            }

            else { Console.WriteLine("ivalid number of answers"); }

            return answers;

        }


        private static void GetQuestions()
        {
            if (quiz.Questions.Count == 0)
            {
                Console.WriteLine("there is no questions");
                return;
            }

            Console.WriteLine($"Quiz : {quiz.Name} ");
            int questionNumber = 1;
            foreach (var question in quiz.Questions)
            {
                Console.WriteLine($"Question {questionNumber} : {question.QuestionText}");

                int answertNumber = 1;
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"{answertNumber} {answer.AnswerText} correct - {answer.IsCorrect}");
                    answertNumber++;
                }

                questionNumber++;
            }




        }
      

        public static Quiz GetQuiz()
        {
            return quiz;
        }
    }
}
