namespace StatsWinApp
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
            label1 = new Label();
            CalculateMean_BTN = new Button();
            listView1 = new ListView();
            StudentName = new ColumnHeader();
            Prelim = new ColumnHeader();
            Midterm = new ColumnHeader();
            Finals = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            CalculateMedian_BTN = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CalculateMode_BTN = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // CalculateMean_BTN
            // 
            CalculateMean_BTN.Location = new Point(332, 12);
            CalculateMean_BTN.Name = "CalculateMean_BTN";
            CalculateMean_BTN.Size = new Size(123, 23);
            CalculateMean_BTN.TabIndex = 1;
            CalculateMean_BTN.Text = "Calculate Mean";
            CalculateMean_BTN.UseVisualStyleBackColor = true;
            CalculateMean_BTN.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { StudentName, Prelim, Midterm, Finals });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(295, 249);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // StudentName
            // 
            StudentName.Text = "Student Name";
            StudentName.Width = 110;
            // 
            // Prelim
            // 
            Prelim.Text = "Prelim";
            // 
            // Midterm
            // 
            Midterm.Text = "Midterm";
            // 
            // Finals
            // 
            Finals.Text = "Finals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 77);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // CalculateMedian_BTN
            // 
            CalculateMedian_BTN.Location = new Point(461, 12);
            CalculateMedian_BTN.Name = "CalculateMedian_BTN";
            CalculateMedian_BTN.Size = new Size(123, 23);
            CalculateMedian_BTN.TabIndex = 5;
            CalculateMedian_BTN.Text = "Calculate Median";
            CalculateMedian_BTN.UseVisualStyleBackColor = true;
            CalculateMedian_BTN.Click += CalculateMedian_BTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 106);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 77);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 49);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // CalculateMode_BTN
            // 
            CalculateMode_BTN.Location = new Point(590, 12);
            CalculateMode_BTN.Name = "CalculateMode_BTN";
            CalculateMode_BTN.Size = new Size(123, 23);
            CalculateMode_BTN.TabIndex = 9;
            CalculateMode_BTN.Text = "Calculate Mode";
            CalculateMode_BTN.UseVisualStyleBackColor = true;
            CalculateMode_BTN.Click += CalculateMode_BTN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 106);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(590, 77);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 11;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(590, 49);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 10;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 713);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(CalculateMode_BTN);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(CalculateMedian_BTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(CalculateMean_BTN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CalculateMean_BTN;
        private ListView listView1;
        private ColumnHeader StudentName;
        private Label label2;
        private Label label3;
        private ColumnHeader Prelim;
        private ColumnHeader Midterm;
        private ColumnHeader Finals;
        private Button CalculateMedian_BTN;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CalculateMode_BTN;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}