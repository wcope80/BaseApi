using BaseApi.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseApi.WebApi.Services.Authentication.Interfaces
{
    public interface IUserContext
    { 
        DbSet<User> Users { get; set; }
    }




}
