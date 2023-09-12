using System.Net;

namespace ResponseModel
{
    public class ResponseModel
    {
        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Result { get; private set; }

        public ResponseModel(HttpStatusCode statusCode, string message, object result)
        {
            StatusCode = (int)statusCode;
            Message = message;
            Result = result;
        }
        public ResponseModel(HttpStatusCode statusCode, string message)
        {
            StatusCode = (int)statusCode;
            Message = message;
        }
    }
}
