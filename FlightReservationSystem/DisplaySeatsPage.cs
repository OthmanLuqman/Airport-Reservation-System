using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{

    public partial class DisplaySeatsPage : Form
    {
        public DisplaySeatsPage(List<bool> seatsFlag,int seatCounts, int seatsPerRow)
        {
            InitializeComponent();
            InitialSeatGridView(seatsFlag, seatCounts, seatsPerRow);
        }

        private void InitialSeatGridView(List<bool> seatsFlag, int seatCounts, int seatsPerRow)
        {

            int columns = seatCounts / seatsPerRow;
            for (int i = 0; i < columns; i++)
            {
                DataGridViewButtonColumn c = new DataGridViewButtonColumn();
                c.HeaderText = i.ToString();
                SeatsGridView.Columns.Add(c);

            }

            for (int i = 0; i < seatsPerRow; i++)
            {
                SeatsGridView.Rows.Add();
                for(int j = 0 ; j< columns ; j++)
                {
                    int seatNo = i + (j * seatsPerRow )+ 1;
                    SeatsGridView.Rows[i].Cells[j].Value = seatNo;

                    
                    if(seatsFlag[seatNo-1])
                    {
                        SeatsGridView.Rows[i].Cells[j].Style.BackColor = Color.Lime;
                    }
                    else
                    {
                        SeatsGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }

                }
            }
        }
            

        private void DisplaySeatsPage_Load(object sender, EventArgs e)
        {
            
        }

    }
}
