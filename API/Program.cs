// Importation des espaces de noms n�cessaires pour l'h�bergement ASP.NET Core
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
// Importation de l'espace de noms de l'application API
using API;

// D�finition de la classe de programme
public static class Program
{
    // M�thode principale du programme
    public static void Main(string[] args)
    {
        // Construction de l'h�te ASP.NET Core et ex�cution de l'application
        HostBuilde(args).Build().Run();
    }

    // M�thode de cr�ation de l'h�te ASP.NET Core
    public static IWebHostBuilder HostBuilde(string[] args)
    {
        // Cr�ation d'un h�te ASP.NET Core avec une configuration par d�faut et utilisation de la classe Startup pour la configuration
        return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
