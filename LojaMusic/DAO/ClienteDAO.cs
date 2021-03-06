﻿using LojaMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMusic.DAO
{
    class ClienteDAO
    {
        private static Context ctx = new Context();
        private static object c;

        public static bool AdicionarCliente(Cliente c)
        {
            try
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Cliente> RetornarLista()
        {
            return ctx.Clientes.ToList();
        }

        public static Cliente RetornarClienteCPF(string aux)
        {
            
            return ctx.Clientes.FirstOrDefault(x => x.ClienteCpf.Equals(aux));
        }

    }
}