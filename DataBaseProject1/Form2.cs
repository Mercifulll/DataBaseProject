using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject1
{
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.open();

            int ID;
            var name = textBoxName2.Text;
            var address = textBoxAddress2.Text;
            if (int.TryParse(textBoxID2.Text, out ID))
            {
                var addQuery = $"insert into Source (ID_Source, Name, Address) values ('{ID}','{name}','{address}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully created!","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
