namespace KenshuServiceForms
{
    partial class AddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MemberIDLabelAddEdit = new Label();
            LeaveDateLabelAddEdit = new Label();
            MailAddressAddEditLabel = new LinkLabel();
            NameLabelAddEdit = new LinkLabel();
            AddressLabelAddEdit = new LinkLabel();
            JoinDateLabelAddEdit = new LinkLabel();
            PaymentMethodLabelAddEdit = new LinkLabel();
            MailAddressTextBoxAddEdit = new TextBox();
            NameTextBoxAddEdit = new TextBox();
            AddressTextBoxAddEdit = new TextBox();
            RegisterButtonAddEdit = new Button();
            CancelButtonAddEdit = new Button();
            PaymentMethodComboBoxAddEdit = new ComboBox();
            MemberIDTextLabelAddEdit = new Label();
            JoinDatePickerAddEdit = new DateTimePicker();
            LeaveDatePickerAddEdit = new DateTimePicker();
            MailErrorLabelAddEdit = new Label();
            NameErrorLabelAddEdit = new Label();
            AddressErrorLabelAddEdit = new Label();
            JoinDateErrorLabelAddEdit = new Label();
            PaymentMethodErrorLabelAddEdit = new Label();
            SuspendLayout();
            // 
            // MemberIDLabelAddEdit
            // 
            MemberIDLabelAddEdit.AutoSize = true;
            MemberIDLabelAddEdit.Location = new Point(30, 9);
            MemberIDLabelAddEdit.Name = "MemberIDLabelAddEdit";
            MemberIDLabelAddEdit.Size = new Size(54, 15);
            MemberIDLabelAddEdit.TabIndex = 0;
            MemberIDLabelAddEdit.Text = "加入者ID";
            // 
            // LeaveDateLabelAddEdit
            // 
            LeaveDateLabelAddEdit.AutoSize = true;
            LeaveDateLabelAddEdit.Location = new Point(50, 222);
            LeaveDateLabelAddEdit.Name = "LeaveDateLabelAddEdit";
            LeaveDateLabelAddEdit.Size = new Size(43, 15);
            LeaveDateLabelAddEdit.TabIndex = 6;
            LeaveDateLabelAddEdit.Text = "解約日";
            // 
            // MailAddressAddEditLabel
            // 
            MailAddressAddEditLabel.AutoSize = true;
            MailAddressAddEditLabel.LinkColor = Color.Black;
            MailAddressAddEditLabel.Location = new Point(25, 43);
            MailAddressAddEditLabel.Name = "MailAddressAddEditLabel";
            MailAddressAddEditLabel.Size = new Size(68, 15);
            MailAddressAddEditLabel.TabIndex = 8;
            MailAddressAddEditLabel.TabStop = true;
            MailAddressAddEditLabel.Text = "メールアドレス";
            // 
            // NameLabelAddEdit
            // 
            NameLabelAddEdit.AutoSize = true;
            NameLabelAddEdit.LinkColor = Color.Black;
            NameLabelAddEdit.Location = new Point(62, 92);
            NameLabelAddEdit.Name = "NameLabelAddEdit";
            NameLabelAddEdit.Size = new Size(31, 15);
            NameLabelAddEdit.TabIndex = 9;
            NameLabelAddEdit.TabStop = true;
            NameLabelAddEdit.Text = "氏名";
            // 
            // AddressLabelAddEdit
            // 
            AddressLabelAddEdit.AutoSize = true;
            AddressLabelAddEdit.LinkColor = Color.Black;
            AddressLabelAddEdit.Location = new Point(62, 131);
            AddressLabelAddEdit.Name = "AddressLabelAddEdit";
            AddressLabelAddEdit.Size = new Size(31, 15);
            AddressLabelAddEdit.TabIndex = 10;
            AddressLabelAddEdit.TabStop = true;
            AddressLabelAddEdit.Text = "住所";
            // 
            // JoinDateLabelAddEdit
            // 
            JoinDateLabelAddEdit.AutoSize = true;
            JoinDateLabelAddEdit.LinkColor = Color.Black;
            JoinDateLabelAddEdit.Location = new Point(50, 178);
            JoinDateLabelAddEdit.Name = "JoinDateLabelAddEdit";
            JoinDateLabelAddEdit.Size = new Size(43, 15);
            JoinDateLabelAddEdit.TabIndex = 11;
            JoinDateLabelAddEdit.TabStop = true;
            JoinDateLabelAddEdit.Text = "加入日";
            // 
            // PaymentMethodLabelAddEdit
            // 
            PaymentMethodLabelAddEdit.AutoSize = true;
            PaymentMethodLabelAddEdit.LinkColor = Color.Black;
            PaymentMethodLabelAddEdit.Location = new Point(38, 254);
            PaymentMethodLabelAddEdit.Name = "PaymentMethodLabelAddEdit";
            PaymentMethodLabelAddEdit.Size = new Size(55, 15);
            PaymentMethodLabelAddEdit.TabIndex = 12;
            PaymentMethodLabelAddEdit.TabStop = true;
            PaymentMethodLabelAddEdit.Text = "決済方法";
            // 
            // MailAddressTextBoxAddEdit
            // 
            MailAddressTextBoxAddEdit.Location = new Point(99, 40);
            MailAddressTextBoxAddEdit.Name = "MailAddressTextBoxAddEdit";
            MailAddressTextBoxAddEdit.Size = new Size(174, 23);
            MailAddressTextBoxAddEdit.TabIndex = 13;
            // 
            // NameTextBoxAddEdit
            // 
            NameTextBoxAddEdit.Location = new Point(99, 84);
            NameTextBoxAddEdit.Name = "NameTextBoxAddEdit";
            NameTextBoxAddEdit.Size = new Size(174, 23);
            NameTextBoxAddEdit.TabIndex = 14;
            // 
            // AddressTextBoxAddEdit
            // 
            AddressTextBoxAddEdit.Location = new Point(99, 128);
            AddressTextBoxAddEdit.Name = "AddressTextBoxAddEdit";
            AddressTextBoxAddEdit.Size = new Size(174, 23);
            AddressTextBoxAddEdit.TabIndex = 15;
            // 
            // RegisterButtonAddEdit
            // 
            RegisterButtonAddEdit.Location = new Point(99, 303);
            RegisterButtonAddEdit.Name = "RegisterButtonAddEdit";
            RegisterButtonAddEdit.Size = new Size(75, 23);
            RegisterButtonAddEdit.TabIndex = 19;
            RegisterButtonAddEdit.Text = "登録";
            RegisterButtonAddEdit.UseVisualStyleBackColor = true;
            RegisterButtonAddEdit.Click += RegisterButtonAddEdit_Click;
            // 
            // CancelButtonAddEdit
            // 
            CancelButtonAddEdit.Location = new Point(198, 303);
            CancelButtonAddEdit.Name = "CancelButtonAddEdit";
            CancelButtonAddEdit.Size = new Size(75, 23);
            CancelButtonAddEdit.TabIndex = 20;
            CancelButtonAddEdit.Text = "キャンセル";
            CancelButtonAddEdit.UseVisualStyleBackColor = true;
            CancelButtonAddEdit.Click += CancelButtonAddEdit_Click;
            // 
            // PaymentMethodComboBoxAddEdit
            // 
            PaymentMethodComboBoxAddEdit.FormattingEnabled = true;
            PaymentMethodComboBoxAddEdit.Items.AddRange(new object[] { "クレジット", "口座振込" });
            PaymentMethodComboBoxAddEdit.Location = new Point(99, 251);
            PaymentMethodComboBoxAddEdit.Name = "PaymentMethodComboBoxAddEdit";
            PaymentMethodComboBoxAddEdit.Size = new Size(174, 23);
            PaymentMethodComboBoxAddEdit.TabIndex = 21;
            // 
            // MemberIDTextLabelAddEdit
            // 
            MemberIDTextLabelAddEdit.AutoSize = true;
            MemberIDTextLabelAddEdit.Location = new Point(99, 9);
            MemberIDTextLabelAddEdit.Name = "MemberIDTextLabelAddEdit";
            MemberIDTextLabelAddEdit.Size = new Size(32, 15);
            MemberIDTextLabelAddEdit.TabIndex = 22;
            MemberIDTextLabelAddEdit.Text = "Error";
            // 
            // JoinDatePickerAddEdit
            // 
            JoinDatePickerAddEdit.Location = new Point(99, 172);
            JoinDatePickerAddEdit.Name = "JoinDatePickerAddEdit";
            JoinDatePickerAddEdit.Size = new Size(174, 23);
            JoinDatePickerAddEdit.TabIndex = 23;
            JoinDatePickerAddEdit.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            JoinDatePickerAddEdit.ValueChanged += JoinDatePickerAddEdit_ValueChanged;
            // 
            // LeaveDatePickerAddEdit
            // 
            LeaveDatePickerAddEdit.Location = new Point(99, 216);
            LeaveDatePickerAddEdit.Name = "LeaveDatePickerAddEdit";
            LeaveDatePickerAddEdit.Size = new Size(174, 23);
            LeaveDatePickerAddEdit.TabIndex = 24;
            LeaveDatePickerAddEdit.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            LeaveDatePickerAddEdit.ValueChanged += LeaveDatePickerAddEdit_ValueChanged;
            // 
            // MailErrorLabelAddEdit
            // 
            MailErrorLabelAddEdit.AutoSize = true;
            MailErrorLabelAddEdit.ForeColor = Color.Red;
            MailErrorLabelAddEdit.Location = new Point(99, 66);
            MailErrorLabelAddEdit.Name = "MailErrorLabelAddEdit";
            MailErrorLabelAddEdit.Size = new Size(78, 15);
            MailErrorLabelAddEdit.TabIndex = 27;
            MailErrorLabelAddEdit.Text = "ErrorMessage";
            MailErrorLabelAddEdit.Visible = false;
            // 
            // NameErrorLabelAddEdit
            // 
            NameErrorLabelAddEdit.AutoSize = true;
            NameErrorLabelAddEdit.ForeColor = Color.Red;
            NameErrorLabelAddEdit.Location = new Point(99, 110);
            NameErrorLabelAddEdit.Name = "NameErrorLabelAddEdit";
            NameErrorLabelAddEdit.Size = new Size(78, 15);
            NameErrorLabelAddEdit.TabIndex = 28;
            NameErrorLabelAddEdit.Text = "ErrorMessage";
            NameErrorLabelAddEdit.Visible = false;
            // 
            // AddressErrorLabelAddEdit
            // 
            AddressErrorLabelAddEdit.AutoSize = true;
            AddressErrorLabelAddEdit.ForeColor = Color.Red;
            AddressErrorLabelAddEdit.Location = new Point(99, 154);
            AddressErrorLabelAddEdit.Name = "AddressErrorLabelAddEdit";
            AddressErrorLabelAddEdit.Size = new Size(78, 15);
            AddressErrorLabelAddEdit.TabIndex = 29;
            AddressErrorLabelAddEdit.Text = "ErrorMessage";
            AddressErrorLabelAddEdit.Visible = false;
            // 
            // JoinDateErrorLabelAddEdit
            // 
            JoinDateErrorLabelAddEdit.AutoSize = true;
            JoinDateErrorLabelAddEdit.ForeColor = Color.Red;
            JoinDateErrorLabelAddEdit.Location = new Point(99, 198);
            JoinDateErrorLabelAddEdit.Name = "JoinDateErrorLabelAddEdit";
            JoinDateErrorLabelAddEdit.Size = new Size(78, 15);
            JoinDateErrorLabelAddEdit.TabIndex = 30;
            JoinDateErrorLabelAddEdit.Text = "ErrorMessage";
            JoinDateErrorLabelAddEdit.Visible = false;
            // 
            // PaymentMethodErrorLabelAddEdit
            // 
            PaymentMethodErrorLabelAddEdit.AutoSize = true;
            PaymentMethodErrorLabelAddEdit.ForeColor = Color.Red;
            PaymentMethodErrorLabelAddEdit.Location = new Point(99, 277);
            PaymentMethodErrorLabelAddEdit.Name = "PaymentMethodErrorLabelAddEdit";
            PaymentMethodErrorLabelAddEdit.Size = new Size(78, 15);
            PaymentMethodErrorLabelAddEdit.TabIndex = 31;
            PaymentMethodErrorLabelAddEdit.Text = "ErrorMessage";
            PaymentMethodErrorLabelAddEdit.Visible = false;
            // 
            // AddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 351);
            Controls.Add(PaymentMethodErrorLabelAddEdit);
            Controls.Add(JoinDateErrorLabelAddEdit);
            Controls.Add(AddressErrorLabelAddEdit);
            Controls.Add(NameErrorLabelAddEdit);
            Controls.Add(MailErrorLabelAddEdit);
            Controls.Add(LeaveDatePickerAddEdit);
            Controls.Add(JoinDatePickerAddEdit);
            Controls.Add(MemberIDTextLabelAddEdit);
            Controls.Add(PaymentMethodComboBoxAddEdit);
            Controls.Add(CancelButtonAddEdit);
            Controls.Add(RegisterButtonAddEdit);
            Controls.Add(AddressTextBoxAddEdit);
            Controls.Add(NameTextBoxAddEdit);
            Controls.Add(MailAddressTextBoxAddEdit);
            Controls.Add(PaymentMethodLabelAddEdit);
            Controls.Add(JoinDateLabelAddEdit);
            Controls.Add(AddressLabelAddEdit);
            Controls.Add(NameLabelAddEdit);
            Controls.Add(MailAddressAddEditLabel);
            Controls.Add(LeaveDateLabelAddEdit);
            Controls.Add(MemberIDLabelAddEdit);
            Name = "AddEdit";
            Text = "Add";
            Load += AddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemberIDLabelAddEdit;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LeaveDateLabelAddEdit;
        private Label label8;
        private LinkLabel MailAddressAddEditLabel;
        private LinkLabel NameLabelAddEdit;
        private LinkLabel AddressLabelAddEdit;
        private LinkLabel JoinDateLabelAddEdit;
        private LinkLabel PaymentMethodLabelAddEdit;
        private TextBox MailAddressTextBoxAddEdit;
        private TextBox NameTextBoxAddEdit;
        private TextBox AddressTextBoxAddEdit;
        private Button RegisterButtonAddEdit;
        private Button CancelButtonAddEdit;
        private ComboBox PaymentMethodComboBoxAddEdit;
        private Label MemberIDTextLabelAddEdit;
        private DateTimePicker JoinDatePickerAddEdit;
        private DateTimePicker LeaveDatePickerAddEdit;
        private Label MailErrorLabelAddEdit;
        private Label NameErrorLabelAddEdit;
        private Label AddressErrorLabelAddEdit;
        private Label JoinDateErrorLabelAddEdit;
        private Label PaymentMethodErrorLabelAddEdit;
    }
}