using System.Net;


namespace caapivania.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string message, object data, HttpStatusCode statuscode)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = statuscode;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
