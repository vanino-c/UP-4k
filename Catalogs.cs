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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void cATALOGSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATALOGSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet1);

        }

        private void Catalogs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.CATALOGS". При необходимости она может быть перемещена или удалена.
            this.cATALOGSTableAdapter.Fill(this.computer_ShopDataSet1.CATALOGS);

        }
    }
}
