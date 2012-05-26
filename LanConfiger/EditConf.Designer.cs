namespace LanConfiger
{
    partial class EditConf
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
            this.label4 = new System.Windows.Forms.Label();
            this.dnsConf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shluzConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskConf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipConf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameConf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dnsConf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.shluzConf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskConf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipConf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameConf);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры конфигурации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "dns сервер";
            // 
            // dnsConf
            // 
            this.dnsConf.Location = new System.Drawing.Point(162, 127);
            this.dnsConf.Name = "dnsConf";
            this.dnsConf.Size = new System.Drawing.Size(145, 21);
            this.dnsConf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ip шлюза";
            // 
            // shluzConf
            // 
            this.shluzConf.Location = new System.Drawing.Point(8, 127);
            this.shluzConf.Name = "shluzConf";
            this.shluzConf.Size = new System.Drawing.Size(145, 21);
            this.shluzConf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "маска сети";
            // 
            // maskConf
            // 
            this.maskConf.Location = new System.Drawing.Point(162, 84);
            this.maskConf.Name = "maskConf";
            this.maskConf.Size = new System.Drawing.Size(145, 21);
            this.maskConf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ip адрес";
            // 
            // ipConf
            // 
            this.ipConf.Location = new System.Drawing.Point(8, 84);
            this.ipConf.Name = "ipConf";
            this.ipConf.Size = new System.Drawing.Size(145, 21);
            this.ipConf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя конфигурации";
            // 
            // nameConf
            // 
            this.nameConf.Location = new System.Drawing.Point(8, 43);
            this.nameConf.Name = "nameConf";
            this.nameConf.Size = new System.Drawing.Size(145, 21);
            this.nameConf.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Image = global::LanConfiger.Properties.Resources._45;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(7, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditConf";
            this.Text = "Редактирование конфигурации";
            this.Load += new System.EventHandler(this.EditConf_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditConf_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dnsConf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shluzConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maskConf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameConf;
    }
}