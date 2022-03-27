using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебка2
{
    public partial class Product_line : Form
    {
        public Product_line()
        {
            InitializeComponent();
        }

        private void productLineBindingNavigatorSaveItem_Click(object sender, EventArgs e)// сохранение данных
        {
            this.Validate();
            this.productLineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet1);

        }

        private void Product_line_Load(object sender, EventArgs e)// загрузка данных
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.ProductLine". При необходимости она может быть перемещена или удалена.
            this.productLineTableAdapter.Fill(this.computer_ShopDataSet1.ProductLine);

        }
    }
}
