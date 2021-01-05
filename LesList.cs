using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GereBanque
{
    [Serializable]
    class LesList
    {
       public static List<Compte> comptes = new List<Compte>();
       public static List<Client> clients = new List<Client>();
    }
}
