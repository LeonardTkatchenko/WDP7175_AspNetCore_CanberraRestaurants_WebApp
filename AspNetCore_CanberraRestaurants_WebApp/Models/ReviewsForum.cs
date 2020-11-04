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

        [Display(Name = "Date")]
        public DateTime PostDate { get; set; }

        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Heading")]
        public string Header { get; set; }

        [Required]
        [Display(Name = "Restaurant")]
        public string TopicTitle { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string MessageContent { get; set; }

        [Required]
        [Display(Name = "Rating")]
        public string Rating { get; set; }

        public int Agree { get; set; }
        public bool canIncreaseAgree { get; set; }
        public int Disagree { get; set; }
        public bool canIncreaseDisagree { get; set; }
    }
}
