using MediatR;
using Microsoft.AspNetCore.Mvc;
using Question1.CQRS_Mediator.Library.Commands;
using Question1.CQRS_Mediator.Library.DataAccess;
using Question1.CQRS_Mediator.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Question.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHoursController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OpeningHoursController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<List<string>> GetOpeningHours(OpeningDays days)
        {
            var models = new CheckOpeningHoursCommand(days);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            var result = await _mediator.Send(models);

            return result;
        }
    }
}
