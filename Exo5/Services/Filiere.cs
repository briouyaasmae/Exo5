﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exo5.Services
{
    public class Filiere
    {
        public Filiere()
        {
            this.Etudiants = new HashSet<Etudiant>();
        }
        [Key]
        public int idFil { get; set; }
        public string nomFil { get; set; }

        public ICollection<Etudiant> Etudiants { get; set; }
    }
}
