namespace xyztext.Utils.Validation
{
    public class ValidationMessage
    {
        public int LineIndex { get; set; }
        public string Message { get; set; }
        public bool IsError { get; set; }
        public override string ToString() => $"Line {LineIndex + 1}: {(IsError ? "ERROR" : "WARN")}: {Message}";
    }
}
