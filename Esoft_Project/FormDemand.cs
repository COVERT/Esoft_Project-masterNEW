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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
        }

        void ShowAgents()
        {
            //очистка
            comboBoxAgents.Items.Clear();
            foreach(AgentsSet agentsSet in Program.wftDB.AgentsSet)
            {
                string[] item =
                {
                    agentsSet.Id.ToString()+".",
                    agentsSet.FirstName,
                    agentsSet.LastName
                };
                comboBoxAgents.Items.Add(string.Join(" ", item));
                
            }

        }
        void ShowRealEstate()
        {
            //очистка
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstatesSet in Program.wftDB.RealEstateSet)
            {
                string[] item =
                {
                   realEstatesSet.Id.ToString()+".",
                    realEstatesSet.Address_City+",",
                     realEstatesSet.Address_Street,
                     realEstatesSet.Address_Hoyse,
                     realEstatesSet.Address_Number
                };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));

            }

        }
        void ShowClients()
        {
            //очистка
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDB.ClientsSet)
            {
                string[] item =
                {
                    clientsSet.Id.ToString()+".",
                    clientsSet.FirserName,
                     clientsSet.lastName
                };
                comboBoxClients.Items.Add(string.Join(" ", item));

            }

        }

        private void labelRealEstate_Click(object sender, EventArgs e)
        {

        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null &&
                comboBoxClients.SelectedItem != null && 
                comboBoxRealEstate.SelectedItem != null && 
                textBoxMinPrice.Text != " "&&
                textBoxMaxPrice.Text != " " &&
                textBoxMinRooms.Text != " " &&
                textBoxMaxRooms.Text != " "&&
                textBoxMinFloors.Text != " "&&
                textBoxMaxFloors.Text != " " &&
                textBoxMaxFloor.Text != " " &&
                textBoxMinFloor.Text != " " &&
                textBoxMinArea.Text != " " &&
                textBoxMaxArea.Text != " ")
            {
                //создаем новый эл в класс предложений
                DemandSet demand = new DemandSet();
                //отделяем id и делаем ссылку на суппле
                demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]); 
                demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                Program.wftDB.DemandSet.Add(demand);
                Program.wftDB.SaveChanges();
                
            }


        }
    }
}
