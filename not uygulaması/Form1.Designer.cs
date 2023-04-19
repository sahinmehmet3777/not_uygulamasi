namespace not_uygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.noteklebtn = new System.Windows.Forms.Button();
            this.notgrsbox = new System.Windows.Forms.TextBox();
            this.yazi1lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciadıBox1 = new System.Windows.Forms.TextBox();
            this.buyukucuklbl = new System.Windows.Forms.Label();
            this.notadetbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notadettxt = new System.Windows.Forms.TextBox();
            this.listelebtn = new System.Windows.Forms.Button();
            this.scmbox1 = new System.Windows.Forms.ComboBox();
            this.bklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(361, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "-- Harf Notu Hesaplama --";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.BackColor = System.Drawing.Color.White;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.sonuclbl.Location = new System.Drawing.Point(42, 288);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(0, 31);
            this.sonuclbl.TabIndex = 8;
            // 
            // noteklebtn
            // 
            this.noteklebtn.Enabled = false;
            this.noteklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.noteklebtn.Location = new System.Drawing.Point(542, 213);
            this.noteklebtn.Name = "noteklebtn";
            this.noteklebtn.Size = new System.Drawing.Size(134, 38);
            this.noteklebtn.TabIndex = 7;
            this.noteklebtn.Text = "Notu ekle";
            this.noteklebtn.UseVisualStyleBackColor = true;
            this.noteklebtn.Visible = false;
            this.noteklebtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // notgrsbox
            // 
            this.notgrsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.notgrsbox.Location = new System.Drawing.Point(689, 168);
            this.notgrsbox.Name = "notgrsbox";
            this.notgrsbox.Size = new System.Drawing.Size(134, 29);
            this.notgrsbox.TabIndex = 6;
            this.notgrsbox.Visible = false;
            this.notgrsbox.WordWrap = false;
            this.notgrsbox.TextChanged += new System.EventHandler(this.notgrsbox_TextChanged);
            this.notgrsbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notgrsbox_KeyPress);
            // 
            // yazi1lbl
            // 
            this.yazi1lbl.AutoSize = true;
            this.yazi1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.yazi1lbl.Location = new System.Drawing.Point(41, 161);
            this.yazi1lbl.Name = "yazi1lbl";
            this.yazi1lbl.Size = new System.Drawing.Size(463, 37);
            this.yazi1lbl.TabIndex = 5;
            this.yazi1lbl.Text = "Lütfen sınav notunuzu giriniz:";
            this.yazi1lbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(128, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Öğrencinin adını giriniz:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ogrenciadıBox1
            // 
            this.ogrenciadıBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ogrenciadıBox1.Location = new System.Drawing.Point(689, 117);
            this.ogrenciadıBox1.Name = "ogrenciadıBox1";
            this.ogrenciadıBox1.Size = new System.Drawing.Size(134, 29);
            this.ogrenciadıBox1.TabIndex = 11;
            this.ogrenciadıBox1.Visible = false;
            this.ogrenciadıBox1.WordWrap = false;
            this.ogrenciadıBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrenciadıBox1_KeyPress);
            // 
            // buyukucuklbl
            // 
            this.buyukucuklbl.AutoSize = true;
            this.buyukucuklbl.BackColor = System.Drawing.Color.White;
            this.buyukucuklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buyukucuklbl.Location = new System.Drawing.Point(42, 332);
            this.buyukucuklbl.Name = "buyukucuklbl";
            this.buyukucuklbl.Size = new System.Drawing.Size(0, 31);
            this.buyukucuklbl.TabIndex = 12;
            // 
            // notadetbtn
            // 
            this.notadetbtn.Enabled = false;
            this.notadetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.notadetbtn.Location = new System.Drawing.Point(542, 151);
            this.notadetbtn.Name = "notadetbtn";
            this.notadetbtn.Size = new System.Drawing.Size(134, 38);
            this.notadetbtn.TabIndex = 13;
            this.notadetbtn.Text = "kaydet";
            this.notadetbtn.UseVisualStyleBackColor = true;
            this.notadetbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(128, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kaç tane not gireceksiniz:";
            // 
            // notadettxt
            // 
            this.notadettxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.notadettxt.Location = new System.Drawing.Point(542, 116);
            this.notadettxt.Name = "notadettxt";
            this.notadettxt.Size = new System.Drawing.Size(134, 29);
            this.notadettxt.TabIndex = 15;
            this.notadettxt.TextChanged += new System.EventHandler(this.notadettxt_TextChanged);
            this.notadettxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notadettxt_KeyPress);
            // 
            // listelebtn
            // 
            this.listelebtn.Enabled = false;
            this.listelebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listelebtn.Location = new System.Drawing.Point(704, 213);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(134, 38);
            this.listelebtn.TabIndex = 16;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Visible = false;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // scmbox1
            // 
            this.scmbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scmbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scmbox1.FormattingEnabled = true;
            this.scmbox1.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.scmbox1.Location = new System.Drawing.Point(689, 333);
            this.scmbox1.Name = "scmbox1";
            this.scmbox1.Size = new System.Drawing.Size(121, 28);
            this.scmbox1.TabIndex = 17;
            this.scmbox1.Visible = false;
            this.scmbox1.SelectedIndexChanged += new System.EventHandler(this.scmbox1_SelectedIndexChanged);
            // 
            // bklbl
            // 
            this.bklbl.AutoSize = true;
            this.bklbl.BackColor = System.Drawing.Color.White;
            this.bklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bklbl.Location = new System.Drawing.Point(42, 440);
            this.bklbl.Name = "bklbl";
            this.bklbl.Size = new System.Drawing.Size(64, 31);
            this.bklbl.TabIndex = 18;
            this.bklbl.Text = "-----";
            this.bklbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1139, 650);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.ogrenciadıBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteklebtn);
            this.Controls.Add(this.notgrsbox);
            this.Controls.Add(this.yazi1lbl);
            this.Controls.Add(this.bklbl);
            this.Controls.Add(this.scmbox1);
            this.Controls.Add(this.notadettxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notadetbtn);
            this.Controls.Add(this.buyukucuklbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonuclbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sonuclbl;
        private System.Windows.Forms.Button noteklebtn;
        private System.Windows.Forms.TextBox notgrsbox;
        private System.Windows.Forms.Label yazi1lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrenciadıBox1;
        private System.Windows.Forms.Label buyukucuklbl;
        private System.Windows.Forms.Button notadetbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox notadettxt;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.ComboBox scmbox1;
        private System.Windows.Forms.Label bklbl;
    }
}

