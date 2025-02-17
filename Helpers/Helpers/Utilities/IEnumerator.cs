using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Utilities
{
    public interface IEnumerator<TEntity> where TEntity : class
    {
       
    }

    
    public class Enumerator<T> : IEnumerator<T> where T : class
    {

        public static IEnumerable<object> GetValues<T>(IEnumerable<T> items, string propertyName)
        {
            Type type = typeof(T);
            var prop = type.GetProperty(propertyName);
            foreach (var item in items)
                yield return prop.GetValue(item, null);
        }
    }
}
