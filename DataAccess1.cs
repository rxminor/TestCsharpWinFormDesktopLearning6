using Dapper;
using System.Data;

namespace TestCsharpWinFormDesktopLearning6
{
    public class DataAccess1
    {
        public DataAccess1()
        {
        }

        public List<Person> GetPersonData(string LastName)
        {
            //constructor

            string hldMessage = string.Empty;

            List<Person> hldPerson1 = new List<Person>();

            List<Person> hldPerson2 = new List<Person>();

            Helper1 hldHelper1 = new Helper1();

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper1.GetConnectionString("MyAdventureDB")))
                {

                    try
                    {
                        hldPerson1 = connection.Query<Person>($"SELECT * FROM PERSON.PERSON WHERE LastName = '{LastName}'").ToList();

                        hldPerson2 = hldPerson1;

                        // hldMessage = "Database is okay"; ;
                        // MessageBox.Show(hldMessage);

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
