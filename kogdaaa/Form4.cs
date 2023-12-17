using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kogdaaa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void table_3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kogda_eto_konchitsaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kogda_eto_konchitsaDataSet.Table_3". При необходимости она может быть перемещена или удалена.
            this.table_3TableAdapter.Fill(this.kogda_eto_konchitsaDataSet.Table_3);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = table_3DataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.table_3DataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.table_3DataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.table_3DataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.table_3DataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.table_3DataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.table_3BindingSource.Filter = "шифр книги='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_3BindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table_3DataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < table_3DataGridView.RowCount - 1; j++)
                {
                    table_3DataGridView[i, j].Style.BackColor = Color.White;
                    table_3DataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < table_3DataGridView.ColumnCount; i++)
                for (int j = 0; j < table_3DataGridView.RowCount - 1; j++)
                    if (table_3DataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        table_3DataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        table_3DataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
        }
    }
}
