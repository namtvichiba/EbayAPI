using eBay.Service.Core.Soap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EbayApi.Service
{
    public class EbayItem
    {
        public static GetItemResponseType GetItemRequest(string ItemID)
        {
            eBayAPIInterfaceService service = EbayCall.eBayServiceCall("GetItem");

            GetItemRequestType request = new GetItemRequestType();
            request.ItemID = ItemID;
            request.Version = "965";
            request.IncludeItemSpecifics = true;
            request.DetailLevel = new DetailLevelCodeTypeCollection() { DetailLevelCodeType.ItemReturnDescription };

            GetItemResponseType response = service.GetItem(request);

            //Console.WriteLine("=====================================");
            //Console.WriteLine("Item Iitle - {0}", response.Item.Title);
            //Console.WriteLine("Primary Category: {0}", response.Item.PrimaryCategory.CategoryName);

            //Console.WriteLine("=====================================");

            //Console.WriteLine("ItemID: {0}", response.Item.ItemID);
            //Console.WriteLine("Condition: {0}", response.Item.ConditionDisplayName);
            //Console.WriteLine("=====================================");

            //Console.WriteLine("Variation\n  +  {0}", string.Join("\n  +  ", response.Item.Variations.VariationSpecificsSet.ToArray().Select(x => x.Name + ": " + string.Join("| ", x.Value.ToArray()))));

            //Console.WriteLine("=====================================");

            //Console.WriteLine("Listing Duration: {0}", response.Item.ListingDuration);
            //Console.WriteLine("Start Price: {0} {1}", response.Item.StartPrice.Value, response.Item.Currency);
            //Console.WriteLine("Payment Type[0]: {0}", response.Item.PaymentMethods[0]);
            //Console.WriteLine("PayPal Email Address: {0}", response.Item.PayPalEmailAddress);
            //Console.WriteLine("Postal Code: {0}", response.Item.PostalCode);
            //Console.WriteLine("PictureURL:\n  +  {0}", string.Join("\n  +  ", response.Item.PictureDetails.PictureURL.ToArray()));

            //Console.WriteLine("=====================================");

            //Console.WriteLine("Item specifics\n  +  {0}", string.Join("\n  +  ", response.Item.ItemSpecifics.ToArray().Select(x => x.Name + ": " + string.Join("||", x.Value.ToArray())).ToList()));
            // ...Convert response object to JSON to see all
            return response;
        }
    }
}