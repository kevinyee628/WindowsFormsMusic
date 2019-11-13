using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class Music : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.SuspendLayout();
            // 
            // Music
            // 
            this.ClientSize = new System.Drawing.Size(478, 416);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Music";
            this.Text = "BoseMusic";
            this.ResumeLayout(false);

        }
    }
}
