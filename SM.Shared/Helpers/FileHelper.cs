﻿using SM.Shared.Extensions;

namespace SM.Shared.Helpers
{
    public static class FileHelper
    {
        public static bool WriteFile(string path, string jsonString)
        {
            try
            {
                if (!path.NotNullOrEmpty() || !jsonString.NotNullOrEmpty())
                {
                    return false;
                }

                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path));
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ReadFile(string path)
        {
            string jsonString = string.Empty;
            if (!path.NotNullOrEmpty())
            {
                return jsonString;
            }

            if (File.Exists(path))
            {
                StreamReader r = new StreamReader(path);
                jsonString = r.ReadToEnd();
                r.Close();
            }
            return jsonString;
        }

        public static bool RenameFile(string oldPath, string newPath, string jsonString = null)
        {
            try
            {
                if (!oldPath.NotNullOrEmpty() || !newPath.NotNullOrEmpty())
                {
                    return false;
                }
                if (jsonString.NotNullOrEmpty())
                {
                    File.WriteAllText(oldPath, jsonString);
                }

                File.Move(oldPath, newPath);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
