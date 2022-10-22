using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Enums
{
    public enum DatabaseActionType
    {
        Deploy = 0,
        Migrate = 1,
        Drop = 2,
        Backup = 3,
        Restore = 4
    }
}
