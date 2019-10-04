namespace TextFileChallenge
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        public string DisplayText
        {
            get
            {
                string aliveStatus = IsAlive ? "is alive" : "is dead";

                return $"{ FirstName} { LastName } is { Age } and { aliveStatus }";
            }
        }
    }
}
