using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        // This is encapsulating the private fields
        public string name;
        public int health;
        private string inventory; // Basic, one item inventory

        // This is the constructor to load player attributes
        public Player(string name, int health) 
        {
            this.name = name;
            this.health = health;
            this.inventory = null; // Loads the inventory as empty
        }

        // This is the method to access encapsulated fields
        public string Name { get { return name; } }
        public int Health { get { return health; } }

        // This is a method to pick up items to the inventory
        public void PickUpItem(string item)
        {
            if (string.IsNullOrEmpty(item)) // Simple error handling
            {
                Console.WriteLine("Nothing to pick up here.");
                return;
            }

            if (inventory != null) // This checks if the player already has an item
            {
                Console.WriteLine("You are already holding an item. Drop it first to pick up something else.");
                return;
            }

            inventory = item; // This adds the item to the inventory
            Console.WriteLine(item + " has been added to your inventory.");
        }
        
        // This is a method to drop the current item
        public void DropItem()
        {
            if (inventory != null)
            {
                Console.WriteLine("You dropped the " + inventory + ".");
                inventory = null; // This removes the item from the inventory
            }
            else
            {
                Console.WriteLine("You are not carrying anything.");
            }
        }
        
        // This displays the player status (name, health and inventory)
        public void ShowStatus()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Inventory: " + (inventory ?? "Empty")); //This checks if the inventory is empty
        }
    }
}