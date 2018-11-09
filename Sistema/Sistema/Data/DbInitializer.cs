using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContexto context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre = "Programacion", Descripcion="Cursos de programacion",
                Estado= true},
                new Categoria{Nombre = "Diseño", Descripcion="Cursos de diseño grafico",
                Estado= true}
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }

            context.SaveChanges();
        }
    }
}
