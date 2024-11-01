//using QUIZ_Application.MODEL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QUIZ_Application.Services
//{
//    public static class AnswerService
//    {
//        private static List<Answer> Answers { get; set;  } = new List<Answer>();

//        public static int AddAnswer(Answer answer)
//        {
//            Answers.Add(answer);
//            return answer.Id;
//        }

//        public static Answer? GetAnswersById(int answersId)
//        {

//            foreach(Answer answer in Answers)
//            {
//                if (answer.Id == answersId) return answer;
//            }
//            return null;
     
//        }


//        public static List<Answer> GetAllAnswers()
//        {
//            return Answers;
//        }

//    }
//}
