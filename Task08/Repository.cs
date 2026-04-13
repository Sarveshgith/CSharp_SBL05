using System.Collections.Generic;

public class Repository<T> : IRepository<T> where T : class
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public void Update(int index, T item)
    {
        if (index >= 0 && index < _items.Count)
        {
            _items[index] = item;
        }
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < _items.Count)
        {
            _items.RemoveAt(index);
        }
    }
}
