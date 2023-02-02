using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW02Ev
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int winNumber;
            int counter=0;
            Random random = new Random();
            do
            {
                winNumber = random.Next(1,2000);
                counter++;
            } while (numericUpDown1.Value != winNumber);
            MessageBox.Show($"Число :{winNumber},Кількість спроб: {counter}");
        }
    }
}
