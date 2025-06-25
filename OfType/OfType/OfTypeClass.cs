using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    public class OfTypeClass : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            if(enumerable == null)
            {
                throw new ArgumentNullException("Insserted null IEnumerable. Invalid");
            }
            IEnumerable<T> result = new List<T>();
            foreach(var item in enumerable)
            {
                if(typeof(T).Equals(item.GetType()))
                {
                    result.Append<T>((T)item);
                }
            }
            return result;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable);
        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase;
    }
}
