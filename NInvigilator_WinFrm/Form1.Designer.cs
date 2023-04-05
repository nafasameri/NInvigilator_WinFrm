namespace NInvigilator_WinFrm
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.grbGetData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromHour = new System.Windows.Forms.TextBox();
            this.txtFromMin = new System.Windows.Forms.TextBox();
            this.txtFromSecond = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToSecond = new System.Windows.Forms.TextBox();
            this.txtToMin = new System.Windows.Forms.TextBox();
            this.txtToHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbShow = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToSecondSow = new System.Windows.Forms.TextBox();
            this.txtToMinShow = new System.Windows.Forms.TextBox();
            this.txtToHourShow = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNameShow = new System.Windows.Forms.TextBox();
            this.txtFromSecondShow = new System.Windows.Forms.TextBox();
            this.txtFromMinShow = new System.Windows.Forms.TextBox();
            this.txtFromHourShow = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grbGetData.SuspendLayout();
            this.grbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(15, 27);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(125, 51);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 100);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 51);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grbGetData
            // 
            this.grbGetData.Controls.Add(this.grbShow);
            this.grbGetData.Controls.Add(this.btnSave);
            this.grbGetData.Controls.Add(this.label7);
            this.grbGetData.Controls.Add(this.label6);
            this.grbGetData.Controls.Add(this.txtToSecond);
            this.grbGetData.Controls.Add(this.txtToMin);
            this.grbGetData.Controls.Add(this.txtToHour);
            this.grbGetData.Controls.Add(this.label3);
            this.grbGetData.Controls.Add(this.label5);
            this.grbGetData.Controls.Add(this.label4);
            this.grbGetData.Controls.Add(this.txtName);
            this.grbGetData.Controls.Add(this.txtFromSecond);
            this.grbGetData.Controls.Add(this.txtFromMin);
            this.grbGetData.Controls.Add(this.txtFromHour);
            this.grbGetData.Controls.Add(this.label2);
            this.grbGetData.Controls.Add(this.label1);
            this.grbGetData.Location = new System.Drawing.Point(161, 14);
            this.grbGetData.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grbGetData.Name = "grbGetData";
            this.grbGetData.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grbGetData.Size = new System.Drawing.Size(495, 330);
            this.grbGetData.TabIndex = 2;
            this.grbGetData.TabStop = false;
            this.grbGetData.Text = "Get Data";
            this.grbGetData.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // txtFromHour
            // 
            this.txtFromHour.Location = new System.Drawing.Point(100, 154);
            this.txtFromHour.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromHour.Name = "txtFromHour";
            this.txtFromHour.Size = new System.Drawing.Size(54, 38);
            this.txtFromHour.TabIndex = 2;
            // 
            // txtFromMin
            // 
            this.txtFromMin.Location = new System.Drawing.Point(197, 154);
            this.txtFromMin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromMin.Name = "txtFromMin";
            this.txtFromMin.Size = new System.Drawing.Size(54, 38);
            this.txtFromMin.TabIndex = 3;
            // 
            // txtFromSecond
            // 
            this.txtFromSecond.Location = new System.Drawing.Point(294, 154);
            this.txtFromSecond.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromSecond.Name = "txtFromSecond";
            this.txtFromSecond.Size = new System.Drawing.Size(54, 38);
            this.txtFromSecond.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 38);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // txtToSecond
            // 
            this.txtToSecond.Location = new System.Drawing.Point(295, 216);
            this.txtToSecond.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToSecond.Name = "txtToSecond";
            this.txtToSecond.Size = new System.Drawing.Size(54, 38);
            this.txtToSecond.TabIndex = 11;
            // 
            // txtToMin
            // 
            this.txtToMin.Location = new System.Drawing.Point(198, 216);
            this.txtToMin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToMin.Name = "txtToMin";
            this.txtToMin.Size = new System.Drawing.Size(54, 38);
            this.txtToMin.TabIndex = 10;
            // 
            // txtToHour
            // 
            this.txtToHour.Location = new System.Drawing.Point(101, 216);
            this.txtToHour.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToHour.Name = "txtToHour";
            this.txtToHour.Size = new System.Drawing.Size(54, 38);
            this.txtToHour.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "from";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "to";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 51);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbShow
            // 
            this.grbShow.Controls.Add(this.btnNext);
            this.grbShow.Controls.Add(this.label8);
            this.grbShow.Controls.Add(this.label9);
            this.grbShow.Controls.Add(this.txtToSecondSow);
            this.grbShow.Controls.Add(this.txtToMinShow);
            this.grbShow.Controls.Add(this.txtToHourShow);
            this.grbShow.Controls.Add(this.label10);
            this.grbShow.Controls.Add(this.label11);
            this.grbShow.Controls.Add(this.label12);
            this.grbShow.Controls.Add(this.txtNameShow);
            this.grbShow.Controls.Add(this.txtFromSecondShow);
            this.grbShow.Controls.Add(this.txtFromMinShow);
            this.grbShow.Controls.Add(this.txtFromHourShow);
            this.grbShow.Controls.Add(this.label13);
            this.grbShow.Controls.Add(this.label14);
            this.grbShow.Location = new System.Drawing.Point(0, 0);
            this.grbShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grbShow.Name = "grbShow";
            this.grbShow.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grbShow.Size = new System.Drawing.Size(495, 330);
            this.grbShow.TabIndex = 3;
            this.grbShow.TabStop = false;
            this.grbShow.Text = "Show";
            this.grbShow.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(362, 271);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 51);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "from";
            // 
            // txtToSecondSow
            // 
            this.txtToSecondSow.Location = new System.Drawing.Point(295, 216);
            this.txtToSecondSow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToSecondSow.Name = "txtToSecondSow";
            this.txtToSecondSow.Size = new System.Drawing.Size(54, 38);
            this.txtToSecondSow.TabIndex = 11;
            // 
            // txtToMinShow
            // 
            this.txtToMinShow.Location = new System.Drawing.Point(198, 216);
            this.txtToMinShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToMinShow.Name = "txtToMinShow";
            this.txtToMinShow.Size = new System.Drawing.Size(54, 38);
            this.txtToMinShow.TabIndex = 10;
            // 
            // txtToHourShow
            // 
            this.txtToHourShow.Location = new System.Drawing.Point(101, 216);
            this.txtToHourShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtToHourShow.Name = "txtToHourShow";
            this.txtToHourShow.Size = new System.Drawing.Size(54, 38);
            this.txtToHourShow.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 31);
            this.label11.TabIndex = 7;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 31);
            this.label12.TabIndex = 6;
            this.label12.Text = "Name";
            // 
            // txtNameShow
            // 
            this.txtNameShow.Location = new System.Drawing.Point(101, 85);
            this.txtNameShow.Name = "txtNameShow";
            this.txtNameShow.Size = new System.Drawing.Size(248, 38);
            this.txtNameShow.TabIndex = 5;
            // 
            // txtFromSecondShow
            // 
            this.txtFromSecondShow.Location = new System.Drawing.Point(294, 154);
            this.txtFromSecondShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromSecondShow.Name = "txtFromSecondShow";
            this.txtFromSecondShow.Size = new System.Drawing.Size(54, 38);
            this.txtFromSecondShow.TabIndex = 4;
            // 
            // txtFromMinShow
            // 
            this.txtFromMinShow.Location = new System.Drawing.Point(197, 154);
            this.txtFromMinShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromMinShow.Name = "txtFromMinShow";
            this.txtFromMinShow.Size = new System.Drawing.Size(54, 38);
            this.txtFromMinShow.TabIndex = 3;
            // 
            // txtFromHourShow
            // 
            this.txtFromHourShow.Location = new System.Drawing.Point(100, 154);
            this.txtFromHourShow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFromHourShow.Name = "txtFromHourShow";
            this.txtFromHourShow.Size = new System.Drawing.Size(54, 38);
            this.txtFromHourShow.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 31);
            this.label13.TabIndex = 1;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 355);
            this.Controls.Add(this.grbGetData);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGetData);
            this.Font = new System.Drawing.Font("Segoe Print", 11.76923F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbGetData.ResumeLayout(false);
            this.grbGetData.PerformLayout();
            this.grbShow.ResumeLayout(false);
            this.grbShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox grbGetData;
        private System.Windows.Forms.TextBox txtFromSecond;
        private System.Windows.Forms.TextBox txtFromMin;
        private System.Windows.Forms.TextBox txtFromHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToSecond;
        private System.Windows.Forms.TextBox txtToMin;
        private System.Windows.Forms.TextBox txtToHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbShow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToSecondSow;
        private System.Windows.Forms.TextBox txtToMinShow;
        private System.Windows.Forms.TextBox txtToHourShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameShow;
        private System.Windows.Forms.TextBox txtFromSecondShow;
        private System.Windows.Forms.TextBox txtFromMinShow;
        private System.Windows.Forms.TextBox txtFromHourShow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

