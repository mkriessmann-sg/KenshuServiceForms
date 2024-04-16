namespace KenshuServiceForms
{
    partial class ChargesAddEdit
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
            EndDatePickerAddEditCharges = new DateTimePicker();
            StartDatePickerAddEditCharges = new DateTimePicker();
            CancelButtonAddEdit = new Button();
            SaveButtonAddEditCharges = new Button();
            AmountTextBoxAddEditCharges = new TextBox();
            ChargeNameTextBoxAddEditCharges = new TextBox();
            StartDateLabelAddEditCharges = new LinkLabel();
            AmountLabelAddEditCharges = new LinkLabel();
            ChargeNameLabelAddEditCharges = new LinkLabel();
            endDateLabelAddEditCharges = new Label();
            SuspendLayout();
            // 
            // EndDatePickerAddEditCharges
            // 
            EndDatePickerAddEditCharges.Location = new Point(106, 99);
            EndDatePickerAddEditCharges.Name = "EndDatePickerAddEditCharges";
            EndDatePickerAddEditCharges.Size = new Size(174, 23);
            EndDatePickerAddEditCharges.TabIndex = 40;
            // 
            // StartDatePickerAddEditCharges
            // 
            StartDatePickerAddEditCharges.Location = new Point(106, 70);
            StartDatePickerAddEditCharges.Name = "StartDatePickerAddEditCharges";
            StartDatePickerAddEditCharges.Size = new Size(174, 23);
            StartDatePickerAddEditCharges.TabIndex = 39;
            // 
            // CancelButtonAddEdit
            // 
            CancelButtonAddEdit.Location = new Point(205, 128);
            CancelButtonAddEdit.Name = "CancelButtonAddEdit";
            CancelButtonAddEdit.Size = new Size(75, 23);
            CancelButtonAddEdit.TabIndex = 36;
            CancelButtonAddEdit.Text = "キャンセル";
            CancelButtonAddEdit.UseVisualStyleBackColor = true;
            CancelButtonAddEdit.Click += CancelButtonAddEdit_Click;
            // 
            // SaveButtonAddEditCharges
            // 
            SaveButtonAddEditCharges.Location = new Point(106, 128);
            SaveButtonAddEditCharges.Name = "SaveButtonAddEditCharges";
            SaveButtonAddEditCharges.Size = new Size(75, 23);
            SaveButtonAddEditCharges.TabIndex = 35;
            SaveButtonAddEditCharges.Text = "保存";
            SaveButtonAddEditCharges.UseVisualStyleBackColor = true;
            SaveButtonAddEditCharges.Click += SaveButtonAddEditCharges_Click;
            // 
            // AmountTextBoxAddEditCharges
            // 
            AmountTextBoxAddEditCharges.Location = new Point(106, 41);
            AmountTextBoxAddEditCharges.Name = "AmountTextBoxAddEditCharges";
            AmountTextBoxAddEditCharges.Size = new Size(174, 23);
            AmountTextBoxAddEditCharges.TabIndex = 33;
            // 
            // ChargeNameTextBoxAddEditCharges
            // 
            ChargeNameTextBoxAddEditCharges.Location = new Point(106, 12);
            ChargeNameTextBoxAddEditCharges.Name = "ChargeNameTextBoxAddEditCharges";
            ChargeNameTextBoxAddEditCharges.Size = new Size(174, 23);
            ChargeNameTextBoxAddEditCharges.TabIndex = 32;
            // 
            // StartDateLabelAddEditCharges
            // 
            StartDateLabelAddEditCharges.AutoSize = true;
            StartDateLabelAddEditCharges.LinkColor = Color.Black;
            StartDateLabelAddEditCharges.Location = new Point(57, 76);
            StartDateLabelAddEditCharges.Name = "StartDateLabelAddEditCharges";
            StartDateLabelAddEditCharges.Size = new Size(43, 15);
            StartDateLabelAddEditCharges.TabIndex = 30;
            StartDateLabelAddEditCharges.TabStop = true;
            StartDateLabelAddEditCharges.Text = "加入日";
            // 
            // AmountLabelAddEditCharges
            // 
            AmountLabelAddEditCharges.AutoSize = true;
            AmountLabelAddEditCharges.LinkColor = Color.Black;
            AmountLabelAddEditCharges.Location = new Point(45, 44);
            AmountLabelAddEditCharges.Name = "AmountLabelAddEditCharges";
            AmountLabelAddEditCharges.Size = new Size(55, 15);
            AmountLabelAddEditCharges.TabIndex = 28;
            AmountLabelAddEditCharges.TabStop = true;
            AmountLabelAddEditCharges.Text = "月額料金";
            // 
            // ChargeNameLabelAddEditCharges
            // 
            ChargeNameLabelAddEditCharges.AutoSize = true;
            ChargeNameLabelAddEditCharges.LinkColor = Color.Black;
            ChargeNameLabelAddEditCharges.Location = new Point(57, 15);
            ChargeNameLabelAddEditCharges.Name = "ChargeNameLabelAddEditCharges";
            ChargeNameLabelAddEditCharges.Size = new Size(43, 15);
            ChargeNameLabelAddEditCharges.TabIndex = 27;
            ChargeNameLabelAddEditCharges.TabStop = true;
            ChargeNameLabelAddEditCharges.Text = "料金名";
            // 
            // endDateLabelAddEditCharges
            // 
            endDateLabelAddEditCharges.AutoSize = true;
            endDateLabelAddEditCharges.Location = new Point(57, 105);
            endDateLabelAddEditCharges.Name = "endDateLabelAddEditCharges";
            endDateLabelAddEditCharges.Size = new Size(43, 15);
            endDateLabelAddEditCharges.TabIndex = 26;
            endDateLabelAddEditCharges.Text = "解約日";
            // 
            // ChargesAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 191);
            Controls.Add(EndDatePickerAddEditCharges);
            Controls.Add(StartDatePickerAddEditCharges);
            Controls.Add(CancelButtonAddEdit);
            Controls.Add(SaveButtonAddEditCharges);
            Controls.Add(AmountTextBoxAddEditCharges);
            Controls.Add(ChargeNameTextBoxAddEditCharges);
            Controls.Add(StartDateLabelAddEditCharges);
            Controls.Add(AmountLabelAddEditCharges);
            Controls.Add(ChargeNameLabelAddEditCharges);
            Controls.Add(endDateLabelAddEditCharges);
            Name = "ChargesAddEdit";
            Text = "Mode";
            Load += ChargesAddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker EndDatePickerAddEditCharges;
        private DateTimePicker StartDatePickerAddEditCharges;
        private Button CancelButtonAddEdit;
        private Button SaveButtonAddEditCharges;
        private TextBox AmountTextBoxAddEditCharges;
        private TextBox ChargeNameTextBoxAddEditCharges;
        private LinkLabel StartDateLabelAddEditCharges;
        private LinkLabel AmountLabelAddEditCharges;
        private LinkLabel ChargeNameLabelAddEditCharges;
        private Label endDateLabelAddEditCharges;
    }
}