using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        IEnumerable<Database.Korisnici> Get();
        //Korisnici GetById(int id);
    }
}
