﻿namespace Shared;

public class LeaderboardData
{
    public bool IsCache { get; set; } = false;
    
    public Dictionary<string, PlayerCount> MostSeenPlayers { get; set; }
    public Dictionary<string, PlayerCount> MostAntagPlayers { get; set; }
    
    /// <summary>
    /// Most times as a kill or maroon target.
    /// </summary>
    public Dictionary<string, PlayerCount> MostHuntedPlayer { get; set; }
}

public class PlayerCount
{
    public PlayerData Player { get; set; }
    public int Count { get; set; }
}