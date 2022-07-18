using System.Collections.Generic;

namespace Question1.CQRS_Mediator.Library.Models
{



    public class OpeningDays
    {
     
        public List<OpeningHours> Monday { get; set; }
        public List<OpeningHours> Tuesday { get; set; }
        public List<OpeningHours> Wednesday { get; set; }
        public List<OpeningHours> Thursday { get; set; }
        public List<OpeningHours> Friday { get; set; }
        public List<OpeningHours> Saturday { get; set; }
        public List<OpeningHours> Sunday { get; set; }

    }

}
