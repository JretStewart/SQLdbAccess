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


namespace _9_1FamilyDB
{
    public partial class Form1 : Form
    {
        #region
        private SqlConnection dbCon;
        private string sConnection;
        private SqlCommand dbCmd;
        private string sql;
        private SqlDataReader dbReader;
        private Family famDB;
        private Member aMember;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        //declare variables for clock
        int hour, min, sec, ms = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //check for connection before reseting clock
            if(lblCon.Text == "Connection Closed")
            {
                resetClock();
            }//end if


            try
            {
                //declare sConnection 
                sConnection =
               "Data Source=" + tbServer.Text + ";" +
               "Initial Catalog=" + tbUser.Text + ";" +
               "Integrated Security=True";

                //establish connection with server
                dbCon = new SqlConnection(sConnection);
                dbCon.Open();
                timer1.Start();//start timer

                //set command
                lblCon.Text = "Connection Open";
                sql = "SELECT * FROM FamilyDB " +
                    "ORDER BY LastName ASC;";

                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;

                dbCmd.Connection = dbCon;
                dbReader = dbCmd.ExecuteReader();
                
                while (dbReader.Read())
                {
                    famDB = new Family(dbReader["LastName"].ToString(), dbReader["FirstName"].ToString(),
                         dbReader["Age"].ToString(), dbReader["Relationship"].ToString(), dbReader["CurrentCity"].ToString());
                    dgView.DataSource = (famDB);
                }
            }
            



            catch (System.Exception exc)
            {

                lblExc.Text = exc.Message; //display exception in label
            }
            //end family if
            
            

        }
        /// <summary>
        /// create connection timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //set timer to ToString()
            lblTimer.Text = hour + "h:" + min + "m:" + sec.ToString() + "s";
            ms++;
           
            if (ms>15)
            {
                sec++;
                ms = 0;
                if (sec == 20 && min ==0)
                {
                    MessageBox.Show("Your Connection is Still Open");//warn user of open connection
                }
            }
            else
            {
                ms++;
            }
            if (sec > 59)
            {
                min++;
                sec = 0;
            }
            
            if (min > 59)
            {
                hour++;
                min = 0;
            }
            if (sec % 2 == 0)
            {
                lblCon.BackColor = Color.Green;
            }
            else
            {
                lblCon.BackColor = Color.Transparent;
            }
            

        }
        /// <summary>
        /// close connection with server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClose_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();//kill timer
                lblCon.BackColor = Color.Transparent;
                dbReader.Close();
                dbCon.Close();
                lblCon.Text = "Connection Closed";
            }
            catch(System.Exception)
            {
                MessageBox.Show("Connection is not Open");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// reset clock when initialized
        /// </summary>
        public void resetClock()
        {
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;
        }
    }
}
