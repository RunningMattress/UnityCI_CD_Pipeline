using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SampleFeature
{
    public static List<string> UniqueStrings; 
    
    public static bool TryAddUniqueValue(string newValue)
    {
        //Init the list if null
        UniqueStrings ??= new List<string>();
        
        //Early exit if already added
        foreach (string item in UniqueStrings)
        {
            if (item == newValue)
            {
                return false;
            }
        }
        
        //Add the value
        UniqueStrings.Add(newValue);
        return true; 
    }
}
