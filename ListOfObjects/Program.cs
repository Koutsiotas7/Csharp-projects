using System;
using System.Collections.Generic; // For lists

namespace MyFirstProgram
{
class Program
    {
static void Main(string[] args)
{
    List<Player> players = new List<Player>();
    Player player1 = new Player("Todd");
    Player player2 = new Player("May");
    Player player3 = new Player("Red");

    players.Add(player1);
    players.Add(player2);
    players.Add(player3);

    foreach(Player player in players)
    {
        Console.WriteLine(player.getusername()); //getter
        Console.WriteLine(player); // ToString() method
    }

    player1.SetUsername("Mike"); // setter
    Console.WriteLine("Player 1 new name is:" +player1.getusername());
}

    }
 }

 class Player
 {
    private String username;

    public Player(String username)
    {
        this.username = username;
    }

    public String getusername()
    {
        return this.username;
    }

    public void SetUsername(String name)
    {
        username = name;
    }

    public override String ToString()
    {
        return username;
    }
 }