using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TovarForAnimals
{
    public partial class LoginForm : Form
    {
        string res = string.Empty;
        string res2 = string.Empty;
        int numberCaptha = 0;
        string connectionString = @"Data Source=DESKTOP-1HNM0LM;Initial Catalog=Animal;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
            loadCaptchaImage();
        }
        private void loadCaptchaImage()
        {
            Random r1 = new Random();
            numberCaptha = r1.Next(1000, 10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(numberCaptha.ToString(), font, Brushes.RosyBrown, new Point(0, 0));
            pictureBox1.Image = image;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string str = "";

            //try
            //{
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                str = "SELECT FK_Роли, ФИО FROM Пользователи WHERE Логин='" + login;
                str += "' and Пароль='" + password;
                str += "'";

                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

                SqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    res += dataReader["FK_Роли"];
                    res2 += dataReader["ФИО"];
                }
                dataReader.Close();

                if (textBoxCaptha.Text == numberCaptha.ToString() && (res == "1" || res == "2" || res == "3"))
                {
                    ProductsForm newForm = new ProductsForm(res, res2);
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильные данные или капча!");
                    this.Enabled = false;
                    Thread.Sleep(1000 * 2);
                    this.Enabled = true;
                    loadCaptchaImage();
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка");
            //}
        }

        private void buttonTovar_Click(object sender, EventArgs e)
        {
            ProductsForm newForm = new ProductsForm("", "");
            newForm.Show();
            this.Hide();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }
    }
}
