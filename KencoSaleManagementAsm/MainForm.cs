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

namespace KencoSaleManagementAsm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadChartData();
            LoadLabelData();


            RoundCorners(pnTotalRevenue, 20);
            RoundCorners(plTotalOrder, 20);
            RoundCorners(pnTotalProduct, 20);
            RoundCorners(pnTotalCustomer, 20);

        }

        private void button2_Click(object sender, EventArgs e)
        {

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



        public void LoadChartData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu của bạn
            string connectionString = "Server=DESKTOP-I11JMKJ\\MASTERMOS; Database=KencoSaleManagement; Integrated Security=True;";

            // Truy vấn SQL để lấy dữ liệu từ bảng RevenueStatistics
            string query = "SELECT StatDate, TotalRevenue, TotalOrders, TotalCustomers, TotalProducts FROM RevenueStatistics ORDER BY StatDate";

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Xóa dữ liệu cũ trong các series
                chart1.Series["Total Revenue"].Points.Clear();
                chart1.Series["Total Orders"].Points.Clear();
                chart1.Series["Total Customers"].Points.Clear();
                chart1.Series["Total Products"].Points.Clear();


                // Duyệt qua các dòng trong DataTable và thêm dữ liệu vào các series
                foreach (DataRow row in dataTable.Rows)
                {
                    // Chuyển dữ liệu từ DataRow sang dạng cần thiết
                    DateTime statDate = (DateTime)row["StatDate"];
                    decimal totalRevenue = (decimal)row["TotalRevenue"];
                    int totalOrders = (int)row["TotalOrders"];
                    int totalCustomers = (int)row["TotalCustomers"];
                    int totalProducts = (int)row["TotalProducts"];

                    // Thêm điểm vào các series
                    chart1.Series["Total Revenue"].Points.AddXY(statDate, totalRevenue);
                    chart1.Series["Total Orders"].Points.AddXY(statDate, totalOrders);
                    chart1.Series["Total Customers"].Points.AddXY(statDate, totalCustomers);
                    chart1.Series["Total Products"].Points.AddXY(statDate, totalProducts);
                }

                // Thêm trục phụ cho các series có giá trị nhỏ
                chart1.Series["Total Orders"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                chart1.Series["Total Customers"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                chart1.Series["Total Products"].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;

                // Đảm bảo trục phụ được hiển thị
                chart1.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            }

        }

        public void LoadLabelData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu của bạn
            string connectionString = "Server=DESKTOP-I11JMKJ\\MASTERMOS; Database=KencoSaleManagement; Integrated Security=True;";

            // Truy vấn SQL để lấy dữ liệu tổng hợp theo tháng
            string query = @"
                SELECT 
                    YEAR(StatDate) AS Year, 
                    MONTH(StatDate) AS Month, 
                    SUM(TotalRevenue) AS TotalRevenue, 
                    SUM(TotalOrders) AS TotalOrders, 
                    SUM(TotalCustomers) AS TotalCustomers, 
                    SUM(TotalProducts) AS TotalProducts
                FROM RevenueStatistics
                GROUP BY YEAR(StatDate), MONTH(StatDate)
                ORDER BY Year, Month";

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Kiểm tra và lấy giá trị tổng cho tháng đầu tiên
                if (dataTable.Rows.Count == 1) // Nếu có dữ liệu chỉ cho 1 tháng
                {
                    // Lấy giá trị từ dòng duy nhất
                    DataRow currentMonthRow = dataTable.Rows[0]; // Tháng hiện tại (dòng duy nhất)

                    decimal currentTotalRevenue = (decimal)currentMonthRow["TotalRevenue"];
                    int currentTotalOrders = (int)currentMonthRow["TotalOrders"];
                    int currentTotalCustomers = (int)currentMonthRow["TotalCustomers"];
                    int currentTotalProducts = (int)currentMonthRow["TotalProducts"];

                    // Cập nhật các label và màu sắc (màu xanh nếu chỉ có 1 tháng)
                    lblRevenueMoney.Text = currentTotalRevenue.ToString("C", new System.Globalization.CultureInfo("en-US"));
                    lblTtOrderNum.Text = currentTotalOrders.ToString();
                    lblTtProductNum.Text = currentTotalProducts.ToString();
                    lblTtCustomerNum.Text = currentTotalCustomers.ToString();

                    // Màu xanh (LimeGreen) nếu chỉ có 1 tháng
                    lblRevenueMoney.ForeColor = Color.LimeGreen;
                    lblTtOrderNum.ForeColor = Color.LimeGreen;
                    lblTtProductNum.ForeColor = Color.LimeGreen;
                    lblTtCustomerNum.ForeColor = Color.LimeGreen;
                }
                else if (dataTable.Rows.Count > 1) // Nếu có dữ liệu cho ít nhất 2 tháng
                {
                    // Lấy giá trị từ dòng tháng hiện tại và tháng trước
                    DataRow currentMonthRow = dataTable.Rows[0]; // Tháng hiện tại (dòng đầu tiên)
                    DataRow previousMonthRow = dataTable.Rows[1]; // Tháng trước (dòng thứ hai)

                    decimal currentTotalRevenue = (decimal)currentMonthRow["TotalRevenue"];
                    int currentTotalOrders = (int)currentMonthRow["TotalOrders"];
                    int currentTotalCustomers = (int)currentMonthRow["TotalCustomers"];
                    int currentTotalProducts = (int)currentMonthRow["TotalProducts"];

                    decimal previousTotalRevenue = (decimal)previousMonthRow["TotalRevenue"];
                    int previousTotalOrders = (int)previousMonthRow["TotalOrders"];
                    int previousTotalCustomers = (int)previousMonthRow["TotalCustomers"];
                    int previousTotalProducts = (int)previousMonthRow["TotalProducts"];

                    // Cập nhật các label
                    lblRevenueMoney.Text = currentTotalRevenue.ToString("C", new System.Globalization.CultureInfo("en-US"));
                    lblTtOrderNum.Text = currentTotalOrders.ToString();
                    lblTtProductNum.Text = currentTotalProducts.ToString();
                    lblTtCustomerNum.Text = currentTotalCustomers.ToString();

                    // So sánh và thay đổi màu sắc cho các label
                    lblRevenueMoney.ForeColor = currentTotalRevenue > previousTotalRevenue ? Color.LimeGreen : Color.Red;
                    lblTtOrderNum.ForeColor = currentTotalOrders > previousTotalOrders ? Color.LimeGreen : Color.Red;
                    lblTtProductNum.ForeColor = currentTotalProducts > previousTotalProducts ? Color.LimeGreen : Color.Red;
                    lblTtCustomerNum.ForeColor = currentTotalCustomers > previousTotalCustomers ? Color.LimeGreen : Color.Red;
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

        private void btnCustomerM_Click(object sender, EventArgs e)
        {
            // Tạo một instance của CustomerForm
            CustomerForm customerForm = new CustomerForm();

            // Hiển thị CustomerForm
            customerForm.Show();

            // Ẩn MainForm (form hiện tại)
            this.Hide();

            // Gán sự kiện FormClosed để hiển thị lại MainForm khi CustomerForm đóng
            customerForm.FormClosed += (s, args) =>
            {
                // Hiển thị lại MainForm khi CustomerForm bị đóng
                this.Show();
            };
        }
    }
}
