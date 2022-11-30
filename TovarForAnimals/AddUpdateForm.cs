using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TovarForAnimals
{
    public partial class AddUpdateForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-1HNM0LM;Initial Catalog=Animal;Integrated Security=True";
        private string articul;
        private int status;
        private string pathToPhoto;
        string str = "";
        string resPath = "";
        string res2 = "";
        string res3 = "";
        string res4 = "";
        string res5 = "";
        string res6 = "";
        string res7 = "";
        string res8 = "";
        int row = 1;

        public AddUpdateForm(string Articul, int status, int row)
        {
            InitializeComponent();

            string[] Roles = { "Для животных", "Товары для собак", "Товары для кошек"};
            comboBoxType.Items.AddRange(Roles);

            switch (status)
            {
                case 0:
                    AcceptButton.Text = "Добавить";
                    break;
                case 1:
                    AcceptButton.Text = "Обновить";
                    break;
            }
            this.status = status;
            this.row = row;
            this.articul = Articul;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            str = "select * from Tovar where Артикул='" + articul;
            str += "'";

            cmd.CommandText = str;
            cmd.ExecuteNonQuery();

            SqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                resPath += dataReader["Изображение"];
                res2 += dataReader["Наименование "];
                res3 += dataReader["Единица измерения"];
                res4 += dataReader["Стоимость"];
                res5 += dataReader["Поставщик"];
                res6 += dataReader["Категория товара"];
                res7 += dataReader["Кол-во на складе"];
                res8 += dataReader["Описание"];
            }
            dataReader.Close();

            TextBoxName.Text = res2;
            TextBoxIsm.Text = res3;
            TextBoxCost.Text = res4;
            textBoxPost.Text = res5;
            comboBoxType.Text = res6;
            TextBoxOstatok.Text = res7;
            textBoxInfo.Text = res8;
            TextBoxId.Text = articul.ToString();

            try
            {
                UserImage.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Res\\" + articul + ".jpg");
            }
            catch {
                UserImage.Image = Properties.Resources.picture;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string sql = "SELECT * FROM Tovar";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];


                    dt.Rows[row]["Наименование "] = TextBoxName.Text;
                    dt.Rows[row]["Единица измерения"] = TextBoxIsm.Text;
                    dt.Rows[row]["Стоимость"] = TextBoxCost.Text;
                    dt.Rows[row]["Поставщик"] = textBoxPost.Text;
                    dt.Rows[row]["Категория товара"] = comboBoxType.Text;
                    dt.Rows[row]["Кол-во на складе"] = TextBoxOstatok.Text;
                    dt.Rows[row]["Описание"] = textBoxInfo.Text;

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    ds.Clear();

                    connection.Close();

                    MessageBox.Show("Успешно изменено");
                }
                catch
                {
                    MessageBox.Show("Перепроверьте данные!");
                }

                //SqlConnection conn = new SqlConnection(connectionString);
                //conn.Open();
                //SqlCommand command = new SqlCommand("update Tovar SET Артикул=@Артикул, Наименование=@Наименование, [Единица измерения]=@[Единица измерения], " +
                //    "Стоимость=@Стоимость, Поставщик=@Поставщик, [Категория товара]=@[Категория товара], [Кол-во на складе]=@[Кол-во на складе]," +
                //    " Описание=@Описание, where Артикул=@Артикул", conn);
                //command.Parameters.AddWithValue("@Наименование", TextBoxName.Text);
                //command.Parameters.AddWithValue("@[Единица измерения]", TextBoxIsm.Text);
                //command.Parameters.AddWithValue("@Стоимость", TextBoxCost.Text);
                //command.Parameters.AddWithValue("@Поставщик", textBoxPost.Text);
                //command.Parameters.AddWithValue("@[Категория товара]", comboBoxType.Text);
                //command.Parameters.AddWithValue("@[Кол-во на складе]", TextBoxOstatok.Text);
                //command.Parameters.AddWithValue("@Описание", textBoxInfo.Text);
                //command.Parameters.AddWithValue("@Артикул", articul.ToString());
                //command.ExecuteNonQuery();
                //conn.Close();
            }
            else if (status == 0)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string sql = "SELECT * FROM Tovar";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    DataRow MyRow = dt.NewRow();
                    MyRow["Артикул"] = TextBoxId.Text;
                    MyRow["Наименование "] = TextBoxName.Text;
                    MyRow["Единица измерения"] = TextBoxIsm.Text;
                    MyRow["Стоимость"] = TextBoxCost.Text;
                    MyRow["Поставщик"] = textBoxPost.Text;
                    MyRow["Категория товара"] = comboBoxType.Text;
                    MyRow["Кол-во на складе"] = TextBoxOstatok.Text;
                    MyRow["Описание"] = textBoxInfo.Text;

                    dt.Rows.Add(MyRow);


                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    ds.Clear();

                    connection.Close();

                    MessageBox.Show("Успешно создано");
                }
                catch
                {
                    MessageBox.Show("Перепроверьте данные!");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void InsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = new Bitmap(openFileDialog.FileName);
                UserImage.Image = image;

            }
        }
    }
}