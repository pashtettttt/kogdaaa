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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void table_3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kogda_eto_konchitsaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kogda_eto_konchitsaDataSet.Table_3". При необходимости она может быть перемещена или удалена.
            this.table_3TableAdapter.Fill(this.kogda_eto_konchitsaDataSet.Table_3);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(); 
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
