internal class DispatchSystem : IDispatchSystem
{
    private readonly List<BaseEmployee> _employees;

    public DispatchSystem(List<BaseEmployee> employees) => _employees = employees ?? throw new ArgumentNullException(nameof(employees));

    //question for the interviewer - call should probably carry some data, so it should probably be an object passed to this method
    public void DispatchCall() => EscalateCall(BaseEmployee.LowestLevel);

    public void EscalateCall(int level)
    {
        var employee = _employees.Where(e => e.Level >= level && e.IsAvailable).MinBy(e => e.Level); //we can add the "CanHandleCall" here too, but the description of the problem suggests it's the employee that should check if he/she can handle the call
        if (employee != null)
        {
            employee.HandleCall(this);
        }
        else
        {
            //question for the interviewer what happens here, assumption: exception
            throw new InvalidOperationException("system cannot handle the call");
        }
    }
}
