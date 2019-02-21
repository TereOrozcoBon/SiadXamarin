using System;
namespace siad_app.ViewModels
{
    public class TutorItemViewModel : BaseViewModel
    {
        public TutorItemViewModel()
        {
        }

        string _Id;
        int _IdEmpleado;
        string _Nombre;
        string _Correo;
        string _Avatar;


        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                RaisePropertyChanged();
            }
        }

        public int IdEmpleado
        {
            get { return _IdEmpleado; }
            set
            {
                _IdEmpleado = value;
                RaisePropertyChanged();
            }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                RaisePropertyChanged();
            }
        }

        public string Correo
        {
            get { return _Correo; }
            set
            {
                _Correo = value;
                RaisePropertyChanged();
            }
        }


        public string Avatar
        {
            get { return _Avatar; }
            set
            {
                _Avatar = value;
                RaisePropertyChanged();
            }
        }
    }
}
