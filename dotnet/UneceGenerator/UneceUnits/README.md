# Unece Units

UNECE Units generated structures for working with UNECE rec. 20 and rec. 21 standards.

Rec. 21 units have common code prefixed with an "X" to avoid possible conflicts with rec. 20 units.

## Basic usage

Use Units class and its methods to work with units. For example:

```
    var meter = Units.GetByCommonCode("MTR");
    
    if (Units.TryGetByCommonCode("MTR", out var meter2))
    {
        // do something with meter
    }
    
    
    if (Units.TryGetConvertibleByCommonCode("MTR", out var convertibleMeter))
    {
        // do something with convertible meter
    }
    
    // Access meter directly
    var meter3 = Units.Metre;
```

## Operations

Units can be used in operations using the UnitValue class, for example:

```
        var kilometerDistance = new UnitValue
        {
            Value = 1,
            Unit = Units.Kilometre,
        };

        var metreDistance = new UnitValue
        {
            Value = 100,
            Unit = Units.GetByCommonCode("MTR"),
        };

        var totalDistance = kilometerDistance + metreDistance;
        var metreDistanceInKilometers = metreDistance.Convert(Units.Kilometre);
```