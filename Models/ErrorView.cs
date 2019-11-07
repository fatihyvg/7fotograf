namespace _7fotograf.Models
{
    public class ErrorView 
    {
        public string RequestId
        {
            get;
            set;
        }
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}