namespace DesignPatterns.Creational.Singleton
{
    public sealed class ConfigHandler
    {
        private static ConfigHandler instance = null;
        private static readonly object padlock = new object();

        private ConfigHandler()
        {

        }

        public static ConfigHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ConfigHandler();
                    }
                    return instance;
                }
            }
        }

        public string GetConfiguration()
        {
            return "You got the configuration";
        }
    }
}
