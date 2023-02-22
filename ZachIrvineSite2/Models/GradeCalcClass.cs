using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZachIrvineSite2.Models
{
    public class GradeCalcClass
    {
        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int Assignments { get; set; }

        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int GroupProjects { get; set; }

        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int Quizzes { get; set; }

        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int Midterm { get; set; }

        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int Final { get; set; }

        [Range(0, 1000, ErrorMessage = "Enter number between 0 to 1000")]
        public int Intex { get; set; }
    }
}
