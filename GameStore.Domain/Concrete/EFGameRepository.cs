using System.Collections.Generic;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Concrete
{
    public class EFGameRepository:IGameRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games => context.Games;
    }
}
