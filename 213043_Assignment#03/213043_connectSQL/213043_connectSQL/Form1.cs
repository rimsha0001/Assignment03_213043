using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace _213043_connectSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string query;
        
        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-46PNOSO\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True");
            con.Open();
            //MessageBox.Show("connection open");
            SqlCommand cm = new SqlCommand();
            //    cm.CommandText = "Delete FROM stationay where CustName = 'pen'";
            //cm.Connection = con;
            //int inRow = cm.ExecuteNonQuery();
            //con.Close();
            //query = "Insert into stationary(ID,CustName,UnitPrice,QuantityInStock) VALUES(4,'Clipboard',2,5)";
            //SqlCommand cm1 = new SqlCommand(query, con);
            cm.CommandText = "Insert INTO stationay(ID,CustName,UnitPrice,QuantityInStock) VALUES(4,'Clipboard'','2','5')";
            cm.Connection = con;
            cm.ExecuteNonQuery();
            con.Close();
            //Console.Write("Total row Insert" + totalRowAffected + " ");

            //cm.CommandText = "select * from stationay";
            //cm.CommandText = "Delete FROM stationay where CustName = 'pen'";
            /*int totalRowAffected =*/
            //cm.executenonquery();
            //.Write("Total rows Deleted = " +)
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
