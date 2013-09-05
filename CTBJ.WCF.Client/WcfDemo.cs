using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CTBJ.WCF.Client
{
    public partial class WcfDemo : Form
    {
        public WcfDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFService.Service1Client server = new WCFService.Service1Client();

            WCFService.Person person = new WCFService.Person();
            person.Name = "张三";
            person.Gender = "男";

            person = server.changeSex(person);

            MessageBox.Show(string.Format("the gender of {0} is {1}", person.Name, person.Gender));
        }
    }
}
