﻿using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using NPoco;

namespace Hesabot.Storage.Core {
    
    public abstract class BaseRepository<T, Key>: IDisposable, IBaseRepository<T, Key> where T: class {

        private readonly IDatabase _db;

        public BaseRepository(IDatabase db)
            => _db = db ?? throw new ArgumentNullException(nameof(db));

        public void Insert(T model) => _db.Insert(model);

        public async Task InsertAsync(T model)
            => await _db.InsertAsync(model).ConfigureAwait(false);
        
        public void Update(T model) => _db.Update(model);

        public async Task UpdateAsync(T model)
            => await _db.UpdateAsync(model).ConfigureAwait(false);

        public void Delete(T model) => _db.Delete(model);

        public async Task DeleteAsync(T model)
            => await _db.DeleteAsync(model).ConfigureAwait(false);

        public T Single(Key id) => _db.SingleOrDefaultById<T>(id);

        public async Task<T> SingleAsync(Key id)
            => await _db.SingleOrDefaultByIdAsync<T>(id).ConfigureAwait(false);

        public IEnumerable<T> FindAll() => _db.Fetch<T>().ToList();

        public async Task<IEnumerable<T>> FindAllAsync()
            => await _db.FetchAsync<T>().ConfigureAwait(false);

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicate)
            => _db.Query<T>().Where(predicate).ToList();

        public async Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> predicate)
            => await _db.QueryAsync<T>().Where(predicate).ToList().ConfigureAwait(false);

        public T FirstOrDefault(string sql, params object[] args)
            => _db.FirstOrDefault<T>(sql, args);

        public async Task<T> FirstOrDefaultAsync(string sql, params object[] args)
            => await _db.FirstOrDefaultAsync<T>(sql, args).ConfigureAwait(false);

        public bool Any(string sql, params object[] args)
            => _db.ExecuteScalar<int>(sql, args) > 0;

        public async Task<bool> AnyAsync(string sql, params object[] args) 
            => await _db.ExecuteScalarAsync<int>(sql, args).ConfigureAwait(false) > 0;

        public void Dispose() {
            if (_db.Connection.State == ConnectionState.Open)
                _db.Connection.Close();
            _db?.Dispose();
        }
    }
}
