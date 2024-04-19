using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace KenshuServiceForms
{
    public partial class Charges : Form
    {
        List<T_Charge> currentCharges;
        public Charges()
        {
            InitializeComponent();
            UpdateChargesList();
        }
        private void UpdateChargesList()
        {
            ChargesView.Items.Clear();
            KenshuDBHandler handler = new KenshuDBHandler();
            currentCharges = handler.GetCharges();
            if (currentCharges != null)
            {
                foreach (T_Charge charge in currentCharges)
                {
                    ListViewItem item = new ListViewItem(charge.charge_id.ToString());

                    item.SubItems.Add(charge.charge_name);
                    item.SubItems.Add(Convert.ToString(charge.amount));
                    item.SubItems.Add(charge.startDate.ToString());
                    item.SubItems.Add((charge.endDate.ToString()));
                    ChargesView.Items.Add(item);
                }
            }
            ChargesView.Refresh();
        }

        private void ChargesCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddButtonCharges_Click(object sender, EventArgs e)
        {
            ChargesAddEdit addEditCharges = new ChargesAddEdit("新規追加", null);
            addEditCharges.ShowDialog();
            UpdateChargesList();
        }
        //TODO:Implement Function
        private void DeleteButtonCharges_Click(object sender, EventArgs e)
        {
            int selectedChargeID = 0;
            foreach (ListViewItem item in ChargesView.SelectedItems)
            {
                selectedChargeID = Convert.ToInt16(item.Text);
            }
            KenshuDBHandler handler = new KenshuDBHandler();
            handler.DeleteEntryInTable(selectedChargeID, "Charges");
            UpdateChargesList();
        }
        private void ChargesView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedChargeID = 0;
            foreach (ListViewItem item in ChargesView.SelectedItems)
            {
                selectedChargeID = Convert.ToInt16(item.Text);
            }
            ChargesAddEdit addEditCharge = new ChargesAddEdit("編集", selectedChargeID);
            addEditCharge.ShowDialog();
            UpdateChargesList();
        }
    }
}
