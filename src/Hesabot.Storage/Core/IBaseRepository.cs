using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hesabot.Storage.Core {

    public interface IBaseRepository<T, Key> where T: class {

        void Insert(T model);
        Task InsertAsync(T model);

        void Update(T model);
        Task UpdateAsync(T model);

        void Delete(T model);
        Task DeleteAsync(T model);

        T Single(Key id);
        Task<T> SingleAsync(Key id);

        IEnumerable<T> FindAll();
        Task<IEnumerable<T>> FindAllAsync();

        IEnumerable<T> Query(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> predicate);

        T FirstOrDefault(string sql, params object[] args);
        Task<T> FirstOrDefaultAsync(string sql, params object[] args);

        bool Any(string sql, params object[] args);
        Task<bool> AnyAsync(string sql, params object[] args);
    }
}
