using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTetris.Records
{
    public partial class frmInputName : Form
    {
        public frmInputName()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > Constants.MaxLengthForName)
            {
                var message = String.Format(Constants.MessageAbouteIncorrectNameLength, Constants.MaxLengthForName);
                MessageBox.Show(message);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmInputName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
    }
}
