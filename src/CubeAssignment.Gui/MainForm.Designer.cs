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
            this.KeyBindingAnimationStartLabel = new System.Windows.Forms.Label();
            this.KeyBindingAnimationResetLabel = new System.Windows.Forms.Label();
            this.KeyBindingRotationLabel = new System.Windows.Forms.Label();
            this.KeyBindingScaleLabel = new System.Windows.Forms.Label();
            this.KeyBindingZLabel = new System.Windows.Forms.Label();
            this.dValueLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.theValuetaLabel = new System.Windows.Forms.Label();
            this.phiValueLabel = new System.Windows.Forms.Label();
            this.MeshPropertiesLabel = new System.Windows.Forms.Label();
            this.KeybindingLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.ThetaLabel = new System.Windows.Forms.Label();
            this.PhiLabel = new System.Windows.Forms.Label();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CameraPropertiesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CanvasScrollPanel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MainTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.ScaleLabel.Location = new System.Drawing.Point(4, 21);
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
            this.TranslateLabel.Location = new System.Drawing.Point(4, 42);
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
            this.RotateLabel.Location = new System.Drawing.Point(4, 63);
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
            this.ScaleValueLabel.Location = new System.Drawing.Point(87, 21);
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
            this.TranslateValueLabel.Location = new System.Drawing.Point(87, 42);
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
            this.RotateValueLabel.Location = new System.Drawing.Point(87, 63);
            this.RotateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RotateValueLabel.Name = "RotateValueLabel";
            this.RotateValueLabel.Size = new System.Drawing.Size(53, 21);
            this.RotateValueLabel.TabIndex = 12;
            this.RotateValueLabel.Text = "(0,0,0)";
            // 
            // KeyBindingAnimationStartLabel
            // 
            this.KeyBindingAnimationStartLabel.AutoSize = true;
            this.KeyBindingAnimationStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyBindingAnimationStartLabel.ForeColor = System.Drawing.Color.White;
            this.KeyBindingAnimationStartLabel.Location = new System.Drawing.Point(4, 101);
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
            this.KeyBindingAnimationResetLabel.Location = new System.Drawing.Point(4, 81);
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
            this.KeyBindingRotationLabel.Location = new System.Drawing.Point(4, 61);
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
            this.KeyBindingScaleLabel.Location = new System.Drawing.Point(4, 41);
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
            this.KeyBindingZLabel.Location = new System.Drawing.Point(4, 21);
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
            this.dValueLabel.Location = new System.Drawing.Point(121, 20);
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
            this.rValueLabel.Location = new System.Drawing.Point(121, 41);
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
            this.theValuetaLabel.Location = new System.Drawing.Point(121, 62);
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
            this.phiValueLabel.Location = new System.Drawing.Point(121, 83);
            this.phiValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phiValueLabel.Name = "phiValueLabel";
            this.phiValueLabel.Size = new System.Drawing.Size(13, 15);
            this.phiValueLabel.TabIndex = 37;
            this.phiValueLabel.Text = "0";
            // 
            // MeshPropertiesLabel
            // 
            this.MeshPropertiesLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.MeshPropertiesLabel, 2);
            this.MeshPropertiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeshPropertiesLabel.ForeColor = System.Drawing.Color.White;
            this.MeshPropertiesLabel.Location = new System.Drawing.Point(3, 0);
            this.MeshPropertiesLabel.Name = "MeshPropertiesLabel";
            this.MeshPropertiesLabel.Size = new System.Drawing.Size(88, 21);
            this.MeshPropertiesLabel.TabIndex = 38;
            this.MeshPropertiesLabel.Text = "Properties";
            // 
            // KeybindingLabel
            // 
            this.KeybindingLabel.AutoSize = true;
            this.KeybindingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeybindingLabel.ForeColor = System.Drawing.Color.White;
            this.KeybindingLabel.Location = new System.Drawing.Point(3, 0);
            this.KeybindingLabel.Name = "KeybindingLabel";
            this.KeybindingLabel.Size = new System.Drawing.Size(98, 21);
            this.KeybindingLabel.TabIndex = 39;
            this.KeybindingLabel.Text = "Keybinding";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DLabel.ForeColor = System.Drawing.Color.White;
            this.DLabel.Location = new System.Drawing.Point(4, 20);
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
            this.RLabel.Location = new System.Drawing.Point(4, 41);
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
            this.ThetaLabel.Location = new System.Drawing.Point(4, 62);
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
            this.PhiLabel.Location = new System.Drawing.Point(4, 83);
            this.PhiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhiLabel.Name = "PhiLabel";
            this.PhiLabel.Size = new System.Drawing.Size(93, 21);
            this.PhiLabel.TabIndex = 43;
            this.PhiLabel.Text = "Camera Phi:";
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
            this.MainSplitContainer.Panel1.Controls.Add(this.MainTable);
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
            // MainTable
            // 
            this.MainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.MainTable.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.MainTable.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.Size = new System.Drawing.Size(577, 942);
            this.MainTable.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.RotateValueLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MeshPropertiesLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TranslateLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.RotateLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ScaleLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TranslateValueLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ScaleValueLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.CameraPropertiesLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.phiValueLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.theValuetaLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.rValueLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dValueLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.DLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.RLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ThetaLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.PhiLabel, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 215);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(571, 724);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // CameraPropertiesLabel
            // 
            this.CameraPropertiesLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.CameraPropertiesLabel, 2);
            this.CameraPropertiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CameraPropertiesLabel.ForeColor = System.Drawing.Color.White;
            this.CameraPropertiesLabel.Location = new System.Drawing.Point(3, 0);
            this.CameraPropertiesLabel.Name = "CameraPropertiesLabel";
            this.CameraPropertiesLabel.Size = new System.Drawing.Size(150, 20);
            this.CameraPropertiesLabel.TabIndex = 46;
            this.CameraPropertiesLabel.Text = "Camera Properties";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.KeybindingLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.KeyBindingZLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.KeyBindingScaleLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.KeyBindingRotationLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.KeyBindingAnimationResetLabel, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.KeyBindingAnimationStartLabel, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(571, 100);
            this.tableLayoutPanel4.TabIndex = 2;
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
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainTable.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.Label MeshPropertiesLabel;
        private System.Windows.Forms.Label KeybindingLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label ThetaLabel;
        private System.Windows.Forms.Label PhiLabel;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label CameraPropertiesLabel;
    }
}

