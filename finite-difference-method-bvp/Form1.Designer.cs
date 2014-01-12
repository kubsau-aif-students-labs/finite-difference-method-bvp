namespace finite_difference_method_bvp
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
            this.nSpinBox = new System.Windows.Forms.NumericUpDown();
            this.dataSet1 = new System.Data.DataSet();
            this.aSpinBox = new System.Windows.Forms.NumericUpDown();
            this.bSpinBox = new System.Windows.Forms.NumericUpDown();
            this.k1SpinBox = new System.Windows.Forms.NumericUpDown();
            this.k2SpinBox = new System.Windows.Forms.NumericUpDown();
            this.a1SpinBox = new System.Windows.Forms.NumericUpDown();
            this.b1SpinBox = new System.Windows.Forms.NumericUpDown();
            this.l2SpinBox = new System.Windows.Forms.NumericUpDown();
            this.l1SpinBox = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.DataGridView();
            this.epsMaxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k1SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1SpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // nSpinBox
            // 
            this.nSpinBox.Location = new System.Drawing.Point(129, 12);
            this.nSpinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSpinBox.Name = "nSpinBox";
            this.nSpinBox.Size = new System.Drawing.Size(46, 20);
            this.nSpinBox.TabIndex = 0;
            this.nSpinBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // aSpinBox
            // 
            this.aSpinBox.DecimalPlaces = 1;
            this.aSpinBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.aSpinBox.Location = new System.Drawing.Point(129, 36);
            this.aSpinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.aSpinBox.Name = "aSpinBox";
            this.aSpinBox.Size = new System.Drawing.Size(46, 20);
            this.aSpinBox.TabIndex = 1;
            this.aSpinBox.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.aSpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // bSpinBox
            // 
            this.bSpinBox.DecimalPlaces = 1;
            this.bSpinBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bSpinBox.Location = new System.Drawing.Point(181, 36);
            this.bSpinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bSpinBox.Name = "bSpinBox";
            this.bSpinBox.Size = new System.Drawing.Size(46, 20);
            this.bSpinBox.TabIndex = 2;
            this.bSpinBox.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            this.bSpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // k1SpinBox
            // 
            this.k1SpinBox.Location = new System.Drawing.Point(41, 84);
            this.k1SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k1SpinBox.Name = "k1SpinBox";
            this.k1SpinBox.Size = new System.Drawing.Size(42, 20);
            this.k1SpinBox.TabIndex = 3;
            this.k1SpinBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.k1SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // k2SpinBox
            // 
            this.k2SpinBox.Location = new System.Drawing.Point(117, 84);
            this.k2SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k2SpinBox.Name = "k2SpinBox";
            this.k2SpinBox.Size = new System.Drawing.Size(42, 20);
            this.k2SpinBox.TabIndex = 4;
            this.k2SpinBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.k2SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // a1SpinBox
            // 
            this.a1SpinBox.Location = new System.Drawing.Point(181, 84);
            this.a1SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.a1SpinBox.Name = "a1SpinBox";
            this.a1SpinBox.Size = new System.Drawing.Size(42, 20);
            this.a1SpinBox.TabIndex = 5;
            this.a1SpinBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.a1SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // b1SpinBox
            // 
            this.b1SpinBox.Location = new System.Drawing.Point(117, 108);
            this.b1SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.b1SpinBox.Name = "b1SpinBox";
            this.b1SpinBox.Size = new System.Drawing.Size(42, 20);
            this.b1SpinBox.TabIndex = 8;
            this.b1SpinBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.b1SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // l2SpinBox
            // 
            this.l2SpinBox.Location = new System.Drawing.Point(41, 108);
            this.l2SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.l2SpinBox.Name = "l2SpinBox";
            this.l2SpinBox.Size = new System.Drawing.Size(42, 20);
            this.l2SpinBox.TabIndex = 7;
            this.l2SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // l1SpinBox
            // 
            this.l1SpinBox.Location = new System.Drawing.Point(181, 108);
            this.l1SpinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.l1SpinBox.Name = "l1SpinBox";
            this.l1SpinBox.Size = new System.Drawing.Size(42, 20);
            this.l1SpinBox.TabIndex = 6;
            this.l1SpinBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.l1SpinBox.ValueChanged += new System.EventHandler(this.nSpinBox_ValueChanged);
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.AllowUserToDeleteRows = false;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Location = new System.Drawing.Point(13, 134);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(573, 220);
            this.result.TabIndex = 9;
            // 
            // epsMaxTextBox
            // 
            this.epsMaxTextBox.Location = new System.Drawing.Point(175, 360);
            this.epsMaxTextBox.Name = "epsMaxTextBox";
            this.epsMaxTextBox.ReadOnly = true;
            this.epsMaxTextBox.Size = new System.Drawing.Size(274, 20);
            this.epsMaxTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Максимальная погрешность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Число точек:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Границы интервала:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Краевые условия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "k1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "k2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "a:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "l1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "l2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "b:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 389);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epsMaxTextBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.b1SpinBox);
            this.Controls.Add(this.l2SpinBox);
            this.Controls.Add(this.l1SpinBox);
            this.Controls.Add(this.a1SpinBox);
            this.Controls.Add(this.k2SpinBox);
            this.Controls.Add(this.k1SpinBox);
            this.Controls.Add(this.bSpinBox);
            this.Controls.Add(this.aSpinBox);
            this.Controls.Add(this.nSpinBox);
            this.MaximumSize = new System.Drawing.Size(606, 423);
            this.Name = "Form1";
            this.Text = "Finite Difference Method BVP";
            ((System.ComponentModel.ISupportInitialize)(this.nSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k1SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1SpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nSpinBox;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.NumericUpDown aSpinBox;
        private System.Windows.Forms.NumericUpDown bSpinBox;
        private System.Windows.Forms.NumericUpDown k1SpinBox;
        private System.Windows.Forms.NumericUpDown k2SpinBox;
        private System.Windows.Forms.NumericUpDown a1SpinBox;
        private System.Windows.Forms.NumericUpDown b1SpinBox;
        private System.Windows.Forms.NumericUpDown l2SpinBox;
        private System.Windows.Forms.NumericUpDown l1SpinBox;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.TextBox epsMaxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

    }
}

