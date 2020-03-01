using CopyBackupToolUI.Models;

namespace CopyBackupToolUI
{
    public interface IOperations<T>
    {
        void CopyAndPaste(CopyAndPaste copy);
        void CompressFolder(CompressFolder folder);
    }
}
