namespace FlieProjectFinal
{
    partial class Create_table
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
            this.NumOfCol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colname = new System.Windows.Forms.TextBox();
            this.constraints = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumOfRows = new System.Windows.Forms.Label();
            this.Add_Row = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.del_button = new System.Windows.Forms.Button();
            this.deletecombo = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.primaryselect = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumOfCol
            // 
            this.NumOfCol.AutoSize = true;
            this.NumOfCol.Location = new System.Drawing.Point(22, 28);
            this.NumOfCol.Name = "NumOfCol";
            this.NumOfCol.Size = new System.Drawing.Size(155, 17);
            this.NumOfCol.TabIndex = 23;
            this.NumOfCol.Text = "Number OF Columns:0 ";
            this.NumOfCol.Click += new System.EventHandler(this.NumOfCol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colname
            // 
            this.colname.Location = new System.Drawing.Point(139, 58);
            this.colname.Name = "colname";
            this.colname.Size = new System.Drawing.Size(185, 22);
            this.colname.TabIndex = 16;
            // 
            // constraints
            // 
            this.constraints.FormattingEnabled = true;
            this.constraints.Items.AddRange(new object[] {
            "Forgien Key",
            "Gender",
            "Nothing"});
            this.constraints.Location = new System.Drawing.Point(139, 124);
            this.constraints.Name = "constraints";
            this.constraints.Size = new System.Drawing.Size(185, 24);
            this.constraints.TabIndex = 18;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(58, 183);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 30);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add Column";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Coulmn Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumOfRows);
            this.groupBox1.Controls.Add(this.Add_Row);
            this.groupBox1.Controls.Add(this.NumOfCol);
            this.groupBox1.Controls.Add(this.colname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.constraints);
            this.groupBox1.Location = new System.Drawing.Point(12, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 228);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Columns / Row";
            // 
            // NumOfRows
            // 
            this.NumOfRows.AutoSize = true;
            this.NumOfRows.Location = new System.Drawing.Point(258, 28);
            this.NumOfRows.Name = "NumOfRows";
            this.NumOfRows.Size = new System.Drawing.Size(132, 17);
            this.NumOfRows.TabIndex = 28;
            this.NumOfRows.Text = "Number of Rows : 0";
            // 
            // Add_Row
            // 
            this.Add_Row.Location = new System.Drawing.Point(227, 183);
            this.Add_Row.Name = "Add_Row";
            this.Add_Row.Size = new System.Drawing.Size(133, 30);
            this.Add_Row.TabIndex = 27;
            this.Add_Row.Text = "Add Row";
            this.Add_Row.UseVisualStyleBackColor = true;
            this.Add_Row.Click += new System.EventHandler(this.Add_Row_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.del_button);
            this.groupBox2.Controls.Add(this.deletecombo);
            this.groupBox2.Location = new System.Drawing.Point(569, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 213);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Columns";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Coulmn To Delete";
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(48, 161);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(108, 23);
            this.del_button.TabIndex = 1;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // deletecombo
            // 
            this.deletecombo.FormattingEnabled = true;
            this.deletecombo.Location = new System.Drawing.Point(48, 72);
            this.deletecombo.Name = "deletecombo";
            this.deletecombo.Size = new System.Drawing.Size(245, 24);
            this.deletecombo.TabIndex = 0;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 21);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1441, 431);
            this.table.TabIndex = 26;
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.primaryselect);
            this.groupBox3.Location = new System.Drawing.Point(1036, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 100);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Primary";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Make Primary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // primaryselect
            // 
            this.primaryselect.FormattingEnabled = true;
            this.primaryselect.Location = new System.Drawing.Point(46, 28);
            this.primaryselect.Name = "primaryselect";
            this.primaryselect.Size = new System.Drawing.Size(215, 24);
            this.primaryselect.TabIndex = 0;
            // 
            // Create_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 739);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Create_table";
            this.Text = "Create_table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumOfCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox colname;
        private System.Windows.Forms.ComboBox constraints;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.ComboBox deletecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button Add_Row;
        private System.Windows.Forms.Label NumOfRows;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox primaryselect;
    }
}