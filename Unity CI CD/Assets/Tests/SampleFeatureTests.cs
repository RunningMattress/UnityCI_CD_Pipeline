using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SampleFeatureTests
{
    [SetUp]
    public void SetUp()
    {
        SampleFeature.UniqueStrings?.Clear();
    }
    
    
    // Test that we can add a single value
    [Test]
    public void CanAddAValue()
    {
        SampleFeature.TryAddUniqueValue("test");
        
        Assert.AreEqual(1, SampleFeature.UniqueStrings.Count);
    }
    
    // Test that we can add many values
    [Test]
    public void CanAddManyValues()
    {
        SampleFeature.TryAddUniqueValue("test");
        SampleFeature.TryAddUniqueValue("test2");
        
        Assert.AreEqual(2, SampleFeature.UniqueStrings.Count);
    }

    // Test that we cannot add duplicates
    [Test]
    public void CannotAddTheSameValue()
    {
        SampleFeature.TryAddUniqueValue("test");
        SampleFeature.TryAddUniqueValue("test");
        
        Assert.AreEqual(1, SampleFeature.UniqueStrings.Count);
    }
}
