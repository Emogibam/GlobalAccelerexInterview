using MediatR;
using Question1.CQRS_Mediator.Library.Commands;
using Question1.CQRS_Mediator.Library.DataAccess;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Question1.CQRS_Mediator.Library.Handlers
{
    public class CheckOpeningHoursHandler : IRequestHandler<CheckOpeningHoursCommand, List<string>>
    {
        private readonly IDataAccess _data;

        public CheckOpeningHoursHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<string>> Handle(CheckOpeningHoursCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetOpeningHours(request.openingDays));
        }
    }
}
