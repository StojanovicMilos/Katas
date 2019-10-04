using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        private readonly IUserDb _userDb;
        private readonly BindingList<UserModel> _users;

        public ChallengeForm(IUserDb userDb)
        {
            _userDb = userDb;
            InitializeComponent();
            _users = new BindingList<UserModel>(_userDb.LoadUsers().ToList());
            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = _users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void AddUserButton_Click(object sender, EventArgs e) =>
            _users.Add(new UserModel
            {
                Age = Convert.ToInt32(agePicker.Value),
                FirstName = firstNameText.Text,
                IsAlive = isAliveCheckbox.Checked,
                LastName = lastNameText.Text
            });

        private void SaveListButton_Click(object sender, EventArgs e) => _userDb.SaveUsers(_users);
    }
}
