using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Containervervoer_Logic;

namespace Containervervoer_algoritme
{
    public partial class Form1 : Form
    {
        public Dock Dock = new Dock();
        bool IsShipSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_AddContainer_Click(object sender, EventArgs e)
        {
            int weight = 4000;
            bool isCooled = false;
            bool isValuable = false;

            weight = Convert.ToInt32(numericUpDown_Weight.Value);
            if(checkBox_IsCooled.Checked)
            {
                isCooled = true;
            }
            if (checkBox_IsValuable.Checked)
            {
                isValuable = true;
            }

            Containervervoer_Logic.Container container = new Containervervoer_Logic.Container(weight, isCooled, isValuable);
            Dock.AddContainerToContainersToDistributeList(container);

            UpdateListBoxes();
        }

        private void Btn_EditShip_Click(object sender, EventArgs e)
        {
            IsShipSet = true;

            int verticalRows = Convert.ToInt32(numericUpDown_VerticalRows.Value);
            int horizontalRows = Convert.ToInt32(numericUpDown_HorizontalRows.Value);
            int maxWeight = Convert.ToInt32(numericUpDown_MaxWeight.Value);

            Dock.SetShipSize(verticalRows, horizontalRows, maxWeight);

            MessageBox.Show("Schipgrootte succesvol ingesteld");
        }

        private void UpdateListBoxes()
        {
            listBox_ContainersToDistribute.Items.Clear();

            foreach(var c in Dock.GetContainersToDistribute())
            {
                listBox_ContainersToDistribute.Items.Add(c);
            }
        }

        private void Btn_SortContainers_Click(object sender, EventArgs e)
        {
            if (IsShipSet)
            {
                Dock.DistributeContainersToShip();
            }
            else
            {
                MessageBox.Show("Vergeet niet eerst het schip in te stellen.");
            }
        }
    }
}
