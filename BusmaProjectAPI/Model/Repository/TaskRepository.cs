using BusmaProjectAPI.Data;
using BusmaProjectAPI.Model.Models;
using BusmaProjectAPI.Model.Repository;

namespace BusmaProjectAPI.Model.Repository;
public class TaskRepository : ITaskRepository
{
    private readonly AppDbContext appDbContext;
    public TaskRepository(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }
    public task Add(task task)
    {
        appDbContext.Tasks.Add(task);
        appDbContext.SaveChanges();
        return task;
    }

    public task Delete(int Id)
    {
        var account = appDbContext.Tasks.Find(Id);
        if (account != null)
        {
            appDbContext.Tasks.Remove(account);
            appDbContext.SaveChanges();
        }
        return account;
    }

    public IEnumerable<task> GetAll()
    {
        return appDbContext.Tasks;
    }

    public task GetById(int id)
    {
        return appDbContext.Tasks.Find(id);
    }

    public task Update(task task)
    {
        appDbContext.Tasks.Update(task);
        appDbContext.SaveChanges();
        return task;
    }
}
public interface ITaskRepository
{
    public task Add(task task);
    public task Update(task task);
    public task Delete(int Id);
    public task GetById(int Id);
    public IEnumerable<task> GetAll();
}
