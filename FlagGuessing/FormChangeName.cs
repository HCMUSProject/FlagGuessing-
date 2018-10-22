using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagGuessing
{
    public partial class FormChangeName : Form
    {
        public FormChangeName()
        {
            InitializeComponent();
        }

        private void FormChangeName_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnOK;
        }

        public string getInputName()
        {
            return txtNewName.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text.Length == 0)
            {
                lbNotification.Text = "Tên phải dài hơn 4 kí tự !";
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {
            lbNotification.Text = "";
        }
    }
}
