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
    public partial class Products : Form
    {
        private Form3 productstable;

        public Products()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)// сохранение данных
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet1);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.CATALOGS". При необходимости она может быть перемещена или удалена.
            this.cATALOGSTableAdapter.Fill(this.computer_ShopDataSet1.CATALOGS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.computer_ShopDataSet1.Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)// переход в табличный вид
        {
            productstable = new Form3();
            productstable.Visible = true;
        }
    }
}
