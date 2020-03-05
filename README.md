# CopyBackup Tool UI - Move Files, Folders & Zip Folder
### Beta 3.0 

## Package Required

	1. Microsoft.NETCore.App
	2. Ionic.Zip
	3. Newtonsoft.Json
    4. Windows Form

## Example Config
```
[
  {
    "Id": "1"
    "Title": "Front",
    "Status": "true",
    "CompressFolder": {
      "Status": "true",
      "ZipFileName": "Front",
      "SourcePath": "C:\\CopyBackupTool\\CopyBackupTool\\TEST\\Folder1",
      "MoveToPath": "C:\\CopyBackupTool\\CopyBackupTool\\TEST",
      "Ignore": {
        "Folders": [],
        "Files": [ "1 file.txt", "Another\\1 file.txt" ]
      }
    },
    "CopyAndPaste": {
      "Status": "true",
      "SourcePath": "C:\\CopyBackupTool\\CopyBackupTool\\TEST\\Folder1",
      "DestinationPath": "C:\\CopyBackupTool\\CopyBackupTool\\TEST\\Folder2",
      "Ignore": {
        "Folders": [ "folder1", "folder2", "folder3", "Inside" ],
        "Files": []
      }
    }
  }
]
```
## Compiling
```The configuration file "ConfigurationFile.json" must be in the same folder as the executable.```
