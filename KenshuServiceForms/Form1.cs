namespace KenshuServiceForms
{
    public partial class Form1 : Form
    {

        public string? name = null;
        public string? email = null;
        List<T_Member> currentMembers = new List<T_Member>();
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateList()
        {

            result.Items.Clear();
            KenshuDBHandler handler = new KenshuDBHandler();
            currentMembers = handler.SearchInMembers(name, email);
            if (currentMembers != null)
            {
                foreach (T_Member member in currentMembers)
                {
                    ListViewItem item = new ListViewItem(member.member_id.ToString());

                    item.SubItems.Add(member.mail);
                    item.SubItems.Add(member.name);
                    item.SubItems.Add(member.address);
                    item.SubItems.Add(member.start_date.ToString());
                    item.SubItems.Add((member.end_date.ToString()));
                    //TODO:Show payment method as string
                    if (member.payment_method == 0) { item.SubItems.Add("クレジット"); }
                    if (member.payment_method == 1) { item.SubItems.Add("口座振込"); }
                    result.Items.Add(item);
                }
            }
            result.Refresh();

        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search(this);
            search.ShowDialog();
            UpdateList();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit("新規追加", null);
            addEdit.ShowDialog();
            UpdateList();
        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email = null;
            name = null;
            UpdateList();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PricemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charges charges = new Charges();
            charges.ShowDialog();
            UpdateList();
        }
        private void result_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedMemberID = 0;
            foreach (ListViewItem item in result.SelectedItems)
            {
                selectedMemberID = Convert.ToInt16(item.Text);
            }

            AddEdit addEdit = new AddEdit("編集", selectedMemberID);
            addEdit.ShowDialog();
            UpdateList();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedMemberID = 0;
            foreach (ListViewItem item in result.SelectedItems)
            {
                selectedMemberID = Convert.ToInt16(item.Text);
            }
            KenshuDBHandler handler = new KenshuDBHandler();
            handler.DeleteEntryInTable(selectedMemberID, "Members");
            UpdateList();   
        }
    }
}
