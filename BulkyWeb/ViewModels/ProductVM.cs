using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyWeb.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
