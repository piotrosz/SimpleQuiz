﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuiz.Core.Model.Questions
{
    public class CategoryQuestion : Question<CategoryQuestionOption>
    {
        public override QuestionType QuestionType
        {
            get { return QuestionType.Category; }
        }

        public override ICollection<CategoryQuestionOption> Answers { get; set; }
    }
}
