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
        public string Assignments { get; set; }
        [Range(1, 100)]
        public string Quizzes { get; set; }
        [Range(1, 100)]
        public string GP { get; set; }
        [Range(1, 100)]
        public string Intex { get; set; }
        [Range(1, 100)]
        public string Exams { get; set; }


    }
}
