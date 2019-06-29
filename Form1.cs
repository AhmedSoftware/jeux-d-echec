using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ProjetCavalier
{
    public partial class Form1 : Form
    {

        public Button[,] tableJeu = new Button[8, 8]; //l'aire du jeu
        Echequier echequier = new Echequier();
        List<Cellule> deplacements = new List<Cellule>(); //liste de deplacement possible
        bool sortir; //pour verifier que le thread de lancement automatique a fini de s'éxecuter
        int numero = 0; //l'ordre du deblacement
        bool valeurExist = false; //verifier que l'utilisation du boutton
        Thread jouer;
        Button caseDepart = new Button();
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            // 
            // button3
            // 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button3 = new Button();
                    button3.Location = new System.Drawing.Point(i * 60, j * 60);
                    button3.Margin = new System.Windows.Forms.Padding(0);
                    button3.Name = "button3";
                    button3.Tag = i + j;
                    button3.Size = new System.Drawing.Size(60, 60);
                    button3.UseVisualStyleBackColor = true;
                    button3.Click += new System.EventHandler(this.boutton_click);
                    button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
                    button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
                    button3.Font = new Font("Arial", 18, FontStyle.Bold);
                    button3.ForeColor = Color.Green;

                    if ((i + j) % 2 == 0)
                        button3.BackColor = Color.Black;
                    else
                        button3.BackColor = Color.White;
                    this.panel1.Controls.Add(button3);
                    tableJeu[i, j] = button3;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CAVLIER";
            this.BackColor = Color.Yellow;
            this.labCommnetaire.Font = new Font("Arial", 20, FontStyle.Bold);
            this.labCommnetaire.ForeColor = Color.Red;
            toolTip1.ShowAlways = true;

            //tooltip

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.button1, "Lancer lejeu");
            toolTip1.SetToolTip(this.button2, "Annulez la partie en cours");
            toolTip1.SetToolTip(this.radioButton1, "activez le mode automatique");
            toolTip1.SetToolTip(this.radioButton2, "activez le mode manuelle");
            toolTip1.SetToolTip(this.retour, "Retour à la page d'Accueuil");
            toolTip1.SetToolTip(this.x, "Entrez le x de départ(horizontalement)");
            toolTip1.SetToolTip(this.y, "Entrez le y de départ(Verticalement)");

            sortir = false;
            echequier.ininialisationEchequipier();
            echequier.initialisationTableauDeplacement();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            Panel p = new Panel();
            Position location;
            if (sender is Panel)
            {
                p = (Panel)sender;
                List<Cellule> deplacements = new List<Cellule>();
                location.x = p.Location.X / 60;
                location.y = p.Location.Y / 60;
                deplacements = echequier.Deplacements(location);
                foreach (Button panel in tableJeu)
                {
                    foreach (Cellule c in deplacements)
                    {
                        if ((c.getX() == panel.Location.X / 60) && (c.getY() == panel.Location.Y / 60))
                            panel.BackColor = Color.Blue;
                    }
                }
            }
        }



        private void panel31_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = new Panel();
            Position location;
            if (sender is Panel)
            {
                p = (Panel)sender;

                List<Cellule> deplacements = new List<Cellule>();
                location.x = p.Location.Y / 60;
                location.y = p.Location.X / 60;
                deplacements = echequier.DeplacementsForm(location);
                foreach (Button panel in tableJeu)
                {
                    foreach (Cellule c in deplacements)
                    {
                        if ((c.getX() == panel.Location.X / 60) && (c.getY() == panel.Location.Y / 60))
                            panel.BackColor = Color.Blue;
                    }
                }
            }
        }
        //boutonn jouer 

        private void button1_Click(object sender, EventArgs e)
        {

            echequier.ininialisationEchequipier();
            this.remttreJourTable();
            if (this.radioButton1.Checked)
            {
                jouer = new Thread(JouerAutomatique);
                jouer.Start();
            }

            if (this.radioButton2.Checked)
            {
                JouerManuelle();
            }



        }
       

        public void JouerManuelle()
        {

            this.labCommnetaire.Text = " ";
            this.radioButton1.Enabled = false;
            Cellule c = new Cellule();
            this.button1.Enabled = false;
            int.TryParse(this.xDepart.Text, out Echequier.positionDepart.x);
            int.TryParse(this.yDepart.Text, out Echequier.positionDepart.y);
            Echequier.positionDepart.x--;
            Echequier.positionDepart.y--;
            if (Echequier.positionDepart.x >= 0 && Echequier.positionDepart.x < 8 &&
               Echequier.positionDepart.y >= 0 && Echequier.positionDepart.y < 8)
            {
                c = echequier.initialisationPositionDepart();
                caseDepart = tableJeu[c.getX(), c.getY()];
                caseDepart.BackgroundImage = Image.FromFile("Ressource\\cavjeu.PNG");
                this.panel1.Refresh();
                Thread.Sleep(1000);
            }
            if (Echequier.positionDepart.x < 0 || Echequier.positionDepart.x >= 8)
            {
                this.labCommnetaire.Text = "Verifiez x Depart";
                this.labCommnetaire.Refresh();
                this.button1.Enabled = true;
            }
            if (Echequier.positionDepart.y < 0 || Echequier.positionDepart.y >= 8)
            {
                this.labCommnetaire.Text += "\nVerifiez Y Depart";
                this.labCommnetaire.Refresh();
                this.button1.Enabled = true;
            }
        }

        public void JouerAutomatique()
        {
            this.Invoke((MethodInvoker)(delegate { this.button1.Enabled = false; })); //delagation pour desactiver boutton demarez
            Cellule c = new Cellule();
            echequier.lancerJeuAutomatique();
            c = echequier.initialisationPositionDepart();
            for (int i = 1; i < 64; i++)
            {
                if (sortir == true)
                    break;
                Button p = tableJeu[c.getX(), c.getY()];
                if (i == 1)
                {
                    p.BackgroundImage = Image.FromFile("Ressource\\cavjeu.PNG");
                    panel1.Invoke((MethodInvoker)(delegate { this.panel1.Refresh(); }));
                    Thread.Sleep(1000);
                    p.BackgroundImage = null;
                }
                else
                    p.BackgroundImage = null;

                Button p2 = new Button();
                panel1.Invoke((MethodInvoker)(delegate { p.Text = " " + c.getNumero(); }));

                echequier.celluleDeplasements = echequier.Deplacements(Echequier.positionDepart);
                echequier.poidsCelluleUtile();
                c = echequier.deplacervers();
                p2 = tableJeu[c.getX(), c.getY()];

                p2.BackgroundImage = Image.FromFile("Ressource\\cavjeu.PNG");
                panel1.Invoke((MethodInvoker)(delegate { this.panel1.Refresh(); }));
                Console.Beep();
                Thread.Sleep(1000);

                c.setNumero(i + 1);
                c.Poids = 0;
                c.Passe = true;
                echequier.ajouterCellule(c);
                echequier.listUtile.Clear();
                echequier.celluleDeplasements.Clear();
                Echequier.positionDepart = new Position(c.getX(), c.getY());

            }
            sortir = false;
        }
        public void remttreJourTable()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tableJeu[i, j].BackgroundImage = null;
                    tableJeu[i, j].Text = "";
                }
            }
            this.Refresh();
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button cellule = (Button)sender;
            Position location;

            if (cellule.BackgroundImage != null)
            {
                List<Cellule> deplacements = new List<Cellule>();
                location.x = (cellule.Location.X) / 60;
                location.y = (cellule.Location.Y) / 60;
                deplacements = echequier.DeplacementsForm(location);
                foreach (Cellule c in deplacements)
                {
                    Button b = tableJeu[c.getX(), c.getY()];
                    if (cellule.BackColor == Color.Black)
                    {
                        b.BackColor = Color.White;
                    }
                    else
                    {
                        b.BackColor = Color.Black;
                    }

                }
            }
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button c = (Button)sender;
            if (c.BackgroundImage != null)
            {
                Position location;
                List<Cellule> deplacements = new List<Cellule>();
                location.x = (c.Location.X) / 60;
                location.y = (c.Location.Y) / 60;
                deplacements = echequier.DeplacementsForm(location);
                foreach (Cellule d in deplacements)
                {
                    Button b = tableJeu[d.getX(), d.getY()];
                    b.BackColor = Color.Blue;
                }
                if (deplacements.Count == 0)
                {
                    this.button1.Enabled = true;
                    this.radioButton1.Enabled = true;
                    MessageBox.Show("!!!GAME OVER!!!\n Score: " + this.scoreLabel.Text, "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        //fonction principale sur la partie manuelle 
        int nbDeplacementPossible = 0;
        private void boutton_click(object sender, EventArgs e)
        {
            Button p2 = sender as Button;
            valeurExist = false;
            Cellule cinitial = Echequier.echequier[caseDepart.Location.X / 60, caseDepart.Location.Y / 60];
            Cellule c = new Cellule();


            this.deplacements = echequier.DeplacementsForm(Echequier.positionDepart);
            this.nbDeplacementPossible = this.deplacements.Count;
            for (int i = 0; i < this.deplacements.Count; i++)
            {
                if ((p2.Location.X / 60 == this.deplacements[i].getX()) && (p2.Location.Y / 60 == this.deplacements[i].getY()))
                {
                    valeurExist = true;
                    numero = cinitial.getNumero();
                    this.caseDepart.Text = " " + numero;
                    this.caseDepart.BackgroundImage = null;
                    p2.BackgroundImage = Image.FromFile("Ressource\\cavjeu.PNG");
                    c.setX(p2.Location.X / 60);
                    c.setY(p2.Location.Y / 60);
                    c.setNumero(numero + 1);
                    c.Poids = 0;
                    c.Passe = true;

                    Echequier.echequier[c.getX(), c.getY()] = c;
                    this.deplacements.Clear();
                    Echequier.positionDepart = new Position(p2.Location.X / 60, p2.Location.Y / 60);
                    valeurExist = true;
                    this.caseDepart = p2;
                    break;
                }

            }
            Console.Beep();
            if (valeurExist == false)
            {
                MessageBox.Show("Deplacement Impossible", "Mauvaise Deplacement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int valeur = 0;
                int.TryParse(this.scoreLabel.Text, out valeur);
                this.scoreLabel.Text = "" + (valeur + 5);
            }

            this.Refresh();
        }
        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous annulez la partie en cours ?", "annulez", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sortir = true;
                remttreJourTable();
                echequier.ininialisationEchequipier();
                Echequier.positionDepart.x = 0;
                Echequier.positionDepart.y = 0;
                this.button1.Enabled = true;
                this.radioButton1.Enabled = true;
                if (this.radioButton1.Checked)
                {
                    while (jouer.IsAlive) ;
                    jouer.Abort();

                }
            }
            this.scoreLabel.Text = "";
            sortir = false;
        }
    }
}
