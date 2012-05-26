namespace LanConfiger
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrCn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeConf = new System.Windows.Forms.Button();
            this.DeleteConf = new System.Windows.Forms.Button();
            this.AcceptConf = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrCn,
            this.toolStripSeparator2,
            this.Exit});
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ConfigToolStripMenuItem.Text = "Конфигурации";
            // 
            // CrCn
            // 
            this.CrCn.Image = global::LanConfiger.Properties.Resources._11;
            this.CrCn.Name = "CrCn";
            this.CrCn.Size = new System.Drawing.Size(117, 22);
            this.CrCn.Text = "Создать";
            this.CrCn.Click += new System.EventHandler(this.CreateConf_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // Exit
            // 
            this.Exit.Image = global::LanConfiger.Properties.Resources._25;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 22);
            this.Exit.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // help
            // 
            this.help.Image = global::LanConfiger.Properties.Resources._17;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(123, 22);
            this.help.Text = "Помощь";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите интрефейс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите кофигурацию";
            // 
            // button1
            // 
            this.button1.Image = global::LanConfiger.Properties.Resources._89;
            this.button1.Location = new System.Drawing.Point(221, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "При изменении или добавлении конфигурации, \r\nнажмите что бы обновить список конфи" +
                    "гураций.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeConf
            // 
            this.changeConf.ForeColor = System.Drawing.Color.Teal;
            this.changeConf.Image = global::LanConfiger.Properties.Resources._24;
            this.changeConf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeConf.Location = new System.Drawing.Point(271, 63);
            this.changeConf.Name = "changeConf";
            this.changeConf.Size = new System.Drawing.Size(113, 54);
            this.changeConf.TabIndex = 4;
            this.changeConf.Text = "Изменить конфигурацию";
            this.changeConf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.changeConf.UseVisualStyleBackColor = true;
            this.changeConf.Click += new System.EventHandler(this.changeConf_Click);
            // 
            // DeleteConf
            // 
            this.DeleteConf.ForeColor = System.Drawing.Color.Red;
            this.DeleteConf.Image = global::LanConfiger.Properties.Resources._12;
            this.DeleteConf.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DeleteConf.Location = new System.Drawing.Point(271, 123);
            this.DeleteConf.Name = "DeleteConf";
            this.DeleteConf.Size = new System.Drawing.Size(113, 26);
            this.DeleteConf.TabIndex = 6;
            this.DeleteConf.Text = "Удалить";
            this.DeleteConf.UseVisualStyleBackColor = true;
            this.DeleteConf.Click += new System.EventHandler(this.DeleteConf_Click);
            // 
            // AcceptConf
            // 
            this.AcceptConf.ForeColor = System.Drawing.Color.Green;
            this.AcceptConf.Image = global::LanConfiger.Properties.Resources._10;
            this.AcceptConf.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AcceptConf.Location = new System.Drawing.Point(271, 32);
            this.AcceptConf.Name = "AcceptConf";
            this.AcceptConf.Size = new System.Drawing.Size(113, 25);
            this.AcceptConf.TabIndex = 3;
            this.AcceptConf.Text = "Применить";
            this.AcceptConf.UseVisualStyleBackColor = true;
            this.AcceptConf.Click += new System.EventHandler(this.AcceptConf_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeConf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DeleteConf);
            this.Controls.Add(this.AcceptConf);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "LanConfiger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button AcceptConf;
        private System.Windows.Forms.Button DeleteConf;
        private System.Windows.Forms.ToolStripMenuItem CrCn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeConf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

