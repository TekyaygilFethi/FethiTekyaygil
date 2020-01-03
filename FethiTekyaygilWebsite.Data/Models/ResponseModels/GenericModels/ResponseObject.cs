using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels
{
    public class ResponseObject<T> 
    {
        public bool IsSuccess { get; set; }

        public T Object { get; set; }

        public string Message { get; set; }
    }
}
