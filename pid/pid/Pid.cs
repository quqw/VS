using System;
using System.Collections.Generic;
using System.Text;

namespace Pid
{
    public class PID
    {
        public const int AUTOMATIC = 1;
        public const int MANUAL = 0;
        public const int DIRECT = 0;
        public const int REVERSE = 1;
        double time_ticks;
        double dispKp;              // * we'll hold on to the tuning parameters in user-entered 
        double dispKi;              //   format for display purposes
        double dispKd;              //
        double kp;                  // * (P)roportional Tuning Parameter
        double ki;                  // * (I)ntegral Tuning Parameter
        double kd;                  // * (D)erivative Tuning Parameter
        int controllerDirection;
        double myInput;              // * Pointers to the Input, Output, and Setpoint variables
        double myOutput;             //   This creates a hard link between the variables and the 
        double myTargetPoint;           //   PID, freeing the user from having to constantly tell us
                                      //   what these values are.  with pointers we'll just know.

        ulong lastTime;
        double ITerm, lastInput;

        ulong SampleTime;
        double outMin, outMax;
        bool inAuto;

        //public double Input
        //{
        //    get { return myInput; }
        //    set { myInput = value; }
        //}
        public double Output
        {
            get { return myOutput; }
        }
        public double Setpoint
        {
            get { return myTargetPoint; }
            set { myTargetPoint = value; }
        }

        public PID(double initInput, double targetPoint,
        double Kp, double Ki, double Kd, int ControllerDirection)
        {
            SetOutputLimits(0, 255);               //default output limit corresponds to 
                                                        //the arduino pwm limits
            SampleTime = 100;                           //default Controller Sample Time is 0.1 seconds

            SetControllerDirection(ControllerDirection);
            SetTunings(Kp, Ki, Kd);
            inAuto = false;
            myInput = initInput;
            myTargetPoint = targetPoint;
            time_ticks = 0;
        }

 /* Compute() **********************************************************************
 *     This, as they say, is where the magic happens.  this function should be called
 *   every time "void loop()" executes.  the function will decide for itself whether a new
 *   pid Output needs to be computed
 **********************************************************************************/
        public double Compute(double currentInput,ulong ticks)
        {
            time_ticks += ticks;
            if (!inAuto) return myOutput;
            if (time_ticks >= SampleTime)
            {
                time_ticks = 0;
                /*Compute all the working error variables*/
                double input = myInput;
                double error = myTargetPoint - input;
                ITerm += (ki * error);
                if (ITerm > outMax) ITerm = outMax;
                else if (ITerm < outMin) ITerm = outMin;
                double dInput = (input - lastInput);

                /*Compute PID Output*/
                double output = kp * error + ITerm - kd * dInput;

                if (output > outMax) output = outMax;
                else if (output < outMin) output = outMin;
                myOutput = output;

                /*Remember some variables for next time*/
                lastInput = input;
            }
            return myOutput;
        }


        /* SetTunings(...)*************************************************************
         * This function allows the controller's dynamic performance to be adjusted. 
         * it's called automatically from the constructor, but tunings can also
         * be adjusted on the fly during normal operation
         ******************************************************************************/
        void SetTunings(double Kp, double Ki, double Kd)
        {
            if (Kp < 0 || Ki < 0 || Kd < 0) return;

            dispKp = Kp; dispKi = Ki; dispKd = Kd;

            double SampleTimeInSec = ((double)SampleTime) / 1000;
            kp = Kp;
            ki = Ki * SampleTimeInSec;
            kd = Kd / SampleTimeInSec;

            if (controllerDirection == REVERSE)
            {
                kp = (0 - kp);
                ki = (0 - ki);
                kd = (0 - kd);
            }
        }

        /* SetSampleTime(...) *********************************************************
         * sets the period, in Milliseconds, at which the calculation is performed	
         ******************************************************************************/
        void SetSampleTime(int NewSampleTime)
        {
            if (NewSampleTime > 0)
            {
                double ratio = (double)NewSampleTime
                                / (double)SampleTime;
                ki *= ratio;
                kd /= ratio;
                SampleTime = (ulong)NewSampleTime;
            }
        }

        /* SetOutputLimits(...)****************************************************
         *     This function will be used far more often than SetInputLimits.  while
         *  the input to the controller will generally be in the 0-1023 range (which is
         *  the default already,)  the output will be a little different.  maybe they'll
         *  be doing a time window and will need 0-8000 or something.  or maybe they'll
         *  want to clamp it from 0-125.  who knows.  at any rate, that can all be done
         *  here.
         **************************************************************************/
        void SetOutputLimits(double Min, double Max)
        {
            if (Min >= Max) return;
            outMin = Min;
            outMax = Max;

            if (inAuto)
            {
                if (myOutput > outMax) myOutput = outMax;
                else if (myOutput < outMin) myOutput = outMin;

                if (ITerm > outMax) ITerm = outMax;
                else if (ITerm < outMin) ITerm = outMin;
            }
        }

        /* SetMode(...)****************************************************************
         * Allows the controller Mode to be set to manual (0) or Automatic (non-zero)
         * when the transition from manual to auto occurs, the controller is
         * automatically initialized
         ******************************************************************************/
        public void SetMode(int Mode)
        {
            bool newAuto = (Mode == AUTOMATIC);
            if (newAuto == !inAuto)
            {  /*we just went from manual to auto*/
                Initialize();
            }
            inAuto = newAuto;
        }

        /* Initialize()****************************************************************
         *	does all the things that need to happen to ensure a bumpless transfer
         *  from manual to automatic mode.
         ******************************************************************************/
        void Initialize()
        {
            ITerm = myOutput;
            lastInput = myInput;
            if (ITerm > outMax) ITerm = outMax;
            else if (ITerm < outMin) ITerm = outMin;
        }

        /* SetControllerDirection(...)*************************************************
         * The PID will either be connected to a DIRECT acting process (+Output leads 
         * to +Input) or a REVERSE acting process(+Output leads to -Input.)  we need to
         * know which one, because otherwise we may increase the output when we should
         * be decreasing.  This is called from the constructor.
         ******************************************************************************/
        void SetControllerDirection(int Direction)
        {
            if (inAuto && Direction != controllerDirection)
            {
                kp = (0 - kp);
                ki = (0 - ki);
                kd = (0 - kd);
            }
            controllerDirection = Direction;
        }

        /* Status Funcions*************************************************************
         * Just because you set the Kp=-1 doesn't mean it actually happened.  these
         * functions query the internal state of the PID.  they're here for display 
         * purposes.  this are the functions the PID Front-end uses for example
         ******************************************************************************/
        public double Kp
        {
            get { return dispKp; }
        }
        public double Ki { get { return dispKi; } }
        public double Kd {  get   { return dispKd;  } }
        public int Mode { get { return inAuto ? AUTOMATIC : MANUAL; } }
        public int Direction { get { return controllerDirection; } }

    }
}
