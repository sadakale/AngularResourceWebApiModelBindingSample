using System.Collections.Generic;

namespace WebApiSample.Models
{
    public class CriteriaModel
    {
        public IEnumerable<CriteriaCategory> Categories { get; set; }
    }
}