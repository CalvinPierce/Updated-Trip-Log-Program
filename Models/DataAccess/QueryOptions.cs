using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Lab11.Models.DataAccess
{
    public class QueryOptions<T>
    {
        public Expression<Func<T, Object>> Orderby { get; set; }

        public Expression<Func<T, bool>> Where { get; set; }

        private string[] includes;

        public string Includes
        {
            set => includes = value.Replace(" ", ",").Split(",");
        }

        public string[] GetIncludes() => includes ?? new string[0];

        public bool HasWhere => Where != null;

        public bool HasOrderBy => Orderby != null;
    }
}
