// Importation des espaces de noms nécessaires pour l'hébergement ASP.NET Core
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
// Importation de l'espace de noms de l'application API
using API;

// Définition de la classe de programme
public static class Program
{
    // Méthode principale du programme
    public static void Main(string[] args)
    {
        // Construction de l'hôte ASP.NET Core et exécution de l'application
        HostBuilde(args).Build().Run();
    }

    // Méthode de création de l'hôte ASP.NET Core
    public static IWebHostBuilder HostBuilde(string[] args)
    {
        // Création d'un hôte ASP.NET Core avec une configuration par défaut et utilisation de la classe Startup pour la configuration
        return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
