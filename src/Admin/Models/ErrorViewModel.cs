namespace Orion.Admin.Models
{
    public class ErrorViewModel(string requestId)
    {
        public ErrorViewModel() : this()
        {
            throw new NotImplementedException();
        }

        public string RequestId { get; set; } = requestId;

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}