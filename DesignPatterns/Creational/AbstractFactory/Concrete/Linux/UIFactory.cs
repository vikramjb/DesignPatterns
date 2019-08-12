using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.Linux
{
    public class UIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new UIButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new UICheckBox();
        }

        public IRadioButton CreateRadioButton()
        {
            return new UIRadioButton();
        }

        public ITextBox CreateTextBox()
        {
            return new UITextBox();
        }
    }
}
