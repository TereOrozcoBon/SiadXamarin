using System;
namespace siad_app.ViewModels
{
    public class TutorDetailViewModel : BaseViewModel
    {
        TutorItemViewModel _Tutor;
        public TutorItemViewModel Tutor
        {
            get { return _Tutor; }
            set
            {
                _Tutor = value;
                RaisePropertyChanged();
            }
        }

        public TutorDetailViewModel(TutorItemViewModel tutor)
        {
            Tutor = tutor;
        }
    }
}
