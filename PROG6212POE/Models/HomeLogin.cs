﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Models
{
    // login page properties
    public class HomeLogin
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; } 


    }
}
