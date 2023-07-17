using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace Panel.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(IValidator<T> validator, T entity)
        {
            var validationContext = new ValidationContext<T>(entity);
            var result = validator.Validate(validationContext);
            //if (result.Errors.Count>0)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }

   
    }
