using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission5.Models
{
    public class CalcModel
    {
        [Required]
        public string Assignments { get; set; }
        public string Quizzes { get; set; }
        public string GP { get; set; }
        public string Intex { get; set; }
        public string Exams { get; set; }


    }
}
