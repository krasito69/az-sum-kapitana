using Fireman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireman.Controller
{
    public class FiremanController
    {
        public List<Fireman.Model.Fireman> GetFireman()
        {
            using (FiremenDBEntities f = new FiremenDBEntities())
            {
                return f.Firemen.ToList();
            }
        }

        public void InsertFireman(Fireman.Model.Fireman fireman)
        {
            using (FiremenDBEntities f = new FiremenDBEntities())
            {
                fireman.Id = f.Firemen.Count() + 1;
                f.Firemen.Add(fireman);
                f.SaveChanges();
            }
        }

        public List<Fireman.Model.Fireman> OrderByIncident()
        {
            using (FiremenDBEntities fm = new FiremenDBEntities())
            {
                return fm.Firemen.OrderByDescending(f => f.IncidentsPartiicipated).ToList();
            }
        }

    }
}
