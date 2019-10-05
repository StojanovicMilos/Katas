namespace WinFormApp
{
    public class SystemUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{ FirstName } { LastName }";
    }
}
