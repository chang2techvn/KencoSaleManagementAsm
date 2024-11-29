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

namespace KencoSaleManagementAsm
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        string connectionString = "Server=DESKTOP-I11JMKJ\\MASTERMOS; Database=KencoSaleManagement; Integrated Security=True;";

        private void LoadCustomerData()
        {
            // Clear existing items
            lvCustomer.Items.Clear();

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL để lấy dữ liệu từ bảng Customers
                    string query = "SELECT CustomerID, Name, Email, Phone, Address, EmployeeID FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Sử dụng SqlDataReader để đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ từng dòng trong kết quả
                            string customerID = reader["CustomerID"].ToString();
                            string name = reader["Name"].ToString();
                            string email = reader["Email"].ToString();
                            string phone = reader["Phone"].ToString();
                            string address = reader["Address"].ToString();
                            string employeeID = reader["EmployeeID"].ToString();

                            // Tạo một ListViewItem mới và thêm vào ListView
                            ListViewItem item = new ListViewItem(customerID);
                            item.SubItems.Add(name);
                            item.SubItems.Add(email);
                            item.SubItems.Add(phone);
                            item.SubItems.Add(address);
                            item.SubItems.Add(employeeID);

                            // Thêm item vào ListView
                            lvCustomer.Items.Add(item);
                        }
                    }

                    // Điều chỉnh kích thước cột sau khi đã thêm hết dữ liệu
                    foreach (ColumnHeader column in lvCustomer.Columns)
                    {
                        column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent); // Điều chỉnh cột theo nội dung
                        column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);   // Điều chỉnh cột theo tiêu đề
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem form MainForm có đang mở hay không
            foreach (Form f in Application.OpenForms)
            {
                if (f is MainForm) // Nếu form MainForm đã mở
                {
                    f.BringToFront(); // Đưa form MainForm lên phía trước
                    return;
                }
            }

            // Nếu MainForm chưa mở, tạo mới và mở form MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show(); // Hiển thị MainForm
        }
    }
}
