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
    public partial class Charges : Form
    {
        public Charges()
        {
            InitializeComponent();
        }


        private void ChargesCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddButtonCharges_Click(object sender, EventArgs e)
        {
            ChargesAddEdit addEditCharges = new ChargesAddEdit("新規追加", null);
            addEditCharges.ShowDialog();
        }
        //TODO:Implement Function
        private void DeleteButtonCharges_Click(object sender, EventArgs e)
        {

        }
    }
}
