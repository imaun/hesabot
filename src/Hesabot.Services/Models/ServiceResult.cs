using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Services.Models
{
    public class ServiceResult<T> where T: class {

        public ServiceResult() {
            Validation = new ValidationResult { IsValid = true };
        }

        public T Result { get; set; }

        public ValidationResult Validation { get; set; }

        public ServiceResult<T> Which(bool isValid, string withMessage = "") {
            Validation.IsValid = isValid;
            Validation.Message = withMessage;
            return this;
        }

        public void IsValid() => Validation.IsValid = true;
    }
}
