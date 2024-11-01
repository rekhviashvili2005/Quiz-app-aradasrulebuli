using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app_2
{

    public class Question : BaseClass
    {
        public Question(string questionText)
        {
            QuestionText = questionText;
            Answers = new List<Answer>();
        }

        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }

        public void AddAnswer(Answer answer)
        {
            Answers.Add(answer);
        }

        public void RemoveAnswer(Answer answer)
        {
            Answers.Remove(answer);
        }

        public string GetQuestionContent()
        {
            // Start with the question text
            string content = $"{QuestionText}\n";

            // Append each answer with numbering
            for (int i = 0; i < Answers.Count; i++)
            {
                content += $"{i + 1}. {Answers[i].GetAnswerContent()}\n";
            }

            return content;
        }
    }





















    //public class Question : BaseClass
    //{
    //    public Question(string questionText)
    //    {
    //        QuestionText = questionText;
    //        Answers = new List<Answer>();
    //    }

    //    public string QuestionText { get; set; }
    //    public List<Answer> Answers { get; set; }

    //    public void AddAnswer(Answer answer)
    //    {
    //        Answers.Add(answer);
    //    }

    //    public void RemoveAnswer(Answer answer)
    //    {
    //       Answers.Remove(answer);
    //    }


    //    public string GetQuestionContent(string questionText)
    //    {
    //        string content  = $"{QuestionText}";
    //        for (int i = 0; i < Answers.Count; i++)
    //        {
    //            content += $"{i + 1} {Answers[i].GetAnswerContent()}";
    //        }
    //        return content;

    //    }


    //}
}
