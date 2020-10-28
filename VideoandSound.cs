using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoandSound
{
    public partial class VideoandSound : Form
    {
        public VideoandSound()
        {
            InitializeComponent();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("VideoandSound.spin image 1.jpg");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;


        }
    }
}
