﻿using Draven.Structures;

using RtmpSharp.IO.AMF3;
using RtmpSharp.Messaging;
using System.Collections.Generic;

namespace Draven.Messages.MatchmakerService
{
    using Draven.Structures.Platform.Login.Matchmaking;

    class GetAvailableQueues : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            ArrayCollection data = new ArrayCollection
            {
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 100,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 3,
                    QueueState = "ON",
                    Type = "NORMAL",
                    CacheName = "matching-queue-NORMAL-5x5-game-queue",
                    Id = 2.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = false,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "NORMAL",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 75,
                    Ranked = true,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 100,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 2,
                    MinLevel = 30,
                    QueueState = "ON",
                    Type = "RANKED_SOLO_5x5",
                    CacheName = "matching-queue-RANKED_SOLO-5x5-game-queue",
                    Id = 4.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "rankedSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = false,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "RANKED_SOLO_5x5",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = true,
                    MaximumParticipantListSize = 2,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "MapMusic(Bilgewater)", "NOCLARITY" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 4,
                    MinLevel = 5,
                    QueueState = "ON",
                    Type = "ARAM_UNRANKED_5x5",
                    CacheName = "matching-queue-BILGEWATER_ARAM-5x5-game-queue",
                    Id = 100.0,
                    QueueBonusKey = "ARAMQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalARAM",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 14 },
                    GameMode = "ARAM",
                    TypeString = "ARAM_UNRANKED_5x5",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "LAST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "ReRoll", "BattleBoost" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_INTRO-5x5-game-queue",
                    Id = 31.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 9,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "OnboardCoopBeginner", "LearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_EASY-5x5-game-queue",
                    Id = 32.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "AdvancedLearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 1,
                    MinLevel = 0,
                    QueueState = "ON",
                    Type = "BOT",
                    CacheName = "matching-queue-BOT_MEDIUM-5x5-game-queue",
                    Id = 33.0,
                    QueueBonusKey = "matchedBotsQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "coOpVsAiSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BOT",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "AdvancedLearningQuests", "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 75,
                    Ranked = true,
                    MinimumParticipantListSize = 5,
                    MaxLevel = 100,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 2,
                    MinLevel = 30,
                    QueueState = "ON",
                    Type = "RANKED_TEAM_5x5",
                    CacheName = "matching-queue-RANKED_TEAM-5x5-game-queue",
                    Id = 42.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "rankedSummonersRift",
                    TeamOnly = true,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "RANKED_TEAM_5x5",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = false,
                    GameMutators = new ArrayCollection{ "MapMusic(Bilgewater)", "NOCLARITY" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 75,
                    Ranked = false,
                    MinimumParticipantListSize = 5,
                    MaxLevel = 100,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 12,
                    MinLevel = 25,
                    QueueState = "ON",
                    Type = "CAP_5x5",
                    CacheName = "matching-queue-GROUP_FINDER-5x5-game-queue",
                    Id = 61.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "CAP_5x5",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "MapMusic(Bilgewater)" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
                new GameQueueConfig {
                    BlockedMinutesThreshold = 60,
                    Ranked = false,
                    MinimumParticipantListSize = 1,
                    MaxLevel = 30,
                    ThresholdEnabled = false,
                    GameTypeConfigId = 16,
                    MinLevel = 10,
                    QueueState = "ON",
                    Type = "BILGEWATER",
                    CacheName = "matching-queue-BILGEWATER-5x5-game-queue",
                    Id = 313.0,
                    QueueBonusKey = "normalQueueBonuses",
                    MaxSummonerLevelForFWOTD = 100,
                    QueueStateString = "ON",
                    PointsConfigKey = "normalSummonersRift",
                    TeamOnly = false,
                    MinimumQueueDodgeDelayTime = 8000,
                    RandomizeTeamSides = true,
                    SupportedMapIds = new ArrayCollection{ 11 },
                    GameMode = "CLASSIC",
                    TypeString = "BILGEWATER",
                    NumPlayersPerTeam = 5,
                    DisallowFreeChampions = false,
                    MaximumParticipantListSize = 5,
                    MapSelectionAlgorithm = "FIRST",
                    BotsCanSpawnOnBlueSide = true,
                    GameMutators = new ArrayCollection{ "Bilgewater" },
                    ThresholdSize = 2147483647.0,
                    MatchingThrottleConfig = new MatchingThrottleConfig
                    {
                        CacheName = "",
                        Limit = 2147483647.0,
                        MatchingThrottleProperties = new ArrayCollection()
                    }
                },
            };
            e.ReturnRequired = true;
            e.Data = data;

            return e;
        }
    }
}
