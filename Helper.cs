using System.Configuration;

namespace TestCsharpWinFormDesktopLearning6
{
    public class Helper
    {
        //field name
        private string _name = string.Empty;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Constructor
        public Helper()
        {
        }

        public Helper(string name)
        {
            this._name = name;
        }

        public string GetConnectionString()
        {
            string hldConnectString2 = string.Empty;
            string message = string.Empty;

            hldConnectString2 = ConfigurationManager.ConnectionStrings[_name].ConnectionString;


            if (string.IsNullOrEmpty(hldConnectString2))
            {
                message = "Connections string is invalid";
                MessageBox.Show(message);
            }

            return hldConnectString2;
        }
    }
}
