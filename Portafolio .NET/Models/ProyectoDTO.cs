namespace Portafolio_.NET.Models
{
    public class ProyectoDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string UrlProyecto { get; set; }
        public List<string> Tecnologias { get; set; } // Cambiar de string a List<string>
    }
}
