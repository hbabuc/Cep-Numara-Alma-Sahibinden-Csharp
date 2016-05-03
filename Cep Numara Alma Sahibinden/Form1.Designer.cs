namespace Cep_Numara_Alma_Sahibinden
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
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.baslangicTxt = new System.Windows.Forms.TextBox();
            this.kactaneTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cekilenList = new System.Windows.Forms.ListBox();
            this.tumuTxt = new System.Windows.Forms.TextBox();
            this.kacSaniyeTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.durumList = new System.Windows.Forms.ListBox();
            this.kacSaniyede2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkTxt
            // 
            this.linkTxt.Location = new System.Drawing.Point(115, 26);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Size = new System.Drawing.Size(507, 20);
            this.linkTxt.TabIndex = 0;
            this.linkTxt.Text = "http://www.sahibinden.com/satilik-daire/bursa";
            // 
            // baslangicTxt
            // 
            this.baslangicTxt.Enabled = false;
            this.baslangicTxt.Location = new System.Drawing.Point(115, 89);
            this.baslangicTxt.Name = "baslangicTxt";
            this.baslangicTxt.Size = new System.Drawing.Size(197, 20);
            this.baslangicTxt.TabIndex = 2;
            this.baslangicTxt.Text = "0";
            // 
            // kactaneTxt
            // 
            this.kactaneTxt.Enabled = false;
            this.kactaneTxt.Location = new System.Drawing.Point(444, 89);
            this.kactaneTxt.Name = "kactaneTxt";
            this.kactaneTxt.Size = new System.Drawing.Size(178, 20);
            this.kactaneTxt.TabIndex = 3;
            this.kactaneTxt.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Başlangıç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaç tane";
            // 
            // cekilenList
            // 
            this.cekilenList.FormattingEnabled = true;
            this.cekilenList.Location = new System.Drawing.Point(37, 248);
            this.cekilenList.Name = "cekilenList";
            this.cekilenList.Size = new System.Drawing.Size(275, 290);
            this.cekilenList.TabIndex = 8;
            // 
            // tumuTxt
            // 
            this.tumuTxt.HideSelection = false;
            this.tumuTxt.Location = new System.Drawing.Point(386, 248);
            this.tumuTxt.Multiline = true;
            this.tumuTxt.Name = "tumuTxt";
            this.tumuTxt.Size = new System.Drawing.Size(236, 290);
            this.tumuTxt.TabIndex = 9;
            // 
            // kacSaniyeTxt
            // 
            this.kacSaniyeTxt.Location = new System.Drawing.Point(186, 574);
            this.kacSaniyeTxt.Name = "kacSaniyeTxt";
            this.kacSaniyeTxt.Size = new System.Drawing.Size(43, 20);
            this.kacSaniyeTxt.TabIndex = 10;
            this.kacSaniyeTxt.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tümü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Şu anda çekilen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kaç saniyede bir çekilsin";
            // 
            // durumList
            // 
            this.durumList.FormattingEnabled = true;
            this.durumList.Location = new System.Drawing.Point(37, 140);
            this.durumList.Name = "durumList";
            this.durumList.Size = new System.Drawing.Size(585, 69);
            this.durumList.TabIndex = 15;
            // 
            // kacSaniyede2
            // 
            this.kacSaniyede2.Location = new System.Drawing.Point(265, 574);
            this.kacSaniyede2.Name = "kacSaniyede2";
            this.kacSaniyede2.Size = new System.Drawing.Size(46, 20);
            this.kacSaniyede2.TabIndex = 17;
            this.kacSaniyede2.Tag = "";
            this.kacSaniyede2.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 645);
            this.Controls.Add(this.kacSaniyede2);
            this.Controls.Add(this.durumList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kacSaniyeTxt);
            this.Controls.Add(this.tumuTxt);
            this.Controls.Add(this.cekilenList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kactaneTxt);
            this.Controls.Add(this.baslangicTxt);
            this.Controls.Add(this.linkTxt);
            this.Name = "Form1";
            this.Text = "Sahibinden Numara Alma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox linkTxt;
        private System.Windows.Forms.TextBox baslangicTxt;
        private System.Windows.Forms.TextBox kactaneTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox cekilenList;
        private System.Windows.Forms.TextBox tumuTxt;
        private System.Windows.Forms.TextBox kacSaniyeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox durumList;
        private System.Windows.Forms.TextBox kacSaniyede2;
    }
}

