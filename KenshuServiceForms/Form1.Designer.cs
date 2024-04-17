namespace KenshuServiceForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "1", "mail＠mail.com" }, -1);
            groupBox1 = new GroupBox();
            result = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            AddButton = new Button();
            DeleteButton = new Button();
            HomeMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            QuitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            SearchToolStripMenuItem = new ToolStripMenuItem();
            ClearToolStripMenuItem = new ToolStripMenuItem();
            ManagementToolStripMenuItem = new ToolStripMenuItem();
            PricemanToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            HomeMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(result);
            groupBox1.Location = new Point(5, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 376);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // result
            // 
            result.AllowColumnReorder = true;
            result.BackColor = SystemColors.HighlightText;
            result.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            result.Dock = DockStyle.Fill;
            result.FullRowSelect = true;
            result.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            result.Items.AddRange(new ListViewItem[] { listViewItem1 });
            result.Location = new Point(3, 19);
            result.Name = "result";
            result.Size = new Size(787, 354);
            result.TabIndex = 1;
            result.UseCompatibleStateImageBehavior = false;
            result.View = View.Details;
            result.MouseDoubleClick += result_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "加入者番号";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "メールアドレス";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "氏名";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "住所";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "加入日";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "解約日";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "決済方法";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 406);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "新規追加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(93, 406);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "削除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // HomeMenuStrip
            // 
            HomeMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, ManagementToolStripMenuItem });
            HomeMenuStrip.Location = new Point(0, 0);
            HomeMenuStrip.Name = "HomeMenuStrip";
            HomeMenuStrip.Size = new Size(800, 24);
            HomeMenuStrip.TabIndex = 4;
            HomeMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QuitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(53, 20);
            FileToolStripMenuItem.Text = "ファイル";
            // 
            // QuitToolStripMenuItem
            // 
            QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            QuitToolStripMenuItem.Size = new Size(98, 22);
            QuitToolStripMenuItem.Text = "終了";
            QuitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SearchToolStripMenuItem, ClearToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(43, 20);
            EditToolStripMenuItem.Text = "編集";
            // 
            // SearchToolStripMenuItem
            // 
            SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            SearchToolStripMenuItem.Size = new Size(146, 22);
            SearchToolStripMenuItem.Text = "検索";
            SearchToolStripMenuItem.Click += SearchToolStripMenuItem_Click;
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.Size = new Size(146, 22);
            ClearToolStripMenuItem.Text = "検査条件解除";
            ClearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
            // 
            // ManagementToolStripMenuItem
            // 
            ManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PricemanToolStripMenuItem });
            ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem";
            ManagementToolStripMenuItem.Size = new Size(43, 20);
            ManagementToolStripMenuItem.Text = "管理";
            // 
            // PricemanToolStripMenuItem
            // 
            PricemanToolStripMenuItem.Name = "PricemanToolStripMenuItem";
            PricemanToolStripMenuItem.Size = new Size(122, 22);
            PricemanToolStripMenuItem.Text = "料金情報";
            PricemanToolStripMenuItem.Click += PricemanToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(groupBox1);
            Controls.Add(HomeMenuStrip);
            MainMenuStrip = HomeMenuStrip;
            Name = "Form1";
            Text = "社内研修用サービス管理システム";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            HomeMenuStrip.ResumeLayout(false);
            HomeMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView result;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button AddButton;
        private Button DeleteButton;
        private MenuStrip HomeMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem ManagementToolStripMenuItem;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private ToolStripMenuItem SearchToolStripMenuItem;
        private ToolStripMenuItem ClearToolStripMenuItem;
        private ToolStripMenuItem PricemanToolStripMenuItem;
    }
}
