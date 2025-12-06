// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IAbstractUIFactory factory = new DarkUIFactory();
IButton btn = factory.CreateButton();
btn.Render();

IText text = factory.CreateText();
text.Render();


IAbstractUIFactory factory2 = new LightUIFactory();
IButton btn2 = factory2.CreateButton();
btn2.Render();

IText text2 = factory2.CreateText();
text2.Render();

