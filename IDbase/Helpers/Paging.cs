using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Text;

namespace IDbase.Helpers
{
    public static class Paging
    {
        public static MvcHtmlString PagingNavigator(this HtmlHelper Helper, int PageNum, int ItemsCount, int PageSize)
        {
            StringBuilder sb = new StringBuilder();

            if (PageNum > 0)
            {
                sb.Append(Helper.ActionLink("Назад", "Index", new { PageNum = PageNum - 1 }));
            }

            int PagesCount = ItemsCount / PageSize;

            if (PageNum < PagesCount-1)
            {
                sb.Append(Helper.ActionLink("Вперед", "Index", new { PageNum = PageNum + 1 }));
            }
            


            return MvcHtmlString.Create(sb.ToString());
        }
    }
}