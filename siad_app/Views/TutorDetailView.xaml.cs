using System;
using System.Collections.Generic;
using Xamarin.Forms;
using siad_app.ViewModels;

namespace siad_app.Views
{
    public partial class TutorDetailView : ContentPage
    {
        public TutorDetailView(TutorDetailViewModel tutorDetalleViewModel)
        {
            InitializeComponent();

            this.BindingContext = tutorDetalleViewModel; //se hace el enlace delavista modelo a esta vista
        } 
    }
}
