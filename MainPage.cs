using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasterInCorfu
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GeneralInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralInfo form2 = new GeneralInfo();
            form2.Show();
        }

        private void ClimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Climate form7 = new Climate();
            form7.Show();
        }

        private void PatronSaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaintSpyridon form18 = new SaintSpyridon();
            form18.Show();
        }

        private void RomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomanPeriod form4 = new RomanPeriod();
            form4.Show();
        }


        private void ByzantineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ByzantineVenetianPeriod form5 = new ByzantineVenetianPeriod();
            form5.Show();
        }

        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrenchDomination form6 = new FrenchDomination();
            form6.Show();
        }


        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnglishDomination form3 = new EnglishDomination();
            form3.Show();
        }

        private void TodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Today form8 = new Today();
            form8.Show();
        }

        private void AchilleionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Achilleion form9 = new Achilleion();
            form9.Show();
        }

        private void OldFortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OldFort form13 = new OldFort();
            form13.Show();
        }

        private void PalaiokastritsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Palaiokastritsa form10 = new Palaiokastritsa();
            form10.Show();
        }

        private void MonRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonRepo form11 = new MonRepo();
            form11.Show();
        }

        private void PalaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaintsMichaelAndGeorgiouPalace form12 = new SaintsMichaelAndGeorgiouPalace();
            form12.Show();
        }

        private void PontikonisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pontikonisi form17 = new Pontikonisi();
            form17.Show();
        }

        private void CarnivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carnival form14 = new Carnival();
            form14.Show();
        }

        private void EasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Easter form15 = new Easter();
            form15.Show();
        }

        private void GastronomyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastronomy form16 = new Gastronomy();
            form16.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string video1 = @"video\Corfu video.mp4";
            axWindowsMediaPlayer1.URL = video1;
        }

    }
}
