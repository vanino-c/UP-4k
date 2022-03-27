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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void customsBindingNavigatorSaveItem_Click(object sender, EventArgs e)// сохранение данных
        {
            this.Validate();
            this.customsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet1);

        }

        private void Orders_Load(object sender, EventArgs e)// загрузка заказов
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.Customs". При необходимости она может быть перемещена или удалена.
            this.customsTableAdapter.Fill(this.computer_ShopDataSet1.Customs);

        }
    }
}
