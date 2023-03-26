using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Unit_Conversion_App
{
    public partial class UnitConversionForm : Form
    {
        public UnitConversionForm()
        {
            InitializeComponent();
        }

        //Allow mouse down to move application using custom border
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void UnitConversionForm_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Application
            this.Close();
        }

        private void metroTabTime_Click(object sender, EventArgs e)
        {
        }

        private void btnTimeConvert_Click(object sender, EventArgs e)
        {
            string sSelectedUnitFrom;
            string sSelectedUnitTo;
            double dUnitFrom;
            double dUnitTo = 0;

            //Validate required input
            if (tbxTimeFrom.Text == "" || lbxTimeFrom.SelectedIndex <= -1 || lbxTimeTo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a conversion unit to convert from, convert to or type in a conversion unit in the textbox.");
                return;
            }

            double dInput;
            bool isDouble = Double.TryParse(tbxTimeFrom.Text, out dInput);
            if (!isDouble)
            {
                MessageBox.Show("Please insert a numeric value.");
                return;
            }

            //Set input to variables
            sSelectedUnitFrom = lbxTimeFrom.Items[lbxTimeFrom.SelectedIndex].ToString();
            sSelectedUnitTo = lbxTimeTo.Items[lbxTimeTo.SelectedIndex].ToString();
            dUnitFrom = Convert.ToDouble(tbxTimeFrom.Text);           

            //Call clsTime Class
            clsTime convertTime = new clsTime(sSelectedUnitTo, dUnitFrom);

            //Determine which method to call based on the selected conversion option
            switch (sSelectedUnitFrom)
            {
                case ("Second"):
                    dUnitTo = convertTime.ConvertFromSeconds();
                    break;
                case ("Minute"):
                    dUnitTo = convertTime.ConvertFromMinutes();
                    break;
                case ("Hour"):
                    dUnitTo = convertTime.ConvertFromHours();
                    break;
                case ("Day"):
                    dUnitTo = convertTime.ConvertFromDays();
                    break;
                case ("Week"):
                    dUnitTo = convertTime.ConvertFromWeeks();
                    break;
                default:
                    break;
            }

            //Print Output of the selected class method to Textbox
            tbxTimeTo.Text = Convert.ToString(Math.Round(dUnitTo, 10));
        }

        private void btnLenghtConvert_Click(object sender, EventArgs e)
        {
            string sSelectedUnitFrom;
            string sSelectedUnitTo;
            double dUnitFrom;
            double dUnitTo = 0;

            //Validate required input
            if (tbxLenghtFrom.Text == "" || lbxLenghtFrom.SelectedIndex <= -1 || lbxLenghtTo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a conversion unit to convert from, convert to or type in a conversion unit in the textbox.");
                return;
            }

            double dInput;
            bool isDouble = Double.TryParse(tbxLenghtFrom.Text, out dInput);
            if (!isDouble)
            {
                MessageBox.Show("Please insert a numeric value.");
                return;
            }

            //Set input to variables
            sSelectedUnitFrom = lbxLenghtFrom.Items[lbxLenghtFrom.SelectedIndex].ToString();
            sSelectedUnitTo = lbxLenghtTo.Items[lbxLenghtTo.SelectedIndex].ToString();
            dUnitFrom = Convert.ToDouble(tbxLenghtFrom.Text);

            //Call clsTime Class
            clsLenght convertLenght = new clsLenght(sSelectedUnitTo, dUnitFrom);

            //Determine which method to call based on the selected conversion option
            switch (sSelectedUnitFrom)
            {
                case ("Milimeter"):
                    dUnitTo = convertLenght.ConvertFromMilimeter();
                    break;
                case ("Centimeter"):
                    dUnitTo = convertLenght.ConvertFromCentimeter();
                    break;
                case ("Decimeter"):
                    dUnitTo = convertLenght.ConvertFromDecimeter();
                    break;
                case ("Meter"):
                    dUnitTo = convertLenght.ConvertFromMeter();
                    break;
                case ("Kilometer"):
                    dUnitTo = convertLenght.ConvertFromKilometer();
                    break;
                default:
                    break;
            }

            //Print Output of the selected class method to Textbox
            tbxLenghtTo.Text = Convert.ToString(Math.Round(dUnitTo, 10));
        }

        private void btnWeightConvert_Click(object sender, EventArgs e)
        {
            string sSelectedUnitFrom;
            string sSelectedUnitTo;
            double dUnitFrom;
            double dUnitTo = 0;

            //Validate required input
            if (tbxWeightFrom.Text == "" || lbxWeightFrom.SelectedIndex <= -1 || lbxWeightTo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a conversion unit to convert from, convert to or type in a conversion unit in the textbox.");
                return;
            }

            double dInput;
            bool isDouble = Double.TryParse(tbxWeightFrom.Text, out dInput);
            if (!isDouble)
            {
                MessageBox.Show("Please insert a numeric value.");
                return;
            }

            //Set input to variables
            sSelectedUnitFrom = lbxWeightFrom.Items[lbxWeightFrom.SelectedIndex].ToString();
            sSelectedUnitTo = lbxWeightTo.Items[lbxWeightTo.SelectedIndex].ToString();
            dUnitFrom = Convert.ToDouble(tbxWeightFrom.Text);

            //Call clsTime Class
            clsWeight convertWeight = new clsWeight(sSelectedUnitTo, dUnitFrom);

            //Determine which method to call based on the selected conversion option
            switch (sSelectedUnitFrom)
            {
                case ("Gram"):
                    dUnitTo = convertWeight.ConvertFromGram();
                    break;
                case ("Kilogram"):
                    dUnitTo = convertWeight.ConvertFromKilogram();
                    break;
                case ("Ton"):
                    dUnitTo = convertWeight.ConvertFromTon();
                    break;
                default:
                    break;
            }

            //Print Output of the selected class method to Textbox
            tbxWeightTo.Text = Convert.ToString(Math.Round(dUnitTo, 10));
        }

        private void btnLiquidConvert_Click(object sender, EventArgs e)
        {
            string sSelectedUnitFrom;
            string sSelectedUnitTo;
            double dUnitFrom;
            double dUnitTo = 0;

            //Validate required input
            if (tbxLiquidFrom.Text == "" || lbxLiquidFrom.SelectedIndex <= -1 || lbxLiquidTo.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a conversion unit to convert from, convert to or type in a conversion unit in the textbox.");
                return;
            }

            double dInput;
            bool isDouble = Double.TryParse(tbxLiquidFrom.Text, out dInput);
            if (!isDouble)
            {
                MessageBox.Show("Please insert a numeric value.");
                return;
            }

            //Set input to variables
            sSelectedUnitFrom = lbxLiquidFrom.Items[lbxLiquidFrom.SelectedIndex].ToString();
            sSelectedUnitTo = lbxLiquidTo.Items[lbxLiquidTo.SelectedIndex].ToString();
            dUnitFrom = Convert.ToDouble(tbxLiquidFrom.Text);

            //Call clsTime Class
            clsLiquid convertLiquid = new clsLiquid(sSelectedUnitTo, dUnitFrom);

            //Determine which method to call based on the selected conversion option
            switch (sSelectedUnitFrom)
            {
                case ("Cup"):
                    dUnitTo = convertLiquid.ConvertFromCup();
                    break;
                case ("Pint"):
                    dUnitTo = convertLiquid.ConvertFromPint();
                    break;
                case ("Quart"):
                    dUnitTo = convertLiquid.ConvertFromQuart(); 
                    break;
                case ("Gallon"):
                    dUnitTo = convertLiquid.ConvertFromGallon();
                    break;
                default:
                    break;
            }

            //Print Output of the selected class method to Textbox
            tbxLiquidTo.Text = Convert.ToString(Math.Round(dUnitTo, 10));
        }

        //Allow mouse down to move application using custom border 
        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
