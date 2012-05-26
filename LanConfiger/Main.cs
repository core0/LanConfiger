using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections;

namespace LanConfiger

{
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //страктура конфигурации(глобальная и определяется через LanConfiger.Form1.conf)
        public class conf
        {

            public String name;
            public String ip;
            public String mask;
            public String shluz;
            public String dnsip;

        }
        //глобальный массив с конфигурациями
        static public ArrayList SetCn;


        //функция записи конфигураций
        static public void WriteXML(LanConfiger.Main.conf c)
        {

            LanConfiger.Main.conf configs = c;

            XmlDocument xd = new XmlDocument();
            xd.Load("data.xml");

            XmlElement record = xd.CreateElement("configurations");
            record.SetAttribute("name", configs.name);
            record.SetAttribute("ip", configs.ip);
            record.SetAttribute("mask", configs.mask);
            record.SetAttribute("shluz", configs.shluz);
            record.SetAttribute("dns", configs.dnsip);
            xd.DocumentElement.AppendChild(record);

            xd.Save("data.xml");

        }
        //функция чтения файла с конфигурациями
        static public void ReadXML()
        {
            SetCn = new ArrayList();

            XmlDocument xd = new XmlDocument();
            xd.Load("data.xml");

            //получаем список всех элементов с тегом "configurations"
            XmlNodeList xl = xd.GetElementsByTagName("configurations");
            foreach (XmlElement itm in xl)
            {
                conf UnConf = new conf();
                UnConf.name = itm.GetAttribute("name");
                UnConf.ip = itm.GetAttribute("ip");
                UnConf.mask = itm.GetAttribute("mask");
                UnConf.shluz = itm.GetAttribute("shluz");
                UnConf.dnsip = itm.GetAttribute("dns");

                SetCn.Add(UnConf);
            }

        }



        //открываем форму создания конфигурации
        private void CreateConf_Click(object sender, EventArgs e)
        {
            Form CreateConf = new CreateConf();
            CreateConf.Show();
            

        }
        //загружаем список сетевых интерфейсов и список конфигураций
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                if(!File.Exists("data.xml"))
                    File.WriteAllText("data.xml","<xml version=\"1.0\" encoding=\"utf-8\">\n</xml>");


                System.Net.NetworkInformation.NetworkInterface[] f = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

                foreach (System.Net.NetworkInformation.NetworkInterface interf in f)
                {
                    //фильтруем "физические" адаптеры
                    if (interf.Name.IndexOf("{") == -1 && interf.Name.IndexOf("Pseudo-Interface") == -1)
                        comboBox1.Items.Add(interf.Name);
                }
                
                ReadXML();

                //отображаем список загруженых конфигураций из файла
                foreach (conf tmp in SetCn)
                {
                    comboBox2.Items.Add(tmp.name);
                    comboBox2.SelectedItem = comboBox2.Items[0];
                }  

            }
            catch (System.Exception ex)
            {
            	
            }

        }

        //исполнение команды по приминению конфигурации к выбраному адаптеру
        private void AcceptConf_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                Process run_cmd = new Process();

                //построение команды к netsh.exe для смены ip адреса, маски сети, и шлюза
                conf temp = (conf)SetCn[comboBox2.SelectedIndex];
                String cmd = "interface ip set address \"" + 
                    comboBox1.Items[comboBox1.SelectedIndex].ToString()
                    + "\" static " + 
                    temp.ip + 
                    " " + 
                    temp.mask + 
                    " " + 
                    " " + 
                    temp.shluz;
                this.Text = "Применяются настройки... Подождите.";
                //выполнение                
                run_cmd.StartInfo.FileName = "netsh.exe";
                run_cmd.StartInfo.Arguments = cmd;
                run_cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                run_cmd.Start();
                run_cmd.WaitForExit();

                //посроение команды к netsh.exe для смены днс сервера
                cmd = "interface ip set dns \"" + 
                        comboBox1.Items[comboBox1.SelectedIndex].ToString()
                        + "\" static " + temp.dnsip;

                //выполнение
                run_cmd.StartInfo.FileName = "netsh.exe";
                run_cmd.StartInfo.Arguments = cmd;
                run_cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                run_cmd.Start();
                run_cmd.WaitForExit();
                this.Text = "LanConfiger";

            }
            else{

                MessageBox.Show("Выберите из списка конфигурацию и подключение.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        //открываем форму для изменения конфигурации адаптера
        private void changeConf_Click(object sender, EventArgs e)
        {
            LanConfiger.EditConf.index = comboBox2.SelectedIndex;
            Form EditConf = new EditConf();
            EditConf.Show();
        }

        //удаляем конфигурацию
        private void DeleteConf_Click(object sender, EventArgs e)
        {

            XmlDocument xd = new XmlDocument();
            xd.Load("data.xml");
            XmlNode frmDel = xd.GetElementsByTagName("configurations")[comboBox2.SelectedIndex];
            frmDel.ParentNode.RemoveChild(frmDel);
            xd.Save("data.xml");
        }

        //обновление списка конфигураций
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            ReadXML();
            for (int i = 0; i < SetCn.Count; i++)
            {

                conf tmp = new conf();
                tmp = (conf)SetCn[i];
                comboBox2.Items.Add(tmp.name);
                if (i == 0)
                    comboBox2.SelectedItem = comboBox2.Items[0];
            }

        }


    }
}
