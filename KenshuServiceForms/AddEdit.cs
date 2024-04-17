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
        string mode;
        T_Member? member;
        KenshuDBHandler handler =  new KenshuDBHandler();
        public AddEdit(string _mode, int? _memberID)
        {
            InitializeComponent();
            mode = _mode;
            this.Text = mode;
            int? memberID = _memberID;
            if (memberID.HasValue )
            {
                member= (T_Member)handler.SearchObjectInTableByID(Convert.ToInt32(memberID), "Members");
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
            }
            else if (mode == "新規追加")
            {
                member = new T_Member();
                member.member_id = Convert.ToInt32(handler.GetHighestIndex("Members"));
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
           member.mail = MailAddressTextBoxAddEdit.Text;
           member.name = NameTextBoxAddEdit.Text;
           member.address = AddressTextBoxAddEdit.Text;
           

            this.Close();
        }

        private void CancelButtonAddEdit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
