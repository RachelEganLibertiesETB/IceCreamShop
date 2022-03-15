using System.Globalization;

namespace IceCreamShop

    //My pb wont activate the price changes, while the rb will!!!!!!!
    //disabling of the flavours section!!
{
    public partial class frmIceCreamShop : Form
    {
        public frmIceCreamShop()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //******************************************************************//

        private void frmIceCreamShop_Load(object sender, EventArgs e)
        {
            pbCone_Click_1(); // should be calling rb, not pb
        }

        //******************************************************************//

        private void pbCone_Click_1(object sender, EventArgs e)
        {
            pbCone_Click_1();
        }

        private void pbSundae_Click_1(object sender, EventArgs e)
        {
            pbSundae_Click_1();
        }

        private void pbBananaSplit_Click_1(object sender, EventArgs e)
        {
            pbBananaSplit_Click_1();
        }








        //******************************************************************//

        private void pbCone_Click_1()
        {
            ResetAll();
            rbChocolate.Checked = true;
            CalculatePrice();
        }

        private void pbSundae_Click_1()
        {
            ResetAll();
            cbSyrup.Checked = true;
            rbVanilla.Checked = true;
            CalculatePrice();
        }

        private void pbBananaSplit_Click_1()
        {
            ResetAll();
            gbIceCreamFlavour.Enabled = false;
            CalculatePrice();

            MessageBox.Show("Your Banana Split comes with Chocolate, " +
                "Vanilla, and Strawberry ice-cream");
        }

        //******************************************************************//

        private void ResetAll()
        {
            gbIceCreamFlavour.Enabled = true;
            cbSyrup.Checked = false;
            cbSprinkles.Checked = false;
            cbFlake.Checked = false;
        }


        private void CalculatePrice()
        {
            //base price for ice cream
            double price = 0;

            if (rbCone.Checked)
            {
                price = 1.50;
            }
            else if (rbSundae.Checked)
            {
                price = 1.90;
            }
            else if (rbBananaSplit.Checked)
            {
                price = 2.50;
            }


            //toppings price
            double toppingPrice = 0;
            if (cbFlake.Checked)
            {
                toppingPrice = toppingPrice + 0.20;
            }
            if (cbSprinkles.Checked)
            {
                toppingPrice = toppingPrice + 0.20;
            }
            if (cbSyrup.Checked)
            {
                toppingPrice = toppingPrice + 0.20;
            }

            //add price to toppingPrice
            price = price + toppingPrice;

            //Format and display total to label
            lblPrice.Text = price.ToString("C", new CultureInfo("en-FR"));


        }

        private void ToppingCheckChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;

            string message = "You have ordered";
            if (rbCone.Checked)
                message += " a Cone";
            else if (rbSundae.Checked)
                message += newline + "an Ice Cream Sundae";
            else if (rbBananaSplit.Checked)
                message += newline + "a Banana Split";

            if (rbChocolate.Checked)
                message += newline + "with Chocolate ice cream";
            else if (rbVanilla.Checked)
                message += newline + "with Vanilla ice cream";
            else if (rbStrawberry.Checked)
                message += newline + "with Strawberry ice cream";

            message += newline;

            if (cbFlake.Checked)
                message += "with a flake ";
            if (cbSprinkles.Checked)
                message += "with sprinkles ";
            if (cbSyrup.Checked)
                message += "with syrup ";

            message += newline + newline + "Please pay the cashier " +
                lblPrice.Text;

            MessageBox.Show(message, "You have ordered",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset the form back to a Cone
            rbCone.PerformClick();
        }
    }    
}