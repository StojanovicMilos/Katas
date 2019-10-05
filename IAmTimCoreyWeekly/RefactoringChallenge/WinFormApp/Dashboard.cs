using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DapperDemo.DAL;

namespace WinFormApp
{
    public partial class Dashboard : Form
    {
        private readonly BindingList<UserDTO> _users = new BindingList<UserDTO>();
        private readonly IDataAccessObject _dao;

        public Dashboard(IDataAccessObject dao)
        {
            _dao = dao ?? throw new ArgumentNullException(nameof(dao));
            InitializeComponent();
            userDisplayList.DataSource = _users;
            userDisplayList.DisplayMember = nameof(UserDTO.FullName);
            DisplayUsersFromDb(IDataAccessObjectConstants.NoFilter);
        }

        private void DisplayUsersFromDb(string filter)
        {
            _users.Clear();
            _dao.GetAllUsers(filter).ToList()
                .ForEach(x => _users.Add(x));
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            _dao.CreateUser(new UserDTO { FirstName = firstNameText.Text, LastName = lastNameText.Text });
            ClearTextBoxes();
            DisplayUsersFromDb(IDataAccessObjectConstants.NoFilter);
        }

        private void ClearTextBoxes()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            firstNameText.Focus();
        }

        private void applyFilterButton_Click(object sender, EventArgs e) => DisplayUsersFromDb(filterUsersText.Text);
    }
}
