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
        public void GetProductsRatingGreaterThanThreeAndProductID149(List<ProductReview> productReview)
        {
            var recordedData = from products in productReview where (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9) && products.Rating > 3 select products;
            foreach(var list in recordedData)
                Console.WriteLine("ProductID: " + list.ProductID + "\nUserId: " + list.UserID + "\nRating: " + list.Rating + "\nReview: " + list.Review + "\nIsLike: " + list.isLike);
        }
        public void GetCountOfReviewsForEachProductID(List<ProductReview> productReview)
        {
            var recordedData = productReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach(var list in recordedData)
                Console.WriteLine(list.ProductID+"-->"+list.Count);
        }
    }
}
