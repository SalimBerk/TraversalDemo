using DataAccessLayer.Concrete;
using TraversalCoreDemo.CQRS.Commands.DestinationCommands;

namespace TraversalCoreDemo.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void handle(UpdateDestinationCommand updateDestinationCommand)
        {
            var values = _context.Desninations.Find(updateDestinationCommand.DestinationId);
            values.City = updateDestinationCommand.city;
            values.DayNight = updateDestinationCommand.daynight;
            _context.SaveChanges();
        }
    }
}
