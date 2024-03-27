using CafeOtomasyon.Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Entities.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator, IEntity entity)
        {
            bool result = true;
            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var ValidationResult = validator.Validate(context);
            if (!ValidationResult.IsValid)
            {
                string message = "";
                foreach (var Error in ValidationResult.Errors)
                {
                    message += Error.ErrorMessage + "\n";
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
        }
    }
}
