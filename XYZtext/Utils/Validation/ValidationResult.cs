using System.Collections.Generic;

namespace xyztext.Utils.Validation
{
    public class ValidationResult
    {
        public ValidationStatus Status { get; set; } = ValidationStatus.Green;
        public List<int> WarningLines { get; } = new List<int>();
        public List<int> ErrorLines { get; } = new List<int>();
        public List<ValidationMessage> Messages { get; } = new List<ValidationMessage>();
    }
}