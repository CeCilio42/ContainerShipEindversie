using ContainerShipV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerShipEindversie
{
    public partial class ContainerShipForm : Form
    {
        List<Container> FormContainers = new List<Container>();

        public ContainerShipForm()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(2, 3));

            FormContainers.Add(new Container(30, 4));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 2));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 4));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 3));
            FormContainers.Add(new Container(30, 1));
            FormContainers.Add(new Container(30, 1));
            FormContainers.Add(new Container(30, 1));
            FormContainers.Add(new Container(30, 1));
            FormContainers.Add(new Container(30, 2));

            foreach (Container container in FormContainers)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }
    }
}
