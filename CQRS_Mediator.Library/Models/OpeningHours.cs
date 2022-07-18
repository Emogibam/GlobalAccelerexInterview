using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.CQRS_Mediator.Library.Models
{
    public class OpeningHours
    {
        public string Type { get; set; }
        public int Value { get; set; }
    }
}
