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
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;

namespace YearA_Final.UI.UserControls
{
    public partial class AddBread : UserControl
    {
        private BindingList<Bread> breads;
        public AddBread(BindingList<Bread> breads)
        {
            InitializeComponent();
            this.breads = breads;
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
            textBoxPrice.Text = "7.5 ₪";
            textBoxCalories.Text = "298 Calories (100g)";

        }
        private void handleRyeBread()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(25);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "19.80 ₪";
            textBoxCalories.Text = "298 Calories (100g)";
        }
        private void handleWholeWheat()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(2);
            timeNow = timeNow.AddMonths(2);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "25.90 ₪";
            textBoxCalories.Text = "298 Calories (100g)";

        }
    }
}
