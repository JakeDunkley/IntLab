namespace intlab.Tokenization;

public abstract class TokenBase
{
    private string _content;

    public TokenBase(string content)
    {
        _content = content;
    }
}