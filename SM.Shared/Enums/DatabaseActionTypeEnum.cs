using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Enums
{
    public enum DatabaseActionType
    {
        DEPLOY = 0,
        MIGRATE = 1,
        DROP = 2,
        BACKUP = 3,
        RESTORE = 4
    }
}
