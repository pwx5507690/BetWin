using BW.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BW.Infrastructure;

namespace BW.Respository
{
    public enum OptionType
    {
        Add,
        Update,
        Delete
    }
    public abstract class BaseRespository<T> where T : ISQLDataEnity<T>
    {
        public string _defaultOrderBy;
        public readonly T _sqlDataEnity;
        public BaseRespository(T sqlDataEnity)
        {
            _defaultOrderBy = GetDefaultOrderBy();
            _sqlDataEnity = sqlDataEnity;
        }
        public virtual int AddStr(string item)
        {
            var t = item.DeserializeObject<T>();
            SetItemView(t, OptionType.Add);
            return Add(t);
        }
        public virtual int DeleteStr(string item)
        {
            var t = item.DeserializeObject<T>();
            SetItemView(t, OptionType.Delete);
            return Delete(t);

        }
        public virtual int UpdateStr(string item)
        {
            var t = item.DeserializeObject<T>();
            SetItemView(t, OptionType.Update);
            return Update(t);
        }
        public virtual int Add(T item)
        {
            return _sqlDataEnity.Add(item);
        }
        public virtual int Delete(T item)
        {
            _sqlDataEnity.Add(item);
            return 1;
        }
        public virtual int Update(T item)
        {
            return _sqlDataEnity.Add(item);
        }
        public IEnumerable<T> QueryAll()
        {
            return _sqlDataEnity.Query();
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
        public abstract void SetItemView(T item, OptionType type);
        public abstract string GetDefaultOrderBy();
    }
}
