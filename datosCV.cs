namespace CV
{
    public class datosCV
    {
        public DatosPersonale datosPersonales { get; set; }
        public List<Estudio> estudios { get; set; }
        public List<Trabajo> trabajos { get; set; }
        public List<Herramienta> herramientas { get; set; }
        public ContactaConmigo ContactaConmigo { get; set; }
    }

    public class DatosPersonale
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string poblacion { get; set; }
        public string provincia { get; set; }
        public string empresa { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public List<string> breveDescripcion { get; set; }
        public List<string> sobreMi { get; set; }
    }

    public class Estudio
    {
        public string formacion { get; set; }
        public string Foto { get; set; }
        public string Lugar { get; set; }
        public string poblacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<string> explicacion { get; set; }
        public List<string> extra { get; set; }
    }

    public class Herramienta
    {
        public string categoria { get; set; }
        public List<Tipo> Tipos { get; set; }
    }
    public class Tipo
    {
        public string Foto { get; set; }
        public string Nombre { get; set; }
    }

    public class Trabajo
    {
        public string Foto { get; set; }
        public string puesto { get; set; }
        public string empresa { get; set; }
        public string poblacion { get; set; }
        public List<string> trabajosRealizado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
    }

    public class ContactaConmigo
    {
        public string Email { get; set; }
        public string Linkedin { get; set; }
        public string CodigoMiVida { get; set; }
        public string CVenPDF { get; set; }
        public string githubEstudiante { get; set; }
        public string github { get; set; }
    }

}
