using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statuscode, string message = null)
        {
            this.StatusCode = statuscode;
            this.Message = message ?? GetDefaultMessageStatusCode(statuscode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }


        private string GetDefaultMessageStatusCode(int statuscode)
        {
            string errorMessage = string.Empty;
            switch (statuscode)
            {
                case 400:
                    errorMessage = "A Bad request!";
                    break;
                case 401:
                    errorMessage = "Authorized error!";
                    break;
                case 404:
                    errorMessage = "Resouce Not Found!";
                    break;
                case 500:
                    errorMessage = "Server Error!";
                    break;
            }
            return errorMessage;
        }

    }
}
