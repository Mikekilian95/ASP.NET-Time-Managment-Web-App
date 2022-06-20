using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Models
{
    // Module Information properties of Module table in database
    public class ModuleModel
    {
        [Key]
        public int ModuleID { get; set; }
        public string ModuleCode { get; set; }

        public string ModuleName { get; set; }

        public double Credits { get; set; }

        public double ClassHours { get; set; }
    }
}
