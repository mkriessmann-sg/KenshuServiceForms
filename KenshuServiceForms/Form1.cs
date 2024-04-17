namespace KenshuServiceForms
{
    public partial class Form1 : Form
    {

        string name = null;
        string email = null;
        List<T_Member> currentMembers = new List<T_Member>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            KenshuDBHandler handler = new KenshuDBHandler();
            currentMembers = handler.SearchInMembers(name, email);
            foreach ( T_Member member in currentMembers)
            {
                ListViewItem item = new ListViewItem(member.member_id.ToString());

                item.SubItems.Add(member.mail);
                item.SubItems.Add(member.name);
                item.SubItems.Add(member.address);
                item.SubItems.Add(member.start_date.ToString());
                item.SubItems.Add((member.end_date?.ToString()));
                //TODO:Show payment method as string
                item.SubItems.Add(member.payment_method.ToString());
                result.Items.Add(item);
            }
            result.Refresh();

        }


        
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            UpdateList();
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit("êVãKí«â¡", null) ;
            addEdit.ShowDialog();
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
        }

        
    }
}
