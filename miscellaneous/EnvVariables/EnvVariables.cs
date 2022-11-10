namespace miscellaneous.EnvVariables
{
    public class EnvVariables
    {
        public EnvVariables(StageEnvironments environment)
        {
             if (environment == StageEnvironments.Dev)
            {
                Connectionstring = Environment.GetEnvironmentVariable("DEV_CONNECTION_STRING") ?? "Error";
            }
        }
        public string? Connectionstring {get; set;}
    }
}
