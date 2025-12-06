public class DarkUIFactory : IAbstractUIFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }
    public IText CreateText()
    {
        return new DarkText();
    }
}