using DataAccessLayer.Concrete;
using TraversalCoreDemo.CQRS.Queries.DestinationQueries;
using TraversalCoreDemo.CQRS.Results.DestinationResults;

namespace TraversalCoreDemo.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public DestinationByIdQueryResult queryResult(GetDestinationByIdQuery query)
        {
            var value = _context.Desninations.Where(x => x.DesninationId == query.id).FirstOrDefault();
            return new DestinationByIdQueryResult
            {
                DestinationId = value.DesninationId,
                daynight = value.DayNight,
                city = value.City,
            };

        }
    }
}
