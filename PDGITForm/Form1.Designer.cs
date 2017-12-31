namespace PDGIT1730
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
            this.stuName = new System.Windows.Forms.TextBox();
            this.stuAge = new System.Windows.Forms.TextBox();
            this.stuRoll = new System.Windows.Forms.TextBox();
            this.stuGender = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuRollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updatebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(130, 30);
            this.stuName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(252, 24);
            this.stuName.TabIndex = 0;
            // 
            // stuAge
            // 
            this.stuAge.Location = new System.Drawing.Point(130, 90);
            this.stuAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stuAge.Name = "stuAge";
            this.stuAge.Size = new System.Drawing.Size(252, 24);
            this.stuAge.TabIndex = 2;
            // 
            // stuRoll
            // 
            this.stuRoll.Location = new System.Drawing.Point(514, 30);
            this.stuRoll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stuRoll.Name = "stuRoll";
            this.stuRoll.Size = new System.Drawing.Size(270, 24);
            this.stuRoll.TabIndex = 3;
            // 
            // stuGender
            // 
            this.stuGender.FormattingEnabled = true;
            this.stuGender.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.stuGender.Location = new System.Drawing.Point(514, 87);
            this.stuGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stuGender.Name = "stuGender";
            this.stuGender.Size = new System.Drawing.Size(270, 23);
            this.stuGender.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(293, 130);
            this.save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 27);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(388, 130);
            this.update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 27);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Roll :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Updatebtn,
            this.Deletebtn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(14, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            // 
            // stuRollDataGridViewTextBoxColumn
            // 
            this.stuRollDataGridViewTextBoxColumn.Name = "stuRollDataGridViewTextBoxColumn";
            // 
            // stuAgeDataGridViewTextBoxColumn
            // 
            this.stuAgeDataGridViewTextBoxColumn.Name = "stuAgeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Frozen = true;
            this.Updatebtn.HeaderText = "Edit";
            this.Updatebtn.MinimumWidth = 3;
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Text = "Edit";
            this.Updatebtn.ToolTipText = "Edit";
            this.Updatebtn.Width = 50;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Frozen = true;
            this.Deletebtn.HeaderText = "Delete";
            this.Deletebtn.MinimumWidth = 3;
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 155);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.stuGender);
            this.Controls.Add(this.stuRoll);
            this.Controls.Add(this.stuAge);
            this.Controls.Add(this.stuName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Saul Hamidur Rahman, PGDIT-1730 (Crud Operation)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.TextBox stuAge;
        private System.Windows.Forms.TextBox stuRoll;
        private System.Windows.Forms.ComboBox stuGender;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuRollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Updatebtn;
        private System.Windows.Forms.DataGridViewButtonColumn Deletebtn;
        private System.Windows.Forms.Panel panel1;
    }
}

