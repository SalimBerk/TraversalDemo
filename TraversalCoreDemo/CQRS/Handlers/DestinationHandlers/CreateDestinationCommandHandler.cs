using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using TraversalCoreDemo.CQRS.Commands.DestinationCommands;

namespace TraversalCoreDemo.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void handle(CreateDestinationCommand createDestinationCommand)
        {
            _context.Desninations.Add(new EntityLayer.Concrete.Desnination
            {
                City= createDestinationCommand.City,
                Capacity= createDestinationCommand.Capacity,
                DayNight= createDestinationCommand.DayNight,
                Description= createDestinationCommand.Description,
                Details1=createDestinationCommand.Details1,
                Details2=createDestinationCommand.Details2,
                Image= createDestinationCommand.Image,
                Image2= createDestinationCommand.Image2,
                CoverImage= createDestinationCommand.CoverImage,
            });
            _context.SaveChanges();

        }
    }
}
