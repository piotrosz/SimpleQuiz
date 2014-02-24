﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuiz.Core.Model
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.DateTime)]
        [DisplayName("Created date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedOn { get; set; }
    }
}
