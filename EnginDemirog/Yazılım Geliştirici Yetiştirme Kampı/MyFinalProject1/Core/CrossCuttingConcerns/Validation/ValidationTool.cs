﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var contex = new ValidationContext<object>(entity);
            var result = validator.Validate(contex);
            if (!result.IsValid)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }

        }
    }
}
