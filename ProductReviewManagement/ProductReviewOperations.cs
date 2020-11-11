using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    public class ProductReviewOperations
    {
        public readonly DataTable productTable = new DataTable();
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
        public void RetrieveOnlyProductIDAndReview(List<ProductReview> productReview)
        {
            var recordedData = from products in productReview select new {products.ProductID, products.Review};
            foreach(var list in recordedData)
                Console.WriteLine(list.ProductID+"--->"+list.Review);
        }
        public void SkipTop5Records(List<ProductReview> productReview)
        {
            var recordedData = (from products in productReview select products).Skip(5);
            foreach(var list in recordedData)
                Console.WriteLine("ProductID: " + list.ProductID + "\nUserId: " + list.UserID + "\nRating: " + list.Rating + "\nReview: " + list.Review + "\nIsLike: " + list.isLike);
        }
        public void InsertValuesInDataTable(List<ProductReview> productReview)
        {
            productTable.Columns.Add("ProductID", typeof(int));
            productTable.Columns.Add("UserID", typeof(int));
            productTable.Columns.Add("Rating", typeof(double));
            productTable.Columns.Add("Reviews", typeof(string));
            productTable.Columns.Add("isLike", typeof(bool));
            foreach (ProductReview product in productReview)
                productTable.Rows.Add(product.ProductID, product.UserID, product.Rating, product.Review, product.isLike);
        }
        public void GetRecordsWithIsLikeValueTrue()
        {
            var recordedData = from products in productTable.AsEnumerable() where products.Field<bool>("isLike") == true select products;
            foreach (var product in recordedData)
                Console.WriteLine("ProductID: " + product.Field<int>("ProductID") + " UserID: " + product.Field<int>("UserID") + " Rating: " + product.Field<double>("Rating") + " Reviews: " + product.Field<string>("Reviews") + " isLike: " + product.Field<bool>("isLike"));
        }
        public void GetAverageRating()
        {
            var recordedData=productTable.AsEnumerable().GroupBy(e => e.Field<int>("ProductID")).Select(x => new { ProductID = x.Key, Average = x.Average(y => y.Field<double>("Rating")) });
            foreach(var list in recordedData)
                Console.WriteLine(list.ProductID+"---->"+list.Average);
        }
        public void GetRecordsWithReviewNice()
        {
            var recordedData = from products in productTable.AsEnumerable() where products.Field<string>("Reviews").ToUpper().Contains("NICE") select products;
            foreach(var product in recordedData)
                Console.WriteLine("ProductID: " + product.Field<int>("ProductID") + " UserID: " + product.Field<int>("UserID") + " Rating: " + product.Field<double>("Rating") + " Reviews: " + product.Field<string>("Reviews") + " isLike: " + product.Field<bool>("isLike"));
        }
    }
}
