using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app_2
{




    internal class Quiz
    {
        public Quiz(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }

        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public int QuestionsCount => Questions.Count;  //can i write this little diferently?

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            Questions.Remove(question);
        }

        public string GetQuizContent()
        {
            string quizContent = $"Quiz: {Name}\n";
            int questionNumber = 1;

            foreach (Question question in Questions)
            {
                quizContent += $"Question {questionNumber}:\n{question.GetQuestionContent()}\n";
                questionNumber++;
            }

            return quizContent;
        }

        public string DisplayQuiz()
        {
            return $"Quiz: {Name}, Total Questions: {QuestionsCount}";
        }
    }

















    //internal class Quiz
    //{
    //    public Quiz(string name) 
    //    {
    //        Name = name;
    //        Questions = new List<Question>();

    //    }
    //    public string Name { get; set; }  
    //    public List<Question> Questions { get; set; }

    //    public int QuestionsCount { get; set; } = 0;//??

    //    public void AddQuestion(Question question)
    //    {
    //        Questions.Add(question);
    //    }

    //    public void RemoveQuestion(Question question)
    //    {
    //        Questions.Remove(question);
    //    }

    //    public string GetQuizContent()
    //    {
    //        string quizContent = $"Quiz: {Name}";
    //        int questionNumber = 1;


    //        foreach (Question question in Questions)
    //        {
    //            quizContent += $"Question {questionNumber}:\n{question.GetQuestionContent()}\n";
    //            questionNumber++;
    //        }
    //        return quizContent ;
    //    }

    //    public string DisplayQuiz()
    //    {
    //        return $"Quiz {Name} : {QuestionsCount}";
    //    }

    //}
}
