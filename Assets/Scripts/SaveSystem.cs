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

    public static int GetInventoryLevel(string name)
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
}
