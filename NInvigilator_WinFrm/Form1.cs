using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NInvigilator_WinFrm
{
    public partial class Form1 : Form
    {
        const int n = 5;
        Time a;
        Time b;
        Time[] S = new Time[n];
        Time[] F = new Time[n];

        bool[] State;
        string[] Names = new string[n];
        int counter = 0;
        private int CountInvigilator(Time a, Time b, Time[] S, Time[] F, bool[] State)
        {
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if ((a <= S[i] && S[i] < b) || (a < F[i] && F[i] <= b))
                {
                    State[i] = true;
                    count++;
                }
            }
            return count;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (counter < n)
            {
                Names[counter] = txtName.Text;
                try { S[counter].Hour = int.Parse(txtFromHour.Text); } catch { }
                try { S[counter].Minute = int.Parse(txtFromMin.Text); } catch { }
                try { S[counter].Second = int.Parse(txtFromSecond.Text); } catch { }
                try { F[counter].Hour = int.Parse(txtToHour.Text); } catch { }
                try { F[counter].Minute = int.Parse(txtToMin.Text); } catch { }
                try { F[counter].Second = int.Parse(txtToSecond.Text); } catch { }
                counter++;
            }
            else if (counter >= n)
                MessageBox.Show("full space", "Full Space", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtName.Text = string.Empty;
            txtFromHour.Text = string.Empty;
            txtFromMin.Text = string.Empty;
            txtFromSecond.Text = string.Empty;
            txtToHour.Text = string.Empty;
            txtToMin.Text = string.Empty;
            txtToSecond.Text = string.Empty;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            grbGetData.Visible = true;
            grbShow.Visible = false;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            grbShow.Visible = true;
            grbGetData.Visible = false;
            Time.sort(S, F, Names);
            int co = CountInvigilator(a, b, S, F, State);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtNameShow.Text = Names[counter];
        }
    }
}