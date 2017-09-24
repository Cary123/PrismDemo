using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrismDemo
{
    public partial class ABForm : Form
    {
        public ABForm()
        {
            InitializeComponent();
            ABAgent.SubscribeEvent();
        }

        public void SynchronizeAB()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        protected override void CreateHandle()
        {
            base.CreateHandle();          
        }
    }
}
