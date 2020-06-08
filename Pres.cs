﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pres
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Finalidade { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
        public string NomeFornecedor { get; set; }
    }
}
