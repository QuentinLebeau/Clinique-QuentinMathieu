using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MgtAnimal
    {
        ADO_Animal animauxDAL = new ADO_Animal();

        public List<Animaux> AfficherTout()
        {
            return animauxDAL.GetAll();
        }

        public Animaux AfficherUneSeul(int pCodeAnimal)
        {
            return animauxDAL.GetOne(pCodeAnimal);
        }

        public void Ajouter(Animaux unAnimal)
        {
            animauxDAL.Add(unAnimal);
        }

        public void Modifier(Animaux unAnimal)
        {
            animauxDAL.Update(unAnimal);
        }

        public void Supprimer(int pCodeAnimal)
        {
            animauxDAL.Delete(pCodeAnimal);
        }
    }
}
