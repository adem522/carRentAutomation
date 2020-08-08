using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpProje1
{
    public partial class departmentForm : Form
    {
        public departmentForm()
        {
            InitializeComponent();
        }
        vtIslemleri islemler1 = new vtIslemleri();
        private void departmentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =islemler1.listele("department").Tables[0];
        }
    }
}
