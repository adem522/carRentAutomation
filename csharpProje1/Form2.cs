using Npgsql;
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
namespace csharpProje1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        vtIslemleri islemler1 = new vtIslemleri();
        //form load olurken gridviewi dolduruyor
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("insurance").Tables[0];
        }
        //textboxlara aktarma
        int id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Textboxları boşaltma
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        //Ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            
            islemler1.executeSql(String.Format("insert into public.\"insurance\"(name,description,cost) values ('{0}','{1}',{2})",textBox1.Text,textBox2.Text,Convert.ToInt32(textBox3.Text)));
            dataGridView1.DataSource = islemler1.listele("insurance").Tables[0];
        }

        //Silme
        private void button2_Click(object sender, EventArgs e)
        {
            islemler1.deleteColumn("insurance", id);
            dataGridView1.DataSource = islemler1.listele("insurance").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islemler1.guncelleString("insurance", "name", textBox1.Text, id);
            islemler1.guncelleString("insurance", "description", textBox2.Text, id);
            islemler1.guncelleInt("insurance", "cost", Convert.ToInt32(textBox3.Text), id);
            dataGridView1.DataSource=islemler1.listele("insurance").Tables[0];
        }
    }
}
