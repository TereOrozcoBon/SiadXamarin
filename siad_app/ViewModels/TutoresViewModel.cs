using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using siad_app.Services;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq;
using siad_app.Views;

namespace siad_app.ViewModels
{
    public class TutoresViewModel : BaseViewModel
    {
        readonly IApiService _service;
        List<TutorItemViewModel> _TutorList;
        String _SearchText;
        ICommand _SearchByName;
        //ICommand _AllTutores;
        //public List<TutorItemViewModel> TutoresList { get; set; }


        public TutoresViewModel(IApiService service = null)
        {
            _service = service ?? DependencyService.Get<IApiService>();
        }

        public async Task Init()
        {
            await LoadData();

        }


        //GET SET:

        public List<TutorItemViewModel> TutorList
        {
            get
            {
                return _TutorList;
            }
            set
            {
                _TutorList = value;
                RaisePropertyChanged();
            }
        }



        public string SearchText
        {
            get
            {
                return _SearchText;
            }
            set
            {
                _SearchText = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SearchByName
        {
            get
            {
                return _SearchByName ?? (_SearchByName = new Command(
                    async () => await ExecuteSearchByNameCommand()

                    ));
            }
        }



        public ICommand AllTutores
        {
            get
            {
                return new Command(
                 async () => await ExecuteSearchAllTutores()
               );
            }
        }



        //TASKS (llamadas a API):

        async Task LoadData(string filter = null)
        {
            IsBusy = true;

            var result = await _service.GetTutores(filter);

            if (result != null)
            {
                TutorList = (from p in result
                             select new TutorItemViewModel
                               {
                                   Id = p.Id,
                                   Nombre = p.Nombre,
                                   Correo = p.Correo,
                                   Avatar = p.Avatar
                               }
                ).ToList();
            }



            IsBusy = false;
        }


       



     

        async Task ExecuteSearchByNameCommand()
        {
            await LoadData(SearchText);
        }








        async Task ExecuteSearchAllTutores() //reutilizar!!! en ExecuteSearchByNameCommand sin filtro
        {
            this.SearchText = String.Empty;
            await LoadData();
        }

    }


}
