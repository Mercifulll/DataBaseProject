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
    enum RowState
    {
        Existed,
        Modified,
        ModifiedNew,
        Deleted,
    }
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        int selectRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Source", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        { 
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw) 
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Source";
            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            database.open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) 
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
        }
        private new void Update()
        {
            database.open();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;
                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Sourse where ID_Source = {id}";
                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified) 
                {
                    var id = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var address = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update Sourse set ID_Source = '{id}', Name = '{name}', Address = '{address}' where ID_Source = '{id}'";
                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.close();
        }
        private void Edit()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            int id;
            var name = textBoxName.Text;
            var address = textBoxAddress.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBoxID.Text, out id))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, address);
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Invalid value");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxAddress.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
