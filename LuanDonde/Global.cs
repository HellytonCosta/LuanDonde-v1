using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace SeuNamespace
{
    public class Global
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Defina a cultura padrão para o aplicativo
            SetDefaultCulture("pt-BR"); // Substitua "pt-BR" pela cultura desejada
        }

        private void SetDefaultCulture(string culture)
        {
            var cultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
