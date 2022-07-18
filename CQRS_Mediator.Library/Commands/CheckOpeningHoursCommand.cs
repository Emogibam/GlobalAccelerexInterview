using MediatR;
using Question1.CQRS_Mediator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.CQRS_Mediator.Library.Commands
{
    public record CheckOpeningHoursCommand(OpeningDays openingDays) : IRequest<List<string>>;

}
