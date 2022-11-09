using Microsoft.Data.SqlClient;
using WFA221109.Properties;

namespace WFA221109
{
    public partial class FrmMain : Form
    {
        public FrmMain() => InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();

            string sqlcmdstr = 
                "SELECT unikornis.id, fajta.nev, tenyeszto.nev, varos, suly, nem " +
                "FROM unikornis " +
                "INNER JOIN fajta ON fajtaId = fajta.id " +
                "INNER JOIN tenyeszto ON tulajdonosId = tenyeszto.id " +
                "ORDER BY unikornis.id ASC;";

            var reader = new SqlCommand(sqlcmdstr, conn)
                .ExecuteReader();

            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader[0],
                    reader[1],
                    reader[2],
                    reader[3],
                    $"{reader[4]} Kg",
                    reader.GetBoolean(5) ? "csõdör" : "kanca");
            }
        }

        private void TsmiBejelentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ = new FrmAdatlap().ShowDialog();
            this.Show();
        }
    }
}