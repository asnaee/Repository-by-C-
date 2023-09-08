using ex_0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex_0.Reposetory
{
    public interface Ioprepo
    {
        IEnumerable<Oparetor> GetAll();
        Oparetor GetById(int OparetorId);
        void Insert(Oparetor oparator);
        void Update(Oparetor oparator);
        void Delete(int oparetorId);

    }
}
