using TeamOn.Domain.Contracts.Commands;
using TeamOn.Domain.Humor.Entities;
using TeamOn.Domain.Humor.Repositories;
using TeamOn.Domain.Infra.Contexts;

namespace TeamOn.Domain.Infra.Repositories.Humor
{
    public class HumorRepository : IHumorRepository
    {
        private HumorContext _dataContext;
        public HumorRepository(HumorContext dataContext)
            => _dataContext = dataContext;

        public void SendTodaysHumor(HumorEntity humor, string refUser)
        {
            _dataContext.Add(humor);
            _dataContext.SaveChanges();
        }
    }
}