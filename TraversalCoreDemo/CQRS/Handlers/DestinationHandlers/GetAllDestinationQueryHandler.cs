using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCoreDemo.CQRS.Queries.DestinationQueries;
using TraversalCoreDemo.CQRS.Results.DestinationResults;

namespace TraversalCoreDemo.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Desninations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DesninationId,
                daynight = x.DayNight,
                capacity = x.Capacity,
                city = x.City,
                price = x.Price,

            }).AsNoTracking().ToList();

            return values;
           

        }
    }
}
