namespace lab1DBMS
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
            this.festivalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.festDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.festivalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicFestivalsDataSet = new lab1DBMS.MusicFestivalsDataSet();
            this.addTicketBtn = new System.Windows.Forms.Button();
            this.delTicketBtn = new System.Windows.Forms.Button();
            this.updateTicketBtn = new System.Windows.Forms.Button();
            this.childrenGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.festivalIDTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new lab1DBMS.MusicFestivalsDataSetTableAdapters.ticketTableAdapter();
            this.festivalTableAdapter = new lab1DBMS.MusicFestivalsDataSetTableAdapters.festivalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFestivalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // parentGrid
            // 
            this.parentGrid.AllowUserToOrderColumns = true;
            this.parentGrid.AutoGenerateColumns = false;
            this.parentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.festivalID,
            this.name,
            this.festDate,
            this.genre,
            this.website,
            this.edition});
            this.parentGrid.DataSource = this.festivalBindingSource;
            this.parentGrid.Location = new System.Drawing.Point(17, 12);
            this.parentGrid.Name = "parentGrid";
            this.parentGrid.Size = new System.Drawing.Size(613, 156);
            this.parentGrid.TabIndex = 0;
            this.parentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentGrid_CellContentClick);
            // 
            // festivalID
            // 
            this.festivalID.DataPropertyName = "festivalID";
            this.festivalID.HeaderText = "festivalID";
            this.festivalID.Name = "festivalID";
            this.festivalID.ReadOnly = true;
            this.festivalID.Width = 70;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // festDate
            // 
            this.festDate.DataPropertyName = "festDate";
            this.festDate.HeaderText = "festDate";
            this.festDate.Name = "festDate";
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "genre";
            this.genre.Name = "genre";
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "website";
            this.website.Name = "website";
            this.website.Width = 150;
            // 
            // edition
            // 
            this.edition.DataPropertyName = "edition";
            this.edition.HeaderText = "edition";
            this.edition.Name = "edition";
            this.edition.Width = 50;
            // 
            // festivalBindingSource
            // 
            this.festivalBindingSource.DataMember = "festival";
            this.festivalBindingSource.DataSource = this.musicFestivalsDataSet;
            // 
            // musicFestivalsDataSet
            // 
            this.musicFestivalsDataSet.DataSetName = "MusicFestivalsDataSet";
            this.musicFestivalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addTicketBtn
            // 
            this.addTicketBtn.Location = new System.Drawing.Point(17, 198);
            this.addTicketBtn.Name = "addTicketBtn";
            this.addTicketBtn.Size = new System.Drawing.Size(161, 33);
            this.addTicketBtn.TabIndex = 2;
            this.addTicketBtn.Text = "Add Ticket";
            this.addTicketBtn.UseVisualStyleBackColor = true;
            this.addTicketBtn.Click += new System.EventHandler(this.addTicketBtn_Clicked);
            // 
            // delTicketBtn
            // 
            this.delTicketBtn.Location = new System.Drawing.Point(17, 250);
            this.delTicketBtn.Name = "delTicketBtn";
            this.delTicketBtn.Size = new System.Drawing.Size(161, 34);
            this.delTicketBtn.TabIndex = 3;
            this.delTicketBtn.Text = "Remove Ticket";
            this.delTicketBtn.UseVisualStyleBackColor = true;
            this.delTicketBtn.Click += new System.EventHandler(this.removeTicketBtn_Clicked);
            // 
            // updateTicketBtn
            // 
            this.updateTicketBtn.Location = new System.Drawing.Point(17, 304);
            this.updateTicketBtn.Name = "updateTicketBtn";
            this.updateTicketBtn.Size = new System.Drawing.Size(161, 32);
            this.updateTicketBtn.TabIndex = 4;
            this.updateTicketBtn.Text = "Update Ticket";
            this.updateTicketBtn.UseVisualStyleBackColor = true;
            this.updateTicketBtn.Click += new System.EventHandler(this.updateTicketBtn_Clicked);
            // 
            // childrenGrid
            // 
            this.childrenGrid.AutoGenerateColumns = false;
            this.childrenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.ticketType,
            this.festivalIDTicket,
            this.price});
            this.childrenGrid.DataSource = this.ticketBindingSource;
            this.childrenGrid.Location = new System.Drawing.Point(247, 198);
            this.childrenGrid.Name = "childrenGrid";
            this.childrenGrid.Size = new System.Drawing.Size(383, 138);
            this.childrenGrid.TabIndex = 9;
            this.childrenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childrenGrid_CellContentClick);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // ticketType
            // 
            this.ticketType.DataPropertyName = "ticketType";
            this.ticketType.HeaderText = "ticketType";
            this.ticketType.Name = "ticketType";
            // 
            // festivalIDTicket
            // 
            this.festivalIDTicket.DataPropertyName = "festivalID";
            this.festivalIDTicket.HeaderText = "festivalID";
            this.festivalIDTicket.Name = "festivalIDTicket";
            this.festivalIDTicket.Width = 70;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Width = 120;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.musicFestivalsDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // festivalTableAdapter
            // 
            this.festivalTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 354);
            this.Controls.Add(this.childrenGrid);
            this.Controls.Add(this.updateTicketBtn);
            this.Controls.Add(this.delTicketBtn);
            this.Controls.Add(this.addTicketBtn);
            this.Controls.Add(this.parentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicFestivalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentGrid;
        private System.Windows.Forms.Button addTicketBtn;
        private System.Windows.Forms.Button delTicketBtn;
        private System.Windows.Forms.Button updateTicketBtn;
        private System.Windows.Forms.DataGridView childrenGrid;
        private MusicFestivalsDataSet musicFestivalsDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private MusicFestivalsDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource festivalBindingSource;
        private MusicFestivalsDataSetTableAdapters.festivalTableAdapter festivalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn festivalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn festDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn festivalIDTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

