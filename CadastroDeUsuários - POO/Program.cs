﻿using CadastroDeUsuarios_POO;
using CadastroUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDados baseDeDados = new BaseDeDados();
            InterfaceGrafica meuPrograma = new InterfaceGrafica(baseDeDados);
            meuPrograma.IniciarInterface();
        }
    }
}
