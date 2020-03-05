using Newtonsoft.Json;
using Pipedrive.CustomFields;
using Pipedrive.Internal;

namespace Pipedrive
{
    public class OrganizationRelationship
    {
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonIgnore]
        [JsonProperty("org_id")]
        public long org_id { get; set; }

        [JsonProperty("rel_owner_org_id")]
        public OrganizationRelationshipProperty rel_owner_org_id { get; set; }

        [JsonProperty("rel_linked_org_id")]
        public OrganizationRelationshipProperty rel_linked_org_id { get; set; }
    }

    public class OrganizationRelationshipProperty
    {
        public string name { get; set; }

        public int value { get; set; }
    }

    public class OrganizationRelationshipCreate
    {
        [JsonIgnore]
        [JsonProperty("org_id")]
        public long org_id { get; set; }

        [JsonProperty("rel_owner_org_id")]
        public long rel_owner_org_id { get; set; }

        [JsonProperty("rel_linked_org_id")]
        public long rel_linked_org_id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
