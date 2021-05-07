using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Services.Models
{
    public class ServiceResult<T> where T: class {

        public T Result { get; set; }

        public ValidationResult Validation { get; set; }
    }
}
