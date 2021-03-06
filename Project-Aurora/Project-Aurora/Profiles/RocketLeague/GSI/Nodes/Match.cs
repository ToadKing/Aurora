﻿namespace Aurora.Profiles.RocketLeague.GSI.Nodes
{
    /// <summary>
    /// Class representing match information
    /// </summary>
    public class Match_RocketLeague : Node<Match_RocketLeague>
    {
        /// <summary>
        /// Blue team's score
        /// </summary>
        public int BlueTeam_Score = 0;

        /// <summary>
        /// Orange team's score
        /// </summary>
        public int OrangeTeam_Score = 0;

        internal Match_RocketLeague(string json_data) : base(json_data)
        {
        }
    }
}
