using MediatR;
using TraversalCoreDemo.CQRS.Results.GuideResults;

namespace TraversalCoreDemo.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
