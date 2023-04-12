using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjects.DataAccess.Repository.IRepository
{
    //since it is generic reposiory
    //specify interface purpose
    internal interface IRepository<C> where C : class 
    {
    }
}
