using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eZ430ChronosNet;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace ez430_test 
{
    public partial class Form1 : Form
    {
        /*Variables:*/
        private Chronos ez = new Chronos();
        private string portName = "";
        private bool isConnected = false;                
        private int bufferSize = 47;
        private int shift = 64; //for drawing.      

        private bool matchFlag = false;
        RecognitionManager rmm = new RecognitionManager();

        LinkedList<UInt32> accelerData = new LinkedList<UInt32>();

        LinkedList<sbyte> rawXList = new LinkedList<sbyte>();
        LinkedList<sbyte> rawYList = new LinkedList<sbyte>();
        LinkedList<sbyte> rawZList = new LinkedList<sbyte>();

        LinkedList<double> recogXList = new LinkedList<double>();
        LinkedList<double> recogYList = new LinkedList<double>();
        LinkedList<double> recogZList = new LinkedList<double>();
        /*END*/



        public Form1()
        {   
            InitializeComponent();            
        }

        private void log(string message) {
            MessageLabel.Text = message;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            portName = ez.GetComPortName();
            if (portName == "") {
                log("Check your receiver and drivers. COM port device is not found");
                return;
            }
            
            if (isConnected)
            {
                ez.CloseComPort();
                log("AP Disconnected");
                isConnected = false;
                connectButton.Text = "Connect";
            }
            else if (ez.OpenComPort(portName))
            {
                
                if (!ez.StartSimpliciTI()) log("Error while StartSimpliciTI");


                /*
                 * In C++ library it is said:
                 * After power-up, the hardware is not automatically reset. 
                 * Use the following function to initialize the RF AP.
                 * ...
                 * 
                 * Returns true if RF AP COULD be initialized succesfully.
                 * 
                 * However in ez430_chronos_net library sources:
                 * ResetAP() return true :
                 * 
                 *      APStatus BM_errorstate = (APStatus)response.Data[Constants.PACKET_BYTE_CMD];
                 *      if (BM_errorstate != APStatus.HW_NO_ERROR) return false;
                 *      return true;
                 * 
                 */

                /*
                if (!ez.ResetAP())
                {
                    log("Error while starting AP");
                    if (ez.PortOpen) ez.CloseComPort();
                    isConnected = false;
                    return;
                }
                */

                rmm.load("C:\\temp");
                Thread.Sleep(1000); //Pause to initialize AP.                                

                connectButton.Text = "Disconnect";
                log("AP Connected");
                isConnected = true;                
            }
            else 
            {
                log("AP is not responding");
            }            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UInt32 data;
            sbyte rawX = 0;
            sbyte rawY = 0;
            sbyte rawZ = 0;

            /*
             * This check should be replaced by more adequate =)
             */
            if (!ez.PortOpen) return;

            //Obtain data from watches
            ez.GetData(out data);

            //Parse data
            rawX = (sbyte)((data >> 8) & (UInt32)255);
            rawY = (sbyte)((data >> 16) & (UInt32)255);
            rawZ = (sbyte)((data >> 24) & (UInt32)255);

            //Sets acceleration values on form
            AccX.Text = rawX.ToString();
            AccY.Text = rawY.ToString();
            AccZ.Text = rawZ.ToString();
            
            //Filling accelerData list            
            if (accelerData.Count >= bufferSize) accelerData.RemoveFirst();
            accelerData.AddLast(data);
            
            //Filling raw lists
            if (rawXList.Count >= bufferSize) rawXList.RemoveFirst();
            rawXList.AddLast(rawX);

            if (rawYList.Count >= bufferSize) rawYList.RemoveFirst();
            rawYList.AddLast(rawY);

            if (rawZList.Count >= bufferSize) rawZList.RemoveFirst();
            rawZList.AddLast(rawZ);                

            //Filling recognition lists
            if (recogXList.Count >= bufferSize) recogXList.RemoveFirst();
            recogXList.AddLast(rmm.compare(rawXList, "source44x.xml"));

            if (recogYList.Count >= bufferSize) recogYList.RemoveFirst();
            recogYList.AddLast(rmm.compare(rawYList, "source44y.xml"));

            if (recogZList.Count >= bufferSize) recogZList.RemoveFirst();
            recogZList.AddLast(rmm.compare(rawZList, "source44z.xml"));

            //draw everything we have done
            drawBuffer();
        }

        private void drawBuffer() {
            /*
             * Drawing to bitmap removing flashing
             */

            Bitmap bitmapX = new Bitmap(pictureBoxX.Width, pictureBoxX.Height);
            Graphics g_dataX = Graphics.FromImage(bitmapX);

            Bitmap bitmapY = new Bitmap(pictureBoxY.Width, pictureBoxY.Height);
            Graphics g_dataY = Graphics.FromImage(bitmapY);

            Bitmap bitmapZ = new Bitmap(pictureBoxZ.Width, pictureBoxZ.Height);
            Graphics g_dataZ = Graphics.FromImage(bitmapZ);

            Bitmap recognitionProcess = new Bitmap(pictureBox_recognitionProcess.Width, pictureBox_recognitionProcess.Height);
            Graphics g_recognition = Graphics.FromImage(recognitionProcess);
      
            Pen p = new Pen(Color.Red);
            Pen p1 = new Pen(Color.Green);
            Pen p2 = new Pen(Color.Blue);                        
            
            g_recognition.Clear(Color.White);            

            try {
                //exp
                if (0 != rawXList.Count)
                {
                    //exactly from 1!
                    for (int i = 1; i < rawXList.Count; i++) {
                        g_dataX.DrawLine(p, i, shift + rawXList.ElementAt(i - 1), i + 1, shift + rawXList.ElementAt(i));
                        g_dataY.DrawLine(p1, i, shift + rawYList.ElementAt(i - 1), i + 1, shift + rawYList.ElementAt(i));
                        g_dataZ.DrawLine(p2, i, shift + rawZList.ElementAt(i - 1), i + 1, shift + rawZList.ElementAt(i));
                        
                        g_recognition.DrawLine(p, i,  (int)recogXList.ElementAt(i - 1), i + 1,  (int)recogXList.ElementAt(i));
                        g_recognition.DrawLine(p1, i,  (int)recogYList.ElementAt(i - 1), i + 1,  (int)recogYList.ElementAt(i));
                        g_recognition.DrawLine(p2, i,  (int)recogZList.ElementAt(i - 1), i + 1,  (int)recogZList.ElementAt(i));
                         
                        pictureBoxX.Image = bitmapX;
                        pictureBoxY.Image = bitmapY;
                        pictureBoxZ.Image = bitmapZ;

                        pictureBox_recognitionProcess.Image = recognitionProcess;
                    }
                }

                pictureBoxX.Refresh();
                pictureBoxY.Refresh();
                pictureBoxZ.Refresh();
                pictureBox_recognitionProcess.Refresh();

                if (matchFlag) {
                    /*
                     * Need to be reviewed
                    g_last.DrawCurve(p, bufX);
                    g_last.DrawCurve(p1, bufY);
                    g_last.DrawCurve(p2, bufZ);
                     */
                    matchFlag = false;
                }
            }
            catch (ArgumentException e) { 
                //What an F***?
                //It is evil. Inf - 100%.
            }            

        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            /*
            FileWorks fw = new FileWorks("C:\\tmp", ".txt");            
            fw.saveList(bufferListX);
             */       

            
            XmlSerializer s = new XmlSerializer(typeof(List<sbyte>));

            StreamWriter xtw = new StreamWriter("C:\\temp\\44x.xml");
            StreamWriter ytw = new StreamWriter("C:\\temp\\44y.xml");
            StreamWriter ztw = new StreamWriter("C:\\temp\\44z.xml");

            List<sbyte> rx = new List<sbyte>(rawXList);
            List<sbyte> ry = new List<sbyte>(rawYList);
            List<sbyte> rz = new List<sbyte>(rawZList);

            s.Serialize(xtw, rx);
            s.Serialize(ytw, ry);
            s.Serialize(ztw, rz);
            

            xtw.Close();
            ytw.Close();
            ztw.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Stop();
            else timer1.Start();
        }

        private void pictureBoxX_MouseMove(object sender, MouseEventArgs e)
        {
            label_value.Text = (e.Y - shift).ToString();
            label_count.Text = e.X.ToString();
        }

        

    }
}
