using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo5.Services
{
    interface IEtudiantService
    {
        Etudiant Save(Etudiant e);
        IEnumerable<Etudiant> FindAll();
        Etudiant GetEtudiantById(int id);
    }
}
