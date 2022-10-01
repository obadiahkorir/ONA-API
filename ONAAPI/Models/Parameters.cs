using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONAAPI.Models
{
    public class Parameters
    {
        [Display(Name="Form Number")]
        public string FormId { get; set; }

        [Display(Name = "Project Number")]
        public string ProjectId { get; set; }
    }
}