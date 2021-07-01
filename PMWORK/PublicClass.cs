using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMWORK
{
    public class PublicClass
    {
        private AppDbContext _db;
        public AppDbContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new AppDbContext();
                    return _db;
                }
                return _db;
            }
            set
            {
                _db = value;
            }

        }

    }
}
