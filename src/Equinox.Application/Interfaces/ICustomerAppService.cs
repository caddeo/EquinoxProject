using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Equinox.Application.EventSourcedNormalizers;
using Equinox.Application.ViewModels;

namespace Equinox.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        Task<CustomerViewModel> GetById(Guid id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid id);
        IList<CustomerHistoryData> GetAllHistory(Guid id);
    }
}
