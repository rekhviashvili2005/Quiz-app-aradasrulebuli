using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app_2
{
    public class Answer : BaseClass
    {
        public Answer(string answerText, bool isCorrect)
        {
            AnswerText = answerText;
            IsCorrect = isCorrect;
        }

        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }

        public string GetAnswerContent()
        {
            return $"\nAnswer text: {AnswerText}";
        }


    }
}
