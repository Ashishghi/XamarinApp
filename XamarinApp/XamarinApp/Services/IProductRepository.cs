using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinApp.Model;

namespace XamarinApp.Services
{
	public interface IProductRepository
	{
		Task<bool> AddproductAsync(ProductInfo productInfo);

        Task<bool> UpdateproductAsync(ProductInfo productInfo);

        Task<bool> DeleteproductAsync(int id);

        Task<ProductInfo> GetProductAsync(int id);

        Task<IEnumerable<ProductInfo>> GetProductAsync();
    }
}

