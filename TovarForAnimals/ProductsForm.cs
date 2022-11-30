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

namespace TovarForAnimals
{
    public partial class ProductsForm : Form
    {
        SqlDataAdapter pagingAdapter;
        DataSet pagingDS;
        int pageSize = 10;
        int maxItem = 0;
        int nowItem = 0;
        int scrollVal;
        string connectionString = @"Data Source=DESKTOP-1HNM0LM;Initial Catalog=Animal;Integrated Security=True";
        string sql = "select [Артикул], [Наименование], [Производитель], [Поставщик], [Стоимость], [Кол-во на складе], [Описание], [Изображение] from Tovar";
        string sql1 = "select count(Артикул) from Tovar";
        string sqlFiltr = "";
        string sqlSortV = "";
        string sqlSearch = "";
        string sqlFiltrMax = "";
        string sqlSearchMax = "";
        string ID = "";
        public ProductsForm(string role, string name)
        {
            InitializeComponent();

            //buttonAdd.Visible = false;
            //buttonDelete.Visible = false;
            //buttonChange.Visible = false;


            if (role == "1")
            {
                labelRole.Text = "Администратор";
                buttonAdd.Visible = true;
                buttonDelete.Visible = true;
                buttonChange.Visible = true;
            }
            else if (role == "2")
                labelRole.Text = "Менеджер";
            else if (role == "3")
                labelRole.Text = "Клиент";
            else
                labelRole.Text = "Гость";
            labelName.Text = name;

            string[] m1 = { "По убыванию", "По возрастанию" };
            string[] m3 = { "Все производители", "Triol", "trixie", "Cat Chow", "Fancy Pets", "TitBit", "Pro Plan", "LIKER", "True Touch", "ZooM", "Chappy", "Nobby", "Dreames", "Dog Chow" };
            comboBoxSortV.Items.AddRange(m1);
            comboBoxFilter.Items.AddRange(m3);

            scrollVal = 0;
            dataGridMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMaterial.AllowUserToAddRows = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql1, connection);
            labelMaxItem.Text = command.ExecuteScalar().ToString();
            labelNowItem.Text = command.ExecuteScalar().ToString();
            maxItem = Convert.ToInt32(command.ExecuteScalar());


            pagingAdapter = new SqlDataAdapter(sql, connection);
            pagingDS = new DataSet();

            pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "Authors_table");

            dataGridMaterial.DataSource = pagingDS;
            dataGridMaterial.DataMember = "Authors_table";

            connection.Close();
        }

        public void Create()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                sql = "select [Артикул], [Наименование], [Производитель], [Поставщик], [Стоимость], [Кол-во на складе], [Описание], [Изображение] from Tovar";
                if ((comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители") || textBoxSearch.Text != "")
                    sql += " WHERE ";
                sql += sqlFiltr;
                if (comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители" && textBoxSearch.Text != "")
                    sql += " AND ";
                sql += sqlSearch;
                sql += sqlSortV;

                pagingAdapter = new SqlDataAdapter(sql, connection);
                pagingDS = new DataSet();
                connection.Open();
                pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "Authors_table");

                dataGridMaterial.DataSource = pagingDS;
                dataGridMaterial.DataMember = "Authors_table";
                scrollVal = 0;

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Что-то не так");
            }
        }
        public void Max()
        {
            try
            {
                sql1 = "select count(Артикул) from Tovar";
                if ((comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители") || textBoxSearch.Text != "")
                    sql1 += " WHERE ";
                sql1 += sqlFiltrMax;
                if (comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители" && textBoxSearch.Text != "")
                    sql1 += " AND ";
                sql1 += sqlSearchMax;


                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(sql1, connection);
                labelNowItem.Text = command.ExecuteScalar().ToString();
                maxItem = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
                scrollVal = scrollVal - pageSize;
                if (scrollVal <= 0)
                {
                    scrollVal = 0;
                }
                pagingDS.Clear();
                pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "authors_table");
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            scrollVal = scrollVal + pageSize;
            if (scrollVal >= maxItem)
            {
                scrollVal = maxItem - pageSize;
            }
            else
            {
                pagingDS.Clear();
                pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "authors_table");
            }
        }

        private void dataGridMaterial_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridMaterial.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridMaterial[5, i].Value) == 0)
                    dataGridMaterial.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            sqlSearch = String.Format("[Наименование] like '{0}%'", textBoxSearch.Text);
            sqlSearchMax = String.Format("[Наименование] like '{0}%'", textBoxSearch.Text);
            if (textBoxSearch.Text == "")
            {
                sqlSearch = "";
                sqlSearchMax = "";
            }
            Max();
            Create();
        }

        private void comboBoxSortV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSortV.Text == "По убыванию")
            {
                sqlSortV = "order by Стоимость DESC";
            }
            else if (comboBoxSortV.Text == "По возрастанию")
            {
                sqlSortV = "order by Стоимость ASC";
            }

            Create();
        }

        private void comboBoxFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxFilter.Text != "Все производители" && comboBoxFilter.Text != "")
            {
                sqlFiltr = "[Производитель]='" + comboBoxFilter.Text + "'";
                sqlFiltrMax = "[Производитель]='" + comboBoxFilter.Text + "'";
            }
            else
            {
                sqlFiltr = "";
                sqlFiltrMax = "";
            }

            Max();
            Create();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm newForm = new AddUpdateForm("", 0, 1);
            newForm.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string ID = dataGridMaterial.SelectedCells[0].Value.ToString();
            int tt = Convert.ToInt32(dataGridMaterial.SelectedCells[0].RowIndex);

            AddUpdateForm newForm = new AddUpdateForm(ID, 1, tt);
            newForm.Show();
            this.Hide();
        }
    }

}

