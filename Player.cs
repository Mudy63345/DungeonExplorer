using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        // This is encapsulating the private fields // Minor changes due to review from public to private fields
        private string name;
        private int health;
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
            if (inventory != null) // This check if the player already has an item
            {
                Console.WriteLine("You are already carrying an item. Drop it first.");
                return;
            }

            inventory = item; // This adds the item to the inventory
            Console.WriteLine(item + " has been added to your inventory.");
        }
        
        // This is a method to drop the current item // Minor changes to more consistentcy
        public void DropItem()
        {
            if (inventory != null)
            {
                Console.WriteLine("You're not carrying an item.");
                return;
            }
            Console.WriteLine("You dropped a " + inventory);
            inventory = null;
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