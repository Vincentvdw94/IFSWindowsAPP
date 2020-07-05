using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ifes.Contracts.Dtos.Errors {
    public class ErrorMessageDto {
        public int StatusCode { get; set; }
        public IEnumerable<string> Messages { get; set; }

        public ErrorMessageDto(HttpStatusCode statusCode, IEnumerable<string> messages) {
            this.StatusCode = (int)statusCode;
            this.Messages = messages;
        }
    }

}
