namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string messasge = null, string details = null)
        {
            StatusCode = statusCode;
            Messasge = messasge;
            Details = details;
        }

        public int StatusCode { get; set; }
        public string Messasge { get; set; }
        public string Details { get; set; }
    }
}