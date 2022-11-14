namespace autonyilvan
{
    partial class Form_Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.textBox_szin = new System.Windows.Forms.TextBox();
            this.numericUpDown_evjarat = new System.Windows.Forms.NumericUpDown();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_evjarat)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(120, 450);
            this.listBox_Autok.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.numericUpDown_evjarat);
            this.groupBox1.Controls.Add(this.textBox_szin);
            this.groupBox1.Controls.Add(this.textBox_rendszam);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválastott autók adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "rendszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "évjárat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "szín";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 51);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(73, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(117, 95);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(115, 20);
            this.textBox_rendszam.TabIndex = 5;
            // 
            // textBox_szin
            // 
            this.textBox_szin.Location = new System.Drawing.Point(117, 183);
            this.textBox_szin.Name = "textBox_szin";
            this.textBox_szin.Size = new System.Drawing.Size(115, 20);
            this.textBox_szin.TabIndex = 7;
            // 
            // numericUpDown_evjarat
            // 
            this.numericUpDown_evjarat.Location = new System.Drawing.Point(117, 141);
            this.numericUpDown_evjarat.Name = "numericUpDown_evjarat";
            this.numericUpDown_evjarat.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown_evjarat.TabIndex = 8;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(71, 241);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(137, 36);
            this.insert.TabIndex = 9;
            this.insert.Text = "Új Autó";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(71, 302);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(137, 36);
            this.update.TabIndex = 10;
            this.update.Text = "Módosítás";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(71, 364);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(137, 36);
            this.delete.TabIndex = 11;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Autok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Nyito";
            this.Text = "Autok_nyilvantartas";
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_evjarat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.NumericUpDown numericUpDown_evjarat;
        private System.Windows.Forms.TextBox textBox_szin;
        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

