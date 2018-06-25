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
    public partial class UserRolesEditForm : Form
    {
        public UserRolesEditForm(BindingList<UserRole> userRoles)
        {
            InitializeComponent();

            userRoleBindingSource.DataSource = userRoles;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            userRoleBindingSource.EndEdit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            userRoleBindingSource.CancelEdit();
            Close();
        }
    }
}
