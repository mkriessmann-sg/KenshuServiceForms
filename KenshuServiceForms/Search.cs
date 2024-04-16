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
        public Search()
        {
            InitializeComponent();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TODO:implement function
        private void KensakuSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
