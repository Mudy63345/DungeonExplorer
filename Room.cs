namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private string item;

        // A Constructor to load room attributes
        public Room(string description, string item = null)
        {
            this.description = description;
            this.item = item;
        }

        // A method to get the room's description
        public string GetDescription()
        {
            return description;
        }

        // A method to check if the room has an item
        public string GetItem()
        {
            return item;
        }

        // A method to remove an item from the room after it's picked up
        public void ItemRemove()
        {
            item = null;
        }
    }
}