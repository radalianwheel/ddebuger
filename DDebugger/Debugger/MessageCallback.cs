using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    sealed class ManagedCallback : ICorDebugManagedCallback, ICorDebugManagedCallback2
    {
        public void Breakpoint(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugBreakpoint pBreakpoint)
        {
            Console.WriteLine("Breakpoint");
            pAppDomain.Continue(0);
        }

        public void StepComplete(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugStepper pStepper, CorDebugStepReason reason)
        {
            Console.WriteLine("StepComplete");
            pAppDomain.Continue(0);
        }

        public void Break(ICorDebugAppDomain pAppDomain, ICorDebugThread thread)
        {
            Console.WriteLine("Break");
            pAppDomain.Continue(0);
        }

        public void Exception(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, int unhandled)
        {
            Console.WriteLine("Exception");
            pAppDomain.Continue(0);
        }

        public void EvalComplete(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugEval pEval)
        {
            Console.WriteLine("EvalComplete");
            pAppDomain.Continue(0);
        }

        public void EvalException(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugEval pEval)
        {
            Console.WriteLine("EvalException");
            pAppDomain.Continue(0);
        }

        public void CreateProcess(ICorDebugProcess pProcess)
        {
            Console.WriteLine("CreateProcess");
            pProcess.Continue(0);
        }

        public void ExitProcess(ICorDebugProcess pProcess)
        {
            Console.WriteLine("ExitProcess");
            pProcess.Continue(0);
        }

        public void CreateThread(ICorDebugAppDomain pAppDomain, ICorDebugThread thread)
        {
            Console.WriteLine("CreateThread");
            pAppDomain.Continue(0);
        }

        public void ExitThread(ICorDebugAppDomain pAppDomain, ICorDebugThread thread)
        {
            Console.WriteLine("ExitThread");
            pAppDomain.Continue(0);
        }

        public void LoadModule(ICorDebugAppDomain pAppDomain, ICorDebugModule pModule)
        {
            Console.WriteLine("LoadModule");
            pAppDomain.Continue(0);
        }

        public void UnloadModule(ICorDebugAppDomain pAppDomain, ICorDebugModule pModule)
        {
            Console.WriteLine("UnloadModule");
            pAppDomain.Continue(0);
        }

        public void LoadClass(ICorDebugAppDomain pAppDomain, ICorDebugClass c)
        {
            Console.WriteLine("LoadClass");
            pAppDomain.Continue(0);
        }

        public void UnloadClass(ICorDebugAppDomain pAppDomain, ICorDebugClass c)
        {
            Console.WriteLine("UnloadClass");
            pAppDomain.Continue(0);
        }

        public void DebuggerError(ICorDebugProcess pProcess, int errorHR, uint errorCode)
        {
            Console.WriteLine("DebuggerError");
            pProcess.Continue(0);
        }

        public void LogMessage(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, int lLevel, string pLogSwitchName, string pMessage)
        {
            Console.WriteLine("LogMessage");
            pAppDomain.Continue(0);
        }

        public void LogSwitch(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, int lLevel, uint ulReason, string pLogSwitchName, string pParentName)
        {
            Console.WriteLine("LogSwitch");
            pAppDomain.Continue(0);
        }

        public void CreateAppDomain(ICorDebugProcess pProcess, ICorDebugAppDomain pAppDomain)
        {
            Console.WriteLine("CreateAppDomain");
            pAppDomain.Continue(0);
        }

        public void ExitAppDomain(ICorDebugProcess pProcess, ICorDebugAppDomain pAppDomain)
        {
            Console.WriteLine("ExitAppDomain");
            pAppDomain.Continue(0);
        }

        public void LoadAssembly(ICorDebugAppDomain pAppDomain, ICorDebugAssembly pAssembly)
        {
            Console.WriteLine("LoadAssembly");
            pAppDomain.Continue(0);
        }

        public void UnloadAssembly(ICorDebugAppDomain pAppDomain, ICorDebugAssembly pAssembly)
        {
            Console.WriteLine("UnloadAssembly");
            pAppDomain.Continue(0);
        }

        public void ControlCTrap(ICorDebugProcess pProcess)
        {
            Console.WriteLine("ControlCTrap");
            pProcess.Continue(0);
        }

        public void NameChange(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread)
        {
            Console.WriteLine("NameChange");
            pAppDomain.Continue(0);
        }

        public void UpdateModuleSymbols(ICorDebugAppDomain pAppDomain, ICorDebugModule pModule, IStream pSymbolStream)
        {
            Console.WriteLine("UpdateModuleSymbols");
            pAppDomain.Continue(0);
        }

        public void EditAndContinueRemap(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugFunction pFunction, int fAccurate)
        {
            Console.WriteLine("EditAndContinueRemap");
            pAppDomain.Continue(0);
        }

        public void BreakpointSetError(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugBreakpoint pBreakpoint, uint dwError)
        {
            Console.WriteLine("BreakpointSetError");
            pAppDomain.Continue(0);
        }

        public void FunctionRemapOpportunity(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugFunction pOldFunction, ICorDebugFunction pNewFunction, uint oldILOffset)
        {
            Console.WriteLine("FunctionRemapOpportunity");
            pAppDomain.Continue(0);
        }

        public void CreateConnection(ICorDebugProcess pProcess, uint dwConnectionId, ref ushort pConnName)
        {
            Console.WriteLine("CreateConnection");
            pProcess.Continue(0);
        }

        public void ChangeConnection(ICorDebugProcess pProcess, uint dwConnectionId)
        {
            Console.WriteLine("ChangeConnection");
            pProcess.Continue(0);
        }

        public void DestroyConnection(ICorDebugProcess pProcess, uint dwConnectionId)
        {
            Console.WriteLine("DestroyConnection");
            pProcess.Continue(0);
        }

        public void Exception(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugFrame pFrame, uint nOffset, CorDebugExceptionCallbackType dwEventType, uint dwFlags)
        {
            Console.WriteLine("Exception");
            pAppDomain.Continue(0);
        }

        public void ExceptionUnwind(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, CorDebugExceptionUnwindCallbackType dwEventType, uint dwFlags)
        {
            Console.WriteLine("ExceptionUnwind");
            pAppDomain.Continue(0);
        }

        public void FunctionRemapComplete(ICorDebugAppDomain pAppDomain, ICorDebugThread pThread, ICorDebugFunction pFunction)
        {
            Console.WriteLine("FunctionRemapComplete");
            pAppDomain.Continue(0);
        }

        public void MDANotification(ICorDebugController pController, ICorDebugThread pThread, ICorDebugMDA pMDA)
        {
            Console.WriteLine("MDANotification");
            pController.Continue(0);
        }
    }
}
