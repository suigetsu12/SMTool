using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Enums
{
    public enum FeatureType
    {
        [Description("Full flow")]
        FullFlow = 0,
        [Description("Full Main flow")]
        FullMainFlow = 1,
        [Description("Full Small flow")]
        FullSmallFlow = 2,
        [Description("Archive")]
        Archive = 3,
        [Description("Duplicate Engagement")]
        DuplicateEngagement = 4,
        [Description("Carryforward")]
        Carryforward = 5
    }
}
