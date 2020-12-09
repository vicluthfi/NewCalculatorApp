using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalc
{
    public partial class FrmHasil : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public FrmHasil()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FrmEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            lstHasil.Items.Add(cal.Hasil);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCalculator frmEntry = new FrmCalculator("Calculator");
            frmEntry.OnCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }

        private void FrmCal_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
