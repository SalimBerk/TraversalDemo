namespace TraversalCoreDemo.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {

        public int DestinationId { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
    }
}
