﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AngularQuiz.Core.Model
{
    public class UserQuizScorePackage : Entity
    {
        public int UserId { get; set; }

        public virtual IEnumerable<UserQuizScore> UserQuizScores { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
    }
}
