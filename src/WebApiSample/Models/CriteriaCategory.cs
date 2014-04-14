using System.Collections.Generic;

namespace WebApiSample.Models
{
    public class CriteriaCategory
    {
        public string Name { get; set; }
        public IEnumerable<CriteriaOption> Options { get; set; }
    }
}