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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void table_2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kogda_eto_konchitsaDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kogda_eto_konchitsaDataSet.Table_2". При необходимости она может быть перемещена или удалена.
            this.table_2TableAdapter.Fill(this.kogda_eto_konchitsaDataSet.Table_2);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _библиотекиLabel_Click(object sender, EventArgs e)
        {

        }

        private void адресLabel_Click(object sender, EventArgs e)
        {

        }

        private void телефонLabel_Click(object sender, EventArgs e)
        {

        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void адресTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void _библиотекиTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
