//using QUIZ_Application.MODEL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QUIZ_Application.Services
//{
//    public static class QuestionService
//    { 
//        private static List<Question> Questions { get; set; } = new List<Question>();

//        public static int AddQuestion(Question question)
//        {
//            Questions.Add(question);
//            return question.Id;
//        }

       

//        public static Question? GetQuestionsById(int questionId)
//        {
//            foreach (Question question in Questions)
//            {
//                if (question.Id == questionId)
//                return question;
//            }
//            return null;
//        }

//        public static List<Question> GetAllQuestions()
//        {
//            return Questions;
//        }



//    }
//}
