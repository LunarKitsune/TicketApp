/*
*   Ken Macneal 
*   10/22/19
*   Ticket Ap
*/ 


using System;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        public double speed, speedLimit;
        public delegate string officerRequest();

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Buttons
        private void btnInterface_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (FormFilled() && validNumerics())
            {
                if(speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnInterfaceFine();
                }
                else
                {
                    MessageBox.Show("Speed limit greater than/equal to speed","Ticket Error");
                }
            }
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (FormFilled() && validNumerics())
            {
                if (speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnDelegateFine();
                }
                else
                {
                    MessageBox.Show("Speed limit greater than/equal to speed", "Ticket Error");
                }
            }

        }

        private void btnLambdaCalc_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (FormFilled() && validNumerics())
            {
                if(speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnLambdaFine();
                }
                else
                {
                    MessageBox.Show("Speed limit greater than/equal to speed", "Ticket Error");
                }
            }
        }

        private void btnLambdaBool_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (FormFilled() && validNumerics())
            {
                if (speed > speedLimit)
                {
                    Officer Basillico = new Officer(speed, speedLimit);
                    rtbOutput.Text = Basillico.ReturnLamdaBoolFine();
                }
                else
                {
                    MessageBox.Show("Speed limit greater than/equal to speed", "Ticket Error");
                }
            }
        }

        private void btnIDValidate_Click(object sender, EventArgs e)
        {
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
            }
        }
        #endregion Form Buttons

        #region General Form Events

        #endregion General Form Events

        #region Form Methods
        public bool FormFilled()
        {
            if(txtSpeed.Text == string.Empty)
            {
                errProvider.SetError(txtSpeed, "Input Needed!");
                txtSpeed.Focus();
                return false;
            }
            else
            {
                if(txtSpeedLimit.Text == string.Empty)
                {
                    errProvider.SetError(txtSpeedLimit, "Input Needed!");
                    txtSpeedLimit.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        public bool validNumerics()
        {
            bool validatedNumerics = ((double.TryParse(txtSpeed.Text, out speed)) == true && (double.TryParse(txtSpeedLimit.Text, out speedLimit)) == true);
            
            return validatedNumerics;
        }

        #endregion Form Methods
    }
}
