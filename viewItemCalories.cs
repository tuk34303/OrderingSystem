using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class viewItemCalories : Form
    {
        public viewItemCalories(MenuItem item)
        {
            InitializeComponent();

            itemChart.Series["Calories"].Points.AddXY("Calories", item.Calories);
            itemChart.Series["Carbohydrates"].Points.AddXY("Carbohydrates", item.Carbs);
            itemChart.Series["Fats"].Points.AddXY("Fats", item.Fats);
            itemChart.Series["Proteins"].Points.AddXY("Proteins", item.Proteins);
            itemChart.Series["SodiumContent"].Points.AddXY("SodiumContent", item.SodiumContent);
        }

        private void viewItemCalories_Load(object sender, EventArgs e)
        {
            

        }

        private void itemChart_Click(object sender, EventArgs e)
        {

        }
    }
}
