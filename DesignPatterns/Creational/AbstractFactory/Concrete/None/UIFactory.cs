using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.None
{
    internal class UIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new NoneControl();
        }

        public ICheckBox CreateCheckBox()
        {
            return new NoneControl();
        }

        public IRadioButton CreateRadioButton()
        {
            return new NoneControl();
        }

        public ITextBox CreateTextBox()
        {
            return new NoneControl();
        }
    }
}
