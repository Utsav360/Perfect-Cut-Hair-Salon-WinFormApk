// @ Author Utsavkumar M Patel, Student Number -000820474 ,
// This program was created on the 12th October 2020.
// The primary goal of this program is to make a windows form application of the Perfect Cut Hair Salon that 

// (Statement of the authorships)
// I, Utsavkumar M Patel , Student Number 000820474 , certify that this material is my original work.
// And No other person's work has been used without due acknowledgement.'



// System Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//File Name Lab2B
namespace Lab2B
{
    /// <summary>
    /// Form 1 File
    /// </summary>
    public partial class Form1 : Form
    {
        // Create Local Variables
        double HairDresserRate = 30;
        double ServiceChargeRate = 0;
        double ClientTypeDiscount = 0;
        double ClientVisitsDiscount = 0;
        double finalprice = 0;


        /// <summary>
        /// Initialize the form
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
           
        }

        /// <summary>
        /// Services Checkbox 1 calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ServicesCheckBox1.Checked)
            
            {
            
                ServiceChargeRate = ServiceChargeRate + 30;
            
            }
            
            else
            
            {
                
                ServiceChargeRate =ServiceChargeRate- 30;
            
            }
        
        
        }



        /// <summary>
        /// Services checkbox2 calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ServicesCheckBox1.Checked)
            
            {
            
                ServiceChargeRate = ServiceChargeRate+ 40;
            
            }
            
            else
            
            {
            
                ServiceChargeRate = ServiceChargeRate- 40;
            
            }

        
        }
        
        
        /// <summary>
        /// Services checkbox3 calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServicesCheckBox3_CheckedChanged(object sender, EventArgs e)
        
        {
            
            if (ServicesCheckBox1.Checked)
            
            {
            
                ServiceChargeRate = ServiceChargeRate+ 50;
            
            }
            
            else
            
            {
            
                ServiceChargeRate = ServiceChargeRate- 50;
            
            }
        
        }


        /// <summary>
        /// Services checkbox4 calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServicesCheckBox4_CheckedChanged(object sender, EventArgs e)
        
        {
        
            if (ServicesCheckBox1.Checked)
            
            {
                
                ServiceChargeRate = ServiceChargeRate+ 200;
            
            }
            
            else
            
            {
            
                ServiceChargeRate = ServiceChargeRate- 200;
            
            }

        }

        /// <summary>
        /// ExitButton_Click method to terminate the windows form application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the windows form applicaton when user click this button.

            Close();

        }





        private void ClientVisitsTextBox_TextChanged(object sender, EventArgs e)
        
        {
           
            double check;
            
            if (Double.TryParse(ClientVisitsTextBox.Text, out check) == true)
            
            {
                
                if (double.Parse(ClientVisitsTextBox.Text) <= 0 )
                {
                    MessageBox.Show(" Number of Visits must be an integer greater than 0 ", " Incorrect Value ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                else if (double.Parse(ClientVisitsTextBox.Text) >= 4 && double.Parse(ClientVisitsTextBox.Text) <= 8)
                
                {               
                    
                    ClientVisitsDiscount = ((HairDresserRate + ServiceChargeRate) * 5) / 100;
                    
                }
                
                else if (double.Parse(ClientVisitsTextBox.Text) >= 9 && double.Parse(ClientVisitsTextBox.Text) <= 13)
                
                {
                
                    ClientVisitsDiscount = ((HairDresserRate + ServiceChargeRate) * 10) / 100;
                
                }
                
                else if (double.Parse(ClientVisitsTextBox.Text) >= 14)
                
                {
                   
                    ClientVisitsDiscount = ((HairDresserRate + ServiceChargeRate) * 15) / 100;
                
                }
            
            }


        }



        /// <summary>
        /// CalculateButton Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {

            double ValueCheck;
            finalprice = 0;

            if (ServicesCheckBox1.Checked == false && ServicesCheckBox2.Checked == false && ServicesCheckBox3.Checked == false && ServicesCheckBox4.Checked == false)
            
            {
                
                MessageBox.Show("You Must Select At least one Services", "Missing Service(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
            else if (ClientVisitsTextBox.Text == "" || Double.TryParse(ClientVisitsTextBox.Text,out ValueCheck) == false)
            
            {
            
                MessageBox.Show("Please Provide a valid Number of visits!","Please provide A Numebr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
            else
            
            {
                    
                    
                    finalprice += (HairDresserRate + ServiceChargeRate)-(ClientTypeDiscount+ClientVisitsDiscount);
                    
                    FinalResultLabel.Text = finalprice.ToString("$0.00");


                
            }


        }







        private void HairDresserRadioButton1_CheckedChanged(object sender, EventArgs e)
        
        {
            
                HairDresserRate = 30;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        
        {
        
            ResultLabel.Text = ResultLabel.Text;
        
        }

        private void HairDresserRadioButton2_CheckedChanged(object sender, EventArgs e)
        
        {
        
            HairDresserRate = 45;
        
        }

        private void TotalPriceLabel_Click(object sender, EventArgs e)
        
        {

        }

        private void HairDresserGroupBox_Enter(object sender, EventArgs e)
        
        {
           
       
        }

        private void ServicesGroupBox_Enter(object sender, EventArgs e)
        
        {
            

        }

        private void ClientTypeGroupBox_Enter(object sender, EventArgs e)
        
        {
             
        }

        private void ClientVisitsGroupBox_Enter(object sender, EventArgs e)
        
        {

        }

        private void HairDresserRadioButton3_CheckedChanged(object sender, EventArgs e)
        
        {
        
            HairDresserRate = 40;
        
        }

        private void HairDresserRadioButton4_CheckedChanged(object sender, EventArgs e)
        
        {
        
            HairDresserRate = 50;
        
        }

        private void HairDresserRadioButton5_CheckedChanged(object sender, EventArgs e)
        
        {
        
            HairDresserRate = 55;
        
        }

       

        private void ClientTypeRadioButton2_CheckedChanged(object sender, EventArgs e)
        
        {
        
            ClientTypeDiscount = ((HairDresserRate + ServiceChargeRate) * 10) / 100;
        
        }

        private void ClientTypeRadioButton3_CheckedChanged(object sender, EventArgs e)
        
        {
        
            ClientTypeDiscount = ((HairDresserRate + ServiceChargeRate) * 5) / 100;
        
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)

        {

            ClientTypeDiscount = ((HairDresserRate + ServiceChargeRate) * 15) / 100;

        }


        private void label1_Click(object sender, EventArgs e)
        
        {

        }

        private void ClientTypeRadioButton1_CheckedChanged(object sender, EventArgs e)
    
        {

        }



        /// <summary>
        /// 
        /// ClearButton method to clear all controls , select and set focus on the first button in each groupbox.
        /// 
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button1_Click(object sender, EventArgs e)
        {

            //Clear the TotalResult label to empty.
            ResultLabel.Text = "";

            //Set Focus to the HairDresser on the FirstRadionButton1 and disable rest of them.
            HairDresserRadioButton1.Focus();
            HairDresserRadioButton2.Checked = false;
            HairDresserRadioButton3.Checked = false;
            HairDresserRadioButton4.Checked = false;
            HairDresserRadioButton5.Checked = false;

            //Set Focus to the ClientType on the FirstRadionButton1 and disable rest of them.
            ClientTypeRadioButton1.Focus();
            ClientTypeRadioButton2.Checked = false;
            ClientTypeRadioButton3.Checked = false;
            ClientTypeRadioButton4.Checked = false;

            //Clear the Textbox 
            ClientVisitsTextBox.Text = "";

            //Uncheck the Checkbox components
            ServicesCheckBox1.Checked = false;
            ServicesCheckBox2.Checked = false;
            ServicesCheckBox3.Checked = false;
            ServicesCheckBox4.Checked = false;

            // Set Focus on the Calculate Button
            CalculateButton.Focus();
            //Set finalprice and ServiceChargeValue to 0 after the clear button pressed.
            finalprice = 0;
            ServiceChargeRate = 0;
          



        }
    }

}
