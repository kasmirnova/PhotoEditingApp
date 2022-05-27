using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YearCursWork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Redaction : ContentPage
    {
        public Redaction()
        {
            InitializeComponent();
        }
        public Redaction(ImageSource source)
        {
            ImgEditor.Source = source;
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
                OpenImageEditor(_imageSource);
            }
        }

        void OpenImageEditor(ImageSource imageSource)
        {
            ImgEditor.Source = imageSource;
        }
    }
}