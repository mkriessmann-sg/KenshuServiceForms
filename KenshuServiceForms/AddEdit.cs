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
    public partial class AddEdit : Form
    {
        bool startSelected = false;
        bool endSelected = false;
        string mode;
        T_Member? member;
        KenshuDBHandler handler = new KenshuDBHandler();
        public AddEdit(string _mode, int? _memberID)
        {
            InitializeComponent();
            mode = _mode;
            this.Text = mode;
            int? memberID = _memberID;
            if (memberID.HasValue)
            {
                member = (T_Member)handler.SearchObjectInTableByID(Convert.ToInt32(memberID), "Members");
            }
        }


        //implement mode 
        private void AddEdit_Load(object sender, EventArgs e)
        {
            if (mode == "編集")
            {
                MemberIDTextLabelAddEdit.Text = Convert.ToString(member.member_id);
                MailAddressTextBoxAddEdit.Text = member.mail;
                NameTextBoxAddEdit.Text = member.name;
                AddressTextBoxAddEdit.Text = member.address;
                JoinDatePickerAddEdit.Text = Convert.ToString(member.start_date);
                if (member.end_date != null) { LeaveDatePickerAddEdit.Text = Convert.ToString(member.end_date); }
                if (member.payment_method != null) { PaymentMethodComboBoxAddEdit.SelectedIndex = Convert.ToInt16(member.payment_method); }
            }
            else if (mode == "新規追加")
            {
                member = new T_Member();
                member.member_id = 1 + Convert.ToInt32(handler.GetHighestIndex("Members"));
                MemberIDTextLabelAddEdit.Text = Convert.ToString(member.member_id);
            }
            else
            {
                //TODO:Implement Error handling
            }

        }
        //TODO:Implement functions
        private void RegisterButtonAddEdit_Click(object sender, EventArgs e)
        {

            if (mode == "編集")
            {
                if (AssingValues())
                {
                    handler.UpdateEntryInTable(member, "Members");
                    this.Close();
                }
            }
            else if (mode == "新規追加")
            {
                if (AssingValues())
                {
                    handler.CreateNewMemberEntry(member);
                    this.Close();
                }
            }
        }

        private void CancelButtonAddEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool AssingValues()
        {
            bool success = true;
            if (!string.IsNullOrEmpty(MailAddressTextBoxAddEdit.Text))
            {
                if(MailAddressTextBoxAddEdit.Text.Length < 129)
                {
                    member.mail = MailAddressTextBoxAddEdit.Text;
                    MailErrorLabelAddEdit.Visible = false;
                }
                else 
                { 
                    success = false;
                    MailErrorLabelAddEdit.Text = "メールアドレスは128文字までです";
                    MailErrorLabelAddEdit.Visible = true;
                }
               
            }
            else
            {
                success = false;
                MailErrorLabelAddEdit.Text = "必須です";
                MailErrorLabelAddEdit.Visible = true;
            }

            if (!string.IsNullOrEmpty(NameTextBoxAddEdit.Text))
            {
                if (NameTextBoxAddEdit.Text.Length < 21)
                {
                    member.mail = MailAddressTextBoxAddEdit.Text;
                    NameErrorLabelAddEdit.Visible = false;
                }
                else
                {
                    success = false;
                    NameErrorLabelAddEdit.Text = "氏名は20文字までです";
                    NameErrorLabelAddEdit.Visible = true;
                }

            }
            else
            {
                success = false;
                NameErrorLabelAddEdit.Text = "必須です";
                NameErrorLabelAddEdit.Visible = true;
            }
            if (!string.IsNullOrEmpty(AddressTextBoxAddEdit.Text))
            {
                if (AddressTextBoxAddEdit.Text.Length> 256)
                {
                    member.address = MailAddressTextBoxAddEdit.Text;
                    NameErrorLabelAddEdit.Visible = false;
                }
                else
                {
                    success = false;
                    AddressErrorLabelAddEdit.Text = "住所は256文字までです";
                    AddressErrorLabelAddEdit.Visible = true;
                }
            }
            else
            {
                success = false;
                AddressErrorLabelAddEdit.Text = "必須です";
                AddressErrorLabelAddEdit.Visible = true;
            }
            if (startSelected)
            {
                member.start_date = DateOnly.FromDateTime(JoinDatePickerAddEdit.Value.Date);
                JoinDateErrorLabelAddEdit.Visible = false;
            }
            else
            {
                success = false;
                JoinDateErrorLabelAddEdit.Text = "必須です";
                JoinDateErrorLabelAddEdit.Visible = true;
            }

            if (endSelected) { member.end_date = DateOnly.FromDateTime(LeaveDatePickerAddEdit.Value.Date); }
            if (PaymentMethodComboBoxAddEdit.SelectedIndex != -1)
            {
                member.payment_method = PaymentMethodComboBoxAddEdit.SelectedIndex;
                PaymentMethodErrorLabelAddEdit.Visible = false;
            }
            else
            {
                success = false;
                PaymentMethodErrorLabelAddEdit.Text = "必須です";
                PaymentMethodErrorLabelAddEdit.Visible = true;
            }

            return success;
        }

        private void JoinDatePickerAddEdit_ValueChanged(object sender, EventArgs e)
        {
            startSelected = true;
        }

        private void LeaveDatePickerAddEdit_ValueChanged(object sender, EventArgs e)
        {
            endSelected = true;
        }
    }
}
