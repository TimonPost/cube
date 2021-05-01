namespace MatrixTransformations
{
    partial class From1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scale_txt = new System.Windows.Forms.Label();
            this.translate_txt = new System.Windows.Forms.Label();
            this.rotate_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.camera_txt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Translate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rotate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(256, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "S/s";
            // 
            // scale_txt
            // 
            this.scale_txt.AutoSize = true;
            this.scale_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scale_txt.Location = new System.Drawing.Point(97, 4);
            this.scale_txt.Name = "scale_txt";
            this.scale_txt.Size = new System.Drawing.Size(53, 21);
            this.scale_txt.TabIndex = 10;
            this.scale_txt.Text = "(0,0,0)";
            // 
            // translate_txt
            // 
            this.translate_txt.AutoSize = true;
            this.translate_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.translate_txt.Location = new System.Drawing.Point(97, 25);
            this.translate_txt.Name = "translate_txt";
            this.translate_txt.Size = new System.Drawing.Size(53, 21);
            this.translate_txt.TabIndex = 11;
            this.translate_txt.Text = "(0,0,0)";
            // 
            // rotate_txt
            // 
            this.rotate_txt.AutoSize = true;
            this.rotate_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rotate_txt.Location = new System.Drawing.Point(97, 46);
            this.rotate_txt.Name = "rotate_txt";
            this.rotate_txt.Size = new System.Drawing.Size(53, 21);
            this.rotate_txt.TabIndex = 12;
            this.rotate_txt.Text = "(0,0,0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(256, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "(j/i)/(k/l)/(PgDn/PgUp)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(256, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "(X/x)/(Z/z)/(Y/y)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(680, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Enable Animation";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(256, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "(Q/q)/(W/w)/(E/e)";
            // 
            // camera_txt
            // 
            this.camera_txt.AutoSize = true;
            this.camera_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.camera_txt.Location = new System.Drawing.Point(97, 67);
            this.camera_txt.Name = "camera_txt";
            this.camera_txt.Size = new System.Drawing.Size(53, 21);
            this.camera_txt.TabIndex = 23;
            this.camera_txt.Text = "(0,0,0)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(7, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Animation: Start = A, Stop = C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Reset Values = C";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.camera_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rotate_txt);
            this.Controls.Add(this.translate_txt);
            this.Controls.Add(this.scale_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.KeyPreview = true;
            this.Name = "From1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.From1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label scale_txt;
        private System.Windows.Forms.Label translate_txt;
        private System.Windows.Forms.Label rotate_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label camera_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

