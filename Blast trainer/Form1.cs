using System;
using System.Configuration;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Memory;

namespace Blast_trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int pID = m.GetProcIdFromName("EarthwormJim3D");   //  ZInfo: get proc id of game

                bool openProc = false;  // ZInfo: Is process open?

                if (pID > 0) openProc = m.OpenProcess(pID); // ZInfo: Try opening process if proc ID is greater than 1.

                if (openProc)   // ZInfo: If process open, do code
                {
                    //Config file stuff
                    string sAttr;
                    sAttr = ConfigurationManager.AppSettings.Get("aRatio");                


                    //The pointer bytes are read from bottom to top in cheat engine. I was doing top to bottom at first, which of course made it not work.
                    if (lives.Checked) m.WriteMemory("base+000FBEE8,4,34,B1C", "float", sAttr);

                }

            }
        }

        private void lives_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
