using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Models
{
    // Self study property of database 
    public class SelfStudyModel
    {
        [Key]
        public int SelfStudyID { get; set; }

        public int UserID { get; set; }

        public int ModuleID { get; set; }

        public string ModuleChosen { get; set; }

        public string DateChosen { get; set; }   

        public double StudyHours { get; set; }

    }
}
