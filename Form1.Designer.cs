namespace HW_4b
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
            this.tmrForm = new System.Windows.Forms.Timer(this.components);
            this.lblQ1 = new System.Windows.Forms.Label();
            this.ckbxQ1A1 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A2 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A3 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A4 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A5 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A6 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A7 = new System.Windows.Forms.CheckBox();
            this.ckbxQ1A8 = new System.Windows.Forms.CheckBox();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.rdbtnQ2A1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbtnQ2A2 = new System.Windows.Forms.RadioButton();
            this.rdbtnQ2A3 = new System.Windows.Forms.RadioButton();
            this.rdbtnQ2A4 = new System.Windows.Forms.RadioButton();
            this.nmbbxQ3 = new System.Windows.Forms.NumericUpDown();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.cbobxQ4 = new System.Windows.Forms.ComboBox();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAmsterDam = new System.Windows.Forms.Button();
            this.btnPSV = new System.Windows.Forms.Button();
            this.btnRotterdam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbxQ4 = new System.Windows.Forms.PictureBox();
            this.picbxQ3 = new System.Windows.Forms.PictureBox();
            this.picbxQ1 = new System.Windows.Forms.PictureBox();
            this.picbxQ2 = new System.Windows.Forms.PictureBox();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbbxQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrForm
            // 
            this.tmrForm.Interval = 1000;
            this.tmrForm.Tick += new System.EventHandler(this.tmrForm_Tick);
            // 
            // lblQ1
            // 
            this.lblQ1.AutoSize = true;
            this.lblQ1.Location = new System.Drawing.Point(13, 72);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(197, 20);
            this.lblQ1.TabIndex = 0;
            this.lblQ1.Text = "לא שיחקתי ב: ___, וב_____";
            this.lblQ1.Click += new System.EventHandler(this.lblQ1_Click);
            // 
            // ckbxQ1A1
            // 
            this.ckbxQ1A1.AutoSize = true;
            this.ckbxQ1A1.Location = new System.Drawing.Point(17, 100);
            this.ckbxQ1A1.Name = "ckbxQ1A1";
            this.ckbxQ1A1.Size = new System.Drawing.Size(75, 24);
            this.ckbxQ1A1.TabIndex = 1;
            this.ckbxQ1A1.Text = "אינטר";
            this.ckbxQ1A1.UseVisualStyleBackColor = true;
            this.ckbxQ1A1.CheckedChanged += new System.EventHandler(this.ckbxQ1A1_CheckedChanged);
            // 
            // ckbxQ1A2
            // 
            this.ckbxQ1A2.AutoSize = true;
            this.ckbxQ1A2.Location = new System.Drawing.Point(17, 130);
            this.ckbxQ1A2.Name = "ckbxQ1A2";
            this.ckbxQ1A2.Size = new System.Drawing.Size(76, 24);
            this.ckbxQ1A2.TabIndex = 2;
            this.ckbxQ1A2.Text = "מילאן";
            this.ckbxQ1A2.UseVisualStyleBackColor = true;
            this.ckbxQ1A2.CheckedChanged += new System.EventHandler(this.ckbxQ1A2_CheckedChanged);
            // 
            // ckbxQ1A3
            // 
            this.ckbxQ1A3.AutoSize = true;
            this.ckbxQ1A3.Location = new System.Drawing.Point(17, 160);
            this.ckbxQ1A3.Name = "ckbxQ1A3";
            this.ckbxQ1A3.Size = new System.Drawing.Size(84, 24);
            this.ckbxQ1A3.TabIndex = 3;
            this.ckbxQ1A3.Text = "באיירן ";
            this.ckbxQ1A3.UseVisualStyleBackColor = true;
            this.ckbxQ1A3.CheckedChanged += new System.EventHandler(this.ckbxQ1A3_CheckedChanged);
            // 
            // ckbxQ1A4
            // 
            this.ckbxQ1A4.AutoSize = true;
            this.ckbxQ1A4.Location = new System.Drawing.Point(17, 190);
            this.ckbxQ1A4.Name = "ckbxQ1A4";
            this.ckbxQ1A4.Size = new System.Drawing.Size(88, 24);
            this.ckbxQ1A4.TabIndex = 4;
            this.ckbxQ1A4.Text = "קרוזיירו";
            this.ckbxQ1A4.UseVisualStyleBackColor = true;
            this.ckbxQ1A4.CheckedChanged += new System.EventHandler(this.ckbxQ1A4_CheckedChanged);
            // 
            // ckbxQ1A5
            // 
            this.ckbxQ1A5.AutoSize = true;
            this.ckbxQ1A5.Location = new System.Drawing.Point(189, 100);
            this.ckbxQ1A5.Name = "ckbxQ1A5";
            this.ckbxQ1A5.Size = new System.Drawing.Size(91, 24);
            this.ckbxQ1A5.TabIndex = 5;
            this.ckbxQ1A5.Text = "ברצלונה";
            this.ckbxQ1A5.UseVisualStyleBackColor = true;
            this.ckbxQ1A5.CheckedChanged += new System.EventHandler(this.ckbxQ1A5_CheckedChanged);
            // 
            // ckbxQ1A6
            // 
            this.ckbxQ1A6.AutoSize = true;
            this.ckbxQ1A6.Location = new System.Drawing.Point(189, 130);
            this.ckbxQ1A6.Name = "ckbxQ1A6";
            this.ckbxQ1A6.Size = new System.Drawing.Size(69, 24);
            this.ckbxQ1A6.TabIndex = 6;
            this.ckbxQ1A6.Text = "פ.ס.ז\'";
            this.ckbxQ1A6.UseVisualStyleBackColor = true;
            this.ckbxQ1A6.CheckedChanged += new System.EventHandler(this.ckbxQ1A6_CheckedChanged);
            // 
            // ckbxQ1A7
            // 
            this.ckbxQ1A7.AutoSize = true;
            this.ckbxQ1A7.Location = new System.Drawing.Point(189, 160);
            this.ckbxQ1A7.Name = "ckbxQ1A7";
            this.ckbxQ1A7.Size = new System.Drawing.Size(109, 24);
            this.ckbxQ1A7.TabIndex = 7;
            this.ckbxQ1A7.Text = "קורינתיאנס";
            this.ckbxQ1A7.UseVisualStyleBackColor = true;
            // 
            // ckbxQ1A8
            // 
            this.ckbxQ1A8.AutoSize = true;
            this.ckbxQ1A8.Location = new System.Drawing.Point(189, 190);
            this.ckbxQ1A8.Name = "ckbxQ1A8";
            this.ckbxQ1A8.Size = new System.Drawing.Size(114, 24);
            this.ckbxQ1A8.TabIndex = 8;
            this.ckbxQ1A8.Text = "ריאל מדריד";
            this.ckbxQ1A8.UseVisualStyleBackColor = true;
            this.ckbxQ1A8.CheckedChanged += new System.EventHandler(this.ckbxQ1A8_CheckedChanged);
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Location = new System.Drawing.Point(13, 253);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(158, 20);
            this.lblQ2.TabIndex = 9;
            this.lblQ2.Text = "שמי: ___ ואן ניסטלרוי";
            // 
            // rdbtnQ2A1
            // 
            this.rdbtnQ2A1.AutoSize = true;
            this.rdbtnQ2A1.Location = new System.Drawing.Point(17, 289);
            this.rdbtnQ2A1.Name = "rdbtnQ2A1";
            this.rdbtnQ2A1.Size = new System.Drawing.Size(58, 24);
            this.rdbtnQ2A1.TabIndex = 11;
            this.rdbtnQ2A1.TabStop = true;
            this.rdbtnQ2A1.Text = "לאו";
            this.rdbtnQ2A1.UseVisualStyleBackColor = true;
            // 
            // rdbtnQ2A2
            // 
            this.rdbtnQ2A2.AutoSize = true;
            this.rdbtnQ2A2.Location = new System.Drawing.Point(16, 319);
            this.rdbtnQ2A2.Name = "rdbtnQ2A2";
            this.rdbtnQ2A2.Size = new System.Drawing.Size(57, 24);
            this.rdbtnQ2A2.TabIndex = 12;
            this.rdbtnQ2A2.TabStop = true;
            this.rdbtnQ2A2.Text = "רוד";
            this.rdbtnQ2A2.UseVisualStyleBackColor = true;
            this.rdbtnQ2A2.CheckedChanged += new System.EventHandler(this.rdbtnQ2A2_CheckedChanged);
            // 
            // rdbtnQ2A3
            // 
            this.rdbtnQ2A3.AutoSize = true;
            this.rdbtnQ2A3.Location = new System.Drawing.Point(17, 349);
            this.rdbtnQ2A3.Name = "rdbtnQ2A3";
            this.rdbtnQ2A3.Size = new System.Drawing.Size(57, 24);
            this.rdbtnQ2A3.TabIndex = 13;
            this.rdbtnQ2A3.TabStop = true;
            this.rdbtnQ2A3.Text = "בוב";
            this.rdbtnQ2A3.UseVisualStyleBackColor = true;
            // 
            // rdbtnQ2A4
            // 
            this.rdbtnQ2A4.AutoSize = true;
            this.rdbtnQ2A4.Location = new System.Drawing.Point(17, 379);
            this.rdbtnQ2A4.Name = "rdbtnQ2A4";
            this.rdbtnQ2A4.Size = new System.Drawing.Size(63, 24);
            this.rdbtnQ2A4.TabIndex = 14;
            this.rdbtnQ2A4.TabStop = true;
            this.rdbtnQ2A4.Text = "חאל";
            this.rdbtnQ2A4.UseVisualStyleBackColor = true;
            // 
            // nmbbxQ3
            // 
            this.nmbbxQ3.Location = new System.Drawing.Point(37, 505);
            this.nmbbxQ3.Name = "nmbbxQ3";
            this.nmbbxQ3.Size = new System.Drawing.Size(216, 26);
            this.nmbbxQ3.TabIndex = 15;
            this.nmbbxQ3.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Location = new System.Drawing.Point(39, 460);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(132, 20);
            this.lblQ3.TabIndex = 16;
            this.lblQ3.Text = "שיחקתי ב_ קבוצות";
            // 
            // cbobxQ4
            // 
            this.cbobxQ4.FormattingEnabled = true;
            this.cbobxQ4.Items.AddRange(new object[] {
            "ו__ו _ה ג_מה",
            "ט__ל ה_ _פ_מה",
            "א__ה _ט א_טה",
            "ק_ע_ ה_ א_תן"});
            this.cbobxQ4.Location = new System.Drawing.Point(676, 110);
            this.cbobxQ4.Name = "cbobxQ4";
            this.cbobxQ4.Size = new System.Drawing.Size(247, 28);
            this.cbobxQ4.TabIndex = 19;
            this.cbobxQ4.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblQ4
            // 
            this.lblQ4.AutoSize = true;
            this.lblQ4.Location = new System.Drawing.Point(672, 72);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(234, 20);
            this.lblQ4.TabIndex = 20;
            this.lblQ4.Text = "שיחקתי לראשונה ב_סק_ ד_ _א__";
            this.lblQ4.Click += new System.EventHandler(this.lblQ4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(676, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 20);
            this.progressBar1.TabIndex = 23;
            // 
            // btnAmsterDam
            // 
            this.btnAmsterDam.Location = new System.Drawing.Point(676, 261);
            this.btnAmsterDam.Name = "btnAmsterDam";
            this.btnAmsterDam.Size = new System.Drawing.Size(133, 58);
            this.btnAmsterDam.TabIndex = 24;
            this.btnAmsterDam.Text = "Project Sport Verticle";
            this.btnAmsterDam.UseVisualStyleBackColor = true;
            this.btnAmsterDam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPSV
            // 
            this.btnPSV.Location = new System.Drawing.Point(676, 333);
            this.btnPSV.Name = "btnPSV";
            this.btnPSV.Size = new System.Drawing.Size(137, 57);
            this.btnPSV.TabIndex = 25;
            this.btnPSV.Text = "Philips Sport Vereniging";
            this.btnPSV.UseVisualStyleBackColor = true;
            this.btnPSV.Click += new System.EventHandler(this.btnPSV_Click);
            // 
            // btnRotterdam
            // 
            this.btnRotterdam.Location = new System.Drawing.Point(676, 399);
            this.btnRotterdam.Name = "btnRotterdam";
            this.btnRotterdam.Size = new System.Drawing.Size(133, 57);
            this.btnRotterdam.TabIndex = 26;
            this.btnRotterdam.Text = "Postdam Sport Volley";
            this.btnRotterdam.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HW_4b.Properties.Resources.PSV_logo;
            this.pictureBox1.Location = new System.Drawing.Point(932, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // picbxQ4
            // 
            this.picbxQ4.Image = global::HW_4b.Properties.Resources.Romario2;
            this.picbxQ4.Location = new System.Drawing.Point(1055, 72);
            this.picbxQ4.Name = "picbxQ4";
            this.picbxQ4.Size = new System.Drawing.Size(130, 142);
            this.picbxQ4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxQ4.TabIndex = 21;
            this.picbxQ4.TabStop = false;
            // 
            // picbxQ3
            // 
            this.picbxQ3.Image = global::HW_4b.Properties.Resources.Ruud_Gullit1;
            this.picbxQ3.Location = new System.Drawing.Point(335, 460);
            this.picbxQ3.Name = "picbxQ3";
            this.picbxQ3.Size = new System.Drawing.Size(180, 138);
            this.picbxQ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxQ3.TabIndex = 18;
            this.picbxQ3.TabStop = false;
            // 
            // picbxQ1
            // 
            this.picbxQ1.Image = global::HW_4b.Properties.Resources.Ronaldo;
            this.picbxQ1.Location = new System.Drawing.Point(342, 72);
            this.picbxQ1.Name = "picbxQ1";
            this.picbxQ1.Size = new System.Drawing.Size(173, 142);
            this.picbxQ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxQ1.TabIndex = 17;
            this.picbxQ1.TabStop = false;
            // 
            // picbxQ2
            // 
            this.picbxQ2.Image = global::HW_4b.Properties.Resources.RVN;
            this.picbxQ2.Location = new System.Drawing.Point(342, 253);
            this.picbxQ2.Name = "picbxQ2";
            this.picbxQ2.Size = new System.Drawing.Size(173, 164);
            this.picbxQ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxQ2.TabIndex = 10;
            this.picbxQ2.TabStop = false;
            // 
            // lblQ5
            // 
            this.lblQ5.AutoSize = true;
            this.lblQ5.Location = new System.Drawing.Point(672, 238);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Size = new System.Drawing.Size(183, 20);
            this.lblQ5.TabIndex = 28;
            this.lblQ5.Text = "מה האותיות בשם מייצגות?";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(676, 505);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(525, 80);
            this.btnFinish.TabIndex = 29;
            this.btnFinish.Text = "סיים!";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(13, 12);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(99, 20);
            this.lblHead.TabIndex = 30;
            this.lblHead.Text = "נשאר לך עוד:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(116, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(18, 20);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 653);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblQ5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRotterdam);
            this.Controls.Add(this.btnPSV);
            this.Controls.Add(this.btnAmsterDam);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picbxQ4);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.cbobxQ4);
            this.Controls.Add(this.picbxQ3);
            this.Controls.Add(this.picbxQ1);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.nmbbxQ3);
            this.Controls.Add(this.rdbtnQ2A4);
            this.Controls.Add(this.rdbtnQ2A3);
            this.Controls.Add(this.rdbtnQ2A2);
            this.Controls.Add(this.rdbtnQ2A1);
            this.Controls.Add(this.picbxQ2);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.ckbxQ1A8);
            this.Controls.Add(this.ckbxQ1A7);
            this.Controls.Add(this.ckbxQ1A6);
            this.Controls.Add(this.ckbxQ1A5);
            this.Controls.Add(this.ckbxQ1A4);
            this.Controls.Add(this.ckbxQ1A3);
            this.Controls.Add(this.ckbxQ1A2);
            this.Controls.Add(this.ckbxQ1A1);
            this.Controls.Add(this.lblQ1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbbxQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQ2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrForm;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.CheckBox ckbxQ1A1;
        private System.Windows.Forms.CheckBox ckbxQ1A2;
        private System.Windows.Forms.CheckBox ckbxQ1A3;
        private System.Windows.Forms.CheckBox ckbxQ1A4;
        private System.Windows.Forms.CheckBox ckbxQ1A5;
        private System.Windows.Forms.CheckBox ckbxQ1A6;
        private System.Windows.Forms.CheckBox ckbxQ1A7;
        private System.Windows.Forms.CheckBox ckbxQ1A8;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.PictureBox picbxQ2;
        private System.Windows.Forms.RadioButton rdbtnQ2A1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbtnQ2A2;
        private System.Windows.Forms.RadioButton rdbtnQ2A3;
        private System.Windows.Forms.RadioButton rdbtnQ2A4;
        private System.Windows.Forms.NumericUpDown nmbbxQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.PictureBox picbxQ1;
        private System.Windows.Forms.PictureBox picbxQ3;
        private System.Windows.Forms.ComboBox cbobxQ4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.PictureBox picbxQ4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAmsterDam;
        private System.Windows.Forms.Button btnPSV;
        private System.Windows.Forms.Button btnRotterdam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQ5;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
    }
}

