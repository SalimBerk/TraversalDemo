using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreDemo.CQRS.Queries.GuideQueries;
using TraversalCoreDemo.CQRS.Results.GuideResults;

namespace TraversalCoreDemo.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var value=await _context.Guides.FindAsync(request.id);
            return new GetGuideByIdQueryResult
            {
                GuidId = value.GuidId,
                Description = value.Description,
                Name = value.Name,
            };
        }
    }
}
