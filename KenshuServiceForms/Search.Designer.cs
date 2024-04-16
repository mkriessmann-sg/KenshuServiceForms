namespace KenshuServiceForms
{
    partial class Search
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
            SearchMailLabel = new Label();
            SearchNameLabel = new Label();
            MailSearchBox = new TextBox();
            NameSearchBox = new TextBox();
            KensakuSearchButton = new Button();
            CancelSearchButton = new Button();
            MailErrorLabelSearch = new Label();
            NameErrorLabelSearch = new Label();
            SuspendLayout();
            // 
            // SearchMailLabel
            // 
            SearchMailLabel.AutoSize = true;
            SearchMailLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchMailLabel.Location = new Point(12, 15);
            SearchMailLabel.Name = "SearchMailLabel";
            SearchMailLabel.Size = new Size(68, 15);
            SearchMailLabel.TabIndex = 0;
            SearchMailLabel.Text = "メールアドレス";
            // 
            // SearchNameLabel
            // 
            SearchNameLabel.AutoSize = true;
            SearchNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchNameLabel.Location = new Point(49, 59);
            SearchNameLabel.Name = "SearchNameLabel";
            SearchNameLabel.Size = new Size(31, 15);
            SearchNameLabel.TabIndex = 1;
            SearchNameLabel.Text = "氏名";
            // 
            // MailSearchBox
            // 
            MailSearchBox.Location = new Point(86, 12);
            MailSearchBox.Name = "MailSearchBox";
            MailSearchBox.Size = new Size(162, 23);
            MailSearchBox.TabIndex = 2;
            MailSearchBox.TextChanged += MailSearchBox_TextChanged;
            // 
            // NameSearchBox
            // 
            NameSearchBox.Location = new Point(86, 56);
            NameSearchBox.Name = "NameSearchBox";
            NameSearchBox.Size = new Size(162, 23);
            NameSearchBox.TabIndex = 3;
            // 
            // KensakuSearchButton
            // 
            KensakuSearchButton.ForeColor = SystemColors.ActiveCaptionText;
            KensakuSearchButton.Location = new Point(89, 108);
            KensakuSearchButton.Name = "KensakuSearchButton";
            KensakuSearchButton.Size = new Size(75, 23);
            KensakuSearchButton.TabIndex = 4;
            KensakuSearchButton.Text = "検索";
            KensakuSearchButton.UseVisualStyleBackColor = true;
            KensakuSearchButton.Click += KensakuSearchButton_Click;
            // 
            // CancelSearchButton
            // 
            CancelSearchButton.ForeColor = SystemColors.ActiveCaptionText;
            CancelSearchButton.Location = new Point(173, 108);
            CancelSearchButton.Name = "CancelSearchButton";
            CancelSearchButton.Size = new Size(75, 23);
            CancelSearchButton.TabIndex = 5;
            CancelSearchButton.Text = "キャンセル";
            CancelSearchButton.UseVisualStyleBackColor = true;
            CancelSearchButton.Click += CancelSearchButton_Click;
            // 
            // MailErrorLabelSearch
            // 
            MailErrorLabelSearch.AutoSize = true;
            MailErrorLabelSearch.ForeColor = Color.Red;
            MailErrorLabelSearch.Location = new Point(86, 38);
            MailErrorLabelSearch.Name = "MailErrorLabelSearch";
            MailErrorLabelSearch.Size = new Size(78, 15);
            MailErrorLabelSearch.TabIndex = 28;
            MailErrorLabelSearch.Text = "ErrorMessage";
            MailErrorLabelSearch.Visible = false;
            // 
            // NameErrorLabelSearch
            // 
            NameErrorLabelSearch.AutoSize = true;
            NameErrorLabelSearch.ForeColor = Color.Red;
            NameErrorLabelSearch.Location = new Point(86, 82);
            NameErrorLabelSearch.Name = "NameErrorLabelSearch";
            NameErrorLabelSearch.Size = new Size(78, 15);
            NameErrorLabelSearch.TabIndex = 29;
            NameErrorLabelSearch.Text = "ErrorMessage";
            NameErrorLabelSearch.Visible = false;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(313, 154);
            Controls.Add(NameErrorLabelSearch);
            Controls.Add(MailErrorLabelSearch);
            Controls.Add(CancelSearchButton);
            Controls.Add(KensakuSearchButton);
            Controls.Add(NameSearchBox);
            Controls.Add(MailSearchBox);
            Controls.Add(SearchNameLabel);
            Controls.Add(SearchMailLabel);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Search";
            Text = "検索";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchMailLabel;
        private Label SearchNameLabel;
        private TextBox MailSearchBox;
        private TextBox NameSearchBox;
        private Button KensakuSearchButton;
        private Button CancelSearchButton;
        private Label MailErrorLabelSearch;
        private Label NameErrorLabelSearch;
    }
}