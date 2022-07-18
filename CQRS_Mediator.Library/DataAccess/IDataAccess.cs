using Question1.CQRS_Mediator.Library.Commands;
using Question1.CQRS_Mediator.Library.Models;
using System.Collections.Generic;

namespace Question1.CQRS_Mediator.Library.DataAccess
{
    public interface IDataAccess
    {
       List<string> GetOpeningHours(OpeningDays request);
        //List<string> GetOpeningHours(CheckOpeningHoursCommand request);
    }
}
