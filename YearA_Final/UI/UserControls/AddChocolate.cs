using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YearA_Final.Back;
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YearA_Final.UI.UserControls
{
    public partial class AddChocolate : UserControl
    {
        private BindingList<Chocolate> chocolates;
        private ShopForm shopForm;
        public AddChocolate(BindingList<Chocolate> chocolates, ShopForm shopForm)
        {
            InitializeComponent();
            this.shopForm = shopForm;
            this.chocolates = chocolates;
            comboBoxChocolateType.DataSource = Enum.GetValues(typeof(eChocolateTypes))
            .Cast<eChocolateTypes>().Select(type => ChocolateTypeExtantions.ToDisplayString(type))
            .ToList();
        }

        private void comboBoxChocolateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((int)comboBoxChocolateType.SelectedIndex)
            {
                case (int)eChocolateTypes.WhiteChocolate:
                    handleWhiteChoco();
                    break;
                case (int)eChocolateTypes.MilkChocolate:
                    handleMilkChoco();
                    break;
                case (int)eChocolateTypes.DarkChocolate:
                    handleDarkChoco();
                    break;
                default:
                    break;

            }
        }
        private void handleWhiteChoco ()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddMonths(5);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "5 ₪";
            textBoxCalories.Text = "539 Calories (100g)";

        }
        private void handleMilkChoco()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddMonths(3);
            timeNow = timeNow.AddDays(7);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "4 ₪";
            textBoxCalories.Text = "535 Calories (100g)";

        }
        private void handleDarkChoco()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddMonths(8);
            timeNow = timeNow.AddDays(20);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "7 ₪";
            textBoxCalories.Text = "600 Calories (100g)";

        }

        private void buttonAddBread_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Int32.Parse(textBoxQuantity.Text);
                int finalprice;
                DateTime timeNow = DateTime.Now;
                int chocolateType;
                int fatPrecentage;

                switch ((eChocolateTypes)comboBoxChocolateType.SelectedIndex)
                {
                    case eChocolateTypes.WhiteChocolate:
                        chocolateType = (int)eChocolateTypes.WhiteChocolate;
                        finalprice = quantity * 5;
                        fatPrecentage = 33;
                        timeNow = timeNow.AddMonths(5); ;
                        break;
                    case eChocolateTypes.MilkChocolate:
                        chocolateType = (int)eChocolateTypes.MilkChocolate;
                        finalprice = quantity * 4;
                        fatPrecentage = 30;
                        timeNow = timeNow.AddMonths(3);
                        timeNow = timeNow.AddDays(7);
                        break;
                    case eChocolateTypes.DarkChocolate:
                        chocolateType = (int)eChocolateTypes.DarkChocolate;
                        finalprice = quantity * 7;
                        fatPrecentage = 44;
                        timeNow = timeNow.AddMonths(8);
                        timeNow = timeNow.AddDays(20);
                        break;
                    default:
                        return;
                }
                Chocolate chocolate = new Chocolate(ChocolateTypeExtantions.ToDisplayString((eChocolateTypes)comboBoxChocolateType.SelectedIndex), timeNow.ToString("dd/MM/yy"), finalprice, 100 * quantity, chocolateType, fatPrecentage);
                chocolate.Quantity = quantity;
                Cart.AddProducts(chocolate);
                chocolates.Add(chocolate);
                shopForm.UpdateTotalPrice();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid quantity.");
            }
        }

        private void textBoxCalories_MouseHover(object sender, EventArgs e)
        {
            toolTipPriceChocolate.SetToolTip(textBoxCalories, "Calories will be shown for 100 grams,  will be calculated for enitre quantity");
        }
    }
}
