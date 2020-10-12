using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace temptest.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IconTitleTemplate : Grid
    {
        public IconTitleTemplate()
        {
            InitializeComponent();
        }
    }
}