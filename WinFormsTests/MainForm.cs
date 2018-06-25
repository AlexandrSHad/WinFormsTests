using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTests
{
    public partial class MainForm : Form
    {
        private BindingList<User> _users;

        public MainForm()
        {
            InitializeComponent();

            var god = new UserRole { Id = 10, Name = "God" };
            var adm = new UserRole { Id = 20, Name = "Admin" };
            var usr = new UserRole { Id = 30, Name = "User" };

            _users = new BindingList<User>
            {
                new User { Id = 1, Name = "User 1", Roles = new BindingList<UserRole>{ god, adm, usr } },
                new User { Id = 2, Name = "User 2", Roles = new BindingList<UserRole>{ usr } },
                new User { Id = 3, Name = "User 3", Roles = new BindingList<UserRole>{ adm, usr} },
            };

            userBindingSource.DataSource = _users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user2 = _users.FirstOrDefault(u => u.Id == 2);
            user2.Roles = _users.FirstOrDefault(u => u.Id == 1).Roles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentUser = dataGridView1.CurrentRow.DataBoundItem as User;
            currentUser.Email = "email@example.com";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var currentUser = dataGridView1.CurrentRow.DataBoundItem as User;

            using (var rolesForm = new UserRolesEditForm(currentUser.Roles))
            {
                rolesForm.ShowDialog();
            }
        }
    }
}
