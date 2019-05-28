using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string RoomName = txtRoomName.Text;
            string RoomNum = txtRoomNum.Text;
            //bool allempty = Extentions.isnotEmpty(new string[] {

            //})
        }
    }
}
