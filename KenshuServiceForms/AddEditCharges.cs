using KenshuServiceForms.Database;
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
    public partial class ChargesAddEdit : Form
    {
        T_Charge? charge;
        string mode;
        public ChargesAddEdit(string _mode, T_Charge _charge)
        {
            InitializeComponent();

            charge = _charge;
            mode = _mode;
            this.Text = mode;
        }
        private void ChargesAddEdit_Load(object sender, EventArgs e)
        {
            if (mode == "編集")
            {
                ChargeNameTextBoxAddEditCharges.Text = charge.charge_name;
                AmountLabelAddEditCharges.Text = Convert.ToString(charge.amount);
                StartDatePickerAddEditCharges.Text = Convert.ToString(charge.startDate);
                if (charge.endDate != null) { EndDatePickerAddEditCharges.Text = charge.endDate.ToString(); }
            }
            else if (mode == "新規追加")
            {
                //empty for now since nothing needs to be executed but default leads to error
            }
            else
            {
                //TODO:Implement Error handling
            }
        }

        private void CancelButtonAddEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TODO: Implement Function
        private void SaveButtonAddEditCharges_Click(object sender, EventArgs e)
        {

        }
    }
}
