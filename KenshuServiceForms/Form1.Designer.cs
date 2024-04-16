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
            MainView = new ListView();
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            編集ToolStripMenuItem = new ToolStripMenuItem();
            料理一覧ToolStripMenuItem = new ToolStripMenuItem();
            管理ToolStripMenuItem = new ToolStripMenuItem();
            検索ToolStripMenuItem = new ToolStripMenuItem();
            検査条件取消ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            HomeMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MainView);
            groupBox1.Location = new Point(5, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 376);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // MainView
            // 
            MainView.AllowColumnReorder = true;
            MainView.BackColor = SystemColors.HighlightText;
            MainView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            MainView.Dock = DockStyle.Fill;
            MainView.FullRowSelect = true;
            MainView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            MainView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            MainView.Location = new Point(3, 19);
            MainView.Name = "MainView";
            MainView.Size = new Size(787, 354);
            MainView.TabIndex = 1;
            MainView.UseCompatibleStateImageBehavior = false;
            MainView.View = View.Details;
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
            // 
            // HomeMenuStrip
            // 
            HomeMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, 編集ToolStripMenuItem, 管理ToolStripMenuItem });
            HomeMenuStrip.Location = new Point(0, 0);
            HomeMenuStrip.Name = "HomeMenuStrip";
            HomeMenuStrip.Size = new Size(800, 24);
            HomeMenuStrip.TabIndex = 4;
            HomeMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 20);
            toolStripMenuItem1.Text = "ファイル";
            // 
            // 編集ToolStripMenuItem
            // 
            編集ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 料理一覧ToolStripMenuItem });
            編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            編集ToolStripMenuItem.Size = new Size(43, 20);
            編集ToolStripMenuItem.Text = "編集";
            // 
            // 料理一覧ToolStripMenuItem
            // 
            料理一覧ToolStripMenuItem.Name = "料理一覧ToolStripMenuItem";
            料理一覧ToolStripMenuItem.Size = new Size(122, 22);
            料理一覧ToolStripMenuItem.Text = "料理一覧";
            // 
            // 管理ToolStripMenuItem
            // 
            管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 検索ToolStripMenuItem, 検査条件取消ToolStripMenuItem });
            管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            管理ToolStripMenuItem.Size = new Size(43, 20);
            管理ToolStripMenuItem.Text = "管理";
            // 
            // 検索ToolStripMenuItem
            // 
            検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            検索ToolStripMenuItem.Size = new Size(146, 22);
            検索ToolStripMenuItem.Text = "検索";
            検索ToolStripMenuItem.Click += 検索ToolStripMenuItem_Click;
            // 
            // 検査条件取消ToolStripMenuItem
            // 
            検査条件取消ToolStripMenuItem.Name = "検査条件取消ToolStripMenuItem";
            検査条件取消ToolStripMenuItem.Size = new Size(146, 22);
            検査条件取消ToolStripMenuItem.Text = "検査条件取消";
            検査条件取消ToolStripMenuItem.Click += 検査条件取消ToolStripMenuItem_Click;
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
            groupBox1.ResumeLayout(false);
            HomeMenuStrip.ResumeLayout(false);
            HomeMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView MainView;
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 編集ToolStripMenuItem;
        private ToolStripMenuItem 管理ToolStripMenuItem;
        private ToolStripMenuItem 検索ToolStripMenuItem;
        private ToolStripMenuItem 検査条件取消ToolStripMenuItem;
        private ToolStripMenuItem 料理一覧ToolStripMenuItem;
    }
}
