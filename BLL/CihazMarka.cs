using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CihazMarka
    {
        public class SinifBL : IDisposable
        {
            AracDbContext ctx = new AracDbContext();

            public void Dispose()
            {
                ((IDisposable)ctx).Dispose();
            }

            public bool Ekle(Arac a)
            {
                ctx.Arac.Add(a);
                return ctx.SaveChanges() > 0;
            }
        }
}
