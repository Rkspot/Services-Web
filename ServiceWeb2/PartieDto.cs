﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWeb2
{
    public class PartieDto
    {

        public int Id { get; set; }
        public int Id_personnage { get; set; }
        public int Salle_actuelle { get; set; }
        public int Difficulte { get; set; }



        public Partie ToEntity()
        {
            return new Mapping().ToEntity(this);
        }


    }
}

