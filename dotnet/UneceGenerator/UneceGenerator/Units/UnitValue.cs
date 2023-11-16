// namespace UneceGenerator.Units;
//
// public class UnitValue
// {
//     public decimal Value { get; }
//
//     /// <summary>
//     /// Or unit code only? Unit could be in DB only once.
//     /// </summary>
//     public Unit Unit { get; }
//
//     public UnitValue(decimal value, Unit unit)
//     {
//         Value = value;
//         Unit = unit;
//     }
//
//     public UnitValue Convert(Unit unit)
//     {
//         this.AssertSameConversionGroup(unit);
//
//         return new UnitValue(Value * Unit.ConversionFactor / unit.ConversionFactor, unit);
//     }
//
//     // TODO: Operators
//     public static UnitValue operator +(UnitValue a, UnitValue b)
//     {
//         a.AssertSameConversionGroup(b.Unit);
//
//         return new UnitValue(a.Value + b.Value * b.Unit.ConversionFactor / a.Unit.ConversionFactor, a.Unit);
//     }
//
//     void AssertSameConversionGroup(Unit target)
//     {
//         if (!Equals(Unit.ConversionGroup, target.ConversionGroup))
//         {
//             throw new InvalidOperationException(
//                 $"Conversion group '{Unit.ConversionGroup}' does not equal to target conversion group '{target.ConversionGroup}'.");
//         }
//     }
//
//     public override string ToString()
//     {
//         return $"{Value} {Unit}".TrimEnd();
//     }
// }