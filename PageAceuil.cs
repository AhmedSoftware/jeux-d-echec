using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace ProjetCavalier
{

    public partial class PageAceuil : Form
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        SoundPlayer son;
        public PageAceuil()
        {
            InitializeComponent();
            son = new SoundPlayer(@"Ressource\son.wav");
            uint CurrVol = 1;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            this.trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
            this.trackBar1.Value = 1;
        }

        private void Automatique_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void PageAceuil_Load(object sender, EventArgs e)
        {
            son.PlayLooping();
            this.BackgroundImage = Image.FromFile("Ressource\\cavalier.jpg");
            this.JOUER.BackColor = Color.Azure;
            this.BApropos.BackColor = Color.Azure;
            this.Text = "Page D'Acceuil";
            this.Font = new Font("Times New Roman", 10, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);

            //toolTip
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.JOUER, "Lancer une partie");
            toolTip1.SetToolTip(this.BApropos, "message expliquant le but du jeu");
            toolTip1.SetToolTip(this.trackBar1, "Augmentez ou Diminuez le volume");
        }

        private void JOUER_MouseMove(object sender, MouseEventArgs e)
        {
            this.JOUER.BackColor = Color.Blue;
        }

        private void JOUER_MouseLeave(object sender, EventArgs e)
        {
            this.JOUER.BackColor = Color.Empty;
        }

        private void BApropos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t\tBut du jeu:\nDéplacer un cavalier en passant qu'un seul fois sur les cases de l'échequier", "A propos du jeux", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void BApropos_MouseMove(object sender, MouseEventArgs e)
        {
            this.BApropos.BackColor = Color.Blue;
        }

        private void BApropos_MouseLeave(object sender, EventArgs e)
        {
            this.BApropos.BackColor = Color.Empty;
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez vous rellement quitter le jeu ?\n ", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void commencerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void approposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" \tProjet Cavalier\n Date Creation: 13/11/ 2017\n Auteur: AHMED ali \n Spécialité: Téléommunication et Réseaux ", "A propos du jeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Calculate the volume that's being set. BTW: this is a trackbar!
            int NewVolume = ((ushort.MaxValue / 10) * this.trackBar1.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
    }
}
