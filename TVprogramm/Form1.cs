using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Tutorial.SqlConn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Tutorial.SqlConn;
//using Tutorial.SqlConn;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace TVprogramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            /*string sql = ""
            MySqlConnection conn = DBUtils.GetDBConnection();
            // Create a Command
            MySqlCommand cmd = new MySqlCommand(sql);

            // Set connection for command.
            cmd.Connection = conn;
            conn.Open();
            */
            List<Stamp> stl2 = new List<Stamp>();
            QueryDataExample dt = new QueryDataExample();
            stl2 = dt.Query();
            String stl3 = "";
            foreach (Stamp s in stl2)
            {

                dataGridView1.Rows.Add(s.id, s.data, s.start_time, s.end_time, s.TV, s.TV_show);

                /*   stl3 = "";
                   stl3 += s.Name;
                   stl3 += s.id_stamp;
                   stl3 += s.name_stamp;
                   stl3 += s.price;
                   stl3 += s.Size;

                   stl3 += "\n";
                   label2.Text += stl3; */

            }


        }
    }
}
