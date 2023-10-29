﻿using Donations.Data.Enums;
using Donations.Data.Interfaces;

namespace Donations.Data.Responses
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        /// <summary>
        /// Errors, warnings, success describing property
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Status of process, can be: OK, NotFound, InternalServerError
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Returns count of objects from get query
        /// </summary>
        public int ResultsCount { get; set; }

        /// <summary>
        /// Received data from DAL
        /// </summary>
        public T Data { get; set; }
    }
}
