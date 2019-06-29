﻿using System.Collections.Generic;

namespace Contracts.GoogleBooksApi.Responses
{
    public class ErrorResponse
    {
        public Error Error { get; set; }
    }
    public class Error
    {
        public List<Errors> Errors { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
    public class Errors
    {
        public string Domain { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
        public string LocationType { get; set; }
        public string Location { get; set; }
    }
}