﻿using SimpleQuiz.Core.Model;
using SimpleQuiz.Core.Model.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleQuiz.Core.Tests.Stubs
{
    internal static class StubOpenQuestions
    {
        public static OpenQuestion SingleAnswerSingleOptionQuestion
        {
            get { return new OpenQuestion("Po wodzie pływa kaczka się nazywa?", "kaczka"); }
        }

        public static OpenQuestion SingleAnswerThreeOptionsQuestion
        {
            get 
            { 
                var result = new OpenQuestion("What is one of my favourite colours?");

                result.CorrectAnswers = new List<OpenQuestionCorrectAnswer> 
                {
                    new OpenQuestionCorrectAnswer("red", "black", "blue")
                };

                return result;
            }
        }

        public static OpenQuestion ThreeAnswersSingleOptionQuestion
        {
            get
            {
                var question = new OpenQuestion
                {
                    Content = "What are my top 3 favourite colours (in correct order)?",
                    CorrectAnswers = new List<OpenQuestionCorrectAnswer>
                    {
                        new OpenQuestionCorrectAnswer("red") { OrderId = 1 },
                        new OpenQuestionCorrectAnswer("black") { OrderId = 2 },
                        new OpenQuestionCorrectAnswer("blue") { OrderId = 3}
                    }
                };

                return question;
            }
        }

        public static Question ThreeAnswersThreeOptionsQuestion
        {
            get
            {
                var question = new OpenQuestion
                {
                    Content = "What are my top 3 favourite colours (in correct order)?",
                    CorrectAnswers = new List<OpenQuestionCorrectAnswer>
                    {
                        new OpenQuestionCorrectAnswer("red", "rojo", "czerwony") { OrderId = 1 },
                        new OpenQuestionCorrectAnswer("black", "negro", "czarny") { OrderId = 2 },
                        new OpenQuestionCorrectAnswer("blue", "azul", "niebieski") { OrderId = 3 }
                    }
                };

                return question;
            }
        }
    }
}