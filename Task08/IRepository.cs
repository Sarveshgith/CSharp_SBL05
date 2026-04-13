using System.Collections.Generic;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    void Update(int index, T item);
    void Delete(int index);
}