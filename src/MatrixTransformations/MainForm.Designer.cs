namespace MatrixTransformations
{
    partial class MainForm
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
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scale_txt = new System.Windows.Forms.Label();
            this.translate_txt = new System.Windows.Forms.Label();
            this.rotate_txt = new System.Windows.Forms.Label();
            this.camera_txt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTrack = new System.Windows.Forms.TrackBar();
            this.rTrack = new System.Windows.Forms.TrackBar();
            this.thetaTrack = new System.Windows.Forms.TrackBar();
            this.phiTrack = new System.Windows.Forms.TrackBar();
            this.dLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.phiLabel = new System.Windows.Forms.Label();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // FrameTimer
            // 
            this.FrameTimer.Enabled = true;
            this.FrameTimer.Interval = 16;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Translate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rotate:";
            // 
            // scale_txt
            // 
            this.scale_txt.AutoSize = true;
            this.scale_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scale_txt.Location = new System.Drawing.Point(390, 0);
            this.scale_txt.Name = "scale_txt";
            this.scale_txt.Size = new System.Drawing.Size(53, 21);
            this.scale_txt.TabIndex = 10;
            this.scale_txt.Text = "(0,0,0)";
            // 
            // translate_txt
            // 
            this.translate_txt.AutoSize = true;
            this.translate_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.translate_txt.Location = new System.Drawing.Point(390, 21);
            this.translate_txt.Name = "translate_txt";
            this.translate_txt.Size = new System.Drawing.Size(53, 21);
            this.translate_txt.TabIndex = 11;
            this.translate_txt.Text = "(0,0,0)";
            // 
            // rotate_txt
            // 
            this.rotate_txt.AutoSize = true;
            this.rotate_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rotate_txt.Location = new System.Drawing.Point(390, 42);
            this.rotate_txt.Name = "rotate_txt";
            this.rotate_txt.Size = new System.Drawing.Size(53, 21);
            this.rotate_txt.TabIndex = 12;
            this.rotate_txt.Text = "(0,0,0)";
            // 
            // camera_txt
            // 
            this.camera_txt.AutoSize = true;
            this.camera_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.camera_txt.Location = new System.Drawing.Point(390, 63);
            this.camera_txt.Name = "camera_txt";
            this.camera_txt.Size = new System.Drawing.Size(53, 21);
            this.camera_txt.TabIndex = 23;
            this.camera_txt.Text = "(0,0,0)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(3, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Camera";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.scale_txt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.translate_txt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.camera_txt, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.rotate_txt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 18);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 17);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.dTrack, 0, 20);
            this.tableLayoutPanel2.Controls.Add(this.rTrack, 0, 21);
            this.tableLayoutPanel2.Controls.Add(this.thetaTrack, 0, 22);
            this.tableLayoutPanel2.Controls.Add(this.phiTrack, 0, 23);
            this.tableLayoutPanel2.Controls.Add(this.dLabel, 1, 20);
            this.tableLayoutPanel2.Controls.Add(this.rLabel, 1, 21);
            this.tableLayoutPanel2.Controls.Add(this.thetaLabel, 1, 22);
            this.tableLayoutPanel2.Controls.Add(this.phiLabel, 1, 23);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 25;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 816);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "When “A” is pressed, start animation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "When “C” is pressed, all variables are reset to default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "X/X, y/Y, z/Z: rotate around x-axis, y-axis, z-axis.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "s/S: scale (increase, decrease)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "PgUp/PgDn: decrase / increase z";
            // 
            // dTrack
            // 
            this.dTrack.Location = new System.Drawing.Point(3, 207);
            this.dTrack.Maximum = 1100;
            this.dTrack.Minimum = 600;
            this.dTrack.Name = "dTrack";
            this.dTrack.Size = new System.Drawing.Size(104, 14);
            this.dTrack.TabIndex = 30;
            this.dTrack.Value = 800;
            this.dTrack.ValueChanged += new System.EventHandler(this.dTrack_ValueChanged);
            // 
            // rTrack
            // 
            this.rTrack.Location = new System.Drawing.Point(3, 227);
            this.rTrack.Maximum = 50;
            this.rTrack.Name = "rTrack";
            this.rTrack.Size = new System.Drawing.Size(104, 14);
            this.rTrack.TabIndex = 31;
            this.rTrack.Value = 10;
            this.rTrack.ValueChanged += new System.EventHandler(this.rTrack_ValueChanged);
            // 
            // thetaTrack
            // 
            this.thetaTrack.Location = new System.Drawing.Point(3, 247);
            this.thetaTrack.Maximum = -500;
            this.thetaTrack.Minimum = -1000;
            this.thetaTrack.Name = "thetaTrack";
            this.thetaTrack.Size = new System.Drawing.Size(104, 14);
            this.thetaTrack.TabIndex = 32;
            this.thetaTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.thetaTrack.Value = -1000;
            this.thetaTrack.ValueChanged += new System.EventHandler(this.thetaTrack_ValueChanged);
            // 
            // phiTrack
            // 
            this.phiTrack.Location = new System.Drawing.Point(3, 267);
            this.phiTrack.Maximum = 300;
            this.phiTrack.Minimum = -900;
            this.phiTrack.Name = "phiTrack";
            this.phiTrack.Size = new System.Drawing.Size(104, 14);
            this.phiTrack.TabIndex = 33;
            this.phiTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.phiTrack.Value = -10;
            this.phiTrack.Scroll += new System.EventHandler(this.phiTrack_Scroll);
            this.phiTrack.ValueChanged += new System.EventHandler(this.phiTrack_ValueChanged);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(390, 204);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(35, 13);
            this.dLabel.TabIndex = 34;
            this.dLabel.Text = "label9";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(390, 224);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(35, 13);
            this.rLabel.TabIndex = 35;
            this.rLabel.Text = "label9";
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(390, 244);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(35, 13);
            this.thetaLabel.TabIndex = 36;
            this.thetaLabel.Text = "label9";
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Location = new System.Drawing.Point(390, 264);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(35, 13);
            this.phiLabel.TabIndex = 37;
            this.phiLabel.Text = "label9";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.panel1);
            this.MainSplitContainer.Size = new System.Drawing.Size(1440, 816);
            this.MainSplitContainer.SplitterDistance = 495;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Canvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 816);
            this.panel1.TabIndex = 1;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Location = new System.Drawing.Point(3, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(800, 800);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 816);
            this.Controls.Add(this.MainSplitContainer);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrack)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label scale_txt;
        private System.Windows.Forms.Label translate_txt;
        private System.Windows.Forms.Label rotate_txt;
        private System.Windows.Forms.Label camera_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar dTrack;
        private System.Windows.Forms.TrackBar rTrack;
        private System.Windows.Forms.TrackBar thetaTrack;
        private System.Windows.Forms.TrackBar phiTrack;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.Label phiLabel;
    }
}

