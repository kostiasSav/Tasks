using System;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;
using NameSpaceClassInIncludedFile;

namespace ColourfullButton
{
    public class ColourfullButton
    {
        public void ChangeButtonColour()
        {
            var brushConverter = new BrushConverter();
            ColourfullButton.Background = (Brush)brushConverter.ConvertFromString(comboBox.Text);
        }
    }
}
