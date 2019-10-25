/*
*   Ken Macneal 
*   10/22/19
*   Ticket Ap
*/ 


using System;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class frmMain : Form
    {
        public int speed, speedLimit;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Buttons
        private void btnInterface_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            errProvider.Clear();

            if (FormFilled())
            {
                if(speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnInterfaceFine();
                }
                else
                {
                    MessageBox.Show("Speed limit >= Speed","Ticket Error");
                    txtSpeed.Focus();
                }
            }
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            errProvider.Clear();

            if (FormFilled())
            {
                if (speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnDelegateFine();
                }
                else
                {
                    MessageBox.Show("Speed limit >= Speed", "Ticket Error");
                    txtSpeed.Focus();
                }
            }

        }

        private void btnLambdaCalc_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            errProvider.Clear();

            if (FormFilled())
            {
                if(speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnLambdaFine();
                }
                else
                {
                    MessageBox.Show("Speed limit >= Speed", "Ticket Error");
                    txtSpeed.Focus();
                }
            }
        }

        private void btnLambdaBool_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            errProvider.Clear();

            if (FormFilled())
            {
                if (speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnLamdaBoolFine();
                }
                else
                {
                    MessageBox.Show("Speed limit >= Speed", "Ticket Error");
                    txtSpeed.Focus();
                }
            }
        }

        private void btnIDValidate_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = string.Empty;
            errProvider.Clear();

            if (txtID.Text != string.Empty)
            {
                Officer Basillico = new Officer();
                Basillico.ID = txtID.Text;

                rtbOutput.Text = Basillico.validateID();
            }
            else
            {
                errProvider.SetError(txtID, "Id Required!");
                txtID.Focus();
            }
        }
        #endregion Form Buttons

        #region Form Methods
        public bool FormFilled()
        {
            bool validSpeedInput = (int.TryParse(txtSpeed.Text, out speed)) == true;
            bool validSpeedLimitInput = (int.TryParse(txtSpeedLimit.Text, out speedLimit)) == true;

            if (txtSpeed.Text == string.Empty || !validSpeedInput)
            {
                errProvider.SetError(txtSpeed, "Valid Input Needed!");
                txtSpeed.Focus();
                return false;
            }
            else
            {
                if(txtSpeedLimit.Text == string.Empty || !validSpeedLimitInput)
                {
                    errProvider.SetError(txtSpeedLimit, "Valid Input Needed!");
                    txtSpeedLimit.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        #endregion Form Methods
    }
}
