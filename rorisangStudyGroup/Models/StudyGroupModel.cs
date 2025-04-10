﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rorisangStudyGroup.Models
{
    public class StudyGroupModel
    {
        [Display(Name = "Student Number")]
        public string StudentNr { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "myLink")]
        public string myLink { get; set; }
    }
}