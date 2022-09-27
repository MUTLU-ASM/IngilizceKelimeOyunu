
namespace KelimeOgren
{
    partial class frmKelimeOgren
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTekrarOyna = new System.Windows.Forms.Button();
            this.lblİngilizce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe :";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurkce.Location = new System.Drawing.Point(140, 115);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(312, 39);
            this.txtTurkce.TabIndex = 0;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre :";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(624, 45);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(43, 33);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime :";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.Location = new System.Drawing.Point(638, 115);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(29, 33);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCevap.Location = new System.Drawing.Point(146, 169);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(29, 33);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "..";
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTekrarOyna
            // 
            this.btnTekrarOyna.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTekrarOyna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekrarOyna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTekrarOyna.Location = new System.Drawing.Point(512, 162);
            this.btnTekrarOyna.Name = "btnTekrarOyna";
            this.btnTekrarOyna.Size = new System.Drawing.Size(155, 49);
            this.btnTekrarOyna.TabIndex = 9;
            this.btnTekrarOyna.Text = "Tekrar Oyna";
            this.btnTekrarOyna.UseVisualStyleBackColor = false;
            this.btnTekrarOyna.Visible = false;
            this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // lblİngilizce
            // 
            this.lblİngilizce.AutoSize = true;
            this.lblİngilizce.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİngilizce.Location = new System.Drawing.Point(150, 47);
            this.lblİngilizce.Name = "lblİngilizce";
            this.lblİngilizce.Size = new System.Drawing.Size(85, 33);
            this.lblİngilizce.TabIndex = 10;
            this.lblİngilizce.Text = "_____";
            // 
            // frmKelimeOgren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 215);
            this.Controls.Add(this.lblİngilizce);
            this.Controls.Add(this.btnTekrarOyna);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKelimeOgren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKelimeOyunu";
            this.Load += new System.EventHandler(this.frmKelimeOgren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTekrarOyna;
        private System.Windows.Forms.Label lblİngilizce;
    }
}

