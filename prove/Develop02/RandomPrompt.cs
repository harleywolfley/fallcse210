using System.Data;

class RandomPrompt
{
    public static string SelectPrompt()
    {
        Random random = new Random();

        string[] allPrompts = {"How was your day? ", "What was the highlight of your day?", "What was exciting? "};

        string selectedPrompt = random.GetItems(allPrompts, 1)[0];

        return selectedPrompt;
      
    }
    
}