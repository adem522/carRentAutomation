using System;
using System.Data;
using System.Windows.Forms;
namespace csharpProje1
{
    public partial class rentTable : Form
    {
        public rentTable()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
        }
        vtIslemleri islemler1 = new vtIslemleri();
        DataTable tempDataTable = new DataTable();
        int id;
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("rental").Tables[0];
            tempDataTable = islemler1.comboFill("customer", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                comboBox2.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());//arama için doldurma
            }

            tempDataTable = islemler1.comboFill("car_category", "name");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                carCategoryComboBox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
            }
            tempDataTable = islemler1.comboFill("car", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                comboBox3.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
            }
            tempDataTable = islemler1.comboFill("location", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                pickUpLocationCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
            }
            tempDataTable = islemler1.comboFill("location", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                dropOffLocationCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
            }
            tempDataTable = islemler1.comboFill("equipment", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                equipmentCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                comboBox4.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());//arama için doldurma
            }
            tempDataTable = islemler1.comboFill("insurance", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                insuranceCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                comboBox5.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());//arama için doldurma

            }
            tempDataTable = islemler1.comboFill("department", "id");
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                departmentCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
            }
        }

        private void carCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected index 0 dan başladığı için 1 ekleme yaptım
            tempDataTable = islemler1.comboFillWithWhere("car", "brand", "car_category_id", (carCategoryComboBox.SelectedIndex + 1).ToString());
            brandCombobox.Items.Clear(); brandCombobox.Text = ""; modelCombobox.Text = ""; plateCombobox.Text = "";
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                //combobox2 nin içerisinde aynı itemden 2 tane oluşmaması için kontrol
                if (!brandCombobox.Items.Contains(tempDataTable.Rows[i].ItemArray[0].ToString()))
                {
                    brandCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void brandCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelCombobox.Items.Clear(); modelCombobox.Text = ""; plateCombobox.Text = "";
            tempDataTable = islemler1.comboFillWith2Where("car", "model", "brand", brandCombobox.Text, "car_category_id", (carCategoryComboBox.SelectedIndex + 1).ToString());
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                if (!modelCombobox.Items.Contains(tempDataTable.Rows[i].ItemArray[0].ToString()))
                {
                    modelCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                }
            }
        }
        private void modelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            plateCombobox.Items.Clear(); plateCombobox.Text = "";
            tempDataTable = islemler1.comboFillWith3Where("car", "license_plate", "model", modelCombobox.Text, "brand", brandCombobox.Text, "car_category_id", (carCategoryComboBox.SelectedIndex + 1).ToString());
            for (int i = 0; i < tempDataTable.Rows.Count; i++)
            {
                if (!plateCombobox.Items.Contains(tempDataTable.Rows[i].ItemArray[0].ToString()))
                {
                    plateCombobox.Items.Add(tempDataTable.Rows[i].ItemArray[0].ToString());
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            int car_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dateTimePicker3.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            carCategoryComboBox.Text = islemler1.oneDataReturnWithWhere("car_category", "name", "id", Convert.ToInt32(islemler1.oneDataReturnWithWhere("car", "car_category_id", "id", car_id)));
            brandCombobox.Text = islemler1.oneDataReturnWithWhere("car", "brand", "id", car_id);
            modelCombobox.Text = islemler1.oneDataReturnWithWhere("car", "model", "id", car_id);
            plateCombobox.Text = islemler1.oneDataReturnWithWhere("car", "license_plate", "id", car_id);
            pickUpLocationCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dropOffLocationCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            departmentCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            equipmentCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            insuranceCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerTable customers = new customerTable();
            customers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carTable cartable = new carTable();
            cartable.Show();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            locationForm location = new locationForm();
            location.Show();
        }

        private void equipmentButton_Click(object sender, EventArgs e)
        {
            equipmentForm equipment = new equipmentForm();
            equipment.Show();
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            insuranceForm insurance = new insuranceForm();
            insurance.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DialogResult availableDialog = new DialogResult();
            int car_id = Convert.ToInt32(islemler1.oneDataReturnWithWhereString("car", "id", "license_plate", plateCombobox.Text.ToString()));
            string available = islemler1.oneDataReturnWithWhere("car", "available", "id", car_id);
            if (Convert.ToBoolean(available))
            {
                string date1 = dateTimePicker1.Value.ToString(), date2 = dateTimePicker2.Value.ToString(), date3 = dateTimePicker3.Value.ToString();
                int pick_up_location_temp = Convert.ToInt32(pickUpLocationCombobox.Text),
                    drop_off_location_temp = Convert.ToInt32(dropOffLocationCombobox.Text),
                    department_temp = Convert.ToInt32(departmentCombobox.Text),
                    customer_temp = Convert.ToInt32(comboBox1.Text);
                string sql;
                if (insuranceCombobox.Text == "" && equipmentCombobox.Text == "")
                {
                    sql = String.Format("insert into public.\"rental\"(start_date,end_date,delivery_date,customer_id,car_id,pick_up_location_id,drop_off_location_id,department_id)" +
                        " values ('{0}','{1}','{2}',{3},{4},{5},{6},{7})",
                        date1,
                        date2,
                        date3,
                        customer_temp,
                        car_id,
                        pick_up_location_temp,
                        drop_off_location_temp,
                        department_temp);
                }
                else if (insuranceCombobox.Text == "")
                {
                    int equipment_id = Convert.ToInt32(equipmentCombobox.Text);
                    sql = String.Format("insert into public.\"rental\"(start_date,end_date,delivery_date,customer_id,car_id,pick_up_location_id,drop_off_location_id,equipment_id,department_id) " +
                        "values ('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8})",
                        date1,
                        date2,
                        date3,
                        customer_temp,
                        car_id,
                        pick_up_location_temp,
                        drop_off_location_temp,
                        equipment_id,
                        department_temp);
                }
                else if (equipmentCombobox.Text == "")
                {
                    int insurance_id = Convert.ToInt32(insuranceCombobox.Text);
                    sql = String.Format("insert into public.\"rental\"(start_date,end_date,delivery_date,customer_id,car_id,pick_up_location_id,drop_off_location_id,department_id,insurance_id)" +
                        " values ('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8})",
                        date1,
                        date2,
                        date3,
                        customer_temp,
                        car_id,
                        pick_up_location_temp,
                        drop_off_location_temp,
                        department_temp,
                        insurance_id);
                }
                else
                {
                    int insurance_id = Convert.ToInt32(insuranceCombobox.Text);
                    int equipment_id = Convert.ToInt32(equipmentCombobox.Text);
                    sql = String.Format("insert into public.\"rental\"" +
                        "(start_date,end_date,delivery_date,customer_id,car_id,pick_up_location_id,drop_off_location_id,equipment_id,department_id,insurance_id) " +
                        "values ('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9})",
                        date1,
                        date2,
                        date3,
                        customer_temp,
                        car_id,
                        pick_up_location_temp,
                        drop_off_location_temp,
                        equipment_id,
                        department_temp,
                        insurance_id);
                }
                islemler1.executeSql(sql);
                dataGridView1.DataSource = islemler1.listele("rental").Tables[0];
            }
            else availableDialog = MessageBox.Show("This car not available");
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            departmentForm department = new departmentForm();
            department.Show();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string sql;
            int equipment_id, insurance_id;
            string  date1 = dateTimePicker1.Value.ToString(),
                    date2 = dateTimePicker2.Value.ToString(),
                    date3 = dateTimePicker3.Value.ToString();
            int pick_up_location_temp   = Convert.ToInt32(pickUpLocationCombobox.Text),
                drop_off_location_temp  = Convert.ToInt32(dropOffLocationCombobox.Text),
                department_temp         = Convert.ToInt32(departmentCombobox.Text),
                customer_temp           = Convert.ToInt32(comboBox1.Text);
            int car_id = Convert.ToInt32(islemler1.oneDataReturnWithWhereString("car", "id", "license_plate", plateCombobox.Text.ToString()));
                
            if (insuranceCombobox.Text == "" && equipmentCombobox.Text == "")
            {
                sql = string.Format("update public.\"rental\" " +
                "set start_date='{0}',end_date='{1}',delivery_date='{2}',customer_id={3},car_id={4},pick_up_location_id={5},drop_off_location_id={6}," +
                "department_id={7},insurance_id=NULL,equipment_id=NULL where id={8}",
                date1,
                date2,
                date3,
                customer_temp,
                car_id,
                pick_up_location_temp,
                drop_off_location_temp,
                department_temp,
                id
                );
            }
            else if (insuranceCombobox.Text == "")
            {
                equipment_id = Convert.ToInt32(equipmentCombobox.Text);
                sql = string.Format("update public.\"rental\" " +
                "set start_date='{0}',end_date='{1}',delivery_date='{2}',customer_id={3},car_id={4},pick_up_location_id={5},drop_off_location_id={6}," +
                "department_id={7},equipment_id={8},insurance_id={10} where id={9}",
                date1,
                date2,
                date3,
                customer_temp,
                car_id,
                pick_up_location_temp,
                drop_off_location_temp,
                department_temp,
                equipment_id,
                id,
                "NULL"
                );
            }
            else if (equipmentCombobox.Text == "")
            {
                insurance_id = Convert.ToInt32(insuranceCombobox.Text);
                sql = string.Format("update public.\"rental\" " +
                "set start_date='{0}',end_date='{1}',delivery_date='{2}',customer_id={3},car_id={4},pick_up_location_id={5},drop_off_location_id={6}," +
                "department_id={7},insurance_id={8},equipment_id={10} where id={9}",
                date1,
                date2,
                date3,
                customer_temp,
                car_id,
                pick_up_location_temp,
                drop_off_location_temp,
                department_temp,
                insurance_id,
                id,
                "NULL"
                );
            }
            else
            {
                insurance_id = Convert.ToInt32(insuranceCombobox.Text);
                equipment_id = Convert.ToInt32(equipmentCombobox.Text);
                sql = string.Format("update public.\"rental\" " +
                "set start_date='{0}',end_date='{1}',delivery_date='{2}',customer_id={3},car_id={4},pick_up_location_id={5},drop_off_location_id={6}," +
                "department_id={7},equipment_id={8}, insurance_id={9} where id={10}",
                date1,
                date2,
                date3,
                customer_temp,
                car_id,
                pick_up_location_temp,
                drop_off_location_temp,
                equipment_id,
                department_temp,
                insurance_id,
                id
                );
            }
            islemler1.executeSql(sql);
            dataGridView1.DataSource = islemler1.listele("rental").Tables[0];
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            islemler1.deleteColumn("rental", id);
            dataGridView1.DataSource = islemler1.listele("rental").Tables[0];
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "") dataGridView1.DataSource = islemler1.listele("rental").Tables[0];

            else dataGridView1.DataSource = islemler1.aramaInt("rental", "customer_id", Convert.ToInt32(comboBox2.Text)).Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox4.Text == "") dataGridView1.DataSource = islemler1.executeSqlReturnDataSet(String.Format("select * from rental where equipment_id is null")).Tables[0];

            else dataGridView1.DataSource = islemler1.aramaInt("rental", "equipment_id", Convert.ToInt32(comboBox4.Text)).Tables[0];
        }

        private void carSearchButton_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "") dataGridView1.DataSource = islemler1.listele("rental").Tables[0];

            else dataGridView1.DataSource = islemler1.aramaInt("rental", "car_id", Convert.ToInt32(comboBox3.Text)).Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "") dataGridView1.DataSource = islemler1.executeSqlReturnDataSet(String.Format("select * from rental where insurance_id is null")).Tables[0];

            else dataGridView1.DataSource = islemler1.aramaInt("rental", "insurance_id", Convert.ToInt32(comboBox5.Text)).Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = islemler1.listele("rental").Tables[0];
        }
    }
}    
