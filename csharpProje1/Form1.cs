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

namespace csharpProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void InsuranceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz
            //this.Hide();// bu yani form1 gizle diyoruz
        }

        private void RentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rentTable form3 = new rentTable();
            form3.Show();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            customerTable customerTable1 = new customerTable();
            customerTable1.Show();
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carTable cartable = new carTable();
            cartable.Show();
        }

        private void ınvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rentalInvoiceForm rentalForm = new rentalInvoiceForm();
            rentalForm.Show();
        }

        private void EquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipmentForm equipment = new equipmentForm();
            equipment.Show();
        }

        private void DepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departmentForm department = new departmentForm();
            department.Show();
        }

        private void directionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directionsForm directions = new directionsForm();
            directions.Show();
        }
    }
}
