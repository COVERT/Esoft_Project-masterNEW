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
            ShowAgent();
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (Agents agentsSet in Program.newDB.Agents)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentsSet.ID.ToString(),
                        agentsSet.FirstName ,
                        agentsSet.MiddleName,
                        agentsSet.LastName ,
                       Convert.ToString (agentsSet.DealShare) 
                });
                item.Tag = agentsSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Agents agentsSet = new Agents();
            agentsSet.FirstName = textBoxFirstName.Text;
            agentsSet.MiddleName = textBoxMiddleName.Text;
            agentsSet.LastName = textBoxLastName.Text;
            agentsSet.DealShare = Convert.ToInt32(textBoxDealshare.Text);
            Program.newDB.Agents.Add(agentsSet);
            Program.newDB.SaveChanges();
            ShowAgent();

        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
