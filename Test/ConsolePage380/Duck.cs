using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage380 {
    enum KindOfDuck {
        Mallard,
        Muscovy,
        Decoy,
    }

    enum SortCriteria {
        SizeThenKind,
        KindThenSize,
    }

    class Duck : Bird , IComparable<Duck> {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare) {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString() {
            return "A " + Size + " inch " + Kind.ToString();
        }
    }

    class DuckComparerBySize : IComparer<Duck> {
        public int Compare(Duck x, Duck y) {
            if (x.Size < y.Size)
                return -1;
            if (x.Size > y.Size)
                return 1;
            return 0;
        }
    }

    class DuckComparerByKind : IComparer<Duck> {
        public int Compare(Duck x, Duck y) {
            if (x.Kind < y.Kind)
                return -1;
            if (x.Kind > y.Kind)
                return 1;
            return 0;
        }
    }

    class DuckComparer : IComparer<Duck> {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y) {
            if(SortBy == SortCriteria.SizeThenKind) {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    return 0;
                }
            }
            else {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    return 0;
                }
            }
        }
    }
}
