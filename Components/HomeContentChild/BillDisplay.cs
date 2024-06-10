﻿using FinalProject.Controllers;
using FinalProject.Models;

namespace FinalProject.Components
{
    public partial class BillDisplay : UserControl
    {
        private Order currentOrder;
        private List<OrderDetail> currentOrderDetails;
        private OrderController orderController;
        private OrderDetailController orderDetailController;
        private ToolTip toolTip;
        private int EmployeeID { get; set; }  // Thêm thuộc tính EmployeeID

        public BillDisplay(int employeeID) // Thêm tham số employeeID
        {
            InitializeComponent();
            EmployeeID = employeeID;  // Lưu trữ EmployeeID
            currentOrderDetails = new List<OrderDetail>();
            orderController = new OrderController();
            orderDetailController = new OrderDetailController();
            toolTip = new ToolTip();
        }

        public Button CommitButton => button1;

        public void AddProductToBill(string productName, int quantity, decimal totalPrice)
        {
            Panel productPanel = new Panel
            {
                BackColor = SystemColors.Control,
                Size = new Size(thisPanelDisplayProductDetail.Width, 43),
                Margin = new Padding(0, 0, 0, 10)
            };

            Label productNameLabel = new Label
            {
                Text = productName,
                Location = new Point(13, 13),
                AutoSize = true
            };

            Label productQuantityLabel = new Label
            {
                Text = quantity.ToString(),
                Location = new Point(350, 13),
                AutoSize = true
            };

            Label x = new Label
            {
                Text = "x",
                Location = new Point(400, 13),
                AutoSize = true
            };

            Label productTotalPriceLabel = new Label
            {
                Text = $"{totalPrice:C}",
                Location = new Point(450, 13),
                AutoSize = true
            };

            productPanel.Controls.Add(productNameLabel);
            productPanel.Controls.Add(x);
            productPanel.Controls.Add(productQuantityLabel);
            productPanel.Controls.Add(productTotalPriceLabel);

            thisPanelDisplayProductDetail.Controls.Add(productPanel);

            var productController = new ProductController();
            var product = productController.GetAllProducts().FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                var orderDetail = new OrderDetail
                {
                    ProductID = product.ProductID,
                    Quantity = quantity,
                    UnitPrice = totalPrice / quantity
                };
                currentOrderDetails.Add(orderDetail);
            }
        }

        public void SetTotalPrice(decimal totalPrice)
        {
            totalPriceOfBill.Text = $"{totalPrice:C}";
            currentOrder = new Order
            {
                EmployeeID = EmployeeID, // Sử dụng EmployeeID đã được truyền vào
                OrderDate = DateTime.Now,
                CustomerID = 1, // Set the CustomerID to a default value or retrieve from current session
                TotalAmount = totalPrice
            };
        }

        private void BillDisplay_Load(object sender, EventArgs e)
        {
            // Clear previous controls
            thisPanelDisplayProductDetail.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentOrder != null && currentOrderDetails.Any())
            {
                // Add the order to the database
                orderController.AddOrder(currentOrder);

                // Add each order detail to the database
                foreach (var detail in currentOrderDetails)
                {
                    detail.OrderID = currentOrder.OrderID; // Set the OrderID of each detail
                    orderDetailController.AddOrderDetail(detail); // Uncomment this line to add order detail
                }

                ShowToolTip(button1, "Order committed successfully!");

                // Clear the current order details
                currentOrderDetails.Clear();
                thisPanelDisplayProductDetail.Controls.Clear();
                totalPriceOfBill.Text = "0$";
            }
            else
            {
                ShowToolTip(button1, "No products in the order!");
            }
        }

        private void ShowToolTip(Control control, string message)
        {
            toolTip.Show(message, control, control.Width / 2, control.Height / 2, 3000); // Hiển thị thông báo trong 3 giây
        }
    }
}
