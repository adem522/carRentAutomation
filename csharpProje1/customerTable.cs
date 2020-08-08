using System;
using System.Windows.Forms;

namespace csharpProje1
{
    public partial class customerTable : Form
    {
        vtIslemleri islemler1 = new vtIslemleri();
        int id;
        public customerTable()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void customerTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("customer").Tables[0];            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {            
            try
            {
                islemler1.guncelleString("customer", "name", textBox1.Text.ToString(), id);
                islemler1.guncelleString("customer", "surname", textBox2.Text.ToString(), id);
                islemler1.guncelleString("customer", "birth_date", dateTimePicker1.Value.ToString(), id);
                islemler1.guncelleInt("customer", "driving_license_number", Convert.ToInt32(textBox3.Text), id);
            }
            catch (Exception ex)
            {
                throw;
            }
            dataGridView1.DataSource = islemler1.listele("customer").Tables[0];
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {           

            string sql = String.Format("insert into public.\"customer\"(name,surname,birth_date,driving_license_number) values ('{0}','{1}','{2}',{3})", textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), Convert.ToInt32(textBox3.Text));
            islemler1.executeSql(sql);
            dataGridView1.DataSource = islemler1.listele("customer").Tables[0];
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {            
            try
            {
                islemler1.deleteColumn("customer", id);
            }
            catch (Exception ex)
            {
                throw;
            }
            dataGridView1.DataSource = islemler1.listele("customer").Tables[0];
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchTextBox.Text=="") dataGridView1.DataSource = islemler1.listele("customer").Tables[0];

            else dataGridView1.DataSource = islemler1.aramaString("customer", "driving_license_number", searchTextBox.Text).Tables[0];
        }
    }
}
