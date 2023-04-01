using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount aForm = new AddAccount();
            aForm.Show();
            Visible = false;
        }


        private void btnEditAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }

        private void Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTextBox_OnForm1(string data)
        {
            Accounts.Items.Add(data);
        }
    }
}
