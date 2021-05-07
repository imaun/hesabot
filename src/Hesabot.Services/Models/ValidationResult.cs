using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Services.Models {

    public abstract class ValidationResult {
        public bool IsValid { get; set; }
        public string ModelMessage { get; set; }

    }
}
