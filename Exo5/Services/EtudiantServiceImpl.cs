using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo5.Services
{
    public class EtudiantServiceImpl : IEtudiantService
    {
        public Dictionary<int, Etudiant> Etudiants = new Dictionary<int, Etudiant>();
        public Dictionary<int, Filiere> Filieres = new Dictionary<int, Filiere>();

        public EtudiantServiceImpl()
        {
            Filieres[Filieres.Count + 1] = new Filiere
            {
                idFil = 1,
                nomFil = "informatique"
            };
            Save(new Etudiant
            {
                id = 1,
                nom = "briouya",
                prenom = "asmae",
                idFil = 1
            });
        }
        public Etudiant Save(Etudiant s)
        {

            s.id = Etudiants.Count + 1;
            Etudiants[s.id] =s;
            return s;
        }

        public IEnumerable<Etudiant> FindAll()
        {
            return Etudiants.Values;
        }

        public Etudiant GetEtudiantById(int id)
        {
            Etudiant s;
            Etudiants.TryGetValue(id, out s);
            return Etudiants[id];
        }
    }
}
