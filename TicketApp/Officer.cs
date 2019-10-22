using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class Officer
    {
        double detectedSpeed;
        double enforcedSpeed;
        string IDTaken;
        const double FEETHRESHOLD = 200;
        const double FEE_PER_MPH = 20;

        public string ID
        { set { IDTaken = value; } }

        public Officer()
        {

        }

        public Officer(double speedDetected, double speedEnforced)
        {
            enforcedSpeed = speedEnforced;
            detectedSpeed = speedDetected;

        }

        #region delegates
        delegate double fineCalc(double detectableSpeed, double enforceableSpeed);
        delegate bool OverTwoHundrd(double fine);

        #endregion delegates

        #region Class Methods

        private double CalculateFine()
        {
            return (detectedSpeed - enforcedSpeed) * FEE_PER_MPH;
        }

        private double CalculateFine(double speedLimit, double speedDriven)
        {
            return (speedLimit - speedDriven) * FEE_PER_MPH;
        }

        public string ReturnInterfaceFine()
        {
            double fineTotal = CalculateFine();

            return $"Fine using interface: {fineTotal:C}";
        }


        public string ReturnDelegateFine()
        {
            fineCalc result = CalculateFine;

            return $"Fine is delegate {result(detectedSpeed, enforcedSpeed):C}";
        }

        public string ReturnLambdaFine()
        {
            fineCalc fineCalc = (double seenSpeed, double speedLaw) => (seenSpeed - speedLaw) * FEE_PER_MPH;

            return $"Fine is Lambda {fineCalc(detectedSpeed, enforcedSpeed):C}";
        }

        public string ReturnLamdaBoolFine()
        {
            string output = string.Empty;
            double fine = CalculateFine();
            OverTwoHundrd fineThreshhold = ans => ans > 200;

            output = $"Fine is {fine:C}\n";
            output += $"Fine over threshold:";
            output += fineThreshhold(fine) ? $"{fine - 200:C}\n" : $"{0:C}\n";
            output += $"Over $200:{fineThreshhold(fine)}";

            return output;
        }
        
        public string validateID()
        {
            bool idValid = IDTaken.Substring(2, 2) == "55" && IDTaken.Length == 5;

            return idValid ? "Valid ID" : "Invalid ID";
        }

        #endregion Class Methods
    }
}
