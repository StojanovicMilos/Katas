using System.Collections.Generic;

namespace DapperDemo.DAL
{
    public interface IDataAccessObject
    {
        IEnumerable<UserDTO> GetAllUsers(string filter);
        void CreateUser(UserDTO user);   
    }

    // ReSharper disable once InconsistentNaming
    public static class IDataAccessObjectConstants
    {
        public const string NoFilter = "";
    }
}