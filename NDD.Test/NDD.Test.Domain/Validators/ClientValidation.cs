using FluentValidation;
using DocumentValidator;
using NDD.Test.Domain.Entities;

namespace NDD.Test.Domain.Validators
{
    public class ClientValidation : AbstractValidator<Client>
    {
        public ClientValidation()
        {
            RuleFor(client => client.Id)
                .NotEmpty().WithMessage("Id is required.");

            RuleFor(client => client.Name)
                 .NotEmpty().WithMessage("Name is required.");

            RuleFor(client => client.CPF)
               .NotEmpty().WithMessage("CPF is required.");

            RuleFor(client => CpfValidation.Validate(client.CPF)).Equal(true).WithMessage("Invalid CPF.");

            RuleFor(client => client.Gender)
                .NotEmpty().WithMessage("Gender is required.");

            RuleFor(client => client.PhoneNumber)
                .NotEmpty().WithMessage("Phone Number is required.");

            RuleFor(client => client.Email)
                .NotEmpty().WithMessage("E-mail is required.")
                .EmailAddress().WithMessage("This e-mail is not valid.");

            RuleFor(client => client.BirthDate)
                .NotEmpty().WithMessage("Birth Date is required.");

        }
    }
}
