﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Tilestuff
{


    public static readonly string[] tilestring =
    {
     "//FLOODTEMP",
    "//EMPTY",
    "//THEREISNTAZERO",
    "//NOSPRITE",
   "hill overlay","mountain overlay","base_tile polar 1","base_tile polar 2","base_tile polar 3","base_tile polar tree overlay","base_tile tundra 1","base_tile tundra 2","base_tile tundra 3","base_tile tundra tree overlay","base_tile taiga 1","base_tile taiga 2","base_tile taiga 3","base_tile taiga tree overlay","base_tile alpine 1","base_tile alpine 2","base_tile alpine 3","base_tile alpine tree overlay","base_tile mediterranean 1","base_tile mediterranean 2","base_tile mediterranean 3","base_tile mediterranean tree overlay","base_tile prairie 1","base_tile prairie 2","base_tile prairie 3","base_tile prairie tree overlay","base_tile temperate forest 1","base_tile temperate forest 2","base_tile temperate forest 3","base_tile temperate forest tree overlay","base_tile desert 1","base_tile desert 2","base_tile desert 3","base_tile desert tree overlay","base_tile savanna 1","base_tile savanna 2","base_tile savanna 3","base_tile savanna tree overlay","base_tile tropical_rainforest 1","base_tile tropical_rainforest 2","base_tile tropical_rainforest 3","base_tile tropical_rainforest tree overlay","base_tile coastal_water 1","base_tile coastal_water 2","base_tile coastal_water 3","base_tile ocean 1","base_tile ocean 2","base_tile ocean 3","yield production 1","yield production 2","yield production 3","yield production 4","yield gold 1","yield gold 2","yield gold 3","yield gold 4","yield food 1","yield food 2","yield food 3","yield food 4","resource leather","resource orange","resource sheep","resource coffee","resource gems","resource oil","resource copper","resource silver","resource gold","resource tropical plants","resource fish","resource iron","resource horses","resource honey","buildings city","buildings factory","buildings trading post","buildings barracks","buildings market","buildings allotments","buildings guard post","buildings armourer","buildings blacksmith","buildings port and docks","buildings teleporter","buildings town hall","buildings improvements farm","buildings improvements mine","buildings improvements generic resource exploitation","buildings barbarian camp","buildings barbarian citadel","buildings city state","units player scout","units enemy scout","units player clubber","units enemy clubber","units player spearman","units enemy spearman","units player knight","units enemy knight","units player pikeman","units enemy pikeman","units player mounted clubber","units enemy mounted clubber","units player mounted knight","units enemy mounted knight","units player","units barbarian champion","units barbarian lord","units player hero broom","units player hero moop","units player hero torkin spider","units player hero reginald marsby","units player hero chickadee monserat","units player hero benzedrene the ESR","units player hero creepy salado","units player hero doctor barnabee","units player hero pango pangolin","units player trader","goodie hut","//EFFECT FULL SQUARE"
};
}
public enum Etilesprite : int
{
    FLOODTEMP = -2,
    EMPTY = -1,
    THEREISNTAZERO = 0,
    NOSPRITE = 1,
    HILL_OVERLAY,
    MOUNTAIN_OVERLAY,
    BASE_TILE_POLAR_1,
    BASE_TILE_POLAR_2,
    BASE_TILE_POLAR_3,
    BASE_TILE_POLAR_TREE_OVERLAY,
    BASE_TILE_TUNDRA_1,
    BASE_TILE_TUNDRA_2,
    BASE_TILE_TUNDRA_3,
    BASE_TILE_TUNDRA_TREE_OVERLAY,
    BASE_TILE_TAIGA_1,
    BASE_TILE_TAIGA_2,
    BASE_TILE_TAIGA_3,
    BASE_TILE_TAIGA_TREE_OVERLAY,
    BASE_TILE_ALPINE_1,
    BASE_TILE_ALPINE_2,
    BASE_TILE_ALPINE_3,
    BASE_TILE_ALPINE_TREE_OVERLAY,
    BASE_TILE_MEDITERRANEAN_1,
    BASE_TILE_MEDITERRANEAN_2,
    BASE_TILE_MEDITERRANEAN_3,
    BASE_TILE_MEDITERRANEAN_TREE_OVERLAY,
    BASE_TILE_PRAIRIE_1,
    BASE_TILE_PRAIRIE_2,
    BASE_TILE_PRAIRIE_3,
    BASE_TILE_PRAIRIE_TREE_OVERLAY,
    BASE_TILE_TEMPERATE_FOREST_1,
    BASE_TILE_TEMPERATE_FOREST_2,
    BASE_TILE_TEMPERATE_FOREST_3,
    BASE_TILE_TEMPERATE_FOREST_TREE_OVERLAY,
    BASE_TILE_DESERT_1,
    BASE_TILE_DESERT_2,
    BASE_TILE_DESERT_3,
    BASE_TILE_DESERT_TREE_OVERLAY,
    BASE_TILE_SAVANNA_1,
    BASE_TILE_SAVANNA_2,
    BASE_TILE_SAVANNA_3,
    BASE_TILE_SAVANNA_TREE_OVERLAY,
    BASE_TILE_TROPICAL_RAINFOREST_1,
    BASE_TILE_TROPICAL_RAINFOREST_2,
    BASE_TILE_TROPICAL_RAINFOREST_3,
    BASE_TILE_TROPICAL_RAINFOREST_TREE_OVERLAY,
    BASE_TILE_COASTAL_WATER_1,
    BASE_TILE_COASTAL_WATER_2,
    BASE_TILE_COASTAL_WATER_3,
    BASE_TILE_OCEAN_1,
    BASE_TILE_OCEAN_2,
    BASE_TILE_OCEAN_3,
    YIELD_PRODUCTION_1,
    YIELD_PRODUCTION_2,
    YIELD_PRODUCTION_3,
    YIELD_PRODUCTION_4,
    YIELD_GOLD_1,
    YIELD_GOLD_2,
    YIELD_GOLD_3,
    YIELD_GOLD_4,
    YIELD_FOOD_1,
    YIELD_FOOD_2,
    YIELD_FOOD_3,
    YIELD_FOOD_4,
    RESOURCE_LEATHER,
    RESOURCE_ORANGE,
    RESOURCE_SHEEP,
    RESOURCE_COFFEE,
    RESOURCE_GEMS,
    RESOURCE_OIL,
    RESOURCE_COPPER,
    RESOURCE_SILVER,
    RESOURCE_GOLD,
    RESOURCE_TROPICAL_PLANTS,
    RESOURCE_FISH,
    RESOURCE_IRON,
    RESOURCE_HORSES,
    RESOURCE_HONEY,
    BUILDINGS_CITY,
    BUILDINGS_FACTORY,
    BUILDINGS_TRADING_POST,
    BUILDINGS_BARRACKS,
    BUILDINGS_MARKET,
    BUILDINGS_ALLOTMENTS,
    BUILDINGS_GUARD_POST,
    BUILDINGS_ARMOURER,
    BUILDINGS_BLACKSMITH,
    BUILDINGS_PORT_AND_DOCKS,
    BUILDINGS_TELEPORTER,
    BUILDINGS_TOWN_HALL,
    BUILDINGS_IMPROVEMENTS_FARM,
    BUILDINGS_IMPROVEMENTS_MINE,
    BUILDINGS_IMPROVEMENTS_GENERIC_RESOURCE_EXPLOITATION,
    BUILDINGS_BARBARIAN_CAMP,
    BUILDINGS_BARBARIAN_CITADEL,
    BUILDINGS_CITY_STATE,
    UNITS_PLAYER_SCOUT,
    UNITS_ENEMY_SCOUT,
    UNITS_PLAYER_CLUBBER,
    UNITS_ENEMY_CLUBBER,
    UNITS_PLAYER_SPEARMAN,
    UNITS_ENEMY_SPEARMAN,
    UNITS_PLAYER_KNIGHT,
    UNITS_ENEMY_KNIGHT,
    UNITS_PLAYER_PIKEMAN,
    UNITS_ENEMY_PIKEMAN,
    UNITS_PLAYER_MOUNTED_CLUBBER,
    UNITS_ENEMY_MOUNTED_CLUBBER,
    UNITS_PLAYER_MOUNTED_KNIGHT,
    UNITS_ENEMY_MOUNTED_KNIGHT,
    UNITS_PLAYER,
    UNITS_BARBARIAN_CHAMPION,
    UNITS_BARBARIAN_LORD,
    UNITS_PLAYER_HERO_BROOM,
    UNITS_PLAYER_HERO_MOOP,
    UNITS_PLAYER_HERO_TORKIN_SPIDER,
    UNITS_PLAYER_HERO_REGINALD_MARSBY,
    UNITS_PLAYER_HERO_CHICKADEE_MONSERAT,
    UNITS_PLAYER_HERO_BENZEDRENE_THE_ESR,
    UNITS_PLAYER_HERO_CREEPY_SALADO,
    UNITS_PLAYER_HERO_DOCTOR_BARNABEE,
    UNITS_PLAYER_HERO_PANGO_PANGOLIN,
    UNITS_PLAYER_TRADER,
    BUILDINGS_GOODIE_HUT,
    EFFECT_FULLSQUARE

}
