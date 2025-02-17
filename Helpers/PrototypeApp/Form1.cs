using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers.Enum;

namespace PrototypeApp
{
    public partial class PrototypeFrm : Form
    {
        public PrototypeFrm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var test = new Statuses();
            
            

            this.txtMain.Text = Statuses.FindItem(1).Name; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtMain.Text = "";
        }
    }
}
