using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_CanberraRestaurants_WebApp.Models
{
    public class ReviewsForum
    {
        public int Id { get; set; }

        [Display(Name = "Post Date")]
        public DateTime PostDate { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Topic Title")]
        public string TopicTitle { get; set; }

        [Required]
        [Display(Name = "Message Content")]
        public string MessageContent { get; set; }

        public int Agree { get; set; }
        public int Disagree { get; set; }
    }
}
