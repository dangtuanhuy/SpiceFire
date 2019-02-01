using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceFire.Models.ViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }

        public List<string> SubCategoryList { get; set; }
        //Bắt lỗi SubCategory Tồn Tại nè
        public string StatusMessage { get; set; }
    }
}
