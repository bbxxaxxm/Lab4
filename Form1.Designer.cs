namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxname = new System.Windows.Forms.TextBox();
            this.boxyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.tbLishPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.boxMax = new System.Windows.Forms.TextBox();
            this.boxMin = new System.Windows.Forms.TextBox();
            this.boxAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxMinName = new System.Windows.Forms.TextBox();
            this.boMaxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxGPA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxname
            // 
            this.boxname.BackColor = System.Drawing.SystemColors.Window;
            this.boxname.Location = new System.Drawing.Point(65, 9);
            this.boxname.Name = "boxname";
            this.boxname.Size = new System.Drawing.Size(140, 27);
            this.boxname.TabIndex = 0;
            // 
            // boxyear
            // 
            this.boxyear.Location = new System.Drawing.Point(65, 51);
            this.boxyear.Name = "boxyear";
            this.boxyear.Size = new System.Drawing.Size(140, 27);
            this.boxyear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(90, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 36);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(27, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 20);
            this.name.TabIndex = 6;
            this.name.Text = "รายชื่อ :";
            // 
            // tbLishPerson
            // 
            this.tbLishPerson.Location = new System.Drawing.Point(113, 189);
            this.tbLishPerson.Multiline = true;
            this.tbLishPerson.Name = "tbLishPerson";
            this.tbLishPerson.Size = new System.Drawing.Size(139, 183);
            this.tbLishPerson.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "อายุทั้งหมด :";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(113, 153);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(139, 27);
            this.tbTotal.TabIndex = 8;
            this.tbTotal.Text = "0";
            // 
            // boxMax
            // 
            this.boxMax.Location = new System.Drawing.Point(113, 29);
            this.boxMax.Name = "boxMax";
            this.boxMax.Size = new System.Drawing.Size(142, 27);
            this.boxMax.TabIndex = 9;
            // 
            // boxMin
            // 
            this.boxMin.Location = new System.Drawing.Point(113, 73);
            this.boxMin.Name = "boxMin";
            this.boxMin.Size = new System.Drawing.Size(142, 27);
            this.boxMin.TabIndex = 10;
            // 
            // boxAvg
            // 
            this.boxAvg.Location = new System.Drawing.Point(113, 113);
            this.boxAvg.Name = "boxAvg";
            this.boxAvg.Size = new System.Drawing.Size(142, 27);
            this.boxAvg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "GPA Max :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "GPA Min :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = " GPA Avg :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxMinName);
            this.groupBox1.Controls.Add(this.boMaxName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxAvg);
            this.groupBox1.Controls.Add(this.boxMin);
            this.groupBox1.Controls.Add(this.boxMax);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.tbLishPerson);
            this.groupBox1.Location = new System.Drawing.Point(227, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 378);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            // 
            // boxMinName
            // 
            this.boxMinName.Location = new System.Drawing.Point(397, 70);
            this.boxMinName.Name = "boxMinName";
            this.boxMinName.Size = new System.Drawing.Size(125, 27);
            this.boxMinName.TabIndex = 19;
            // 
            // boMaxName
            // 
            this.boMaxName.Location = new System.Drawing.Point(397, 29);
            this.boMaxName.Name = "boMaxName";
            this.boMaxName.Size = new System.Drawing.Size(125, 27);
            this.boMaxName.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "GPA Min Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "GPA Max Name :";
            // 
            // boxGPA
            // 
            this.boxGPA.Location = new System.Drawing.Point(65, 91);
            this.boxGPA.Name = "boxGPA";
            this.boxGPA.Size = new System.Drawing.Size(140, 27);
            this.boxGPA.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "GPA :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxGPA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxyear);
            this.Controls.Add(this.boxname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox boxname;
        private TextBox boxyear;
        private Label label1;
        private Label label2;
        private Button buttonAdd;
        private Label name;
        private TextBox tbLishPerson;
        private Label label3;
        private TextBox tbTotal;
        private TextBox boxMax;
        private TextBox boxMin;
        private TextBox boxAvg;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox boxMinName;
        private TextBox boMaxName;
        private Label label9;
        private Label label8;
        private TextBox boxGPA;
        private Label label10;
    }
}