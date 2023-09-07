using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YearA_Final.Back;
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;

namespace YearA_Final.UI.UserControls
{
    public partial class AddBread : UserControl
    {
        private BindingList<Bread> breads;
        private ShopForm shopForm;
        public AddBread(BindingList<Bread> breads, ShopForm shopForm)
        {
            InitializeComponent();
            this.breads = breads;
            this.shopForm = shopForm;
            comboBoxBreadType.DataSource = Enum.GetValues(typeof(eBreadType))
            .Cast<eBreadType>()
            .Select(type => BreadTypeExtensions.ToDisplayString(type))
            .ToList();
        }

        private void comboBoxBreadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((int)comboBoxBreadType.SelectedIndex)
            {
                case (int)eBreadType.BlackBread:
                    handleBlackBread();
                    break;
                case (int)eBreadType.RyeBread:
                    handleRyeBread();
                    break;
                case (int)eBreadType.WholeWheatBread:
                    handleWholeWheat();
                    break;
                default:
                    break;
            }
        }
        private void handleBlackBread()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(10);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "7 ₪";
            textBoxCalories.Text = "298 Calories (100g)";

        }
        private void handleRyeBread()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(25);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "19 ₪";
            textBoxCalories.Text = "259 Calories (100g)";
        }
        private void handleWholeWheat()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(2);
            timeNow = timeNow.AddMonths(2);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "25 ₪";
            textBoxCalories.Text = "247 Calories (100g)";
        }
        private void buttonAddBread_Click(object sender, EventArgs e)
        {

            try
            {
                int quantity = Int32.Parse(textBoxQuantity.Text);
                double claories;  
                int finalprice;
                DateTime timeNow = DateTime.Now;
                int breadType;

                switch ((eBreadType)comboBoxBreadType.SelectedIndex)
                {
                    case eBreadType.BlackBread:
                        breadType = (int)eBreadType.BlackBread;
                        finalprice = quantity * 7;
                        timeNow = timeNow.AddDays(10);
                        break;
                    case eBreadType.RyeBread:
                        breadType = (int)eBreadType.RyeBread;
                        finalprice = quantity * 19;
                        timeNow = timeNow.AddDays(2);
                        timeNow = timeNow.AddMonths(2);
                        break;
                    case eBreadType.WholeWheatBread:
                        breadType = (int)eBreadType.WholeWheatBread;
                        finalprice = quantity * 25;
                        timeNow = timeNow.AddDays(22);
                        break;
                    default:
                        return;
                }
                Bread bread = new Bread (BreadTypeExtensions.ToDisplayString((eBreadType)comboBoxBreadType.SelectedIndex), timeNow.ToString("dd/MM/yy"), finalprice, quantity, breadType);
                bread.Quantity = quantity;
                Cart.AddProducts(bread);
                breads.Add(bread);
                shopForm.UpdateTotalPrice();
                //here comes the call for updatetotalcalories.
                /*                MessageBox.Show("Pay Attention, Cool for bread is on Cart.");*/
                claories = bread.CalcCalories();
                MessageBox.Show("The number of calories for this product is: " + claories.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid quantity.");
            }
        }
    }
}
