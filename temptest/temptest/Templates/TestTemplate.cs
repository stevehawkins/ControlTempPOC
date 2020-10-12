using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace temptest.Templates
{
    public class TestControl :  Frame
    {
        static readonly ControlTemplate iconTitleSubRightTemplate = new ControlTemplate(typeof(IconTitleSubRightTemplate));
        static readonly ControlTemplate iconTitleSubTemplate = new ControlTemplate(typeof(IconTitleSubTemplate));
        static readonly ControlTemplate iconTitleTemplate = new ControlTemplate(typeof(IconTitleTemplate));
        static readonly ControlTemplate titleTemplate = new ControlTemplate(typeof(TitleTemplate));

        public TestControl()
        {
            Padding = new Thickness(10);
            CornerRadius = 10;
        }

        public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon),
            typeof(ImageSource), typeof(TestControl), propertyChanged: OnPropChanged);

        public static BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
            typeof(string),typeof(TestControl),propertyChanged: OnPropChanged);

        public static BindableProperty SubTitleProperty = BindableProperty.Create(nameof(SubTitle),
            typeof(string),typeof(TestControl),propertyChanged: OnPropChanged);

        public static BindableProperty RightTextProperty = BindableProperty.Create(nameof(RightText),
            typeof(string),typeof(TestControl),propertyChanged: OnPropChanged);
        
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string SubTitle
        {
            get { return (string)GetValue(SubTitleProperty); }
            set { SetValue(SubTitleProperty, value); }
        }

        public string RightText
        {
            get { return (string)GetValue(RightTextProperty); }
            set { SetValue(RightTextProperty, value); }
        }

        private static void OnPropChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is TestControl ctrl)) return;

            // could be done more elegant but this is just a test
            if (ctrl.Icon != null
                && !string.IsNullOrEmpty(ctrl.Title)
                && !string.IsNullOrEmpty(ctrl.SubTitle)
                && !string.IsNullOrEmpty(ctrl.RightText))
            {
                ctrl.ControlTemplate = iconTitleSubRightTemplate;
            }
            else if (ctrl.Icon != null
                && !string.IsNullOrEmpty(ctrl.Title)
                && !string.IsNullOrEmpty(ctrl.SubTitle))
            {
                ctrl.ControlTemplate = iconTitleSubTemplate;
            }
            else if (ctrl.Icon != null
                     && !string.IsNullOrEmpty(ctrl.Title))
            {
                ctrl.ControlTemplate = iconTitleTemplate;
            }
            else if (!string.IsNullOrEmpty(ctrl.Title))
            {
                ctrl.ControlTemplate = titleTemplate;
            }

        }
    }
}
