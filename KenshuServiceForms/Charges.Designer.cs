namespace KenshuServiceForms
{
    partial class Charges
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "1", "mail＠mail.com" }, -1);
            DeleteButtonCharges = new Button();
            AddButtonCharges = new Button();
            groupBox1 = new GroupBox();
            ChargesView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ChargesCloseButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButtonCharges
            // 
            DeleteButtonCharges.Location = new Point(96, 248);
            DeleteButtonCharges.Name = "DeleteButtonCharges";
            DeleteButtonCharges.Size = new Size(75, 23);
            DeleteButtonCharges.TabIndex = 6;
            DeleteButtonCharges.Text = "削除";
            DeleteButtonCharges.UseVisualStyleBackColor = true;
            DeleteButtonCharges.Click += DeleteButtonCharges_Click;
            // 
            // AddButtonCharges
            // 
            AddButtonCharges.Location = new Point(15, 248);
            AddButtonCharges.Name = "AddButtonCharges";
            AddButtonCharges.Size = new Size(75, 23);
            AddButtonCharges.TabIndex = 5;
            AddButtonCharges.Text = "新規追加";
            AddButtonCharges.UseVisualStyleBackColor = true;
            AddButtonCharges.Click += AddButtonCharges_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChargesView);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 230);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // ChargesView
            // 
            ChargesView.AllowColumnReorder = true;
            ChargesView.BackColor = SystemColors.HighlightText;
            ChargesView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader6 });
            ChargesView.Dock = DockStyle.Fill;
            ChargesView.FullRowSelect = true;
            ChargesView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            ChargesView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ChargesView.Location = new Point(3, 19);
            ChargesView.Name = "ChargesView";
            ChargesView.Size = new Size(437, 208);
            ChargesView.TabIndex = 1;
            ChargesView.UseCompatibleStateImageBehavior = false;
            ChargesView.View = View.Details;
            ChargesView.MouseDoubleClick += ChargesView_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "料金番号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "料金名";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "月額料金";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "適用開始日";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "適用終了日";
            // 
            // ChargesCloseButton
            // 
            ChargesCloseButton.Location = new Point(377, 248);
            ChargesCloseButton.Name = "ChargesCloseButton";
            ChargesCloseButton.Size = new Size(75, 23);
            ChargesCloseButton.TabIndex = 7;
            ChargesCloseButton.Text = "閉じる";
            ChargesCloseButton.UseVisualStyleBackColor = true;
            ChargesCloseButton.Click += ChargesCloseButton_Click;
            // 
            // Charges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 292);
            Controls.Add(ChargesCloseButton);
            Controls.Add(DeleteButtonCharges);
            Controls.Add(AddButtonCharges);
            Controls.Add(groupBox1);
            Name = "Charges";
            Text = "料金一覧";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButtonCharges;
        private Button AddButtonCharges;
        private GroupBox groupBox1;
        private ListView ChargesView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button ChargesCloseButton;
    }
}