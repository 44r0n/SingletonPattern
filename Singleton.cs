namespace SingletonPattern
{
    public class Singleton
    {
        private string text;

        public string Text => text;

        public void ChangeData()
        {
            text = "Changed!";
        }       

        private Singleton()
        {
            text = "Constructed!";
        }

        private static Singleton instance = null;

        public static Singleton GetInstance() 
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}