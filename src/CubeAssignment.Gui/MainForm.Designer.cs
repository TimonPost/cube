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
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.RotateLabel = new System.Windows.Forms.Label();
            this.ScaleValueLabel = new System.Windows.Forms.Label();
            this.TranslateValueLabel = new System.Windows.Forms.Label();
            this.RotateValueLabel = new System.Windows.Forms.Label();
            this.CameraValueLabel = new System.Windows.Forms.Label();
            this.CameraLabel = new System.Windows.Forms.Label();
            this.MenuTable = new System.Windows.Forms.TableLayoutPanel();
            this.KeyBindingAnimationStartLabel = new System.Windows.Forms.Label();
            this.KeyBindingAnimationResetLabel = new System.Windows.Forms.Label();
            this.KeyBindingRotationLabel = new System.Windows.Forms.Label();
            this.KeyBindingScaleLabel = new System.Windows.Forms.Label();
            this.KeyBindingZLabel = new System.Windows.Forms.Label();
            this.dValueLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.theValuetaLabel = new System.Windows.Forms.Label();
            this.phiValueLabel = new System.Windows.Forms.Label();
            this.PropertiesLabel = new System.Windows.Forms.Label();
            this.KeybindingLabel = new System.Windows.Forms.Label();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CanvasScrollPanel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.DLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.ThetaLabel = new System.Windows.Forms.Label();
            this.PhiLabel = new System.Windows.Forms.Label();
            this.MenuTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.CanvasScrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // FrameTimer
            // 
            this.FrameTimer.Enabled = true;
            this.FrameTimer.Interval = 16;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleLabel.ForeColor = System.Drawing.Color.White;
            this.ScaleLabel.Location = new System.Drawing.Point(4, 20);
            this.ScaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(49, 21);
            this.ScaleLabel.TabIndex = 6;
            this.ScaleLabel.Text = "Scale:";
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateLabel.ForeColor = System.Drawing.Color.White;
            this.TranslateLabel.Location = new System.Drawing.Point(4, 41);
            this.TranslateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(75, 21);
            this.TranslateLabel.TabIndex = 7;
            this.TranslateLabel.Text = "Translate:";
            // 
            // RotateLabel
            // 
            this.RotateLabel.AutoSize = true;
            this.RotateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RotateLabel.ForeColor = System.Drawing.Color.White;
            this.RotateLabel.Location = new System.Drawing.Point(4, 62);
            this.RotateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RotateLabel.Name = "RotateLabel";
            this.RotateLabel.Size = new System.Drawing.Size(58, 21);
            this.RotateLabel.TabIndex = 8;
            this.RotateLabel.Text = "Rotate:";
            // 
            // ScaleValueLabel
            // 
            this.ScaleValueLabel.AutoSize = true;
            this.ScaleValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleValueLabel.ForeColor = System.Drawing.Color.White;
            this.ScaleValueLabel.Location = new System.Drawing.Point(393, 20);
            this.ScaleValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScaleValueLabel.Name = "ScaleValueLabel";
            this.ScaleValueLabel.Size = new System.Drawing.Size(53, 21);
            this.ScaleValueLabel.TabIndex = 10;
            this.ScaleValueLabel.Text = "(0,0,0)";
            // 
            // TranslateValueLabel
            // 
            this.TranslateValueLabel.AutoSize = true;
            this.TranslateValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TranslateValueLabel.ForeColor = System.Drawing.Color.White;
            this.TranslateValueLabel.Location = new System.Drawing.Point(393, 41);
            this.TranslateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TranslateValueLabel.Name = "TranslateValueLabel";
            this.TranslateValueLabel.Size = new System.Drawing.Size(53, 21);
            this.TranslateValueLabel.TabIndex = 11;
            this.TranslateValueLabel.Text = "(0,0,0)";
            // 
            // RotateValueLabel
            // 
            this.RotateValueLabel.AutoSize = true;
            this.RotateValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RotateValueLabel.ForeColor = System.Drawing.Color.White;
            this.RotateValueLabel.Location = new System.Drawing.Point(393, 62);
            this.RotateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RotateValueLabel.Name = "RotateValueLabel";
            this.RotateValueLabel.Size = new System.Drawing.Size(53, 21);
            this.RotateValueLabel.TabIndex = 12;
            this.RotateValueLabel.Text = "(0,0,0)";
            // 
            // CameraValueLabel
            // 
            this.CameraValueLabel.AutoSize = true;
            this.CameraValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CameraValueLabel.ForeColor = System.Drawing.Color.White;
            this.CameraValueLabel.Location = new System.Drawing.Point(393, 83);
            this.CameraValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CameraValueLabel.Name = "CameraValueLabel";
            this.CameraValueLabel.Size = new System.Drawing.Size(53, 21);
            this.CameraValueLabel.TabIndex = 23;
            this.CameraValueLabel.Text = "(0,0,0)";
            // 
            // CameraLabel
            // 
            this.CameraLabel.AutoSize = true;
            this.CameraLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CameraLabel.ForeColor = System.Drawing.Color.White;
            this.CameraLabel.Location = new System.Drawing.Point(4, 83);
            this.CameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CameraLabel.Name = "CameraLabel";
            this.CameraLabel.Size = new System.Drawing.Size(64, 21);
            this.CameraLabel.TabIndex = 22;
            this.CameraLabel.Text = "Camera";
            // 
            // MenuTable
            // 
            this.MenuTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.MenuTable.ColumnCount = 2;
            this.MenuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MenuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuTable.Controls.Add(this.ScaleLabel, 0, 1);
            this.MenuTable.Controls.Add(this.ScaleValueLabel, 1, 1);
            this.MenuTable.Controls.Add(this.TranslateLabel, 0, 2);
            this.MenuTable.Controls.Add(this.TranslateValueLabel, 1, 2);
            this.MenuTable.Controls.Add(this.CameraValueLabel, 1, 4);
            this.MenuTable.Controls.Add(this.RotateLabel, 0, 3);
            this.MenuTable.Controls.Add(this.CameraLabel, 0, 4);
            this.MenuTable.Controls.Add(this.RotateValueLabel, 1, 3);
            this.MenuTable.Controls.Add(this.KeyBindingAnimationStartLabel, 0, 20);
            this.MenuTable.Controls.Add(this.KeyBindingAnimationResetLabel, 0, 19);
            this.MenuTable.Controls.Add(this.KeyBindingRotationLabel, 0, 18);
            this.MenuTable.Controls.Add(this.KeyBindingScaleLabel, 0, 17);
            this.MenuTable.Controls.Add(this.KeyBindingZLabel, 0, 16);
            this.MenuTable.Controls.Add(this.dValueLabel, 1, 22);
            this.MenuTable.Controls.Add(this.rValueLabel, 1, 23);
            this.MenuTable.Controls.Add(this.theValuetaLabel, 1, 24);
            this.MenuTable.Controls.Add(this.phiValueLabel, 1, 25);
            this.MenuTable.Controls.Add(this.PropertiesLabel, 0, 0);
            this.MenuTable.Controls.Add(this.KeybindingLabel, 0, 15);
            this.MenuTable.Controls.Add(this.DLabel, 0, 22);
            this.MenuTable.Controls.Add(this.RLabel, 0, 23);
            this.MenuTable.Controls.Add(this.ThetaLabel, 0, 24);
            this.MenuTable.Controls.Add(this.PhiLabel, 0, 25);
            this.MenuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTable.Location = new System.Drawing.Point(0, 0);
            this.MenuTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuTable.Name = "MenuTable";
            this.MenuTable.RowCount = 27;
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MenuTable.Size = new System.Drawing.Size(577, 942);
            this.MenuTable.TabIndex = 1;
            // 
            // KeyBindingAnimationStartLabel
            // 
            this.KeyBindingAnimationStartLabel.AutoSize = true;
            this.KeyBindingAnimationStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingAnimationStartLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingAnimationStartLabel.Location = new System.Drawing.Point(4, 216);
            this.KeyBindingAnimationStartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingAnimationStartLabel.Name = "KeyBindingAnimationStartLabel";
            this.KeyBindingAnimationStartLabel.Size = new System.Drawing.Size(267, 20);
            this.KeyBindingAnimationStartLabel.TabIndex = 29;
            this.KeyBindingAnimationStartLabel.Text = "When “A” is pressed, start animation";
            // 
            // KeyBindingAnimationResetLabel
            // 
            this.KeyBindingAnimationResetLabel.AutoSize = true;
            this.KeyBindingAnimationResetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingAnimationResetLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingAnimationResetLabel.Location = new System.Drawing.Point(4, 193);
            this.KeyBindingAnimationResetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingAnimationResetLabel.Name = "KeyBindingAnimationResetLabel";
            this.KeyBindingAnimationResetLabel.Size = new System.Drawing.Size(381, 20);
            this.KeyBindingAnimationResetLabel.TabIndex = 28;
            this.KeyBindingAnimationResetLabel.Text = "When “C” is pressed, all variables are reset to default";
            // 
            // KeyBindingRotationLabel
            // 
            this.KeyBindingRotationLabel.AutoSize = true;
            this.KeyBindingRotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingRotationLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingRotationLabel.Location = new System.Drawing.Point(4, 170);
            this.KeyBindingRotationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingRotationLabel.Name = "KeyBindingRotationLabel";
            this.KeyBindingRotationLabel.Size = new System.Drawing.Size(341, 20);
            this.KeyBindingRotationLabel.TabIndex = 26;
            this.KeyBindingRotationLabel.Text = "X/X, y/Y, z/Z: rotate around x-axis, y-axis, z-axis.";
            // 
            // KeyBindingScaleLabel
            // 
            this.KeyBindingScaleLabel.AutoSize = true;
            this.KeyBindingScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingScaleLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingScaleLabel.Location = new System.Drawing.Point(4, 147);
            this.KeyBindingScaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingScaleLabel.Name = "KeyBindingScaleLabel";
            this.KeyBindingScaleLabel.Size = new System.Drawing.Size(225, 20);
            this.KeyBindingScaleLabel.TabIndex = 27;
            this.KeyBindingScaleLabel.Text = "s/S: scale (increase, decrease)";
            // 
            // KeyBindingZLabel
            // 
            this.KeyBindingZLabel.AutoSize = true;
            this.KeyBindingZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingZLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingZLabel.Location = new System.Drawing.Point(4, 124);
            this.KeyBindingZLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingZLabel.Name = "KeyBindingZLabel";
            this.KeyBindingZLabel.Size = new System.Drawing.Size(242, 20);
            this.KeyBindingZLabel.TabIndex = 24;
            this.KeyBindingZLabel.Text = "PgUp/PgDn: decrase / increase z";
            // 
            // dValueLabel
            // 
            this.dValueLabel.AutoSize = true;
            this.dValueLabel.ForeColor = System.Drawing.Color.White;
            this.dValueLabel.Location = new System.Drawing.Point(393, 262);
            this.dValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dValueLabel.Name = "dValueLabel";
            this.dValueLabel.Size = new System.Drawing.Size(13, 15);
            this.dValueLabel.TabIndex = 34;
            this.dValueLabel.Text = "0";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.ForeColor = System.Drawing.Color.White;
            this.rValueLabel.Location = new System.Drawing.Point(393, 285);
            this.rValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(13, 15);
            this.rValueLabel.TabIndex = 35;
            this.rValueLabel.Text = "0";
            // 
            // theValuetaLabel
            // 
            this.theValuetaLabel.AutoSize = true;
            this.theValuetaLabel.ForeColor = System.Drawing.Color.White;
            this.theValuetaLabel.Location = new System.Drawing.Point(393, 308);
            this.theValuetaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theValuetaLabel.Name = "theValuetaLabel";
            this.theValuetaLabel.Size = new System.Drawing.Size(13, 15);
            this.theValuetaLabel.TabIndex = 36;
            this.theValuetaLabel.Text = "0";
            // 
            // phiValueLabel
            // 
            this.phiValueLabel.AutoSize = true;
            this.phiValueLabel.ForeColor = System.Drawing.Color.White;
            this.phiValueLabel.Location = new System.Drawing.Point(393, 331);
            this.phiValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phiValueLabel.Name = "phiValueLabel";
            this.phiValueLabel.Size = new System.Drawing.Size(13, 15);
            this.phiValueLabel.TabIndex = 37;
            this.phiValueLabel.Text = "0";
            // 
            // PropertiesLabel
            // 
            this.PropertiesLabel.AutoSize = true;
            this.PropertiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PropertiesLabel.ForeColor = System.Drawing.Color.White;
            this.PropertiesLabel.Location = new System.Drawing.Point(3, 0);
            this.PropertiesLabel.Name = "PropertiesLabel";
            this.PropertiesLabel.Size = new System.Drawing.Size(88, 20);
            this.PropertiesLabel.TabIndex = 38;
            this.PropertiesLabel.Text = "Properties";
            // 
            // KeybindingLabel
            // 
            this.KeybindingLabel.AutoSize = true;
            this.KeybindingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeybindingLabel.ForeColor = System.Drawing.Color.White;
            this.KeybindingLabel.Location = new System.Drawing.Point(3, 104);
            this.KeybindingLabel.Name = "KeybindingLabel";
            this.KeybindingLabel.Size = new System.Drawing.Size(98, 20);
            this.KeybindingLabel.TabIndex = 39;
            this.KeybindingLabel.Text = "Keybinding";
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.MenuTable);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.MainSplitContainer.Panel2.Controls.Add(this.CanvasScrollPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1680, 942);
            this.MainSplitContainer.SplitterDistance = 577;
            this.MainSplitContainer.SplitterWidth = 5;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // CanvasScrollPanel
            // 
            this.CanvasScrollPanel.AutoScroll = true;
            this.CanvasScrollPanel.BackColor = System.Drawing.Color.Black;
            this.CanvasScrollPanel.Controls.Add(this.Canvas);
            this.CanvasScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasScrollPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasScrollPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CanvasScrollPanel.Name = "CanvasScrollPanel";
            this.CanvasScrollPanel.Size = new System.Drawing.Size(1098, 942);
            this.CanvasScrollPanel.TabIndex = 1;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Black;
            this.Canvas.Location = new System.Drawing.Point(4, 0);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(933, 923);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DLabel.ForeColor = System.Drawing.Color.White;
            this.DLabel.Location = new System.Drawing.Point(4, 262);
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
            this.RLabel.Location = new System.Drawing.Point(4, 285);
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
            this.ThetaLabel.Location = new System.Drawing.Point(4, 308);
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
            this.PhiLabel.Location = new System.Drawing.Point(4, 331);
            this.PhiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhiLabel.Name = "PhiLabel";
            this.PhiLabel.Size = new System.Drawing.Size(93, 21);
            this.PhiLabel.TabIndex = 43;
            this.PhiLabel.Text = "Camera Phi:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 942);
            this.Controls.Add(this.MainSplitContainer);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MenuTable.ResumeLayout(false);
            this.MenuTable.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.CanvasScrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label TranslateLabel;
        private System.Windows.Forms.Label RotateLabel;
        private System.Windows.Forms.Label ScaleValueLabel;
        private System.Windows.Forms.Label TranslateValueLabel;
        private System.Windows.Forms.Label RotateValueLabel;
        private System.Windows.Forms.Label CameraValueLabel;
        private System.Windows.Forms.Label CameraLabel;
        private System.Windows.Forms.TableLayoutPanel MenuTable;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label KeyBindingAnimationStartLabel;
        private System.Windows.Forms.Label KeyBindingAnimationResetLabel;
        private System.Windows.Forms.Label KeyBindingRotationLabel;
        private System.Windows.Forms.Label KeyBindingScaleLabel;
        private System.Windows.Forms.Label KeyBindingZLabel;
        private System.Windows.Forms.Panel CanvasScrollPanel;
        private System.Windows.Forms.Label dValueLabel;
        private System.Windows.Forms.Label rValueLabel;
        private System.Windows.Forms.Label theValuetaLabel;
        private System.Windows.Forms.Label phiValueLabel;
        private System.Windows.Forms.Label PropertiesLabel;
        private System.Windows.Forms.Label KeybindingLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label ThetaLabel;
        private System.Windows.Forms.Label PhiLabel;
    }
}

