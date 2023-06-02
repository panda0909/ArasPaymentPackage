using InnoPayApi.Models;
using InnoPayApi.Repositories.Interfaces;
using Innovator.Client.Model;

namespace InnoPayApi.Repositories.Payment
{
    public class PaymentRepository : BaseRepository<InUserPayment>, IPaymentRepository
    {
        public PaymentRepository(ArasContext context) : base(context)
        {

        }

        public IEnumerable<InUserPayment> GetOrgPayment(string org_name)
        {
            return  _context.InUserPayments.Where(p=>p.InCurrentOrg == org_name).ToList();
        }
    }
}
