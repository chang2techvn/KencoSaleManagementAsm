using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KencoSaleManagementAsm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RoundCorners(panelLoginMain, 30);


            txtbLoginEmail.Paint += (sender, e) => CenterTextVertically(sender as System.Windows.Forms.TextBox, e);
            txtbPassword.Paint += (sender, e) => CenterTextVertically(sender as System.Windows.Forms.TextBox, e);
        }



        // Hàm tái sử dụng để căn giữa văn bản theo chiều dọc trong TextBox
        private void CenterTextVertically(System.Windows.Forms.TextBox textBox, PaintEventArgs e)
        {
            if (textBox != null)
            {
                int verticalMargin = (textBox.ClientSize.Height - textBox.Font.Height) / 2;

                // Vẽ lại văn bản với lề trên và dưới để căn giữa
                e.Graphics.DrawString(textBox.Text, textBox.Font, Brushes.Black, new PointF(2, verticalMargin));
            }
        }

        public static void RoundCorners(Panel panel, int cornerRadius)
        {
            if (cornerRadius < 1) return;

            // Create a GraphicsPath for rounded corners
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);

            path.AddArc(bounds.X, bounds.Y, cornerRadius * 2, cornerRadius * 2, 180, 90); // Top-left corner
            path.AddArc(bounds.Right - cornerRadius * 2, bounds.Y, cornerRadius * 2, cornerRadius * 2, 270, 90); // Top-right corner
            path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90); // Bottom-right corner
            path.AddArc(bounds.X, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90); // Bottom-left corner
            path.CloseAllFigures();

            // Apply the GraphicsPath as the region of the panel
            panel.Region = new Region(path);
        }

        string connectionString = "Server=DESKTOP-I11JMKJ\\MASTERMOS; Database=KencoSaleManagement; Integrated Security=True;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string username = txtbLoginEmail.Text.Trim();
            string password = txtbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Kiểm tra thông tin đăng nhập
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Mở form chính của ứng dụng hoặc chuyển hướng
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Ẩn form login
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Mở kết nối
                connection.Open();

                // Câu lệnh SQL để kiểm tra tài khoản và mật khẩu
                string query = "SELECT COUNT(*) FROM Employee WHERE Account = @account AND Password = @password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@account", username);
                command.Parameters.AddWithValue("@password", password);

                // Thực thi truy vấn và kiểm tra kết quả
                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    isAuthenticated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isAuthenticated;
        }
    }
}
