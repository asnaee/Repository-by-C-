using ex_0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_0.Reposetory
{
    public class Oparetorreport : Ioprepo
    {
   
    public void Delete(int oparetorId)
        {
            Oparetor oparetor = DyingOparetorCD.OparList.FirstOrDefault(x => x.OparetorId == oparetorId);
            DyingOparetorCD.OparList.Remove(oparetor);
        }

        public IEnumerable<Oparetor> GetAll()
        {
            return DyingOparetorCD.OparList;
        }

        public Oparetor GetById(int OparetorId)
        {
            Oparetor oparetor = DyingOparetorCD.OparList.FirstOrDefault(x => x.OparetorId == OparetorId);
            return oparetor;
        }

        public void Insert(Oparetor oparator)
        {
            DyingOparetorCD.OparList.Add(oparator);
        }

        public void Update(Oparetor oparator)
        {
            Oparetor _oparator = DyingOparetorCD.OparList.FirstOrDefault(x => x.OparetorId == oparator.OparetorId);
            if (oparator.OparetorName != null)
            {
                _oparator.OparetorName = oparator.OparetorName;
            }
            if (oparator.OparetorAge != 0)
            {
                _oparator.OparetorAge = oparator.OparetorAge;
            }
        }
    }
}
