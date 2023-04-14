using MediatR;
using TraversalCoreDemo.CQRS.Results.GuideResults;

namespace TraversalCoreDemo.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
