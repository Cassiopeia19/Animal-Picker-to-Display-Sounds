using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalPart2
{
    public partial class Form1 : Form
    {
        private bool state = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void AnimalNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetNamesOfAnimals_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetAnimalSounds_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
                listBoxItem.Items.Add(s);
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            listBoxIndex.Items.Clear();
            string[] sound = new String[5];
            sound[0] = "Meow-Meow";
            sound[1] = "Moo-Moo";
            sound[2] = "Quack-Quack";
            sound[3] = "Oink-Oink";
            sound[4] = "Cock-a-Doodle-Doo";

           if (checkedListBox.CheckedItems.Contains("Cat"))
            {
                listBoxIndex.Items.Add(sound[0]);
            }
            if (checkedListBox.CheckedItems.Contains("Cow"))
            { 
                listBoxIndex.Items.Add(sound[1]);
             }
           if (checkedListBox.CheckedItems.Contains("Duck"))
            {
                listBoxIndex.Items.Add(sound[2]);
            }
            if (checkedListBox.CheckedItems.Contains("Pig"))
        {
                listBoxIndex.Items.Add(sound[3]);
            }
            if (checkedListBox.CheckedItems.Contains("Rooster"))
            {
                listBoxIndex.Items.Add(sound[4]);
            }
        }
        private void listBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UncheckAllItems();
            
        }
        private void UncheckAllItems()
        {
            while (checkedListBox.CheckedIndices.Count > 0)
                checkedListBox.SetItemChecked(checkedListBox.CheckedIndices[0], false);
                listBoxIndex.Items.Clear();
                listBoxItem.Items.Clear();
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            UncheckAllItems();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm that you want to Exit the System", "Restaurant and Culinary Delights",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
