﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace PowerPointLabs.Converters
{
    class selectedColorToAnalogousLower : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, -30.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class selectedColorToAnalogousHigher : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 30.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class selectedColorToComplementaryColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 180.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToSplitComplementaryLower : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 150.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToSplitComplementaryHigher : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 210.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToTriadicLower : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, -120.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToTriadicHigher : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 120.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToTetradicOne : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 90.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToTetradicTwo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 180.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class selectedColorToTetradicThree : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.GetColorShiftedByAngle(selectedColor, 270.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticOne : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255, 
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.80f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticTwo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.70f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticThree : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.60f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticFour : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.50f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticFive : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.40f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticSix : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.30f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToMonochromaticSeven : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return ColorHelper.ColorFromAhsb(
                255,
                selectedColor.GetHue(),
                selectedColor.GetSaturation(),
                0.20f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class selectedColorToBrightnessValue : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return (int)(selectedColor.GetBrightness() * 240.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class selectedColorToSaturationValue : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color selectedColor = (Color)value;
            return (int)(selectedColor.GetSaturation() * 240.0f);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}