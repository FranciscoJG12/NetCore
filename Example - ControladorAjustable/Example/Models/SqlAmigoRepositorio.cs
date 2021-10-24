using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    public class SqlAmigoRepositorio:IAmigoAlmacen
    {
        private readonly AppDbContext contexto;
        private List<Amigo> amigoLista;

        public SqlAmigoRepositorio(AppDbContext contexto)
        {
            this.contexto = contexto;
        }

        public Amigo Nuevo(Amigo amigo)
        {
            contexto.Add(amigo);
            contexto.SaveChanges();
            return amigo;
        }

        public Amigo dameDatosAmigo(int Id)
        {
            //return this.amigoLista.FirstOrDefault(e => e.Id == Id);
            return contexto.Amigos.Find(Id);
        }

        public List<Amigo> DameTodosLosAmigos()
        {
            List<Amigo> lista = contexto.Amigos.ToList<Amigo>();
            return lista;
        }

        public Amigo Eliminar(int Id)
        {
            Amigo amigo = contexto.Amigos.Find(Id);
            if (amigo != null)
            {
                contexto.Amigos.Remove(amigo);
                contexto.SaveChanges();
            }

            return amigo;

        }

        public Amigo Actualizar(int Id)
        {
            Amigo amigo = contexto.Amigos.Find(Id);
            if (amigo != null)
            {
                var personaEditar = contexto.Amigos.FirstOrDefault(x => x.Id == Id);
                personaEditar.Nombre = "Cambio registrado";
                personaEditar.Email = "cambio@gmail.com";
                contexto.SaveChanges();
            }
            return amigo;

        }
    }
}
