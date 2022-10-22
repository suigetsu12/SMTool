﻿using SM.Shared.Extensions;

namespace SM.Shared.Helpers
{
    public static class StringHelper
    {
        public static string RefactorPathContainSpace(string pathStr)
        {
            string newPathStr = string.Empty;
            var strArr = pathStr.Split('\\');
            foreach (var str in strArr)
            {
                string newString = str;
                if (newString.Contains(" "))
                {
                    newString = $"\"{newString}\"";
                }
                if (!newPathStr.NotNullOrEmpty())
                    newPathStr = newString;
                else
                    newPathStr = newPathStr + "\\" + newString;
            }
            return newPathStr;
        }
    }
}
