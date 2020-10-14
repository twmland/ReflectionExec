using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// https://www.itread01.com/content/1552328408.html
namespace CSharpWinFormReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var file = @"D:\Positions\RobotPathGetter\MvAssistant.Mac.VerifyEqp.exe";
            Assembly assemFrom =Assembly.LoadFrom(file);
            Assembly assemFile = Assembly.LoadFile(file);
        }
    }
}
