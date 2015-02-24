using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class ScreenUseCaseTable : Form
    {
        //fields
        List<Save> saveList;

        //constructor
        public ScreenUseCaseTable()
        {
            InitializeComponent();

            saveList = new List<Save>();
        }
        
        //methods
        public void CreateSave(string name, string summary, string actor, string assumption, string discription, string implementation, string result)
        {
            Save save = new Save(name, summary, actor, assumption, discription, implementation, result);
            saveList.Add(save);

            comboxSaves.Items.Clear();
            foreach (Save savefile in saveList)
            {
                comboxSaves.Items.Add(Convert.ToString(savefile.Name));
            }
        }

        public void LoadSave(string selectedSave)
        {
            foreach (Save savefile in saveList)
            {
                if (savefile.Name == selectedSave)
                {
                    rchtbName.Text = savefile.Name;
                    rchtbSummary.Text = savefile.Summary;
                    rchtbActor.Text = savefile.Actor;
                    rchtbAssumption.Text = savefile.Assumption;
                    rchtbDiscription.Text = savefile.Discription;
                    rchtbImplementation.Text = savefile.Implementation;
                    rchtbResult.Text = savefile.Result;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string selectedSave;

            selectedSave = Convert.ToString(comboxSaves.SelectedItem);

            LoadSave(selectedSave);
        }

        private void comboxSaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxSaves.SelectedIndex == -1)
            {
                btnLoad.Enabled = false;
            }
            else
            {
                btnLoad.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = rchtbName.Text;
            string summary = rchtbSummary.Text;
            string actor = rchtbActor.Text;
            string assumption = rchtbAssumption.Text;
            string discription = rchtbDiscription.Text;
            string implementation = rchtbImplementation.Text;
            string result = rchtbResult.Text;

            CreateSave(name, summary, actor, assumption, discription, implementation, result);
        }
    }
}
