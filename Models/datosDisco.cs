
public class datosDisco 
{
    public string NombreArtista { get; private set; }
    public string NombreProductor{ get; private set; }
    public string GeneroMusical {get; private set; }
    public int id {get; private set; }
    public List<string> Canciones { get; private set; }
    public string foto {get; private set;}


 public datosDisco(string NombreArtista, string NombreProductor, string GeneroMusical, List<string> Canciones, int id, string foto)
    {
        this.NombreArtista=NombreArtista;
        this.NombreProductor = NombreProductor;
        this.GeneroMusical = GeneroMusical; 
        this.Canciones=Canciones;
        this.id=id;
        this.foto=foto; 
    }
}