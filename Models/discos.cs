namespace tp03_gk.Models;
public class discos
{
  public static Dictionary<int, datosDisco> datosDisco{get; private set;}
   
    public static void InicializarDiscos()
    {
        datosDisco = new Dictionary<int, datosDisco>();
        string NombreArtista1 = "Britney Spears";
        string NombreProductor= "Max Martin";
        List<string> Canciones = new List<string>();
        Canciones.Add("Me Against the Music (feat. Madonna)", "(I Got That) Boom Boom (feat. Ying Yang Twins)", "Showdown", "Breathe on Me", "Early Mornin’", "Toxic", "Outrageous", "Touch of My Hand", "The hook up", "Shadow", "Brave New Girl", "Everytime");


 }
}