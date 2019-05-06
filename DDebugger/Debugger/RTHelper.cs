using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    class RTHelper
    {
        public static ICLRRuntimeInfo GetRuntime(IEnumUnknown runtimes, String version)
        {
            Object[] temparr = new Object[3];
            uint fetchedNum;
            String highestVersion = null;
            ICLRRuntimeInfo result = null;
            do
            {
                runtimes.Next(Convert.ToUInt32(temparr.Length), temparr, out fetchedNum);

                for (int i = 0; i < fetchedNum; i++)
                {
                    ICLRRuntimeInfo t = (ICLRRuntimeInfo)temparr[i];

                    // initialize buffer for the runtime version string
                    StringBuilder sb = new StringBuilder(16);
                    UInt32 len = Convert.ToUInt32(sb.Capacity);
                    t.GetVersionString(sb, ref len);

                    // version not specified we return the first one
                    if (!String.IsNullOrEmpty(version))
                    {
                        if (sb.ToString().StartsWith(version, StringComparison.Ordinal))
                            return t;
                    }
                    else
                    {
                        if (highestVersion == null || String.CompareOrdinal(version, highestVersion) > 0)
                        {
                            highestVersion = version;
                            result = t;
                        }
                    }
                }
            } while (fetchedNum == temparr.Length);

            return result;
        }
    }
}
