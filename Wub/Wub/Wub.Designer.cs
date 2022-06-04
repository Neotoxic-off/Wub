namespace Wub
{
    partial class Wub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wub));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_secure_boot = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.label4 = new System.Windows.Forms.Label();
            this.button_tpm = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ram = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.button_bypass = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.button_about = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragger
            // 
            this.dragger.Fixed = true;
            this.dragger.Horizontal = true;
            this.dragger.TargetControl = this.panel;
            this.dragger.Vertical = true;
            // 
            // panel
            // 
            this.panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 3;
            this.panel.BorderThickness = 1;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.button_exit);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShowBorders = true;
            this.panel.Size = new System.Drawing.Size(415, 28);
            this.panel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Windows Upgrade Bypasser";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.BackgroundImage = global::Wub.Properties.Resources.Closepx;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_exit.Location = new System.Drawing.Point(382, 4);
            this.button_exit.Margin = new System.Windows.Forms.Padding(1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10);
            this.button_exit.Size = new System.Drawing.Size(23, 21);
            this.button_exit.TabIndex = 12;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wub.Properties.Resources.windows_11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.panel);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(415, 257);
            this.bunifuPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 229);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_secure_boot);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button_tpm);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_ram);
            this.panel2.Controls.Add(this.button_bypass);
            this.panel2.Controls.Add(this.button_about);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 229);
            this.panel2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(55, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Remove windows upgrader Secure boot check";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(55, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Remove windows upgrader TPM 2.0 check\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(53, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Remove windows upgrader minimum ram requirement check";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(55, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Secure Boot Bypass";
            // 
            // button_secure_boot
            // 
            this.button_secure_boot.BackColor = System.Drawing.Color.Transparent;
            this.button_secure_boot.Checked = false;
            this.button_secure_boot.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.button_secure_boot.CheckedSwitchColor = System.Drawing.Color.White;
            this.button_secure_boot.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.button_secure_boot.Location = new System.Drawing.Point(15, 129);
            this.button_secure_boot.Margin = new System.Windows.Forms.Padding(1);
            this.button_secure_boot.Name = "button_secure_boot";
            this.button_secure_boot.OutlineThickness = 2;
            this.button_secure_boot.Size = new System.Drawing.Size(34, 19);
            this.button_secure_boot.TabIndex = 20;
            this.button_secure_boot.Tag = "";
            this.button_secure_boot.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.button_secure_boot.UncheckedSwitchColor = System.Drawing.Color.White;
            this.button_secure_boot.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(55, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "TPM Bypass";
            // 
            // button_tpm
            // 
            this.button_tpm.BackColor = System.Drawing.Color.Transparent;
            this.button_tpm.Checked = false;
            this.button_tpm.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.button_tpm.CheckedSwitchColor = System.Drawing.Color.White;
            this.button_tpm.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.button_tpm.Location = new System.Drawing.Point(15, 79);
            this.button_tpm.Margin = new System.Windows.Forms.Padding(1);
            this.button_tpm.Name = "button_tpm";
            this.button_tpm.OutlineThickness = 2;
            this.button_tpm.Size = new System.Drawing.Size(34, 19);
            this.button_tpm.TabIndex = 18;
            this.button_tpm.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.button_tpm.UncheckedSwitchColor = System.Drawing.Color.White;
            this.button_tpm.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(53, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ram Bypass";
            // 
            // button_ram
            // 
            this.button_ram.BackColor = System.Drawing.Color.Transparent;
            this.button_ram.Checked = false;
            this.button_ram.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.button_ram.CheckedSwitchColor = System.Drawing.Color.White;
            this.button_ram.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.button_ram.Location = new System.Drawing.Point(15, 32);
            this.button_ram.Margin = new System.Windows.Forms.Padding(1);
            this.button_ram.Name = "button_ram";
            this.button_ram.OutlineThickness = 2;
            this.button_ram.Size = new System.Drawing.Size(34, 19);
            this.button_ram.TabIndex = 16;
            this.button_ram.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.button_ram.UncheckedSwitchColor = System.Drawing.Color.White;
            this.button_ram.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            // 
            // button_bypass
            // 
            this.button_bypass.AllowAnimations = true;
            this.button_bypass.AllowMouseEffects = true;
            this.button_bypass.AllowToggling = false;
            this.button_bypass.AnimationSpeed = 200;
            this.button_bypass.AutoGenerateColors = false;
            this.button_bypass.AutoRoundBorders = false;
            this.button_bypass.AutoSizeLeftIcon = true;
            this.button_bypass.AutoSizeRightIcon = true;
            this.button_bypass.BackColor = System.Drawing.Color.Transparent;
            this.button_bypass.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button_bypass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_bypass.BackgroundImage")));
            this.button_bypass.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_bypass.ButtonText = "Bypass";
            this.button_bypass.ButtonTextMarginLeft = 0;
            this.button_bypass.ColorContrastOnClick = 45;
            this.button_bypass.ColorContrastOnHover = 45;
            this.button_bypass.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_bypass.CustomizableEdges = borderEdges1;
            this.button_bypass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_bypass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_bypass.DisabledFillColor = System.Drawing.Color.Empty;
            this.button_bypass.DisabledForecolor = System.Drawing.Color.Empty;
            this.button_bypass.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_bypass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_bypass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bypass.IconLeft = null;
            this.button_bypass.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bypass.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_bypass.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_bypass.IconMarginLeft = 11;
            this.button_bypass.IconPadding = 10;
            this.button_bypass.IconRight = null;
            this.button_bypass.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bypass.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_bypass.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_bypass.IconSize = 25;
            this.button_bypass.IdleBorderColor = System.Drawing.Color.Empty;
            this.button_bypass.IdleBorderRadius = 0;
            this.button_bypass.IdleBorderThickness = 0;
            this.button_bypass.IdleFillColor = System.Drawing.Color.Empty;
            this.button_bypass.IdleIconLeftImage = null;
            this.button_bypass.IdleIconRightImage = null;
            this.button_bypass.IndicateFocus = false;
            this.button_bypass.Location = new System.Drawing.Point(130, 185);
            this.button_bypass.Name = "button_bypass";
            this.button_bypass.OnDisabledState.BorderColor = System.Drawing.Color.Gray;
            this.button_bypass.OnDisabledState.BorderRadius = 10;
            this.button_bypass.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_bypass.OnDisabledState.BorderThickness = 1;
            this.button_bypass.OnDisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.button_bypass.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bypass.OnDisabledState.IconLeftImage = null;
            this.button_bypass.OnDisabledState.IconRightImage = null;
            this.button_bypass.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.button_bypass.onHoverState.BorderRadius = 10;
            this.button_bypass.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_bypass.onHoverState.BorderThickness = 1;
            this.button_bypass.onHoverState.FillColor = System.Drawing.SystemColors.Control;
            this.button_bypass.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bypass.onHoverState.IconLeftImage = null;
            this.button_bypass.onHoverState.IconRightImage = null;
            this.button_bypass.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.button_bypass.OnIdleState.BorderRadius = 10;
            this.button_bypass.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_bypass.OnIdleState.BorderThickness = 1;
            this.button_bypass.OnIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.button_bypass.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bypass.OnIdleState.IconLeftImage = null;
            this.button_bypass.OnIdleState.IconRightImage = null;
            this.button_bypass.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.button_bypass.OnPressedState.BorderRadius = 10;
            this.button_bypass.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_bypass.OnPressedState.BorderThickness = 1;
            this.button_bypass.OnPressedState.FillColor = System.Drawing.SystemColors.Control;
            this.button_bypass.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bypass.OnPressedState.IconLeftImage = null;
            this.button_bypass.OnPressedState.IconRightImage = null;
            this.button_bypass.Size = new System.Drawing.Size(77, 23);
            this.button_bypass.TabIndex = 3;
            this.button_bypass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_bypass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_bypass.TextMarginLeft = 0;
            this.button_bypass.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_bypass.UseDefaultRadiusAndThickness = true;
            this.button_bypass.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // button_about
            // 
            this.button_about.AllowAnimations = true;
            this.button_about.AllowMouseEffects = true;
            this.button_about.AllowToggling = false;
            this.button_about.AnimationSpeed = 200;
            this.button_about.AutoGenerateColors = false;
            this.button_about.AutoRoundBorders = false;
            this.button_about.AutoSizeLeftIcon = true;
            this.button_about.AutoSizeRightIcon = true;
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_about.BackgroundImage")));
            this.button_about.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_about.ButtonText = "About";
            this.button_about.ButtonTextMarginLeft = 0;
            this.button_about.ColorContrastOnClick = 45;
            this.button_about.ColorContrastOnHover = 45;
            this.button_about.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button_about.CustomizableEdges = borderEdges2;
            this.button_about.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_about.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_about.DisabledFillColor = System.Drawing.Color.Empty;
            this.button_about.DisabledForecolor = System.Drawing.Color.Empty;
            this.button_about.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_about.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.IconLeft = null;
            this.button_about.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_about.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_about.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_about.IconMarginLeft = 11;
            this.button_about.IconPadding = 10;
            this.button_about.IconRight = null;
            this.button_about.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_about.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_about.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_about.IconSize = 25;
            this.button_about.IdleBorderColor = System.Drawing.Color.Empty;
            this.button_about.IdleBorderRadius = 0;
            this.button_about.IdleBorderThickness = 0;
            this.button_about.IdleFillColor = System.Drawing.Color.Empty;
            this.button_about.IdleIconLeftImage = null;
            this.button_about.IdleIconRightImage = null;
            this.button_about.IndicateFocus = false;
            this.button_about.Location = new System.Drawing.Point(213, 185);
            this.button_about.Name = "button_about";
            this.button_about.OnDisabledState.BorderColor = System.Drawing.Color.Gray;
            this.button_about.OnDisabledState.BorderRadius = 10;
            this.button_about.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_about.OnDisabledState.BorderThickness = 1;
            this.button_about.OnDisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.button_about.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.OnDisabledState.IconLeftImage = null;
            this.button_about.OnDisabledState.IconRightImage = null;
            this.button_about.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.button_about.onHoverState.BorderRadius = 10;
            this.button_about.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_about.onHoverState.BorderThickness = 1;
            this.button_about.onHoverState.FillColor = System.Drawing.SystemColors.Control;
            this.button_about.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.onHoverState.IconLeftImage = null;
            this.button_about.onHoverState.IconRightImage = null;
            this.button_about.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.button_about.OnIdleState.BorderRadius = 10;
            this.button_about.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_about.OnIdleState.BorderThickness = 1;
            this.button_about.OnIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.button_about.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.OnIdleState.IconLeftImage = null;
            this.button_about.OnIdleState.IconRightImage = null;
            this.button_about.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.button_about.OnPressedState.BorderRadius = 10;
            this.button_about.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_about.OnPressedState.BorderThickness = 1;
            this.button_about.OnPressedState.FillColor = System.Drawing.SystemColors.Control;
            this.button_about.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_about.OnPressedState.IconLeftImage = null;
            this.button_about.OnPressedState.IconRightImage = null;
            this.button_about.Size = new System.Drawing.Size(77, 23);
            this.button_about.TabIndex = 7;
            this.button_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_about.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_about.TextMarginLeft = 0;
            this.button_about.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_about.UseDefaultRadiusAndThickness = true;
            this.button_about.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // Wub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 257);
            this.Controls.Add(this.bunifuPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl dragger;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 button_secure_boot;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 button_tpm;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 button_ram;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_bypass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_about;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

