using System;
using System.Windows.Forms;

namespace csharpProje1
{
    public partial class carTable : Form
    {
        public carTable()
        {
            InitializeComponent();
        }

        vtIslemleri islemler1 = new vtIslemleri();
        int id;
        private void carTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("car").Tables[0];
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox10.Text = islemler1.oneDataReturnWithWhere("car_category", "name", "id", Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value));
            textBox11.Text = islemler1.oneDataReturnWithWhere("location", "city", "id", Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value));
        }
    }
}
