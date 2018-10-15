using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class Generator: Form
    {
        string expectedOrArrived;
        string etaDate;
        string etaTime;
        string etbDate;
        string etbTime;
        string port;
        bool noEta;
        bool noEtb;
        bool isArrived;
        bool isRemains;

        List<ComboBox> productSelection = new List<ComboBox>();
        List<int> errors = new List<int>();

        //Initialize components and variables on start-up
        public Generator()
        {
            InitializeComponent();

            // Version text
            double version = 0.3;
            lblVersion.Text = "AmSpec LPG Dispatch tool v. " + version;

            //initialize ETA text
            expectedOrArrived = "vessel is expected to arrive at ";

            // Create tab control event handler
            tabControl.Selecting += new TabControlCancelEventHandler(tabControl_Selecting);

            // Create new DateTime key handlers
            etaDateTime.KeyDown += new KeyEventHandler(etaDateTime_KeyDown);
            etbDateTime.KeyDown += new KeyEventHandler(etbDateTime_KeyDown);
        }

        #region EventHandlers

        // Handle what happens when tab is changed
        void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
        }

        // Remove key input from DateTime selectors on daily updates
        private void etaDateTime_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void etbDateTime_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        // Time box event handlers for time-only formatted entry
        private void tbEtaTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForTimeKeyPress(e);
        }

        private void tbEtbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForTimeKeyPress(e);
        }

        private void tbTimeString_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForTimeKeyPress(e);
        }

        //Arrival selector control
        private void etaSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (etaSelector.Text == "Arrived")
            {
                isArrived = true;
                isRemains = false;
                expectedOrArrived = "vessel arrived at ";
            }
            else if (etaSelector.Text == "Remains")
            {
                isArrived = false;
                isRemains = true;
                expectedOrArrived = "vessel remains at ";
                etaDate = ".";
                etaTime = null;
            }
            else if (etaSelector.Text == "ETA")
            {
                isArrived = false;
                isRemains = false;
                expectedOrArrived = "vessel is expected to arrive at ";
            }
        }

        //No ETB checkbox
        private void chkNoEtb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoEtb.Checked)
            {
                etbDateTime.Enabled = false;
                tbEtbTime.Enabled = false;
                cbBerthingArrival.Enabled = false;
                noEtb = true;
            } else
            {
                etbDateTime.Enabled = true;
                tbEtbTime.Enabled = true;
                cbBerthingArrival.Enabled = true;
                noEtb = false;
            }
        }

        //No ETA checkbox
        private void chkNoEta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoEta.Checked)
            {
                etaDateTime.Enabled = false;
                etbDateTime.Enabled = false;
                tbEtaTime.Enabled = false;
                tbEtbTime.Enabled = false;
                chkNoEtb.Enabled = false;
                portSelector.Enabled = false;
                noEta = true;
            } else
            {
                etaDateTime.Enabled = true;
                etbDateTime.Enabled = true;
                tbEtaTime.Enabled = true;
                tbEtbTime.Enabled = true;
                chkNoEtb.Enabled = true;
                portSelector.Enabled = true;
                noEta = false;
            }
        }

        //Berthing on arrival checkbox
        private void cbBerthingArrival_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBerthingArrival.Checked)
            {
                etbDateTime.Enabled = false;
                tbEtbTime.Enabled = false;
            } else
            {
                etbDateTime.Enabled = true;
                tbEtbTime.Enabled = true;
            }
        }

        //Control ETC product text - 1st grade
        private void ddProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFirstGrade.Text = ddProduct1.Text;
        }

        private void ddProduct2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSecondGrade.Text = ddProduct2.Text;

            if (ddProduct2.Text != "" && ddProduct2.Text != "None")
            {
                panelSecondGrade.Enabled = true;
            } else
            {
                panelSecondGrade.Enabled = false;
            }
        }

        // Reset data button on daily update tab
        private void btnResetData_Click(object sender, EventArgs e)
        {
            foreach (DateTimePicker dtp in dailyUpdatePanel.Controls.OfType<DateTimePicker>())
            {
                dtp.Value = DateTime.Now;
            }

            foreach (ComboBox cb in dailyUpdatePanel.Controls.OfType<ComboBox>())
            {
                cb.Text = "";
            }

            foreach (TextBox tb in dailyUpdatePanel.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }

            foreach (CheckBox chkb in dailyUpdatePanel.Controls.OfType<CheckBox>())
            {
                chkb.Checked = false;
            }

            richTextEta.Text = "";
        }

        // Copy textbox to clipboard
        private void btnCopyEta_Click(object sender, EventArgs e)
        {
            richTextEta.SelectAll();
            richTextEta.Copy();
        }

        private void btnCopyEtc_Click(object sender, EventArgs e)
        {
            richTextEtc.SelectAll();
            richTextEtc.Copy();
        }

        #endregion

        #region ControlMethods All created methods that are called by event handlers
        //-----------Begin Methods--------------

        private static void CheckForTimeKeyPress(KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
        }

        // This is the method that generates the update text
        public void updateText()
        {
            if (noEta)
            {
                richTextEta.Text = DateTime.Today.ToLongDateString() + "\nPlease be advised, we have reached out to the vessel's agent to request ETA and berthing prospects. However, vessel's agent has not yet received this information from the vessel.\nWe will keep you updated as furhter information becomes available.";
            } else
            {
                richTextEta.Text = DateTime.Today.ToLongDateString() +
                    "\nAs per vessel's agent, " + expectedOrArrived
                    + port + etaDate + etaTime + etbDate + etbTime +
                    "\nWe will keep you updated as further information becomes available.";
            }
        }

        //port selector
        private void portTextHandler()
        {
            if (portSelector.SelectedItem.ToString() == "Galveston")
            {
                port = "Galveston, TX anchorage";
            } else if (portSelector.SelectedItem.ToString() == "Freeport")
            {
                port = "Freeport, TX anchorage";
            }
        }

        //Check port menu for selection
        private bool checkPort()
        {
            if (portSelector.SelectedItem != null)
            {
                return true;
            } else
            {
                MessageBox.Show("You must select a port!", "Oops!");
                return false;
            }
        }

        //etaDate
        private void etaDateTextHandler()
        {
            if (isRemains)
            {
                etaDate = "";
            } else
            {
                etaDate = " on " + etaDateTime.Value.ToLongDateString();
            }
        }

        //etaTime
        private void etaTimeTextHandler()
        {
            if (tbEtaTime.Text == "")
            {
                etaTime = "";
            } else
            {
                if (isArrived)
                {
                    etaTime = " at " + HelperMethods.ConvertTimeString(tbEtaTime.Text);
                } else if (isRemains)
                {
                    etaTime = "";
                } else 
                {
                    etaTime = " at approximately " + HelperMethods.ConvertTimeString(tbEtaTime.Text);
                } 
            }
        }

        private bool checkEtaTime()
        {
            if (isArrived == true)
            {
                if (tbEtaTime.Text == "")
                {
                    MessageBox.Show("You have selected vessel arrived without indicating a time!", "Oops!");
                    return false;
                } else
                {
                    return true;
                }
            } else
            {
                return true;
            }
        }

        //etbDate
        private void etbDateTextHandler()
        {
            if (noEtb)
            {
                etbDate = ". Vessel has no firm berthing prospects at this time.";
            } else if (cbBerthingArrival.Checked)
            {
                etbDate = " and is anticipated to berth on arrival";
            } else
            {
                etbDate = " and is anticipated to berth on " + etbDateTime.Value.ToLongDateString();
            }
        }

        //etbTime
        private void etbTimeTextHandler()
        {
            if (!noEtb)
            {

                if (tbEtbTime.Text == "")
                {
                    etbTime = ".";
                } else
                {
                    if (cbBerthingArrival.Checked)
                    {
                        etbTime = ".";
                    } else
                    {
                        etbTime = " at approximately " + HelperMethods.ConvertTimeString(tbEtbTime.Text) + ".";
                    }  
                }
            }  
            else
            {
                etbTime = "";
            }
        }

        //Generate ETA Update button (check for blanks or missing data)
        private void btnGenerateEta_Click(object sender, EventArgs e)
        {
            GenerateDaily();
        }

        private void btnGenerateEtc_Click(object sender, EventArgs e)
        {
            generateEtc();
        }

        private void GenerateDaily()
        {
            int dataChecked = 0;
            int numberOfChecks = 2;

            // Check for errors on daily update
            if (checkPort() == true && checkEtaTime() == true)
            {
                dataChecked++;
            }

            // If no ETB is not checked, make sure ETA and ETB dates make sense (ETB cannot be before ETA)
            if (!noEtb)
            {
                if (etbDateTime.Value.Date < etaDateTime.Value.Date)
                {
                    MessageBox.Show("Berthing date is before arrival!", "Error!");
                } else
                {
                    dataChecked++;
                }
            } else
            {
                dataChecked++;
            }

            //Generate daily update
            if (dataChecked >= numberOfChecks)
            {
                portTextHandler();
                etaDateTextHandler();
                etaTimeTextHandler();
                etbDateTextHandler();
                etbTimeTextHandler();
                updateText();
                Console.WriteLine("Data Check: " + dataChecked);
            }
        }

        private void generateEtc()
        {
            //Make sure the product selection list is clear, then populate it with the appropriate combobox's
            productSelection.Clear();
            productSelection.Add(ddProduct1);
            productSelection.Add(ddProduct2);

            //Set number of products to 0, this will be incremented upon
            int numProducts = 0;

            //check each product combobox for product text, if it is not blank or set to none, increment the value of numProducts
            foreach (ComboBox product in productSelection)
            {
                if (product.Text != "" && product.Text != "None")
                {
                    numProducts++;
                }

            }

            //Check for integer only values in the intended load, total loaded and rate sections
            int intendedLoad, totalLoaded, rate, intendedLoad2, totalLoaded2, rate2;

            if (numProducts > 1)
            {
                GetEtcData(tbIntendedLoad1, tbTotalLoaded1, tbRateOfLoading1, out intendedLoad, out totalLoaded, out rate);
                GetEtcData(tbIntendedLoad2, tbTotalLoaded2, tbRateOfLoading2, out intendedLoad2, out totalLoaded2, out rate2);  
            } else
            {
                GetEtcData(tbIntendedLoad1, tbTotalLoaded1, tbRateOfLoading1, out intendedLoad, out totalLoaded, out rate);

                //Set 2nd product variables to 0
                intendedLoad2 = 0;
                totalLoaded2 = 0;
                rate2 = 0;
            }

            //Check to make sure at least the first product is selected
            if (productSelection[0].Text == "" || productSelection[0].Text == "None")
            {
                errors.Add(004);
            }

            //Calculate all the data, man
            float productRemaining = intendedLoad - totalLoaded;
            float hoursLeft = productRemaining / rate;
            double roundedHoursLeft = Math.Round(hoursLeft);

            //For debugging purposes
            Console.WriteLine("Product remaining: " + productRemaining);
            Console.WriteLine("Hours left: " + hoursLeft);
            Console.WriteLine("Hours left (rounded): " + Math.Round(hoursLeft));
            Console.WriteLine("Number of products: " + numProducts);

            //Error codes: 001/002/003 = Intended load/Total loaded/Rate is not a numeric value
            //004 = Product is not selected
            if (errors.Count > 0)
            {
                ShowAllErrors();
                errors.Clear();
            } else
            {
                //Create a new update with the calculated data
                if (numProducts > 1)
                {
                    float productRemaining2 = intendedLoad2 - totalLoaded2;
                    float hoursLeft2 = productRemaining2 / rate2;
                    double roundedHoursLeft2 = Math.Round(hoursLeft2);

                    Console.WriteLine("Product remaining 2: " + productRemaining2);
                    Console.WriteLine("Hours left 2: " + hoursLeft2);
                    Console.WriteLine("Hours left (rounded) 2: " + Math.Round(hoursLeft2));

                    GeneratedMultiEtcUpdate generatedMultiEtcUpdate = new GeneratedMultiEtcUpdate();
                    generatedMultiEtcUpdate.timeOfUpdateString = HelperMethods.ConvertTimeString(tbTimeString.Text);
                    generatedMultiEtcUpdate.selectedUnit = (rdBarrels.Checked) ? "barrels" : "MT";
                    generatedMultiEtcUpdate.timeOfUpdate = DateTime.Parse(generatedMultiEtcUpdate.timeOfUpdateString);
                    richTextEtc.Text = generatedMultiEtcUpdate.GetText(totalLoaded, rate, roundedHoursLeft, productSelection[0].Text, totalLoaded2, rate2, roundedHoursLeft2, productSelection[1].Text);
                } else
                {
                    GeneratedEtcUpdate generatedEtcUpdate = new GeneratedEtcUpdate();
                    generatedEtcUpdate.timeOfUpdateString = HelperMethods.ConvertTimeString(tbTimeString.Text);
                    generatedEtcUpdate.selectedUnit = (rdBarrels.Checked) ? "barrels" : "MT";
                    generatedEtcUpdate.timeOfUpdate = DateTime.Parse(generatedEtcUpdate.timeOfUpdateString);
                    richTextEtc.Text = generatedEtcUpdate.GetText(totalLoaded, rate, roundedHoursLeft, productSelection[0].Text);
                }   
            }
        }

        private void GetEtcData(TextBox tbIntendedLoad, TextBox tbTotalLoaded, TextBox tbRateOfLoading, out int intendedLoad, out int totalLoaded, out int rate)
        {
            if (!Int32.TryParse(tbIntendedLoad.Text, out intendedLoad))
            {
                errors.Add(001);
            }

            if (!Int32.TryParse(tbTotalLoaded.Text, out totalLoaded))
            {
                errors.Add(002);
            }

            if (!Int32.TryParse(tbRateOfLoading.Text, out rate))
            {
                errors.Add(003);
            }
        }

        private void ShowAllErrors()
        {
            List<string> showErrors = new List<string>();

            foreach (int errorCode in errors)
            {
                switch (errorCode)
                {
                    case 001:
                        showErrors.Add("001: Intended load is not a number");
                        break;
                    case 002:
                        showErrors.Add("002: Total loaded is not a number");
                        break;
                    case 003:
                        showErrors.Add("003: Rate is not a number");
                        break;
                    case 004:
                        showErrors.Add("004: A product must be selected in the first box");
                        break;
                }
            }

            string returnString = "";

            for (int i = 0; i < errors.Count; i++)
            {
                returnString += showErrors[i] + "\n";
            }

            MessageBox.Show(returnString);
        }

        #endregion
    }
}
