using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Models
{

    // Weekly Schedule entities and properties
    public class WeeklySchedule
    {
        [Key]
        public int ScheduleID { get; set; }

        public string MondayModule { get; set; }
        public string TuesdayModule { get; set; }
        public string WednesdayModule { get; set; }
        public string ThursdayModule { get; set; }
        public string FridayModule { get; set; }


    }
}
