using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCORE5.ViewModels
{
    public class UploadImageViewModel
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile SpeakerPicture { get; set; }
    }
}
