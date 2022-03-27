using System;
using System.Windows.Forms;

namespace Учебка2
{
    public partial class Form1 : Form
    {
        private Users users;
        private Catalogs catalogs;
        private Products products;
        private Orders orders;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//переход на форму пользователей
        {
            users = new Users();
            users.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)//переход на форму каталоги
        {
            catalogs = new Catalogs();
            catalogs.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//переход на форму товары
        {
            products = new Products();
            products.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)// переход на форму заказы
        {
            orders = new Orders();
            orders.Visible = true;
        }
    }
}
