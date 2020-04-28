using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> MenuItemList = new List<IOrderItem>();

        /// <summary>
        /// Constructor that loads all menu items into a list for quicker load times
        /// </summary>
        static Menu()
        {
            foreach(IOrderItem item in CompleteMenu())
            {
                MenuItemList.Add(item);
            }
        } 


        public static string[] ItemType
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// returns an enumerable list of all entree items.
        /// </summary>
        /// <returns>A list of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;
        }

        /// <summary>
        /// Returns an enumerable list of all side items.
        /// </summary>
        /// <returns>A list of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            return sides;
        }

        /// <summary>
        /// Returns an enumerable list of all drink items
        /// </summary>
        /// <returns>a list of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            return drinks;
        }

        /// <summary>
        /// Returns an enumerable list of all menu items
        /// </summary>
        /// <returns>A list of menu items</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());
            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());
            menu.Add(new CowboyCoffee());
            menu.Add(new JerkedSoda());
            menu.Add(new TexasTea());
            menu.Add(new Water());
            return menu;
        }

        /// <summary>
        /// Searches the MenuItemList
        /// </summary>
        /// <param name="terms">Terms to search for</param>
        /// <returns>List of items in search</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return MenuItemList;

            foreach(IOrderItem item in MenuItemList)
            {
                if(item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list for each type
        /// </summary>
        /// <param name="items">List to filter</param>
        /// <param name="types">What to filter</param>
        /// <returns>Filtered list of items</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(item is Entree && types.Contains("Entree"))
                {
                    results.Add(item);
                }
                if(item is Side && types.Contains("Side"))
                {
                    results.Add(item);
                }
                if (item is Drink && types.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given items by Calories
        /// </summary>
        /// <param name="items">Items to filter</param>
        /// <param name="min">Min Filter</param>
        /// <param name="max">Max Filter</param>
        /// <returns>Filtered list of items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();
            
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given items by the price filters
        /// </summary>
        /// <param name="items">Items to filter</param>
        /// <param name="min">Min Price Filter</param>
        /// <param name="max">Max Price Filter</param>
        /// <returns>Filtered list of items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach(IOrderItem item in items)
            {
                if(item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
