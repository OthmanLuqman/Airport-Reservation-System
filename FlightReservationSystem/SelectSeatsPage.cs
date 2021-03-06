﻿using System;
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
    public delegate void SeatSelectionCallBack(int seatNo);
    public partial class SelectSeatsPage : Form
    {
        public SelectSeatsPage(List<bool> seatsFlag,int seatCounts, int seatsPerRow)
        {
            this.seatsFlag = seatsFlag;
            InitializeComponent();
            InitialSeatGridView(seatsFlag, seatCounts, seatsPerRow);
        }

        private void InitialSeatGridView(List<bool> seatsFlag, int seatCounts, int seatsPerRow)
        {

            int columns = seatCounts / seatsPerRow;
            for (int i = 0; i < columns; i++)
            {
                DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
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

        public void SetSeatSelectionCallBack(SeatSelectionCallBack c)
        {
            seatSelectionCallBack = c;
        }


        private void OnCellDoubleClicked(Object sender, DataGridViewCellEventArgs e)
        {
            int seatIndex = int.Parse(SeatsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) -1;

            if (seatIndex >= seatsFlag.Count)
                return;

            if (seatsFlag[seatIndex] && seatSelectionCallBack != null )
            {
                seatSelectionCallBack(seatIndex + 1);
                this.Close();
            }
            
        }

        private void DisplaySeatsPage_Load(object sender, EventArgs e)
        {
            
        }
        private SeatSelectionCallBack seatSelectionCallBack = null;
        List<bool> seatsFlag;

    }
}
