using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PetDiary
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = DB.ConnectDB();
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed) sqlCon.Open();
                if (txtage.Text != "" && txtlastname.Text != "" && txtfirstname.Text != "" && txtpassword.Password != "")
                {
                    String query = "insert into dbUser (FirstName, LastName, Password, Age) values (@FirstName, @LastName, @Password, @Age)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", Convert.ToString(DB.Hash(txtpassword.Password)));
                    sqlCmd.Parameters.AddWithValue("@Age", txtage.Text);
                    sqlCmd.ExecuteNonQuery();
                    MainWindow Menu = new MainWindow();
                    Menu.Show();
                    this.Close();
                    //User user = new User();
                    //int id = user.Get_id(txtfirstname.Text, txtlastname.Text);
                    //user = new User(txtfirstname.Text, txtlastname.Text, Convert.ToInt32(txtage.Text), id);

                }
                else
                {
                    MessageBox.Show("Fill all fields.");
                    Registration Reg = new Registration();
                    Reg.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
           
       
        }
    }
}
