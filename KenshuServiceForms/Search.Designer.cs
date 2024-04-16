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
            SuspendLayout();
            // 
            // SearchMailLabel
            // 
            SearchMailLabel.AutoSize = true;
            SearchMailLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchMailLabel.Location = new Point(39, 32);
            SearchMailLabel.Name = "SearchMailLabel";
            SearchMailLabel.Size = new Size(68, 15);
            SearchMailLabel.TabIndex = 0;
            SearchMailLabel.Text = "メールアドレス";
            // 
            // SearchNameLabel
            // 
            SearchNameLabel.AutoSize = true;
            SearchNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            SearchNameLabel.Location = new Point(76, 67);
            SearchNameLabel.Name = "SearchNameLabel";
            SearchNameLabel.Size = new Size(31, 15);
            SearchNameLabel.TabIndex = 1;
            SearchNameLabel.Text = "氏名";
            // 
            // MailSearchBox
            // 
            MailSearchBox.Location = new Point(113, 29);
            MailSearchBox.Name = "MailSearchBox";
            MailSearchBox.Size = new Size(162, 23);
            MailSearchBox.TabIndex = 2;
            // 
            // NameSearchBox
            // 
            NameSearchBox.Location = new Point(113, 64);
            NameSearchBox.Name = "NameSearchBox";
            NameSearchBox.Size = new Size(162, 23);
            NameSearchBox.TabIndex = 3;
            // 
            // KensakuSearchButton
            // 
            KensakuSearchButton.ForeColor = SystemColors.ActiveCaptionText;
            KensakuSearchButton.Location = new Point(113, 108);
            KensakuSearchButton.Name = "KensakuSearchButton";
            KensakuSearchButton.Size = new Size(75, 23);
            KensakuSearchButton.TabIndex = 4;
            KensakuSearchButton.Text = "検索";
            KensakuSearchButton.UseVisualStyleBackColor = true;
            KensakuSearchButton.Click += this.KensakuSearchButton_Click;
            // 
            // CancelSearchButton
            // 
            CancelSearchButton.ForeColor = SystemColors.ActiveCaptionText;
            CancelSearchButton.Location = new Point(200, 108);
            CancelSearchButton.Name = "CancelSearchButton";
            CancelSearchButton.Size = new Size(75, 23);
            CancelSearchButton.TabIndex = 5;
            CancelSearchButton.Text = "キャンセル";
            CancelSearchButton.UseVisualStyleBackColor = true;
            CancelSearchButton.Click += CancelSearchButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(339, 161);
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
    }
}