namespace kogdaaa
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label _библиотекиLabel;
            System.Windows.Forms.Label шифр_книгиLabel;
            System.Windows.Forms.Label наименование_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.kogda_eto_konchitsaDataSet = new kogdaaa.kogda_eto_konchitsaDataSet();
            this.table_3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_3TableAdapter = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.Table_3TableAdapter();
            this.tableAdapterManager = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager();
            this.table_3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_3BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._библиотекиTextBox = new System.Windows.Forms.TextBox();
            this.шифр_книгиTextBox = new System.Windows.Forms.TextBox();
            this.наименование_залаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            _библиотекиLabel = new System.Windows.Forms.Label();
            шифр_книгиLabel = new System.Windows.Forms.Label();
            наименование_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_3BindingNavigator)).BeginInit();
            this.table_3BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _библиотекиLabel
            // 
            _библиотекиLabel.AutoSize = true;
            _библиотекиLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _библиотекиLabel.Location = new System.Drawing.Point(65, 222);
            _библиотекиLabel.Name = "_библиотекиLabel";
            _библиотекиLabel.Size = new System.Drawing.Size(183, 27);
            _библиотекиLabel.TabIndex = 1;
            _библиотекиLabel.Text = "№библиотеки:";
            // 
            // шифр_книгиLabel
            // 
            шифр_книгиLabel.AutoSize = true;
            шифр_книгиLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            шифр_книгиLabel.Location = new System.Drawing.Point(81, 277);
            шифр_книгиLabel.Name = "шифр_книгиLabel";
            шифр_книгиLabel.Size = new System.Drawing.Size(160, 27);
            шифр_книгиLabel.TabIndex = 3;
            шифр_книгиLabel.Text = "шифр книги:";
            // 
            // наименование_залаLabel
            // 
            наименование_залаLabel.AutoSize = true;
            наименование_залаLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_залаLabel.Location = new System.Drawing.Point(25, 331);
            наименование_залаLabel.Name = "наименование_залаLabel";
            наименование_залаLabel.Size = new System.Drawing.Size(252, 27);
            наименование_залаLabel.TabIndex = 5;
            наименование_залаLabel.Text = "наименование зала:";
            // 
            // kogda_eto_konchitsaDataSet
            // 
            this.kogda_eto_konchitsaDataSet.DataSetName = "kogda_eto_konchitsaDataSet";
            this.kogda_eto_konchitsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_3BindingSource
            // 
            this.table_3BindingSource.DataMember = "Table_3";
            this.table_3BindingSource.DataSource = this.kogda_eto_konchitsaDataSet;
            // 
            // table_3TableAdapter
            // 
            this.table_3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.Table_2TableAdapter = null;
            this.tableAdapterManager.Table_3TableAdapter = this.table_3TableAdapter;
            this.tableAdapterManager.UpdateOrder = kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_3BindingNavigator
            // 
            this.table_3BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_3BindingNavigator.BindingSource = this.table_3BindingSource;
            this.table_3BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_3BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_3BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table_3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table_3BindingNavigatorSaveItem});
            this.table_3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_3BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_3BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_3BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_3BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_3BindingNavigator.Name = "table_3BindingNavigator";
            this.table_3BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_3BindingNavigator.Size = new System.Drawing.Size(515, 27);
            this.table_3BindingNavigator.TabIndex = 0;
            this.table_3BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // table_3BindingNavigatorSaveItem
            // 
            this.table_3BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_3BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_3BindingNavigatorSaveItem.Image")));
            this.table_3BindingNavigatorSaveItem.Name = "table_3BindingNavigatorSaveItem";
            this.table_3BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.table_3BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_3BindingNavigatorSaveItem.Click += new System.EventHandler(this.table_3BindingNavigatorSaveItem_Click);
            // 
            // _библиотекиTextBox
            // 
            this._библиотекиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_3BindingSource, "№библиотеки", true));
            this._библиотекиTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._библиотекиTextBox.Location = new System.Drawing.Point(302, 219);
            this._библиотекиTextBox.Name = "_библиотекиTextBox";
            this._библиотекиTextBox.Size = new System.Drawing.Size(155, 36);
            this._библиотекиTextBox.TabIndex = 2;
            // 
            // шифр_книгиTextBox
            // 
            this.шифр_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_3BindingSource, "шифр книги", true));
            this.шифр_книгиTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.шифр_книгиTextBox.Location = new System.Drawing.Point(302, 274);
            this.шифр_книгиTextBox.Name = "шифр_книгиTextBox";
            this.шифр_книгиTextBox.Size = new System.Drawing.Size(155, 36);
            this.шифр_книгиTextBox.TabIndex = 4;
            // 
            // наименование_залаTextBox
            // 
            this.наименование_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_3BindingSource, "наименование зала", true));
            this.наименование_залаTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_залаTextBox.Location = new System.Drawing.Point(302, 328);
            this.наименование_залаTextBox.Name = "наименование_залаTextBox";
            this.наименование_залаTextBox.Size = new System.Drawing.Size(155, 36);
            this.наименование_залаTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(155, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Работники";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(267, 397);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 54);
            this.button9.TabIndex = 29;
            this.button9.Text = "таблица";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(142, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(наименование_залаLabel);
            this.Controls.Add(this.наименование_залаTextBox);
            this.Controls.Add(шифр_книгиLabel);
            this.Controls.Add(this.шифр_книгиTextBox);
            this.Controls.Add(_библиотекиLabel);
            this.Controls.Add(this._библиотекиTextBox);
            this.Controls.Add(this.table_3BindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_3BindingNavigator)).EndInit();
            this.table_3BindingNavigator.ResumeLayout(false);
            this.table_3BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.BindingSource table_3BindingSource;
        private System.Windows.Forms.BindingNavigator table_3BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_3BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox _библиотекиTextBox;
        private System.Windows.Forms.TextBox шифр_книгиTextBox;
        private System.Windows.Forms.TextBox наименование_залаTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
    }
}