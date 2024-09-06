using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace EShop.Application.Services.ApplicationService
{
    public class ServiceResult
    {
        public bool Succeeded { get; private set; }
        public IEnumerable<string> Errors { get; private set; }

        protected ServiceResult(bool success)
        {
            Succeeded = success;
            Errors = Enumerable.Empty<string>();
        }

        public ServiceResult(IEnumerable<string> errors)
        {
            Succeeded = false;
            Errors = errors;
        }

        public static ServiceResult Success => new(true);

        public static ServiceResult Failed(params string[] errors) => new(errors);

        public static ServiceResult Failed(IEnumerable<string> errors) => new(errors);
    }
}
