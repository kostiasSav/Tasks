using System;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColourfullButtonClass
{
    public class ColourfullButton
    {
        public void ChangeButtonColour(Button сolourfullButton, ComboBox comboBox)
        {
            var brushConverter = new BrushConverter();
            string comboBoxSelectedItemText= ((ComboBoxItem)(comboBox.SelectedItem)).Content.ToString();
            сolourfullButton.Background = (Brush)brushConverter.ConvertFromString(comboBoxSelectedItemText);
        }
    }
}
