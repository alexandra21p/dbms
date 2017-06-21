namespace ExamDBMS
{
    partial class Form1
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
            this.parentGrid = new System.Windows.Forms.DataGridView();
            this.examDBMSDataSet = new ExamDBMS.examDBMSDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new ExamDBMS.examDBMSDataSetTableAdapters.gameTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new ExamDBMS.examDBMSDataSetTableAdapters.companyTableAdapter();
            this.childrenGrid = new System.Windows.Forms.DataGridView();
            this.idGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.updateGame = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parentGrid
            // 
            this.parentGrid.AutoGenerateColumns = false;
            this.parentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameDataGridViewTextBoxColumn,
            this.website,
            this.nrEmployees});
            this.parentGrid.DataSource = this.companyBindingSource;
            this.parentGrid.Location = new System.Drawing.Point(26, 23);
            this.parentGrid.Name = "parentGrid";
            this.parentGrid.Size = new System.Drawing.Size(619, 148);
            this.parentGrid.TabIndex = 0;
            this.parentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentGrid_CellContentClick);
            // 
            // examDBMSDataSet
            // 
            this.examDBMSDataSet.DataSetName = "examDBMSDataSet";
            this.examDBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "game";
            this.gameBindingSource.DataSource = this.examDBMSDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.examDBMSDataSet;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // childrenGrid
            // 
            this.childrenGrid.AutoGenerateColumns = false;
            this.childrenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGame,
            this.nameDataGridViewTextBoxColumn1,
            this.descrDataGridViewTextBoxColumn,
            this.companyID,
            this.typeIDDataGridViewTextBoxColumn});
            this.childrenGrid.DataSource = this.gameBindingSource;
            this.childrenGrid.Location = new System.Drawing.Point(210, 201);
            this.childrenGrid.Name = "childrenGrid";
            this.childrenGrid.Size = new System.Drawing.Size(435, 154);
            this.childrenGrid.TabIndex = 1;
            this.childrenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childrenGrid_CellContentClick);
            // 
            // idGame
            // 
            this.idGame.DataPropertyName = "id";
            this.idGame.HeaderText = "id";
            this.idGame.Name = "idGame";
            this.idGame.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // companyID
            // 
            this.companyID.DataPropertyName = "companyID";
            this.companyID.HeaderText = "companyID";
            this.companyID.Name = "companyID";
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "typeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "typeID";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(26, 201);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(168, 33);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Game";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(26, 262);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(168, 33);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Remove Game";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateGame
            // 
            this.updateGame.Location = new System.Drawing.Point(26, 322);
            this.updateGame.Name = "updateGame";
            this.updateGame.Size = new System.Drawing.Size(168, 33);
            this.updateGame.TabIndex = 4;
            this.updateGame.Text = "Update Game";
            this.updateGame.UseVisualStyleBackColor = true;
            this.updateGame.Click += new System.EventHandler(this.updateGame_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "website";
            this.website.Name = "website";
            this.website.Width = 200;
            // 
            // nrEmployees
            // 
            this.nrEmployees.DataPropertyName = "nrEmployees";
            this.nrEmployees.HeaderText = "nrEmployees";
            this.nrEmployees.Name = "nrEmployees";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 381);
            this.Controls.Add(this.updateGame);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.childrenGrid);
            this.Controls.Add(this.parentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentGrid;
        private examDBMSDataSet examDBMSDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private examDBMSDataSetTableAdapters.gameTableAdapter gameTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private examDBMSDataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridView childrenGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrEmployees;
    }
}

