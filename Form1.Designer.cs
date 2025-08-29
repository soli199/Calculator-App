namespace Calculator_App
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
        private void initializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnclr = new System.Windows.Forms.Button();
            this.btneql = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(276, 54);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Tag = "0";
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btndel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnclr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btneql, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnadd, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btndot, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnmin, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnmult, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btndiv, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 340);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnclr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnclr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(3, 3);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(63, 62);
            this.btnclr.TabIndex = 17;
            this.btnclr.Tag = "1";
            this.btnclr.Text = "C";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.Clear);
            // 
            // btneql
            // 
            this.btneql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneql.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneql.Location = new System.Drawing.Point(210, 275);
            this.btneql.Name = "btneql";
            this.btneql.Size = new System.Drawing.Size(63, 62);
            this.btneql.TabIndex = 16;
            this.btneql.Tag = "17";
            this.btneql.Text = "=";
            this.btneql.UseVisualStyleBackColor = false;
            this.btneql.Click += new System.EventHandler(this.Result);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(141, 275);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(63, 62);
            this.btnadd.TabIndex = 15;
            this.btnadd.Tag = "16";
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.process);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.White;
            this.btndot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(72, 275);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(63, 62);
            this.btndot.TabIndex = 14;
            this.btndot.Tag = "15";
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.button_click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 275);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(63, 62);
            this.btn0.TabIndex = 13;
            this.btn0.Tag = "14";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.White;
            this.btnmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(210, 207);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(63, 62);
            this.btnmin.TabIndex = 12;
            this.btnmin.Tag = "13";
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.process);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 11;
            this.button1.Tag = "12";
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(72, 207);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 62);
            this.btn2.TabIndex = 10;
            this.btn2.Tag = "11";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 207);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 62);
            this.btn1.TabIndex = 9;
            this.btn1.Tag = "10";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.White;
            this.btnmult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnmult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(210, 139);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(63, 62);
            this.btnmult.TabIndex = 8;
            this.btnmult.Tag = "10";
            this.btnmult.Text = "×";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.process);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.CausesValidation = false;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(141, 139);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 62);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "8";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(72, 139);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 62);
            this.btn5.TabIndex = 6;
            this.btn5.Tag = "7";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 139);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 62);
            this.btn4.TabIndex = 5;
            this.btn4.Tag = "6";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.White;
            this.btndiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndiv.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(210, 71);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(63, 62);
            this.btndiv.TabIndex = 4;
            this.btndiv.Tag = "5";
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.process);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(141, 71);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 62);
            this.btn9.TabIndex = 3;
            this.btn9.Tag = "4";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 71);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 62);
            this.btn7.TabIndex = 1;
            this.btn7.Tag = "2";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(72, 71);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 62);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "3";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Red;
            this.btndel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(72, 3);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(63, 62);
            this.btndel.TabIndex = 18;
            this.btndel.Tag = "1";
            this.btndel.Text = "Del";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.Delete);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(141, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(132, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "By: Ahmed Tahawey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(297, 418);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btneql;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label1;
    }
}

