namespace Orion.Admin.Handlers
{
    public class CustomerDeleteEvent
    {
        public object CustomerId { get; set; }
        public object OldVersion { get; set; }
    }
}