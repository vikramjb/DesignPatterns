namespace DesignPatterns.Creational.AbstractFactory.Interface
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        IRadioButton CreateRadioButton();
        ICheckBox CreateCheckBox();
    }
}
