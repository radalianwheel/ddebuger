using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Debugger
{
    class Program
    {
        static Guid metahost_clsid = new Guid("9280188D-0E8E-4867-B30C-7FA83884E8DE");
        static Guid metahost_riid = new Guid("D332DB9E-B9B3-4125-8207-A14884F53216");
        static Guid codebugger_clsid = new Guid("DF8395B5-A4BA-450B-A77C-A9A47762C520");
        static Guid codebugger_riid = new Guid("3D6F5F61-7538-11D3-8D5B-00104B35E7EF");

        private static ICorDebug CreateDebugger(ICLRRuntimeInfo runtime)
        {
            Object res;
            runtime.GetInterface(ref codebugger_clsid, ref codebugger_riid, out res);
            return (ICorDebug)res;
        }

        public static void AttachToProcess(Int32 pid)
        {
            Process proc = Process.GetProcessById(pid);
            ICLRMetaHost metahost = NativeMethods.CLRCreateInstance(ref metahost_clsid, ref metahost_riid);
            IEnumUnknown runtimes = metahost.EnumerateLoadedRuntimes(proc.Handle);
            ICLRRuntimeInfo runtime = RTHelper.GetRuntime(runtimes, "v4.0");


            ICorDebug codebugger = CreateDebugger(runtime);
            codebugger.Initialize();
            codebugger.SetManagedHandler(new ManagedCallback());


            ICorDebugProcess coproc;
            codebugger.DebugActiveProcess(Convert.ToUInt32(pid), 0, out coproc);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int pid = 15108;
            AttachToProcess(pid);
        }
    }
}
