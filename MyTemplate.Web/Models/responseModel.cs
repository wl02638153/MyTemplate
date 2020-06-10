using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTemplate.Web.Models
{
    public class responseModel<T>
    {
        public bool isSuccess { get; set; }
        public T data { get; set; }
        public Paginate paginate { get; set; }

        public string message { get; set; }
    }
    public class Data<T>
    {
        public T viewData { get; set; }
        public int Total { get; set; }
    }
    public class Paginate
    {
        public int Page { get; set; }
        public int PageConut { get; set; }
        public int Size { get; set; }
        public int Total { get; set; }
    }
}
