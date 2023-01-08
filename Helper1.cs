using System.Configuration;

namespace TestCsharpWinFormDesktopLearning6
{
    public class Helper1
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
        public Helper1()
        {
        }

        public Helper1(string name)
        {
            this._name = name;
        }
        public static string GetConnectionString(string _name)
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
