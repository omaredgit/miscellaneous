using Microsoft.AspNetCore.Hosting.Server;

namespace miscellaneous.EnvVariables
{
    public class EnvVariables
    {
        public EnvVariables(StageEnvironments environment)
        {
             if (environment == StageEnvironments.Dev)
            {
                //Connectionstring = Environment.GetEnvironmentVariable("DEV_CONNECTION_STRING") ?? "Error";
                Connectionstring = "Server=ruby.db.elephantsql.com;Port=5432;Database=ntlmvaei;UserId=ntlmvaei;Password=D-KoHm6N6ykKfKwDRmaJrbwHzxR-HIAS" ;
            }
        }
        public string? Connectionstring {get; set;}
    }
}
