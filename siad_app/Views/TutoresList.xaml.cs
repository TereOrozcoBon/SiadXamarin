using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using siad_app.ViewModels;

using Xamarin.Forms;

namespace siad_app.Views
{
    public partial class TutoresList : ContentPage
    {
        TutoresViewModel _vm;

        public TutoresList()
        {
            InitializeComponent();

            this.lstTutores.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var tutor = (TutorItemViewModel)e.SelectedItem;

                var tutorDetalleViewModel = new TutorDetailViewModel(tutor);
                var tutorDetalleView = new TutorDetailView(tutorDetalleViewModel);
                this.Navigation.PushAsync(tutorDetalleView);


            };

            _vm = new TutoresViewModel();

            BindingContext = _vm;

            Task.Run(async () =>
                await _vm.Init()
            );
        }
    }
}
