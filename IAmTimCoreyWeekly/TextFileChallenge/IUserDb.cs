using System.Collections.Generic;
using System.ComponentModel;

namespace TextFileChallenge
{
    public interface IUserDb
    {
        IEnumerable<UserModel> LoadUsers();
        void SaveUsers(BindingList<UserModel> users);
    }
}