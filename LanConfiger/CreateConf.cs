using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//


namespace LanConfiger
{
    public partial class CreateConf : Form
    {
        public CreateConf()
        {
            InitializeComponent();
        }
        //очистка текстовых полей
        void clear(){

            nameConf.Text = "";
            ipConf.Text = "";
            maskConf.Text = "";
            shluzConf.Text = "";
            dnsConf.Text = "";
        }

        //создание конфигурации от вызов функции из главной формы для записи конфигурации в файл
        private void button1_Click(object sender, EventArgs e)
        {
            LanConfiger.Main.conf newConfigurations = new LanConfiger.Main.conf();
            newConfigurations.name = nameConf.Text;
            newConfigurations.ip = ipConf.Text;
            newConfigurations.mask = maskConf.Text;
            newConfigurations.shluz = shluzConf.Text;
            newConfigurations.dnsip = dnsConf.Text;
            Main.WriteXML(newConfigurations);
            clear();
            this.Hide();



        }
        //обработка закрытия форму
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            this.Hide();
        }

        private void CreateConf_FormClosed(object sender, FormClosedEventArgs e)
        {
            clear();
            this.Hide();
        }

    }
}
