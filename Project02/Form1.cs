using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project02
// Date: 01/30/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When executed program will close
            this.Close();

        }

        /// <summary>
        /// About Message Box Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When executed message box will appear with name, class/section, and assignment
            MessageBox.Show("Matthew Vaughan\nCS1400 Section 003\nProject #2");
        }

        /// <summary>
        /// Calculation Handler will submit users input and return pirates shares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Define some constants
            const int 
                JACK_PERCENT = 12,
                MATE_PERCENT = 8,
                ONE_HUNDRED = 100,
                CREWS_NIGHT = 3,
                JACK_MATE = 2;

            //Store users input of number of pirates and number of coins
            int 
                numPirates = int.Parse(txtNumPirates.Text),
                numCoins = int.Parse(txtNumCoins.Text);

            //Figure how many coins are left after the crew takes 3 coins each
            int newNumCoins = numCoins - (numPirates - JACK_MATE) * CREWS_NIGHT;

            //Calculates Jack's percentage cut out
            int jackShare = JACK_PERCENT * newNumCoins / ONE_HUNDRED;

            //Calculate the First Mate's percentage cut out
            int mateShare = MATE_PERCENT * (newNumCoins - jackShare) / ONE_HUNDRED;

            //Calculate Crew's Share
            int crewShare = (newNumCoins - (jackShare + mateShare)) / numPirates;

            //Calculate what left overs will be going toward the Pirates Benevolent Fund
            int sharePBF = (newNumCoins - (jackShare + mateShare)) % numPirates;

            //Add the Crew's Share to Jack's Share and Mate's Share
            jackShare = jackShare + crewShare;
            mateShare = mateShare + crewShare;

            //Output Jack's Share
            string outJackShare = ($"{jackShare:d}");
            txtJackShare.Text = outJackShare;

            //Output Mate's Share
            string outMateShare = ($"{mateShare:d}");
            txtMateShare.Text = outMateShare;

            //Output Crew's Share to the Crew's Text Box
            string outCrewShare = ($"{crewShare:d}");
            txtCrewShare.Text = outCrewShare;

            //Output the Pirates Benevolent Fund to their Text Box
            string outPBF = ($"{sharePBF:d}");
            txtPBF.Text = outPBF;

        }
    }
}
