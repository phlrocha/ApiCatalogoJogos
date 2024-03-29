﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Entities
{
    public class Jogo
    {
        public Guid IdJogo { get; set; }

        public string Nome { get; set; }

        public string Produtora { get; set; }

        public double Preco { get; set; }

        public DateTime Lancamento { get; set; }
    }
}
