using System;

namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private string item;

        // Due to the review, I have added a list of room descriptions and items
        private static List<string> roomDescriptions = new List<string>
        {
            "You are in a dark cave. There is a torch on the wall.",
            "You are in a forest. There is a sword on the ground.",
            "You are in a castle. There is a shield on the table."
        };

        private static List<string> roomItems = new List<string>
        {
            "torch",
            "sword",
            "shield"
        };

        // A Constructor to load room attributes 
        public Room() // Due to review, room now loads random descriptions and items
        {
            Random random = new Random();
            this.description = roomDescriptions[random.Next(roomDescriptions.Count)];
            this.item = roomItems[random.Next(roomItems.Count)];
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