
namespace W5Praktikum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.ListBoxInput = new System.Windows.Forms.ListBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.radioButtonWarnaMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonWarnaBiru = new System.Windows.Forms.RadioButton();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelShowOutput = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(106, 34);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(435, 27);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(52, 37);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data :";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(577, 33);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(94, 29);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(52, 115);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(63, 20);
            this.labelKoleksi.TabIndex = 3;
            this.labelKoleksi.Text = "Koleksi :";
            // 
            // ListBoxInput
            // 
            this.ListBoxInput.FormattingEnabled = true;
            this.ListBoxInput.ItemHeight = 20;
            this.ListBoxInput.Location = new System.Drawing.Point(52, 157);
            this.ListBoxInput.Name = "ListBoxInput";
            this.ListBoxInput.Size = new System.Drawing.Size(263, 264);
            this.ListBoxInput.TabIndex = 4;
            this.ListBoxInput.SelectedIndexChanged += new System.EventHandler(this.ListBoxInput_SelectedIndexChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(398, 115);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(63, 20);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Setting :";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(467, 115);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // radioButtonWarnaMerah
            // 
            this.radioButtonWarnaMerah.AutoSize = true;
            this.radioButtonWarnaMerah.Location = new System.Drawing.Point(467, 157);
            this.radioButtonWarnaMerah.Name = "radioButtonWarnaMerah";
            this.radioButtonWarnaMerah.Size = new System.Drawing.Size(118, 24);
            this.radioButtonWarnaMerah.TabIndex = 7;
            this.radioButtonWarnaMerah.TabStop = true;
            this.radioButtonWarnaMerah.Text = "Warna Merah";
            this.radioButtonWarnaMerah.UseVisualStyleBackColor = true;
            this.radioButtonWarnaMerah.CheckedChanged += new System.EventHandler(this.radioButtonWarnaMerah_CheckedChanged);
            // 
            // radioButtonWarnaBiru
            // 
            this.radioButtonWarnaBiru.AutoSize = true;
            this.radioButtonWarnaBiru.Location = new System.Drawing.Point(467, 187);
            this.radioButtonWarnaBiru.Name = "radioButtonWarnaBiru";
            this.radioButtonWarnaBiru.Size = new System.Drawing.Size(102, 24);
            this.radioButtonWarnaBiru.TabIndex = 8;
            this.radioButtonWarnaBiru.TabStop = true;
            this.radioButtonWarnaBiru.Text = "Warna Biru";
            this.radioButtonWarnaBiru.UseVisualStyleBackColor = true;
            this.radioButtonWarnaBiru.CheckedChanged += new System.EventHandler(this.radioButtonWarnaBiru_CheckedChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(398, 276);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(62, 20);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output :";
            // 
            // labelShowOutput
            // 
            this.labelShowOutput.AutoSize = true;
            this.labelShowOutput.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShowOutput.Location = new System.Drawing.Point(485, 362);
            this.labelShowOutput.Name = "labelShowOutput";
            this.labelShowOutput.Size = new System.Drawing.Size(0, 59);
            this.labelShowOutput.TabIndex = 10;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(467, 517);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(253, 29);
            this.ButtonClear.TabIndex = 11;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.labelShowOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.radioButtonWarnaBiru);
            this.Controls.Add(this.radioButtonWarnaMerah);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.ListBoxInput);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.ListBox ListBoxInput;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.RadioButton radioButtonWarnaMerah;
        private System.Windows.Forms.RadioButton radioButtonWarnaBiru;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelShowOutput;
        private System.Windows.Forms.Button ButtonClear;
    }
}

