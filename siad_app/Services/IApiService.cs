using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using siad_app.Models;

namespace siad_app.Services
{
    public interface IApiService
    {
        Task<List<TutoresModel>> GetTutores(string filter = null);

    }
}
