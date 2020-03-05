using System.Collections.Generic;

namespace Pipedrive
{
    public class OrganizationRelationshipFilters
    {
        public static OrganizationRelationshipFilters None
        {
            get { return new OrganizationRelationshipFilters(); }
        }


        public long? org_id { get; set; }

        public int? StartPage { get; set; }

        public int? PageCount { get; set; }

        public int? PageSize { get; set; }

        public string Sort { get; set; }

        /// <summary>
        /// Get the query parameters that will be appending onto the search
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                var d = new Dictionary<string, string>();
                if (org_id.HasValue)
                {
                    d.Add("org_id", org_id.Value.ToString());
                }

                return d;
            }
        }
    }
}
