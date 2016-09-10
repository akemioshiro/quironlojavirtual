using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - Inicio - Produtos de todas as categorias, ex: "/"
            routes.MapRoute(
                    null,
                    "",
                    new { controller = "Vitrine",
                        action = "ListaProdutos",
                        categoria = (string)null , pagina = 1 });

            // 2 - Todas as categorias de determinada pagina, ex: pagina 2 "/Pagina2"
            routes.MapRoute(
                    null,
                    "Pagina{pagina}",
                    new
                    {
                        controller = "Vitrine",
                        action = "ListaProdutos",
                        categoria = (string)null
                    }, new { pagina = @"\d+" });



            // 3 - Primeira página da categoria X, ex: "/Futebol" primeira pagina da categoria futebol
            routes.MapRoute(
                    null, 
                    "{categoria}", 
                    new { controller = "Vitrine",
                        action = "ListaProdutos",
                        pagina = 1 });


            // 4 - Pagina x da categoria Y, ex: "/Futebol/Pagina2"
            routes.MapRoute(
                    null,
                    "{categoria}/Pagina{pagina}",
                    new
                    {
                        controller = "Vitrine",
                        action = "ListaProdutos",
                    }, new { pagina = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vitrine", action = "ListaProdutos", id = UrlParameter.Optional }
            );




        }
    }
}
