using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleApp.Core.Domain;

namespace SampleApp.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id); 
        Task<IEnumerable<User>> BrowseAsync(string firstName = "", string lastName = "");
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);      
    }
}