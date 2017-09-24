using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prism;
using Prism.Events;

namespace PrismDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainABAgent.SubscribeEvent();
            new ABForm().Show();
        }  

        public void OpenABScreen()
        {
            panel1.Visible = true;
            ABAgent.OpenABScreen();
        }

        public void CloseWindow()
        {
            //this.Close();
            ABAgent.CloseWindow();
        }

        public void SynchronizeWindow()
        {
            ABAgent.SyncAB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenABScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SynchronizeWindow();
        }
    }
}
