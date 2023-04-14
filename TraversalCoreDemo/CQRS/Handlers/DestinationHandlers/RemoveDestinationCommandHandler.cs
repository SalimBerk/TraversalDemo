using DataAccessLayer.Concrete;
using NuGet.Packaging.Signing;
using TraversalCoreDemo.CQRS.Commands.DestinationCommands;

namespace TraversalCoreDemo.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void handle(RemoveDestinationCommand removeDestinationCommand)
        {
            var value=_context.Desninations.Find(removeDestinationCommand.Id);
            _context.Desninations.Remove(value);
            _context.SaveChanges();

        }
    }
}
