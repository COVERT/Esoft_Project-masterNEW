using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Agents agentsSet = new Agents();
            agentsSet.FirstName = textBoxFirstName.Text;
            agentsSet.MiddleName = textBoxMiddleName.Text;
            agentsSet.LastName = textBoxLastName.Text;
            agentsSet.DealShare = Convert.ToInt32(textBoxDealshare.Text);
            Program.wftDB.AgentsSet.Add(agentsSet);
            Program.wftDB.SaveChanges();


        }
    }
}
