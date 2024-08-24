
internal class Director : BaseEmployee
{
    internal override int Level => 2;

    //question for the interviewer - what if director cannot handle the call? Is that possible?
    internal override void EscalateCall(IEscalateCallSystem escalateCallSystem) => throw new InvalidOperationException("Director has nobody to escalate the call to");
}