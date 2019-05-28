using Hostel.Model;
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
    public partial class AdminDahboard : Form
    {
        HostelAppEntities db = new HostelAppEntities();
        public AdminDahboard()
        {
            InitializeComponent();
        }

        private void AdminDahboard_Load(object sender, EventArgs e)
        {
            FilldtgReservation();
        }
        private void FilldtgReservation()
        {
            dtgView.DataSource = db.Reservation.Select(a => new
            {
                a.Guests.Name,
                a.Guests.Surname,
                a.Guest_Phone,
                a.Beds.Beds_Number,
                a.Check_in,
                a.Check_out,
                a.Price
            }).ToList();
        }

        private void AddRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.ShowDialog();

        }
    }
}
