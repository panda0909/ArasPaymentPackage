using InnoPayApi.Models;
using InnoPayApi.Repositories.Payment;

namespace InnoPayApi.Repositories.Interfaces
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private ArasContext _context;
        private IPaymentRepository _payment;

        public IPaymentRepository Payments
        {
            get
            {
                if (_payment == null)
                {
                    _payment = new PaymentRepository(_context);
                }
                return _payment;
            }
        }
        public RepositoryWrapper(ArasContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
