using EbayApi.Service;
using System.Web.Http;

namespace EbayApi.Controllers
{
    public class EbayUsController : ApiController
    {
        public IHttpActionResult GetItem(string ItemId)
        {
            var res = EbayItem.GetItemRequest(ItemId);
            return Json(res);
        }
    }
}