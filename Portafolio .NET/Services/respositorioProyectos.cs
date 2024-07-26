

//Esta clase solo se encarga de servir datos a la vista

using Portafolio_.NET.Models;

namespace Portafolio_.NET.Services
{

    public interface IrepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }



    public class respositorioProyectos:IrepositorioProyectos
    {

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO {
                    Titulo = "Seguros",
                    Descripcion = "Aplicación para manejar seguros, incapacidades y nómina en HORUS SEGUROS.",
                    UrlProyecto = "https://github.com/kaiseer999/Seguros_Horus",
                    Tecnologias = new List<string> { "Laravel" }
                },
                new ProyectoDTO {
                    Titulo = "JS_GaleriaImagenes",
                    Descripcion = "Galería de imágenes de un viaje, basado en el curso de Carlos Esparza.",
                    UrlProyecto = "https://github.com/kaiseer999/JS_GaleriaImagenes",
                    Tecnologias = new List<string> { "JavaScript", "HTML", "CSS" }
                },
                new ProyectoDTO {
                    Titulo = "AnimeEeve",
                    Descripcion = "Aplicación integral para gestión de contenido de películas y anime.",
                    UrlProyecto = "https://github.com/kaiseer999/PeliculasAnime_phpvanilla",
                    Tecnologias = new List<string> { "PHP", "VanillaJS" }
                },
                new ProyectoDTO {
                    Titulo = "Sistema de manejo de gastos",
                    Descripcion = "Sistema para el manejo de gastos de un usuario.",
                    UrlProyecto = "https://github.com/kaiseer999/sistemagastos_laravel_adminlte3",
                    Tecnologias = new List<string> { "Laravel", "AdminLTE" }
                },
                new ProyectoDTO {
                    Titulo = "Hospital mvc asp.net",
                    Descripcion = "Aplicación para manejar diagnósticos médicos en un hospital.",
                    UrlProyecto = "https://github.com/kaiseer999/Hospital-MVC-.NET-7",
                    Tecnologias = new List<string> { "ASP.NET", "MVC", ".NET 7" }
                }



            };

        }

    }
}
