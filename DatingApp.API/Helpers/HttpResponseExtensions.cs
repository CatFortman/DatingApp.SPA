using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DatingApp.API.Helpers
{
    public static class HttpResponseExtensions
    {
        public static void AddPagination(this HttpResponse httpResponse, int currentPage, int itemsPerPage, int totalItems, int totalPages) 
        {
            PaginationHeader paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);

            JsonSerializerSettings camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            httpResponse.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
            httpResponse.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}