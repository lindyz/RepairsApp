namespace RepairsApp.Models
{
    /// <summary>
    /// Repairs.
    /// </summary>
    public class Repair
    {
        /// <summary>
        /// This is the list of the repairs
        /// </summary>
        public enum RepairType
        {
            Lights = 1,
            Tires = 2,
            Floor = 3,
            Roof = 4,
            Brakes = 5,
            Bumper = 6,
            LicensePlate = 7,
            Undercarriage = 8,
            Pins = 9,
            NoRepair = 10
        }

        /// <summary>
        /// Constructors an activity for the provided activity type and name.
        /// </summary>
        /// <param name="activityType">The activity type for the activity.</param>
        /// <param name="name">The name for the activity.</param>
        public Repair(RepairType repairType, string name = null)
        {
            Id = (int)repairType;

            // If we don't have a name argument, 
            // then use the string representation of the activity type for the name.
            Name = name ?? repairType.ToString();
        }

        /// <summary>
        /// The ID of the activity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string Name { get; set; }
    }
}