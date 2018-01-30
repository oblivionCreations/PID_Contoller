using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PID_Controller
{
    public static class PID
    {
       

        public static Double POutput(Double Kp, Double Error)
        {
            Double P;
            P = Kp * Error;
            return P;
        }
        public static Double IOutput(Double Ki, Double Integral, Double Error, double Dt)
        {
            Double I;
            I = Ki * (Integral + (Error * Dt));
            return I;
        }
        public static Double DOutput(Double Kd, Double Preerror, Double Error, double Dt)
        {

            Double D=0;
            if (Error < Preerror)
                D = Kd * ((Error - Preerror) / Dt);
            return D;
        }


    
    }
}
