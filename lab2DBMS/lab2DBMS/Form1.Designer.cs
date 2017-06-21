namespace lab2DBMS
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
            this.parentGrid = new System.Windows.Forms.DataGridView();
            this.childrenGrid = new System.Windows.Forms.DataGridView();
            this.displayFestBtn = new System.Windows.Forms.Button();
            this.delTicketBtn = new System.Windows.Forms.Button();
            this.updateTicketBtn = new System.Windows.Forms.Button();
            this.addTicketBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parentGrid
            // 
            this.parentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentGrid.Location = new System.Drawing.Point(28, 27);
            this.parentGrid.Name = "parentGrid";
            this.parentGrid.Size = new System.Drawing.Size(355, 136);
            this.parentGrid.TabIndex = 0;
            this.parentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentGrid_CellContentClick);
            // 
            // childrenGrid
            // 
            this.childrenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenGrid.Location = new System.Drawing.Point(237, 194);
            this.childrenGrid.Name = "childrenGrid";
            this.childrenGrid.Size = new System.Drawing.Size(355, 150);
            this.childrenGrid.TabIndex = 1;
            this.childrenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childrenGrid_CellContentClick);
            // 
            // displayFestBtn
            // 
            this.displayFestBtn.Location = new System.Drawing.Point(418, 78);
            this.displayFestBtn.Name = "displayFestBtn";
            this.displayFestBtn.Size = new System.Drawing.Size(174, 42);
            this.displayFestBtn.TabIndex = 2;
            this.displayFestBtn.Text = "Display Festivals";
            this.displayFestBtn.UseVisualStyleBackColor = true;
            this.displayFestBtn.Click += new System.EventHandler(this.displayFestBtn_Click);
            // 
            // delTicketBtn
            // 
            this.delTicketBtn.Location = new System.Drawing.Point(28, 253);
            this.delTicketBtn.Name = "delTicketBtn";
            this.delTicketBtn.Size = new System.Drawing.Size(159, 33);
            this.delTicketBtn.TabIndex = 3;
            this.delTicketBtn.Text = "Remove Ticket";
            this.delTicketBtn.UseVisualStyleBackColor = true;
            this.delTicketBtn.Click += new System.EventHandler(this.delTicketBtn_Click);
            // 
            // updateTicketBtn
            // 
            this.updateTicketBtn.Location = new System.Drawing.Point(28, 311);
            this.updateTicketBtn.Name = "updateTicketBtn";
            this.updateTicketBtn.Size = new System.Drawing.Size(159, 33);
            this.updateTicketBtn.TabIndex = 4;
            this.updateTicketBtn.Text = "Update Ticket";
            this.updateTicketBtn.UseVisualStyleBackColor = true;
            this.updateTicketBtn.Click += new System.EventHandler(this.updateTicketBtn_Click);
            // 
            // addTicketBtn
            // 
            this.addTicketBtn.Location = new System.Drawing.Point(28, 194);
            this.addTicketBtn.Name = "addTicketBtn";
            this.addTicketBtn.Size = new System.Drawing.Size(159, 33);
            this.addTicketBtn.TabIndex = 5;
            this.addTicketBtn.Text = "Add Ticket";
            this.addTicketBtn.UseVisualStyleBackColor = true;
            this.addTicketBtn.Click += new System.EventHandler(this.addTicketBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.addTicketBtn);
            this.Controls.Add(this.updateTicketBtn);
            this.Controls.Add(this.delTicketBtn);
            this.Controls.Add(this.displayFestBtn);
            this.Controls.Add(this.childrenGrid);
            this.Controls.Add(this.parentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.parentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentGrid;
        private System.Windows.Forms.DataGridView childrenGrid;
        private System.Windows.Forms.Button displayFestBtn;
        private System.Windows.Forms.Button delTicketBtn;
        private System.Windows.Forms.Button updateTicketBtn;
        private System.Windows.Forms.Button addTicketBtn;
    }
}

