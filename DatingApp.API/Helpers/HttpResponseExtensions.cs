using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DatingApp.API.Helpers
{
    public static class HttpResponseExtensions
    {
        public static void AddPagination(this HttpResponse httpResponse, int currentPage, int itemsPerPage, int totalItems, int totalPages) 
        {
            PaginationHeader paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            httpResponse.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            httpResponse.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}