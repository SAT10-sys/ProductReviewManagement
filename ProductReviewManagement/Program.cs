﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management With Linq");
            Console.WriteLine("Displaying All Products");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="Nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="Bad",isLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="Nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="Nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="Nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="Nice",isLike=true}
            };
            /**foreach(var list in productReviewList)
                Console.WriteLine("ProductID: "+list.ProductID+"\nUserId: "+list.UserID+"\nRating: "+list.Rating+"\nReview: "+list.Review+"\nIsLike: "+list.isLike);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Displaying Best Rated Top 3 Products");
            ProductReviewOperations productReviewOperations = new ProductReviewOperations();
            productReviewOperations.GetTopBestRatedProducts(productReviewList);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Displaying all Products having ID 1, 4 or 9 and rating greater than 3");
            productReviewOperations.GetProductsRatingGreaterThanThreeAndProductID149(productReviewList);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Displaying count of reviews by ID");
            productReviewOperations.GetCountOfReviewsForEachProductID(productReviewList);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Displaying only ProductID and Review");
            productReviewOperations.RetrieveOnlyProductIDAndReview(productReviewList);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Skip Top 5 Records and Display Other Records");
            productReviewOperations.SkipTop5Records(productReviewList);
            */
            Console.WriteLine("Inserting the values in data table and displaying it");
            ProductReviewOperations productReviewOperations = new ProductReviewOperations();
            productReviewOperations.InsertValuesInDataTable(productReviewList);
            Console.WriteLine("Values inserted successfully");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Displaying records with user id 10 and arranged by ratings");
            //productReviewOperations.GetRecordsWithIsLikeValueTrue();
            //productReviewOperations.GetAverageRating();
            //productReviewOperations.GetRecordsWithReviewNice();
            productReviewOperations.GetRecordsWithUserID10();
        }
    }
}
