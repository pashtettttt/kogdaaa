namespace kogdaaa
{
    partial class Form5
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
            System.Windows.Forms.Label шифр_книгиLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label издательствоLabel;
            System.Windows.Forms.Label годLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.kogda_eto_konchitsaDataSet = new kogdaaa.kogda_eto_konchitsaDataSet();
            this.table_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.Table_1TableAdapter();
            this.tableAdapterManager = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager();
            this.table_1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table_1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.шифр_книгиTextBox = new System.Windows.Forms.TextBox();
            this.авторTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.издательствоTextBox = new System.Windows.Forms.TextBox();
            this.годTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            шифр_книгиLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            издательствоLabel = new System.Windows.Forms.Label();
            годLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingNavigator)).BeginInit();
            this.table_1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // шифр_книгиLabel
            // 
            шифр_книгиLabel.AutoSize = true;
            шифр_книгиLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            шифр_книгиLabel.Location = new System.Drawing.Point(57, 173);
            шифр_книгиLabel.Name = "шифр_книгиLabel";
            шифр_книгиLabel.Size = new System.Drawing.Size(160, 27);
            шифр_книгиLabel.TabIndex = 1;
            шифр_книгиLabel.Text = "шифр книги:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            авторLabel.Location = new System.Drawing.Point(94, 220);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(87, 27);
            авторLabel.TabIndex = 3;
            авторLabel.Text = "автор:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.Location = new System.Drawing.Point(69, 267);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(127, 27);
            названиеLabel.TabIndex = 5;
            названиеLabel.Text = "название:";
            // 
            // издательствоLabel
            // 
            издательствоLabel.AutoSize = true;
            издательствоLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            издательствоLabel.Location = new System.Drawing.Point(41, 315);
            издательствоLabel.Name = "издательствоLabel";
            издательствоLabel.Size = new System.Drawing.Size(178, 27);
            издательствоLabel.TabIndex = 7;
            издательствоLabel.Text = "издательство:";
            // 
            // годLabel
            // 
            годLabel.AutoSize = true;
            годLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            годLabel.Location = new System.Drawing.Point(111, 366);
            годLabel.Name = "годLabel";
            годLabel.Size = new System.Drawing.Size(57, 27);
            годLabel.TabIndex = 9;
            годLabel.Text = "год:";
            // 
            // kogda_eto_konchitsaDataSet
            // 
            this.kogda_eto_konchitsaDataSet.DataSetName = "kogda_eto_konchitsaDataSet";
            this.kogda_eto_konchitsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1BindingSource
            // 
            this.table_1BindingSource.DataMember = "Table_1";
            this.table_1BindingSource.DataSource = this.kogda_eto_konchitsaDataSet;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_1TableAdapter = this.table_1TableAdapter;
            this.tableAdapterManager.Table_2TableAdapter = null;
            this.tableAdapterManager.Table_3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_1BindingNavigator
            // 
            this.table_1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_1BindingNavigator.BindingSource = this.table_1BindingSource;
            this.table_1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table_1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_1BindingNavigatorSaveItem});
            this.table_1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_1BindingNavigator.Name = "table_1BindingNavigator";
            this.table_1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_1BindingNavigator.Size = new System.Drawing.Size(421, 31);
            this.table_1BindingNavigator.TabIndex = 0;
            this.table_1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // table_1BindingNavigatorSaveItem
            // 
            this.table_1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_1BindingNavigatorSaveItem.Image")));
            this.table_1BindingNavigatorSaveItem.Name = "table_1BindingNavigatorSaveItem";
            this.table_1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.table_1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_1BindingNavigatorSaveItem.Click += new System.EventHandler(this.table_1BindingNavigatorSaveItem_Click);
            // 
            // шифр_книгиTextBox
            // 
            this.шифр_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "шифр книги", true));
            this.шифр_книгиTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.шифр_книгиTextBox.Location = new System.Drawing.Point(235, 170);
            this.шифр_книгиTextBox.Name = "шифр_книгиTextBox";
            this.шифр_книгиTextBox.Size = new System.Drawing.Size(156, 36);
            this.шифр_книгиTextBox.TabIndex = 2;
            // 
            // авторTextBox
            // 
            this.авторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "автор", true));
            this.авторTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.авторTextBox.Location = new System.Drawing.Point(235, 217);
            this.авторTextBox.Name = "авторTextBox";
            this.авторTextBox.Size = new System.Drawing.Size(156, 36);
            this.авторTextBox.TabIndex = 4;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "название", true));
            this.названиеTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox.Location = new System.Drawing.Point(235, 264);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(156, 36);
            this.названиеTextBox.TabIndex = 6;
            // 
            // издательствоTextBox
            // 
            this.издательствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "издательство", true));
            this.издательствоTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.издательствоTextBox.Location = new System.Drawing.Point(235, 312);
            this.издательствоTextBox.Name = "издательствоTextBox";
            this.издательствоTextBox.Size = new System.Drawing.Size(156, 36);
            this.издательствоTextBox.TabIndex = 8;
            // 
            // годTextBox
            // 
            this.годTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "год", true));
            this.годTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.годTextBox.Location = new System.Drawing.Point(235, 363);
            this.годTextBox.Name = "годTextBox";
            this.годTextBox.Size = new System.Drawing.Size(156, 36);
            this.годTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Заказчики";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(220, 428);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 54);
            this.button9.TabIndex = 20;
            this.button9.Text = "таблица";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(95, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(годLabel);
            this.Controls.Add(this.годTextBox);
            this.Controls.Add(издательствоLabel);
            this.Controls.Add(this.издательствоTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(авторLabel);
            this.Controls.Add(this.авторTextBox);
            this.Controls.Add(шифр_книгиLabel);
            this.Controls.Add(this.шифр_книгиTextBox);
            this.Controls.Add(this.table_1BindingNavigator);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingNavigator)).EndInit();
            this.table_1BindingNavigator.ResumeLayout(false);
            this.table_1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kogda_eto_konchitsaDataSet kogda_eto_konchitsaDataSet;
        private System.Windows.Forms.BindingSource table_1BindingSource;
        private kogda_eto_konchitsaDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox шифр_книгиTextBox;
        private System.Windows.Forms.TextBox авторTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox издательствоTextBox;
        private System.Windows.Forms.TextBox годTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
    }
}