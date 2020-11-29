﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCORE5.ViewModels
{
    public class SpeakerViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string SpeakerName { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime SpeakingDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public DateTime SpeakingTime { get; set; }

        [Required]
        public string Venue { get; set; }
    }
}
