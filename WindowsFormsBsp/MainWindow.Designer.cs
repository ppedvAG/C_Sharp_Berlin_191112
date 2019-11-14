namespace WindowsFormsBsp
{
    partial class MainWindow
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
            this.BtnKlickMich = new System.Windows.Forms.Button();
            this.CbxHakMichAb = new System.Windows.Forms.CheckBox();
            this.CbbAuswahl = new System.Windows.Forms.ComboBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fensterSchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnZeigeMB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKlickMich
            // 
            this.BtnKlickMich.Location = new System.Drawing.Point(15, 313);
            this.BtnKlickMich.Name = "BtnKlickMich";
            this.BtnKlickMich.Size = new System.Drawing.Size(211, 44);
            this.BtnKlickMich.TabIndex = 0;
            this.BtnKlickMich.Text = "Klick Mich";
            this.BtnKlickMich.UseVisualStyleBackColor = true;
            this.BtnKlickMich.Click += new System.EventHandler(this.BtnKlickMich_Click);
            this.BtnKlickMich.MouseHover += new System.EventHandler(this.BtnKlickMich_Click);
            // 
            // CbxHakMichAb
            // 
            this.CbxHakMichAb.AutoSize = true;
            this.CbxHakMichAb.Location = new System.Drawing.Point(12, 62);
            this.CbxHakMichAb.Name = "CbxHakMichAb";
            this.CbxHakMichAb.Size = new System.Drawing.Size(88, 17);
            this.CbxHakMichAb.TabIndex = 1;
            this.CbxHakMichAb.Text = "Hak Mich Ab";
            this.CbxHakMichAb.UseVisualStyleBackColor = true;
            // 
            // CbbAuswahl
            // 
            this.CbbAuswahl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbbAuswahl.FormattingEnabled = true;
            this.CbbAuswahl.Items.AddRange(new object[] {
            "Eintrag1",
            "Auswahl2",
            "Item3"});
            this.CbbAuswahl.Location = new System.Drawing.Point(12, 112);
            this.CbbAuswahl.Name = "CbbAuswahl";
            this.CbbAuswahl.Size = new System.Drawing.Size(211, 21);
            this.CbbAuswahl.TabIndex = 2;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(12, 157);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(115, 13);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "Hallo, ich bin ein String";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Item1",
            "Eintrag2"});
            this.listBox1.Location = new System.Drawing.Point(28, 194);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 95);
            this.listBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(305, 134);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(515, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(305, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(263, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 146);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Hallo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterSchließenToolStripMenuItem,
            this.programmBeendenToolStripMenuItem});
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // fensterSchließenToolStripMenuItem
            // 
            this.fensterSchließenToolStripMenuItem.Name = "fensterSchließenToolStripMenuItem";
            this.fensterSchließenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fensterSchließenToolStripMenuItem.Text = "Fenster schließen";
            this.fensterSchließenToolStripMenuItem.Click += new System.EventHandler(this.fensterSchließenToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmBeendenToolStripMenuItem.Text = "Programm beenden";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // BtnZeigeMB
            // 
            this.BtnZeigeMB.Location = new System.Drawing.Point(67, 401);
            this.BtnZeigeMB.Name = "BtnZeigeMB";
            this.BtnZeigeMB.Size = new System.Drawing.Size(102, 26);
            this.BtnZeigeMB.TabIndex = 12;
            this.BtnZeigeMB.Text = "Zeige MB";
            this.BtnZeigeMB.UseVisualStyleBackColor = true;
            this.BtnZeigeMB.Click += new System.EventHandler(this.BtnZeigeMB_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnZeigeMB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CbbAuswahl);
            this.Controls.Add(this.CbxHakMichAb);
            this.Controls.Add(this.BtnKlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKlickMich;
        private System.Windows.Forms.CheckBox CbxHakMichAb;
        private System.Windows.Forms.ComboBox CbbAuswahl;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fensterSchließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.Button BtnZeigeMB;
    }
}

