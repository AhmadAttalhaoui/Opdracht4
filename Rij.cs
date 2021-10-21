using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Opdracht4
{
    internal class Rij<T>
    {
        List<T> lijst = new List<T>();

        public void addLijst(T add)
        {
            lijst.Add(add);
        }

        public T RemoveLijst()
        {
            if (lijst.Count == 0)
                throw new StackOverflowException();
            T del = lijst[0];
            lijst.RemoveAt(0);
            return del;
        }

        public T Toon(T iets)
        {
            if (lijst.Contains(iets))
            {
                return iets;
            }
            else
            {
                return lijst[0];
            }
        }

        public void Delete(T deleteAll)
        {
            lijst.Clear();
        }

        public override string? ToString()
        {
            return String.Join(",", lijst);
        }

        public bool isAanwezig(T iets)
        {
            if (lijst.Contains(iets))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T>? Copy(List<T> stapel)
        {
            List<T> Tweedelijst = new List<T>();
            foreach (T add in stapel)
            {
                Tweedelijst.Add(add);
            }
            return Tweedelijst;
        }

        public static implicit operator Rij<T>(Timer v)
        {
            throw new NotImplementedException();
        }
    }
}
