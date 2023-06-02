using InnoPayApi.Models;
using InnoPayApi.Repositories.Interfaces;

namespace InnoPayApi.Repositories.Payment
{
    public interface IPaymentRepository:IBaseRepository<InUserPayment>
    {
        IEnumerable<InUserPayment> GetOrgPayment(string org_name);
    }
}
