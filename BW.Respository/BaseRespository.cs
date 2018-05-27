using BW.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BW.Infrastructure;

namespace BW.Respository
{
    public abstract class BaseRespository<T> where T : ISQLDataEnity<T>
    {
        public string _defaultOrderBy;
        public readonly T _sqlDataEnity;
        public BaseRespository(T sqlDataEnity)
        {
            _defaultOrderBy = GetDefaultOrderBy();
               _sqlDataEnity = sqlDataEnity;
        }
        public virtual int Add(string item)
        {
            return _sqlDataEnity.Add(item.DeserializeObject<T>());
        }
        public virtual void Delete(string item)
        {
            _sqlDataEnity.Add(item.DeserializeObject<T>());
        }
        public virtual int Update(string item)
        {
            return _sqlDataEnity.Add(item.DeserializeObject<T>());
        }
        public virtual int Add(T item)
        {
            return _sqlDataEnity.Add(item);
        }
        public virtual void Delete(T item)
        {
             _sqlDataEnity.Add(item);
        }
        public virtual int Update(T item)
        {
            return _sqlDataEnity.Add(item);
        }
        public SQLPage<T> Query(int pageSize, int currentPage, string expression = null)
        {
            if (string.IsNullOrEmpty(expression))
                return _sqlDataEnity.Query(pageSize, currentPage);

            var condition = new SQLCondition();
            _defaultOrderBy = _defaultOrderBy ?? "";
            condition.Expression = $"where {expression} {_defaultOrderBy}";
            return _sqlDataEnity.Query(pageSize, currentPage, condition);
        }
        public abstract string GetDefaultOrderBy();
    }
}
