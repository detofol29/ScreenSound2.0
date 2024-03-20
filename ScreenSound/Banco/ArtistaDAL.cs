﻿using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL : DAL<Artista>
    {
        public ArtistaDAL(ScreenSoundContext context) : base(context) { }

        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
        }
    }

}
