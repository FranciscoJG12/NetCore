using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public class MockAmigoRepositorio:IAmigoAlmacen
    {
        private List<Amigo> amigoLista;

        public MockAmigoRepositorio()
        {
            amigoLista = new List<Amigo>();
            amigoLista.Add(new Amigo() {Id = 1, Ciudad = "Quito" ,Email = "fjarrin@pichincha.com",Nombre = "Francisco"});
            amigoLista.Add(new Amigo() {Id = 2, Ciudad = "Guayaquil", Email = "pjarrin@pichincha.com", Nombre = "Pedro" });
            amigoLista.Add(new Amigo() {Id = 3, Ciudad = "Cuenca", Email = "djarrin@pichincha.com", Nombre = "Damian" });
        }

        public Amigo dameDatosAmigo(int Id)
        {
            return this.amigoLista.FirstOrDefault(e => e.Id == Id);
        }

        public List<Amigo> DameTodosLosAmigos()
        {
            return this.amigoLista;
        }

        public Amigo Nuevo(Amigo amigo)
        {
            return amigo;
        }

        public Amigo Eliminar(int Id)
        {
            Amigo amigo = new Amigo();
            return amigo;
        }


        public Amigo Actualizar(int Id)
        {
            Amigo amigo = new Amigo();
            return amigo;
        }

    }
}