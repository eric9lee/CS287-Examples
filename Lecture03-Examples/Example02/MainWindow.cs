using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStoreLibrary;

namespace Example02
{
    public partial class MainWindow : Form
    {
        public Product[] Products;
        public List<Product> ShoppingCart;
        public int Total;

        public MainWindow()
        {
            InitializeComponent();
            Products = new Product[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "iPhone 7",
                    Price = 28900,
                    Categories = new string[] { "iPhone" }
                },
                new Product()
                {
                    Id = 2,
                    Name = "iPhone 7 plus",
                    Price = 31900,
                    Categories = new string[] { "iPhone" }
                }
            };
            ShoppingCart = new List<Product>();

            Total = 0;
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
            Product1Label.Text = string.Format("產品:{0}, 價格:{1}元", Products[0].Name, Products[0].Price);
            Product2Label.Text = string.Format("產品:{0}, 價格:{1}元", Products[1].Name, Products[1].Price);
        }

        private void AddProduct1Button_Click(object sender, EventArgs e)
        {
            ShoppingCart.Add(Products[0]);
            ShoppingCartRichTextBox.Text = ShoppingCartRichTextBox.Text + Products[0].Name + "\n";
            Total += Products[0].Price;
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
        }

        private void AddProduct2Button_Click(object sender, EventArgs e)
        {
            ShoppingCart.Add(Products[1]);
            ShoppingCartRichTextBox.Text = ShoppingCartRichTextBox.Text + Products[1].Name + "\n";
            Total += Products[1].Price;
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Total = 0;
            ShoppingCartRichTextBox.Text = "";
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
        }
    }
}