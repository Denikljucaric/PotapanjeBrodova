using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class Polje : IEquatable<Polje>
    {
        public readonly int Redak;
        public readonly int Stupac;
        public Polje(int redak, int stupac) {
            Redak = redak;
            Stupac = stupac;
        }

        public bool Equals(Polje other)
        {
            if (other.Redak == Redak && other.Stupac == Stupac) return true;
            return false;
        }
    }
  
}
