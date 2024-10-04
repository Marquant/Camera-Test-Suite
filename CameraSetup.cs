using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_Test_Suite
{
    public partial class CameraSetup : Form
    {

        private string[] vendors;
        private List<ComboBox> dropdowns = new List<ComboBox>();
        public Camera camera;

        public CameraSetup(string[] vendorNames)
        {
            InitializeComponent();
            vendors = vendorNames;
        }

        private void CameraSetup_Load(object sender, EventArgs e)
        {
            //Load camera vendor list to dropdowns
            dropdowns.Add(camera1Dropdown);

            foreach (ComboBox cameraDropdown in dropdowns)
            {
                for (int i = 0; i < vendors.Length; i++)
                {
                    cameraDropdown.Items.Add(vendors[i]);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Add new camera to cameralist

            if (camera1NameBox.Text != "")
            {
                camera = new Camera(camera1NameBox.Text, camera1Dropdown.Text, camera1MqttTopicBox.Text);
            }
        }
    }
}
