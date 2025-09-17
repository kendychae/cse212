/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            // Add points to the player's total (or create new entry if first time seeing player)
            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            else
            {
                players[playerId] = points;
            }
        }

        Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        // Convert dictionary to a list of key-value pairs and sort by points (descending)
        var sortedPlayers = players.OrderByDescending(p => p.Value).ToList();

        // Get the top 10 players
        var topPlayers = sortedPlayers.Take(10).Select(p => p.Key).ToArray();

        Console.WriteLine("\nTop 10 Players by Career Points:");
        for (int i = 0; i < topPlayers.Length; i++)
        {
            var playerId = topPlayers[i];
            var totalPoints = players[playerId];
            Console.WriteLine($"{i + 1}. Player {playerId}: {totalPoints:N0} points");
        }
    }
}