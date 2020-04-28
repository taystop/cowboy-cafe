using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// A list of current menu items
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }

        /// <summary>
        /// Current search terms
        /// </summary>
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered Item Types
        /// </summary>
        public string[] ItemType { get; set; }

        /// <summary>
        /// Min Calories filter
        /// </summary>
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Max Calories filter
        /// </summary>
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Min Price filter
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Max Price filter
        /// </summary>
        public double? PriceMax { get; set; }


        public void OnGet(double? CaloriesMin, double? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            SearchTerms = Request.Query["SearchTerms"];
            ItemType = Request.Query["ItemType"];

            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByType(MenuItems, ItemType);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
