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
    public partial class Form3 : Form
    {
        private System.Windows.Forms.DataGridViewColumn COL;
        public Form3()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)// обновление всех данных
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_ShopDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_ShopDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.computer_ShopDataSet1.Products);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)// включение кнопки
        {
            button1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, присваивающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex). Если выбран первый пункт
            //списка, то в переменную Col записывается столбец
            //DataGridViewTextBoxColumn2, если второй, то – DataGridViewTextBoxColumn3
            //и так далее. Хотелось бы отметить тот факт, что нумерация пунктов списка
            //начинается с нуля, а нумерация столбцов с единицы. Первый столбец «Наименование»
            //носит имя DataGridViewTextBoxColumn2, так как имя
            //DataGridViewTextBoxColumn1 имеет столбец заголовков строк;
            switch (listBox1.SelectedIndex)// проверка listbox'a
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю заданному в переменной Col по возрастанию
            //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton2.Checked)// сортировка
                productsDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                productsDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)// фильтр
        {
            productsBindingSource.Filter = "NAME='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)// фильтр
        {
            productsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)//цикл
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < productsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    productsDataGridView[i, j].Style.BackColor = Color.White;
                    productsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < productsDataGridView.ColumnCount - 1; i++)// цикл
            {
                for (int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    if (productsDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        productsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        productsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)// закрыть вкладку
        {
            this.Close();
        }
    }
}
