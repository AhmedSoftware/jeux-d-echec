/************************************************
 *             cellule                          *
 ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCavalier

{
    public struct Position
    {
        public int x;
        public int y;

 
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Cellule
    {
        private Position p;  //la position de chaque cellule
        public Boolean Passe{get;set;}
        private int numero;
        public int Poids { get; set; } //le nombre de possibilite de deplacement
     
       
        public Cellule()
        {
            this.p = new Position(10,10);
            this.Passe = false;
            this.Poids = 50;
        }
        
        public Cellule(int x, int y)
        {
            this.p = new Position(x,y);
            this.Passe = false;
            this.Poids = 50;
        }

        public Cellule(Position p)
        {
            this.p = p;
        }
        
       //Affichage d'un cellule
        public void affichage()
        {
            if (this.p.y == 0 )
                Console.Write("| " + string.Format("{0,2}", this.numero) + " |");
            else
                Console.Write("  " + string.Format("{0,2}", this.numero) + " |");
        }

        //getters et setters
        public int getX()
        {
            return this.p.x;
        }
        public int getY()
        {
            return this.p.y;
        }
        public void setX(int x)
        {
            this.p.x = x;
        }
        public void setY(int y)
        {
            this.p.y = y;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return this.numero;
        }
    }
}
