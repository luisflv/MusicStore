﻿using MusicStore.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Instrumento : IObjectValidation
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataFabricacao { get; set; }

        public double Valor { get; set; }

        public TipoInstrumento TipoInstrumento { get; set; }

        public void Validate()
        {

        }


    }
}
