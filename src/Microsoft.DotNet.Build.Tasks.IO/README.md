Microsoft.DotNet.Build.Tasks.IO
===============================

Contains tasks related to file IO.

See ["Task Packages"](../../Documentation/TaskPackages.md#usage) for guidance on installing this package.

Tasks in this package

 - Chmod
 - DownloadFile
 - GetFileHash
 - UnzipArchive
 - VerifyFileHash
 - ZipArchive

## Tasks

This package contains the following MSBuild tasks.

### `UnzipArchive`

Unzips a .zip archive file.

Task parameter     | Type        | Description
-------------------|-------------|--------------------------------------------------------------------------------
File               | string      | **[Required]** The path to the file to unzip.
DestinationFolder  | string      | **[Required]** The directory where files will be unzipped.
Overwrite          | boolean     | Overwrite files if they exists already in DestinationFolder. Defaults to false.
OutputFiles        | ITaskItem[] | **[Output]** The files that were unzipped.

```xml
<UnzipArchive File="myapp.zip" DestinationFolder="$(OutDir)" />
```

### `ZipArchive`

Creates a .zip archive file

#### Common parameters
Task parameter     | Type    | Description
-------------------|---------|---------------------------------------------------------------
OutputPath         | string  | **[Required]**  The path where the zip file should be created. The containing directory will be created if it doesn't already exist.
Overwrite          | boolean | Overwrite output path if it exists

There are two valid usages: a list of files, or an entire directory

#### Parameter set - files

Task parameter     | Type        | Description
-------------------|-------------|----------------------------------------------------------------------------------------------------------------------------------
SourceFiles        | ITaskItem[] | **[Required]** Files to be included in the zip. <br> The `Link` metadata item can be set to explicitly set the zip entry path.
BaseDirectory      | string      | **[Required]** The directory to use as the base directory. The entry path for each item in SourceFiles is relative to this.

```xml
<ItemGroup>
   <JsFiles Include="$(PublishDir)**\*.js" >
   <JsFiles Include="../webpack.js" Link="webpack.js" >
</ItemGroup>

<ZipArchive OutputPath="myapp.js.zip" SourceFiles="@(JsFiles)" BaseDirectory="$(PublishDir)" />
```


#### Parameter set - directory

Task parameter         | Type    | Description
-----------------------|---------|-------------
SourceDirectory        | string  | **[Required]** Creates a zip for an entire directory.
IncludeSourceDirectory | bool    | Include the source directory in the zip. Defaults to false.

Example:
```xml
<ZipArchive OutputPath="myapp.zip" SourceDirectory="$(PublishDir)" />
```


### `DownloadFile`

Downloads a file.

Task parameter     | Type    | Description
-------------------|---------|-------------
Uri                | string  | **[Required]** The file to download. Can be prefixed with `file://` for local file paths (results in a copy).
OutputPath         | string  | **[Required]** The full file path destination for the downloaded file, including file name. The containing directory will be created if it doesn't already exist.
Overwrite          | boolean | Overwrite output path if it exists
TimeoutSeconds     | int     | The maximum amount of time (in seconds) to allow for downloading the file. Defaults to 15 minutes.

Example:
```xml
<DownloadFile Uri="https://contoso.com/mytools.1.2.3.zip" OutputPath="$(OutputDir)mytools.1.2.3.zip" />
```

### `GetFileHash`

Computes the checksums for files.

Task parameter     | Type         | Description
-------------------|--------------|-------------
Files              | ITaskItem[]  | **[Required]** The files to be hashed.
Algorithm          | string       | The algorithm. Allowed values: SHA256, SHA384, SHA512. Default = SHA256
FileHash           | string       | **[Output]** The hash of the file in hex. This is only set if there was one item group passed in.
FileHashBase64     | string       | **[Output]** The hash of the file base64 encoded. This is only set if there was one item group passed in.
Items              | ITaskItem[]  | **[Output]** The input files with additional metadata set to include the file hash. <br> Metadata items include: FileHashAlgoritm, FileHash, and FileHashBase64.
MetadataName       | string       | The metadata name where the hash is store in each item. File hash is in hex. Defaults to "FileHash"
MetadataNameBase64 | string       | The metadata name where the base64 encoded hash is store in each item. Defaults to "FileHashBase64"

Example:
```xml
<GetFileHash Files="file.txt">
    <Output TaskParameter="FileHash" PropertyName="MyFileChecksum">
</GetFileHash>

<ItemGroup>
   <FilesToHash Include="*.txt" />
</ItemGroup>

<GetFileHash Files="@(FilesToHash)">
    <Output TaskParameter="Items" ItemName="FilesWithHash">
</GetFileHash>

<Message Text="%(FilesWithHash.FullPath) = %(FilesWithHash.FileHash), algorithm = %(FilesWithHash.FileHashAlgoritm) " />
```

### `VerifyFileHash`

Verifies that a checksum for a file

Task parameter     | Type         | Description
-------------------|--------------|-------------
File               | string       | **[Required]** The file to be verified.
Algorithm          | string       | The algorithm. Allowed values: SHA256, SHA384, SHA512. Default = SHA256
FileHash           | string       | **[Required]** The expected hash of the file in hex.

Example:
```xml
<VerifyFileHash File="file.txt" FileHash="B85656CE3BC7045D403CC55E688C872083A89986CBBF5B336684B669AE19CB7E" />
```

### `Chmod`

Changes Unix permissions on files using `chmod`. On Windows, this task is a no-op.

Task parameter    | Type    | Description
------------------|---------|-------------
File              | string  | **[Required]** The file to be chmod-ed.
Mode              | string  | **[Required]** The file mode to be used. Mode can be any input supported my `man chmod`. e.g. `+x`, `0755`.
