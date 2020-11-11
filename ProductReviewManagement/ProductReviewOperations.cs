using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class ProductReviewOperations
    {
        public void GetTopBestRatedProducts(List<ProductReview> productReview)
        {
            var recordedData = (from products in productReview orderby products.Rating descending select products).Take(3);
            foreach(var list in recordedData)
                Console.WriteLine("ProductID: " + list.ProductID + "\nUserId: " + list.UserID + "\nRating: " + list.Rating + "\nReview: " + list.Review + "\nIsLike: " + list.isLike);
        }
    }
}
