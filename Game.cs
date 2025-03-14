using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        // This is a constructor to initialize the game
        public Game()
        {
            // Initialize the game with one room and one player
            player = new Player("Steve", 100);

            // Initialize the room with a name and description (uses constructor from Room.cs)
            currentRoom = new Room();
        }

        // This is the method to start the game
        public void Start()
        {
            Console.WriteLine("Welcome to the game, Dungeon Explorer!");
            Console.WriteLine(">>Press any key to start the game<<");
            bool playing = true;
            
            while (playing)
            {
                try
                {
                    // Shows the room description
                    Console.WriteLine(currentRoom.GetDescription());

                    // Shows the player status
                    player.ShowStatus();

                    // Asks the player what they want to do
                    Console.WriteLine(@"What would you like to do?
                    1. Pick up item
                    2. Drop item
                    3. Quit game
                    Enter your choice");
                    
                    string choice = Console.ReadLine();

                    // This handles player's input choice
                    switch (choice)
                    {
                        case "1":
                            string item = currentRoom.GetItem();
                            if (item != null) // This checks if the item is picked up
                            {
                                player.PickUpItem(item);
                                currentRoom.ItemRemove(); // This removes the item from the room after it's picked up
                            }
                            else // Basic error handling
                            {
                                Console.WriteLine("There is no item to pick up in this room.");
                            }
                            break;
                        case "2":
                            player.DropItem();
                            break;
                        case "3":
                            playing = false;
                            Console.WriteLine("Thank you for playing Dungeon Explorer!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex) // This change due to review, catches any errors that occur during the game
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}