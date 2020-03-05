using System;

namespace CopyBackupToolUI.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public CopyAndPaste CopyAndPaste { get; set; }
        public CompressFolder CompressFolder { get; set; }
    }
}