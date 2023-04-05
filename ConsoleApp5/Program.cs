namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = { "Pete524", "James242", "Stuart535"};
            string[] passWords = { "51450", "42942", "76931" };

            SimpleLoginApp loginApp = new SimpleLoginApp(userNames, passWords);

            loginApp.PromptUser();
        }
    }
}