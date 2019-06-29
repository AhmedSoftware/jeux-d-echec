/***************************************************
 * ECHEQUIER:                                      *
 *    -Declaration des methodes important          *
 *      gerer le cavalier                          *
 ***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCavalier
{
    class  Echequier :Cellule
    {

        public static Cellule[,] echequier ; //enregistre tous les deplacement du cavalier
        static Position[] deplacements; //vecteur de translation 
        const int N = 8;
        public static Position positionDepart;
        public List<Cellule> listUtile; //je enregistre les deplacement qui ne sort pas en dehors de l'echequier 
        public List<Cellule> celluleDeplasements;// list de tous les deplacements possible à partir d'un position 
       
        //constructeur
        public Echequier(int x,int y) : base(x,y)
        {
            Echequier.echequier = new Cellule[N, N];
        }
        public Echequier()
        {
            echequier = new Cellule[8, 8];
            this.listUtile = new List<Cellule>();
            this.celluleDeplasements = new List<Cellule>();
            
        }
        //initialisation de vecteur de deplacements
        public void initialisationTableauDeplacement()
        {
        Echequier.deplacements=new []{
                new Position(1,-2),
                new Position(2,-1),
                new Position(2,1),
                new Position(1,2),
                new Position(-1,2),
                new Position(-2,1),
                new Position(-2,-1),
                new Position(-1,-2)
                };
        }

        //initialisation de 64 case de l'échequier
        public void ininialisationEchequipier(){
        
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    echequier[i, j] = new Cellule();
                }
            }
        }

        //affichage de l'échequier
        
        new public void affichage()
        {
            Console.WriteLine("+----------------------------------------------+");
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    echequier[i, j].affichage();

                }
                Console.WriteLine("\n+----------------------------------------------+");
            }
        }
        
		//ajouter une cellule au matrice echequier 
        public void ajouterCellule(Cellule c)
        {
            Echequier.echequier[c.getX(), c.getY()] = c;   
        }
		
		//calcule tous les deplacemen possible à partir d'un position 
        public List<Cellule>  Deplacements(Position p)
        {
            List<Cellule> listDep = new List<Cellule>();

            Cellule c;
            for (int i = 0; i < N; i++)
                {
                    c = new Cellule();
                    c.setX(deplacements[i].x + p.x);
                    c.setY(deplacements[i].y + p.y);

                    if (c.getX()>= 0 && c.getX()< N && c.getY() >=0 && c.getY()< N)
                    {
                        c.Poids = -1;
                        foreach (Cellule cequipier in echequier)
                        {
                            if ((cequipier.getX() == c.getX()) && (cequipier.getY() == c.getY()))
                               c.Passe = true;
                        }
                        if (c.Passe == false)
                            listDep.Add(c);
                        
                    }
                }
                return listDep;
        }

        //calcule tous les deplacemen possible à partir d'un position 
        public List<Cellule> DeplacementsForm(Position p)
        {
            List<Cellule> listDep = new List<Cellule>();

            Cellule c;
            for (int i = 0; i < N; i++)
            {
                c = new Cellule();
                c.setX(deplacements[i].x + p.x);
                c.setY(deplacements[i].y + p.y);

                if (c.getX() >= 0 && c.getX() < N && c.getY() >= 0 && c.getY() < N)
                {
                    c.Poids = -1;
                    foreach (Cellule cequipier in echequier)
                    {
                        if ((cequipier.getX() == c.getX()) && (cequipier.getY() == c.getY()))
                            c.Passe = true;
                    }
                    if (c.Passe == false)
                        listDep.Add(c);
                }
            }
            return listDep;
        }
        //calcul le nombre de deplacement possible vers les autres cellule
        public void poidsCelluleUtile()
        {
            int Deplacement=0;
            foreach (Cellule c in this.celluleDeplasements)
            {
                 Deplacement=Deplacements(new Position(c.getX(), c.getY())).Count;
                 c.Poids = c.Poids + Deplacement;
                 listUtile.Add(c);
            }
        }
		
		//initialisation poistion de depart 
        public void lancerJeuAutomatique(){
           int x =(new System.Random()).Next(0,7);
           int y = (new System.Random()).Next(0,7);
           positionDepart = new Position(x,y);
        }
		
		//on lance le jeu 
        public void joueUnCavalier(Boolean automatique)
        {
            ininialisationEchequipier();
            initialisationTableauDeplacement();
            if(automatique==true)
            lancerJeuAutomatique();
            else
            lancerJeuManuelle();
            initialisationPositionDepart();
            for (int i = 1; i < N*N; i++)
            {
                Cellule c = new Cellule();
                this.celluleDeplasements =Deplacements(positionDepart);
                poidsCelluleUtile();
                c = deplacervers();
                c.setNumero(i+1);
                c.Poids = 0;
                c.Passe = true;
                ajouterCellule(c);
                this.listUtile.Clear();
                this.celluleDeplasements.Clear();
                positionDepart= new Position(c.getX(),c.getY());
                
            }
        }
		
		//initialisation position depart manuelle
        public Cellule initialisationPositionDepart()
        {
            Cellule c = new Cellule();
            c.setX(positionDepart.x);
            c.setY(positionDepart.y);
            c.setNumero(1);
            c.Poids = 0;
            c.Passe = true;
            ajouterCellule(c);
            return c;
        }

        //Deplacer le cavalier ves la cellule qui a le nombre de deplacement minimal
        public Cellule deplacervers()
        {
               Cellule ci = new Cellule();
                foreach (Cellule cu in listUtile)
                {
                    if ((ci.Poids > cu.Poids))
                        ci = cu;
                }
            return ci ;
        }

        //demande à l'utilisateur de rentrer 
        //la position de de part
        public void lancerJeuManuelle()
        {
            int x;
            int y;
            Boolean ok;
            //Console.WriteLine("Oncommence le jeux");
            do{
            Console.Write("saisiez x:");
            ok = int.TryParse(Console.ReadLine(), out x);
            if (ok == false)
                Console.WriteLine("Entrez une valeur!!!!");
             if(x<1||x>8)
                Console.WriteLine("Entrez un X(abscice) Comprise entre 1-8");
            }while((ok==false)||(x<1||x>8));
            Console.Write("saisissez y:");
            do{
            ok = int.TryParse(Console.ReadLine(), out y);
            if (ok == false)
                Console.WriteLine("Entrez une valeur");
             
             if(y<1||y>8)
                Console.WriteLine("Entrez un Y(ordonne) Compris entre 1-8");
            } while ((ok == false) || (y < 1 || y > 8));

            positionDepart = new Position(x-1, y-1);
        }
    
    }
}
