namespace CubeAssignment.Gui
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
            this.MenuTable = new System.Windows.Forms.TableLayoutPanel();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.MeshPropertiesLabel = new System.Windows.Forms.Label();
            this.RotateLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.RotateValueLabel = new System.Windows.Forms.Label();
            this.TranslateValueLabel = new System.Windows.Forms.Label();
            this.ScaleValueLabel = new System.Windows.Forms.Label();
            this.CameraPropertiesLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.ThetaLabel = new System.Windows.Forms.Label();
            this.PhiLabel = new System.Windows.Forms.Label();
            this.KeybindingLabel = new System.Windows.Forms.Label();
            this.KeyBindingZLabel = new System.Windows.Forms.Label();
            this.KeyBindingScaleLabel = new System.Windows.Forms.Label();
            this.KeyBindingRotationLabel = new System.Windows.Forms.Label();
            this.KeyBindingAnimationResetLabel = new System.Windows.Forms.Label();
            this.CameraZoomLabel = new System.Windows.Forms.Label();
            this.phiValueLabel = new System.Windows.Forms.Label();
            this.dValueLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.theValuetaLabel = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.MenuTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.MainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrameTimer
            // 
            this.FrameTimer.Enabled = true;
            this.FrameTimer.Interval = 16;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // MenuTable
            // 
            this.MenuTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuTable.ColumnCount = 2;
            this.MenuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTable.Controls.Add(this.TranslateLabel, 0, 1);
            this.MenuTable.Controls.Add(this.MeshPropertiesLabel, 0, 0);
            this.MenuTable.Controls.Add(this.RotateLabel, 0, 2);
            this.MenuTable.Controls.Add(this.ScaleLabel, 0, 3);
            this.MenuTable.Controls.Add(this.RotateValueLabel, 1, 2);
            this.MenuTable.Controls.Add(this.TranslateValueLabel, 1, 1);
            this.MenuTable.Controls.Add(this.ScaleValueLabel, 1, 3);
            this.MenuTable.Controls.Add(this.CameraPropertiesLabel, 0, 4);
            this.MenuTable.Controls.Add(this.DLabel, 0, 5);
            this.MenuTable.Controls.Add(this.RLabel, 0, 6);
            this.MenuTable.Controls.Add(this.ThetaLabel, 0, 7);
            this.MenuTable.Controls.Add(this.PhiLabel, 0, 8);
            this.MenuTable.Controls.Add(this.KeybindingLabel, 0, 9);
            this.MenuTable.Controls.Add(this.KeyBindingZLabel, 0, 10);
            this.MenuTable.Controls.Add(this.KeyBindingScaleLabel, 0, 11);
            this.MenuTable.Controls.Add(this.KeyBindingRotationLabel, 0, 12);
            this.MenuTable.Controls.Add(this.KeyBindingAnimationResetLabel, 0, 13);
            this.MenuTable.Controls.Add(this.CameraZoomLabel, 0, 14);
            this.MenuTable.Controls.Add(this.phiValueLabel, 1, 8);
            this.MenuTable.Controls.Add(this.dValueLabel, 1, 5);
            this.MenuTable.Controls.Add(this.rValueLabel, 1, 6);
            this.MenuTable.Controls.Add(this.theValuetaLabel, 1, 7);
            this.MenuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTable.Location = new System.Drawing.Point(3, 3);
            this.MenuTable.Name = "MenuTable";
            this.MenuTable.RowCount = 20;
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuTable.Size = new System.Drawing.Size(394, 936);
            this.MenuTable.TabIndex = 2;
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateLabel.ForeColor = System.Drawing.Color.White;
            this.TranslateLabel.Location = new System.Drawing.Point(4, 21);
            this.TranslateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(75, 21);
            this.TranslateLabel.TabIndex = 7;
            this.TranslateLabel.Text = "Translate:";
            // 
            // MeshPropertiesLabel
            // 
            this.MeshPropertiesLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.MeshPropertiesLabel, 2);
            this.MeshPropertiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeshPropertiesLabel.ForeColor = System.Drawing.Color.White;
            this.MeshPropertiesLabel.Location = new System.Drawing.Point(3, 0);
            this.MeshPropertiesLabel.Name = "MeshPropertiesLabel";
            this.MeshPropertiesLabel.Size = new System.Drawing.Size(88, 21);
            this.MeshPropertiesLabel.TabIndex = 38;
            this.MeshPropertiesLabel.Text = "Properties";
            // 
            // RotateLabel
            // 
            this.RotateLabel.AutoSize = true;
            this.RotateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RotateLabel.ForeColor = System.Drawing.Color.White;
            this.RotateLabel.Location = new System.Drawing.Point(4, 42);
            this.RotateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RotateLabel.Name = "RotateLabel";
            this.RotateLabel.Size = new System.Drawing.Size(58, 21);
            this.RotateLabel.TabIndex = 8;
            this.RotateLabel.Text = "Rotate:";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleLabel.ForeColor = System.Drawing.Color.White;
            this.ScaleLabel.Location = new System.Drawing.Point(4, 63);
            this.ScaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(49, 21);
            this.ScaleLabel.TabIndex = 6;
            this.ScaleLabel.Text = "Scale:";
            // 
            // RotateValueLabel
            // 
            this.RotateValueLabel.AutoSize = true;
            this.RotateValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RotateValueLabel.ForeColor = System.Drawing.Color.White;
            this.RotateValueLabel.Location = new System.Drawing.Point(201, 42);
            this.RotateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RotateValueLabel.Name = "RotateValueLabel";
            this.RotateValueLabel.Size = new System.Drawing.Size(53, 21);
            this.RotateValueLabel.TabIndex = 12;
            this.RotateValueLabel.Text = "(0,0,0)";
            // 
            // TranslateValueLabel
            // 
            this.TranslateValueLabel.AutoSize = true;
            this.TranslateValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateValueLabel.ForeColor = System.Drawing.Color.White;
            this.TranslateValueLabel.Location = new System.Drawing.Point(201, 21);
            this.TranslateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TranslateValueLabel.Name = "TranslateValueLabel";
            this.TranslateValueLabel.Size = new System.Drawing.Size(53, 21);
            this.TranslateValueLabel.TabIndex = 11;
            this.TranslateValueLabel.Text = "(0,0,0)";
            // 
            // ScaleValueLabel
            // 
            this.ScaleValueLabel.AutoSize = true;
            this.ScaleValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleValueLabel.ForeColor = System.Drawing.Color.White;
            this.ScaleValueLabel.Location = new System.Drawing.Point(201, 63);
            this.ScaleValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScaleValueLabel.Name = "ScaleValueLabel";
            this.ScaleValueLabel.Size = new System.Drawing.Size(53, 21);
            this.ScaleValueLabel.TabIndex = 10;
            this.ScaleValueLabel.Text = "(0,0,0)";
            // 
            // CameraPropertiesLabel
            // 
            this.CameraPropertiesLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.CameraPropertiesLabel, 2);
            this.CameraPropertiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CameraPropertiesLabel.ForeColor = System.Drawing.Color.White;
            this.CameraPropertiesLabel.Location = new System.Drawing.Point(3, 84);
            this.CameraPropertiesLabel.Name = "CameraPropertiesLabel";
            this.CameraPropertiesLabel.Size = new System.Drawing.Size(150, 21);
            this.CameraPropertiesLabel.TabIndex = 46;
            this.CameraPropertiesLabel.Text = "Camera Properties";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DLabel.ForeColor = System.Drawing.Color.White;
            this.DLabel.Location = new System.Drawing.Point(4, 105);
            this.DLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(82, 21);
            this.DLabel.TabIndex = 40;
            this.DLabel.Text = "Camera D:";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RLabel.ForeColor = System.Drawing.Color.White;
            this.RLabel.Location = new System.Drawing.Point(4, 126);
            this.RLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(81, 21);
            this.RLabel.TabIndex = 41;
            this.RLabel.Text = "Camera R:";
            // 
            // ThetaLabel
            // 
            this.ThetaLabel.AutoSize = true;
            this.ThetaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThetaLabel.ForeColor = System.Drawing.Color.White;
            this.ThetaLabel.Location = new System.Drawing.Point(4, 147);
            this.ThetaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThetaLabel.Name = "ThetaLabel";
            this.ThetaLabel.Size = new System.Drawing.Size(109, 21);
            this.ThetaLabel.TabIndex = 42;
            this.ThetaLabel.Text = "Camera Theta:";
            // 
            // PhiLabel
            // 
            this.PhiLabel.AutoSize = true;
            this.PhiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhiLabel.ForeColor = System.Drawing.Color.White;
            this.PhiLabel.Location = new System.Drawing.Point(4, 168);
            this.PhiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhiLabel.Name = "PhiLabel";
            this.PhiLabel.Size = new System.Drawing.Size(93, 21);
            this.PhiLabel.TabIndex = 43;
            this.PhiLabel.Text = "Camera Phi:";
            // 
            // KeybindingLabel
            // 
            this.KeybindingLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.KeybindingLabel, 2);
            this.KeybindingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeybindingLabel.ForeColor = System.Drawing.Color.White;
            this.KeybindingLabel.Location = new System.Drawing.Point(3, 189);
            this.KeybindingLabel.Name = "KeybindingLabel";
            this.KeybindingLabel.Size = new System.Drawing.Size(98, 21);
            this.KeybindingLabel.TabIndex = 39;
            this.KeybindingLabel.Text = "Keybinding";
            // 
            // KeyBindingZLabel
            // 
            this.KeyBindingZLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.KeyBindingZLabel, 2);
            this.KeyBindingZLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingZLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingZLabel.Location = new System.Drawing.Point(4, 210);
            this.KeyBindingZLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingZLabel.Name = "KeyBindingZLabel";
            this.KeyBindingZLabel.Size = new System.Drawing.Size(232, 21);
            this.KeyBindingZLabel.TabIndex = 24;
            this.KeyBindingZLabel.Text = "PgUp/PgDn: decrase / increase z";
            // 
            // KeyBindingScaleLabel
            // 
            this.KeyBindingScaleLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.KeyBindingScaleLabel, 2);
            this.KeyBindingScaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyBindingScaleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingScaleLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingScaleLabel.Location = new System.Drawing.Point(4, 231);
            this.KeyBindingScaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingScaleLabel.Name = "KeyBindingScaleLabel";
            this.KeyBindingScaleLabel.Size = new System.Drawing.Size(386, 21);
            this.KeyBindingScaleLabel.TabIndex = 27;
            this.KeyBindingScaleLabel.Text = "s/S: scale (increase, decrease)";
            // 
            // KeyBindingRotationLabel
            // 
            this.KeyBindingRotationLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.KeyBindingRotationLabel, 2);
            this.KeyBindingRotationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingRotationLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingRotationLabel.Location = new System.Drawing.Point(4, 252);
            this.KeyBindingRotationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingRotationLabel.Name = "KeyBindingRotationLabel";
            this.KeyBindingRotationLabel.Size = new System.Drawing.Size(334, 21);
            this.KeyBindingRotationLabel.TabIndex = 26;
            this.KeyBindingRotationLabel.Text = "X/X, y/Y, z/Z: rotate around x-axis, y-axis, z-axis.";
            // 
            // KeyBindingAnimationResetLabel
            // 
            this.KeyBindingAnimationResetLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.KeyBindingAnimationResetLabel, 2);
            this.KeyBindingAnimationResetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingAnimationResetLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingAnimationResetLabel.Location = new System.Drawing.Point(4, 273);
            this.KeyBindingAnimationResetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingAnimationResetLabel.Name = "KeyBindingAnimationResetLabel";
            this.KeyBindingAnimationResetLabel.Size = new System.Drawing.Size(373, 21);
            this.KeyBindingAnimationResetLabel.TabIndex = 28;
            this.KeyBindingAnimationResetLabel.Text = "When “C” is pressed, all variables are reset to default";
            // 
            // CameraZoomLabel
            // 
            this.CameraZoomLabel.AutoSize = true;
            this.MenuTable.SetColumnSpan(this.CameraZoomLabel, 2);
            this.CameraZoomLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CameraZoomLabel.ForeColor = System.Drawing.Color.White;
            this.CameraZoomLabel.Location = new System.Drawing.Point(4, 294);
            this.CameraZoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CameraZoomLabel.Name = "CameraZoomLabel";
            this.CameraZoomLabel.Size = new System.Drawing.Size(167, 21);
            this.CameraZoomLabel.TabIndex = 26;
            this.CameraZoomLabel.Text = "Camera Distance: Q/W";
            // 
            // phiValueLabel
            // 
            this.phiValueLabel.AutoSize = true;
            this.phiValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phiValueLabel.ForeColor = System.Drawing.Color.White;
            this.phiValueLabel.Location = new System.Drawing.Point(201, 168);
            this.phiValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phiValueLabel.Name = "phiValueLabel";
            this.phiValueLabel.Size = new System.Drawing.Size(19, 21);
            this.phiValueLabel.TabIndex = 37;
            this.phiValueLabel.Text = "0";
            // 
            // dValueLabel
            // 
            this.dValueLabel.AutoSize = true;
            this.dValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dValueLabel.ForeColor = System.Drawing.Color.White;
            this.dValueLabel.Location = new System.Drawing.Point(201, 105);
            this.dValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dValueLabel.Name = "dValueLabel";
            this.dValueLabel.Size = new System.Drawing.Size(19, 21);
            this.dValueLabel.TabIndex = 34;
            this.dValueLabel.Text = "0";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rValueLabel.ForeColor = System.Drawing.Color.White;
            this.rValueLabel.Location = new System.Drawing.Point(201, 126);
            this.rValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(19, 21);
            this.rValueLabel.TabIndex = 35;
            this.rValueLabel.Text = "0";
            // 
            // theValuetaLabel
            // 
            this.theValuetaLabel.AutoSize = true;
            this.theValuetaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theValuetaLabel.ForeColor = System.Drawing.Color.White;
            this.theValuetaLabel.Location = new System.Drawing.Point(201, 147);
            this.theValuetaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theValuetaLabel.Name = "theValuetaLabel";
            this.theValuetaLabel.Size = new System.Drawing.Size(19, 21);
            this.theValuetaLabel.TabIndex = 36;
            this.theValuetaLabel.Text = "0";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(404, 3);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1789, 936);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.Canvas, 1, 0);
            this.MainTable.Controls.Add(this.MenuTable, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(2197, 942);
            this.MainTable.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2197, 942);
            this.Controls.Add(this.MainTable);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MenuTable.ResumeLayout(false);
            this.MenuTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.MainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TableLayoutPanel MenuTable;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label TranslateLabel;
        private System.Windows.Forms.Label MeshPropertiesLabel;
        private System.Windows.Forms.Label RotateLabel;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label RotateValueLabel;
        private System.Windows.Forms.Label TranslateValueLabel;
        private System.Windows.Forms.Label ScaleValueLabel;
        private System.Windows.Forms.Label CameraPropertiesLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label ThetaLabel;
        private System.Windows.Forms.Label PhiLabel;
        private System.Windows.Forms.Label KeybindingLabel;
        private System.Windows.Forms.Label KeyBindingZLabel;
        private System.Windows.Forms.Label KeyBindingScaleLabel;
        private System.Windows.Forms.Label phiValueLabel;
        private System.Windows.Forms.Label dValueLabel;
        private System.Windows.Forms.Label rValueLabel;
        private System.Windows.Forms.Label theValuetaLabel;
        private System.Windows.Forms.Label KeyBindingRotationLabel;
        private System.Windows.Forms.Label KeyBindingAnimationResetLabel;
        private System.Windows.Forms.Label CameraZoomLabel;
    }
}

