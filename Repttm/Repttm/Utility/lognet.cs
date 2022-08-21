using System;
using System.Collections.Generic;
using System.Text;

namespace Repttm.Utility
{
    class lognet
    {
        public static readonly log4net.ILog log = log4net.LogManager
            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
