using SM.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Helpers
{
    public static class FolderHelper
    {
        public static void CreateFolder(string path)
        {
            try
            {
                if (!path.NotNullOrEmpty())
                {
                    return;
                }

                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    return;
                }
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch
            {
                return;
            }
        }

        public static void DeleteFolder(string path)
        {
            try
            {
                if (!path.NotNullOrEmpty())
                {
                    return;
                }

                // Determine whether the directory exists.
                if (!Directory.Exists(path))
                {
                    return;
                }
                // Try to delete the directory.
                DirectoryInfo di = new DirectoryInfo(path);
                di.Delete(true);
            }
            catch
            {
                return;
            }
        }
    }
}
