using CopyBackupToolUI_NS;
using System.Collections.Generic;

namespace CopyBackupToolUI
{
    public interface IOperations<T>
    {
        void CopyAndPaste(CopyAndPaste copy);
        void CompressFolder(CompressFolder folder);
    }
}
