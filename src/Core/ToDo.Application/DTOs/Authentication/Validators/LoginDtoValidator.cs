using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.DTOs.Authentication.Validators
{
	public class LoginDtoValidator:AbstractValidator<LoginDto>
	{
        public LoginDtoValidator()
        {
            
        }
    }
}
