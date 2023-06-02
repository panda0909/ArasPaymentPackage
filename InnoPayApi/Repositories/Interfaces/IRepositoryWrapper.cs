using InnoPayApi.Repositories.Payment;

namespace InnoPayApi.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IPaymentRepository Payments { get; }
        void Save();
    }
}
