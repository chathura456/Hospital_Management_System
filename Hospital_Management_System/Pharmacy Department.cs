using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Pharmacist_Department : Form
    {
        public Pharmacist_Department()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pharmacist_Department_Load(object sender, EventArgs e)
        {
            textBox1.Text=DBconnection.id;  
            textBox2.Text=DBconnection.name;    
            textBox3.Text=DBconnection.phoneNumber;

            //display data in datagridView

            DBconnection.DisplayUser("SELECT * FROM patientlab", dataGridView1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        //datagridview action
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Shoe patient profile

                DBconnection.showProfile(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                ProfilePatient profilePatient = new ProfilePatient();
                profilePatient.Show();


                return;
            }
        }
        //log out button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }
    }
}
