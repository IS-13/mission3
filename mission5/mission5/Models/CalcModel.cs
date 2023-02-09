using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission5.Models
{
    public class CalcModel
    {
        [Range(1, 100)]
        public float Assignments { get; set; }
        [Range(1, 100)]
        public float Quizzes { get; set; }
        [Range(1, 100)]
        public float GP { get; set; }
        [Range(1, 100)]
        public float Intex { get; set; }
        [Range(1, 100)]
        public float Exams { get; set; }


    }
}
