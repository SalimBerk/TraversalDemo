using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreDemo.CQRS.Commands.GuideCommands;

namespace TraversalCoreDemo.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new EntityLayer.Concrete.Guide()
            {
                Description= request.Description,
                Name= request.Name,
                Image= request.Image,
                InstagramUrl= request.InstagramUrl,
                TwitterUrl= request.TwitterUrl,
                

            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
