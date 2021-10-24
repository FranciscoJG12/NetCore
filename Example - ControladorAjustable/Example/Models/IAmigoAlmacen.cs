using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public interface IAmigoAlmacen
    {
        Amigo dameDatosAmigo (int Id);

        List<Amigo> DameTodosLosAmigos();

        Amigo Nuevo(Amigo amigo);

        Amigo Eliminar(int Id);

        Amigo Actualizar(int Id);

    }
}
