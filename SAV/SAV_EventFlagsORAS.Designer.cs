﻿namespace PKHeX
{
    partial class SAV_EventFlagsORAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAV_EventFlagsORAS));
            this.CHK_CustomFlag = new System.Windows.Forms.CheckBox();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.L_UnSet = new System.Windows.Forms.Label();
            this.L_IsSet = new System.Windows.Forms.Label();
            this.TB_NewSAV = new System.Windows.Forms.TextBox();
            this.TB_OldSAV = new System.Windows.Forms.TextBox();
            this.TB_UnSet = new System.Windows.Forms.TextBox();
            this.TB_IsSet = new System.Windows.Forms.TextBox();
            this.B_LoadNew = new System.Windows.Forms.Button();
            this.B_LoadOld = new System.Windows.Forms.Button();
            this.flag_0647 = new System.Windows.Forms.CheckBox();
            this.flag_2840 = new System.Windows.Forms.CheckBox();
            this.GB_Rebattle = new System.Windows.Forms.GroupBox();
            this.flag_2818 = new System.Windows.Forms.CheckBox();
            this.flag_0181 = new System.Windows.Forms.CheckBox();
            this.flag_2831 = new System.Windows.Forms.CheckBox();
            this.flag_0183 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flag_0289 = new System.Windows.Forms.CheckBox();
            this.flag_0288 = new System.Windows.Forms.CheckBox();
            this.flag_0287 = new System.Windows.Forms.CheckBox();
            this.flag_0294 = new System.Windows.Forms.CheckBox();
            this.flag_0293 = new System.Windows.Forms.CheckBox();
            this.flag_0292 = new System.Windows.Forms.CheckBox();
            this.flag_0291 = new System.Windows.Forms.CheckBox();
            this.flag_0290 = new System.Windows.Forms.CheckBox();
            this.flag_0675 = new System.Windows.Forms.CheckBox();
            this.flag_0286 = new System.Windows.Forms.CheckBox();
            this.flag_0285 = new System.Windows.Forms.CheckBox();
            this.flag_2546 = new System.Windows.Forms.CheckBox();
            this.flag_2814 = new System.Windows.Forms.CheckBox();
            this.flag_0209 = new System.Windows.Forms.CheckBox();
            this.flag_2825 = new System.Windows.Forms.CheckBox();
            this.flag_0176 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GB_Rebattle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHK_CustomFlag
            // 
            this.CHK_CustomFlag.AutoSize = true;
            this.CHK_CustomFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_CustomFlag.Enabled = false;
            this.CHK_CustomFlag.Location = new System.Drawing.Point(12, 44);
            this.CHK_CustomFlag.Name = "CHK_CustomFlag";
            this.CHK_CustomFlag.Size = new System.Drawing.Size(59, 17);
            this.CHK_CustomFlag.TabIndex = 1;
            this.CHK_CustomFlag.Text = "Status:";
            this.CHK_CustomFlag.UseVisualStyleBackColor = true;
            this.CHK_CustomFlag.CheckedChanged += new System.EventHandler(this.changeCustomBool);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(287, 307);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CHK_CustomFlag);
            this.groupBox1.Location = new System.Drawing.Point(14, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Flag Status";
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(56, 19);
            this.nud.Maximum = new decimal(new int[] {
            3072,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(45, 20);
            this.nud.TabIndex = 9;
            this.nud.Value = new decimal(new int[] {
            3071,
            0,
            0,
            0});
            this.nud.ValueChanged += new System.EventHandler(this.changeCustomFlag);
            this.nud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.changeCustomFlag);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flag:";
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(366, 306);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(75, 23);
            this.B_Save.TabIndex = 9;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.L_UnSet);
            this.groupBox2.Controls.Add(this.L_IsSet);
            this.groupBox2.Controls.Add(this.TB_NewSAV);
            this.groupBox2.Controls.Add(this.TB_OldSAV);
            this.groupBox2.Controls.Add(this.TB_UnSet);
            this.groupBox2.Controls.Add(this.TB_IsSet);
            this.groupBox2.Controls.Add(this.B_LoadNew);
            this.groupBox2.Controls.Add(this.B_LoadOld);
            this.groupBox2.Location = new System.Drawing.Point(14, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 120);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FlagDiff Researcher";
            // 
            // L_UnSet
            // 
            this.L_UnSet.AutoSize = true;
            this.L_UnSet.Location = new System.Drawing.Point(10, 97);
            this.L_UnSet.Name = "L_UnSet";
            this.L_UnSet.Size = new System.Drawing.Size(37, 13);
            this.L_UnSet.TabIndex = 7;
            this.L_UnSet.Text = "UnSet";
            // 
            // L_IsSet
            // 
            this.L_IsSet.AutoSize = true;
            this.L_IsSet.Location = new System.Drawing.Point(12, 77);
            this.L_IsSet.Name = "L_IsSet";
            this.L_IsSet.Size = new System.Drawing.Size(31, 13);
            this.L_IsSet.TabIndex = 6;
            this.L_IsSet.Text = "IsSet";
            // 
            // TB_NewSAV
            // 
            this.TB_NewSAV.Location = new System.Drawing.Point(93, 47);
            this.TB_NewSAV.Name = "TB_NewSAV";
            this.TB_NewSAV.ReadOnly = true;
            this.TB_NewSAV.Size = new System.Drawing.Size(169, 20);
            this.TB_NewSAV.TabIndex = 5;
            this.TB_NewSAV.TextChanged += new System.EventHandler(this.changeSAV);
            // 
            // TB_OldSAV
            // 
            this.TB_OldSAV.Location = new System.Drawing.Point(93, 21);
            this.TB_OldSAV.Name = "TB_OldSAV";
            this.TB_OldSAV.ReadOnly = true;
            this.TB_OldSAV.Size = new System.Drawing.Size(169, 20);
            this.TB_OldSAV.TabIndex = 4;
            this.TB_OldSAV.TextChanged += new System.EventHandler(this.changeSAV);
            // 
            // TB_UnSet
            // 
            this.TB_UnSet.Location = new System.Drawing.Point(56, 94);
            this.TB_UnSet.Name = "TB_UnSet";
            this.TB_UnSet.ReadOnly = true;
            this.TB_UnSet.Size = new System.Drawing.Size(206, 20);
            this.TB_UnSet.TabIndex = 3;
            // 
            // TB_IsSet
            // 
            this.TB_IsSet.Location = new System.Drawing.Point(56, 74);
            this.TB_IsSet.Name = "TB_IsSet";
            this.TB_IsSet.ReadOnly = true;
            this.TB_IsSet.Size = new System.Drawing.Size(206, 20);
            this.TB_IsSet.TabIndex = 2;
            // 
            // B_LoadNew
            // 
            this.B_LoadNew.Location = new System.Drawing.Point(12, 45);
            this.B_LoadNew.Name = "B_LoadNew";
            this.B_LoadNew.Size = new System.Drawing.Size(75, 23);
            this.B_LoadNew.TabIndex = 1;
            this.B_LoadNew.Text = "Load New";
            this.B_LoadNew.UseVisualStyleBackColor = true;
            this.B_LoadNew.Click += new System.EventHandler(this.openSAV);
            // 
            // B_LoadOld
            // 
            this.B_LoadOld.Location = new System.Drawing.Point(12, 19);
            this.B_LoadOld.Name = "B_LoadOld";
            this.B_LoadOld.Size = new System.Drawing.Size(75, 23);
            this.B_LoadOld.TabIndex = 0;
            this.B_LoadOld.Text = "Load Old";
            this.B_LoadOld.UseVisualStyleBackColor = true;
            this.B_LoadOld.Click += new System.EventHandler(this.openSAV);
            // 
            // flag_0647
            // 
            this.flag_0647.AutoSize = true;
            this.flag_0647.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0647.Location = new System.Drawing.Point(16, 19);
            this.flag_0647.Name = "flag_0647";
            this.flag_0647.Size = new System.Drawing.Size(108, 17);
            this.flag_0647.TabIndex = 14;
            this.flag_0647.Text = "Mascot Defeated";
            this.flag_0647.UseVisualStyleBackColor = true;
            this.flag_0647.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_2840
            // 
            this.flag_2840.AutoSize = true;
            this.flag_2840.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_2840.Location = new System.Drawing.Point(16, 34);
            this.flag_2840.Name = "flag_2840";
            this.flag_2840.Size = new System.Drawing.Size(107, 17);
            this.flag_2840.TabIndex = 15;
            this.flag_2840.Text = "Mascot Captured";
            this.flag_2840.UseVisualStyleBackColor = true;
            this.flag_2840.Click += new System.EventHandler(this.toggleFlag);
            // 
            // GB_Rebattle
            // 
            this.GB_Rebattle.Controls.Add(this.flag_2825);
            this.GB_Rebattle.Controls.Add(this.flag_0176);
            this.GB_Rebattle.Controls.Add(this.flag_2814);
            this.GB_Rebattle.Controls.Add(this.flag_0209);
            this.GB_Rebattle.Controls.Add(this.flag_2818);
            this.GB_Rebattle.Controls.Add(this.flag_0181);
            this.GB_Rebattle.Controls.Add(this.flag_2831);
            this.GB_Rebattle.Controls.Add(this.flag_0183);
            this.GB_Rebattle.Controls.Add(this.flag_2840);
            this.GB_Rebattle.Controls.Add(this.flag_0647);
            this.GB_Rebattle.Location = new System.Drawing.Point(129, 12);
            this.GB_Rebattle.Name = "GB_Rebattle";
            this.GB_Rebattle.Size = new System.Drawing.Size(152, 191);
            this.GB_Rebattle.TabIndex = 16;
            this.GB_Rebattle.TabStop = false;
            this.GB_Rebattle.Text = "Rebattle";
            // 
            // flag_2818
            // 
            this.flag_2818.AutoSize = true;
            this.flag_2818.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_2818.Location = new System.Drawing.Point(16, 94);
            this.flag_2818.Name = "flag_2818";
            this.flag_2818.Size = new System.Drawing.Size(95, 17);
            this.flag_2818.TabIndex = 19;
            this.flag_2818.Text = "Azelf Captured";
            this.flag_2818.UseVisualStyleBackColor = true;
            // 
            // flag_0181
            // 
            this.flag_0181.AutoSize = true;
            this.flag_0181.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0181.Location = new System.Drawing.Point(16, 79);
            this.flag_0181.Name = "flag_0181";
            this.flag_0181.Size = new System.Drawing.Size(96, 17);
            this.flag_0181.TabIndex = 18;
            this.flag_0181.Text = "Azelf Defeated";
            this.flag_0181.UseVisualStyleBackColor = true;
            // 
            // flag_2831
            // 
            this.flag_2831.AutoSize = true;
            this.flag_2831.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_2831.Location = new System.Drawing.Point(16, 64);
            this.flag_2831.Name = "flag_2831";
            this.flag_2831.Size = new System.Drawing.Size(121, 17);
            this.flag_2831.TabIndex = 17;
            this.flag_2831.Text = "Zek/Resh Captured";
            this.flag_2831.UseVisualStyleBackColor = true;
            // 
            // flag_0183
            // 
            this.flag_0183.AutoSize = true;
            this.flag_0183.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0183.Location = new System.Drawing.Point(16, 49);
            this.flag_0183.Name = "flag_0183";
            this.flag_0183.Size = new System.Drawing.Size(122, 17);
            this.flag_0183.TabIndex = 16;
            this.flag_0183.Text = "Zek/Resh Defeated";
            this.flag_0183.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flag_0289);
            this.groupBox3.Controls.Add(this.flag_0288);
            this.groupBox3.Controls.Add(this.flag_0287);
            this.groupBox3.Controls.Add(this.flag_0294);
            this.groupBox3.Controls.Add(this.flag_0293);
            this.groupBox3.Controls.Add(this.flag_0292);
            this.groupBox3.Controls.Add(this.flag_0291);
            this.groupBox3.Controls.Add(this.flag_0290);
            this.groupBox3.Controls.Add(this.flag_0675);
            this.groupBox3.Controls.Add(this.flag_0286);
            this.groupBox3.Controls.Add(this.flag_0285);
            this.groupBox3.Location = new System.Drawing.Point(287, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 288);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            this.groupBox3.Visible = false;
            // 
            // flag_0289
            // 
            this.flag_0289.AutoSize = true;
            this.flag_0289.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0289.Location = new System.Drawing.Point(6, 79);
            this.flag_0289.Name = "flag_0289";
            this.flag_0289.Size = new System.Drawing.Size(94, 17);
            this.flag_0289.TabIndex = 25;
            this.flag_0289.Text = "Multi Statuette";
            this.flag_0289.UseVisualStyleBackColor = true;
            this.flag_0289.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0288
            // 
            this.flag_0288.AutoSize = true;
            this.flag_0288.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0288.Location = new System.Drawing.Point(6, 64);
            this.flag_0288.Name = "flag_0288";
            this.flag_0288.Size = new System.Drawing.Size(112, 17);
            this.flag_0288.TabIndex = 24;
            this.flag_0288.Text = "Rotation Statuette";
            this.flag_0288.UseVisualStyleBackColor = true;
            this.flag_0288.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0287
            // 
            this.flag_0287.AutoSize = true;
            this.flag_0287.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0287.Location = new System.Drawing.Point(6, 49);
            this.flag_0287.Name = "flag_0287";
            this.flag_0287.Size = new System.Drawing.Size(103, 17);
            this.flag_0287.TabIndex = 23;
            this.flag_0287.Text = "Triples Statuette";
            this.flag_0287.UseVisualStyleBackColor = true;
            this.flag_0287.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0294
            // 
            this.flag_0294.AutoSize = true;
            this.flag_0294.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0294.Location = new System.Drawing.Point(6, 159);
            this.flag_0294.Name = "flag_0294";
            this.flag_0294.Size = new System.Drawing.Size(128, 17);
            this.flag_0294.TabIndex = 22;
            this.flag_0294.Text = "Super Multi Unlocked";
            this.flag_0294.UseVisualStyleBackColor = true;
            this.flag_0294.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0293
            // 
            this.flag_0293.AutoSize = true;
            this.flag_0293.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0293.Location = new System.Drawing.Point(6, 144);
            this.flag_0293.Name = "flag_0293";
            this.flag_0293.Size = new System.Drawing.Size(146, 17);
            this.flag_0293.TabIndex = 21;
            this.flag_0293.Text = "Super Rotation Unlocked";
            this.flag_0293.UseVisualStyleBackColor = true;
            this.flag_0293.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0292
            // 
            this.flag_0292.AutoSize = true;
            this.flag_0292.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0292.Location = new System.Drawing.Point(6, 129);
            this.flag_0292.Name = "flag_0292";
            this.flag_0292.Size = new System.Drawing.Size(137, 17);
            this.flag_0292.TabIndex = 20;
            this.flag_0292.Text = "Super Triples Unlocked";
            this.flag_0292.UseVisualStyleBackColor = true;
            this.flag_0292.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0291
            // 
            this.flag_0291.AutoSize = true;
            this.flag_0291.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0291.Location = new System.Drawing.Point(6, 114);
            this.flag_0291.Name = "flag_0291";
            this.flag_0291.Size = new System.Drawing.Size(145, 17);
            this.flag_0291.TabIndex = 19;
            this.flag_0291.Text = "Super Doubles Unlocked";
            this.flag_0291.UseVisualStyleBackColor = true;
            this.flag_0291.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0290
            // 
            this.flag_0290.AutoSize = true;
            this.flag_0290.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0290.Location = new System.Drawing.Point(6, 99);
            this.flag_0290.Name = "flag_0290";
            this.flag_0290.Size = new System.Drawing.Size(140, 17);
            this.flag_0290.TabIndex = 18;
            this.flag_0290.Text = "Super Singles Unlocked";
            this.flag_0290.UseVisualStyleBackColor = true;
            this.flag_0290.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0675
            // 
            this.flag_0675.AutoSize = true;
            this.flag_0675.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0675.Location = new System.Drawing.Point(15, 243);
            this.flag_0675.Name = "flag_0675";
            this.flag_0675.Size = new System.Drawing.Size(119, 17);
            this.flag_0675.TabIndex = 17;
            this.flag_0675.Text = "50: Beat Chatelaine";
            this.flag_0675.UseVisualStyleBackColor = true;
            this.flag_0675.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0286
            // 
            this.flag_0286.AutoSize = true;
            this.flag_0286.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0286.Location = new System.Drawing.Point(6, 34);
            this.flag_0286.Name = "flag_0286";
            this.flag_0286.Size = new System.Drawing.Size(111, 17);
            this.flag_0286.TabIndex = 16;
            this.flag_0286.Text = "Doubles Statuette";
            this.flag_0286.UseVisualStyleBackColor = true;
            this.flag_0286.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_0285
            // 
            this.flag_0285.AutoSize = true;
            this.flag_0285.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0285.Location = new System.Drawing.Point(6, 19);
            this.flag_0285.Name = "flag_0285";
            this.flag_0285.Size = new System.Drawing.Size(106, 17);
            this.flag_0285.TabIndex = 15;
            this.flag_0285.Text = "Singles Statuette";
            this.flag_0285.UseVisualStyleBackColor = true;
            this.flag_0285.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_2546
            // 
            this.flag_2546.AutoSize = true;
            this.flag_2546.Enabled = false;
            this.flag_2546.Location = new System.Drawing.Point(13, 112);
            this.flag_2546.Name = "flag_2546";
            this.flag_2546.Size = new System.Drawing.Size(114, 17);
            this.flag_2546.TabIndex = 18;
            this.flag_2546.Text = "Pokédex Obtained";
            this.flag_2546.UseVisualStyleBackColor = true;
            this.flag_2546.Click += new System.EventHandler(this.toggleFlag);
            // 
            // flag_2814
            // 
            this.flag_2814.AutoSize = true;
            this.flag_2814.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_2814.Location = new System.Drawing.Point(16, 124);
            this.flag_2814.Name = "flag_2814";
            this.flag_2814.Size = new System.Drawing.Size(134, 17);
            this.flag_2814.TabIndex = 21;
            this.flag_2814.Text = "Lugia/Ho-Oh Captured";
            this.flag_2814.UseVisualStyleBackColor = true;
            // 
            // flag_0209
            // 
            this.flag_0209.AutoSize = true;
            this.flag_0209.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0209.Location = new System.Drawing.Point(16, 109);
            this.flag_0209.Name = "flag_0209";
            this.flag_0209.Size = new System.Drawing.Size(135, 17);
            this.flag_0209.TabIndex = 20;
            this.flag_0209.Text = "Lugia/Ho-Oh Defeated";
            this.flag_0209.UseVisualStyleBackColor = true;
            // 
            // flag_2825
            // 
            this.flag_2825.AutoSize = true;
            this.flag_2825.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_2825.Location = new System.Drawing.Point(16, 154);
            this.flag_2825.Name = "flag_2825";
            this.flag_2825.Size = new System.Drawing.Size(113, 17);
            this.flag_2825.TabIndex = 23;
            this.flag_2825.Text = "Cobalion Captured";
            this.flag_2825.UseVisualStyleBackColor = true;
            // 
            // flag_0176
            // 
            this.flag_0176.AutoSize = true;
            this.flag_0176.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flag_0176.Location = new System.Drawing.Point(16, 139);
            this.flag_0176.Name = "flag_0176";
            this.flag_0176.Size = new System.Drawing.Size(114, 17);
            this.flag_0176.TabIndex = 22;
            this.flag_0176.Text = "Cobalion Defeated";
            this.flag_0176.UseVisualStyleBackColor = true;
            // 
            // SAV_EventFlagsORAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 342);
            this.Controls.Add(this.flag_2546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GB_Rebattle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SAV_EventFlagsORAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Flag Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GB_Rebattle.ResumeLayout(false);
            this.GB_Rebattle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHK_CustomFlag;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label L_UnSet;
        private System.Windows.Forms.Label L_IsSet;
        private System.Windows.Forms.TextBox TB_NewSAV;
        private System.Windows.Forms.TextBox TB_OldSAV;
        private System.Windows.Forms.TextBox TB_UnSet;
        private System.Windows.Forms.TextBox TB_IsSet;
        private System.Windows.Forms.Button B_LoadNew;
        private System.Windows.Forms.Button B_LoadOld;
        private System.Windows.Forms.CheckBox flag_0647;
        private System.Windows.Forms.CheckBox flag_2840;
        private System.Windows.Forms.GroupBox GB_Rebattle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox flag_0289;
        private System.Windows.Forms.CheckBox flag_0288;
        private System.Windows.Forms.CheckBox flag_0287;
        private System.Windows.Forms.CheckBox flag_0294;
        private System.Windows.Forms.CheckBox flag_0293;
        private System.Windows.Forms.CheckBox flag_0292;
        private System.Windows.Forms.CheckBox flag_0291;
        private System.Windows.Forms.CheckBox flag_0290;
        private System.Windows.Forms.CheckBox flag_0675;
        private System.Windows.Forms.CheckBox flag_0286;
        private System.Windows.Forms.CheckBox flag_0285;
        private System.Windows.Forms.CheckBox flag_2546;
        private System.Windows.Forms.CheckBox flag_2831;
        private System.Windows.Forms.CheckBox flag_0183;
        private System.Windows.Forms.CheckBox flag_2818;
        private System.Windows.Forms.CheckBox flag_0181;
        private System.Windows.Forms.CheckBox flag_2814;
        private System.Windows.Forms.CheckBox flag_0209;
        private System.Windows.Forms.CheckBox flag_2825;
        private System.Windows.Forms.CheckBox flag_0176;
    }
}