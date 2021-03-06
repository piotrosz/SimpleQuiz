﻿using AngularQuiz.Core.Model.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularQuiz.Core.Tests.Stubs
{
    internal static class StubSortQuestions
    {
        public static SortQuestion SortQuestion
        {
            get
            {
                return new SortQuestion
                {
                    Id = 234,
                    Content = "Sort alphabet",
                    Answers = new List<SortQuestionOption>
                    {
                        new SortQuestionOption { Content = "A", OrderId = 1 },
                        new SortQuestionOption { Content = "B", OrderId = 2 },
                        new SortQuestionOption { Content = "C", OrderId = 3 }
                    }
                };
            }
        }
    }
}
