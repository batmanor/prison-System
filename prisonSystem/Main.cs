using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace prisonSystem
{
    public static class Main
    {
        public static string username { get; set; } = "system";
        public static string password { get; set; } = "o";
        public static string deviceName { get; set; } = "DESKTOP-OVOP2UP";
        public static string serviceName { get; set; } = "orcl";
        public static string connectionString => $"Data Source={deviceName}/{serviceName};User ID={username};Password={password};Unicode=True";
        public static void commit()
        {
            using (OracleConnection connection = new OracleConnection(Main.connectionString)) 
            {
                connection.Open();
                OracleCommand command = new OracleCommand("commit", connection);
                    command.ExecuteNonQuery();
                
            }
        }

        public static void LoadData(string query, DataGridView dataGrid) // no more adding dis func everywhere!!! (just learned that i can get the winforms things as parameters....
        {
            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);
                    dataGrid.DataSource = dtable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error in Main.LoadData function. \n\n\n The full error in oracle:\n\t" + ex.Message);
                }
            }
        }
    }
}
