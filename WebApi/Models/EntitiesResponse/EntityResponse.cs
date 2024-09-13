using NPOI.SS.Formula.Functions;

namespace WebApi.Models.EntitiesResponse
{
    public class EntityResponse<T> where T : class
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<T> Items { get; set; }
    }
}
