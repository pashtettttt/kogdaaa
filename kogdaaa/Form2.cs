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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void table_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kogda_eto_konchitsaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kogda_eto_konchitsaDataSet.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.kogda_eto_konchitsaDataSet.Table_1);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = table_1DataGridView.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = this.table_1DataGridView.Columns[0];
                    break;
                case 1:
                    Col = this.table_1DataGridView.Columns[1];
                    break;
                case 2:
                    Col = this.table_1DataGridView.Columns[2];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.table_1DataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.table_1DataGridView.Sort(Col, ListSortDirection.Descending);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.table_1BindingSource.Filter = "автор='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_1BindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table_1DataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < table_1DataGridView.RowCount - 1; j++)
                {
                    table_1DataGridView[i, j].Style.BackColor = Color.White;
                    table_1DataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < table_1DataGridView.ColumnCount; i++)
                for (int j = 0; j < table_1DataGridView.RowCount - 1; j++)
                    if (table_1DataGridView[i, j].Value.ToString().StartsWith(textBox1.Text) == true)
                    {
                        table_1DataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        table_1DataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
        }
    }
}
