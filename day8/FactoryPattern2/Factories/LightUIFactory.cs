public class LightUIFactory : IAbstractUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }
    public IText CreateText()
    {
        return new LightText();
    }
}