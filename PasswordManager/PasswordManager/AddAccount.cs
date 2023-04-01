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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Management mForm = new Management();

            if (txtName.Text.Length > 0 && txtEmail.Text.Length > 0 && txtUsername.Text.Length > 0 &&
            txtPass.Text.Length > 0)
            {
                List<String> accountInfo = new List<String>();
                accountInfo.Add(txtName.Text);
                accountInfo.Add(txtEmail.Text);
                accountInfo.Add(txtUsername.Text);
                accountInfo.Add(txtPass.Text);
                accountInfo.Add(txtSecurityInfo.Text);
                accountInfo.Add(txtExtraInfo.Text);
                mForm.UpdateTextBox_OnForm1(Accounts.Text);
            }
            
            mForm.Show();
            Visible = false;
            
        }
    }
}
