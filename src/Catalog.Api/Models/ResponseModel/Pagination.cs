namespace Catalog.Api.Models.ResponseModel
{
    public sealed class Pagination
    {
        /// <summary>
        /// Total number of items in the result set.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Total number of items in the collection response.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The amount of items returned in the collection per page, controlled by the limit parameter.
        /// </summary>
        public int PerPage { get; set; }

        /// <summary>
        /// The page you are currently on within the collection.
        /// <example>
        ///  Example: 1
        /// </example>
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages in the collection.
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Link to the previous page returned in the response.
        /// </summary>
        public string Previous { get; set; } = string.Empty;

        /// <summary>
        /// Link to the current page returned in the response.
        /// <example>
        /// Example: ?page=1&amp;limit=50
        /// </example> 
        /// </summary>
        public string Current { get; set; } = string.Empty;

        /// <summary>
        /// Link to the next page returned in the response.
        /// </summary>
        public string Next { get; set; } = string.Empty;
    }
}
