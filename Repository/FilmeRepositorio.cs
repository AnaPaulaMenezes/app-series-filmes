using System;
using System.Collections.Generic;
using DIO.Catalogo.Interfaces;

namespace DIO.Catalogo

{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme obj)
        {
            listaFilme[id] = obj;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme obj)
        {
            listaFilme.Add(obj);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
        public bool Existe(int id)
        {
            if (listaFilme[id].Id > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}