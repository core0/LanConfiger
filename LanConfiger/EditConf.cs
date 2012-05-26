using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Xml;

namespace LanConfiger
{
    public partial class EditConf : Form
    {
        public EditConf()
        {
            InitializeComponent();
        }


        static public Int32 index = -1;
        //очистка формы
        void clear()
        {

            nameConf.Text = "";
            ipConf.Text = "";
            maskConf.Text = "";
            shluzConf.Text = "";
            dnsConf.Text = "";
        }
        //открываем для редактрирования конфигурацию, которы выбраны в списке на главной форме
        private void EditConf_Load(object sender, EventArgs e)
        {


            if (index !=-1)
            {
                LanConfiger.Main.conf tmp = (LanConfiger.Main.conf)Main.SetCn[index];
                nameConf.Text = tmp.name;
                ipConf.Text = tmp.ip;
                maskConf.Text = tmp.mask;
                shluzConf.Text = tmp.shluz;
                dnsConf.Text = tmp.dnsip;                

            }

        }
        //обрабатываем закрытие формы
        private void EditConf_FormClosed(object sender, FormClosedEventArgs e)
        {
            clear();
            this.Hide();
        }

        //удалени старой конфигурации, и сохранение новой конфигурации путем вызова
        //функциии записи конфигурации в главной форме
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("data.xml");
            XmlNode frmDel = xd.GetElementsByTagName("configurations")[index];
            frmDel.ParentNode.RemoveChild(frmDel);
            xd.Save("data.xml");
            
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
    }
}
