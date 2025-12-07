using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Api.Model
{
    public class ResponseServer
    {
        public ResponseServer()
        {
            IsSuccess = true;
            ErrorMessages = new List<string>();
        }
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}