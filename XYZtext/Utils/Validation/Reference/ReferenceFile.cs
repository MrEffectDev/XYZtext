public class ReferenceFile
{
    public string FileName { get; private set; }
    public string[] Lines { get; private set; }

    public ReferenceFile(string fileName, string[] lines)
    {
        FileName = fileName;
        Lines = lines;
    }
}