using Dapper;
using System.Data;

namespace TestCsharpWinFormDesktopLearning6
{
    public class DataAccess
    {
        public DataAccess()
        {
        }

        public List<Person> GetPersonData(string LastName)
        {
            //constructor

            string hldMessage = string.Empty;

            List<Person> hldPerson1 = new List<Person>();

            List<Person> hldPerson2 = new List<Person>();

            Helper hldHelper = new Helper("MyAdventureDB");

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(hldHelper.GetConnectionString()))
                {

                    try
                    {
                        hldPerson1 = connection.Query<Person>($"SELECT * FROM PERSON.PERSON WHERE LastName = '{LastName}'").ToList();
                        hldMessage = "Database is okay"; ;
                        MessageBox.Show(hldMessage);

                        hldPerson2 = hldPerson1;

                    }
                    catch (Exception ex)
                    {
                        hldMessage = "Connection error " + ex.Message;
                        MessageBox.Show(hldMessage);

                    }
                }
            }
            catch (Exception ex)
            {
                hldMessage = ex.Message;
                MessageBox.Show(hldMessage);
            }

            return hldPerson2;

        }


    }

}

