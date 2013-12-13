using System;
using System.IO;
using System.Security;

#if NETFX_CORE
using Windows.Storage;
#endif

namespace Loqu8.MvvmCross.Plugins.IO
{
    public class MvxPath : IMvxPath
    {
        public MvxPath()
        {
        }

        #region MvxBasePath
#if !NETFX_CORE && !WINDOWS_PHONE
        // Summary:
        //     Provides a platform-specific alternate character used to separate directory
        //     levels in a path string that reflects a hierarchical file system organization.
        public char AltDirectorySeparatorChar
        {
            get
            {
                return System.IO.Path.AltDirectorySeparatorChar;
            }
        }
#endif
#if !NETFX_CORE
        //
        // Summary:
        //     Provides a platform-specific character used to separate directory levels
        //     in a path string that reflects a hierarchical file system organization.
        public char DirectorySeparatorChar
        {
            get
            {
                return System.IO.Path.DirectorySeparatorChar;
            }
        }
        //
        // Summary:
        //     Provides a platform-specific array of characters that cannot be specified
        //     in path string arguments passed to members of the System.IO.Path class.
        //
        // Returns:
        //     A character array of invalid path characters for the current platform.
        [Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public char[] InvalidPathChars
        {
            get
            {
                return System.IO.Path.GetInvalidPathChars();
            }
        }
        //
        // Summary:
        //     A platform-specific separator character used to separate path strings in
        //     environment variables.
        public char PathSeparator
        {
            get
            {
                return System.IO.Path.PathSeparator;
            }
        }
        //
        // Summary:
        //     Provides a platform-specific volume separator character.
        public char VolumeSeparatorChar
        {
            get
            {
                return System.IO.Path.VolumeSeparatorChar;
            }
        }
#endif

        // Summary:
        //     Changes the extension of a path string.
        //
        // Parameters:
        //   path:
        //     The path information to modify. The path cannot contain any of the characters
        //     defined in System.IO.System.IO.Path.GetInvalidPathChars().
        //
        //   extension:
        //     The new extension (with or without a leading period). Specify null to remove
        //     an existing extension from System.IO.Path.
        //
        // Returns:
        //     The modified path information.On Windows-based desktop platforms, if path
        //     is null or an empty string (""), the path information is returned unmodified.
        //     If extension is null, the returned string contains the specified path with
        //     its extension removed. If path has no extension, and extension is not null,
        //     the returned path string contains extension appended to the end of System.IO.Path.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public string ChangeExtension(string path, string extension)
        {
            return System.IO.Path.ChangeExtension(path, extension);
        }
        //
        // Summary:
        //     Combines an array of strings into a System.IO.Path.
        //
        // Parameters:
        //   paths:
        //     An array of parts of the System.IO.Path.
        //
        // Returns:
        //     The combined paths.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     One of the strings in the array contains one or more of the invalid characters
        //     defined in System.IO.System.IO.Path.GetInvalidPathChars().
        //
        //   System.ArgumentNullException:
        //     One of the strings in the array is null.
        public string Combine(params string[] paths)
        {
            return System.IO.Path.Combine(paths);
        }
        //
        // Summary:
        //     Combines two strings into a System.IO.Path.
        //
        // Parameters:
        //   path1:
        //     The first path to combine.
        //
        //   path2:
        //     The second path to combine.
        //
        // Returns:
        //     The combined paths. If one of the specified paths is a zero-length string,
        //     this method returns the other System.IO.Path. If path2 contains an absolute path, this
        //     method returns path2.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path1 or path2 contains one or more of the invalid characters defined in
        //     System.IO.System.IO.Path.GetInvalidPathChars().
        //
        //   System.ArgumentNullException:
        //     path1 or path2 is null.
        public string Combine(string path1, string path2)
        {
            return System.IO.Path.Combine(path1, path2);
        }
        //
        // Summary:
        //     Combines three strings into a System.IO.Path.
        //
        // Parameters:
        //   path1:
        //     The first path to combine.
        //
        //   path2:
        //     The second path to combine.
        //
        //   path3:
        //     The third path to combine.
        //
        // Returns:
        //     The combined paths.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path1, path2, or path3 contains one or more of the invalid characters defined
        //     in System.IO.System.IO.Path.GetInvalidPathChars().
        //
        //   System.ArgumentNullException:
        //     path1, path2, or path3 is null.
        public string Combine(string path1, string path2, string path3)
        {
            return System.IO.Path.Combine(path1, path2, path3);
        }
        //
        // Summary:
        //     Combines four strings into a System.IO.Path.
        //
        // Parameters:
        //   path1:
        //     The first path to combine.
        //
        //   path2:
        //     The second path to combine.
        //
        //   path3:
        //     The third path to combine.
        //
        //   path4:
        //     The fourth path to combine.
        //
        // Returns:
        //     The combined paths.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path1, path2, path3, or path4 contains one or more of the invalid characters
        //     defined in System.IO.System.IO.Path.GetInvalidPathChars().
        //
        //   System.ArgumentNullException:
        //     path1, path2, path3, or path4 is null.
        public string Combine(string path1, string path2, string path3, string path4)
        {
            return System.IO.Path.Combine(path1, path2, path3, path4);
        }
        //
        // Summary:
        //     Returns the directory information for the specified path string.
        //
        // Parameters:
        //   path:
        //     The path of a file or directory.
        //
        // Returns:
        //     Directory information for path, or null if path denotes a root directory
        //     or is null. Returns System.String.Empty if path does not contain directory
        //     information.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     The path parameter contains invalid characters, is empty, or contains only
        //     white spaces.
        //
        //   System.IO.PathTooLongException:
        //     The path parameter is longer than the system-defined maximum length.
        public string GetDirectoryName(string path)
        {
            return GetDirectoryName(path);
        }
        //
        // Summary:
        //     Returns the extension of the specified path string.
        //
        // Parameters:
        //   path:
        //     The path string from which to get the extension.
        //
        // Returns:
        //     The extension of the specified path (including the period "."), or null,
        //     or System.String.Empty. If path is null, System.IO.System.IO.Path.GetExtension(System.String)
        //     returns null. If path does not have extension information, System.IO.System.IO.Path.GetExtension(System.String)
        //     returns System.String.Empty.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public string GetExtension(string path)
        {
            return GetExtension(path);
        }
        //
        // Summary:
        //     Returns the file name and extension of the specified path string.
        //
        // Parameters:
        //   path:
        //     The path string from which to obtain the file name and extension.
        //
        // Returns:
        //     The characters after the last directory character in System.IO.Path. If the last character
        //     of path is a directory or volume separator character, this method returns
        //     System.String.Empty. If path is null, this method returns null.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public string GetFileName(string path)
        {
            return GetFileName(path);
        }
        //
        // Summary:
        //     Returns the file name of the specified path string without the extension.
        //
        // Parameters:
        //   path:
        //     The path of the file.
        //
        // Returns:
        //     The string returned by System.IO.System.IO.Path.GetFileName(System.String), minus the
        //     last period (.) and all characters following it.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public string GetFileNameWithoutExtension(string path)
        {
            return GetFileNameWithoutExtension(path);
        }
#if !NETFX_CORE
        //
        // Summary:
        //     Returns the absolute path for the specified path string.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to obtain absolute path information.
        //
        // Returns:
        //     The fully qualified location of path, such as "C:\MyFile.txt".
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one
        //     or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().-or-
        //     The system could not retrieve the absolute System.IO.Path.
        //
        //   System.Security.SecurityException:
        //     The caller does not have the required permissions.
        //
        //   System.ArgumentNullException:
        //     path is null.
        //
        //   System.NotSupportedException:
        //     path contains a colon (":") that is not part of a volume identifier (for
        //     example, "c:\").
        //
        //   System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum
        //     length. For example, on Windows-based platforms, paths must be less than
        //     248 characters, and file names must be less than 260 characters.
        [SecuritySafeCritical]
        public string GetFullPath(string path)
        {
            return System.IO.Path.GetFullPath(path);
        }
#endif
        //
        // Summary:
        //     Gets an array containing the characters that are not allowed in file names.
        //
        // Returns:
        //     An array containing the characters that are not allowed in file names.
        public char[] GetInvalidFileNameChars()
        {
            return System.IO.Path.GetInvalidFileNameChars();
        }
        //
        // Summary:
        //     Gets an array containing the characters that are not allowed in path names.
        //
        // Returns:
        //     An array containing the characters that are not allowed in path names.
        public char[] GetInvalidPathChars()
        {
            return System.IO.Path.GetInvalidPathChars();
        }
        //
        // Summary:
        //     Gets the root directory information of the specified System.IO.Path.
        //
        // Parameters:
        //   path:
        //     The path from which to obtain root directory information.
        //
        // Returns:
        //     The root directory of path, such as "C:\", or null if path is null, or an
        //     empty string if path does not contain root directory information.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().-or-
        //     System.String.Empty was passed to System.IO.Path.
        public string GetPathRoot(string path)
        {
            return GetPathRoot(path);
        }
        //
        // Summary:
        //     Returns a random folder name or file name.
        //
        // Returns:
        //     A random folder name or file name.
        public string GetRandomFileName()
        {
            return System.IO.Path.GetRandomFileName();
        }
#if !NETFX_CORE
        //
        // Summary:
        //     Creates a uniquely named, zero-byte temporary file on disk and returns the
        //     full path of that file.
        //
        // Returns:
        //     The full path of the temporary file.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs, such as no unique temporary file name is available.-
        //     or -This method was unable to create a temporary file.
        [SecuritySafeCritical]
        public string GetTempFileName()
        {
            return System.IO.Path.GetTempFileName();
        }
#endif
        //
        // Summary:
        //     Returns the path of the current user's temporary folder.
        //
        // Returns:
        //     The path to the temporary folder, ending with a backslash.
        //
        // Exceptions:
        //   System.Security.SecurityException:
        //     The caller does not have the required permissions.
        [SecuritySafeCritical]
        public string GetTempPath()
        {
#if NETFX_CORE
            var tempFolder = ApplicationData.Current.TemporaryFolder;
            return tempFolder.Path;
#else
            return System.IO.Path.GetTempPath();
#endif
        }
        //
        // Summary:
        //     Determines whether a path includes a file name extension.
        //
        // Parameters:
        //   path:
        //     The path to search for an extension.
        //
        // Returns:
        //     true if the characters that follow the last directory separator (\\ or /)
        //     or volume separator (:) in the path include a period (.) followed by one
        //     or more characters; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public bool HasExtension(string path)
        {
            return System.IO.Path.HasExtension(path);
        }
        //
        // Summary:
        //     Gets a value indicating whether the specified path string contains a root.
        //
        // Parameters:
        //   path:
        //     The path to test.
        //
        // Returns:
        //     true if path contains a root; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     path contains one or more of the invalid characters defined in System.IO.System.IO.Path.GetInvalidPathChars().
        public bool IsPathRooted(string path)
        {
            return System.IO.Path.IsPathRooted(path);
        }

        #endregion MvxBasePath
    }
}
