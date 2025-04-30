
public static class Discografia
{
  public static Dictionary<int, datosDisco> Discos{get; private set;}
   
    public static void InicializarDiscos()
    {
        Discos = new Dictionary<int, datosDisco>();
        string NombreArtista1 = "Britney Spears";
        string NombreProductor1= "Max Martin";
        string GeneroMusical1 = "Pop";
        List<string> Canciones1 = new List<string>();
        Canciones1.Add("Me Against the Music (feat. Madonna)");
        Canciones1.Add("(I Got That) Boom Boom (feat. Ying Yang Twins)");
        Canciones1.Add("Showdown");
        Canciones1.Add("Breathe on Me");
        Canciones1.Add("Early Mornin’");
        Canciones1.Add("Toxic");
        Canciones1.Add("Outrageous");
        Canciones1.Add("Touch of My Hand");
        Canciones1.Add("The Hook Up");
        Canciones1.Add("Shadow");
        Canciones1.Add("Brave New Girl");
        Canciones1.Add("Everytime");

        datosDisco ITZ = new datosDisco(NombreArtista1, NombreProductor1, GeneroMusical1, Canciones1, 11111111, "ITZ.jpg" );
        Discos.Add(ITZ.id, ITZ);
 }
}