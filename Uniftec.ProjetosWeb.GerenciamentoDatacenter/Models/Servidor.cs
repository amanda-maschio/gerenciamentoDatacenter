﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uniftec.ProjetosWeb.GerenciamentoDatacenter.Models
{
    public class Servidor
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }

        public string EnderecoFisico { get; set; }

        public string Processador { get; set; }

        public string SistemaOperacional { get; set; }

        public string MacAddress { get; set; }

        public string IpAddress { get; set; }

        public List<Sensor> ListaSensores { get; set; }

        public Servidor()
        {
            Id = Guid.NewGuid();
            this.ListaSensores = new List<Sensor>();
        }
    }
}