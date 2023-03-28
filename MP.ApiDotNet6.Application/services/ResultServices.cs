using FluentValidation.Results;
using MP.ApiDotNet6.Application.Dtos;
using MP.ApiDotNet6.Application.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.services
{
    public class ResultServices
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ICollection<ErrorValidation> Errors { get; set; }
        public static ResultServices RequestError(string message, ValidationResult validationResult) => new ResultServices
        {
            IsSuccess = false,
            Message = message,
            Errors = ValidationResult.Errors.Select(x => new ErrorValidation { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
        };
        public static ResultServices<T> RequestError<T>(string message, ValidationResult validationResult)
        {
            return new ResultServices<T>
            {
                IsSuccess = false,
                Message = message,
                Errors = ValidationResult.Errors.Select(x => new ErrorValidation { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }
        public static ResultServices Fail(string message)=>new ResultServices { IsSuccess=false, Message=message};
        public static ResultServices<T> Fail<T>(string message) => new ResultServices<T> { IsSuccess = false, Message = message };
        public static ResultServices Ok(string message)=>new ResultServices { IsSuccess=true, Message=message};
        public static ResultServices<T> Ok<T>(T Data) => new ResultServices<T> { IsSuccess = true, Data=Data };

        internal static ResultServices<T> RequestError<T>(string v, object result)
        {
            throw new NotImplementedException();
        }
    }
}   public class ResultServices<T> : ResultServices 
    {  
       public T Data { get; set; }

    internal object Validate(Equipment_Dtos equipment_Dtos)
    {
        throw new NotImplementedException();
    }
}

