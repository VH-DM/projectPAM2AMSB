using System.Collections.Generic;
public interface IRepositoryBase<T> {
void Add(T entity);
List<T> GetAll();
void SendMail();
}