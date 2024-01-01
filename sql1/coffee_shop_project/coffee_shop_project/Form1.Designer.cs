namespace coffee_shop_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cntmomos = new System.Windows.Forms.NumericUpDown();
            this.cntfries = new System.Windows.Forms.NumericUpDown();
            this.cntmaggie = new System.Windows.Forms.NumericUpDown();
            this.txtmomos = new System.Windows.Forms.CheckBox();
            this.txtfries = new System.Windows.Forms.CheckBox();
            this.txtmaggie = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cntcoldcoffee = new System.Windows.Forms.NumericUpDown();
            this.cntcoffee = new System.Windows.Forms.NumericUpDown();
            this.cnttea = new System.Windows.Forms.NumericUpDown();
            this.txtcoldcoffee = new System.Windows.Forms.CheckBox();
            this.txtcoffee = new System.Windows.Forms.CheckBox();
            this.txttea = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntmomos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntfries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntmaggie)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntcoldcoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntcoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "coffee shop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cntmomos);
            this.groupBox1.Controls.Add(this.cntfries);
            this.groupBox1.Controls.Add(this.cntmaggie);
            this.groupBox1.Controls.Add(this.txtmomos);
            this.groupBox1.Controls.Add(this.txtfries);
            this.groupBox1.Controls.Add(this.txtmaggie);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rice";
            // 
            // cntmomos
            // 
            this.cntmomos.Location = new System.Drawing.Point(86, 126);
            this.cntmomos.Name = "cntmomos";
            this.cntmomos.Size = new System.Drawing.Size(125, 22);
            this.cntmomos.TabIndex = 5;
            // 
            // cntfries
            // 
            this.cntfries.Location = new System.Drawing.Point(86, 81);
            this.cntfries.Name = "cntfries";
            this.cntfries.Size = new System.Drawing.Size(125, 22);
            this.cntfries.TabIndex = 4;
            // 
            // cntmaggie
            // 
            this.cntmaggie.Location = new System.Drawing.Point(86, 38);
            this.cntmaggie.Name = "cntmaggie";
            this.cntmaggie.Size = new System.Drawing.Size(121, 22);
            this.cntmaggie.TabIndex = 3;
            // 
            // txtmomos
            // 
            this.txtmomos.AutoSize = true;
            this.txtmomos.Location = new System.Drawing.Point(6, 123);
            this.txtmomos.Name = "txtmomos";
            this.txtmomos.Size = new System.Drawing.Size(74, 20);
            this.txtmomos.TabIndex = 2;
            this.txtmomos.Text = "momos";
            this.txtmomos.UseVisualStyleBackColor = true;
            // 
            // txtfries
            // 
            this.txtfries.AutoSize = true;
            this.txtfries.Location = new System.Drawing.Point(6, 81);
            this.txtfries.Name = "txtfries";
            this.txtfries.Size = new System.Drawing.Size(80, 20);
            this.txtfries.TabIndex = 1;
            this.txtfries.Text = "fried rice";
            this.txtfries.UseVisualStyleBackColor = true;
            // 
            // txtmaggie
            // 
            this.txtmaggie.AutoSize = true;
            this.txtmaggie.Location = new System.Drawing.Point(6, 40);
            this.txtmaggie.Name = "txtmaggie";
            this.txtmaggie.Size = new System.Drawing.Size(62, 20);
            this.txtmaggie.TabIndex = 0;
            this.txtmaggie.Text = "magii";
            this.txtmaggie.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cntcoldcoffee);
            this.groupBox2.Controls.Add(this.cntcoffee);
            this.groupBox2.Controls.Add(this.cnttea);
            this.groupBox2.Controls.Add(this.txtcoldcoffee);
            this.groupBox2.Controls.Add(this.txtcoffee);
            this.groupBox2.Controls.Add(this.txttea);
            this.groupBox2.Location = new System.Drawing.Point(270, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "drink";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cntcoldcoffee
            // 
            this.cntcoldcoffee.Location = new System.Drawing.Point(107, 123);
            this.cntcoldcoffee.Name = "cntcoldcoffee";
            this.cntcoldcoffee.Size = new System.Drawing.Size(120, 22);
            this.cntcoldcoffee.TabIndex = 5;
            // 
            // cntcoffee
            // 
            this.cntcoffee.Location = new System.Drawing.Point(107, 79);
            this.cntcoffee.Name = "cntcoffee";
            this.cntcoffee.Size = new System.Drawing.Size(120, 22);
            this.cntcoffee.TabIndex = 4;
            // 
            // cnttea
            // 
            this.cnttea.Location = new System.Drawing.Point(107, 37);
            this.cnttea.Name = "cnttea";
            this.cnttea.Size = new System.Drawing.Size(120, 22);
            this.cnttea.TabIndex = 3;
            // 
            // txtcoldcoffee
            // 
            this.txtcoldcoffee.AutoSize = true;
            this.txtcoldcoffee.Location = new System.Drawing.Point(6, 124);
            this.txtcoldcoffee.Name = "txtcoldcoffee";
            this.txtcoldcoffee.Size = new System.Drawing.Size(95, 20);
            this.txtcoldcoffee.TabIndex = 2;
            this.txtcoldcoffee.Text = "cold coffee";
            this.txtcoldcoffee.UseVisualStyleBackColor = true;
            // 
            // txtcoffee
            // 
            this.txtcoffee.AutoSize = true;
            this.txtcoffee.Location = new System.Drawing.Point(6, 82);
            this.txtcoffee.Name = "txtcoffee";
            this.txtcoffee.Size = new System.Drawing.Size(66, 20);
            this.txtcoffee.TabIndex = 1;
            this.txtcoffee.Text = "coffee";
            this.txtcoffee.UseVisualStyleBackColor = true;
            // 
            // txttea
            // 
            this.txttea.AutoSize = true;
            this.txttea.Location = new System.Drawing.Point(6, 38);
            this.txttea.Name = "txttea";
            this.txttea.Size = new System.Drawing.Size(54, 20);
            this.txttea.TabIndex = 0;
            this.txttea.Text = "Tea";
            this.txttea.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 185);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(650, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(630, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(630, 477);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 34);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 549);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "coffee shope";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntmomos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntfries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntmaggie)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntcoldcoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntcoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox txtmomos;
        private System.Windows.Forms.CheckBox txtfries;
        private System.Windows.Forms.CheckBox txtmaggie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox txtcoldcoffee;
        private System.Windows.Forms.CheckBox txtcoffee;
        private System.Windows.Forms.CheckBox txttea;
        private System.Windows.Forms.NumericUpDown cntmomos;
        private System.Windows.Forms.NumericUpDown cntfries;
        private System.Windows.Forms.NumericUpDown cntmaggie;
        private System.Windows.Forms.NumericUpDown cntcoldcoffee;
        private System.Windows.Forms.NumericUpDown cntcoffee;
        private System.Windows.Forms.NumericUpDown cnttea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

