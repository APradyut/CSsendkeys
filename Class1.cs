using System.Windows.Forms;
public class SendThis
{
    private static string text;
    public static void start(string input)
    {
        setText(input);
        sendthis();
    }
    private static void setText(string input)
    {
        if (input == "Enter" || input == "enter")
        {
            text = "{Enter}";
            return;
        }
        switch (input)
        {
            case "up":
                text = "{UP}";
                break;

            case "down":
                text = "{DOWN}";
                break;

            case "right":
                text = "{RIGHT}";
                break;

            case "left":
                text = "{LEFT}";
                break;
            default:
                text = input;
                break;
        }
    }
    private static void sendthis()
    {
        SendKeys.Send(text);
    }
}