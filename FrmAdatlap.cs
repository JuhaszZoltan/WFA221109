using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA221109.Properties;

namespace WFA221109
{
    public partial class FrmAdatlap : Form
    {
        private Dictionary<int, string> fajtaIDs = new();
        private Dictionary<int, string> tenyesztoIDs = new();
        private int selectedFajtaId = -1;
        private int selectedTenyesztoId = -1;

        public FrmAdatlap() => InitializeComponent();

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            string sqlCmdStr = "SELECT id, nev FROM fajta ORDER BY nev;";
            var reader = new SqlCommand(sqlCmdStr, conn).ExecuteReader();
            while (reader.Read())
                fajtaIDs.Add(reader.GetInt32(0), reader.GetString(1));


            reader.Close();
            sqlCmdStr = "SELECT id, nev FROM tenyeszto ORDER BY nev;";
            reader = new SqlCommand(sqlCmdStr, conn).ExecuteReader();
            while (reader.Read())
                tenyesztoIDs.Add(reader.GetInt32(0), reader.GetString(1));

            foreach (var nev in fajtaIDs.Values)
                cbFajtak.Items.Add(nev);
            cbFajtak.SelectedIndex = 0;

            foreach (var nev in tenyesztoIDs.Values)
                cbTulajdonosok.Items.Add(nev);
            cbTulajdonosok.SelectedIndex = 0;
        }

        private void CbFajtak_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFajtaId = fajtaIDs.Single(x => x.Value == cbFajtak.Text).Key;

            pbKep.Image = cbFajtak.Text switch
            {
                "dapper"  => Resources.dapper,
                "hipster" => Resources.hipster,
                "ninja"   => Resources.ninja,
                "nyan"    => Resources.nyan,
                "robot"   => Resources.robot,
                "zombie"  => Resources.zombie,
            };
            MessageBox.Show(selectedFajtaId + "");
        }

        private void CbTulajdonosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTenyesztoId = tenyesztoIDs.Single(x => x.Value == cbTulajdonosok.Text).Key;
            
        }
    }
}
