using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffeeshop
{
    public partial class Coffeshop : Form
    {
        const int size = 3;
        string[] name = new string[size];
        int[] contuct = new int[size];
        string[] addres = new string[size];
        string[] item = new string[size];
        int[] quantitty = new int[size];
        
        int index = 0;
        string message = " ";

       
        public Coffeshop()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            //string name = customerNameBox.Text;
            // string contuct = customerContuctNo.Text;
            // string address = customerAddress.Text;
            // string item = orderComboBox.Text;

            //int quantity = Convert.ToInt32(quantityCoffee.Text);

            double price = 0;
            for (index = 0; index < size; index++)
            {
                if (item[index] == "Black")
                {
                    price = 120 * (quantitty[index]);
                }
                else if (item[index] == "Cold")
                {
                    price = 100 * (quantitty[index]);
                }
                else if (item[index] == "Hot")
                {
                    price = 90 * quantitty[index];
                }
                else if (item[index] == "Regular")

                    price = 80 * quantitty[index];
            
        
                else
                {
                MessageBox.Show("Please Select an item first");
            }

                message +="Customer Name : " + name[index] + "\n" + "Contuct Number : " + contuct[index] + "\n" + "Address : " + addres[index] + "\n" + "Order : " + item[index] + "\n" + "Quantity : " + quantitty[index] + "\n" + "Total Price : " + price + "\n" + "\n";

            

            }
            richTextBox.Text = (message);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(index<=size)
            {
                name[index] = customerNameBox.Text;
                contuct[index] = Convert.ToInt32(customerContuctNo.Text);
                addres[index] = customerAddress.Text;
                item[index] = orderComboBox.Text;
                quantitty[index] = Convert.ToInt32(quantityCoffee.Text);

                index++;
            }
        }
    }
}
