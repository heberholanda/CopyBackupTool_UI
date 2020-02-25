namespace CopyBackupToolUI_NS
{
    public class FileModel
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public CopyAndPaste CopyAndPaste { get; set; }
        public CompressFolder CompressFolder { get; set; }
    }
}