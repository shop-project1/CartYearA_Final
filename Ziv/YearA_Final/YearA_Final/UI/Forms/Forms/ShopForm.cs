using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YearA_Final.Back;
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;
using YearA_Final.UI.UserControls;


namespace YearA_Final
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            comboBoxChooseProduct.DataSource = Enum.GetValues(typeof(eCategory));
        }
        public void PopulateCartView()
        {
            // Clear the DataGridView;;
            dataGridCart.DataSource = null;

            // Set the DataGridView's DataSource to the cart products
            dataGridCart.DataSource = Cart.products;
        }
        private void comboBoxChooseProduct_SelectedItemChanged(object sender, EventArgs e)
        {
            panelAddUserControl.Controls.Clear();
            
            if (comboBoxChooseProduct.SelectedItem.ToString() == eCategory.None.ToString())
            {
                panelAddUserControl.Controls.Clear();
                comboBoxByCatgeory.Visible = false;
            }
            if (comboBoxChooseProduct.SelectedItem.ToString() == eCategory.Drinks.ToString())
            {
                panelAddUserControl.Controls.Clear();
                comboBoxByCatgeory.Visible = true;
                comboBoxByCatgeory.DataSource= Enum.GetValues(typeof(eDrinks));
              
            }

            if (comboBoxChooseProduct.SelectedItem.ToString() == eCategory.Food.ToString())
            {
                panelAddUserControl.Controls.Clear();
                comboBoxByCatgeory.Visible = true;
                comboBoxByCatgeory.DataSource = Enum.GetValues(typeof(eFood));
                
            }
            PopulateCartView();

        }

        private void comboBoxByCatgeory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxByCatgeory.SelectedIndex)
            {
                case (int)eFood.Choose:
                    chooseHandle();
                    break;
                case (int)eFood.Bread:
                    breadHandle();                    
                    break;
                case (int)eFood.Chicken:
                    chickenHandle();
                    break;
                default:
                    break;
            }
            PopulateCartView();
        }
        private void chooseHandle()
        {
            panelAddUserControl.Controls.Clear();

        }

        private void chickenHandle()
        {
            panelAddUserControl.Controls.Clear();
            MessageBox.Show("Please pay attention, quantity in 100 Grams per unit.");
            BindingList<Chicken> chickenList = Cart.GetProductsByType<Chicken>();

            // Create the AddChicken user control and pass the chickenList
            AddChicken addChickenControl = new AddChicken(chickenList);

            // Add the user control to the panel
            panelAddUserControl.Controls.Add(addChickenControl);

            dataGridCart.DataSource = chickenList;
            dataGridCart.Refresh();
        }

        private void breadHandle()
        {
            panelAddUserControl.Controls.Clear();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            PopulateCartView();
        }

        private void gridSaveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridCart.DataSource);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fileInfo = new FileInfo("Products.txt");
            using (FileStream fileStream = new FileStream("Products.txt", FileMode.Create))
            {
                binaryFormatter.Serialize(fileStream, dataGridCart.DataSource);
            }

        }
    }
}
