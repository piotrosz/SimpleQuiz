﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuiz.Core.Model.Questions
{
    public class SortQuestion : Question
    {
        public ICollection<SortQuestionOption> Options { get; set; }
    }
}
