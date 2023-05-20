namespace NotDefteri
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchMesaj = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkListe = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notlar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchMesaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // rchMesaj
            // 
            this.rchMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchMesaj.Location = new System.Drawing.Point(3, 23);
            this.rchMesaj.Name = "rchMesaj";
            this.rchMesaj.Size = new System.Drawing.Size(1024, 91);
            this.rchMesaj.TabIndex = 0;
            this.rchMesaj.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1048, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkListe
            // 
            this.chkListe.FormattingEnabled = true;
            this.chkListe.Location = new System.Drawing.Point(6, 19);
            this.chkListe.Name = "chkListe";
            this.chkListe.Size = new System.Drawing.Size(1129, 488);
            this.chkListe.TabIndex = 0;
            this.chkListe.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListe_ItemCheck);
            this.chkListe.SelectedIndexChanged += new System.EventHandler(this.chkListe_SelectedIndexChanged);
            this.chkListe.SelectedValueChanged += new System.EventHandler(this.chkListe_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchMesaj;
        private System.Windows.Forms.Button button1;
    }
}

