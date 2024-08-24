internal interface IDispatchSystem
{
    void DispatchCall();
    void EscalateCall(int level);
}
