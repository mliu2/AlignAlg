namespace Analysis
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
            this.seq1 = new System.Windows.Forms.TextBox();
            this.seq2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isGlobal = new System.Windows.Forms.RadioButton();
            this.isLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countGaps = new System.Windows.Forms.RadioButton();
            this.countNoGaps = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // seq1
            // 
            this.seq1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seq1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seq1.Location = new System.Drawing.Point(12, 75);
            this.seq1.Multiline = true;
            this.seq1.Name = "seq1";
            this.seq1.Size = new System.Drawing.Size(292, 163);
            this.seq1.TabIndex = 5;
            // 
            // seq2
            // 
            this.seq2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seq2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seq2.Location = new System.Drawing.Point(318, 75);
            this.seq2.MinimumSize = new System.Drawing.Size(50, 2);
            this.seq2.Multiline = true;
            this.seq2.Name = "seq2";
            this.seq2.Size = new System.Drawing.Size(302, 163);
            this.seq2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sequence 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sequence 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // results
            // 
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.results.Location = new System.Drawing.Point(15, 319);
            this.results.MinimumSize = new System.Drawing.Size(400, 2);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.results.Size = new System.Drawing.Size(605, 60);
            this.results.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // isGlobal
            // 
            this.isGlobal.AutoSize = true;
            this.isGlobal.Location = new System.Drawing.Point(50, 16);
            this.isGlobal.Name = "isGlobal";
            this.isGlobal.Size = new System.Drawing.Size(55, 17);
            this.isGlobal.TabIndex = 1;
            this.isGlobal.TabStop = true;
            this.isGlobal.Text = "Global";
            this.isGlobal.UseVisualStyleBackColor = true;
            this.isGlobal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // isLocal
            // 
            this.isLocal.AutoSize = true;
            this.isLocal.Location = new System.Drawing.Point(167, 16);
            this.isLocal.Name = "isLocal";
            this.isLocal.Size = new System.Drawing.Size(51, 17);
            this.isLocal.TabIndex = 2;
            this.isLocal.TabStop = true;
            this.isLocal.Text = "Local";
            this.isLocal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isGlobal);
            this.groupBox1.Controls.Add(this.isLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alignment Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.countGaps);
            this.groupBox2.Controls.Add(this.countNoGaps);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 44);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gaps";
            // 
            // countGaps
            // 
            this.countGaps.AutoSize = true;
            this.countGaps.Location = new System.Drawing.Point(57, 16);
            this.countGaps.Name = "countGaps";
            this.countGaps.Size = new System.Drawing.Size(53, 17);
            this.countGaps.TabIndex = 1;
            this.countGaps.TabStop = true;
            this.countGaps.Text = "Count";
            this.countGaps.UseVisualStyleBackColor = true;
            // 
            // countNoGaps
            // 
            this.countNoGaps.AutoSize = true;
            this.countNoGaps.Location = new System.Drawing.Point(157, 16);
            this.countNoGaps.Name = "countNoGaps";
            this.countNoGaps.Size = new System.Drawing.Size(87, 17);
            this.countNoGaps.TabIndex = 2;
            this.countNoGaps.TabStop = true;
            this.countNoGaps.Text = "Do not count";
            this.countNoGaps.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(15, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Align";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seq2);
            this.Controls.Add(this.seq1);
            this.MaximumSize = new System.Drawing.Size(648, 429);
            this.MinimumSize = new System.Drawing.Size(648, 429);
            this.Name = "Form1";
            this.Text = "Alignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seq1;
        private System.Windows.Forms.TextBox seq2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton isGlobal;
        private System.Windows.Forms.RadioButton isLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton countGaps;
        private System.Windows.Forms.RadioButton countNoGaps;
        private System.Windows.Forms.Button button1;
    }
}

