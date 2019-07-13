using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CoffeShop : Form
    {
        public CoffeeShopMdl csm;
        public List<CoffeeShopMdl> csList = new List<CoffeeShopMdl>();
        const int arrySize = 15;
        int Index = 0;
        public int[] Id = new int[arrySize];
        public string[] customerName = new string[arrySize];
        public string[] contactNo = new string[arrySize];
        public string[] address = new string[arrySize];
        public string[] order = new string[arrySize];
        public int[] Quentity = new int[arrySize];
        
        public int[] totalPrice = new int[arrySize];




        public CoffeShop()
        {
            InitializeComponent();
        }

        private void CoffeShop_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(customerIdtextBox.Text);
            string name = textBoxCustomerName.Text;
            string contact = textBoxContactNo.Text;
            string address = textBoxAddress.Text;
            string order = comboBoxOrder.Text;
            string quantity = Convert.ToInt32( textBoxQuentity.Text);
            double totalPrice = 0;
            if (order == "Cold Coffe")
            {

                totalPrice = 120 * Quentity[Index];

            }
            else if (order == "cold drinks")
            {
                totalPrice = 130* Quentity[Index];
            } 
            else if (order == "Hot coffe")
            {
                totalPrice = 140*Quentity[Index];
            }
            
            csm = new CoffeeShopMdl(id, name, contact, address, order, quantity, totalPrice);
            csList.Add(csm);
            string message = "";
            foreach(CoffeeShopMdl c in csList){
                if (c.getQuantity!=0)
                {
                    message = message + " \n\n  "+ "___Order Information___" + "\nCustomer Id   :  " + c.getId() + "\nCustomer Name   :  " + c.getName() + "\nContact No  :  " + c.getContact() +
                "\nAddress  :  " + c.getAddress() + "\nOrder :  " + c.getOrder() + "\nQuentity  :  " + c.getQuantity() + "\nTotal price" + c.getTotalPrice();

                   
                   
                }
            }
            
            ShowrichTextBox.Text = message;





            //ShowrichTextBox.Text = "___Order Information___" + "\n\n\nCustomer Name   :  " + customerName + "\n\n\nContact No  :  " + contactNo +
            //  "\n\n\nAddress  :  " + address + "\n\n\nOrder :  " + order + "\n\n\nQuentity  :  " + Quentity + "\n\nTotal price" + totalPrice;







        }
    }
}
