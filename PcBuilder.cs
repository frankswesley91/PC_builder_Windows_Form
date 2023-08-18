using System.ComponentModel;

namespace FinalProject
{
    public partial class Form1 : Form
    {

        //===============Variable Declaration=================//


        const double FAN_PRICE = 30;
        double graphicsCardPrice = 0;
        double numRamSticks;
        double ramPrice = 0;
        double ramSize;
        double fps;
        string cpu;
        string email;
        double cPUPrice = 0;
        double numFans;
        double fanPrice = 0;
        bool isliquidCooling = false;
        double storage;
        double storageSizePrice = 0;
        double budget;
        string name;
        double liquidCoolingPrice = 0;
        double totalPrice = 0;
        double casePrice = 0;
        string purposeGameResponse;
        string purposeWorkResponse;
        string purposeHomeResponse;
        string caseDesign;
        string caseSize;
        string recommendedFps;
        string s = "";
        double leftOver;



        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            //=========================================DATA VALIDATION=========================================//

            if (!double.TryParse(NumRamSticks.Text, out numRamSticks) || numRamSticks < 0)
            {
                MessageBox.Show("Please enter a valid number of ram sticks!");
                NumRamSticks.Focus();
                return;
                
                
            }

            if (!double.TryParse(NumOfFans.Text, out numFans) || numFans < 0)
            {
                MessageBox.Show("Please enter a valid number of fans!");
                NumOfFans.Focus();
                return;

            }

            if (!double.TryParse(PCBudget.Text, out budget) || budget <= 0)
            {
                MessageBox.Show("Please enter a valid budget, you should plan out how much you are willing to pay for your" +
                    "dream gaming PC");
                PCBudget.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Name.Text))
            {
                MessageBox.Show("Please enter a valid Name!");
                Name.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Please enter a valid Email!");
                Name.Focus();
                return;
            }



            //=====================Getting user Input===================//
            name = Name.Text;
            numRamSticks = double.Parse(NumRamSticks.Text);
            budget = double.Parse(PCBudget.Text);
            numFans = double.Parse(NumOfFans.Text);
            cpu = PickCPU.SelectedIndex.ToString();
            email = Email.Text;
            ramPrice = ramPrice * numRamSticks;
            fanPrice = FAN_PRICE * numFans;
            leftOver = budget - totalPrice;





            //===============================OUTPUT===========================//
            ResultMessage.Visible = true;
            totalPrice = liquidCoolingPrice + graphicsCardPrice + ramPrice + fanPrice + storageSizePrice + liquidCoolingPrice + cPUPrice;
            ResultMessage.Text = "Thank you for using our app " + name.ToString() + ", Your budget was " + budget.ToString("C")
                + ". \n The approximate total cost of your gaming PC is " + totalPrice.ToString("C") + ". \n" + "I have no doubt" +
                " that your pc will be able to handle " + purposeGameResponse + purposeWorkResponse + purposeHomeResponse + ". \n" +
                "You chose a " + caseDesign + " sized PC which happens to be approximately " + caseSize + ".";


            //While loop? When you calculate the program shuts down.....

            bool validInput = false;
            while (!validInput)

            {
                string input = PCBudget.Text;

                if (string.IsNullOrEmpty(input))

                {
                    MessageBox.Show("Please enter a budget before building your PC!");
                }

                else if (!int.TryParse(input, out _))

                {
                    MessageBox.Show("Please enter a valid integer value.");
                }

                else

                {
                    validInput = true;
                }

            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //Clearing text box
            Name.Clear();
            Email.Clear();
            NumRamSticks.Clear();
            PCBudget.Clear();
            NumOfFans.Clear();
            //Clearing Combo Boxes/List Boxes/Checked List Boxes
            //Pick cpu is not clearing upon reset?
            PickCPU.SelectedIndex = -1;
            StorageSSD.SelectedIndex = -1;
            comboBoxCaseSize.SelectedIndex = -1;
            ResultMessage.Text = "";
            totalPrice = 0;
            //Clearign Radio Buttons
            GPU20Series.Checked = false;
            GPU30Series.Checked = false;
            GPU40Series.Checked = false;
            RAM8GB.Checked = false;
            RAM16GB.Checked = false;
            RAM32GB.Checked = false;
            LCYes.Checked = false;
            LCNo.Checked = false;
            StorageSize8GB.Checked = false;
            StorageSize16G.Checked = false;
            StorageSize32GB.Checked = false;
            RandomYes.Checked = false;
            RandomNo.Checked = false;
            PurposeGaming.Checked = false;
            PurposeHome.Checked = false;
            PurposeWork.Checked = false;


        }

        //======================Processing============================//
        private void GPU20Series_CheckedChanged(object sender, EventArgs e)
        {
            if (GPU20Series.Checked)
            {

                graphicsCardPrice = 657.00;
            }
        }


        private void GPU30Series_CheckedChanged(object sender, EventArgs e)
        {
            if (GPU30Series.Checked)
            {

                graphicsCardPrice = 1300.00;
            }
        }

        private void GPU40Series_CheckedChanged(object sender, EventArgs e)
        {
            if (GPU40Series.Checked)
            {
                graphicsCardPrice = 1800.00;
            }
        }

        private void RAM8GB_CheckedChanged(object sender, EventArgs e)
        {
            if (RAM8GB.Checked)
            {
                ramPrice = 40.00;

            }
        }

        private void RAM16GB_CheckedChanged(object sender, EventArgs e)
        {
            if (RAM16GB.Checked)
            {
                ramPrice = 85.00;
            }
        }

        private void RAM32GB_CheckedChanged(object sender, EventArgs e)
        {
            if (RAM32GB.Checked)
            {
                ramPrice = 150.00;
            }
        }

        private void LCYes_CheckedChanged(object sender, EventArgs e)
        {
            if (LCYes.Checked)
            {
                liquidCoolingPrice = 100.00;
            }
        }

        private void LCNo_CheckedChanged(object sender, EventArgs e)
        {
            if (LCNo.Checked)
            {
                liquidCoolingPrice = 0;
            }
        }

        private void StorageSize8GB_CheckedChanged(object sender, EventArgs e)
        {
            if (StorageSize8GB.Checked)
            {
                //THIS IS SUPPOED TO BE BASED ON A 250GB SSD
                storageSizePrice = 20;
            }
        }

        private void StorageSize16G_CheckedChanged(object sender, EventArgs e)
        {
            if (StorageSize16G.Checked)
            {
                //THIS IS SUPPOED TO BE BASED ON A 500GB SSD
                storageSizePrice = 40;
            }
        }

        private void StorageSize32GB_CheckedChanged(object sender, EventArgs e)
        {
            if (StorageSize32GB.Checked)
            {
                //THIS IS SUPPOED TO BE BASED ON A 1TB SSD
                storageSizePrice = 100;
            }
        }

        private void StorageSSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StorageSSD.SelectedIndex)
            {
                case 0:
                    cPUPrice = 20;
                    break;
                case 1:
                    cPUPrice = 70;
                    break;
                default:
                    cPUPrice = 0;
                    break;

            }

        }

        private void PickCPU_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < PickCPU.Items.Count; i++)
            {
                if (PickCPU.GetItemChecked(i))
                {
                    switch (i)
                    {
                        case 0:
                            cPUPrice = 30;
                            break;
                        case 1:
                            cPUPrice = 100;
                            break;
                        default:
                            cPUPrice = 0;
                            break;

                    }
                }
            }
        }
        //Use of ONE Dimensional Arrays do we use these and import these into separate CS files and store them as methods?????? 
        private void PurposeGaming_CheckedChanged(object sender, EventArgs e)
        {
            string[] PurposeGamingArray = { "Fortnite", "World of Warcraft", "Minecraft" };
            int[] PurposeGamingArray2 = { 1, 2, 3 };
            bool isValidPurpose;
            //Foreach Loop
            foreach (string i in PurposeGamingArray)
            {
                if (PurposeGaming.Checked == true)
                {
                    isValidPurpose = true;
                    purposeGameResponse = PurposeGamingArray[2];
                }

            }
        }

        private void PurposeWork_CheckedChanged(object sender, EventArgs e)
        {
            string[] PurposeWorkArray = { "Software Development", "Accounting", "Sales" };
            int[] PurposeWorkArray2 = { 1, 2, 3 };
            bool isValidPurpose = false;
            for (int i = 0; i < PurposeWorkArray.Length; ++i)
            {
                if (PurposeWork.Checked == true)
                {
                    isValidPurpose = true;
                    purposeWorkResponse = PurposeWorkArray[1];
                }
                else
                {
                    purposeWorkResponse = "";
                }
            }

        }

        private void PurposeHome_CheckedChanged(object sender, EventArgs e)
        {
            string[] PurposeHomeArray = { "Checking Emails", "Paying Bills", "Browsing the Internet" };
            int[] PurposeHomeArray2 = { 1, 2, 3 };
            bool isValidPurpose = false;
            for (int i = 0; i < PurposeHomeArray.Length; ++i)
            {
                if (PurposeHome.Checked == true)
                {
                    isValidPurpose = true;
                    purposeHomeResponse = PurposeHomeArray[1];
                }
                else
                {
                    purposeHomeResponse = "";
                }
            }
        }
        //Deciding what design of case the client wants
        private void comboBoxCaseSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCaseSize.SelectedIndex)
            {
                case 0:
                    caseDesign = "Full";
                    break;
                case 1:
                    caseDesign = "Mid";
                    break;
                case 2:
                    caseDesign = "Micro";
                    break;
                default:
                    caseDesign = "";
                    break;
            }
        }
        //The title is screwed up but this TWO dimensional array helps link up the size in inches to the design of the case
        //the Client chose
        private void RandomYes_CheckedChanged(object sender, EventArgs e)
        {
            string[,] RandomYesArray = new string[2, 3] { { "Full","Mid","Micro"},
                                                          {  "22 Inches", "18 Inches", "14 Inches"} };
            for (int i = 0; i < RandomYesArray.GetLength(0); ++i)
            {
                if (caseDesign == "Full")
                {
                    caseSize = RandomYesArray[1, 0];
                }
                else if (caseDesign == "Mid")
                {
                    caseSize = RandomYesArray[1, 1];
                }
                else if (caseDesign == "Micro")
                {
                    caseSize = RandomYesArray[1, 2];
                }


            }

        }

        private void RandomNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomNo.Checked)
            {
                caseSize = "";
            }

        }

        //Prices Link to Newegg
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.newegg.com");
        }











    }
}
