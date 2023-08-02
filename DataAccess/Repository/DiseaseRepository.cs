using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class DiseaseRepository : ClinicBaseRepository<Disease>
    {
        protected override Expression<Func<Disease, bool>> GetSearchAnythingExpression(string searchText)
        {
            return b => b.DiseaseName.ToLower().Contains(searchText);
        }

    }
}
