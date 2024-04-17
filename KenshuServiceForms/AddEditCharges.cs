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
        bool startSelected = false;
        bool endSelected = false;
        T_Charge? charge;
        string mode;
        KenshuDBHandler handler = new KenshuDBHandler();
        public ChargesAddEdit(string _mode, int? _charge)
        {
            InitializeComponent();
            if (_charge.HasValue) { charge = (T_Charge)handler.SearchObjectInTableByID(Convert.ToInt32(_charge), "Charges"); }
            mode = _mode;
            this.Text = mode;
        }
        private void ChargesAddEdit_Load(object sender, EventArgs e)
        {
            if (mode == "編集")
            {
                ChargeNameTextBoxAddEditCharges.Text = charge.charge_name;
                AmountTextBoxAddEditCharges.Text = Convert.ToString(charge.amount);
                StartDatePickerAddEditCharges.Text = Convert.ToString(charge.startDate);
                if (charge.endDate != null) { EndDatePickerAddEditCharges.Text = charge.endDate.ToString(); }
            }
            else if (mode == "新規追加")
            {
                charge = new T_Charge();
                charge.charge_id = 1 + Convert.ToInt32(handler.GetHighestIndex("Charges"));
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
            if (mode == "編集")
            {
                if (AssingValues())
                {
                    handler.UpdateEntryInTable(charge, "Charges");
                    this.Close();
                }
            }
            else if (mode == "新規追加")
            {
                if (AssingValues())
                {
                    handler.CreateNewChargeEntry(charge);
                    this.Close();
                }
            }
            else
            {
                //TODO:Implement Error handling
            }

            
        }

        private bool AssingValues()
        {
            bool success = false;
            if (!string.IsNullOrEmpty(ChargeNameTextBoxAddEditCharges.Text))
            {
                charge.charge_name = ChargeNameTextBoxAddEditCharges.Text;
                ChargeNameErrorLabelAddEditCharges.Visible = false;
            }
            else
            {
                success = false;
                ChargeNameErrorLabelAddEditCharges.Text = "必須です";
                ChargeNameErrorLabelAddEditCharges.Visible = true;
            }
            if (!string.IsNullOrEmpty(AmountTextBoxAddEditCharges.Text))
            {
                
                if(int.TryParse(AmountTextBoxAddEditCharges.Text, out int result))
                {
                    charge.amount = result;
                    AmountErrorLabelAddEditCharges.Visible = false;
                }
                else 
                {
                    success = false;
                    AmountErrorLabelAddEditCharges.Text = "整数のみを入力してください";
                    AmountErrorLabelAddEditCharges.Visible = true;
                }
            }
            else
            {
                success = false;
                AmountErrorLabelAddEditCharges.Text = "必須です";
                AmountErrorLabelAddEditCharges.Visible = true;
            }

            
            if (startSelected) 
            {
                charge.startDate = DateOnly.FromDateTime(StartDatePickerAddEditCharges.Value.Date);
                StartDateErrorLabelAddEditCharges.Visible = false;
            }
            else
            {
                success = false;
                StartDateErrorLabelAddEditCharges.Text = "必須です";
                StartDateErrorLabelAddEditCharges.Visible = true;
            }

            if (endSelected) { charge.endDate = DateOnly.FromDateTime(EndDatePickerAddEditCharges.Value.Date); }

            return success;
        }

        private void StartDatePickerAddEditCharges_ValueChanged(object sender, EventArgs e)
        {
            bool startSelected = true;
        }

        private void EndDatePickerAddEditCharges_ValueChanged(object sender, EventArgs e)
        {
            bool endSelected = true;
        }
    }
}
