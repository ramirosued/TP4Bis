public static class Info
{
private static List<Pais> ListaPaises = new List<Pais>();

private static void InicializarLista()
{
    Pais unPais = new Pais("Argentina", "argentina.png", 45000000, new DateTime(1816,7,9), "Cataratas");
    ListaPaises.Add(unPais);
    unPais = new Pais("Brasil", "brasil.png", 145000000, new DateTime(1816,7,9), "Amazonas");
    ListaPaises.Add(unPais);
    unPais = new Pais("Chile", "chile.png", 25000000, new DateTime(1816,7,9), "Pucon");
    ListaPaises.Add(unPais);
    unPais = new Pais("Uruguay", "uruguay.webp", 10000000, new DateTime(1816,7,9), "Punta del Este");
    ListaPaises.Add(unPais);
    unPais = new Pais("Paraguay", "paraguay.png", 30000000, new DateTime(1816,7,9), "Asuncion");
    ListaPaises.Add(unPais);
}

public static List<Pais> ListarPaises()
{
if(ListaPaises.Count==0)
{
    InicializarLista();
}
return ListaPaises;
}

public static Pais DetallePais(string Nombre)
{
    Pais PaisBsucado =new Pais();
    foreach(Pais item  in ListaPaises)
    {
    if(item.Nombre==Nombre)
    {
    return item;
    }
    }
    return PaisBsucado;
}
}