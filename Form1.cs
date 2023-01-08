namespace TestCsharpWinFormDesktopLearning6
{
    public partial class Form1 : Form
    {
        List<Person> hldPerson = new List<Person>();

        public Form1()
        {
            InitializeComponent();

            RefreshListBoxWithData();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string hldMessage = string.Empty;

            if (string.IsNullOrEmpty(txtlastname.Text.ToString()))
            {
                hldMessage = "Recheck input - last name is empty";
                MessageBox.Show(hldMessage);
            }
            else
            {
                DataAccess dp = new DataAccess();

                hldPerson = dp.GetPersonData(txtlastname.Text.ToString());

                RefreshListBoxWithData();

            }

        }
        public void RefreshListBoxWithData()
        {
            lstPerson.DataSource = hldPerson;
            lstPerson.DisplayMember = "FullNameInfo";
        }

    }
}