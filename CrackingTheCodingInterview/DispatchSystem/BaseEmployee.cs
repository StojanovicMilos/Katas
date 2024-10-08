﻿
internal abstract class BaseEmployee
{
    //question for the interviewer: does employee have to have id/first/last name or some other way to distinguish them, besides their role

    internal const int LowestLevel = 0;
    internal abstract int Level { get; }
    internal bool IsAvailable { get; private set; }
    protected virtual bool CanHandleCall { get; } //question for the interviewer: what does it mean to (not) be able to handle the call

    internal void HandleCall(IEscalateCallSystem escalateCallSystem)
    {
        if (CanHandleCall)
        {
            IsAvailable = false;
            Thread.Sleep(1000); //handling the call
            IsAvailable = true;
            return;
        }

        EscalateCall(escalateCallSystem);
    }

    internal virtual void EscalateCall(IEscalateCallSystem escalateCallSystem) => escalateCallSystem.EscalateCall(Level + 1);
}
