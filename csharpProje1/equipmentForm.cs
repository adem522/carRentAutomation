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
    public partial class equipmentForm : Form
    {
        public equipmentForm()
        {
            InitializeComponent();
        }
        vtIslemleri islemler1 = new vtIslemleri();
        private void equipmentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("equipment").Tables[0];
        }
    }
}
