using System.Collections.Generic;
using RepairsApp.Models;

namespace RepairsApp.Data
{
    /// <summary>
    /// Provides an in-memory data store.
    /// 
    /// Note: The code in this class is not to be considered a "best practice" 
    /// example of how to do data persistence, but rather as workaround for
    /// not having a database to persist data to.
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// The collection of activities.
        /// </summary>
        public static List<Repair> Repairs { get; set; }

        /// <summary>
        /// The collection of entries.
        /// </summary>
        public static List<Entry> Entries { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of activities first
            // so we can reference them when creating the entries collection.
            var activities = new List<Repairs>()
            {
                new Repair(Repair.RepairType.roof),
                new Repair(Repair.RepairType.Biking),
                new Repair(Repair.RepairType.Hiking),
                new Repair(Repair.RepairType.Kayaking),
                new Repair(Repair.RepairType.PokemonGo, "Pokemon Go"),
                new Repair(Repair.RepairType.Running),
                new Repair(Repair.RepairType.Skiing),
                new Repair(Repair.RepairType.Swimming),
                new Repair(Repair.RepairType.Walking),
                new Repair(Repair.RepairType.WeightLifting, "Weight Lifting")
            };

            var entries = new List<Entry>()
            {
                new Entry(1, 2016, 7, 8, Repair.RepairType.Biking, 10.0),
                new Entry(2, 2016, 7, 9, Repair.RepairType.Biking, 12.2),
                new Entry(3, 2016, 7, 10, Repair.RepairType.Hiking, 123.0),
                new Entry(4, 2016, 7, 12, Repair.RepairType.Biking, 10.0),
                new Entry(5, 2016, 7, 13, Repair.RepairType.Walking, 32.2),
                new Entry(6, 2016, 7, 13, Repair.RepairType.Biking, 13.3),
                new Entry(7, 2016, 7, 14, Repair.RepairType.Biking, 10.0),
                new Entry(8, 2016, 7, 15, Repair.RepairType.Walking, 28.6),
 
            };

            Repairs = repairs;
            Entries = entries;
        }
    }
}