using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

      
        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void login_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_Click(this, new EventArgs());
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show(); 
        }

        private void login_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
