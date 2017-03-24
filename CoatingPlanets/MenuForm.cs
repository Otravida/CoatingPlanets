using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoatingPlanets
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void chamberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamberForm f2 = Application.OpenForms["ChamberForm"] as ChamberForm;
            f2 = new CoatingPlanets.ChamberForm();
            f2.Show();
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataForm f3 = Application.OpenForms["DataForm"] as DataForm;
            f3 = new CoatingPlanets.DataForm();
            f3.Show();
        }
    }
}
