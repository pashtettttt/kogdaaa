namespace kogdaaa
{
    partial class Form6
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
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.kogda_eto_konchitsaDataSet = new kogdaaa.kogda_eto_konchitsaDataSet();
            this.table_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_2TableAdapter = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.Table_2TableAdapter();
            this.tableAdapterManager = new kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager();
            this.table_2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table_2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._библиотекиTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            _библиотекиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_2BindingNavigator)).BeginInit();
            this.table_2BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _библиотекиLabel
            // 
            _библиотекиLabel.AutoSize = true;
            _библиотекиLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _библиотекиLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            _библиотекиLabel.Location = new System.Drawing.Point(26, 149);
            _библиотекиLabel.Name = "_библиотекиLabel";
            _библиотекиLabel.Size = new System.Drawing.Size(183, 27);
            _библиотекиLabel.TabIndex = 1;
            _библиотекиLabel.Text = "№библиотеки:";
            _библиотекиLabel.Click += new System.EventHandler(this._библиотекиLabel_Click);
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            адресLabel.Location = new System.Drawing.Point(79, 197);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(93, 27);
            адресLabel.TabIndex = 3;
            адресLabel.Text = "адрес:";
            адресLabel.Click += new System.EventHandler(this.адресLabel_Click);
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            телефонLabel.Location = new System.Drawing.Point(60, 246);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(125, 27);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "телефон:";
            телефонLabel.Click += new System.EventHandler(this.телефонLabel_Click);
            // 
            // kogda_eto_konchitsaDataSet
            // 
            this.kogda_eto_konchitsaDataSet.DataSetName = "kogda_eto_konchitsaDataSet";
            this.kogda_eto_konchitsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_2BindingSource
            // 
            this.table_2BindingSource.DataMember = "Table_2";
            this.table_2BindingSource.DataSource = this.kogda_eto_konchitsaDataSet;
            // 
            // table_2TableAdapter
            // 
            this.table_2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.Table_2TableAdapter = this.table_2TableAdapter;
            this.tableAdapterManager.Table_3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kogdaaa.kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_2BindingNavigator
            // 
            this.table_2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_2BindingNavigator.BindingSource = this.table_2BindingSource;
            this.table_2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_2BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.table_2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.table_2BindingNavigatorSaveItem});
            this.table_2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_2BindingNavigator.Name = "table_2BindingNavigator";
            this.table_2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_2BindingNavigator.Size = new System.Drawing.Size(437, 27);
            this.table_2BindingNavigator.TabIndex = 0;
            this.table_2BindingNavigator.Text = "bindingNavigator1";
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
            // table_2BindingNavigatorSaveItem
            // 
            this.table_2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_2BindingNavigatorSaveItem.Image")));
            this.table_2BindingNavigatorSaveItem.Name = "table_2BindingNavigatorSaveItem";
            this.table_2BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.table_2BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_2BindingNavigatorSaveItem.Click += new System.EventHandler(this.table_2BindingNavigatorSaveItem_Click);
            // 
            // _библиотекиTextBox
            // 
            this._библиотекиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_2BindingSource, "№библиотеки", true));
            this._библиотекиTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._библиотекиTextBox.Location = new System.Drawing.Point(229, 146);
            this._библиотекиTextBox.Name = "_библиотекиTextBox";
            this._библиотекиTextBox.Size = new System.Drawing.Size(169, 36);
            this._библиотекиTextBox.TabIndex = 2;
            this._библиотекиTextBox.TextChanged += new System.EventHandler(this._библиотекиTextBox_TextChanged);
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_2BindingSource, "адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox.Location = new System.Drawing.Point(229, 194);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(169, 36);
            this.адресTextBox.TabIndex = 4;
            this.адресTextBox.TextChanged += new System.EventHandler(this.адресTextBox_TextChanged);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_2BindingSource, "телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(229, 243);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(169, 36);
            this.телефонTextBox.TabIndex = 6;
            this.телефонTextBox.TextChanged += new System.EventHandler(this.телефонTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список выпускаемой продукции";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(229, 329);
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
            this.button1.Location = new System.Drawing.Point(104, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(_библиотекиLabel);
            this.Controls.Add(this._библиотекиTextBox);
            this.Controls.Add(this.table_2BindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kogda_eto_konchitsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_2BindingNavigator)).EndInit();
            this.table_2BindingNavigator.ResumeLayout(false);
            this.table_2BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kogda_eto_konchitsaDataSet kogda_eto_konchitsaDataSet;
        private System.Windows.Forms.BindingSource table_2BindingSource;
        private kogda_eto_konchitsaDataSetTableAdapters.Table_2TableAdapter table_2TableAdapter;
        private kogda_eto_konchitsaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_2BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table_2BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox _библиотекиTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
    }
}