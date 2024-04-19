using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenshuServiceForms
{
    public partial class Search : Form
    {
        Form1 main;

        public Search(Form1 _main)
        {
            main = _main;
            InitializeComponent();
            MailSearchBox.Text = main.email;
            NameSearchBox.Text = main.name;
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KensakuSearchButton_Click(object sender, EventArgs e)
        {
            if (parse())
            {
                this.Close();
            }
        }
        private bool parse()
        {
            bool success = true;

            if (MailSearchBox.Text.Length < 129)
            {
                main.email = MailSearchBox.Text;
                MailErrorLabelSearch.Visible = false;
            }
            else
            {
                MailErrorLabelSearch.Text = "メールアドレスは128文字までです";
                MailErrorLabelSearch.Visible = true;
                success = false;
            }

            if (NameSearchBox.Text.Length < 21)
            {
                main.name = NameSearchBox.Text;
                NameErrorLabelSearch.Visible = false;

            }
            else
            {
                NameErrorLabelSearch.Text = "氏名は20文字までです";
                NameErrorLabelSearch.Visible = true;
                success = false;
            }
            return success;
        }
    }
}
