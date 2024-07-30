using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            //ClientClass client = new ClientClass();
        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_fname.Clear();
            textBox_lname.Clear();
                textBox_phone.Clear();
            textBox_city.Clear();

        }
        private void button_clean_Click(object sender, EventArgs e)
        {
            string Id = textBox_id.Text;
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string phone = textBox_phone.Text;
            string city = textBox_city.Text;


          /*  Boolean insertclient = client.insertclient(Id, fname, lname, phone, city);
            if (insertclient)
            {
                MessageBox.Show("New client save successfuly", "client Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("ERROF  client not Inserted","Error Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
                


        }

        private void Client_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void panel_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
