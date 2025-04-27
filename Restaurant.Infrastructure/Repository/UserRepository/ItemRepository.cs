using Dapper;

using Restaurant.Domain.Models.UserModels.ItemModel;
using Restaurant.Domain.Interface.User;
using System.Data;

using System.Diagnostics;
using Restaurant.Application.Service.User.Items;


namespace Restaurant.Infrastructure.Repository.UserRepository
{
    public class ItemRepository : IItemRepository
    {
        private readonly IDbConnection dbConnection;
        public ItemRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
            public async Task<Item?> GetItemById(int id)
            {
                try
                {
                    var query = $"select ItemId, CategoryId, Title ,Description ,Image ,isAvailable from Items where ItemId= @Id";
                return await dbConnection.QueryFirstAsync<Item>(query, new { Id = id });
                
                
                }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
            }

        public async Task<IEnumerable<Item>> GetItemsUser()
        {
            try
            {
                var query = "select ItemId, CategoryId ,Title ,Description ,Image ,isAvailable from Items ";
                var items = await dbConnection.QueryAsync<Item>(query);
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
