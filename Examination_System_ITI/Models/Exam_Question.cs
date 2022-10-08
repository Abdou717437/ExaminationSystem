﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Exam_Question")]
    public class Exam_Question
    {
        public Exam_Question()
        {
            Exam_Questions = new HashSet<Question_Bank>();
        }
        public int Id { get; set; }
        public int Points { get; set; }
        
        public Exam Exam { get; set; }

        public virtual ICollection<Question_Bank> Exam_Questions { get; set; }


    }
}