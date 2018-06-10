namespace Ambulance_Relocation_Dispatching
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_srvy = new System.Windows.Forms.MaskedTextBox();
            this.txt_srvx = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_amby = new System.Windows.Forms.MaskedTextBox();
            this.txt_ambx = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_ran1SVy = new System.Windows.Forms.TextBox();
            this.txt_ran1SVx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_rand1path = new System.Windows.Forms.TextBox();
            this.btn_rand1run = new System.Windows.Forms.Button();
            this.txt_rand1amby = new System.Windows.Forms.MaskedTextBox();
            this.txt_rand1ambx = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_ran2svy = new System.Windows.Forms.TextBox();
            this.txt_ran2svx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_rand2path = new System.Windows.Forms.TextBox();
            this.btn_rand2run = new System.Windows.Forms.Button();
            this.txt_rand2amby = new System.Windows.Forms.MaskedTextBox();
            this.txt_rand2ambx = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_path);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.txt_srvy);
            this.tabPage1.Controls.Add(this.txt_srvx);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_amby);
            this.tabPage1.Controls.Add(this.txt_ambx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uniform Cost";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(52, 274);
            this.txt_path.Multiline = true;
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(396, 258);
            this.txt_path.TabIndex = 11;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(52, 210);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(396, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Run";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_srvy
            // 
            this.txt_srvy.Location = new System.Drawing.Point(223, 167);
            this.txt_srvy.Mask = "00,00,00,00,00";
            this.txt_srvy.Name = "txt_srvy";
            this.txt_srvy.Size = new System.Drawing.Size(100, 20);
            this.txt_srvy.TabIndex = 9;
            // 
            // txt_srvx
            // 
            this.txt_srvx.Location = new System.Drawing.Point(224, 139);
            this.txt_srvx.Mask = "00,00,00,00,00";
            this.txt_srvx.Name = "txt_srvx";
            this.txt_srvx.Size = new System.Drawing.Size(100, 20);
            this.txt_srvx.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y values (Sequentially):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X values (Sequentially):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calls Coordinates  (00-99):";
            // 
            // txt_amby
            // 
            this.txt_amby.Location = new System.Drawing.Point(224, 71);
            this.txt_amby.Mask = "00,00,00";
            this.txt_amby.Name = "txt_amby";
            this.txt_amby.Size = new System.Drawing.Size(100, 20);
            this.txt_amby.TabIndex = 4;
            // 
            // txt_ambx
            // 
            this.txt_ambx.Location = new System.Drawing.Point(224, 41);
            this.txt_ambx.Mask = "00,00,00";
            this.txt_ambx.Name = "txt_ambx";
            this.txt_ambx.Size = new System.Drawing.Size(100, 20);
            this.txt_ambx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y values (Sequentially):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X values (Sequentially):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ambulance Coordinates (00-99):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_ran1SVy);
            this.tabPage2.Controls.Add(this.txt_ran1SVx);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txt_rand1path);
            this.tabPage2.Controls.Add(this.btn_rand1run);
            this.tabPage2.Controls.Add(this.txt_rand1amby);
            this.tabPage2.Controls.Add(this.txt_rand1ambx);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Random(10)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_ran1SVy
            // 
            this.txt_ran1SVy.Location = new System.Drawing.Point(224, 154);
            this.txt_ran1SVy.Name = "txt_ran1SVy";
            this.txt_ran1SVy.ReadOnly = true;
            this.txt_ran1SVy.Size = new System.Drawing.Size(266, 20);
            this.txt_ran1SVy.TabIndex = 17;
            // 
            // txt_ran1SVx
            // 
            this.txt_ran1SVx.Location = new System.Drawing.Point(224, 126);
            this.txt_ran1SVx.Name = "txt_ran1SVx";
            this.txt_ran1SVx.ReadOnly = true;
            this.txt_ran1SVx.Size = new System.Drawing.Size(266, 20);
            this.txt_ran1SVx.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Y values (Sequentially):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "X values (Sequentially):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Services Coordinates  (00-99):";
            // 
            // txt_rand1path
            // 
            this.txt_rand1path.Location = new System.Drawing.Point(56, 229);
            this.txt_rand1path.Multiline = true;
            this.txt_rand1path.Name = "txt_rand1path";
            this.txt_rand1path.Size = new System.Drawing.Size(396, 304);
            this.txt_rand1path.TabIndex = 12;
            // 
            // btn_rand1run
            // 
            this.btn_rand1run.Location = new System.Drawing.Point(56, 198);
            this.btn_rand1run.Name = "btn_rand1run";
            this.btn_rand1run.Size = new System.Drawing.Size(396, 23);
            this.btn_rand1run.TabIndex = 11;
            this.btn_rand1run.Text = "Run";
            this.btn_rand1run.UseVisualStyleBackColor = true;
            this.btn_rand1run.Click += new System.EventHandler(this.btn_rand1run_Click);
            // 
            // txt_rand1amby
            // 
            this.txt_rand1amby.Location = new System.Drawing.Point(224, 71);
            this.txt_rand1amby.Mask = "00,00,00";
            this.txt_rand1amby.Name = "txt_rand1amby";
            this.txt_rand1amby.Size = new System.Drawing.Size(100, 20);
            this.txt_rand1amby.TabIndex = 9;
            // 
            // txt_rand1ambx
            // 
            this.txt_rand1ambx.Location = new System.Drawing.Point(224, 41);
            this.txt_rand1ambx.Mask = "00,00,00";
            this.txt_rand1ambx.Name = "txt_rand1ambx";
            this.txt_rand1ambx.Size = new System.Drawing.Size(100, 20);
            this.txt_rand1ambx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Y values (Sequentially):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "X values (Sequentially):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ambulance Coordinates (00-99):";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_ran2svy);
            this.tabPage3.Controls.Add(this.txt_ran2svx);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txt_rand2path);
            this.tabPage3.Controls.Add(this.btn_rand2run);
            this.tabPage3.Controls.Add(this.txt_rand2amby);
            this.tabPage3.Controls.Add(this.txt_rand2ambx);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(498, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Random(100)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_ran2svy
            // 
            this.txt_ran2svy.Location = new System.Drawing.Point(226, 159);
            this.txt_ran2svy.Name = "txt_ran2svy";
            this.txt_ran2svy.ReadOnly = true;
            this.txt_ran2svy.Size = new System.Drawing.Size(266, 20);
            this.txt_ran2svy.TabIndex = 24;
            // 
            // txt_ran2svx
            // 
            this.txt_ran2svx.Location = new System.Drawing.Point(226, 131);
            this.txt_ran2svx.Name = "txt_ran2svx";
            this.txt_ran2svx.ReadOnly = true;
            this.txt_ran2svx.Size = new System.Drawing.Size(266, 20);
            this.txt_ran2svx.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Y values (Sequentially):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "X values (Sequentially):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Services Coordinates  (00-99):";
            // 
            // txt_rand2path
            // 
            this.txt_rand2path.Location = new System.Drawing.Point(56, 238);
            this.txt_rand2path.Multiline = true;
            this.txt_rand2path.Name = "txt_rand2path";
            this.txt_rand2path.Size = new System.Drawing.Size(396, 296);
            this.txt_rand2path.TabIndex = 19;
            // 
            // btn_rand2run
            // 
            this.btn_rand2run.Location = new System.Drawing.Point(56, 208);
            this.btn_rand2run.Name = "btn_rand2run";
            this.btn_rand2run.Size = new System.Drawing.Size(396, 23);
            this.btn_rand2run.TabIndex = 18;
            this.btn_rand2run.Text = "Run";
            this.btn_rand2run.UseVisualStyleBackColor = true;
            this.btn_rand2run.Click += new System.EventHandler(this.btn_rand2run_Click);
            // 
            // txt_rand2amby
            // 
            this.txt_rand2amby.Location = new System.Drawing.Point(224, 72);
            this.txt_rand2amby.Mask = "00,00,00";
            this.txt_rand2amby.Name = "txt_rand2amby";
            this.txt_rand2amby.Size = new System.Drawing.Size(100, 20);
            this.txt_rand2amby.TabIndex = 17;
            // 
            // txt_rand2ambx
            // 
            this.txt_rand2ambx.Location = new System.Drawing.Point(224, 42);
            this.txt_rand2ambx.Mask = "00,00,00";
            this.txt_rand2ambx.Name = "txt_rand2ambx";
            this.txt_rand2ambx.Size = new System.Drawing.Size(100, 20);
            this.txt_rand2ambx.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Y values (Sequentially):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "X values (Sequentially):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ambulance Coordinates (00-99):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 587);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambulance Relocation&Dispatching with Nearest Neighbour";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MaskedTextBox txt_srvy;
        private System.Windows.Forms.MaskedTextBox txt_srvx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_amby;
        private System.Windows.Forms.MaskedTextBox txt_ambx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.MaskedTextBox txt_rand1amby;
        private System.Windows.Forms.MaskedTextBox txt_rand1ambx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_rand1run;
        private System.Windows.Forms.TextBox txt_rand1path;
        private System.Windows.Forms.TextBox txt_rand2path;
        private System.Windows.Forms.Button btn_rand2run;
        private System.Windows.Forms.MaskedTextBox txt_rand2amby;
        private System.Windows.Forms.MaskedTextBox txt_rand2ambx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ran1SVy;
        private System.Windows.Forms.TextBox txt_ran1SVx;
        private System.Windows.Forms.TextBox txt_ran2svy;
        private System.Windows.Forms.TextBox txt_ran2svx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

