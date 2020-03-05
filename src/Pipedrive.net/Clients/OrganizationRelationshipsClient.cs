using System.Collections.Generic;
using System.Threading.Tasks;
using Pipedrive.Helpers;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Organization API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/OrganizationRelationships">Organization relationship API documentation</a> for more information.
    public class OrganizationRelationshipsClient : ApiClient, IOrganizationRelationshipsClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRelationshipsClient"/> class.
        /// Initializes a new Organization Relationship API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public OrganizationRelationshipsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<OrganizationRelationship>> GetAll(OrganizationRelationshipFilters filters)
        {
            Ensure.ArgumentNotNull(filters, nameof(filters));

            var parameters = filters.Parameters;
            var options = new ApiOptions
            {
                StartPage = filters.StartPage,
                PageCount = filters.PageCount,
                PageSize = filters.PageSize
            };

            return ApiConnection.GetAll<OrganizationRelationship>(ApiUrls.OrganizationRelationships(), parameters, options);
        }

        public Task<OrganizationRelationship> Get(long id)
        {
            return ApiConnection.Get<OrganizationRelationship>(ApiUrls.OrganizationRelationship(id));
        }

        public Task<OrganizationRelationship> Create(OrganizationRelationshipCreate data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<OrganizationRelationship>(ApiUrls.OrganizationRelationships(), data);
        }

        public Task<OrganizationRelationship> Edit(long id, OrganizationUpdate data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Put<OrganizationRelationship>(ApiUrls.OrganizationRelationship(id), data);
        }

        public Task Delete(long id)
        {
            return ApiConnection.Delete(ApiUrls.OrganizationRelationship(id));
        }
    }
}
