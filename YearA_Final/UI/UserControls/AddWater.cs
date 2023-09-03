//using YearA_Final.Back;
//using YearA_Final.Back.Enum;
//using YearA_Final.Back.Model;
//using YearA_Final.UI.UserControls;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;


//namespace YearA_Final.UI.UserControls
//{
//    public partial class AddWater : UserControl
//    {

//        public AddWater(BindingList<Water> water)
//        {
//            InitializeComponent();
//            comboBoxTypeOfWater.DataSource = Enum.GetValues(typeof(eWaterType));

//        }
//        //            if (comboBoxTypeOfWater.SelectedIndex == 1)
//        //    {
//        //        textBoxShowPrice.Text = "10";
//        //        DateTime currentDay = DateTime.Now;
//        //textBoxExpDate.Text = currentDay.ToString();

//        //    }

//        private void buttonAdd_Click(object sender, EventArgs e)
//        {

//        }

//        private void comboBoxTypeOfWater_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (comboBoxTypeOfWater.SelectedIndex == 1)
//            {
//                textBoxShowPrice.Text = "10 ₪";
//                DateTime currentDay = DateTime.Now;
//                currentDay = currentDay.AddMonths(4);
//                currentDay = currentDay.AddYears(2);
//                string formattedDate = currentDay.ToString("dd/MM/yy");
//                textBoxExpDate.Text = formattedDate;
//                checkBoxIsCarbon.Checked = true;
//                textBoxVolume.Text = "2.0 L";
//            }

//        }
//    }
//}
