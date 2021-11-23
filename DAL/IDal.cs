using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IDal
    {
        IEnumerable<int> GetAllParcelsIDS(Func<IDAL.DO.Parcel,bool> p = null);
        void AddDrone();
        void AddStudent(object degree);
    }
}
