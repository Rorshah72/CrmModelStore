using CrmBL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = new Product(textBox1.Text, numericUpDown1.Value, Convert.ToInt32(numericUpDown2.Value));
            Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }
    }
}
