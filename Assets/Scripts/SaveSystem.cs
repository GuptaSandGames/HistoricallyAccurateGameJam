using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SaveSystem
{
    public static int honey = 5;
    public static int tulipRoots = 5;
    public static int whiteRoots = 5;
    public static int brandy = 5;
    public static int racoonGrease = 5;
    public static int anemoneSeeds = 5;
    public static int feverRemedy = 0;
    public static int toothachRemedy = 0;
    public static int gashRemedy = 0;
    
    public static float GetInventoryLevel(string name)
    {
      switch (name)
      {
        case "honey":
          return honey;
        case "tulipRoots":
          return tulipRoots;
        case "whiteRoots":
          return whiteRoots;
        case "brandy":
          return brandy;
        case "racoonGrease":
          return racoonGrease;
        case "anemoneSeeds":
          return anemoneSeeds;
        default:
          Debug.Log("REEEEEE");
          return 0;
      }
    }

    public static void SetValue(string name, float value) {
      switch (name)
      {
        case "honey":
          honey = (int)value;
          break;
        case "tulipRoots":
          tulipRoots = (int)value;
          break;
        case "whiteRoots":
          whiteRoots = (int)value;
          break;
        case "brandy":
          brandy = (int)value;
          break;
        case "racoonGrease":
          racoonGrease = (int)value;
          break;
        case "anemoneSeeds":
          anemoneSeeds = (int)value;
          break;
        default:
          Debug.Log("REEEEEE");
          break;
      }
    }

    public static float ModifyValue(string name, int value) {
      switch (name)
      {
        case "honey":
          honey += value;
          return honey;
        case "tulipRoots":
          tulipRoots += value;
          return tulipRoots;
        case "whiteRoots":
          whiteRoots += value;
          return whiteRoots;
        case "brandy":
          brandy += value;
          return brandy;
        case "racoonGrease":
          racoonGrease += value;
          return racoonGrease;
        case "anemoneSeeds":
          anemoneSeeds += value;
          return anemoneSeeds;
        default:
          Debug.Log("REEEEEE");
          return 0;
      }
    }
}
