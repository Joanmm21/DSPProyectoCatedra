namespace BibliotecaMetropolis.Models
{
    public class MaterialesBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string CasaEditorial { get; set; }
        public string NumeroEdicion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public int CantidadUnidades { get; set; }
        public decimal PrecioUnitario { get; set; }

        public string TipoMaterial { get; set; }

        // Propiedad calculada
        public decimal PrecioTotal => CantidadUnidades * PrecioUnitario;
    }

    public class Libro : MaterialesBiblioteca
    {
        public string ISBN { get; set; }
    }

    public class Revista : MaterialesBiblioteca
    {
        public int NumeroRevista { get; set; }
    }

    public class DVD : MaterialesBiblioteca
    {
        public int DuracionMinutos { get; set; }
    }

    public class Enciclopedia : MaterialesBiblioteca
    {
        public int Volumenes { get; set; }
    }

    public class Tesis : MaterialesBiblioteca
    {
        public string Universidad { get; set; }
    }
}

    

