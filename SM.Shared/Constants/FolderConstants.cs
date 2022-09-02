using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Constants
{
    public static class FolderConstants
    {
        public const string Root = "data\\";
        public class Bat
        {
            public const string Root = FolderConstants.Root + "bat\\";
            public const string Start = Root + "start\\";
            public const string Publish = Root + "publish\\";
            public const string Database = Root + "database\\";
            public const string Configuration = Root + "configuration\\";
        }

        public class Sql
        {
            public const string Root = FolderConstants.Root + "sql\\";
        }

        public class Json
        {
            public const string Root = FolderConstants.Root + "json\\";
            public const string Configuration = Root + "configuration\\";
            public const string Storage = Root + "storage\\";
        }
    }
}
