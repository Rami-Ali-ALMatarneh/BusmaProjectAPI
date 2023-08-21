using BusmaProjectAPI.Data;
using BusmaProjectAPI.Model.Models.Accounts;
using BusmaProjectAPI.Model.Repository;

namespace BusmaProjectAPI.Model.Repository;
public class UserRepository : IUserRepository
{
    private readonly AppDbContext appDbContext;
    public UserRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }
    public User Add(User user)
    {
        appDbContext.Users.Add(user);
        appDbContext.SaveChanges();
        return user;
    }

    public User Delete(int Id)
    {
        var account = appDbContext.Users.Find(Id);
        if (account != null)
        {
            appDbContext.Users.Remove(account);
            appDbContext.SaveChanges();
        }
        return account;
    }

    public IEnumerable<User> GetAll()
    {
        return appDbContext.Users;
    }

    public User GetById(int id)
    {
        return appDbContext.Users.Find(id);
    }

    public User Update(User user)
    {
        appDbContext.Users.Update(user);
        appDbContext.SaveChanges();
        return user;
    }
}

public interface IUserRepository
{
    public User Add(User user);
    public User Update(User user);
    public User Delete(int Id);
    public User GetById(int id);
    public IEnumerable<User> GetAll();

}


