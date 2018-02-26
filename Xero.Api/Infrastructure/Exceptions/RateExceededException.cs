﻿using System;
using System.Net;

namespace Xero.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class RateExceededException
        : XeroApiException
    {
        public RateExceededException() { }

        public string RateLimitProblem { get; set; }

        public RateExceededException(string message) : base(HttpStatusCode.ServiceUnavailable, message)
        {

        }

        public RateExceededException(string message, string rateLimitProblem) : this(message)
        {
            RateLimitProblem = rateLimitProblem;
        }
    }
}