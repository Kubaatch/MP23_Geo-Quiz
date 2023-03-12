using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Geo_Quiz
{
    public partial class UC_GameUI : UserControl
    {
        enum Category {
            Flags = 0,
            Capitals = 1,
            Population = 2,
            Area = 3
        };            
            //edited copy from https://stackoverflow.com/questions/2940626/how-to-add-enum-values-to-a-list
        readonly object[] category = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();
            //end

        //add enums for cont/cats?
        private readonly string[] Continents = {
                "Europe",
                "Asia",
                "Africa",
                "America (North & Central)",
                "America (South)",
                "Oceania"
        };
        
        private int SelectedCategory;
        private string[] SelectedContinents;
        private int QuestionCount = 15;

        public UC_GameUI()
        {
            InitializeComponent();

            LB_Category.Items.AddRange(category);
            LB_Continents.Items.AddRange(Continents);
            numericUpDown1.Value = QuestionCount;
        }

        public void B_TextBox_Click(object sender, EventArgs e)
        {
            LoadStats(sender);
        }

        private void B_ABCD_Click(object sender, EventArgs e)
        {
            LoadStats(sender);
        }

        private void LoadStats(object sender)
        {
            SelectedCategory = LB_Category.SelectedIndex;            
            SelectedContinents = LB_Continents.SelectedItems.Cast<string>().ToArray();            
            QuestionCount = Convert.ToInt32(numericUpDown1.Value);

            if (SelectedContinents == null || SelectedContinents.Length == 0)
            {
                DialogResult result = MessageBox.Show("You haven't chosen any continents, are you sure you want to continue?"
                    + "\nSelecting no continents works as if all were selected...", "¯\\_(ツ)_/¯", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SelectedContinents = Continents.ToArray();                    
                    goto Success;
                }
                else
                {
                    return;
                }
            }

            Success:;

            Button clickedButton = sender as Button;

            if (clickedButton == B_ABCD)
            {
                StartABCD();
            }
            else
            {
                StartTextInput();
            }
        }

        private void StartTextInput()
        {
            UC_TextInput uc = new UC_TextInput(SelectedCategory, SelectedContinents, QuestionCount);
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void StartABCD()
        {
            UC_ABCD uc = new UC_ABCD(SelectedCategory, SelectedContinents, QuestionCount);
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
            uc.BringToFront();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
