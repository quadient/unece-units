// Auto-generated code
#nullable enable
namespace UneceUnits;
using System.Diagnostics.CodeAnalysis;
using UneceUnits;

public static class Units
{
    public static IUnit GetByCommonCode(string commonCode)
    {
        if (!TryGetByCommonCode(commonCode, out var unit))
        {
            throw new ArgumentException($"Unit with common code '{commonCode}' does not exist.", nameof(commonCode));
        }

        return unit;
    }

    // TODO[j.semerak]: Tests.
    public static IConvertibleUnit GetConvertibleByCommonCode(string commonCode)
    {
        if (!TryGetConvertibleByCommonCode(commonCode, out var unit))
        {
            throw new ArgumentException($"Unit with common code '{commonCode}' does not exist or is not convertible.", nameof(commonCode));
        }

        return unit;
    }

    public static bool TryGetConvertibleByCommonCode(string commonCode, [NotNullWhen(returnValue: true)] out IConvertibleUnit? convertibleUnit)
    {
        if (TryGetByCommonCode(commonCode, out var unit))
        {
            if (unit is IConvertibleUnit typedUnit)
            {
                convertibleUnit = typedUnit;
                return true;
            }
        }

        convertibleUnit = null;
        return false;
    }

    public static bool TryGetByCommonCode(string commonCode, [NotNullWhen(returnValue: true)] out IUnit? unit)
    {
        unit = commonCode switch
        {
            "10" => Group,
            "11" => Outfit,
            "13" => Ration,
            "14" => Shot,
            "15" => StickMilitary,
            "20" => TwentyFootContainer,
            "21" => FortyFootContainer,
            "22" => DecilitrePerGram,
            "23" => GramPerCubicCentimetre,
            "24" => TheoreticalPound,
            "25" => GramPerSquareCentimetre,
            "27" => TheoreticalTon,
            "28" => KilogramPerSquareMetre,
            "33" => KilopascalSquareMetrePerGram,
            "34" => KilopascalPerMillimetre,
            "35" => MillilitrePerSquareCentimetreSecond,
            "37" => OuncePerSquareFoot,
            "38" => OuncePerSquareFootPer001Inch,
            "40" => MillilitrePerSecond,
            "41" => MillilitrePerMinute,
            "56" => Sitas,
            "57" => Mesh,
            "58" => NetKilogram,
            "59" => PartPerMillion,
            "60" => PercentWeight,
            "61" => PartPerBillionUS,
            "74" => Millipascal,
            "77" => Milliinch,
            "80" => PoundPerSquareInchAbsolute,
            "81" => Henry,
            "85" => FootPoundforce,
            "87" => PoundPerCubicFoot,
            "89" => Poise,
            "91" => Stokes,
            "1I" => FixedRate,
            "2A" => RadianPerSecond,
            "2B" => RadianPerSecondSquared,
            "2C" => Roentgen,
            "2G" => VoltAC,
            "2H" => VoltDC,
            "2I" => BritishThermalUnitInternationalTablePerHour,
            "2J" => CubicCentimetrePerSecond,
            "2K" => CubicFootPerHour,
            "2L" => CubicFootPerMinute,
            "2M" => CentimetrePerSecond,
            "2N" => Decibel,
            "2P" => Kilobyte,
            "2Q" => Kilobecquerel,
            "2R" => Kilocurie,
            "2U" => Megagram,
            "2X" => MetrePerMinute,
            "2Y" => Milliroentgen,
            "2Z" => Millivolt,
            "3B" => Megajoule,
            "3C" => Manmonth,
            "4C" => Centistokes,
            "4G" => Microlitre,
            "4H" => MicrometreMicron,
            "4K" => Milliampere,
            "4L" => Megabyte,
            "4M" => MilligramPerHour,
            "4N" => Megabecquerel,
            "4O" => Microfarad,
            "4P" => NewtonPerMetre,
            "4Q" => OunceInch,
            "4R" => OunceFoot,
            "4T" => Picofarad,
            "4U" => PoundPerHour,
            "4W" => TonUSPerHour,
            "4X" => KilolitrePerHour,
            "5A" => BarrelUSPerMinute,
            "5B" => Batch,
            "5E" => MMSCFPerDay,
            "5J" => HydraulicHorsePower,
            "A10" => AmpereSquareMetrePerJouleSecond,
            "A11" => Angstrom,
            "A12" => AstronomicalUnit,
            "A13" => Attojoule,
            "A14" => Barn,
            "A15" => BarnPerElectronvolt,
            "A16" => BarnPerSteradianElectronvolt,
            "A17" => BarnPerSteradian,
            "A18" => BecquerelPerKilogram,
            "A19" => BecquerelPerCubicMetre,
            "A2" => AmperePerCentimetre,
            "A20" => BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine,
            "A21" => BritishThermalUnitInternationalTablePerPoundDegreeRankine,
            "A22" => BritishThermalUnitInternationalTablePerSecondFootDegreeRankine,
            "A23" => BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine,
            "A24" => CandelaPerSquareMetre,
            "A26" => CoulombMetre,
            "A27" => CoulombMetreSquaredPerVolt,
            "A28" => CoulombPerCubicCentimetre,
            "A29" => CoulombPerCubicMetre,
            "A3" => AmperePerMillimetre,
            "A30" => CoulombPerCubicMillimetre,
            "A31" => CoulombPerKilogramSecond,
            "A32" => CoulombPerMole,
            "A33" => CoulombPerSquareCentimetre,
            "A34" => CoulombPerSquareMetre,
            "A35" => CoulombPerSquareMillimetre,
            "A36" => CubicCentimetrePerMole,
            "A37" => CubicDecimetrePerMole,
            "A38" => CubicMetrePerCoulomb,
            "A39" => CubicMetrePerKilogram,
            "A4" => AmperePerSquareCentimetre,
            "A40" => CubicMetrePerMole,
            "A41" => AmperePerSquareMetre,
            "A42" => CuriePerKilogram,
            "A43" => DeadweightTonnage,
            "A44" => Decalitre,
            "A45" => Decametre,
            "A47" => Decitex,
            "A48" => DegreeRankine,
            "A49" => DenierA49,
            "M83" => DenierM83,
            "A5" => AmpereSquareMetre,
            "A53" => Electronvolt,
            "A54" => ElectronvoltPerMetre,
            "A55" => ElectronvoltSquareMetre,
            "A56" => ElectronvoltSquareMetrePerKilogram,
            "A59" => Unit8partCloudCover,
            "A6" => AmperePerSquareMetreKelvinSquared,
            "A68" => Exajoule,
            "A69" => FaradPerMetre,
            "A7" => AmperePerSquareMillimetre,
            "A70" => Femtojoule,
            "A71" => Femtometre,
            "A73" => FootPerSecondSquared,
            "A74" => FootPoundforcePerSecond,
            "A75" => FreightTon,
            "A76" => Gal,
            "A8" => AmpereSecond,
            "A84" => GigacoulombPerCubicMetre,
            "A85" => Gigaelectronvolt,
            "A86" => Gigahertz,
            "A87" => Gigaohm,
            "A88" => GigaohmMetre,
            "A89" => Gigapascal,
            "A9" => Rate,
            "A90" => Gigawatt,
            "A91" => Gon,
            "A93" => GramPerCubicMetre,
            "A94" => GramPerMole,
            "A95" => Gray,
            "A96" => GrayPerSecond,
            "A97" => Hectopascal,
            "A98" => HenryPerMetre,
            "A99" => Bit,
            "AA" => BallAA,
            "XAL" => BallXAL,
            "AB" => BulkPack,
            "ACR" => Acre,
            "ACT" => Activity,
            "AD" => Byte,
            "AE" => AmperePerMetre,
            "AH" => AdditionalMinute,
            "AI" => AverageMinutePerCall,
            "AK" => Fathom,
            "AL" => AccessLine,
            "AMH" => AmpereHour,
            "AMP" => Ampere,
            "ANN" => Year,
            "APZ" => TroyOunceOrApothecaryOunce,
            "AQ" => AntihemophilicFactorAHFUnit,
            "AS" => Assortment,
            "ASM" => AlcoholicStrengthByMass,
            "ASU" => AlcoholicStrengthByVolume,
            "ATM" => StandardAtmosphere,
            "AWG" => AmericanWireGauge,
            "AY" => Assembly,
            "AZ" => BritishThermalUnitInternationalTablePerPound,
            "B1" => BarrelUSPerDay,
            "B10" => BitPerSecond,
            "B11" => JoulePerKilogramKelvin,
            "B12" => JoulePerMetre,
            "B13" => JoulePerSquareMetre,
            "B14" => JoulePerMetreToTheFourthPower,
            "B15" => JoulePerMole,
            "B16" => JoulePerMoleKelvin,
            "B17" => Credit,
            "B18" => JouleSecond,
            "B19" => Digit,
            "B20" => JouleSquareMetrePerKilogram,
            "B21" => KelvinPerWatt,
            "B22" => Kiloampere,
            "B23" => KiloamperePerSquareMetre,
            "B24" => KiloamperePerMetre,
            "B25" => KilobecquerelPerKilogram,
            "B26" => Kilocoulomb,
            "B27" => KilocoulombPerCubicMetre,
            "B28" => KilocoulombPerSquareMetre,
            "B29" => Kiloelectronvolt,
            "B3" => BattingPound,
            "B30" => Gibibit,
            "B31" => KilogramMetrePerSecond,
            "B32" => KilogramMetreSquared,
            "B33" => KilogramMetreSquaredPerSecond,
            "B34" => KilogramPerCubicDecimetre,
            "B35" => KilogramPerLitre,
            "B4" => BarrelImperial,
            "B41" => KilojoulePerKelvin,
            "B42" => KilojoulePerKilogram,
            "B43" => KilojoulePerKilogramKelvin,
            "B44" => KilojoulePerMole,
            "B45" => Kilomole,
            "B46" => KilomolePerCubicMetre,
            "B47" => Kilonewton,
            "B48" => KilonewtonMetre,
            "B49" => Kiloohm,
            "B50" => KiloohmMetre,
            "B52" => Kilosecond,
            "B53" => Kilosiemens,
            "B54" => KilosiemensPerMetre,
            "B55" => KilovoltPerMetre,
            "B56" => KiloweberPerMetre,
            "B57" => LightYear,
            "B58" => LitrePerMole,
            "B59" => LumenHour,
            "B60" => LumenPerSquareMetre,
            "B61" => LumenPerWatt,
            "B62" => LumenSecond,
            "B63" => LuxHour,
            "B64" => LuxSecond,
            "B66" => MegaamperePerSquareMetre,
            "B67" => MegabecquerelPerKilogram,
            "B68" => Gigabit,
            "B69" => MegacoulombPerCubicMetre,
            "B7" => Cycle,
            "B70" => MegacoulombPerSquareMetre,
            "B71" => Megaelectronvolt,
            "B72" => MegagramPerCubicMetre,
            "B73" => Meganewton,
            "B74" => MeganewtonMetre,
            "B75" => Megaohm,
            "B76" => MegaohmMetre,
            "B77" => MegasiemensPerMetre,
            "B78" => Megavolt,
            "B79" => MegavoltPerMetre,
            "B8" => JoulePerCubicMetre,
            "B80" => GigabitPerSecond,
            "B81" => ReciprocalMetreSquaredReciprocalSecond,
            "B82" => InchPerLinearFoot,
            "B83" => MetreToTheFourthPower,
            "B84" => Microampere,
            "B85" => Microbar,
            "B86" => Microcoulomb,
            "B87" => MicrocoulombPerCubicMetre,
            "B88" => MicrocoulombPerSquareMetre,
            "B89" => MicrofaradPerMetre,
            "B90" => Microhenry,
            "B91" => MicrohenryPerMetre,
            "B92" => Micronewton,
            "B93" => MicronewtonMetre,
            "B94" => Microohm,
            "B95" => MicroohmMetre,
            "B96" => Micropascal,
            "B97" => Microradian,
            "B98" => Microsecond,
            "B99" => Microsiemens,
            "BAR" => BarUnitOfPressure,
            "BB" => BaseBox,
            "BFT" => BoardFoot,
            "BHP" => BrakeHorsePower,
            "BIL" => BillionEUR,
            "BLD" => DryBarrelUS,
            "BLL" => BarrelUS,
            "BP" => HundredBoardFoot,
            "BPM" => BeatsPerMinute,
            "BQL" => Becquerel,
            "BTU" => BritishThermalUnitInternationalTable,
            "BUA" => BushelUS,
            "BUI" => BushelUK,
            "C0" => Call,
            "C10" => Millifarad,
            "C11" => Milligal,
            "C12" => MilligramPerMetre,
            "C13" => Milligray,
            "C14" => Millihenry,
            "C15" => Millijoule,
            "C16" => MillimetrePerSecond,
            "C17" => MillimetreSquaredPerSecond,
            "C18" => Millimole,
            "C19" => MolePerKilogram,
            "C20" => Millinewton,
            "C21" => Kibibit,
            "C22" => MillinewtonPerMetre,
            "C23" => MilliohmMetre,
            "C24" => MillipascalSecond,
            "C25" => Milliradian,
            "C26" => Millisecond,
            "C27" => Millisiemens,
            "C28" => Millisievert,
            "C29" => Millitesla,
            "C3" => MicrovoltPerMetre,
            "C30" => MillivoltPerMetre,
            "C31" => Milliwatt,
            "C32" => MilliwattPerSquareMetre,
            "C33" => Milliweber,
            "C34" => Mole,
            "C35" => MolePerCubicDecimetre,
            "C36" => MolePerCubicMetre,
            "C37" => Kilobit,
            "C38" => MolePerLitre,
            "C39" => Nanoampere,
            "C40" => Nanocoulomb,
            "C41" => Nanofarad,
            "C42" => NanofaradPerMetre,
            "C43" => Nanohenry,
            "C44" => NanohenryPerMetre,
            "C45" => Nanometre,
            "C46" => NanoohmMetre,
            "C47" => Nanosecond,
            "C48" => Nanotesla,
            "C49" => Nanowatt,
            "C50" => Neper,
            "C51" => NeperPerSecond,
            "C52" => Picometre,
            "C53" => NewtonMetreSecond,
            "C54" => NewtonMetreSquaredPerKilogramSquared,
            "C55" => NewtonPerSquareMetre,
            "C56" => NewtonPerSquareMillimetre,
            "C57" => NewtonSecond,
            "C58" => NewtonSecondPerMetre,
            "C59" => Octave,
            "C60" => OhmCentimetre,
            "C61" => OhmMetre,
            "C62" => One,
            "C63" => Parsec,
            "C64" => PascalPerKelvin,
            "C65" => PascalSecond,
            "C66" => PascalSecondPerCubicMetre,
            "C67" => PascalSecondPerMetre,
            "C68" => Petajoule,
            "C69" => Phon,
            "C7" => Centipoise,
            "C70" => Picoampere,
            "C71" => Picocoulomb,
            "C72" => PicofaradPerMetre,
            "C73" => Picohenry,
            "C74" => KilobitPerSecond,
            "C75" => Picowatt,
            "C76" => PicowattPerSquareMetre,
            "C78" => Poundforce,
            "C79" => KilovoltAmpereHour,
            "C8" => MillicoulombPerKilogram,
            "C80" => Rad,
            "C81" => Radian,
            "C82" => RadianSquareMetrePerMole,
            "C83" => RadianSquareMetrePerKilogram,
            "C84" => RadianPerMetre,
            "C85" => ReciprocalAngstrom,
            "C86" => ReciprocalCubicMetre,
            "C87" => ReciprocalCubicMetrePerSecond,
            "C88" => ReciprocalElectronVoltPerCubicMetre,
            "C89" => ReciprocalHenry,
            "C9" => CoilGroup,
            "C90" => ReciprocalJoulePerCubicMetre,
            "C91" => ReciprocalKelvinOrKelvinToThePowerMinusOne,
            "C92" => ReciprocalMetre,
            "C93" => ReciprocalSquareMetre,
            "C94" => ReciprocalMinute,
            "C95" => ReciprocalMole,
            "C96" => ReciprocalPascalOrPascalToThePowerMinusOne,
            "C97" => ReciprocalSecond,
            "C99" => ReciprocalSecondPerMetreSquared,
            "CCT" => CarryingCapacityInMetricTon,
            "CDL" => Candela,
            "CEL" => DegreeCelsius,
            "CEN" => Hundred,
            "CG" => CardCG,
            "XCM" => CardXCM,
            "CGM" => Centigram,
            "CKG" => CoulombPerKilogram,
            "CLF" => HundredLeave,
            "CLT" => Centilitre,
            "CMK" => SquareCentimetre,
            "CMQ" => CubicCentimetre,
            "CMT" => Centimetre,
            "CNP" => HundredPack,
            "CNT" => CentalUK,
            "COU" => Coulomb,
            "CTG" => ContentGram,
            "CTM" => MetricCarat,
            "CTN" => ContentTonMetric,
            "CUR" => Curie,
            "CWA" => HundredPoundCwtPerHundredWeightUS,
            "CWI" => HundredWeightUK,
            "D03" => KilowattHourPerHour,
            "D04" => LotUnitOfWeight,
            "D1" => ReciprocalSecondPerSteradian,
            "D10" => SiemensPerMetre,
            "D11" => Mebibit,
            "D12" => SiemensSquareMetrePerMole,
            "D13" => Sievert,
            "D15" => Sone,
            "D16" => SquareCentimetrePerErg,
            "D17" => SquareCentimetrePerSteradianErg,
            "D18" => MetreKelvin,
            "D19" => SquareMetreKelvinPerWatt,
            "D2" => ReciprocalSecondPerSteradianMetreSquared,
            "D20" => SquareMetrePerJoule,
            "D21" => SquareMetrePerKilogram,
            "D22" => SquareMetrePerMole,
            "D23" => PenGramProtein,
            "D24" => SquareMetrePerSteradian,
            "D25" => SquareMetrePerSteradianJoule,
            "D26" => SquareMetrePerVoltSecond,
            "D27" => Steradian,
            "D29" => Terahertz,
            "D30" => Terajoule,
            "D31" => Terawatt,
            "D32" => TerawattHour,
            "D33" => Tesla,
            "D34" => Tex,
            "D36" => Megabit,
            "D41" => TonnePerCubicMetre,
            "D42" => TropicalYear,
            "D43" => UnifiedAtomicMassUnit,
            "D44" => Var,
            "D45" => VoltSquaredPerKelvinSquared,
            "D46" => VoltAmpere,
            "D47" => VoltPerCentimetre,
            "D48" => VoltPerKelvin,
            "D49" => MillivoltPerKelvin,
            "D5" => KilogramPerSquareCentimetre,
            "D50" => VoltPerMetre,
            "D51" => VoltPerMillimetre,
            "D52" => WattPerKelvin,
            "D53" => WattPerMetreKelvin,
            "D54" => WattPerSquareMetre,
            "D55" => WattPerSquareMetreKelvin,
            "D56" => WattPerSquareMetreKelvinToTheFourthPower,
            "D57" => WattPerSteradian,
            "D58" => WattPerSteradianSquareMetre,
            "D59" => WeberPerMetre,
            "D6" => RoentgenPerSecond,
            "D60" => WeberPerMillimetre,
            "D61" => MinuteUnitOfAngle,
            "D62" => SecondUnitOfAngle,
            "D63" => Book,
            "D65" => Round,
            "D68" => NumberOfWords,
            "D69" => InchToTheFourthPower,
            "D73" => JouleSquareMetre,
            "D74" => KilogramPerMole,
            "D77" => Megacoulomb,
            "D78" => MegajoulePerSecond,
            "D80" => Microwatt,
            "D81" => Microtesla,
            "D82" => Microvolt,
            "D83" => MillinewtonMetre,
            "D85" => MicrowattPerSquareMetre,
            "D86" => Millicoulomb,
            "D87" => MillimolePerKilogram,
            "D88" => MillicoulombPerCubicMetre,
            "D89" => MillicoulombPerSquareMetre,
            "D91" => Rem,
            "D93" => SecondPerCubicMetre,
            "D94" => SecondPerCubicMetreRadian,
            "D95" => JoulePerGram,
            "DAA" => Decare,
            "DAD" => TenDay,
            "DAY" => Day,
            "DB" => DryPound,
            "DD" => DegreeUnitOfAngle,
            "DEC" => Decade,
            "DG" => Decigram,
            "DJ" => Decagram,
            "DLT" => Decilitre,
            "DMA" => CubicDecametre,
            "DMK" => SquareDecimetre,
            "DMO" => StandardKilolitre,
            "DMQ" => CubicDecimetre,
            "DMT" => Decimetre,
            "DN" => DecinewtonMetre,
            "DPC" => DozenPiece,
            "DPR" => DozenPair,
            "DPT" => DisplacementTonnage,
            "DRA" => DramUS,
            "DRI" => DramUK,
            "DRL" => DozenRoll,
            "DT" => DryTon,
            "DTN" => Decitonne,
            "DWT" => Pennyweight,
            "DZN" => Dozen,
            "DZP" => DozenPack,
            "E01" => NewtonPerSquareCentimetre,
            "E07" => MegawattHourPerHour,
            "E08" => MegawattPerHertz,
            "E09" => MilliampereHour,
            "E10" => DegreeDay,
            "E12" => Mille,
            "E14" => KilocalorieInternationalTable,
            "E15" => KilocalorieThermochemicalPerHour,
            "E16" => MillionBtuITPerHour,
            "E17" => CubicFootPerSecond,
            "E18" => TonnePerHour,
            "E19" => Ping,
            "E20" => MegabitPerSecond,
            "E21" => Shares,
            "E22" => TEU,
            "E23" => TyreE23,
            "XTE" => TyreXTE,
            "E25" => ActiveUnit,
            "E27" => Dose,
            "E28" => AirDryTon,
            "E30" => Strand,
            "E31" => SquareMetrePerLitre,
            "E32" => LitrePerHour,
            "E33" => FootPerThousand,
            "E34" => Gigabyte,
            "E35" => Terabyte,
            "E36" => Petabyte,
            "E37" => Pixel,
            "E38" => Megapixel,
            "E39" => DotsPerInch,
            "E4" => GrossKilogram,
            "E40" => PartPerHundredThousand,
            "E41" => KilogramforcePerSquareMillimetre,
            "E42" => KilogramforcePerSquareCentimetre,
            "E43" => JoulePerSquareCentimetre,
            "E44" => KilogramforceMetrePerSquareCentimetre,
            "E45" => Milliohm,
            "E46" => KilowattHourPerCubicMetre,
            "E47" => KilowattHourPerKelvin,
            "E48" => ServiceUnit,
            "E49" => WorkingDay,
            "E50" => AccountingUnit,
            "E51" => Job,
            "E52" => RunFoot,
            "E53" => Test,
            "E54" => Trip,
            "E55" => Use,
            "E56" => Well,
            "E57" => Zone,
            "E58" => ExabitPerSecond,
            "E59" => Exbibyte,
            "E60" => Pebibyte,
            "E61" => Tebibyte,
            "E62" => Gibibyte,
            "E63" => Mebibyte,
            "E64" => Kibibyte,
            "E65" => ExbibitPerMetre,
            "E66" => ExbibitPerSquareMetre,
            "E67" => ExbibitPerCubicMetre,
            "E68" => GigabytePerSecond,
            "E69" => GibibitPerMetre,
            "E70" => GibibitPerSquareMetre,
            "E71" => GibibitPerCubicMetre,
            "E72" => KibibitPerMetre,
            "E73" => KibibitPerSquareMetre,
            "E74" => KibibitPerCubicMetre,
            "E75" => MebibitPerMetre,
            "E76" => MebibitPerSquareMetre,
            "E77" => MebibitPerCubicMetre,
            "E78" => Petabit,
            "E79" => PetabitPerSecond,
            "E80" => PebibitPerMetre,
            "E81" => PebibitPerSquareMetre,
            "E82" => PebibitPerCubicMetre,
            "E83" => Terabit,
            "E84" => TerabitPerSecond,
            "E85" => TebibitPerMetre,
            "E86" => TebibitPerCubicMetre,
            "E87" => TebibitPerSquareMetre,
            "E88" => BitPerMetre,
            "E89" => BitPerSquareMetre,
            "E90" => ReciprocalCentimetre,
            "E91" => ReciprocalDay,
            "E92" => CubicDecimetrePerHour,
            "E93" => KilogramPerHour,
            "E94" => KilomolePerSecond,
            "E95" => MolePerSecond,
            "E96" => DegreePerSecond,
            "E97" => MillimetrePerDegreeCelciusMetre,
            "E98" => DegreeCelsiusPerKelvin,
            "E99" => HectopascalPerBar,
            "EA" => Each,
            "EB" => ElectronicMailBox,
            "EQ" => EquivalentGallon,
            "F01" => BitPerCubicMetre,
            "F02" => KelvinPerKelvin,
            "F03" => KilopascalPerBar,
            "F04" => MillibarPerBar,
            "F05" => MegapascalPerBar,
            "F06" => PoisePerBar,
            "F07" => PascalPerBar,
            "F08" => MilliamperePerInch,
            "F10" => KelvinPerHour,
            "F11" => KelvinPerMinute,
            "F12" => KelvinPerSecond,
            "F13" => Slug,
            "F14" => GramPerKelvin,
            "F15" => KilogramPerKelvin,
            "F16" => MilligramPerKelvin,
            "F17" => PoundforcePerFoot,
            "F18" => KilogramSquareCentimetre,
            "F19" => KilogramSquareMillimetre,
            "F20" => PoundInchSquared,
            "F21" => PoundforceInch,
            "F22" => PoundforceFootPerAmpere,
            "F23" => GramPerCubicDecimetre,
            "F24" => KilogramPerKilomol,
            "F25" => GramPerHertz,
            "F26" => GramPerDay,
            "F27" => GramPerHour,
            "F28" => GramPerMinute,
            "F29" => GramPerSecond,
            "F30" => KilogramPerDay,
            "F31" => KilogramPerMinute,
            "F32" => MilligramPerDay,
            "F33" => MilligramPerMinute,
            "F34" => MilligramPerSecond,
            "F35" => GramPerDayKelvin,
            "F36" => GramPerHourKelvin,
            "F37" => GramPerMinuteKelvin,
            "F38" => GramPerSecondKelvin,
            "F39" => KilogramPerDayKelvin,
            "F40" => KilogramPerHourKelvin,
            "F41" => KilogramPerMinuteKelvin,
            "F42" => KilogramPerSecondKelvin,
            "F43" => MilligramPerDayKelvin,
            "F44" => MilligramPerHourKelvin,
            "F45" => MilligramPerMinuteKelvin,
            "F46" => MilligramPerSecondKelvin,
            "F47" => NewtonPerMillimetre,
            "F48" => PoundforcePerInch,
            "F49" => RodUnitOfDistance,
            "F50" => MicrometrePerKelvin,
            "F51" => CentimetrePerKelvin,
            "F52" => MetrePerKelvin,
            "F53" => MillimetrePerKelvin,
            "F54" => MilliohmPerMetre,
            "F55" => OhmPerMileStatuteMile,
            "F56" => OhmPerKilometre,
            "F57" => MilliamperePerPoundforcePerSquareInch,
            "F58" => ReciprocalBar,
            "F59" => MilliamperePerBar,
            "F60" => DegreeCelsiusPerBar,
            "F61" => KelvinPerBar,
            "F62" => GramPerDayBar,
            "F63" => GramPerHourBar,
            "F64" => GramPerMinuteBar,
            "F65" => GramPerSecondBar,
            "F66" => KilogramPerDayBar,
            "F67" => KilogramPerHourBar,
            "F68" => KilogramPerMinuteBar,
            "F69" => KilogramPerSecondBar,
            "F70" => MilligramPerDayBar,
            "F71" => MilligramPerHourBar,
            "F72" => MilligramPerMinuteBar,
            "F73" => MilligramPerSecondBar,
            "F74" => GramPerBar,
            "F75" => MilligramPerBar,
            "F76" => MilliamperePerMillimetre,
            "F77" => PascalSecondPerKelvin,
            "F78" => InchOfWater,
            "F79" => InchOfMercury,
            "F80" => WaterHorsePower,
            "F81" => BarPerKelvin,
            "F82" => HectopascalPerKelvin,
            "F83" => KilopascalPerKelvin,
            "F84" => MillibarPerKelvin,
            "F85" => MegapascalPerKelvin,
            "F86" => PoisePerKelvin,
            "F87" => VoltPerLitreMinute,
            "F88" => NewtonCentimetre,
            "F89" => NewtonMetrePerDegree,
            "F90" => NewtonMetrePerAmpere,
            "F91" => BarLitrePerSecond,
            "F92" => BarCubicMetrePerSecond,
            "F93" => HectopascalLitrePerSecond,
            "F94" => HectopascalCubicMetrePerSecond,
            "F95" => MillibarLitrePerSecond,
            "F96" => MillibarCubicMetrePerSecond,
            "F97" => MegapascalLitrePerSecond,
            "F98" => MegapascalCubicMetrePerSecond,
            "F99" => PascalLitrePerSecond,
            "FAH" => DegreeFahrenheit,
            "FAR" => Farad,
            "FBM" => FibreMetre,
            "FC" => ThousandCubicFoot,
            "FF" => HundredCubicMetre,
            "FH" => Micromole,
            "FIT" => FailuresInTime,
            "FL" => FlakeTon,
            "FOT" => Foot,
            "FP" => PoundPerSquareFoot,
            "FR" => FootPerMinute,
            "FS" => FootPerSecond,
            "FTK" => SquareFoot,
            "FTQ" => CubicFoot,
            "G01" => PascalCubicMetrePerSecond,
            "G04" => CentimetrePerBar,
            "G05" => MetrePerBar,
            "G06" => MillimetrePerBar,
            "G08" => SquareInchPerSecond,
            "G09" => SquareMetrePerSecondKelvin,
            "G10" => StokesPerKelvin,
            "G11" => GramPerCubicCentimetreBar,
            "G12" => GramPerCubicDecimetreBar,
            "G13" => GramPerLitreBar,
            "G14" => GramPerCubicMetreBar,
            "G15" => GramPerMillilitreBar,
            "G16" => KilogramPerCubicCentimetreBar,
            "G17" => KilogramPerLitreBar,
            "G18" => KilogramPerCubicMetreBar,
            "G19" => NewtonMetrePerKilogram,
            "G2" => USGallonPerMinute,
            "G20" => PoundforceFootPerPound,
            "G21" => CupUnitOfVolume,
            "G23" => Peck,
            "G24" => TablespoonUS,
            "G25" => TeaspoonUS,
            "G26" => Stere,
            "G27" => CubicCentimetrePerKelvin,
            "G28" => LitrePerKelvin,
            "G29" => CubicMetrePerKelvin,
            "G3" => ImperialGallonPerMinute,
            "G30" => MillilitrePerKelvin,
            "G31" => KilogramPerCubicCentimetre,
            "G32" => OunceAvoirdupoisPerCubicYard,
            "G33" => GramPerCubicCentimetreKelvin,
            "G34" => GramPerCubicDecimetreKelvin,
            "G35" => GramPerLitreKelvin,
            "G36" => GramPerCubicMetreKelvin,
            "G37" => GramPerMillilitreKelvin,
            "G38" => KilogramPerCubicCentimetreKelvin,
            "G39" => KilogramPerLitreKelvin,
            "G40" => KilogramPerCubicMetreKelvin,
            "G41" => SquareMetrePerSecondBar,
            "G42" => MicrosiemensPerCentimetre,
            "G43" => MicrosiemensPerMetre,
            "G44" => NanosiemensPerCentimetre,
            "G45" => NanosiemensPerMetre,
            "G46" => StokesPerBar,
            "G47" => CubicCentimetrePerDay,
            "G48" => CubicCentimetrePerHour,
            "G49" => CubicCentimetrePerMinute,
            "G50" => GallonUSPerHour,
            "G51" => LitrePerSecond,
            "G52" => CubicMetrePerDay,
            "G53" => CubicMetrePerMinute,
            "G54" => MillilitrePerDay,
            "G55" => MillilitrePerHour,
            "G56" => CubicInchPerHour,
            "G57" => CubicInchPerMinute,
            "G58" => CubicInchPerSecond,
            "G59" => MilliamperePerLitreMinute,
            "G60" => VoltPerBar,
            "G61" => CubicCentimetrePerDayKelvin,
            "G62" => CubicCentimetrePerHourKelvin,
            "G63" => CubicCentimetrePerMinuteKelvin,
            "G64" => CubicCentimetrePerSecondKelvin,
            "G65" => LitrePerDayKelvin,
            "G66" => LitrePerHourKelvin,
            "G67" => LitrePerMinuteKelvin,
            "G68" => LitrePerSecondKelvin,
            "G69" => CubicMetrePerDayKelvin,
            "G70" => CubicMetrePerHourKelvin,
            "G71" => CubicMetrePerMinuteKelvin,
            "G72" => CubicMetrePerSecondKelvin,
            "G73" => MillilitrePerDayKelvin,
            "G74" => MillilitrePerHourKelvin,
            "G75" => MillilitrePerMinuteKelvin,
            "G76" => MillilitrePerSecondKelvin,
            "G77" => MillimetreToTheFourthPower,
            "G78" => CubicCentimetrePerDayBar,
            "G79" => CubicCentimetrePerHourBar,
            "G80" => CubicCentimetrePerMinuteBar,
            "G81" => CubicCentimetrePerSecondBar,
            "G82" => LitrePerDayBar,
            "G83" => LitrePerHourBar,
            "G84" => LitrePerMinuteBar,
            "G85" => LitrePerSecondBar,
            "G86" => CubicMetrePerDayBar,
            "G87" => CubicMetrePerHourBar,
            "G88" => CubicMetrePerMinuteBar,
            "G89" => CubicMetrePerSecondBar,
            "G90" => MillilitrePerDayBar,
            "G91" => MillilitrePerHourBar,
            "G92" => MillilitrePerMinuteBar,
            "G93" => MillilitrePerSecondBar,
            "G94" => CubicCentimetrePerBar,
            "G95" => LitrePerBar,
            "G96" => CubicMetrePerBar,
            "G97" => MillilitrePerBar,
            "G98" => MicrohenryPerKiloohm,
            "G99" => MicrohenryPerOhm,
            "GB" => GallonUSPerDay,
            "GBQ" => Gigabecquerel,
            "GDW" => GramDryWeight,
            "GE" => PoundPerGallonUS,
            "GF" => GramPerMetreGramPer100Centimetres,
            "GFI" => GramOfFissileIsotope,
            "GGR" => GreatGross,
            "GIA" => GillUS,
            "GIC" => GramIncludingContainer,
            "GII" => GillUK,
            "GIP" => GramIncludingInnerPackaging,
            "GJ" => GramPerMillilitre,
            "GL" => GramPerLitre,
            "GLD" => DryGallonUS,
            "GLI" => GallonUK,
            "GLL" => GallonUS,
            "GM" => GramPerSquareMetre,
            "GO" => MilligramPerSquareMetre,
            "GP" => MilligramPerCubicMetre,
            "GQ" => MicrogramPerCubicMetre,
            "GRM" => Gram,
            "GRN" => Grain,
            "GRO" => Gross,
            "GV" => Gigajoule,
            "GWH" => GigawattHour,
            "H03" => HenryPerKiloohm,
            "H04" => HenryPerOhm,
            "H05" => MillihenryPerKiloohm,
            "H06" => MillihenryPerOhm,
            "H07" => PascalSecondPerBar,
            "H08" => Microbecquerel,
            "H09" => ReciprocalYear,
            "H10" => ReciprocalHour,
            "H11" => ReciprocalMonth,
            "H12" => DegreeCelsiusPerHour,
            "H13" => DegreeCelsiusPerMinute,
            "H14" => DegreeCelsiusPerSecond,
            "H15" => SquareCentimetrePerGram,
            "H16" => SquareDecametre,
            "H18" => SquareHectometre,
            "H19" => CubicHectometre,
            "H20" => CubicKilometre,
            "H21" => Blank,
            "H22" => VoltSquareInchPerPoundforce,
            "H23" => VoltPerInch,
            "H24" => VoltPerMicrosecond,
            "H25" => PercentPerKelvin,
            "H26" => OhmPerMetre,
            "H27" => DegreePerMetre,
            "H28" => MicrofaradPerKilometre,
            "H29" => MicrogramPerLitre,
            "H30" => SquareMicrometreSquareMicron,
            "H31" => AmperePerKilogram,
            "H32" => AmpereSquaredSecond,
            "H33" => FaradPerKilometre,
            "H34" => HertzMetre,
            "H35" => KelvinMetrePerWatt,
            "H36" => MegaohmPerKilometre,
            "H37" => MegaohmPerMetre,
            "H38" => Megaampere,
            "H39" => MegahertzKilometre,
            "H40" => NewtonPerAmpere,
            "H41" => NewtonMetreWattToThePowerMinus05,
            "H42" => PascalPerMetre,
            "H43" => SiemensPerCentimetre,
            "H44" => Teraohm,
            "H45" => VoltSecondPerMetre,
            "H46" => VoltPerSecond,
            "H47" => WattPerCubicMetre,
            "H48" => Attofarad,
            "H49" => CentimetrePerHour,
            "H50" => ReciprocalCubicCentimetre,
            "H51" => DecibelPerKilometre,
            "H52" => DecibelPerMetre,
            "H53" => KilogramPerBar,
            "H54" => KilogramPerCubicDecimetreKelvin,
            "H55" => KilogramPerCubicDecimetreBar,
            "H56" => KilogramPerSquareMetreSecond,
            "H57" => InchPerTwoPiRadiant,
            "H58" => MetrePerVoltSecond,
            "H59" => SquareMetrePerNewton,
            "H60" => CubicMetrePerCubicMetre,
            "H61" => MillisiemensPerCentimetre,
            "H62" => MillivoltPerMinute,
            "H63" => MilligramPerSquareCentimetre,
            "H64" => MilligramPerGram,
            "H65" => MillilitrePerCubicMetre,
            "H66" => MillimetrePerYear,
            "H67" => MillimetrePerHour,
            "H68" => MillimolePerGram,
            "H69" => PicopascalPerKilometre,
            "H70" => Picosecond,
            "H71" => PercentPerMonth,
            "H72" => PercentPerHectobar,
            "H73" => PercentPerDecakelvin,
            "H74" => WattPerMetre,
            "H75" => Decapascal,
            "H76" => GramPerMillimetre,
            "H77" => ModuleWidth,
            "H79" => FrenchGauge,
            "H80" => RackUnit,
            "H81" => MillimetrePerMinute,
            "H82" => BigPoint,
            "H83" => LitrePerKilogram,
            "H84" => GramMillimetre,
            "H85" => ReciprocalWeek,
            "H87" => PieceH87,
            "XPP" => PieceXPP,
            "H88" => MegaohmKilometre,
            "H89" => PercentPerOhm,
            "H90" => PercentPerDegree,
            "H91" => PercentPerTenThousand,
            "H92" => PercentPerOneHundredThousand,
            "H93" => PercentPerHundred,
            "H94" => PercentPerThousand,
            "H95" => PercentPerVolt,
            "H96" => PercentPerBar,
            "H98" => PercentPerInch,
            "H99" => PercentPerMetre,
            "HA" => Hank,
            "HBA" => Hectobar,
            "HBX" => HundredBoxes,
            "HC" => HundredCount,
            "HDW" => HundredKilogramDryWeight,
            "HEA" => Head,
            "HGM" => Hectogram,
            "HH" => HundredCubicFoot,
            "HIU" => HundredInternationalUnit,
            "HKM" => HundredKilogramNetMass,
            "HLT" => Hectolitre,
            "HM" => MilePerHourStatuteMile,
            "HMQ" => MillionCubicMetre,
            "HMT" => Hectometre,
            "HPA" => HectolitreOfPureAlcohol,
            "HTZ" => Hertz,
            "HUR" => Hour,
            "IA" => InchPoundPoundInch,
            "IE" => Person,
            "INH" => Inch,
            "INK" => SquareInch,
            "INQ" => CubicInch,
            "ISD" => InternationalSugarDegree,
            "IU" => InchPerSecond,
            "IUG" => InternationalUnitPerGram,
            "IV" => InchPerSecondSquared,
            "J10" => PercentPerMillimetre,
            "J12" => PerMillePerPsi,
            "J13" => DegreeAPI,
            "J14" => DegreeBaumeOriginScale,
            "J15" => DegreeBaumeUSHeavy,
            "J16" => DegreeBaumeUSLight,
            "J17" => DegreeBalling,
            "J18" => DegreeBrix,
            "J19" => DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical,
            "J2" => JoulePerKilogram,
            "J20" => DegreeFahrenheitPerKelvin,
            "J21" => DegreeFahrenheitPerBar,
            "J22" => DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable,
            "J23" => DegreeFahrenheitPerHour,
            "J24" => DegreeFahrenheitPerMinute,
            "J25" => DegreeFahrenheitPerSecond,
            "J26" => ReciprocalDegreeFahrenheit,
            "J27" => DegreeOechsle,
            "J28" => DegreeRankinePerHour,
            "J29" => DegreeRankinePerMinute,
            "J30" => DegreeRankinePerSecond,
            "J31" => DegreeTwaddell,
            "J32" => Micropoise,
            "J33" => MicrogramPerKilogram,
            "J34" => MicrogramPerCubicMetreKelvin,
            "J35" => MicrogramPerCubicMetreBar,
            "J36" => MicrolitrePerLitre,
            "J38" => Baud,
            "J39" => BritishThermalUnitMean,
            "J40" => BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit,
            "J41" => BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit,
            "J42" => BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit,
            "J43" => BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit,
            "J44" => BritishThermalUnitInternationalTablePerMinute,
            "J45" => BritishThermalUnitInternationalTablePerSecond,
            "J46" => BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit,
            "J47" => BritishThermalUnitThermochemicalPerHour,
            "J48" => BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit,
            "J49" => BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit,
            "J50" => BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit,
            "J51" => BritishThermalUnitThermochemicalPerMinute,
            "J52" => BritishThermalUnitThermochemicalPerSecond,
            "J53" => CoulombSquareMetrePerKilogram,
            "J54" => Megabaud,
            "J55" => WattSecond,
            "J56" => BarPerBar,
            "J57" => BarrelUKPetroleum,
            "J58" => BarrelUKPetroleumPerMinute,
            "J59" => BarrelUKPetroleumPerDay,
            "J60" => BarrelUKPetroleumPerHour,
            "J61" => BarrelUKPetroleumPerSecond,
            "J62" => BarrelUSPetroleumPerHour,
            "J63" => BarrelUSPetroleumPerSecond,
            "J64" => BushelUKPerDay,
            "J65" => BushelUKPerHour,
            "J66" => BushelUKPerMinute,
            "J67" => BushelUKPerSecond,
            "J68" => BushelUSDryPerDay,
            "J69" => BushelUSDryPerHour,
            "J70" => BushelUSDryPerMinute,
            "J71" => BushelUSDryPerSecond,
            "J72" => CentinewtonMetre,
            "J73" => CentipoisePerKelvin,
            "J74" => CentipoisePerBar,
            "J75" => CalorieMean,
            "J76" => CalorieInternationalTablePerGramDegreeCelsius,
            "J78" => CalorieThermochemicalPerCentimetreSecondDegreeCelsius,
            "J79" => CalorieThermochemicalPerGramDegreeCelsius,
            "J81" => CalorieThermochemicalPerMinute,
            "J82" => CalorieThermochemicalPerSecond,
            "J83" => Clo,
            "J84" => CentimetrePerSecondKelvin,
            "J85" => CentimetrePerSecondBar,
            "J87" => CubicCentimetrePerCubicMetre,
            "J90" => CubicDecimetrePerDay,
            "J91" => CubicDecimetrePerCubicMetre,
            "J92" => CubicDecimetrePerMinute,
            "J93" => CubicDecimetrePerSecond,
            "J95" => OunceUKFluidPerDay,
            "J96" => OunceUKFluidPerHour,
            "J97" => OunceUKFluidPerMinute,
            "J98" => OunceUKFluidPerSecond,
            "J99" => OunceUSFluidPerDay,
            "JE" => JoulePerKelvin,
            "JK" => MegajoulePerKilogram,
            "JM" => MegajoulePerCubicMetre,
            "JNT" => PipelineJoint,
            "JOU" => Joule,
            "JPS" => HundredMetre,
            "JWL" => NumberOfJewels,
            "K1" => KilowattDemand,
            "K10" => OunceUSFluidPerHour,
            "K11" => OunceUSFluidPerMinute,
            "K12" => OunceUSFluidPerSecond,
            "K13" => FootPerDegreeFahrenheit,
            "K14" => FootPerHour,
            "K15" => FootPoundforcePerHour,
            "K16" => FootPoundforcePerMinute,
            "K17" => FootPerPsi,
            "K18" => FootPerSecondDegreeFahrenheit,
            "K19" => FootPerSecondPsi,
            "K2" => KilovoltAmpereReactiveDemand,
            "K20" => ReciprocalCubicFoot,
            "K21" => CubicFootPerDegreeFahrenheit,
            "K22" => CubicFootPerDay,
            "K23" => CubicFootPerPsi,
            "K26" => GallonUKPerDay,
            "K27" => GallonUKPerHour,
            "K28" => GallonUKPerSecond,
            "K3" => KilovoltAmpereReactiveHour,
            "K30" => GallonUSLiquidPerSecond,
            "K31" => GramforcePerSquareCentimetre,
            "K32" => GillUKPerDay,
            "K33" => GillUKPerHour,
            "K34" => GillUKPerMinute,
            "K35" => GillUKPerSecond,
            "K36" => GillUSPerDay,
            "K37" => GillUSPerHour,
            "K38" => GillUSPerMinute,
            "K39" => GillUSPerSecond,
            "K40" => StandardAccelerationOfFreeFall,
            "K41" => GrainPerGallonUS,
            "K42" => HorsepowerBoiler,
            "K43" => HorsepowerElectric,
            "K45" => InchPerDegreeFahrenheit,
            "K46" => InchPerPsi,
            "K47" => InchPerSecondDegreeFahrenheit,
            "K48" => InchPerSecondPsi,
            "K49" => ReciprocalCubicInch,
            "K50" => Kilobaud,
            "K51" => KilocalorieMean,
            "K52" => KilocalorieInternationalTablePerHourMetreDegreeCelsius,
            "K53" => KilocalorieThermochemical,
            "K54" => KilocalorieThermochemicalPerMinute,
            "K55" => KilocalorieThermochemicalPerSecond,
            "K58" => KilomolePerHour,
            "K59" => KilomolePerCubicMetreKelvin,
            "K6" => Kilolitre,
            "K60" => KilomolePerCubicMetreBar,
            "K61" => KilomolePerMinute,
            "K62" => LitrePerLitre,
            "K63" => ReciprocalLitre,
            "K64" => PoundAvoirdupoisPerDegreeFahrenheit,
            "K65" => PoundAvoirdupoisSquareFoot,
            "K66" => PoundAvoirdupoisPerDay,
            "K67" => PoundPerFootHour,
            "K68" => PoundPerFootSecond,
            "K69" => PoundAvoirdupoisPerCubicFootDegreeFahrenheit,
            "K70" => PoundAvoirdupoisPerCubicFootPsi,
            "K71" => PoundAvoirdupoisPerGallonUK,
            "K73" => PoundAvoirdupoisPerHourDegreeFahrenheit,
            "K74" => PoundAvoirdupoisPerHourPsi,
            "K75" => PoundAvoirdupoisPerCubicInchDegreeFahrenheit,
            "K76" => PoundAvoirdupoisPerCubicInchPsi,
            "K77" => PoundAvoirdupoisPerPsi,
            "K78" => PoundAvoirdupoisPerMinute,
            "K79" => PoundAvoirdupoisPerMinuteDegreeFahrenheit,
            "K80" => PoundAvoirdupoisPerMinutePsi,
            "K81" => PoundAvoirdupoisPerSecond,
            "K82" => PoundAvoirdupoisPerSecondDegreeFahrenheit,
            "K83" => PoundAvoirdupoisPerSecondPsi,
            "K84" => PoundPerCubicYard,
            "K85" => PoundforcePerSquareFoot,
            "K86" => PoundforcePerSquareInchDegreeFahrenheit,
            "K87" => PsiCubicInchPerSecond,
            "K88" => PsiLitrePerSecond,
            "K89" => PsiCubicMetrePerSecond,
            "K90" => PsiCubicYardPerSecond,
            "K91" => PoundforceSecondPerSquareFoot,
            "K92" => PoundforceSecondPerSquareInch,
            "K93" => ReciprocalPsi,
            "K94" => QuartUKLiquidPerDay,
            "K95" => QuartUKLiquidPerHour,
            "K96" => QuartUKLiquidPerMinute,
            "K97" => QuartUKLiquidPerSecond,
            "K98" => QuartUSLiquidPerDay,
            "K99" => QuartUSLiquidPerHour,
            "KA" => Cake,
            "KAT" => Katal,
            "KB" => Kilocharacter,
            "KBA" => Kilobar,
            "KCC" => KilogramOfCholineChloride,
            "KDW" => KilogramDrainedNetWeight,
            "KEL" => Kelvin,
            "KGM" => Kilogram,
            "KGS" => KilogramPerSecond,
            "KHY" => KilogramOfHydrogenPeroxide,
            "KHZ" => Kilohertz,
            "KI" => KilogramPerMillimetreWidth,
            "KIC" => KilogramIncludingContainer,
            "KIP" => KilogramIncludingInnerPackaging,
            "KJ" => Kilosegment,
            "KJO" => Kilojoule,
            "KL" => KilogramPerMetre,
            "KLK" => LacticDryMaterialPercentage,
            "KLX" => Kilolux,
            "KMA" => KilogramOfMethylamine,
            "KMH" => KilometrePerHour,
            "KMK" => SquareKilometre,
            "KMQ" => KilogramPerCubicMetre,
            "KMT" => Kilometre,
            "KNI" => KilogramOfNitrogen,
            "KNM" => KilonewtonPerSquareMetre,
            "KNS" => KilogramNamedSubstance,
            "KNT" => Knot,
            "KO" => MilliequivalenceCausticPotashPerGramOfProduct,
            "KPA" => Kilopascal,
            "KPH" => KilogramOfPotassiumHydroxideCausticPotash,
            "KPO" => KilogramOfPotassiumOxide,
            "KPP" => KilogramOfPhosphorusPentoxidePhosphoricAnhydride,
            "KR" => Kiloroentgen,
            "KSD" => KilogramOfSubstance90Dry,
            "KSH" => KilogramOfSodiumHydroxideCausticSoda,
            "KT" => KitKT,
            "XKI" => KitXKI,
            "KTN" => Kilotonne,
            "KUR" => KilogramOfUranium,
            "KVA" => KilovoltAmpere,
            "KVR" => Kilovar,
            "KVT" => Kilovolt,
            "KW" => KilogramPerMillimetre,
            "KWH" => KilowattHour,
            "KWY" => KilowattYear,
            "KWN" => KilowattHourPerNormalizedCubicMetre,
            "KWO" => KilogramOfTungstenTrioxide,
            "KWS" => KilowattHourPerStandardCubicMetre,
            "KWT" => Kilowatt,
            "KX" => MillilitrePerKilogram,
            "L10" => QuartUSLiquidPerMinute,
            "L11" => QuartUSLiquidPerSecond,
            "L12" => MetrePerSecondKelvin,
            "L13" => MetrePerSecondBar,
            "L14" => SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable,
            "L15" => MillipascalSecondPerKelvin,
            "L16" => MillipascalSecondPerBar,
            "L17" => MilligramPerCubicMetreKelvin,
            "L18" => MilligramPerCubicMetreBar,
            "L19" => MillilitrePerLitre,
            "L2" => LitrePerMinute,
            "L20" => ReciprocalCubicMillimetre,
            "L21" => CubicMillimetrePerCubicMetre,
            "L23" => MolePerHour,
            "L24" => MolePerKilogramKelvin,
            "L25" => MolePerKilogramBar,
            "L26" => MolePerLitreKelvin,
            "L27" => MolePerLitreBar,
            "L28" => MolePerCubicMetreKelvin,
            "L29" => MolePerCubicMetreBar,
            "L30" => MolePerMinute,
            "L31" => MilliroentgenAequivalentMen,
            "L32" => NanogramPerKilogram,
            "L33" => OunceAvoirdupoisPerDay,
            "L34" => OunceAvoirdupoisPerHour,
            "L35" => OunceAvoirdupoisPerMinute,
            "L36" => OunceAvoirdupoisPerSecond,
            "L37" => OunceAvoirdupoisPerGallonUK,
            "L38" => OunceAvoirdupoisPerGallonUS,
            "L39" => OunceAvoirdupoisPerCubicInch,
            "L40" => OunceAvoirdupoisForce,
            "L41" => OunceAvoirdupoisForceInch,
            "L42" => PicosiemensPerMetre,
            "L43" => PeckUK,
            "L44" => PeckUKPerDay,
            "L45" => PeckUKPerHour,
            "L46" => PeckUKPerMinute,
            "L47" => PeckUKPerSecond,
            "L48" => PeckUSDryPerDay,
            "L49" => PeckUSDryPerHour,
            "L50" => PeckUSDryPerMinute,
            "L51" => PeckUSDryPerSecond,
            "L52" => PsiPerPsi,
            "L53" => PintUKPerDay,
            "L54" => PintUKPerHour,
            "L55" => PintUKPerMinute,
            "L56" => PintUKPerSecond,
            "L57" => PintUSLiquidPerDay,
            "L58" => PintUSLiquidPerHour,
            "L59" => PintUSLiquidPerMinute,
            "L60" => PintUSLiquidPerSecond,
            "L63" => SlugPerDay,
            "L64" => SlugPerFootSecond,
            "L65" => SlugPerCubicFoot,
            "L66" => SlugPerHour,
            "L67" => SlugPerMinute,
            "L68" => SlugPerSecond,
            "L69" => TonnePerKelvin,
            "L70" => TonnePerBar,
            "L71" => TonnePerDay,
            "L72" => TonnePerDayKelvin,
            "L73" => TonnePerDayBar,
            "L74" => TonnePerHourKelvin,
            "L75" => TonnePerHourBar,
            "L76" => TonnePerCubicMetreKelvin,
            "L77" => TonnePerCubicMetreBar,
            "L78" => TonnePerMinute,
            "L79" => TonnePerMinuteKelvin,
            "L80" => TonnePerMinuteBar,
            "L81" => TonnePerSecond,
            "L82" => TonnePerSecondKelvin,
            "L83" => TonnePerSecondBar,
            "L84" => TonUKShipping,
            "L85" => TonLongPerDay,
            "L86" => TonUSShipping,
            "L87" => TonShortPerDegreeFahrenheit,
            "L88" => TonShortPerDay,
            "L89" => TonShortPerHourDegreeFahrenheit,
            "L90" => TonShortPerHourPsi,
            "L91" => TonShortPerPsi,
            "L92" => TonUKLongPerCubicYard,
            "L93" => TonUSShortPerCubicYard,
            "L94" => TonforceUSShort,
            "L95" => CommonYear,
            "L96" => SiderealYear,
            "L98" => YardPerDegreeFahrenheit,
            "L99" => YardPerPsi,
            "LA" => PoundPerCubicInch,
            "LAC" => LactoseExcessPercentage,
            "LBR" => Pound,
            "LBT" => TroyPoundUS,
            "LD" => LitrePerDay,
            "LEF" => Leaf,
            "LF" => LinearFoot,
            "LH" => LabourHour,
            "LK" => Link,
            "LM" => LinearMetre,
            "LN" => Length,
            "LO" => LotUnitOfProcurement,
            "LP" => LiquidPound,
            "LPA" => LitreOfPureAlcohol,
            "LR" => Layer,
            "LS" => LumpSum,
            "LTN" => TonUKOrLongTonUS,
            "LTR" => Litre,
            "LUB" => MetricTonLubricatingOil,
            "LUM" => Lumen,
            "LUX" => Lux,
            "LY" => LinearYard,
            "M1" => MilligramPerLitre,
            "M10" => ReciprocalCubicYard,
            "M11" => CubicYardPerDegreeFahrenheit,
            "M12" => CubicYardPerDay,
            "M13" => CubicYardPerHour,
            "M14" => CubicYardPerPsi,
            "M15" => CubicYardPerMinute,
            "M16" => CubicYardPerSecond,
            "M17" => KilohertzMetre,
            "M18" => GigahertzMetre,
            "M19" => Beaufort,
            "M20" => ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne,
            "M21" => ReciprocalKilovoltAmpereReciprocalHour,
            "M22" => MillilitrePerSquareCentimetreMinute,
            "M23" => NewtonPerCentimetre,
            "M24" => OhmKilometre,
            "M25" => PercentPerDegreeCelsius,
            "M26" => GigaohmPerMetre,
            "M27" => MegahertzMetre,
            "M29" => KilogramPerKilogram,
            "M30" => ReciprocalVoltAmpereReciprocalSecond,
            "M31" => KilogramPerKilometre,
            "M32" => PascalSecondPerLitre,
            "M33" => MillimolePerLitre,
            "M34" => NewtonMetrePerSquareMetre,
            "M35" => MillivoltAmpere,
            "M36" => Unit30dayMonth,
            "M37" => ActualPer360,
            "M38" => KilometrePerSecondSquared,
            "M39" => CentimetrePerSecondSquared,
            "M4" => MonetaryValue,
            "M40" => YardPerSecondSquared,
            "M41" => MillimetrePerSecondSquared,
            "M42" => MileStatuteMilePerSecondSquared,
            "M43" => Mil,
            "M44" => Revolution,
            "M45" => DegreeUnitOfAnglePerSecondSquared,
            "M46" => RevolutionPerMinute,
            "M47" => CircularMil,
            "M48" => SquareMileBasedOnUSSurveyFoot,
            "M49" => ChainBasedOnUSSurveyFoot,
            "M5" => Microcurie,
            "M50" => Furlong,
            "M51" => FootUSSurvey,
            "M52" => MileBasedOnUSSurveyFoot,
            "M53" => MetrePerPascal,
            "M55" => MetrePerRadiant,
            "M56" => Shake,
            "M57" => MilePerMinute,
            "M58" => MilePerSecond,
            "M59" => MetrePerSecondPascal,
            "M60" => MetrePerHour,
            "M61" => InchPerYear,
            "M62" => KilometrePerSecond,
            "M63" => InchPerMinute,
            "M64" => YardPerSecond,
            "M65" => YardPerMinute,
            "M66" => YardPerHour,
            "M67" => AcrefootBasedOnUSSurveyFoot,
            "M68" => Cord128Ft3,
            "M69" => CubicMileUKStatute,
            "M7" => Microinch,
            "M70" => TonRegister,
            "M71" => CubicMetrePerPascal,
            "M72" => Bel,
            "M73" => KilogramPerCubicMetrePascal,
            "M74" => KilogramPerPascal,
            "M75" => Kilopoundforce,
            "M76" => Poundal,
            "M77" => KilogramMetrePerSecondSquared,
            "M78" => Pond,
            "M79" => SquareFootPerHour,
            "M80" => StokesPerPascal,
            "M81" => SquareCentimetrePerSecond,
            "M82" => SquareMetrePerSecondPascal,
            "M84" => PoundPerYard,
            "M85" => TonAssay,
            "M86" => Pfund,
            "M87" => KilogramPerSecondPascal,
            "M88" => TonnePerMonth,
            "M89" => TonnePerYear,
            "M9" => MillionBtuPer1000CubicFoot,
            "M90" => KilopoundPerHour,
            "M91" => PoundPerPound,
            "M92" => PoundforceFoot,
            "M93" => NewtonMetrePerRadian,
            "M94" => KilogramMetre,
            "M95" => PoundalFoot,
            "M96" => PoundalInch,
            "M97" => DyneMetre,
            "M98" => KilogramCentimetrePerSecond,
            "M99" => GramCentimetrePerSecond,
            "MAH" => MegavoltAmpereReactiveHour,
            "MAL" => Megalitre,
            "MAM" => Megametre,
            "MAR" => Megavar,
            "MAW" => Megawatt,
            "MBE" => ThousandStandardBrickEquivalent,
            "MBF" => ThousandBoardFoot,
            "MBR" => Millibar,
            "MC" => Microgram,
            "MCU" => Millicurie,
            "MD" => AirDryMetricTon,
            "MGM" => Milligram,
            "MHZ" => Megahertz,
            "MIK" => SquareMileStatuteMile,
            "MIL" => Thousand,
            "MIN" => MinuteUnitOfTime,
            "MIO" => Million,
            "MIU" => MillionInternationalUnit,
            "MLD" => Milliard,
            "MLT" => Millilitre,
            "MMK" => SquareMillimetre,
            "MMQ" => CubicMillimetre,
            "MMT" => Millimetre,
            "MND" => KilogramDryWeight,
            "MON" => Month,
            "MPA" => Megapascal,
            "MQH" => CubicMetrePerHour,
            "MQS" => CubicMetrePerSecond,
            "MSK" => MetrePerSecondSquared,
            "MTK" => SquareMetre,
            "MTQ" => CubicMetre,
            "MTR" => Metre,
            "MTS" => MetrePerSecond,
            "MVA" => MegavoltAmpere,
            "MWH" => MegawattHour1000KwH,
            "N1" => PenCalorie,
            "N10" => PoundFootPerSecond,
            "N11" => PoundInchPerSecond,
            "N12" => Pferdestaerke,
            "N13" => CentimetreOfMercury0C,
            "N14" => CentimetreOfWater4C,
            "N15" => FootOfWater392F,
            "N16" => InchOfMercury32F,
            "N17" => InchOfMercury60F,
            "N18" => InchOfWater392F,
            "N19" => InchOfWater60F,
            "N20" => KipPerSquareInch,
            "N21" => PoundalPerSquareFoot,
            "N22" => OunceAvoirdupoisPerSquareInch,
            "N23" => ConventionalMetreOfWater,
            "N24" => GramPerSquareMillimetre,
            "N25" => PoundPerSquareYard,
            "N26" => PoundalPerSquareInch,
            "N27" => FootToTheFourthPower,
            "N28" => CubicDecimetrePerKilogram,
            "N29" => CubicFootPerPound,
            "N3" => PrintPoint,
            "N30" => CubicInchPerPound,
            "N31" => KilonewtonPerMetre,
            "N32" => PoundalPerInch,
            "N33" => PoundforcePerYard,
            "N34" => PoundalSecondPerSquareFoot,
            "N35" => PoisePerPascal,
            "N36" => NewtonSecondPerSquareMetre,
            "N37" => KilogramPerMetreSecond,
            "N38" => KilogramPerMetreMinute,
            "N39" => KilogramPerMetreDay,
            "N40" => KilogramPerMetreHour,
            "N41" => GramPerCentimetreSecond,
            "N42" => PoundalSecondPerSquareInch,
            "N43" => PoundPerFootMinute,
            "N44" => PoundPerFootDay,
            "N45" => CubicMetrePerSecondPascal,
            "N46" => FootPoundal,
            "N47" => InchPoundal,
            "N48" => WattPerSquareCentimetre,
            "N49" => WattPerSquareInch,
            "N50" => BritishThermalUnitInternationalTablePerSquareFootHour,
            "N51" => BritishThermalUnitThermochemicalPerSquareFootHour,
            "N52" => BritishThermalUnitThermochemicalPerSquareFootMinute,
            "N53" => BritishThermalUnitInternationalTablePerSquareFootSecond,
            "N54" => BritishThermalUnitThermochemicalPerSquareFootSecond,
            "N55" => BritishThermalUnitInternationalTablePerSquareInchSecond,
            "N56" => CalorieThermochemicalPerSquareCentimetreMinute,
            "N57" => CalorieThermochemicalPerSquareCentimetreSecond,
            "N58" => BritishThermalUnitInternationalTablePerCubicFoot,
            "N59" => BritishThermalUnitThermochemicalPerCubicFoot,
            "N60" => BritishThermalUnitInternationalTablePerDegreeFahrenheit,
            "N61" => BritishThermalUnitThermochemicalPerDegreeFahrenheit,
            "N62" => BritishThermalUnitInternationalTablePerDegreeRankine,
            "N63" => BritishThermalUnitThermochemicalPerDegreeRankine,
            "N64" => BritishThermalUnitThermochemicalPerPoundDegreeRankine,
            "N65" => KilocalorieInternationalTablePerGramKelvin,
            "N66" => BritishThermalUnit39F,
            "N67" => BritishThermalUnit59F,
            "N68" => BritishThermalUnit60F,
            "N69" => Calorie20C,
            "N70" => Quad1015Btuit,
            "N71" => ThermEC,
            "N72" => ThermUS,
            "N73" => BritishThermalUnitThermochemicalPerPound,
            "N74" => BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit,
            "N75" => BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit,
            "N76" => BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit,
            "N77" => BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit,
            "N78" => KilowattPerSquareMetreKelvin,
            "N79" => KelvinPerPascal,
            "N80" => WattPerMetreDegreeCelsius,
            "N81" => KilowattPerMetreKelvin,
            "N82" => KilowattPerMetreDegreeCelsius,
            "N83" => MetrePerDegreeCelciusMetre,
            "N84" => DegreeFahrenheitHourPerBritishThermalUnitInternationalTable,
            "N85" => DegreeFahrenheitHourPerBritishThermalUnitThermochemical,
            "N86" => DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable,
            "N87" => DegreeFahrenheitSecondPerBritishThermalUnitThermochemical,
            "N88" => DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch,
            "N89" => DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch,
            "N90" => Kilofarad,
            "N91" => ReciprocalJoule,
            "N92" => Picosiemens,
            "N93" => AmperePerPascal,
            "N94" => Franklin,
            "N95" => AmpereMinute,
            "N96" => Biot,
            "N97" => Gilbert,
            "N98" => VoltPerPascal,
            "N99" => Picovolt,
            "NA" => MilligramPerKilogram,
            "NAR" => NumberOfArticles,
            "NCL" => NumberOfCells,
            "NEW" => Newton,
            "NF" => Message,
            "NIL" => Nil,
            "NIU" => NumberOfInternationalUnits,
            "NL" => Load,
            "NM3" => NormalisedCubicMetre,
            "NMI" => NauticalMile,
            "NMP" => NumberOfPacks,
            "NPT" => NumberOfParts,
            "NT" => NetTon,
            "NU" => NewtonMetre,
            "NX" => PartPerThousand,
            "OA" => Panel,
            "ODE" => OzoneDepletionEquivalent,
            "ODG" => ODSGrams,
            "ODK" => ODSKilograms,
            "ODM" => ODSMilligrams,
            "OHM" => Ohm,
            "ON" => OuncePerSquareYard,
            "ONZ" => OunceAvoirdupois,
            "OPM" => OscillationsPerMinute,
            "OT" => OvertimeHour,
            "OZA" => FluidOunceUS,
            "OZI" => FluidOunceUK,
            "P1" => Percent,
            "P10" => CoulombPerMetre,
            "P11" => Kiloweber,
            "P12" => Gamma,
            "P13" => Kilotesla,
            "P14" => JoulePerSecond,
            "P15" => JoulePerMinute,
            "P16" => JoulePerHour,
            "P17" => JoulePerDay,
            "P18" => KilojoulePerSecond,
            "P19" => KilojoulePerMinute,
            "P2" => PoundPerFoot,
            "P20" => KilojoulePerHour,
            "P21" => KilojoulePerDay,
            "P22" => Nanoohm,
            "P23" => OhmCircularmilPerFoot,
            "P24" => Kilohenry,
            "P25" => LumenPerSquareFoot,
            "P26" => Phot,
            "P27" => Footcandle,
            "P28" => CandelaPerSquareInch,
            "P29" => Footlambert,
            "P30" => Lambert,
            "P31" => Stilb,
            "P32" => CandelaPerSquareFoot,
            "P33" => Kilocandela,
            "P34" => Millicandela,
            "P35" => Hefnerkerze,
            "P36" => InternationalCandle,
            "P37" => BritishThermalUnitInternationalTablePerSquareFoot,
            "P38" => BritishThermalUnitThermochemicalPerSquareFoot,
            "P39" => CalorieThermochemicalPerSquareCentimetre,
            "P40" => Langley,
            "P41" => DecadeLogarithmic,
            "P42" => PascalSquaredSecond,
            "P43" => BelPerMetre,
            "P44" => PoundMole,
            "P45" => PoundMolePerSecond,
            "P46" => PoundMolePerMinute,
            "P47" => KilomolePerKilogram,
            "P48" => PoundMolePerPound,
            "P49" => NewtonSquareMetrePerAmpere,
            "P5" => FivePack,
            "P50" => WeberMetre,
            "P51" => MolPerKilogramPascal,
            "P52" => MolPerCubicMetrePascal,
            "P53" => UnitPole,
            "P54" => MilligrayPerSecond,
            "P55" => MicrograyPerSecond,
            "P56" => NanograyPerSecond,
            "P57" => GrayPerMinute,
            "P58" => MilligrayPerMinute,
            "P59" => MicrograyPerMinute,
            "P60" => NanograyPerMinute,
            "P61" => GrayPerHour,
            "P62" => MilligrayPerHour,
            "P63" => MicrograyPerHour,
            "P64" => NanograyPerHour,
            "P65" => SievertPerSecond,
            "P66" => MillisievertPerSecond,
            "P67" => MicrosievertPerSecond,
            "P68" => NanosievertPerSecond,
            "P69" => RemPerSecond,
            "P70" => SievertPerHour,
            "P71" => MillisievertPerHour,
            "P72" => MicrosievertPerHour,
            "P73" => NanosievertPerHour,
            "P74" => SievertPerMinute,
            "P75" => MillisievertPerMinute,
            "P76" => MicrosievertPerMinute,
            "P77" => NanosievertPerMinute,
            "P78" => ReciprocalSquareInch,
            "P79" => PascalSquareMetrePerKilogram,
            "P80" => MillipascalPerMetre,
            "P81" => KilopascalPerMetre,
            "P82" => HectopascalPerMetre,
            "P83" => StandardAtmospherePerMetre,
            "P84" => TechnicalAtmospherePerMetre,
            "P85" => TorrPerMetre,
            "P86" => PsiPerInch,
            "P87" => CubicMetrePerSecondSquareMetre,
            "P88" => Rhe,
            "P89" => PoundforceFootPerInch,
            "P90" => PoundforceInchPerInch,
            "P91" => Perm0C,
            "P92" => Perm23C,
            "P93" => BytePerSecond,
            "P94" => KilobytePerSecond,
            "P95" => MegabytePerSecond,
            "P96" => ReciprocalVolt,
            "P97" => ReciprocalRadian,
            "P98" => PascalToThePowerSumOfStoichiometricNumbers,
            "P99" => MolePerCubivMetreToThePowerSumOfStoichiometricNumbers,
            "PAL" => Pascal,
            "PD" => Pad,
            "PFL" => ProofLitre,
            "PGL" => ProofGallon,
            "PI" => Pitch,
            "PLA" => DegreePlato,
            "PO" => PoundPerInchOfLength,
            "PQ" => PagePerInch,
            "PR" => Pair,
            "PS" => PoundforcePerSquareInch,
            "PTD" => DryPintUS,
            "PTI" => PintUK,
            "PTL" => LiquidPintUS,
            "PTN" => Portion,
            "Q10" => JoulePerTesla,
            "Q11" => Erlang,
            "Q12" => Octet,
            "Q13" => OctetPerSecond,
            "Q14" => Shannon,
            "Q15" => Hartley,
            "Q16" => NaturalUnitOfInformation,
            "Q17" => ShannonPerSecond,
            "Q18" => HartleyPerSecond,
            "Q19" => NaturalUnitOfInformationPerSecond,
            "Q20" => SecondPerKilogramm,
            "Q21" => WattSquareMetre,
            "Q22" => SecondPerRadianCubicMetre,
            "Q23" => WeberToThePowerMinusOne,
            "Q24" => ReciprocalInch,
            "Q25" => Dioptre,
            "Q26" => OnePerOne,
            "Q27" => NewtonMetrePerMetre,
            "Q28" => KilogramPerSquareMetrePascalSecond,
            "Q29" => MicrogramPerHectogram,
            "Q30" => PhPotentialOfHydrogen,
            "Q31" => KilojoulePerGram,
            "Q32" => Femtolitre,
            "Q33" => Picolitre,
            "Q34" => Nanolitre,
            "Q35" => MegawattsPerMinute,
            "Q36" => SquareMetrePerCubicMetre,
            "Q37" => StandardCubicMetrePerDay,
            "Q38" => StandardCubicMetrePerHour,
            "Q39" => NormalizedCubicMetrePerDay,
            "Q40" => NormalizedCubicMetrePerHour,
            "Q41" => JoulePerNormalisedCubicMetre,
            "Q42" => JoulePerStandardCubicMetre,
            "MNJ" => MegaJoulePerNormalisedCubicMetre,
            "Q3" => Meal,
            "QA" => PageFacsimile,
            "QAN" => QuarterOfAYear,
            "QB" => PageHardcopy,
            "QR" => Quire,
            "QTD" => DryQuartUS,
            "QTI" => QuartUK,
            "QTL" => LiquidQuartUS,
            "QTR" => QuarterUK,
            "R1" => Pica,
            "R9" => ThousandCubicMetre,
            "RH" => RunningOrOperatingHour,
            "RM" => Ream,
            "ROM" => Room,
            "RP" => PoundPerReam,
            "RPM" => RevolutionsPerMinute,
            "RPS" => RevolutionsPerSecond,
            "RT" => RevenueTonMile,
            "S3" => SquareFootPerSecond,
            "S4" => SquareMetrePerSecond,
            "SAN" => HalfYear6Months,
            "SCO" => Score,
            "SCR" => Scruple,
            "SEC" => SecondUnitOfTime,
            "SET" => Set,
            "SG" => Segment,
            "SIE" => Siemens,
            "SM3" => StandardCubicMetre,
            "SMI" => MileStatuteMile,
            "SQ" => Square,
            "SQR" => SquareRoofing,
            "SR" => Strip,
            "STC" => Stick,
            "STI" => StoneUK,
            "STK" => StickCigarette,
            "STL" => StandardLitre,
            "STN" => TonUSOrShortTonUKPerUS,
            "STW" => Straw,
            "SW" => Skein,
            "SX" => Shipment,
            "SYR" => Syringe,
            "T0" => TelecommunicationLineInService,
            "T3" => ThousandPiece,
            "TAH" => KiloampereHourThousandAmpereHour,
            "TAN" => TotalAcidNumber,
            "TI" => ThousandSquareInch,
            "TIC" => MetricTonIncludingContainer,
            "TIP" => MetricTonIncludingInnerPackaging,
            "TKM" => TonneKilometre,
            "TMS" => KilogramOfImportedMeatLessOffal,
            "TNE" => TonneMetricTon,
            "TP" => TenPack,
            "TPI" => TeethPerInch,
            "TPR" => TenPair,
            "TQD" => ThousandCubicMetrePerDay,
            "TRL" => TrillionEUR,
            "TST" => TenSet,
            "TTS" => TenThousandSticks,
            "U1" => Treatment,
            "U2" => TabletU2,
            "XT1" => TabletXT1,
            "UB" => TelecommunicationLineInServiceAverage,
            "UC" => TelecommunicationPort,
            "VA" => VoltAmperePerKilogram,
            "VLT" => Volt,
            "VP" => PercentVolume,
            "W2" => WetKilo,
            "WA" => WattPerKilogram,
            "WB" => WetPound,
            "WCD" => Cord,
            "WE" => WetTon,
            "WEB" => Weber,
            "WEE" => Week,
            "WG" => WineGallon,
            "WHR" => WattHour,
            "WM" => WorkingMonth,
            "WSD" => Standard,
            "WTT" => Watt,
            "X1" => GuntersChain,
            "YDK" => SquareYard,
            "YDQ" => CubicYard,
            "YRD" => Yard,
            "Z11" => HangingContainer,
            "ZP" => Page,
            "ZZ" => MutuallyDefinedZZ,
            "XZZ" => MutuallyDefinedXZZ,
            "MRW" => MetreWeek,
            "MKW" => SquareMetreWeek,
            "MQW" => CubicMetreWeek,
            "HWE" => PieceWeek,
            "MRD" => MetreDay,
            "MKD" => SquareMetreDay,
            "MQD" => CubicMetreDay,
            "HAD" => PieceDay,
            "MRM" => MetreMonth,
            "MKM" => SquareMetreMonth,
            "MQM" => CubicMetreMonth,
            "HMO" => PieceMonth,
            "DBW" => DecibelWatt,
            "DBM" => Decibelmilliwatts,
            "FNU" => FormazinNephelometricUnit,
            "NTU" => NephelometricTurbidityUnit,
            "MTZ" => Millihertz,
            "Z9" => Nanomole,
            "X1A" => DrumSteel,
            "X1B" => DrumAluminium,
            "X1D" => DrumPlywood,
            "X1F" => ContainerFlexible,
            "X1G" => DrumFibre,
            "X1W" => DrumWooden,
            "X2C" => BarrelWooden,
            "X3A" => JerricanSteel,
            "X3H" => JerricanPlastic,
            "X43" => BagSuperBulk,
            "X44" => BagPolybag,
            "X4A" => BoxSteel,
            "X4B" => BoxAluminium,
            "X4C" => BoxNaturalWood,
            "X4D" => BoxPlywood,
            "X4F" => BoxReconstitutedWood,
            "X4G" => BoxFibreboard,
            "X4H" => BoxPlastic,
            "X5H" => BagWovenPlastic,
            "X5L" => BagTextile,
            "X5M" => BagPaper,
            "X6H" => CompositePackagingPlasticReceptacle,
            "X6P" => CompositePackagingGlassReceptacle,
            "X7A" => CaseCar,
            "X7B" => CaseWooden,
            "X8A" => PalletWooden,
            "X8B" => CrateWooden,
            "X8C" => BundleWooden,
            "XAA" => IntermediateBulkContainerRigidPlastic,
            "XAB" => ReceptacleFibre,
            "XAC" => ReceptaclePaper,
            "XAD" => ReceptacleWooden,
            "XAE" => Aerosol,
            "XAF" => PalletModularCollars80Cms60Cms,
            "XAG" => PalletShrinkwrapped,
            "XAH" => Pallet100Cms110Cms,
            "XAI" => Clamshell,
            "XAJ" => Cone,
            "XAM" => AmpouleNonprotected,
            "XAP" => AmpouleProtected,
            "XAT" => Atomizer,
            "XAV" => Capsule,
            "XB4" => Belt,
            "XBA" => Barrel,
            "XBB" => Bobbin,
            "XBC" => BottlecratePerBottlerack,
            "XBD" => Board,
            "XBE" => Bundle,
            "XBF" => BalloonNonprotected,
            "XBG" => Bag,
            "XBH" => Bunch,
            "XBI" => Bin,
            "XBJ" => Bucket,
            "XBK" => Basket,
            "XBL" => BaleCompressed,
            "XBM" => Basin,
            "XBN" => BaleNoncompressed,
            "XBO" => BottleNonprotectedCylindrical,
            "XBP" => BalloonProtected,
            "XBQ" => BottleProtectedCylindrical,
            "XBR" => Bar,
            "XBS" => BottleNonprotectedBulbous,
            "XBT" => Bolt,
            "XBU" => Butt,
            "XBV" => BottleProtectedBulbous,
            "XBW" => BoxForLiquids,
            "XBX" => Box,
            "XBY" => BoardInBundlePerBunchPerTruss,
            "XBZ" => BarsInBundlePerBunchPerTruss,
            "XCA" => CanRectangular,
            "XCB" => CrateBeer,
            "XCC" => Churn,
            "XCD" => CanWithHandleAndSpout,
            "XCE" => Creel,
            "XCF" => Coffer,
            "XCG" => Cage,
            "XCH" => Chest,
            "XCI" => Canister,
            "XCJ" => Coffin,
            "XCK" => Cask,
            "XCL" => Coil,
            "XCN" => ContainerNotOtherwiseSpecifiedAsTransportEquipment,
            "XCO" => CarboyNonprotected,
            "XCP" => CarboyProtected,
            "XCQ" => Cartridge,
            "XCR" => Crate,
            "XCS" => Case,
            "XCT" => Carton,
            "XCU" => Cup,
            "XCV" => Cover,
            "XCW" => CageRoll,
            "XCX" => CanCylindrical,
            "XCY" => Cylinder,
            "XCZ" => Canvas,
            "XDA" => CrateMultipleLayerPlastic,
            "XDB" => CrateMultipleLayerWooden,
            "XDC" => CrateMultipleLayerCardboard,
            "XDG" => CageCommonwealthHandlingEquipmentPoolCHEP,
            "XDH" => BoxCommonwealthHandlingEquipmentPoolCHEPEurobox,
            "XDI" => DrumIron,
            "XDJ" => DemijohnNonprotected,
            "XDK" => CrateBulkCardboard,
            "XDL" => CrateBulkPlastic,
            "XDM" => CrateBulkWooden,
            "XDN" => Dispenser,
            "XDP" => DemijohnProtected,
            "XDR" => Drum,
            "XDS" => TrayOneLayerNoCoverPlastic,
            "XDT" => TrayOneLayerNoCoverWooden,
            "XDU" => TrayOneLayerNoCoverPolystyrene,
            "XDV" => TrayOneLayerNoCoverCardboard,
            "XDW" => TrayTwoLayersNoCoverPlasticTray,
            "XDX" => TrayTwoLayersNoCoverWooden,
            "XDY" => TrayTwoLayersNoCoverCardboard,
            "XEC" => BagPlastic,
            "XED" => CaseWithPalletBase,
            "XEE" => CaseWithPalletBaseWooden,
            "XEF" => CaseWithPalletBaseCardboard,
            "XEG" => CaseWithPalletBasePlastic,
            "XEH" => CaseWithPalletBaseMetal,
            "XEI" => CaseIsothermic,
            "XEN" => Envelope,
            "XFB" => Flexibag,
            "XFC" => CrateFruit,
            "XFD" => CrateFramed,
            "XFE" => Flexitank,
            "XFI" => Firkin,
            "XFL" => Flask,
            "XFO" => Footlocker,
            "XFP" => Filmpack,
            "XFR" => Frame,
            "XFT" => Foodtainer,
            "XFW" => CartFlatbed,
            "XFX" => BagFlexibleContainer,
            "XGB" => BottleGas,
            "XGI" => Girder,
            "XGL" => ContainerGallon,
            "XGR" => ReceptacleGlass,
            "XGU" => TrayContainingHorizontallyStackedFlatItems,
            "XGY" => BagGunny,
            "XGZ" => GirdersInBundlePerBunchPerTruss,
            "XHA" => BasketWithHandlePlastic,
            "XHB" => BasketWithHandleWooden,
            "XHC" => BasketWithHandleCardboard,
            "XHG" => Hogshead,
            "XHN" => Hanger,
            "XHR" => Hamper,
            "XIA" => PackageDisplayWooden,
            "XIB" => PackageDisplayCardboard,
            "XIC" => PackageDisplayPlastic,
            "XID" => PackageDisplayMetal,
            "XIE" => PackageShow,
            "XIF" => PackageFlow,
            "XIG" => PackagePaperWrapped,
            "XIH" => DrumPlastic,
            "XIK" => PackageCardboardWithBottleGripholes,
            "XIL" => TrayRigidLiddedStackableCENTS144822002,
            "XIN" => Ingot,
            "XIZ" => IngotsInBundlePerBunchPerTruss,
            "XJB" => BagJumbo,
            "XJC" => JerricanRectangular,
            "XJG" => Jug,
            "XJR" => Jar,
            "XJT" => Jutebag,
            "XJY" => JerricanCylindrical,
            "XKG" => Keg,
            "XLE" => Luggage,
            "XLG" => Log,
            "XLT" => Lot,
            "XLU" => Lug,
            "XLV" => Liftvan,
            "XLZ" => LogsInBundlePerBunchPerTruss,
            "XMA" => CrateMetal,
            "XMB" => BagMultiply,
            "XMC" => CrateMilk,
            "XME" => ContainerMetal,
            "XMR" => ReceptacleMetal,
            "XMS" => SackMultiwall,
            "XMT" => Mat,
            "XMW" => ReceptaclePlasticWrapped,
            "XMX" => Matchbox,
            "XNA" => NotAvailable,
            "XNE" => UnpackedOrUnpackaged,
            "XNF" => UnpackedOrUnpackagedSingleUnit,
            "XNG" => UnpackedOrUnpackagedMultipleUnits,
            "XNS" => Nest,
            "XNT" => Net,
            "XNU" => NetTubePlastic,
            "XNV" => NetTubeTextile,
            "XOA" => PalletCHEP40CmX60Cm,
            "XOB" => PalletCHEP80CmX120Cm,
            "XOC" => PalletCHEP100CmX120Cm,
            "XOD" => PalletAS40681993,
            "XOE" => PalletISOT11,
            "XOF" => PlatformUnspecifiedWeightOrDimension,
            "XOK" => Block,
            "XOT" => Octabin,
            "XOU" => ContainerOuter,
            "XOG" => PalletISO01Per2EUROPallet,
            "XOH" => PalletISO11Per1EUROPallet,
            "XOI" => PalletISO22Per1EUROPallet,
            "XOJ" => Unit1Per4EUROPallet,
            "XOL" => Unit1Per8EUROPallet,
            "XOM" => SyntheticPalletISO1,
            "XON" => SyntheticPalletISO2,
            "XOP" => WholesalerPallet,
            "XOQ" => Pallet80X100Cm,
            "XOR" => Pallet60X100Cm,
            "XOS" => OnewayPallet,
            "XOV" => ReturnablePallet,
            "XOW" => LargeBagPalletSized,
            "XOX" => AWheeledPalletWithRaisedRim81X67X135,
            "XOY" => AWheeledPalletWithRaisedRim81X72X135,
            "XOZ" => WheeledPalletWithRaisedRim81X60X16,
            "XO1" => TwoSidedCageOnWheelsWithFixingStrap,
            "XO2" => Trolley,
            "XO3" => OnewayPalletISO01Per2EUROPallet,
            "XO4" => OnewayPalletISO11Per1EUROPallet,
            "XO5" => OnewayPalletISO22Per1EUROPallet,
            "XO6" => PalletWithExceptionalDimensions,
            "XO7" => WoodenPallet40CmX80Cm,
            "XO8" => PlasticPalletSRS60CmX80Cm,
            "XO9" => PlasticPalletSRS80CmX120Cm,
            "XP1" => CHEPPallet60CmX80Cm,
            "XP3" => LPRPallet60CmX80Cm,
            "XP4" => LPRPallet80CmX120Cm,
            "XP2" => Pan,
            "XPA" => Packet,
            "XPB" => PalletBoxCombinedOpenendedBoxAndPallet,
            "XPC" => Parcel,
            "XPD" => PalletModularCollars80Cms100Cms,
            "XPE" => PalletModularCollars80Cms120Cms,
            "XPF" => Pen,
            "XPG" => Plate,
            "XPH" => Pitcher,
            "XPI" => Pipe,
            "XPJ" => Punnet,
            "XPK" => Package,
            "XPL" => Pail,
            "XPN" => Plank,
            "XPO" => Pouch,
            "XPR" => ReceptaclePlastic,
            "XPT" => Pot,
            "XPU" => Tray,
            "XPV" => PipesInBundlePerBunchPerTruss,
            "XPX" => Pallet,
            "XPY" => PlatesInBundlePerBunchPerTruss,
            "XPZ" => PlanksInBundlePerBunchPerTruss,
            "XQA" => DrumSteelNonremovableHead,
            "XQB" => DrumSteelRemovableHead,
            "XQC" => DrumAluminiumNonremovableHead,
            "XQD" => DrumAluminiumRemovableHead,
            "XQF" => DrumPlasticNonremovableHead,
            "XQG" => DrumPlasticRemovableHead,
            "XQH" => BarrelWoodenBungType,
            "XQJ" => BarrelWoodenRemovableHead,
            "XQK" => JerricanSteelNonremovableHead,
            "XQL" => JerricanSteelRemovableHead,
            "XQM" => JerricanPlasticNonremovableHead,
            "XQN" => JerricanPlasticRemovableHead,
            "XQP" => BoxWoodenNaturalWoodOrdinary,
            "XQQ" => BoxWoodenNaturalWoodWithSiftProofWalls,
            "XQR" => BoxPlasticExpanded,
            "XQS" => BoxPlasticSolid,
            "XRD" => Rod,
            "XRG" => Ring,
            "XRJ" => RackClothingHanger,
            "XRK" => Rack,
            "XRL" => Reel,
            "XRO" => Roll,
            "XRT" => Rednet,
            "XRZ" => RodsInBundlePerBunchPerTruss,
            "XSA" => Sack,
            "XSB" => Slab,
            "XSC" => CrateShallow,
            "XSD" => Spindle,
            "XSE" => Seachest,
            "XSH" => Sachet,
            "XSI" => Skid,
            "XSK" => CaseSkeleton,
            "XSL" => Slipsheet,
            "XSM" => Sheetmetal,
            "XSO" => Spool,
            "XSP" => SheetPlasticWrapping,
            "XSS" => CaseSteel,
            "XST" => Sheet,
            "XSU" => Suitcase,
            "XSV" => EnvelopeSteel,
            "XSW" => Shrinkwrapped,
            "XSY" => Sleeve,
            "XSZ" => SheetsInBundlePerBunchPerTruss,
            "XTB" => Tub,
            "XTC" => Teachest,
            "XTD" => TubeCollapsible,
            "XTG" => TankContainerGeneric,
            "XTI" => Tierce,
            "XTK" => TankRectangular,
            "XTL" => TubWithLid,
            "XTN" => Tin,
            "XTO" => Tun,
            "XTR" => Trunk,
            "XTS" => Truss,
            "XTT" => BagTote,
            "XTU" => Tube,
            "XTV" => TubeWithNozzle,
            "XTW" => PalletTriwall,
            "XTY" => TankCylindrical,
            "XTZ" => TubesInBundlePerBunchPerTruss,
            "XUC" => Uncaged,
            "XUN" => UnitUnece,
            "XVA" => Vat,
            "XVG" => BulkGasAt1031MbarAnd15C,
            "XVI" => Vial,
            "XVK" => Vanpack,
            "XVL" => BulkLiquid,
            "XVO" => BulkSolidLargeParticlesNodules,
            "XVP" => Vacuumpacked,
            "XVQ" => BulkLiquefiedGasAtAbnormalTemperaturePerPressure,
            "XVN" => Vehicle,
            "XVR" => BulkSolidGranularParticlesGrains,
            "XVS" => BulkScrapMetal,
            "XVY" => BulkSolidFineParticlesPowders,
            "XWA" => IntermediateBulkContainer,
            "XWB" => Wickerbottle,
            "XWC" => IntermediateBulkContainerSteel,
            "XWD" => IntermediateBulkContainerAluminium,
            "XWF" => IntermediateBulkContainerMetal,
            "XWG" => IntermediateBulkContainerSteelPressurised10Kpa,
            "XWH" => IntermediateBulkContainerAluminiumPressurised10Kpa,
            "XWJ" => IntermediateBulkContainerMetalPressure10Kpa,
            "XWK" => IntermediateBulkContainerSteelLiquid,
            "XWL" => IntermediateBulkContainerAluminiumLiquid,
            "XWM" => IntermediateBulkContainerMetalLiquid,
            "XWN" => IntermediateBulkContainerWovenPlasticWithoutCoatPerLiner,
            "XWP" => IntermediateBulkContainerWovenPlasticCoated,
            "XWQ" => IntermediateBulkContainerWovenPlasticWithLiner,
            "XWR" => IntermediateBulkContainerWovenPlasticCoatedAndLiner,
            "XWS" => IntermediateBulkContainerPlasticFilm,
            "XWT" => IntermediateBulkContainerTextileWithOutCoatPerLiner,
            "XWU" => IntermediateBulkContainerNaturalWoodWithInnerLiner,
            "XWV" => IntermediateBulkContainerTextileCoated,
            "XWW" => IntermediateBulkContainerTextileWithLiner,
            "XWX" => IntermediateBulkContainerTextileCoatedAndLiner,
            "XWY" => IntermediateBulkContainerPlywoodWithInnerLiner,
            "XWZ" => IntermediateBulkContainerReconstitutedWoodWithInnerLiner,
            "XXA" => BagWovenPlasticWithoutInnerCoatPerLiner,
            "XXB" => BagWovenPlasticSiftProof,
            "XXC" => BagWovenPlasticWaterResistant,
            "XXD" => BagPlasticsFilm,
            "XXF" => BagTextileWithoutInnerCoatPerLiner,
            "XXG" => BagTextileSiftProof,
            "XXH" => BagTextileWaterResistant,
            "XXJ" => BagPaperMultiwall,
            "XXK" => BagPaperMultiwallWaterResistant,
            "XYA" => CompositePackagingPlasticReceptacleInSteelDrum,
            "XYB" => CompositePackagingPlasticReceptacleInSteelCrateBox,
            "XYC" => CompositePackagingPlasticReceptacleInAluminiumDrum,
            "XYD" => CompositePackagingPlasticReceptacleInAluminiumCrate,
            "XYF" => CompositePackagingPlasticReceptacleInWoodenBox,
            "XYG" => CompositePackagingPlasticReceptacleInPlywoodDrum,
            "XYH" => CompositePackagingPlasticReceptacleInPlywoodBox,
            "XYJ" => CompositePackagingPlasticReceptacleInFibreDrum,
            "XYK" => CompositePackagingPlasticReceptacleInFibreboardBox,
            "XYL" => CompositePackagingPlasticReceptacleInPlasticDrum,
            "XYM" => CompositePackagingPlasticReceptacleInSolidPlasticBox,
            "XYN" => CompositePackagingGlassReceptacleInSteelDrum,
            "XYP" => CompositePackagingGlassReceptacleInSteelCrateBox,
            "XYQ" => CompositePackagingGlassReceptacleInAluminiumDrum,
            "XYR" => CompositePackagingGlassReceptacleInAluminiumCrate,
            "XYS" => CompositePackagingGlassReceptacleInWoodenBox,
            "XYT" => CompositePackagingGlassReceptacleInPlywoodDrum,
            "XYV" => CompositePackagingGlassReceptacleInWickerworkHamper,
            "XYW" => CompositePackagingGlassReceptacleInFibreDrum,
            "XYX" => CompositePackagingGlassReceptacleInFibreboardBox,
            "XYY" => CompositePackagingGlassReceptacleInExpandablePlasticPack,
            "XYZ" => CompositePackagingGlassReceptacleInSolidPlasticPack,
            "XZA" => IntermediateBulkContainerPaperMultiwall,
            "XZB" => BagLarge,
            "XZC" => IntermediateBulkContainerPaperMultiwallWaterResistant,
            "XZD" => IntermediateBulkContainerRigidPlasticWithStructuralEquipmentSolids,
            "XZF" => IntermediateBulkContainerRigidPlasticFreestandingSolids,
            "XZG" => IntermediateBulkContainerRigidPlasticWithStructuralEquipmentPressurised,
            "XZH" => IntermediateBulkContainerRigidPlasticFreestandingPressurised,
            "XZJ" => IntermediateBulkContainerRigidPlasticWithStructuralEquipmentLiquids,
            "XZK" => IntermediateBulkContainerRigidPlasticFreestandingLiquids,
            "XZL" => IntermediateBulkContainerCompositeRigidPlasticSolids,
            "XZM" => IntermediateBulkContainerCompositeFlexiblePlasticSolids,
            "XZN" => IntermediateBulkContainerCompositeRigidPlasticPressurised,
            "XZP" => IntermediateBulkContainerCompositeFlexiblePlasticPressurised,
            "XZQ" => IntermediateBulkContainerCompositeRigidPlasticLiquids,
            "XZR" => IntermediateBulkContainerCompositeFlexiblePlasticLiquids,
            "XZS" => IntermediateBulkContainerComposite,
            "XZT" => IntermediateBulkContainerFibreboard,
            "XZU" => IntermediateBulkContainerFlexible,
            "XZV" => IntermediateBulkContainerMetalOtherThanSteel,
            "XZW" => IntermediateBulkContainerNaturalWood,
            "XZX" => IntermediateBulkContainerPlywood,
            "XZY" => IntermediateBulkContainerReconstitutedWood,
            _ => null,
        };
        return unit != null;
    }
#region Units

    /// <summary>
    /// A unit of count defining the number of groups (group: set of items classified together).
    /// </summary>
    public static IUnit Group = new Unit()
    {
        Name = "group",
        Symbol = null,
        CommonCode = "10",
    };
    /// <summary>
    /// A unit of count defining the number of outfits (outfit: a complete set of equipment / materials / objects used for a specific purpose).
    /// </summary>
    public static IUnit Outfit = new Unit()
    {
        Name = "outfit",
        Symbol = null,
        CommonCode = "11",
    };
    /// <summary>
    /// A unit of count defining the number of rations (ration: a single portion of provisions).
    /// </summary>
    public static IUnit Ration = new Unit()
    {
        Name = "ration",
        Symbol = null,
        CommonCode = "13",
    };
    /// <summary>
    /// A unit of liquid measure, especially related to spirits.
    /// </summary>
    public static IUnit Shot = new Unit()
    {
        Name = "shot",
        Symbol = null,
        CommonCode = "14",
    };
    /// <summary>
    /// A unit of count defining the number of military sticks (military stick: bombs or paratroops released in rapid succession from an aircraft).
    /// </summary>
    public static IUnit StickMilitary = new Unit()
    {
        Name = "stick, military",
        Symbol = null,
        CommonCode = "15",
    };
    /// <summary>
    /// A unit of count defining the number of shipping containers that measure 20 foot in length.
    /// </summary>
    public static IUnit TwentyFootContainer = new Unit()
    {
        Name = "twenty foot container",
        Symbol = null,
        CommonCode = "20",
    };
    /// <summary>
    /// A unit of count defining the number of shipping containers that measure 40 foot in length.
    /// </summary>
    public static IUnit FortyFootContainer = new Unit()
    {
        Name = "forty foot container",
        Symbol = null,
        CommonCode = "21",
    };
    public static IConvertibleUnit DecilitrePerGram = new ConvertibleUnit()
    {
        Name = "decilitre per gram",
        Symbol = "dl/g",
        CommonCode = "22",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit GramPerCubicCentimetre = new ConvertibleUnit()
    {
        Name = "gram per cubic centimetre",
        Symbol = "g/cm³",
        CommonCode = "23",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// A unit of mass defining the expected mass of material expressed as the number of pounds.
    /// </summary>
    public static IUnit TheoreticalPound = new Unit()
    {
        Name = "theoretical pound",
        Symbol = null,
        CommonCode = "24",
    };
    public static IConvertibleUnit GramPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "gram per square centimetre",
        Symbol = "g/cm²",
        CommonCode = "25",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 10.0m,
    };
    /// <summary>
    /// A unit of mass defining the expected mass of material, expressed as the number of tons.
    /// </summary>
    public static IUnit TheoreticalTon = new Unit()
    {
        Name = "theoretical ton",
        Symbol = null,
        CommonCode = "27",
    };
    public static IConvertibleUnit KilogramPerSquareMetre = new ConvertibleUnit()
    {
        Name = "kilogram per square metre",
        Symbol = "kg/m²",
        CommonCode = "28",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KilopascalSquareMetrePerGram = new ConvertibleUnit()
    {
        Name = "kilopascal square metre per gram",
        Symbol = "kPa·m²/g",
        CommonCode = "33",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit KilopascalPerMillimetre = new ConvertibleUnit()
    {
        Name = "kilopascal per millimetre",
        Symbol = "kPa/mm",
        CommonCode = "34",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit MillilitrePerSquareCentimetreSecond = new ConvertibleUnit()
    {
        Name = "millilitre per square centimetre second",
        Symbol = "ml/(cm²·s)",
        CommonCode = "35",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit OuncePerSquareFoot = new ConvertibleUnit()
    {
        Name = "ounce per square foot",
        Symbol = "oz/ft²",
        CommonCode = "37",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.3051517m,
    };
    public static IUnit OuncePerSquareFootPer001Inch = new Unit()
    {
        Name = "ounce per square foot per 0,01inch",
        Symbol = "oz/(ft²/cin)",
        CommonCode = "38",
    };
    public static IConvertibleUnit MillilitrePerSecond = new ConvertibleUnit()
    {
        Name = "millilitre per second",
        Symbol = "ml/s",
        CommonCode = "40",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillilitrePerMinute = new ConvertibleUnit()
    {
        Name = "millilitre per minute",
        Symbol = "ml/min",
        CommonCode = "41",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000166667m,
    };
    /// <summary>
    /// A unit of area for tin plate equal to a surface area of 100 square metres.
    /// </summary>
    public static IUnit Sitas = new Unit()
    {
        Name = "sitas",
        Symbol = null,
        CommonCode = "56",
    };
    /// <summary>
    /// A unit of count defining the number of strands per inch as a measure of the fineness of a woven product.
    /// </summary>
    public static IUnit Mesh = new Unit()
    {
        Name = "mesh",
        Symbol = null,
        CommonCode = "57",
    };
    /// <summary>
    /// A unit of mass defining the total number of kilograms after deductions.
    /// </summary>
    public static IUnit NetKilogram = new Unit()
    {
        Name = "net kilogram",
        Symbol = null,
        CommonCode = "58",
    };
    /// <summary>
    /// A unit of proportion equal to 10⁻⁶.
    /// </summary>
    public static IConvertibleUnit PartPerMillion = new ConvertibleUnit()
    {
        Name = "part per million",
        Symbol = "ppm",
        CommonCode = "59",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of proportion equal to 10⁻².
    /// </summary>
    public static IConvertibleUnit PercentWeight = new ConvertibleUnit()
    {
        Name = "percent weight",
        Symbol = null,
        CommonCode = "60",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of proportion equal to 10⁻⁹.
    /// </summary>
    public static IConvertibleUnit PartPerBillionUS = new ConvertibleUnit()
    {
        Name = "part per billion (US)",
        Symbol = "ppb",
        CommonCode = "61",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Millipascal = new ConvertibleUnit()
    {
        Name = "millipascal",
        Symbol = "mPa",
        CommonCode = "74",
        ConversionGroup = "pascal",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Milliinch = new ConvertibleUnit()
    {
        Name = "milliinch",
        Symbol = "mil",
        CommonCode = "77",
        ConversionGroup = "meter",
        ConversionFactor = 0.000025399999999999997m,
    };
    public static IConvertibleUnit PoundPerSquareInchAbsolute = new ConvertibleUnit()
    {
        Name = "pound per square inch absolute",
        Symbol = "lb/in²",
        CommonCode = "80",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 703.0696m,
    };
    public static IConvertibleUnit Henry = new ConvertibleUnit()
    {
        Name = "henry",
        Symbol = "H",
        CommonCode = "81",
        ConversionGroup = "henry",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit FootPoundforce = new ConvertibleUnit()
    {
        Name = "foot poundforce",
        Symbol = "ft·lbf",
        CommonCode = "85",
        ConversionGroup = "joule",
        ConversionFactor = 1.355818m,
    };
    public static IConvertibleUnit PoundPerCubicFoot = new ConvertibleUnit()
    {
        Name = "pound per cubic foot",
        Symbol = "lb/ft³",
        CommonCode = "87",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 16.01846m,
    };
    public static IConvertibleUnit Poise = new ConvertibleUnit()
    {
        Name = "poise",
        Symbol = "P",
        CommonCode = "89",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit Stokes = new ConvertibleUnit()
    {
        Name = "stokes",
        Symbol = "St",
        CommonCode = "91",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.0001m,
    };
    /// <summary>
    /// A unit of quantity expressed as a predetermined or set rate for usage of a facility or service.
    /// </summary>
    public static IUnit FixedRate = new Unit()
    {
        Name = "fixed rate",
        Symbol = null,
        CommonCode = "1I",
    };
    /// <summary>
    /// Refer ISO/TC12 SI Guide
    /// </summary>
    public static IConvertibleUnit RadianPerSecond = new ConvertibleUnit()
    {
        Name = "radian per second",
        Symbol = "rad/s",
        CommonCode = "2A",
        ConversionGroup = "radian / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Refer ISO/TC12 SI Guide
    /// </summary>
    public static IConvertibleUnit RadianPerSecondSquared = new ConvertibleUnit()
    {
        Name = "radian per second squared",
        Symbol = "rad/s²",
        CommonCode = "2B",
        ConversionGroup = "radian / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Roentgen = new ConvertibleUnit()
    {
        Name = "roentgen",
        Symbol = "R",
        CommonCode = "2C",
        ConversionGroup = "coulomb / kilogram",
        ConversionFactor = 0.00025800000000000004m,
    };
    /// <summary>
    /// A unit of electric potential in relation to alternating current (AC).
    /// </summary>
    public static IConvertibleUnit VoltAC = new ConvertibleUnit()
    {
        Name = "volt AC",
        Symbol = "V",
        CommonCode = "2G",
        ConversionGroup = "volt",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of electric potential in relation to direct current (DC).
    /// </summary>
    public static IConvertibleUnit VoltDC = new ConvertibleUnit()
    {
        Name = "volt DC",
        Symbol = "V",
        CommonCode = "2H",
        ConversionGroup = "volt",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerHour = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per hour",
        Symbol = "BtuIT/h",
        CommonCode = "2I",
        ConversionGroup = "watt",
        ConversionFactor = 0.29307110000000003m,
    };
    public static IConvertibleUnit CubicCentimetrePerSecond = new ConvertibleUnit()
    {
        Name = "cubic centimetre per second",
        Symbol = "cm³/s",
        CommonCode = "2J",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit CubicFootPerHour = new ConvertibleUnit()
    {
        Name = "cubic foot per hour",
        Symbol = "ft³/h",
        CommonCode = "2K",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000786579m,
    };
    public static IConvertibleUnit CubicFootPerMinute = new ConvertibleUnit()
    {
        Name = "cubic foot per minute",
        Symbol = "ft³/min",
        CommonCode = "2L",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00047194740000000004m,
    };
    public static IConvertibleUnit CentimetrePerSecond = new ConvertibleUnit()
    {
        Name = "centimetre per second",
        Symbol = "cm/s",
        CommonCode = "2M",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.01m,
    };
    public static IUnit Decibel = new Unit()
    {
        Name = "decibel",
        Symbol = "dB",
        CommonCode = "2N",
    };
    /// <summary>
    /// A unit of information equal to 10³ (1000) bytes.
    /// </summary>
    public static IUnit Kilobyte = new Unit()
    {
        Name = "kilobyte",
        Symbol = "kbyte",
        CommonCode = "2P",
    };
    public static IConvertibleUnit Kilobecquerel = new ConvertibleUnit()
    {
        Name = "kilobecquerel",
        Symbol = "kBq",
        CommonCode = "2Q",
        ConversionGroup = "becquerel",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kilocurie = new ConvertibleUnit()
    {
        Name = "kilocurie",
        Symbol = "kCi",
        CommonCode = "2R",
        ConversionGroup = "becquerel",
        ConversionFactor = 37000000000000.0m,
    };
    public static IConvertibleUnit Megagram = new ConvertibleUnit()
    {
        Name = "megagram",
        Symbol = "Mg",
        CommonCode = "2U",
        ConversionGroup = "kilogram",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit MetrePerMinute = new ConvertibleUnit()
    {
        Name = "metre per minute",
        Symbol = "m/min",
        CommonCode = "2X",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.016666m,
    };
    public static IConvertibleUnit Milliroentgen = new ConvertibleUnit()
    {
        Name = "milliroentgen",
        Symbol = "mR",
        CommonCode = "2Y",
        ConversionGroup = "coulomb / kilogram",
        ConversionFactor = 0.000000258m,
    };
    public static IConvertibleUnit Millivolt = new ConvertibleUnit()
    {
        Name = "millivolt",
        Symbol = "mV",
        CommonCode = "2Z",
        ConversionGroup = "volt",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Megajoule = new ConvertibleUnit()
    {
        Name = "megajoule",
        Symbol = "MJ",
        CommonCode = "3B",
        ConversionGroup = "joule",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of count defining the number of months for a person or persons to perform an undertaking.
    /// </summary>
    public static IUnit Manmonth = new Unit()
    {
        Name = "manmonth",
        Symbol = null,
        CommonCode = "3C",
    };
    public static IConvertibleUnit Centistokes = new ConvertibleUnit()
    {
        Name = "centistokes",
        Symbol = "cSt",
        CommonCode = "4C",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microlitre = new ConvertibleUnit()
    {
        Name = "microlitre",
        Symbol = "µl",
        CommonCode = "4G",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit MicrometreMicron = new ConvertibleUnit()
    {
        Name = "micrometre (micron)",
        Symbol = "µm",
        CommonCode = "4H",
        ConversionGroup = "meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Milliampere = new ConvertibleUnit()
    {
        Name = "milliampere",
        Symbol = "mA",
        CommonCode = "4K",
        ConversionGroup = "ampere",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of information equal to 10⁶ (1000000) bytes.
    /// </summary>
    public static IUnit Megabyte = new Unit()
    {
        Name = "megabyte",
        Symbol = "Mbyte",
        CommonCode = "4L",
    };
    public static IConvertibleUnit MilligramPerHour = new ConvertibleUnit()
    {
        Name = "milligram per hour",
        Symbol = "mg/h",
        CommonCode = "4M",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit Megabecquerel = new ConvertibleUnit()
    {
        Name = "megabecquerel",
        Symbol = "MBq",
        CommonCode = "4N",
        ConversionGroup = "becquerel",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit Microfarad = new ConvertibleUnit()
    {
        Name = "microfarad",
        Symbol = "µF",
        CommonCode = "4O",
        ConversionGroup = "farad",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit NewtonPerMetre = new ConvertibleUnit()
    {
        Name = "newton per metre",
        Symbol = "N/m",
        CommonCode = "4P",
        ConversionGroup = "newton / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit OunceInch = new ConvertibleUnit()
    {
        Name = "ounce inch",
        Symbol = "oz·in",
        CommonCode = "4Q",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 0.0007200778m,
    };
    public static IConvertibleUnit OunceFoot = new ConvertibleUnit()
    {
        Name = "ounce foot",
        Symbol = "oz·ft",
        CommonCode = "4R",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 0.008640934m,
    };
    public static IConvertibleUnit Picofarad = new ConvertibleUnit()
    {
        Name = "picofarad",
        Symbol = "pF",
        CommonCode = "4T",
        ConversionGroup = "farad",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit PoundPerHour = new ConvertibleUnit()
    {
        Name = "pound per hour",
        Symbol = "lb/h",
        CommonCode = "4U",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.00012599790000000002m,
    };
    public static IConvertibleUnit TonUSPerHour = new ConvertibleUnit()
    {
        Name = "ton (US) per hour",
        Symbol = "ton (US) /h",
        CommonCode = "4W",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.2519958m,
    };
    public static IConvertibleUnit KilolitrePerHour = new ConvertibleUnit()
    {
        Name = "kilolitre per hour",
        Symbol = "kl/h",
        CommonCode = "4X",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit BarrelUSPerMinute = new ConvertibleUnit()
    {
        Name = "barrel (US) per minute",
        Symbol = "barrel (US)/min",
        CommonCode = "5A",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00264979m,
    };
    /// <summary>
    /// A unit of count defining the number of batches (batch: quantity of material produced in one operation or number of animals or persons coming at once).
    /// </summary>
    public static IUnit Batch = new Unit()
    {
        Name = "batch",
        Symbol = null,
        CommonCode = "5B",
    };
    /// <summary>
    /// A unit of volume equal to one million (1000000) cubic feet of gas per day.
    /// </summary>
    public static IUnit MMSCFPerDay = new Unit()
    {
        Name = "MMSCF/day",
        Symbol = null,
        CommonCode = "5E",
    };
    /// <summary>
    /// A unit of power defining the hydraulic horse power delivered by a fluid pump depending on the viscosity of the fluid.
    /// </summary>
    public static IUnit HydraulicHorsePower = new Unit()
    {
        Name = "hydraulic horse power",
        Symbol = null,
        CommonCode = "5J",
    };
    public static IConvertibleUnit AmpereSquareMetrePerJouleSecond = new ConvertibleUnit()
    {
        Name = "ampere square metre per joule second",
        Symbol = "A·m²/(J·s)",
        CommonCode = "A10",
        ConversionGroup = "ampere * second / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Angstrom = new ConvertibleUnit()
    {
        Name = "angstrom",
        Symbol = "Å",
        CommonCode = "A11",
        ConversionGroup = "meter",
        ConversionFactor = 0.0000000001m,
    };
    public static IConvertibleUnit AstronomicalUnit = new ConvertibleUnit()
    {
        Name = "astronomical unit",
        Symbol = "ua",
        CommonCode = "A12",
        ConversionGroup = "meter",
        ConversionFactor = 149597870000.0m,
    };
    public static IConvertibleUnit Attojoule = new ConvertibleUnit()
    {
        Name = "attojoule",
        Symbol = "aJ",
        CommonCode = "A13",
        ConversionGroup = "joule",
        ConversionFactor = 0.000000000000000001m,
    };
    public static IConvertibleUnit Barn = new ConvertibleUnit()
    {
        Name = "barn",
        Symbol = "b",
        CommonCode = "A14",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.0000000000000000000000000001m,
    };
    public static IConvertibleUnit BarnPerElectronvolt = new ConvertibleUnit()
    {
        Name = "barn per electronvolt",
        Symbol = "b/eV",
        CommonCode = "A15",
        ConversionGroup = "meter ** 2 / joule",
        ConversionFactor = 0.000000000624151m,
    };
    public static IConvertibleUnit BarnPerSteradianElectronvolt = new ConvertibleUnit()
    {
        Name = "barn per steradian electronvolt",
        Symbol = "b/(sr·eV)",
        CommonCode = "A16",
        ConversionGroup = "meter ** 2 / joule / steradian",
        ConversionFactor = 0.000000000624151m,
    };
    public static IConvertibleUnit BarnPerSteradian = new ConvertibleUnit()
    {
        Name = "barn per steradian",
        Symbol = "b/sr",
        CommonCode = "A17",
        ConversionGroup = "meter ** 2 / steradian",
        ConversionFactor = 0.0000000000000000000000000001m,
    };
    public static IConvertibleUnit BecquerelPerKilogram = new ConvertibleUnit()
    {
        Name = "becquerel per kilogram",
        Symbol = "Bq/kg",
        CommonCode = "A18",
        ConversionGroup = "curie / kilogram",
        ConversionFactor = 0.000000000027027m,
    };
    public static IConvertibleUnit BecquerelPerCubicMetre = new ConvertibleUnit()
    {
        Name = "becquerel per cubic metre",
        Symbol = "Bq/m³",
        CommonCode = "A19",
        ConversionGroup = "becquerel / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmperePerCentimetre = new ConvertibleUnit()
    {
        Name = "ampere per centimetre",
        Symbol = "A/cm",
        CommonCode = "A2",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSecondSquareFootDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per second square foot degree Rankine",
        Symbol = "BtuIT/(s·ft²·°R)",
        CommonCode = "A20",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 20441.7m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerPoundDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per pound degree Rankine",
        Symbol = "BtuIT/(lb·°R)",
        CommonCode = "A21",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4186.8m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSecondFootDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per second foot degree Rankine",
        Symbol = "BtuIT/(s·ft·°R)",
        CommonCode = "A22",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 6230.64m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerHourSquareFootDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per hour square foot degree Rankine",
        Symbol = "BtuIT/(h·ft²·°R)",
        CommonCode = "A23",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 5.67826m,
    };
    public static IConvertibleUnit CandelaPerSquareMetre = new ConvertibleUnit()
    {
        Name = "candela per square metre",
        Symbol = "cd/m²",
        CommonCode = "A24",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CoulombMetre = new ConvertibleUnit()
    {
        Name = "coulomb metre",
        Symbol = "C·m",
        CommonCode = "A26",
        ConversionGroup = "ampere * meter * second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit CoulombMetreSquaredPerVolt = new ConvertibleUnit()
    {
        Name = "coulomb metre squared per volt",
        Symbol = "C·m²/V",
        CommonCode = "A27",
        ConversionGroup = "ampere ** 2 * second ** 4 / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CoulombPerCubicCentimetre = new ConvertibleUnit()
    {
        Name = "coulomb per cubic centimetre",
        Symbol = "C/cm³",
        CommonCode = "A28",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit CoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "coulomb per cubic metre",
        Symbol = "C/m³",
        CommonCode = "A29",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmperePerMillimetre = new ConvertibleUnit()
    {
        Name = "ampere per millimetre",
        Symbol = "A/mm",
        CommonCode = "A3",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit CoulombPerCubicMillimetre = new ConvertibleUnit()
    {
        Name = "coulomb per cubic millimetre",
        Symbol = "C/mm³",
        CommonCode = "A30",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1000000000.0m,
    };
    public static IConvertibleUnit CoulombPerKilogramSecond = new ConvertibleUnit()
    {
        Name = "coulomb per kilogram second",
        Symbol = "C/(kg·s)",
        CommonCode = "A31",
        ConversionGroup = "ampere / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CoulombPerMole = new ConvertibleUnit()
    {
        Name = "coulomb per mole",
        Symbol = "C/mol",
        CommonCode = "A32",
        ConversionGroup = "ampere * second / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CoulombPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "coulomb per square centimetre",
        Symbol = "C/cm²",
        CommonCode = "A33",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    public static IConvertibleUnit CoulombPerSquareMetre = new ConvertibleUnit()
    {
        Name = "coulomb per square metre",
        Symbol = "C/m²",
        CommonCode = "A34",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CoulombPerSquareMillimetre = new ConvertibleUnit()
    {
        Name = "coulomb per square millimetre",
        Symbol = "C/mm²",
        CommonCode = "A35",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit CubicCentimetrePerMole = new ConvertibleUnit()
    {
        Name = "cubic centimetre per mole",
        Symbol = "cm³/mol",
        CommonCode = "A36",
        ConversionGroup = "meter ** 3 / mole",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit CubicDecimetrePerMole = new ConvertibleUnit()
    {
        Name = "cubic decimetre per mole",
        Symbol = "dm³/mol",
        CommonCode = "A37",
        ConversionGroup = "meter ** 3 / mole",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CubicMetrePerCoulomb = new ConvertibleUnit()
    {
        Name = "cubic metre per coulomb",
        Symbol = "m³/C",
        CommonCode = "A38",
        ConversionGroup = "meter ** 3 * second / ampere",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CubicMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "cubic metre per kilogram",
        Symbol = "m³/kg",
        CommonCode = "A39",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmperePerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "ampere per square centimetre",
        Symbol = "A/cm²",
        CommonCode = "A4",
        ConversionGroup = "ampere / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    public static IConvertibleUnit CubicMetrePerMole = new ConvertibleUnit()
    {
        Name = "cubic metre per mole",
        Symbol = "m³/mol",
        CommonCode = "A40",
        ConversionGroup = "meter ** 3 / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmperePerSquareMetre = new ConvertibleUnit()
    {
        Name = "ampere per square metre",
        Symbol = "A/m²",
        CommonCode = "A41",
        ConversionGroup = "ampere / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CuriePerKilogram = new ConvertibleUnit()
    {
        Name = "curie per kilogram",
        Symbol = "Ci/kg",
        CommonCode = "A42",
        ConversionGroup = "becquerel / kilogram",
        ConversionFactor = 37000000000.0m,
    };
    /// <summary>
    /// A unit of mass defining the difference between the weight of a ship when completely empty and its weight when completely loaded, expressed as the number of tons.
    /// </summary>
    public static IUnit DeadweightTonnage = new Unit()
    {
        Name = "deadweight tonnage",
        Symbol = "dwt",
        CommonCode = "A43",
    };
    public static IConvertibleUnit Decalitre = new ConvertibleUnit()
    {
        Name = "decalitre",
        Symbol = "dal",
        CommonCode = "A44",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit Decametre = new ConvertibleUnit()
    {
        Name = "decametre",
        Symbol = "dam",
        CommonCode = "A45",
        ConversionGroup = "meter",
        ConversionFactor = 10m,
    };
    /// <summary>
    /// A unit of yarn density. One decitex equals a mass of 1 gram per 10 kilometres of length.
    /// </summary>
    public static IUnit Decitex = new Unit()
    {
        Name = "decitex",
        Symbol = "dtex (g/10km)",
        CommonCode = "A47",
    };
    /// <summary>
    /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
    /// </summary>
    public static IConvertibleUnit DegreeRankine = new ConvertibleUnit()
    {
        Name = "degree Rankine",
        Symbol = "°R",
        CommonCode = "A48",
        ConversionGroup = "kelvin",
        ConversionFactor = 0.5555555555555556m,
    };
    /// <summary>
    /// A unit of yarn density. One denier equals a mass of 1 gram per 9 kilometres of length.
    /// </summary>
    public static IUnit DenierA49 = new Unit()
    {
        Name = "denier",
        Symbol = "den (g/9 km)",
        CommonCode = "A49",
    };
    /// <summary>
    /// Traditional unit for the indication of the linear mass of textile fibers and yarns.
    /// </summary>
    public static IConvertibleUnit DenierM83 = new ConvertibleUnit()
    {
        Name = "denier",
        Symbol = "den",
        CommonCode = "M83",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.00000011111109999999999m,
    };
    public static IConvertibleUnit AmpereSquareMetre = new ConvertibleUnit()
    {
        Name = "ampere square metre",
        Symbol = "A·m²",
        CommonCode = "A5",
        ConversionGroup = "ampere * meter ** 2",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Electronvolt = new ConvertibleUnit()
    {
        Name = "electronvolt",
        Symbol = "eV",
        CommonCode = "A53",
        ConversionGroup = "joule",
        ConversionFactor = 0.0000000000000000001602176487m,
    };
    public static IConvertibleUnit ElectronvoltPerMetre = new ConvertibleUnit()
    {
        Name = "electronvolt per metre",
        Symbol = "eV/m",
        CommonCode = "A54",
        ConversionGroup = "joule / meter",
        ConversionFactor = 0.0000000000000000001602176487m,
    };
    public static IConvertibleUnit ElectronvoltSquareMetre = new ConvertibleUnit()
    {
        Name = "electronvolt square metre",
        Symbol = "eV·m²",
        CommonCode = "A55",
        ConversionGroup = "joule * meter ** 2",
        ConversionFactor = 0.0000000000000000001602176487m,
    };
    public static IConvertibleUnit ElectronvoltSquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "electronvolt square metre per kilogram",
        Symbol = "eV·m²/kg",
        CommonCode = "A56",
        ConversionGroup = "joule * meter ** 2 / kilogram",
        ConversionFactor = 0.0000000000000000001602176487m,
    };
    /// <summary>
    /// A unit of count defining the number of eighth-parts as a measure of the celestial dome cloud coverage.Synonym: OKTA , OCTA
    /// </summary>
    public static IUnit Unit8partCloudCover = new Unit()
    {
        Name = "8part cloud cover",
        Symbol = null,
        CommonCode = "A59",
    };
    public static IConvertibleUnit AmperePerSquareMetreKelvinSquared = new ConvertibleUnit()
    {
        Name = "ampere per square metre kelvin squared",
        Symbol = "A/(m²·K²)",
        CommonCode = "A6",
        ConversionGroup = "ampere / kelvin ** 2 / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Exajoule = new ConvertibleUnit()
    {
        Name = "exajoule",
        Symbol = "EJ",
        CommonCode = "A68",
        ConversionGroup = "joule",
        ConversionFactor = 1000000000000000000m,
    };
    public static IConvertibleUnit FaradPerMetre = new ConvertibleUnit()
    {
        Name = "farad per metre",
        Symbol = "F/m",
        CommonCode = "A69",
        ConversionGroup = "ampere ** 2 * second ** 4 / kilogram / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmperePerSquareMillimetre = new ConvertibleUnit()
    {
        Name = "ampere per square millimetre",
        Symbol = "A/mm²",
        CommonCode = "A7",
        ConversionGroup = "ampere / meter ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit Femtojoule = new ConvertibleUnit()
    {
        Name = "femtojoule",
        Symbol = "fJ",
        CommonCode = "A70",
        ConversionGroup = "joule",
        ConversionFactor = 0.000000000000001m,
    };
    public static IConvertibleUnit Femtometre = new ConvertibleUnit()
    {
        Name = "femtometre",
        Symbol = "fm",
        CommonCode = "A71",
        ConversionGroup = "meter",
        ConversionFactor = 0.000000000000001m,
    };
    public static IConvertibleUnit FootPerSecondSquared = new ConvertibleUnit()
    {
        Name = "foot per second squared",
        Symbol = "ft/s²",
        CommonCode = "A73",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.3048m,
    };
    public static IConvertibleUnit FootPoundforcePerSecond = new ConvertibleUnit()
    {
        Name = "foot poundforce per second",
        Symbol = "ft·lbf/s",
        CommonCode = "A74",
        ConversionGroup = "watt",
        ConversionFactor = 1.355818m,
    };
    /// <summary>
    /// A unit of information typically used for billing purposes, defined as either the number of metric tons or the number of cubic metres, whichever is the larger.
    /// </summary>
    public static IUnit FreightTon = new Unit()
    {
        Name = "freight ton",
        Symbol = null,
        CommonCode = "A75",
    };
    public static IConvertibleUnit Gal = new ConvertibleUnit()
    {
        Name = "gal",
        Symbol = "Gal",
        CommonCode = "A76",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit AmpereSecond = new ConvertibleUnit()
    {
        Name = "ampere second",
        Symbol = "A·s",
        CommonCode = "A8",
        ConversionGroup = "coulomb",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit GigacoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "gigacoulomb per cubic metre",
        Symbol = "GC/m³",
        CommonCode = "A84",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1000000000.0m,
    };
    public static IConvertibleUnit Gigaelectronvolt = new ConvertibleUnit()
    {
        Name = "gigaelectronvolt",
        Symbol = "GeV",
        CommonCode = "A85",
        ConversionGroup = "electron_volt",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit Gigahertz = new ConvertibleUnit()
    {
        Name = "gigahertz",
        Symbol = "GHz",
        CommonCode = "A86",
        ConversionGroup = "hertz",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit Gigaohm = new ConvertibleUnit()
    {
        Name = "gigaohm",
        Symbol = "GΩ",
        CommonCode = "A87",
        ConversionGroup = "ohm",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit GigaohmMetre = new ConvertibleUnit()
    {
        Name = "gigaohm metre",
        Symbol = "GΩ·m",
        CommonCode = "A88",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit Gigapascal = new ConvertibleUnit()
    {
        Name = "gigapascal",
        Symbol = "GPa",
        CommonCode = "A89",
        ConversionGroup = "pascal",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// A unit of quantity expressed as a rate for usage of a facility or service.
    /// </summary>
    public static IUnit Rate = new Unit()
    {
        Name = "rate",
        Symbol = null,
        CommonCode = "A9",
    };
    public static IConvertibleUnit Gigawatt = new ConvertibleUnit()
    {
        Name = "gigawatt",
        Symbol = "GW",
        CommonCode = "A90",
        ConversionGroup = "watt",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// Synonym: grade
    /// </summary>
    public static IConvertibleUnit Gon = new ConvertibleUnit()
    {
        Name = "gon",
        Symbol = "gon",
        CommonCode = "A91",
        ConversionGroup = "radian",
        ConversionFactor = 0.01570796m,
    };
    public static IConvertibleUnit GramPerCubicMetre = new ConvertibleUnit()
    {
        Name = "gram per cubic metre",
        Symbol = "g/m³",
        CommonCode = "A93",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit GramPerMole = new ConvertibleUnit()
    {
        Name = "gram per mole",
        Symbol = "g/mol",
        CommonCode = "A94",
        ConversionGroup = "kilogram / mole",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Gray = new ConvertibleUnit()
    {
        Name = "gray",
        Symbol = "Gy",
        CommonCode = "A95",
        ConversionGroup = "meter ** 2 / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit GrayPerSecond = new ConvertibleUnit()
    {
        Name = "gray per second",
        Symbol = "Gy/s",
        CommonCode = "A96",
        ConversionGroup = "meter ** 2 / second ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Hectopascal = new ConvertibleUnit()
    {
        Name = "hectopascal",
        Symbol = "hPa",
        CommonCode = "A97",
        ConversionGroup = "pascal",
        ConversionFactor = 100m,
    };
    public static IConvertibleUnit HenryPerMetre = new ConvertibleUnit()
    {
        Name = "henry per metre",
        Symbol = "H/m",
        CommonCode = "A98",
        ConversionGroup = "henry / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information equal to one binary digit.
    /// </summary>
    public static IUnit Bit = new Unit()
    {
        Name = "bit",
        Symbol = "bit",
        CommonCode = "A99",
    };
    /// <summary>
    /// A unit of count defining the number of balls (ball: object formed in the shape of sphere).
    /// </summary>
    public static IUnit BallAA = new Unit()
    {
        Name = "ball",
        Symbol = null,
        CommonCode = "AA",
    };
    /// <summary>
    /// A spherical containment vessel for retaining substances or articles.
    /// </summary>
    public static IUnit BallXAL = new Unit()
    {
        Name = "Ball",
        Symbol = null,
        CommonCode = "XAL",
    };
    /// <summary>
    /// A unit of count defining the number of items per bulk pack.
    /// </summary>
    public static IUnit BulkPack = new Unit()
    {
        Name = "bulk pack",
        Symbol = "pk",
        CommonCode = "AB",
    };
    public static IConvertibleUnit Acre = new ConvertibleUnit()
    {
        Name = "acre",
        Symbol = "acre",
        CommonCode = "ACR",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 4046.873m,
    };
    /// <summary>
    /// A unit of count defining the number of activities (activity: a unit of work or action).
    /// </summary>
    public static IUnit Activity = new Unit()
    {
        Name = "activity",
        Symbol = null,
        CommonCode = "ACT",
    };
    /// <summary>
    /// A unit of information equal to 8 bits.
    /// </summary>
    public static IUnit Byte = new Unit()
    {
        Name = "byte",
        Symbol = "byte",
        CommonCode = "AD",
    };
    public static IConvertibleUnit AmperePerMetre = new ConvertibleUnit()
    {
        Name = "ampere per metre",
        Symbol = "A/m",
        CommonCode = "AE",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of time defining the number of minutes in addition to the referenced minutes.
    /// </summary>
    public static IUnit AdditionalMinute = new Unit()
    {
        Name = "additional minute",
        Symbol = null,
        CommonCode = "AH",
    };
    /// <summary>
    /// A unit of count defining the number of minutes for the average interval of a call.
    /// </summary>
    public static IUnit AverageMinutePerCall = new Unit()
    {
        Name = "average minute per call",
        Symbol = null,
        CommonCode = "AI",
    };
    public static IConvertibleUnit Fathom = new ConvertibleUnit()
    {
        Name = "fathom",
        Symbol = "fth",
        CommonCode = "AK",
        ConversionGroup = "meter",
        ConversionFactor = 1.8288m,
    };
    /// <summary>
    /// A unit of count defining the number of telephone access lines.
    /// </summary>
    public static IUnit AccessLine = new Unit()
    {
        Name = "access line",
        Symbol = null,
        CommonCode = "AL",
    };
    /// <summary>
    /// A unit of electric charge defining the amount of charge accumulated by a steady flow of one ampere for one hour.
    /// </summary>
    public static IConvertibleUnit AmpereHour = new ConvertibleUnit()
    {
        Name = "ampere hour",
        Symbol = "A·h",
        CommonCode = "AMH",
        ConversionGroup = "coulomb",
        ConversionFactor = 3600.0m,
    };
    public static IConvertibleUnit Ampere = new ConvertibleUnit()
    {
        Name = "ampere",
        Symbol = "A",
        CommonCode = "AMP",
        ConversionGroup = "ampere",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit of time equal to 365,25 days.Synonym: Julian year
    /// </summary>
    public static IConvertibleUnit Year = new ConvertibleUnit()
    {
        Name = "year",
        Symbol = "y",
        CommonCode = "ANN",
        ConversionGroup = "second",
        ConversionFactor = 31557600.0m,
    };
    public static IConvertibleUnit TroyOunceOrApothecaryOunce = new ConvertibleUnit()
    {
        Name = "troy ounce or apothecary ounce",
        Symbol = "tr oz",
        CommonCode = "APZ",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.003110348m,
    };
    /// <summary>
    /// A unit of measure for blood potency (US).
    /// </summary>
    public static IUnit AntihemophilicFactorAHFUnit = new Unit()
    {
        Name = "antihemophilic factor (AHF) unit",
        Symbol = null,
        CommonCode = "AQ",
    };
    /// <summary>
    /// A unit of count defining the number of assortments (assortment: set of items grouped in a mixed collection).
    /// </summary>
    public static IUnit Assortment = new Unit()
    {
        Name = "assortment",
        Symbol = null,
        CommonCode = "AS",
    };
    /// <summary>
    /// A unit of mass defining the alcoholic strength of a liquid.
    /// </summary>
    public static IUnit AlcoholicStrengthByMass = new Unit()
    {
        Name = "alcoholic strength by mass",
        Symbol = null,
        CommonCode = "ASM",
    };
    /// <summary>
    /// A unit of volume defining the alcoholic strength of a liquid (e.g. spirit, wine, beer, etc), often at a specific temperature.
    /// </summary>
    public static IUnit AlcoholicStrengthByVolume = new Unit()
    {
        Name = "alcoholic strength by volume",
        Symbol = null,
        CommonCode = "ASU",
    };
    public static IConvertibleUnit StandardAtmosphere = new ConvertibleUnit()
    {
        Name = "standard atmosphere",
        Symbol = "atm",
        CommonCode = "ATM",
        ConversionGroup = "pascal",
        ConversionFactor = 101325m,
    };
    /// <summary>
    /// A unit of distance used for measuring the diameter of small tubes or wires such as the outer diameter of hypotermic or suture needles.
    /// </summary>
    public static IUnit AmericanWireGauge = new Unit()
    {
        Name = "american wire gauge",
        Symbol = "AWG",
        CommonCode = "AWG",
    };
    /// <summary>
    /// A unit of count defining the number of assemblies (assembly: items that consist of component parts).
    /// </summary>
    public static IUnit Assembly = new Unit()
    {
        Name = "assembly",
        Symbol = null,
        CommonCode = "AY",
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerPound = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per pound",
        Symbol = "BtuIT/lb",
        CommonCode = "AZ",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 2326.0m,
    };
    public static IConvertibleUnit BarrelUSPerDay = new ConvertibleUnit()
    {
        Name = "barrel (US) per day",
        Symbol = "barrel (US)/d",
        CommonCode = "B1",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000184013m,
    };
    /// <summary>
    /// A unit of information equal to one binary digit per second.
    /// </summary>
    public static IUnit BitPerSecond = new Unit()
    {
        Name = "bit per second",
        Symbol = "bit/s",
        CommonCode = "B10",
    };
    public static IConvertibleUnit JoulePerKilogramKelvin = new ConvertibleUnit()
    {
        Name = "joule per kilogram kelvin",
        Symbol = "J/(kg·K)",
        CommonCode = "B11",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit JoulePerMetre = new ConvertibleUnit()
    {
        Name = "joule per metre",
        Symbol = "J/m",
        CommonCode = "B12",
        ConversionGroup = "joule / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Synonym: joule per metre squared
    /// </summary>
    public static IConvertibleUnit JoulePerSquareMetre = new ConvertibleUnit()
    {
        Name = "joule per square metre",
        Symbol = "J/m²",
        CommonCode = "B13",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit JoulePerMetreToTheFourthPower = new ConvertibleUnit()
    {
        Name = "joule per metre to the fourth power",
        Symbol = "J/m⁴",
        CommonCode = "B14",
        ConversionGroup = "joule / meter ** 4",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit JoulePerMole = new ConvertibleUnit()
    {
        Name = "joule per mole",
        Symbol = "J/mol",
        CommonCode = "B15",
        ConversionGroup = "joule / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit JoulePerMoleKelvin = new ConvertibleUnit()
    {
        Name = "joule per mole kelvin",
        Symbol = "J/(mol·K)",
        CommonCode = "B16",
        ConversionGroup = "joule / kelvin / mole",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of entries made to the credit side of an account.
    /// </summary>
    public static IUnit Credit = new Unit()
    {
        Name = "credit",
        Symbol = null,
        CommonCode = "B17",
    };
    public static IConvertibleUnit JouleSecond = new ConvertibleUnit()
    {
        Name = "joule second",
        Symbol = "J·s",
        CommonCode = "B18",
        ConversionGroup = "joule * second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of information defining the quantity of numerals used to form a number.
    /// </summary>
    public static IUnit Digit = new Unit()
    {
        Name = "digit",
        Symbol = null,
        CommonCode = "B19",
    };
    public static IConvertibleUnit JouleSquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "joule square metre per kilogram",
        Symbol = "J·m²/kg",
        CommonCode = "B20",
        ConversionGroup = "joule * meter ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KelvinPerWatt = new ConvertibleUnit()
    {
        Name = "kelvin per watt",
        Symbol = "K/W",
        CommonCode = "B21",
        ConversionGroup = "kelvin / watt",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Kiloampere = new ConvertibleUnit()
    {
        Name = "kiloampere",
        Symbol = "kA",
        CommonCode = "B22",
        ConversionGroup = "ampere",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KiloamperePerSquareMetre = new ConvertibleUnit()
    {
        Name = "kiloampere per square metre",
        Symbol = "kA/m²",
        CommonCode = "B23",
        ConversionGroup = "ampere / meter ** 2",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KiloamperePerMetre = new ConvertibleUnit()
    {
        Name = "kiloampere per metre",
        Symbol = "kA/m",
        CommonCode = "B24",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilobecquerelPerKilogram = new ConvertibleUnit()
    {
        Name = "kilobecquerel per kilogram",
        Symbol = "kBq/kg",
        CommonCode = "B25",
        ConversionGroup = "becquerel / kilogram",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Kilocoulomb = new ConvertibleUnit()
    {
        Name = "kilocoulomb",
        Symbol = "kC",
        CommonCode = "B26",
        ConversionGroup = "coulomb",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilocoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "kilocoulomb per cubic metre",
        Symbol = "kC/m³",
        CommonCode = "B27",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilocoulombPerSquareMetre = new ConvertibleUnit()
    {
        Name = "kilocoulomb per square metre",
        Symbol = "kC/m²",
        CommonCode = "B28",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Kiloelectronvolt = new ConvertibleUnit()
    {
        Name = "kiloelectronvolt",
        Symbol = "keV",
        CommonCode = "B29",
        ConversionGroup = "electron_volt",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of mass defining the number of pounds of wadded fibre.
    /// </summary>
    public static IUnit BattingPound = new Unit()
    {
        Name = "batting pound",
        Symbol = null,
        CommonCode = "B3",
    };
    /// <summary>
    /// A unit of information equal to 2³⁰ bits (binary digits).
    /// </summary>
    public static IUnit Gibibit = new Unit()
    {
        Name = "gibibit",
        Symbol = "Gibit",
        CommonCode = "B30",
    };
    public static IConvertibleUnit KilogramMetrePerSecond = new ConvertibleUnit()
    {
        Name = "kilogram metre per second",
        Symbol = "kg·m/s",
        CommonCode = "B31",
        ConversionGroup = "kilogram * meter / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KilogramMetreSquared = new ConvertibleUnit()
    {
        Name = "kilogram metre squared",
        Symbol = "kg·m²",
        CommonCode = "B32",
        ConversionGroup = "kilogram * meter ** 2",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KilogramMetreSquaredPerSecond = new ConvertibleUnit()
    {
        Name = "kilogram metre squared per second",
        Symbol = "kg·m²/s",
        CommonCode = "B33",
        ConversionGroup = "kilogram * meter ** 2 / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KilogramPerCubicDecimetre = new ConvertibleUnit()
    {
        Name = "kilogram per cubic decimetre",
        Symbol = "kg/dm³",
        CommonCode = "B34",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilogramPerLitre = new ConvertibleUnit()
    {
        Name = "kilogram per litre",
        Symbol = "kg/l or kg/L",
        CommonCode = "B35",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// A unit of volume used to measure beer.  One beer barrel equals 36 imperial gallons.
    /// </summary>
    public static IUnit BarrelImperial = new Unit()
    {
        Name = "barrel, imperial",
        Symbol = null,
        CommonCode = "B4",
    };
    public static IConvertibleUnit KilojoulePerKelvin = new ConvertibleUnit()
    {
        Name = "kilojoule per kelvin",
        Symbol = "kJ/K",
        CommonCode = "B41",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilojoulePerKilogram = new ConvertibleUnit()
    {
        Name = "kilojoule per kilogram",
        Symbol = "kJ/kg",
        CommonCode = "B42",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilojoulePerKilogramKelvin = new ConvertibleUnit()
    {
        Name = "kilojoule per kilogram kelvin",
        Symbol = "kJ/(kg·K)",
        CommonCode = "B43",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilojoulePerMole = new ConvertibleUnit()
    {
        Name = "kilojoule per mole",
        Symbol = "kJ/mol",
        CommonCode = "B44",
        ConversionGroup = "joule / mole",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Kilomole = new ConvertibleUnit()
    {
        Name = "kilomole",
        Symbol = "kmol",
        CommonCode = "B45",
        ConversionGroup = "mole",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilomolePerCubicMetre = new ConvertibleUnit()
    {
        Name = "kilomole per cubic metre",
        Symbol = "kmol/m³",
        CommonCode = "B46",
        ConversionGroup = "mole / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Kilonewton = new ConvertibleUnit()
    {
        Name = "kilonewton",
        Symbol = "kN",
        CommonCode = "B47",
        ConversionGroup = "newton",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilonewtonMetre = new ConvertibleUnit()
    {
        Name = "kilonewton metre",
        Symbol = "kN·m",
        CommonCode = "B48",
        ConversionGroup = "meter * newton",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kiloohm = new ConvertibleUnit()
    {
        Name = "kiloohm",
        Symbol = "kΩ",
        CommonCode = "B49",
        ConversionGroup = "ohm",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KiloohmMetre = new ConvertibleUnit()
    {
        Name = "kiloohm metre",
        Symbol = "kΩ·m",
        CommonCode = "B50",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kilosecond = new ConvertibleUnit()
    {
        Name = "kilosecond",
        Symbol = "ks",
        CommonCode = "B52",
        ConversionGroup = "second",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kilosiemens = new ConvertibleUnit()
    {
        Name = "kilosiemens",
        Symbol = "kS",
        CommonCode = "B53",
        ConversionGroup = "siemens",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilosiemensPerMetre = new ConvertibleUnit()
    {
        Name = "kilosiemens per metre",
        Symbol = "kS/m",
        CommonCode = "B54",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilovoltPerMetre = new ConvertibleUnit()
    {
        Name = "kilovolt per metre",
        Symbol = "kV/m",
        CommonCode = "B55",
        ConversionGroup = "volt / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KiloweberPerMetre = new ConvertibleUnit()
    {
        Name = "kiloweber per metre",
        Symbol = "kWb/m",
        CommonCode = "B56",
        ConversionGroup = "weber / meter",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// A unit of length defining the distance that light travels in a vacuum in one year.
    /// </summary>
    public static IConvertibleUnit LightYear = new ConvertibleUnit()
    {
        Name = "light year",
        Symbol = "ly",
        CommonCode = "B57",
        ConversionGroup = "meter",
        ConversionFactor = 9460730000000000.0m,
    };
    public static IConvertibleUnit LitrePerMole = new ConvertibleUnit()
    {
        Name = "litre per mole",
        Symbol = "l/mol",
        CommonCode = "B58",
        ConversionGroup = "meter ** 3 / mole",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit LumenHour = new ConvertibleUnit()
    {
        Name = "lumen hour",
        Symbol = "lm·h",
        CommonCode = "B59",
        ConversionGroup = "candela * second * steradian",
        ConversionFactor = 3600.0m,
    };
    public static IConvertibleUnit LumenPerSquareMetre = new ConvertibleUnit()
    {
        Name = "lumen per square metre",
        Symbol = "lm/m²",
        CommonCode = "B60",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit LumenPerWatt = new ConvertibleUnit()
    {
        Name = "lumen per watt",
        Symbol = "lm/W",
        CommonCode = "B61",
        ConversionGroup = "candela * steradian / watt",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit LumenSecond = new ConvertibleUnit()
    {
        Name = "lumen second",
        Symbol = "lm·s",
        CommonCode = "B62",
        ConversionGroup = "candela * second * steradian",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit LuxHour = new ConvertibleUnit()
    {
        Name = "lux hour",
        Symbol = "lx·h",
        CommonCode = "B63",
        ConversionGroup = "candela * second * steradian / meter ** 2",
        ConversionFactor = 3600.0m,
    };
    public static IConvertibleUnit LuxSecond = new ConvertibleUnit()
    {
        Name = "lux second",
        Symbol = "lx·s",
        CommonCode = "B64",
        ConversionGroup = "candela * second * steradian / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MegaamperePerSquareMetre = new ConvertibleUnit()
    {
        Name = "megaampere per square metre",
        Symbol = "MA/m²",
        CommonCode = "B66",
        ConversionGroup = "ampere / meter ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit MegabecquerelPerKilogram = new ConvertibleUnit()
    {
        Name = "megabecquerel per kilogram",
        Symbol = "MBq/kg",
        CommonCode = "B67",
        ConversionGroup = "becquerel / kilogram",
        ConversionFactor = 1000000.0m,
    };
    /// <summary>
    /// A unit of information equal to 10⁹ bits (binary digits).
    /// </summary>
    public static IUnit Gigabit = new Unit()
    {
        Name = "gigabit",
        Symbol = "Gbit",
        CommonCode = "B68",
    };
    public static IConvertibleUnit MegacoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "megacoulomb per cubic metre",
        Symbol = "MC/m³",
        CommonCode = "B69",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    /// <summary>
    /// A unit of count defining the number of cycles (cycle: a recurrent period of definite duration).
    /// </summary>
    public static IUnit Cycle = new Unit()
    {
        Name = "cycle",
        Symbol = null,
        CommonCode = "B7",
    };
    public static IConvertibleUnit MegacoulombPerSquareMetre = new ConvertibleUnit()
    {
        Name = "megacoulomb per square metre",
        Symbol = "MC/m²",
        CommonCode = "B70",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit Megaelectronvolt = new ConvertibleUnit()
    {
        Name = "megaelectronvolt",
        Symbol = "MeV",
        CommonCode = "B71",
        ConversionGroup = "electron_volt",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MegagramPerCubicMetre = new ConvertibleUnit()
    {
        Name = "megagram per cubic metre",
        Symbol = "Mg/m³",
        CommonCode = "B72",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Meganewton = new ConvertibleUnit()
    {
        Name = "meganewton",
        Symbol = "MN",
        CommonCode = "B73",
        ConversionGroup = "newton",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MeganewtonMetre = new ConvertibleUnit()
    {
        Name = "meganewton metre",
        Symbol = "MN·m",
        CommonCode = "B74",
        ConversionGroup = "meter * newton",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit Megaohm = new ConvertibleUnit()
    {
        Name = "megaohm",
        Symbol = "MΩ",
        CommonCode = "B75",
        ConversionGroup = "ohm",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MegaohmMetre = new ConvertibleUnit()
    {
        Name = "megaohm metre",
        Symbol = "MΩ·m",
        CommonCode = "B76",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MegasiemensPerMetre = new ConvertibleUnit()
    {
        Name = "megasiemens per metre",
        Symbol = "MS/m",
        CommonCode = "B77",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit Megavolt = new ConvertibleUnit()
    {
        Name = "megavolt",
        Symbol = "MV",
        CommonCode = "B78",
        ConversionGroup = "volt",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MegavoltPerMetre = new ConvertibleUnit()
    {
        Name = "megavolt per metre",
        Symbol = "MV/m",
        CommonCode = "B79",
        ConversionGroup = "volt / meter",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit JoulePerCubicMetre = new ConvertibleUnit()
    {
        Name = "joule per cubic metre",
        Symbol = "J/m³",
        CommonCode = "B8",
        ConversionGroup = "joule / meter ** 3",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information equal to 10⁹ bits (binary digits) per second.
    /// </summary>
    public static IUnit GigabitPerSecond = new Unit()
    {
        Name = "gigabit per second",
        Symbol = "Gbit/s",
        CommonCode = "B80",
    };
    public static IConvertibleUnit ReciprocalMetreSquaredReciprocalSecond = new ConvertibleUnit()
    {
        Name = "reciprocal metre squared reciprocal second",
        Symbol = "m⁻²/s",
        CommonCode = "B81",
        ConversionGroup = "1 / meter ** 2 / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of length defining the number of inches per linear foot.
    /// </summary>
    public static IUnit InchPerLinearFoot = new Unit()
    {
        Name = "inch per linear foot",
        Symbol = null,
        CommonCode = "B82",
    };
    public static IConvertibleUnit MetreToTheFourthPower = new ConvertibleUnit()
    {
        Name = "metre to the fourth power",
        Symbol = "m⁴",
        CommonCode = "B83",
        ConversionGroup = "meter ** 4",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Microampere = new ConvertibleUnit()
    {
        Name = "microampere",
        Symbol = "µA",
        CommonCode = "B84",
        ConversionGroup = "ampere",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microbar = new ConvertibleUnit()
    {
        Name = "microbar",
        Symbol = "µbar",
        CommonCode = "B85",
        ConversionGroup = "pascal",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit Microcoulomb = new ConvertibleUnit()
    {
        Name = "microcoulomb",
        Symbol = "µC",
        CommonCode = "B86",
        ConversionGroup = "coulomb",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrocoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "microcoulomb per cubic metre",
        Symbol = "µC/m³",
        CommonCode = "B87",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrocoulombPerSquareMetre = new ConvertibleUnit()
    {
        Name = "microcoulomb per square metre",
        Symbol = "µC/m²",
        CommonCode = "B88",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrofaradPerMetre = new ConvertibleUnit()
    {
        Name = "microfarad per metre",
        Symbol = "µF/m",
        CommonCode = "B89",
        ConversionGroup = "farad / meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microhenry = new ConvertibleUnit()
    {
        Name = "microhenry",
        Symbol = "µH",
        CommonCode = "B90",
        ConversionGroup = "henry",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrohenryPerMetre = new ConvertibleUnit()
    {
        Name = "microhenry per metre",
        Symbol = "µH/m",
        CommonCode = "B91",
        ConversionGroup = "henry / meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Micronewton = new ConvertibleUnit()
    {
        Name = "micronewton",
        Symbol = "µN",
        CommonCode = "B92",
        ConversionGroup = "newton",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicronewtonMetre = new ConvertibleUnit()
    {
        Name = "micronewton metre",
        Symbol = "µN·m",
        CommonCode = "B93",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microohm = new ConvertibleUnit()
    {
        Name = "microohm",
        Symbol = "µΩ",
        CommonCode = "B94",
        ConversionGroup = "ohm",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicroohmMetre = new ConvertibleUnit()
    {
        Name = "microohm metre",
        Symbol = "µΩ·m",
        CommonCode = "B95",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Micropascal = new ConvertibleUnit()
    {
        Name = "micropascal",
        Symbol = "µPa",
        CommonCode = "B96",
        ConversionGroup = "pascal",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microradian = new ConvertibleUnit()
    {
        Name = "microradian",
        Symbol = "µrad",
        CommonCode = "B97",
        ConversionGroup = "radian",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microsecond = new ConvertibleUnit()
    {
        Name = "microsecond",
        Symbol = "µs",
        CommonCode = "B98",
        ConversionGroup = "second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microsiemens = new ConvertibleUnit()
    {
        Name = "microsiemens",
        Symbol = "µS",
        CommonCode = "B99",
        ConversionGroup = "siemens",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit BarUnitOfPressure = new ConvertibleUnit()
    {
        Name = "bar [unit of pressure]",
        Symbol = "bar",
        CommonCode = "BAR",
        ConversionGroup = "pascal",
        ConversionFactor = 100000m,
    };
    /// <summary>
    /// A unit of area of 112 sheets of tin mil products (tin plate, tin free steel or black plate) 14 by 20 inches, or 31,360 square inches.
    /// </summary>
    public static IUnit BaseBox = new Unit()
    {
        Name = "base box",
        Symbol = null,
        CommonCode = "BB",
    };
    /// <summary>
    /// A unit of volume defining the number of cords (cord: a stack of firewood of 128 cubic feet).
    /// </summary>
    public static IUnit BoardFoot = new Unit()
    {
        Name = "board foot",
        Symbol = "fbm",
        CommonCode = "BFT",
    };
    public static IConvertibleUnit BrakeHorsePower = new ConvertibleUnit()
    {
        Name = "brake horse power",
        Symbol = "BHP",
        CommonCode = "BHP",
        ConversionGroup = "watt",
        ConversionFactor = 745.6999999999999m,
    };
    /// <summary>
    /// Synonym: trillion (US)
    /// </summary>
    public static IConvertibleUnit BillionEUR = new ConvertibleUnit()
    {
        Name = "billion (EUR)",
        Symbol = null,
        CommonCode = "BIL",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000000000000m,
    };
    public static IConvertibleUnit DryBarrelUS = new ConvertibleUnit()
    {
        Name = "dry barrel (US)",
        Symbol = "bbl (US)",
        CommonCode = "BLD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.115627m,
    };
    public static IConvertibleUnit BarrelUS = new ConvertibleUnit()
    {
        Name = "barrel (US)",
        Symbol = "barrel (US)",
        CommonCode = "BLL",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.1589873m,
    };
    /// <summary>
    /// A unit of volume equal to one hundred board foot.
    /// </summary>
    public static IUnit HundredBoardFoot = new Unit()
    {
        Name = "hundred board foot",
        Symbol = null,
        CommonCode = "BP",
    };
    /// <summary>
    /// The number of beats per minute.
    /// </summary>
    public static IConvertibleUnit BeatsPerMinute = new ConvertibleUnit()
    {
        Name = "beats per minute",
        Symbol = "BPM",
        CommonCode = "BPM",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.01667m,
    };
    public static IConvertibleUnit Becquerel = new ConvertibleUnit()
    {
        Name = "becquerel",
        Symbol = "Bq",
        CommonCode = "BQL",
        ConversionGroup = "curie",
        ConversionFactor = 0.000000000027027m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTable = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table)",
        Symbol = "BtuIT",
        CommonCode = "BTU",
        ConversionGroup = "joule",
        ConversionFactor = 1055.056m,
    };
    public static IConvertibleUnit BushelUS = new ConvertibleUnit()
    {
        Name = "bushel (US)",
        Symbol = "bu (US)",
        CommonCode = "BUA",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.03523907m,
    };
    public static IConvertibleUnit BushelUK = new ConvertibleUnit()
    {
        Name = "bushel (UK)",
        Symbol = "bushel (UK)",
        CommonCode = "BUI",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.03636872m,
    };
    /// <summary>
    /// A unit of count defining the number of calls (call: communication session or visitation).
    /// </summary>
    public static IUnit Call = new Unit()
    {
        Name = "call",
        Symbol = null,
        CommonCode = "C0",
    };
    public static IConvertibleUnit Millifarad = new ConvertibleUnit()
    {
        Name = "millifarad",
        Symbol = "mF",
        CommonCode = "C10",
        ConversionGroup = "farad",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Milligal = new ConvertibleUnit()
    {
        Name = "milligal",
        Symbol = "mGal",
        CommonCode = "C11",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MilligramPerMetre = new ConvertibleUnit()
    {
        Name = "milligram per metre",
        Symbol = "mg/m",
        CommonCode = "C12",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Milligray = new ConvertibleUnit()
    {
        Name = "milligray",
        Symbol = "mGy",
        CommonCode = "C13",
        ConversionGroup = "gray",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millihenry = new ConvertibleUnit()
    {
        Name = "millihenry",
        Symbol = "mH",
        CommonCode = "C14",
        ConversionGroup = "henry",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millijoule = new ConvertibleUnit()
    {
        Name = "millijoule",
        Symbol = "mJ",
        CommonCode = "C15",
        ConversionGroup = "joule",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillimetrePerSecond = new ConvertibleUnit()
    {
        Name = "millimetre per second",
        Symbol = "mm/s",
        CommonCode = "C16",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillimetreSquaredPerSecond = new ConvertibleUnit()
    {
        Name = "millimetre squared per second",
        Symbol = "mm²/s",
        CommonCode = "C17",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Millimole = new ConvertibleUnit()
    {
        Name = "millimole",
        Symbol = "mmol",
        CommonCode = "C18",
        ConversionGroup = "mole",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MolePerKilogram = new ConvertibleUnit()
    {
        Name = "mole per kilogram",
        Symbol = "mol/kg",
        CommonCode = "C19",
        ConversionGroup = "mole / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Millinewton = new ConvertibleUnit()
    {
        Name = "millinewton",
        Symbol = "mN",
        CommonCode = "C20",
        ConversionGroup = "newton",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of information equal to 2¹⁰ (1024) bits (binary digits).
    /// </summary>
    public static IUnit Kibibit = new Unit()
    {
        Name = "kibibit",
        Symbol = "Kibit",
        CommonCode = "C21",
    };
    public static IConvertibleUnit MillinewtonPerMetre = new ConvertibleUnit()
    {
        Name = "millinewton per metre",
        Symbol = "mN/m",
        CommonCode = "C22",
        ConversionGroup = "newton / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MilliohmMetre = new ConvertibleUnit()
    {
        Name = "milliohm metre",
        Symbol = "mΩ·m",
        CommonCode = "C23",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillipascalSecond = new ConvertibleUnit()
    {
        Name = "millipascal second",
        Symbol = "mPa·s",
        CommonCode = "C24",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Milliradian = new ConvertibleUnit()
    {
        Name = "milliradian",
        Symbol = "mrad",
        CommonCode = "C25",
        ConversionGroup = "radian",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millisecond = new ConvertibleUnit()
    {
        Name = "millisecond",
        Symbol = "ms",
        CommonCode = "C26",
        ConversionGroup = "second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millisiemens = new ConvertibleUnit()
    {
        Name = "millisiemens",
        Symbol = "mS",
        CommonCode = "C27",
        ConversionGroup = "siemens",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millisievert = new ConvertibleUnit()
    {
        Name = "millisievert",
        Symbol = "mSv",
        CommonCode = "C28",
        ConversionGroup = "sievert",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Millitesla = new ConvertibleUnit()
    {
        Name = "millitesla",
        Symbol = "mT",
        CommonCode = "C29",
        ConversionGroup = "tesla",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MicrovoltPerMetre = new ConvertibleUnit()
    {
        Name = "microvolt per metre",
        Symbol = "µV/m",
        CommonCode = "C3",
        ConversionGroup = "volt / meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillivoltPerMetre = new ConvertibleUnit()
    {
        Name = "millivolt per metre",
        Symbol = "mV/m",
        CommonCode = "C30",
        ConversionGroup = "volt / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Milliwatt = new ConvertibleUnit()
    {
        Name = "milliwatt",
        Symbol = "mW",
        CommonCode = "C31",
        ConversionGroup = "watt",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MilliwattPerSquareMetre = new ConvertibleUnit()
    {
        Name = "milliwatt per square metre",
        Symbol = "mW/m²",
        CommonCode = "C32",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Milliweber = new ConvertibleUnit()
    {
        Name = "milliweber",
        Symbol = "mWb",
        CommonCode = "C33",
        ConversionGroup = "weber",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Mole = new ConvertibleUnit()
    {
        Name = "mole",
        Symbol = "mol",
        CommonCode = "C34",
        ConversionGroup = "mole",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit MolePerCubicDecimetre = new ConvertibleUnit()
    {
        Name = "mole per cubic decimetre",
        Symbol = "mol/dm³",
        CommonCode = "C35",
        ConversionGroup = "mole / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MolePerCubicMetre = new ConvertibleUnit()
    {
        Name = "mole per cubic metre",
        Symbol = "mol/m³",
        CommonCode = "C36",
        ConversionGroup = "mole / meter ** 3",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information equal to 10³ (1000) bits (binary digits).
    /// </summary>
    public static IUnit Kilobit = new Unit()
    {
        Name = "kilobit",
        Symbol = "kbit",
        CommonCode = "C37",
    };
    public static IConvertibleUnit MolePerLitre = new ConvertibleUnit()
    {
        Name = "mole per litre",
        Symbol = "mol/l",
        CommonCode = "C38",
        ConversionGroup = "mole / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Nanoampere = new ConvertibleUnit()
    {
        Name = "nanoampere",
        Symbol = "nA",
        CommonCode = "C39",
        ConversionGroup = "ampere",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanocoulomb = new ConvertibleUnit()
    {
        Name = "nanocoulomb",
        Symbol = "nC",
        CommonCode = "C40",
        ConversionGroup = "coulomb",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanofarad = new ConvertibleUnit()
    {
        Name = "nanofarad",
        Symbol = "nF",
        CommonCode = "C41",
        ConversionGroup = "farad",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit NanofaradPerMetre = new ConvertibleUnit()
    {
        Name = "nanofarad per metre",
        Symbol = "nF/m",
        CommonCode = "C42",
        ConversionGroup = "farad / meter",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanohenry = new ConvertibleUnit()
    {
        Name = "nanohenry",
        Symbol = "nH",
        CommonCode = "C43",
        ConversionGroup = "henry",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit NanohenryPerMetre = new ConvertibleUnit()
    {
        Name = "nanohenry per metre",
        Symbol = "nH/m",
        CommonCode = "C44",
        ConversionGroup = "henry / meter",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanometre = new ConvertibleUnit()
    {
        Name = "nanometre",
        Symbol = "nm",
        CommonCode = "C45",
        ConversionGroup = "meter",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit NanoohmMetre = new ConvertibleUnit()
    {
        Name = "nanoohm metre",
        Symbol = "nΩ·m",
        CommonCode = "C46",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanosecond = new ConvertibleUnit()
    {
        Name = "nanosecond",
        Symbol = "ns",
        CommonCode = "C47",
        ConversionGroup = "second",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanotesla = new ConvertibleUnit()
    {
        Name = "nanotesla",
        Symbol = "nT",
        CommonCode = "C48",
        ConversionGroup = "tesla",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Nanowatt = new ConvertibleUnit()
    {
        Name = "nanowatt",
        Symbol = "nW",
        CommonCode = "C49",
        ConversionGroup = "watt",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Neper = new ConvertibleUnit()
    {
        Name = "neper",
        Symbol = "Np",
        CommonCode = "C50",
        ConversionGroup = "neper",
        ConversionFactor = 1m,
    };
    public static IUnit NeperPerSecond = new Unit()
    {
        Name = "neper per second",
        Symbol = "Np/s",
        CommonCode = "C51",
    };
    public static IConvertibleUnit Picometre = new ConvertibleUnit()
    {
        Name = "picometre",
        Symbol = "pm",
        CommonCode = "C52",
        ConversionGroup = "meter",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit NewtonMetreSecond = new ConvertibleUnit()
    {
        Name = "newton metre second",
        Symbol = "N·m·s",
        CommonCode = "C53",
        ConversionGroup = "meter * newton * second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit NewtonMetreSquaredPerKilogramSquared = new ConvertibleUnit()
    {
        Name = "newton metre squared per kilogram squared",
        Symbol = "N·m²/kg²",
        CommonCode = "C54",
        ConversionGroup = "meter ** 2 * newton / kilogram ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit NewtonPerSquareMetre = new ConvertibleUnit()
    {
        Name = "newton per square metre",
        Symbol = "N/m²",
        CommonCode = "C55",
        ConversionGroup = "pascal",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit NewtonPerSquareMillimetre = new ConvertibleUnit()
    {
        Name = "newton per square millimetre",
        Symbol = "N/mm²",
        CommonCode = "C56",
        ConversionGroup = "pascal",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit NewtonSecond = new ConvertibleUnit()
    {
        Name = "newton second",
        Symbol = "N·s",
        CommonCode = "C57",
        ConversionGroup = "newton * second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit NewtonSecondPerMetre = new ConvertibleUnit()
    {
        Name = "newton second per metre",
        Symbol = "N·s/m",
        CommonCode = "C58",
        ConversionGroup = "newton * second / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit used in music to describe the ratio in frequency between notes.
    /// </summary>
    public static IUnit Octave = new Unit()
    {
        Name = "octave",
        Symbol = null,
        CommonCode = "C59",
    };
    public static IConvertibleUnit OhmCentimetre = new ConvertibleUnit()
    {
        Name = "ohm centimetre",
        Symbol = "Ω·cm",
        CommonCode = "C60",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit OhmMetre = new ConvertibleUnit()
    {
        Name = "ohm metre",
        Symbol = "Ω·m",
        CommonCode = "C61",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Synonym: unit
    /// </summary>
    public static IConvertibleUnit One = new ConvertibleUnit()
    {
        Name = "one",
        Symbol = "1",
        CommonCode = "C62",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Parsec = new ConvertibleUnit()
    {
        Name = "parsec",
        Symbol = "pc",
        CommonCode = "C63",
        ConversionGroup = "meter",
        ConversionFactor = 30856780000000000m,
    };
    public static IConvertibleUnit PascalPerKelvin = new ConvertibleUnit()
    {
        Name = "pascal per kelvin",
        Symbol = "Pa/K",
        CommonCode = "C64",
        ConversionGroup = "pascal / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit PascalSecond = new ConvertibleUnit()
    {
        Name = "pascal second",
        Symbol = "Pa·s",
        CommonCode = "C65",
        ConversionGroup = "pascal * second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit PascalSecondPerCubicMetre = new ConvertibleUnit()
    {
        Name = "pascal second per cubic metre",
        Symbol = "Pa·s/m³",
        CommonCode = "C66",
        ConversionGroup = "pascal * second / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit PascalSecondPerMetre = new ConvertibleUnit()
    {
        Name = "pascal second per metre",
        Symbol = "Pa· s/m",
        CommonCode = "C67",
        ConversionGroup = "pascal * second / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Petajoule = new ConvertibleUnit()
    {
        Name = "petajoule",
        Symbol = "PJ",
        CommonCode = "C68",
        ConversionGroup = "joule",
        ConversionFactor = 1000000000000000m,
    };
    /// <summary>
    /// A unit of subjective sound loudness. A sound has loudness p phons if it seems to the listener to be equal in loudness to the sound of a pure tone of frequency 1 kilohertz and strength p decibels.
    /// </summary>
    public static IUnit Phon = new Unit()
    {
        Name = "phon",
        Symbol = null,
        CommonCode = "C69",
    };
    public static IConvertibleUnit Centipoise = new ConvertibleUnit()
    {
        Name = "centipoise",
        Symbol = "cP",
        CommonCode = "C7",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Picoampere = new ConvertibleUnit()
    {
        Name = "picoampere",
        Symbol = "pA",
        CommonCode = "C70",
        ConversionGroup = "ampere",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit Picocoulomb = new ConvertibleUnit()
    {
        Name = "picocoulomb",
        Symbol = "pC",
        CommonCode = "C71",
        ConversionGroup = "coulomb",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit PicofaradPerMetre = new ConvertibleUnit()
    {
        Name = "picofarad per metre",
        Symbol = "pF/m",
        CommonCode = "C72",
        ConversionGroup = "farad / meter",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit Picohenry = new ConvertibleUnit()
    {
        Name = "picohenry",
        Symbol = "pH",
        CommonCode = "C73",
        ConversionGroup = "henry",
        ConversionFactor = 0.000000000001m,
    };
    /// <summary>
    /// A unit of information equal to 10³ (1000) bits (binary digits) per second.
    /// </summary>
    public static IConvertibleUnit KilobitPerSecond = new ConvertibleUnit()
    {
        Name = "kilobit per second",
        Symbol = "kbit/s",
        CommonCode = "C74",
        ConversionGroup = "bit / second",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Picowatt = new ConvertibleUnit()
    {
        Name = "picowatt",
        Symbol = "pW",
        CommonCode = "C75",
        ConversionGroup = "watt",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit PicowattPerSquareMetre = new ConvertibleUnit()
    {
        Name = "picowatt per square metre",
        Symbol = "pW/m²",
        CommonCode = "C76",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit Poundforce = new ConvertibleUnit()
    {
        Name = "poundforce",
        Symbol = "lbf",
        CommonCode = "C78",
        ConversionGroup = "newton",
        ConversionFactor = 4.448222m,
    };
    /// <summary>
    /// A unit of accumulated energy of 1000 volt amperes over a period of one hour.
    /// </summary>
    public static IUnit KilovoltAmpereHour = new Unit()
    {
        Name = "kilovolt ampere hour",
        Symbol = "kVAh",
        CommonCode = "C79",
    };
    public static IConvertibleUnit MillicoulombPerKilogram = new ConvertibleUnit()
    {
        Name = "millicoulomb per kilogram",
        Symbol = "mC/kg",
        CommonCode = "C8",
        ConversionGroup = "coulomb / kilogram",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Rad = new ConvertibleUnit()
    {
        Name = "rad",
        Symbol = "rad",
        CommonCode = "C80",
        ConversionGroup = "gray",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit Radian = new ConvertibleUnit()
    {
        Name = "radian",
        Symbol = "rad",
        CommonCode = "C81",
        ConversionGroup = "radian",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit RadianSquareMetrePerMole = new ConvertibleUnit()
    {
        Name = "radian square metre per mole",
        Symbol = "rad·m²/mol",
        CommonCode = "C82",
        ConversionGroup = "meter ** 2 * radian / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit RadianSquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "radian square metre per kilogram",
        Symbol = "rad·m²/kg",
        CommonCode = "C83",
        ConversionGroup = "meter ** 2 * radian / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit RadianPerMetre = new ConvertibleUnit()
    {
        Name = "radian per metre",
        Symbol = "rad/m",
        CommonCode = "C84",
        ConversionGroup = "radian / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalAngstrom = new ConvertibleUnit()
    {
        Name = "reciprocal angstrom",
        Symbol = "Å⁻¹",
        CommonCode = "C85",
        ConversionGroup = "1 / meter",
        ConversionFactor = 10000000000.0m,
    };
    public static IConvertibleUnit ReciprocalCubicMetre = new ConvertibleUnit()
    {
        Name = "reciprocal cubic metre",
        Symbol = "m⁻³",
        CommonCode = "C86",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Synonym: reciprocal second per cubic metre
    /// </summary>
    public static IConvertibleUnit ReciprocalCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "reciprocal cubic metre per second",
        Symbol = "m⁻³/s",
        CommonCode = "C87",
        ConversionGroup = "1 / meter ** 3 / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalElectronVoltPerCubicMetre = new ConvertibleUnit()
    {
        Name = "reciprocal electron volt per cubic metre",
        Symbol = "eV⁻¹/m³",
        CommonCode = "C88",
        ConversionGroup = "1 / joule / meter ** 3",
        ConversionFactor = 6241460000000000000m,
    };
    public static IConvertibleUnit ReciprocalHenry = new ConvertibleUnit()
    {
        Name = "reciprocal henry",
        Symbol = "H⁻¹",
        CommonCode = "C89",
        ConversionGroup = "1 / henry",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of coil groups (coil group: groups of items arranged by lengths of those items placed in a joined sequence of concentric circles).
    /// </summary>
    public static IUnit CoilGroup = new Unit()
    {
        Name = "coil group",
        Symbol = null,
        CommonCode = "C9",
    };
    public static IConvertibleUnit ReciprocalJoulePerCubicMetre = new ConvertibleUnit()
    {
        Name = "reciprocal joule per cubic metre",
        Symbol = "J⁻¹/m³",
        CommonCode = "C90",
        ConversionGroup = "1 / joule / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalKelvinOrKelvinToThePowerMinusOne = new ConvertibleUnit()
    {
        Name = "reciprocal kelvin or kelvin to the power minus one",
        Symbol = "K⁻¹",
        CommonCode = "C91",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalMetre = new ConvertibleUnit()
    {
        Name = "reciprocal metre",
        Symbol = "m⁻¹",
        CommonCode = "C92",
        ConversionGroup = "1 / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Synonym: reciprocal metre squared
    /// </summary>
    public static IConvertibleUnit ReciprocalSquareMetre = new ConvertibleUnit()
    {
        Name = "reciprocal square metre",
        Symbol = "m⁻²",
        CommonCode = "C93",
        ConversionGroup = "1 / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalMinute = new ConvertibleUnit()
    {
        Name = "reciprocal minute",
        Symbol = "min⁻¹",
        CommonCode = "C94",
        ConversionGroup = "second",
        ConversionFactor = 0.016666669999999998m,
    };
    public static IConvertibleUnit ReciprocalMole = new ConvertibleUnit()
    {
        Name = "reciprocal mole",
        Symbol = "mol⁻¹",
        CommonCode = "C95",
        ConversionGroup = "1 / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalPascalOrPascalToThePowerMinusOne = new ConvertibleUnit()
    {
        Name = "reciprocal pascal or pascal to the power minus one",
        Symbol = "Pa⁻¹",
        CommonCode = "C96",
        ConversionGroup = "1 / pascal",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalSecond = new ConvertibleUnit()
    {
        Name = "reciprocal second",
        Symbol = "s⁻¹",
        CommonCode = "C97",
        ConversionGroup = "1 / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalSecondPerMetreSquared = new ConvertibleUnit()
    {
        Name = "reciprocal second per metre squared",
        Symbol = "s⁻¹/m²",
        CommonCode = "C99",
        ConversionGroup = "1 / meter ** 2 / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of mass defining the carrying capacity, expressed as the number of metric tons.
    /// </summary>
    public static IUnit CarryingCapacityInMetricTon = new Unit()
    {
        Name = "carrying capacity in metric ton",
        Symbol = null,
        CommonCode = "CCT",
    };
    public static IConvertibleUnit Candela = new ConvertibleUnit()
    {
        Name = "candela",
        Symbol = "cd",
        CommonCode = "CDL",
        ConversionGroup = "candela",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
    /// </summary>
    public static IConvertibleUnit DegreeCelsius = new ConvertibleUnit()
    {
        Name = "degree Celsius",
        Symbol = "°C",
        CommonCode = "CEL",
        ConversionGroup = "kelvin",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of count defining the number of units in multiples of 100.
    /// </summary>
    public static IConvertibleUnit Hundred = new ConvertibleUnit()
    {
        Name = "hundred",
        Symbol = null,
        CommonCode = "CEN",
        ConversionGroup = "dimensionless",
        ConversionFactor = 100m,
    };
    /// <summary>
    /// A unit of count defining the number of units of card (card: thick stiff paper or cardboard).
    /// </summary>
    public static IUnit CardCG = new Unit()
    {
        Name = "card",
        Symbol = null,
        CommonCode = "CG",
    };
    /// <summary>
    /// A flat package usually made of fibreboard from/to which product is often hung or attached.
    /// </summary>
    public static IUnit CardXCM = new Unit()
    {
        Name = "Card",
        Symbol = null,
        CommonCode = "XCM",
    };
    public static IConvertibleUnit Centigram = new ConvertibleUnit()
    {
        Name = "centigram",
        Symbol = "cg",
        CommonCode = "CGM",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit CoulombPerKilogram = new ConvertibleUnit()
    {
        Name = "coulomb per kilogram",
        Symbol = "C/kg",
        CommonCode = "CKG",
        ConversionGroup = "ampere * second / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of leaves, expressed in units of one hundred leaves.
    /// </summary>
    public static IUnit HundredLeave = new Unit()
    {
        Name = "hundred leave",
        Symbol = null,
        CommonCode = "CLF",
    };
    public static IConvertibleUnit Centilitre = new ConvertibleUnit()
    {
        Name = "centilitre",
        Symbol = "cl",
        CommonCode = "CLT",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit SquareCentimetre = new ConvertibleUnit()
    {
        Name = "square centimetre",
        Symbol = "cm²",
        CommonCode = "CMK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit CubicCentimetre = new ConvertibleUnit()
    {
        Name = "cubic centimetre",
        Symbol = "cm³",
        CommonCode = "CMQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Centimetre = new ConvertibleUnit()
    {
        Name = "centimetre",
        Symbol = "cm",
        CommonCode = "CMT",
        ConversionGroup = "meter",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of count defining the number of hundred-packs (hundred-pack: set of one hundred items packaged together).
    /// </summary>
    public static IUnit HundredPack = new Unit()
    {
        Name = "hundred pack",
        Symbol = null,
        CommonCode = "CNP",
    };
    /// <summary>
    /// A unit of mass equal to one hundred weight (US).
    /// </summary>
    public static IConvertibleUnit CentalUK = new ConvertibleUnit()
    {
        Name = "cental (UK)",
        Symbol = null,
        CommonCode = "CNT",
        ConversionGroup = "kilogram",
        ConversionFactor = 45.359237m,
    };
    public static IConvertibleUnit Coulomb = new ConvertibleUnit()
    {
        Name = "coulomb",
        Symbol = "C",
        CommonCode = "COU",
        ConversionGroup = "ampere * second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of mass defining the number of grams of a named item in a product.
    /// </summary>
    public static IUnit ContentGram = new Unit()
    {
        Name = "content gram",
        Symbol = null,
        CommonCode = "CTG",
    };
    public static IConvertibleUnit MetricCarat = new ConvertibleUnit()
    {
        Name = "metric carat",
        Symbol = null,
        CommonCode = "CTM",
        ConversionGroup = "milligram",
        ConversionFactor = 200m,
    };
    /// <summary>
    /// A unit of mass defining the number of metric tons of a named item in a product.
    /// </summary>
    public static IUnit ContentTonMetric = new Unit()
    {
        Name = "content ton (metric)",
        Symbol = null,
        CommonCode = "CTN",
    };
    public static IConvertibleUnit Curie = new ConvertibleUnit()
    {
        Name = "curie",
        Symbol = "Ci",
        CommonCode = "CUR",
        ConversionGroup = "becquerel",
        ConversionFactor = 37000000000.0m,
    };
    public static IConvertibleUnit HundredPoundCwtPerHundredWeightUS = new ConvertibleUnit()
    {
        Name = "hundred pound (cwt) / hundred weight (US)",
        Symbol = "cwt (US)",
        CommonCode = "CWA",
        ConversionGroup = "kilogram",
        ConversionFactor = 45.3592m,
    };
    public static IConvertibleUnit HundredWeightUK = new ConvertibleUnit()
    {
        Name = "hundred weight (UK)",
        Symbol = "cwt (UK)",
        CommonCode = "CWI",
        ConversionGroup = "kilogram",
        ConversionFactor = 50.80235m,
    };
    /// <summary>
    /// A unit of accumulated energy of a thousand watts over a period of one hour.
    /// </summary>
    public static IUnit KilowattHourPerHour = new Unit()
    {
        Name = "kilowatt hour per hour",
        Symbol = "kW·h/h",
        CommonCode = "D03",
    };
    /// <summary>
    /// A unit of weight equal to about 1/2 ounce or 15 grams.
    /// </summary>
    public static IUnit LotUnitOfWeight = new Unit()
    {
        Name = "lot [unit of weight]",
        Symbol = null,
        CommonCode = "D04",
    };
    public static IConvertibleUnit ReciprocalSecondPerSteradian = new ConvertibleUnit()
    {
        Name = "reciprocal second per steradian",
        Symbol = "s⁻¹/sr",
        CommonCode = "D1",
        ConversionGroup = "1 / second / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SiemensPerMetre = new ConvertibleUnit()
    {
        Name = "siemens per metre",
        Symbol = "S/m",
        CommonCode = "D10",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information equal to 2²⁰ (1048576) bits (binary digits).
    /// </summary>
    public static IUnit Mebibit = new Unit()
    {
        Name = "mebibit",
        Symbol = "Mibit",
        CommonCode = "D11",
    };
    public static IConvertibleUnit SiemensSquareMetrePerMole = new ConvertibleUnit()
    {
        Name = "siemens square metre per mole",
        Symbol = "S·m²/mol",
        CommonCode = "D12",
        ConversionGroup = "meter ** 2 * siemens / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Sievert = new ConvertibleUnit()
    {
        Name = "sievert",
        Symbol = "Sv",
        CommonCode = "D13",
        ConversionGroup = "meter ** 2 / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of subjective sound loudness. One sone is the loudness of a pure tone of frequency one kilohertz and strength 40 decibels.
    /// </summary>
    public static IUnit Sone = new Unit()
    {
        Name = "sone",
        Symbol = null,
        CommonCode = "D15",
    };
    public static IConvertibleUnit SquareCentimetrePerErg = new ConvertibleUnit()
    {
        Name = "square centimetre per erg",
        Symbol = "cm²/erg",
        CommonCode = "D16",
        ConversionGroup = "meter ** 2 / joule",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit SquareCentimetrePerSteradianErg = new ConvertibleUnit()
    {
        Name = "square centimetre per steradian erg",
        Symbol = "cm²/(sr·erg)",
        CommonCode = "D17",
        ConversionGroup = "meter ** 2 / joule / steradian",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MetreKelvin = new ConvertibleUnit()
    {
        Name = "metre kelvin",
        Symbol = "m·K",
        CommonCode = "D18",
        ConversionGroup = "kelvin * meter",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit SquareMetreKelvinPerWatt = new ConvertibleUnit()
    {
        Name = "square metre kelvin per watt",
        Symbol = "m²·K/W",
        CommonCode = "D19",
        ConversionGroup = "kelvin * meter ** 2 / watt",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ReciprocalSecondPerSteradianMetreSquared = new ConvertibleUnit()
    {
        Name = "reciprocal second per steradian metre squared",
        Symbol = "s⁻¹/(sr·m²)",
        CommonCode = "D2",
        ConversionGroup = "1 / meter ** 2 / second / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerJoule = new ConvertibleUnit()
    {
        Name = "square metre per joule",
        Symbol = "m²/J",
        CommonCode = "D20",
        ConversionGroup = "meter ** 2 / joule",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "square metre per kilogram",
        Symbol = "m²/kg",
        CommonCode = "D21",
        ConversionGroup = "meter ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerMole = new ConvertibleUnit()
    {
        Name = "square metre per mole",
        Symbol = "m²/mol",
        CommonCode = "D22",
        ConversionGroup = "meter ** 2 / mole",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of grams of amino acid prescribed for parenteral/enteral therapy.
    /// </summary>
    public static IUnit PenGramProtein = new Unit()
    {
        Name = "pen gram (protein)",
        Symbol = null,
        CommonCode = "D23",
    };
    public static IConvertibleUnit SquareMetrePerSteradian = new ConvertibleUnit()
    {
        Name = "square metre per steradian",
        Symbol = "m²/sr",
        CommonCode = "D24",
        ConversionGroup = "meter ** 2 / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerSteradianJoule = new ConvertibleUnit()
    {
        Name = "square metre per steradian joule",
        Symbol = "m²/(sr·J)",
        CommonCode = "D25",
        ConversionGroup = "meter ** 2 / joule / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerVoltSecond = new ConvertibleUnit()
    {
        Name = "square metre per volt second",
        Symbol = "m²/(V·s)",
        CommonCode = "D26",
        ConversionGroup = "meter ** 2 / second / volt",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Steradian = new ConvertibleUnit()
    {
        Name = "steradian",
        Symbol = "sr",
        CommonCode = "D27",
        ConversionGroup = "steradian",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Terahertz = new ConvertibleUnit()
    {
        Name = "terahertz",
        Symbol = "THz",
        CommonCode = "D29",
        ConversionGroup = "hertz",
        ConversionFactor = 1000000000000m,
    };
    public static IConvertibleUnit Terajoule = new ConvertibleUnit()
    {
        Name = "terajoule",
        Symbol = "TJ",
        CommonCode = "D30",
        ConversionGroup = "joule",
        ConversionFactor = 1000000000000m,
    };
    public static IConvertibleUnit Terawatt = new ConvertibleUnit()
    {
        Name = "terawatt",
        Symbol = "TW",
        CommonCode = "D31",
        ConversionGroup = "watt",
        ConversionFactor = 1000000000000m,
    };
    public static IConvertibleUnit TerawattHour = new ConvertibleUnit()
    {
        Name = "terawatt hour",
        Symbol = "TW·h",
        CommonCode = "D32",
        ConversionGroup = "joule",
        ConversionFactor = 3600000000000000.0m,
    };
    public static IConvertibleUnit Tesla = new ConvertibleUnit()
    {
        Name = "tesla",
        Symbol = "T",
        CommonCode = "D33",
        ConversionGroup = "tesla",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of yarn density. One decitex equals a mass of 1 gram per 1 kilometre of length.
    /// </summary>
    public static IConvertibleUnit Tex = new ConvertibleUnit()
    {
        Name = "tex",
        Symbol = "tex (g/km)",
        CommonCode = "D34",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of information equal to 10⁶ (1000000) bits (binary digits).
    /// </summary>
    public static IUnit Megabit = new Unit()
    {
        Name = "megabit",
        Symbol = "Mbit",
        CommonCode = "D36",
    };
    public static IConvertibleUnit TonnePerCubicMetre = new ConvertibleUnit()
    {
        Name = "tonne per cubic metre",
        Symbol = "t/m³",
        CommonCode = "D41",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit TropicalYear = new ConvertibleUnit()
    {
        Name = "tropical year",
        Symbol = "y (tropical)",
        CommonCode = "D42",
        ConversionGroup = "second",
        ConversionFactor = 31556924.999999996m,
    };
    public static IConvertibleUnit UnifiedAtomicMassUnit = new ConvertibleUnit()
    {
        Name = "unified atomic mass unit",
        Symbol = "u",
        CommonCode = "D43",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.0000000000000000000000000017m,
    };
    /// <summary>
    /// The name of the unit is an acronym for volt-ampere-reactive.
    /// </summary>
    public static IConvertibleUnit Var = new ConvertibleUnit()
    {
        Name = "var",
        Symbol = "var",
        CommonCode = "D44",
        ConversionGroup = "ampere * volt",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit VoltSquaredPerKelvinSquared = new ConvertibleUnit()
    {
        Name = "volt squared per kelvin squared",
        Symbol = "V²/K²",
        CommonCode = "D45",
        ConversionGroup = "volt ** 2 / kelvin ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit VoltAmpere = new ConvertibleUnit()
    {
        Name = "volt  ampere",
        Symbol = "V·A",
        CommonCode = "D46",
        ConversionGroup = "watt",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit VoltPerCentimetre = new ConvertibleUnit()
    {
        Name = "volt per centimetre",
        Symbol = "V/cm",
        CommonCode = "D47",
        ConversionGroup = "volt / meter",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit VoltPerKelvin = new ConvertibleUnit()
    {
        Name = "volt per kelvin",
        Symbol = "V/K",
        CommonCode = "D48",
        ConversionGroup = "volt / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MillivoltPerKelvin = new ConvertibleUnit()
    {
        Name = "millivolt per kelvin",
        Symbol = "mV/K",
        CommonCode = "D49",
        ConversionGroup = "volt / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit KilogramPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "kilogram per square centimetre",
        Symbol = "kg/cm²",
        CommonCode = "D5",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    public static IConvertibleUnit VoltPerMetre = new ConvertibleUnit()
    {
        Name = "volt per metre",
        Symbol = "V/m",
        CommonCode = "D50",
        ConversionGroup = "volt / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit VoltPerMillimetre = new ConvertibleUnit()
    {
        Name = "volt per millimetre",
        Symbol = "V/mm",
        CommonCode = "D51",
        ConversionGroup = "volt / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit WattPerKelvin = new ConvertibleUnit()
    {
        Name = "watt per kelvin",
        Symbol = "W/K",
        CommonCode = "D52",
        ConversionGroup = "watt / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerMetreKelvin = new ConvertibleUnit()
    {
        Name = "watt per metre kelvin",
        Symbol = "W/(m·K)",
        CommonCode = "D53",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerSquareMetre = new ConvertibleUnit()
    {
        Name = "watt per square metre",
        Symbol = "W/m²",
        CommonCode = "D54",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerSquareMetreKelvin = new ConvertibleUnit()
    {
        Name = "watt per square metre kelvin",
        Symbol = "W/(m²·K)",
        CommonCode = "D55",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerSquareMetreKelvinToTheFourthPower = new ConvertibleUnit()
    {
        Name = "watt per square metre kelvin to the fourth power",
        Symbol = "W/(m²·K⁴)",
        CommonCode = "D56",
        ConversionGroup = "watt / kelvin ** 4 / meter ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerSteradian = new ConvertibleUnit()
    {
        Name = "watt per steradian",
        Symbol = "W/sr",
        CommonCode = "D57",
        ConversionGroup = "watt / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerSteradianSquareMetre = new ConvertibleUnit()
    {
        Name = "watt per steradian square metre",
        Symbol = "W/(sr·m²)",
        CommonCode = "D58",
        ConversionGroup = "watt / meter ** 2 / steradian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WeberPerMetre = new ConvertibleUnit()
    {
        Name = "weber per metre",
        Symbol = "Wb/m",
        CommonCode = "D59",
        ConversionGroup = "weber / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit RoentgenPerSecond = new ConvertibleUnit()
    {
        Name = "roentgen per second",
        Symbol = "R/s",
        CommonCode = "D6",
        ConversionGroup = "coulomb / kilogram / second",
        ConversionFactor = 0.00025800000000000004m,
    };
    public static IConvertibleUnit WeberPerMillimetre = new ConvertibleUnit()
    {
        Name = "weber per millimetre",
        Symbol = "Wb/mm",
        CommonCode = "D60",
        ConversionGroup = "weber / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MinuteUnitOfAngle = new ConvertibleUnit()
    {
        Name = "minute [unit of angle]",
        Symbol = "'",
        CommonCode = "D61",
        ConversionGroup = "radian",
        ConversionFactor = 0.0002908882m,
    };
    public static IConvertibleUnit SecondUnitOfAngle = new ConvertibleUnit()
    {
        Name = "second [unit of angle]",
        Symbol = "\"",
        CommonCode = "D62",
        ConversionGroup = "radian",
        ConversionFactor = 0.000004848137m,
    };
    /// <summary>
    /// A unit of count defining the number of books (book: set of items bound together or written document of a material whole).
    /// </summary>
    public static IUnit Book = new Unit()
    {
        Name = "book",
        Symbol = null,
        CommonCode = "D63",
    };
    /// <summary>
    /// A unit of count defining the number of rounds (round: A circular or cylindrical object).
    /// </summary>
    public static IUnit Round = new Unit()
    {
        Name = "round",
        Symbol = null,
        CommonCode = "D65",
    };
    /// <summary>
    /// A unit of count defining the number of words.
    /// </summary>
    public static IUnit NumberOfWords = new Unit()
    {
        Name = "number of words",
        Symbol = null,
        CommonCode = "D68",
    };
    public static IConvertibleUnit InchToTheFourthPower = new ConvertibleUnit()
    {
        Name = "inch to the fourth power",
        Symbol = "in⁴",
        CommonCode = "D69",
        ConversionGroup = "meter ** 4",
        ConversionFactor = 0.0000004162314m,
    };
    public static IConvertibleUnit JouleSquareMetre = new ConvertibleUnit()
    {
        Name = "joule square metre",
        Symbol = "J·m²",
        CommonCode = "D73",
        ConversionGroup = "joule * meter ** 2",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KilogramPerMole = new ConvertibleUnit()
    {
        Name = "kilogram per mole",
        Symbol = "kg/mol",
        CommonCode = "D74",
        ConversionGroup = "kilogram / mole",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Megacoulomb = new ConvertibleUnit()
    {
        Name = "megacoulomb",
        Symbol = "MC",
        CommonCode = "D77",
        ConversionGroup = "coulomb",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of accumulated energy equal to one million joules per second.
    /// </summary>
    public static IUnit MegajoulePerSecond = new Unit()
    {
        Name = "megajoule per second",
        Symbol = "MJ/s",
        CommonCode = "D78",
    };
    public static IConvertibleUnit Microwatt = new ConvertibleUnit()
    {
        Name = "microwatt",
        Symbol = "µW",
        CommonCode = "D80",
        ConversionGroup = "watt",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microtesla = new ConvertibleUnit()
    {
        Name = "microtesla",
        Symbol = "µT",
        CommonCode = "D81",
        ConversionGroup = "tesla",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Microvolt = new ConvertibleUnit()
    {
        Name = "microvolt",
        Symbol = "µV",
        CommonCode = "D82",
        ConversionGroup = "volt",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillinewtonMetre = new ConvertibleUnit()
    {
        Name = "millinewton metre",
        Symbol = "mN·m",
        CommonCode = "D83",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MicrowattPerSquareMetre = new ConvertibleUnit()
    {
        Name = "microwatt per square metre",
        Symbol = "µW/m²",
        CommonCode = "D85",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Millicoulomb = new ConvertibleUnit()
    {
        Name = "millicoulomb",
        Symbol = "mC",
        CommonCode = "D86",
        ConversionGroup = "coulomb",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillimolePerKilogram = new ConvertibleUnit()
    {
        Name = "millimole per kilogram",
        Symbol = "mmol/kg",
        CommonCode = "D87",
        ConversionGroup = "mole / kilogram",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillicoulombPerCubicMetre = new ConvertibleUnit()
    {
        Name = "millicoulomb per cubic metre",
        Symbol = "mC/m³",
        CommonCode = "D88",
        ConversionGroup = "coulomb / meter ** 3",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillicoulombPerSquareMetre = new ConvertibleUnit()
    {
        Name = "millicoulomb per square metre",
        Symbol = "mC/m²",
        CommonCode = "D89",
        ConversionGroup = "coulomb / meter ** 2",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Rem = new ConvertibleUnit()
    {
        Name = "rem",
        Symbol = "rem",
        CommonCode = "D91",
        ConversionGroup = "sievert",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit SecondPerCubicMetre = new ConvertibleUnit()
    {
        Name = "second per cubic metre",
        Symbol = "s/m³",
        CommonCode = "D93",
        ConversionGroup = "second / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SecondPerCubicMetreRadian = new ConvertibleUnit()
    {
        Name = "second per cubic metre radian",
        Symbol = "s/(rad·m³)",
        CommonCode = "D94",
        ConversionGroup = "second / meter ** 3 / radian",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit JoulePerGram = new ConvertibleUnit()
    {
        Name = "joule per gram",
        Symbol = "J/g",
        CommonCode = "D95",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Decare = new ConvertibleUnit()
    {
        Name = "decare",
        Symbol = "daa",
        CommonCode = "DAA",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of time defining the number of days in multiples of 10.
    /// </summary>
    public static IUnit TenDay = new Unit()
    {
        Name = "ten day",
        Symbol = null,
        CommonCode = "DAD",
    };
    public static IConvertibleUnit Day = new ConvertibleUnit()
    {
        Name = "day",
        Symbol = "d",
        CommonCode = "DAY",
        ConversionGroup = "second",
        ConversionFactor = 86400m,
    };
    /// <summary>
    /// A unit of mass defining the number of pounds of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit DryPound = new Unit()
    {
        Name = "dry pound",
        Symbol = null,
        CommonCode = "DB",
    };
    public static IConvertibleUnit DegreeUnitOfAngle = new ConvertibleUnit()
    {
        Name = "degree [unit of angle]",
        Symbol = "°",
        CommonCode = "DD",
        ConversionGroup = "radian",
        ConversionFactor = 0.01745329m,
    };
    /// <summary>
    /// A unit of count defining the number of decades (decade: quantity equal to 10 or time equal to 10 years).
    /// </summary>
    public static IUnit Decade = new Unit()
    {
        Name = "decade",
        Symbol = null,
        CommonCode = "DEC",
    };
    public static IConvertibleUnit Decigram = new ConvertibleUnit()
    {
        Name = "decigram",
        Symbol = "dg",
        CommonCode = "DG",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit Decagram = new ConvertibleUnit()
    {
        Name = "decagram",
        Symbol = "dag",
        CommonCode = "DJ",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit Decilitre = new ConvertibleUnit()
    {
        Name = "decilitre",
        Symbol = "dl",
        CommonCode = "DLT",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit CubicDecametre = new ConvertibleUnit()
    {
        Name = "cubic decametre",
        Symbol = "dam³",
        CommonCode = "DMA",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit SquareDecimetre = new ConvertibleUnit()
    {
        Name = "square decimetre",
        Symbol = "dm²",
        CommonCode = "DMK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of volume defining the number of kilolitres of a product at a temperature of 15 degrees Celsius, especially in relation to hydrocarbon oils.
    /// </summary>
    public static IUnit StandardKilolitre = new Unit()
    {
        Name = "standard kilolitre",
        Symbol = null,
        CommonCode = "DMO",
    };
    public static IConvertibleUnit CubicDecimetre = new ConvertibleUnit()
    {
        Name = "cubic decimetre",
        Symbol = "dm³",
        CommonCode = "DMQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Decimetre = new ConvertibleUnit()
    {
        Name = "decimetre",
        Symbol = "dm",
        CommonCode = "DMT",
        ConversionGroup = "meter",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit DecinewtonMetre = new ConvertibleUnit()
    {
        Name = "decinewton metre",
        Symbol = "dN·m",
        CommonCode = "DN",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.1m,
    };
    /// <summary>
    /// A unit of count defining the number of pieces in multiples of 12 (piece: a single item, article or exemplar).
    /// </summary>
    public static IUnit DozenPiece = new Unit()
    {
        Name = "dozen piece",
        Symbol = null,
        CommonCode = "DPC",
    };
    /// <summary>
    /// A unit of count defining the number of pairs in multiples of 12 (pair: item described by two's).
    /// </summary>
    public static IUnit DozenPair = new Unit()
    {
        Name = "dozen pair",
        Symbol = null,
        CommonCode = "DPR",
    };
    /// <summary>
    /// A unit of mass defining the volume of sea water a ship displaces, expressed as the number of tons.
    /// </summary>
    public static IUnit DisplacementTonnage = new Unit()
    {
        Name = "displacement tonnage",
        Symbol = null,
        CommonCode = "DPT",
    };
    /// <summary>
    /// Synonym: drachm (UK), troy dram
    /// </summary>
    public static IConvertibleUnit DramUS = new ConvertibleUnit()
    {
        Name = "dram (US)",
        Symbol = null,
        CommonCode = "DRA",
        ConversionGroup = "gram",
        ConversionFactor = 3.887935m,
    };
    /// <summary>
    /// Synonym: avoirdupois dram
    /// </summary>
    public static IConvertibleUnit DramUK = new ConvertibleUnit()
    {
        Name = "dram (UK)",
        Symbol = null,
        CommonCode = "DRI",
        ConversionGroup = "gram",
        ConversionFactor = 1.771745m,
    };
    /// <summary>
    /// A unit of count defining the number of rolls, expressed in twelve roll units.
    /// </summary>
    public static IUnit DozenRoll = new Unit()
    {
        Name = "dozen roll",
        Symbol = null,
        CommonCode = "DRL",
    };
    /// <summary>
    /// A unit of mass defining the number of tons of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit DryTon = new Unit()
    {
        Name = "dry ton",
        Symbol = null,
        CommonCode = "DT",
    };
    /// <summary>
    /// Synonym: centner, metric 100 kg; quintal, metric 100 kg
    /// </summary>
    public static IConvertibleUnit Decitonne = new ConvertibleUnit()
    {
        Name = "decitonne",
        Symbol = "dt or dtn",
        CommonCode = "DTN",
        ConversionGroup = "kilogram",
        ConversionFactor = 100m,
    };
    public static IConvertibleUnit Pennyweight = new ConvertibleUnit()
    {
        Name = "pennyweight",
        Symbol = null,
        CommonCode = "DWT",
        ConversionGroup = "gram",
        ConversionFactor = 1.555174m,
    };
    /// <summary>
    /// A unit of count defining the number of units in multiples of 12.
    /// </summary>
    public static IConvertibleUnit Dozen = new ConvertibleUnit()
    {
        Name = "dozen",
        Symbol = "DOZ",
        CommonCode = "DZN",
        ConversionGroup = "dimensionless",
        ConversionFactor = 12m,
    };
    /// <summary>
    /// A unit of count defining the number of packs in multiples of 12 (pack: standard packaging unit).
    /// </summary>
    public static IUnit DozenPack = new Unit()
    {
        Name = "dozen pack",
        Symbol = null,
        CommonCode = "DZP",
    };
    /// <summary>
    /// A measure of pressure expressed in newtons per square centimetre.
    /// </summary>
    public static IConvertibleUnit NewtonPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "newton per square centimetre",
        Symbol = "N/cm²",
        CommonCode = "E01",
        ConversionGroup = "pascal",
        ConversionFactor = 10000m,
    };
    /// <summary>
    /// A unit of accumulated energy of a million watts over a period of one hour.
    /// </summary>
    public static IUnit MegawattHourPerHour = new Unit()
    {
        Name = "megawatt hour per hour",
        Symbol = "MW·h/h",
        CommonCode = "E07",
    };
    /// <summary>
    /// A unit of energy expressed as the load change in million watts that will cause a frequency shift of one hertz.
    /// </summary>
    public static IUnit MegawattPerHertz = new Unit()
    {
        Name = "megawatt per hertz",
        Symbol = "MW/Hz",
        CommonCode = "E08",
    };
    /// <summary>
    /// A unit of power load delivered at the rate of one thousandth of an ampere over a period of one hour.
    /// </summary>
    public static IConvertibleUnit MilliampereHour = new ConvertibleUnit()
    {
        Name = "milliampere hour",
        Symbol = "mA·h",
        CommonCode = "E09",
        ConversionGroup = "coulomb",
        ConversionFactor = 3.6m,
    };
    /// <summary>
    /// A unit of measure used in meteorology and engineering to measure the demand for heating or cooling over a given period of days.
    /// </summary>
    public static IUnit DegreeDay = new Unit()
    {
        Name = "degree day",
        Symbol = "deg da",
        CommonCode = "E10",
    };
    /// <summary>
    /// A unit of count defining the number of cigarettes in units of 1000.
    /// </summary>
    public static IUnit Mille = new Unit()
    {
        Name = "mille",
        Symbol = null,
        CommonCode = "E12",
    };
    /// <summary>
    /// A unit of heat energy equal to one thousand calories.
    /// </summary>
    public static IConvertibleUnit KilocalorieInternationalTable = new ConvertibleUnit()
    {
        Name = "kilocalorie (international table)",
        Symbol = "kcalIT",
        CommonCode = "E14",
        ConversionGroup = "joule",
        ConversionFactor = 4186.8m,
    };
    /// <summary>
    /// A unit of energy equal to one thousand calories per hour.
    /// </summary>
    public static IConvertibleUnit KilocalorieThermochemicalPerHour = new ConvertibleUnit()
    {
        Name = "kilocalorie (thermochemical) per hour",
        Symbol = "kcalth/h",
        CommonCode = "E15",
        ConversionGroup = "watt",
        ConversionFactor = 1.16222m,
    };
    /// <summary>
    /// A unit of power equal to one million British thermal units per hour.
    /// </summary>
    public static IConvertibleUnit MillionBtuITPerHour = new ConvertibleUnit()
    {
        Name = "million Btu(IT) per hour",
        Symbol = "BtuIT/h",
        CommonCode = "E16",
        ConversionGroup = "watt",
        ConversionFactor = 293071.1m,
    };
    /// <summary>
    /// A unit of volume equal to one cubic foot passing a given point in a period of one second.
    /// </summary>
    public static IConvertibleUnit CubicFootPerSecond = new ConvertibleUnit()
    {
        Name = "cubic foot per second",
        Symbol = "ft³/s",
        CommonCode = "E17",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.028316849999999998m,
    };
    /// <summary>
    /// A unit of weight or mass equal to one tonne per hour.
    /// </summary>
    public static IConvertibleUnit TonnePerHour = new ConvertibleUnit()
    {
        Name = "tonne per hour",
        Symbol = "t/h",
        CommonCode = "E18",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.277778m,
    };
    /// <summary>
    /// A unit of area equal to 3.3 square metres.
    /// </summary>
    public static IConvertibleUnit Ping = new ConvertibleUnit()
    {
        Name = "ping",
        Symbol = null,
        CommonCode = "E19",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 3.305m,
    };
    /// <summary>
    /// A unit of information equal to 10⁶ (1000000) bits (binary digits) per second.
    /// </summary>
    public static IUnit MegabitPerSecond = new Unit()
    {
        Name = "megabit per second",
        Symbol = "Mbit/s",
        CommonCode = "E20",
    };
    /// <summary>
    /// A unit of count defining the number of shares (share: a total or portion of the parts into which a business entity’s capital is divided).
    /// </summary>
    public static IUnit Shares = new Unit()
    {
        Name = "shares",
        Symbol = null,
        CommonCode = "E21",
    };
    /// <summary>
    /// A unit of count defining the number of twenty-foot equivalent units (TEUs) as a measure of containerized cargo capacity.
    /// </summary>
    public static IUnit TEU = new Unit()
    {
        Name = "TEU",
        Symbol = null,
        CommonCode = "E22",
    };
    /// <summary>
    /// A unit of count defining the number of tyres (a solid or air-filled covering placed around a wheel rim to form a soft contact with the road, absorb shock and provide traction).
    /// </summary>
    public static IUnit TyreE23 = new Unit()
    {
        Name = "tyre",
        Symbol = null,
        CommonCode = "E23",
    };
    /// <summary>
    /// A ring made of rubber and/or metal surrounding a wheel.
    /// </summary>
    public static IUnit TyreXTE = new Unit()
    {
        Name = "Tyre",
        Symbol = null,
        CommonCode = "XTE",
    };
    /// <summary>
    /// A unit of count defining the number of active units within a substance.
    /// </summary>
    public static IUnit ActiveUnit = new Unit()
    {
        Name = "active unit",
        Symbol = null,
        CommonCode = "E25",
    };
    /// <summary>
    /// A unit of count defining the number of doses (dose: a definite quantity of a medicine or drug).
    /// </summary>
    public static IUnit Dose = new Unit()
    {
        Name = "dose",
        Symbol = null,
        CommonCode = "E27",
    };
    /// <summary>
    /// A unit of mass defining the number of tons of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit AirDryTon = new Unit()
    {
        Name = "air dry ton",
        Symbol = null,
        CommonCode = "E28",
    };
    /// <summary>
    /// A unit of count defining the number of strands (strand: long, thin, flexible, single thread, strip of fibre, constituent filament or multiples of the same, twisted together).
    /// </summary>
    public static IUnit Strand = new Unit()
    {
        Name = "strand",
        Symbol = null,
        CommonCode = "E30",
    };
    /// <summary>
    /// A unit of count defining the number of square metres per litre.
    /// </summary>
    public static IUnit SquareMetrePerLitre = new Unit()
    {
        Name = "square metre per litre",
        Symbol = "m²/l",
        CommonCode = "E31",
    };
    /// <summary>
    /// A unit of count defining the number of litres per hour.
    /// </summary>
    public static IConvertibleUnit LitrePerHour = new ConvertibleUnit()
    {
        Name = "litre per hour",
        Symbol = "l/h",
        CommonCode = "E32",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000277778m,
    };
    /// <summary>
    /// A unit of count defining the number of feet per thousand units.
    /// </summary>
    public static IConvertibleUnit FootPerThousand = new ConvertibleUnit()
    {
        Name = "foot per thousand",
        Symbol = null,
        CommonCode = "E33",
        ConversionGroup = "meter",
        ConversionFactor = 0.00030480000000000004m,
    };
    /// <summary>
    /// A unit of information equal to 10⁹ bytes.
    /// </summary>
    public static IUnit Gigabyte = new Unit()
    {
        Name = "gigabyte",
        Symbol = "Gbyte",
        CommonCode = "E34",
    };
    /// <summary>
    /// A unit of information equal to 10¹² bytes.
    /// </summary>
    public static IUnit Terabyte = new Unit()
    {
        Name = "terabyte",
        Symbol = "Tbyte",
        CommonCode = "E35",
    };
    /// <summary>
    /// A unit of information equal to 10¹⁵ bytes.
    /// </summary>
    public static IUnit Petabyte = new Unit()
    {
        Name = "petabyte",
        Symbol = "Pbyte",
        CommonCode = "E36",
    };
    /// <summary>
    /// A unit of count defining the number of pixels (pixel: picture element).
    /// </summary>
    public static IUnit Pixel = new Unit()
    {
        Name = "pixel",
        Symbol = null,
        CommonCode = "E37",
    };
    /// <summary>
    /// A unit of count equal to 10⁶ (1000000) pixels (picture elements).
    /// </summary>
    public static IUnit Megapixel = new Unit()
    {
        Name = "megapixel",
        Symbol = null,
        CommonCode = "E38",
    };
    /// <summary>
    /// A unit of information defining the number of dots per linear inch as a measure of the resolution or sharpness of a graphic image.
    /// </summary>
    public static IUnit DotsPerInch = new Unit()
    {
        Name = "dots per inch",
        Symbol = "dpi",
        CommonCode = "E39",
    };
    /// <summary>
    /// A unit of mass defining the total number of kilograms before deductions.
    /// </summary>
    public static IUnit GrossKilogram = new Unit()
    {
        Name = "gross kilogram",
        Symbol = null,
        CommonCode = "E4",
    };
    /// <summary>
    /// A unit of proportion equal to 10⁻⁵.
    /// </summary>
    public static IConvertibleUnit PartPerHundredThousand = new ConvertibleUnit()
    {
        Name = "part per hundred thousand",
        Symbol = "ppht",
        CommonCode = "E40",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.00001m,
    };
    /// <summary>
    /// A unit of pressure defining the number of kilograms force per square millimetre.
    /// </summary>
    public static IConvertibleUnit KilogramforcePerSquareMillimetre = new ConvertibleUnit()
    {
        Name = "kilogramforce per square millimetre",
        Symbol = "kgf/mm²",
        CommonCode = "E41",
        ConversionGroup = "pascal",
        ConversionFactor = 9806650.0m,
    };
    /// <summary>
    /// A unit of pressure defining the number of kilograms force per square centimetre.
    /// </summary>
    public static IConvertibleUnit KilogramforcePerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "kilogramforce per square centimetre",
        Symbol = "kgf/cm²",
        CommonCode = "E42",
        ConversionGroup = "pascal",
        ConversionFactor = 98066.5m,
    };
    /// <summary>
    /// A unit of energy defining the number of joules per square centimetre.
    /// </summary>
    public static IConvertibleUnit JoulePerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "joule per square centimetre",
        Symbol = "J/cm²",
        CommonCode = "E43",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    /// <summary>
    /// A unit of torsion defining the torque kilogram-force metre per square centimetre.
    /// </summary>
    public static IUnit KilogramforceMetrePerSquareCentimetre = new Unit()
    {
        Name = "kilogramforce metre per square centimetre",
        Symbol = "kgf·m/cm²",
        CommonCode = "E44",
    };
    public static IConvertibleUnit Milliohm = new ConvertibleUnit()
    {
        Name = "milliohm",
        Symbol = "mΩ",
        CommonCode = "E45",
        ConversionGroup = "ohm",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of energy consumption expressed as kilowatt hour per cubic metre.
    /// </summary>
    public static IConvertibleUnit KilowattHourPerCubicMetre = new ConvertibleUnit()
    {
        Name = "kilowatt hour per cubic metre",
        Symbol = "kW·h/m³",
        CommonCode = "E46",
        ConversionGroup = "joule / meter ** 3",
        ConversionFactor = 3600000.0m,
    };
    /// <summary>
    /// A unit of energy consumption expressed as kilowatt hour per kelvin.
    /// </summary>
    public static IConvertibleUnit KilowattHourPerKelvin = new ConvertibleUnit()
    {
        Name = "kilowatt hour per kelvin",
        Symbol = "kW·h/K",
        CommonCode = "E47",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 3600000.0m,
    };
    /// <summary>
    /// A unit of count defining the number of service units (service unit: defined period / property / facility / utility of supply).
    /// </summary>
    public static IUnit ServiceUnit = new Unit()
    {
        Name = "service unit",
        Symbol = null,
        CommonCode = "E48",
    };
    /// <summary>
    /// A unit of count defining the number of working days (working day: a day on which work is ordinarily performed).
    /// </summary>
    public static IUnit WorkingDay = new Unit()
    {
        Name = "working day",
        Symbol = null,
        CommonCode = "E49",
    };
    /// <summary>
    /// A unit of count defining the number of accounting units.
    /// </summary>
    public static IUnit AccountingUnit = new Unit()
    {
        Name = "accounting unit",
        Symbol = null,
        CommonCode = "E50",
    };
    /// <summary>
    /// A unit of count defining the number of jobs.
    /// </summary>
    public static IUnit Job = new Unit()
    {
        Name = "job",
        Symbol = null,
        CommonCode = "E51",
    };
    /// <summary>
    /// A unit of count defining the number feet per run.
    /// </summary>
    public static IUnit RunFoot = new Unit()
    {
        Name = "run foot",
        Symbol = null,
        CommonCode = "E52",
    };
    /// <summary>
    /// A unit of count defining the number of tests.
    /// </summary>
    public static IUnit Test = new Unit()
    {
        Name = "test",
        Symbol = null,
        CommonCode = "E53",
    };
    /// <summary>
    /// A unit of count defining the number of trips.
    /// </summary>
    public static IUnit Trip = new Unit()
    {
        Name = "trip",
        Symbol = null,
        CommonCode = "E54",
    };
    /// <summary>
    /// A unit of count defining the number of times an object is used.
    /// </summary>
    public static IUnit Use = new Unit()
    {
        Name = "use",
        Symbol = null,
        CommonCode = "E55",
    };
    /// <summary>
    /// A unit of count defining the number of wells.
    /// </summary>
    public static IUnit Well = new Unit()
    {
        Name = "well",
        Symbol = null,
        CommonCode = "E56",
    };
    /// <summary>
    /// A unit of count defining the number of zones.
    /// </summary>
    public static IUnit Zone = new Unit()
    {
        Name = "zone",
        Symbol = null,
        CommonCode = "E57",
    };
    /// <summary>
    /// A unit of information equal to 10¹⁸ bits (binary digits) per second.
    /// </summary>
    public static IUnit ExabitPerSecond = new Unit()
    {
        Name = "exabit per second",
        Symbol = "Ebit/s",
        CommonCode = "E58",
    };
    /// <summary>
    /// A unit of information equal to 2⁶⁰ bytes.
    /// </summary>
    public static IUnit Exbibyte = new Unit()
    {
        Name = "exbibyte",
        Symbol = "Eibyte",
        CommonCode = "E59",
    };
    /// <summary>
    /// A unit of information equal to 2⁵⁰ bytes.
    /// </summary>
    public static IUnit Pebibyte = new Unit()
    {
        Name = "pebibyte",
        Symbol = "Pibyte",
        CommonCode = "E60",
    };
    /// <summary>
    /// A unit of information equal to 2⁴⁰ bytes.
    /// </summary>
    public static IUnit Tebibyte = new Unit()
    {
        Name = "tebibyte",
        Symbol = "Tibyte",
        CommonCode = "E61",
    };
    /// <summary>
    /// A unit of information equal to 2³⁰ bytes.
    /// </summary>
    public static IUnit Gibibyte = new Unit()
    {
        Name = "gibibyte",
        Symbol = "Gibyte",
        CommonCode = "E62",
    };
    /// <summary>
    /// A unit of information equal to 2²⁰ bytes.
    /// </summary>
    public static IUnit Mebibyte = new Unit()
    {
        Name = "mebibyte",
        Symbol = "Mibyte",
        CommonCode = "E63",
    };
    /// <summary>
    /// A unit of information equal to 2¹⁰ bytes.
    /// </summary>
    public static IUnit Kibibyte = new Unit()
    {
        Name = "kibibyte",
        Symbol = "Kibyte",
        CommonCode = "E64",
    };
    /// <summary>
    /// A unit of information equal to 2⁶⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit ExbibitPerMetre = new Unit()
    {
        Name = "exbibit per metre",
        Symbol = "Eibit/m",
        CommonCode = "E65",
    };
    /// <summary>
    /// A unit of information equal to 2⁶⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit ExbibitPerSquareMetre = new Unit()
    {
        Name = "exbibit per square metre",
        Symbol = "Eibit/m²",
        CommonCode = "E66",
    };
    /// <summary>
    /// A unit of information equal to 2⁶⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit ExbibitPerCubicMetre = new Unit()
    {
        Name = "exbibit per cubic metre",
        Symbol = "Eibit/m³",
        CommonCode = "E67",
    };
    /// <summary>
    /// A unit of information equal to 10⁹ bytes per second.
    /// </summary>
    public static IUnit GigabytePerSecond = new Unit()
    {
        Name = "gigabyte per second",
        Symbol = "Gbyte/s",
        CommonCode = "E68",
    };
    /// <summary>
    /// A unit of information equal to 2³⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit GibibitPerMetre = new Unit()
    {
        Name = "gibibit per metre",
        Symbol = "Gibit/m",
        CommonCode = "E69",
    };
    /// <summary>
    /// A unit of information equal to 2³⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit GibibitPerSquareMetre = new Unit()
    {
        Name = "gibibit per square metre",
        Symbol = "Gibit/m²",
        CommonCode = "E70",
    };
    /// <summary>
    /// A unit of information equal to 2³⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit GibibitPerCubicMetre = new Unit()
    {
        Name = "gibibit per cubic metre",
        Symbol = "Gibit/m³",
        CommonCode = "E71",
    };
    /// <summary>
    /// A unit of information equal to 2¹⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit KibibitPerMetre = new Unit()
    {
        Name = "kibibit per metre",
        Symbol = "Kibit/m",
        CommonCode = "E72",
    };
    /// <summary>
    /// A unit of information equal to 2¹⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit KibibitPerSquareMetre = new Unit()
    {
        Name = "kibibit per square metre",
        Symbol = "Kibit/m²",
        CommonCode = "E73",
    };
    /// <summary>
    /// A unit of information equal to 2¹⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit KibibitPerCubicMetre = new Unit()
    {
        Name = "kibibit per cubic metre",
        Symbol = "Kibit/m³",
        CommonCode = "E74",
    };
    /// <summary>
    /// A unit of information equal to 2²⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit MebibitPerMetre = new Unit()
    {
        Name = "mebibit per metre",
        Symbol = "Mibit/m",
        CommonCode = "E75",
    };
    /// <summary>
    /// A unit of information equal to 2²⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit MebibitPerSquareMetre = new Unit()
    {
        Name = "mebibit per square metre",
        Symbol = "Mibit/m²",
        CommonCode = "E76",
    };
    /// <summary>
    /// A unit of information equal to 2²⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit MebibitPerCubicMetre = new Unit()
    {
        Name = "mebibit per cubic metre",
        Symbol = "Mibit/m³",
        CommonCode = "E77",
    };
    /// <summary>
    /// A unit of information equal to 10¹⁵ bits (binary digits).
    /// </summary>
    public static IUnit Petabit = new Unit()
    {
        Name = "petabit",
        Symbol = "Pbit",
        CommonCode = "E78",
    };
    /// <summary>
    /// A unit of information equal to 10¹⁵ bits (binary digits) per second.
    /// </summary>
    public static IUnit PetabitPerSecond = new Unit()
    {
        Name = "petabit per second",
        Symbol = "Pbit/s",
        CommonCode = "E79",
    };
    /// <summary>
    /// A unit of information equal to 2⁵⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit PebibitPerMetre = new Unit()
    {
        Name = "pebibit per metre",
        Symbol = "Pibit/m",
        CommonCode = "E80",
    };
    /// <summary>
    /// A unit of information equal to 2⁵⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit PebibitPerSquareMetre = new Unit()
    {
        Name = "pebibit per square metre",
        Symbol = "Pibit/m²",
        CommonCode = "E81",
    };
    /// <summary>
    /// A unit of information equal to 2⁵⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit PebibitPerCubicMetre = new Unit()
    {
        Name = "pebibit per cubic metre",
        Symbol = "Pibit/m³",
        CommonCode = "E82",
    };
    /// <summary>
    /// A unit of information equal to 10¹² bits (binary digits).
    /// </summary>
    public static IUnit Terabit = new Unit()
    {
        Name = "terabit",
        Symbol = "Tbit",
        CommonCode = "E83",
    };
    /// <summary>
    /// A unit of information equal to 10¹² bits (binary digits) per second.
    /// </summary>
    public static IUnit TerabitPerSecond = new Unit()
    {
        Name = "terabit per second",
        Symbol = "Tbit/s",
        CommonCode = "E84",
    };
    /// <summary>
    /// A unit of information equal to 2⁴⁰ bits (binary digits) per metre.
    /// </summary>
    public static IUnit TebibitPerMetre = new Unit()
    {
        Name = "tebibit per metre",
        Symbol = "Tibit/m",
        CommonCode = "E85",
    };
    /// <summary>
    /// A unit of information equal to 2⁴⁰ bits (binary digits) per cubic metre.
    /// </summary>
    public static IUnit TebibitPerCubicMetre = new Unit()
    {
        Name = "tebibit per cubic metre",
        Symbol = "Tibit/m³",
        CommonCode = "E86",
    };
    /// <summary>
    /// A unit of information equal to 2⁴⁰ bits (binary digits) per square metre.
    /// </summary>
    public static IUnit TebibitPerSquareMetre = new Unit()
    {
        Name = "tebibit per square metre",
        Symbol = "Tibit/m²",
        CommonCode = "E87",
    };
    /// <summary>
    /// A unit of information equal to 1 bit (binary digit) per metre.
    /// </summary>
    public static IUnit BitPerMetre = new Unit()
    {
        Name = "bit per metre",
        Symbol = "bit/m",
        CommonCode = "E88",
    };
    /// <summary>
    /// A unit of information equal to 1 bit (binary digit) per square metre.
    /// </summary>
    public static IUnit BitPerSquareMetre = new Unit()
    {
        Name = "bit per square metre",
        Symbol = "bit/m²",
        CommonCode = "E89",
    };
    public static IConvertibleUnit ReciprocalCentimetre = new ConvertibleUnit()
    {
        Name = "reciprocal centimetre",
        Symbol = "cm⁻¹",
        CommonCode = "E90",
        ConversionGroup = "1 / meter",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit ReciprocalDay = new ConvertibleUnit()
    {
        Name = "reciprocal day",
        Symbol = "d⁻¹",
        CommonCode = "E91",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    public static IConvertibleUnit CubicDecimetrePerHour = new ConvertibleUnit()
    {
        Name = "cubic decimetre per hour",
        Symbol = "dm³/h",
        CommonCode = "E92",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000277778m,
    };
    public static IConvertibleUnit KilogramPerHour = new ConvertibleUnit()
    {
        Name = "kilogram per hour",
        Symbol = "kg/h",
        CommonCode = "E93",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit KilomolePerSecond = new ConvertibleUnit()
    {
        Name = "kilomole per second",
        Symbol = "kmol/s",
        CommonCode = "E94",
        ConversionGroup = "mole / second",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MolePerSecond = new ConvertibleUnit()
    {
        Name = "mole per second",
        Symbol = "mol/s",
        CommonCode = "E95",
        ConversionGroup = "mole / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit DegreePerSecond = new ConvertibleUnit()
    {
        Name = "degree per second",
        Symbol = "°/s",
        CommonCode = "E96",
        ConversionGroup = "radian / second",
        ConversionFactor = 0.01745329m,
    };
    public static IConvertibleUnit MillimetrePerDegreeCelciusMetre = new ConvertibleUnit()
    {
        Name = "millimetre per degree Celcius metre",
        Symbol = "mm/(°C·m)",
        CommonCode = "E97",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit DegreeCelsiusPerKelvin = new ConvertibleUnit()
    {
        Name = "degree Celsius per kelvin",
        Symbol = "°C/K",
        CommonCode = "E98",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit HectopascalPerBar = new ConvertibleUnit()
    {
        Name = "hectopascal per bar",
        Symbol = "hPa/bar",
        CommonCode = "E99",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of count defining the number of items regarded as separate units.
    /// </summary>
    public static IUnit Each = new Unit()
    {
        Name = "each",
        Symbol = null,
        CommonCode = "EA",
    };
    /// <summary>
    /// A unit of count defining the number of electronic mail boxes.
    /// </summary>
    public static IUnit ElectronicMailBox = new Unit()
    {
        Name = "electronic mail box",
        Symbol = null,
        CommonCode = "EB",
    };
    /// <summary>
    /// A unit of volume defining the number of gallons of product produced from concentrate.
    /// </summary>
    public static IUnit EquivalentGallon = new Unit()
    {
        Name = "equivalent gallon",
        Symbol = null,
        CommonCode = "EQ",
    };
    /// <summary>
    /// A unit of information equal to 1 bit (binary digit) per cubic metre.
    /// </summary>
    public static IUnit BitPerCubicMetre = new Unit()
    {
        Name = "bit per cubic metre",
        Symbol = "bit/m³",
        CommonCode = "F01",
    };
    public static IConvertibleUnit KelvinPerKelvin = new ConvertibleUnit()
    {
        Name = "kelvin per kelvin",
        Symbol = "K/K",
        CommonCode = "F02",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KilopascalPerBar = new ConvertibleUnit()
    {
        Name = "kilopascal per bar",
        Symbol = "kPa/bar",
        CommonCode = "F03",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit MillibarPerBar = new ConvertibleUnit()
    {
        Name = "millibar per bar",
        Symbol = "mbar/bar",
        CommonCode = "F04",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MegapascalPerBar = new ConvertibleUnit()
    {
        Name = "megapascal per bar",
        Symbol = "MPa/bar",
        CommonCode = "F05",
        ConversionGroup = "dimensionless",
        ConversionFactor = 10m,
    };
    public static IConvertibleUnit PoisePerBar = new ConvertibleUnit()
    {
        Name = "poise per bar",
        Symbol = "P/bar",
        CommonCode = "F06",
        ConversionGroup = "second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit PascalPerBar = new ConvertibleUnit()
    {
        Name = "pascal per bar",
        Symbol = "Pa/bar",
        CommonCode = "F07",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MilliamperePerInch = new ConvertibleUnit()
    {
        Name = "milliampere per inch",
        Symbol = "mA/in",
        CommonCode = "F08",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 0.0393700787401575m,
    };
    public static IConvertibleUnit KelvinPerHour = new ConvertibleUnit()
    {
        Name = "kelvin per hour",
        Symbol = "K/h",
        CommonCode = "F10",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit KelvinPerMinute = new ConvertibleUnit()
    {
        Name = "kelvin per minute",
        Symbol = "K/min",
        CommonCode = "F11",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit KelvinPerSecond = new ConvertibleUnit()
    {
        Name = "kelvin per second",
        Symbol = "K/s",
        CommonCode = "F12",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of mass. One slug is the mass accelerated at 1 foot per second per second by a force of 1 pound.
    /// </summary>
    public static IConvertibleUnit Slug = new ConvertibleUnit()
    {
        Name = "slug",
        Symbol = "slug",
        CommonCode = "F13",
        ConversionGroup = "kilogram",
        ConversionFactor = 14.5939m,
    };
    public static IConvertibleUnit GramPerKelvin = new ConvertibleUnit()
    {
        Name = "gram per kelvin",
        Symbol = "g/K",
        CommonCode = "F14",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit KilogramPerKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per kelvin",
        Symbol = "kg/K",
        CommonCode = "F15",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MilligramPerKelvin = new ConvertibleUnit()
    {
        Name = "milligram per kelvin",
        Symbol = "mg/K",
        CommonCode = "F16",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit PoundforcePerFoot = new ConvertibleUnit()
    {
        Name = "poundforce per foot",
        Symbol = "lbf/ft",
        CommonCode = "F17",
        ConversionGroup = "kilogram / second ** 2",
        ConversionFactor = 14.5939m,
    };
    public static IConvertibleUnit KilogramSquareCentimetre = new ConvertibleUnit()
    {
        Name = "kilogram square centimetre",
        Symbol = "kg·cm²",
        CommonCode = "F18",
        ConversionGroup = "kilogram * meter ** 2",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit KilogramSquareMillimetre = new ConvertibleUnit()
    {
        Name = "kilogram square millimetre",
        Symbol = "kg·mm²",
        CommonCode = "F19",
        ConversionGroup = "kilogram * meter ** 2",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit PoundInchSquared = new ConvertibleUnit()
    {
        Name = "pound inch squared",
        Symbol = "lb·in²",
        CommonCode = "F20",
        ConversionGroup = "kilogram * meter ** 2",
        ConversionFactor = 0.00029263970000000005m,
    };
    public static IConvertibleUnit PoundforceInch = new ConvertibleUnit()
    {
        Name = "poundforce inch",
        Symbol = "lbf·in",
        CommonCode = "F21",
        ConversionGroup = "kilogram * meter ** 2 / second ** 2",
        ConversionFactor = 0.112985m,
    };
    public static IConvertibleUnit PoundforceFootPerAmpere = new ConvertibleUnit()
    {
        Name = "poundforce foot per ampere",
        Symbol = "lbf·ft/A",
        CommonCode = "F22",
        ConversionGroup = "kilogram * meter ** 2 / ampere / second ** 2",
        ConversionFactor = 1.35582m,
    };
    public static IConvertibleUnit GramPerCubicDecimetre = new ConvertibleUnit()
    {
        Name = "gram per cubic decimetre",
        Symbol = "g/dm³",
        CommonCode = "F23",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KilogramPerKilomol = new ConvertibleUnit()
    {
        Name = "kilogram per kilomol",
        Symbol = "kg/kmol",
        CommonCode = "F24",
        ConversionGroup = "kilogram / mole",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit GramPerHertz = new ConvertibleUnit()
    {
        Name = "gram per hertz",
        Symbol = "g/Hz",
        CommonCode = "F25",
        ConversionGroup = "kilogram * second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit GramPerDay = new ConvertibleUnit()
    {
        Name = "gram per day",
        Symbol = "g/d",
        CommonCode = "F26",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0000000115741m,
    };
    public static IConvertibleUnit GramPerHour = new ConvertibleUnit()
    {
        Name = "gram per hour",
        Symbol = "g/h",
        CommonCode = "F27",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000000277778m,
    };
    public static IConvertibleUnit GramPerMinute = new ConvertibleUnit()
    {
        Name = "gram per minute",
        Symbol = "g/min",
        CommonCode = "F28",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0000166667m,
    };
    public static IConvertibleUnit GramPerSecond = new ConvertibleUnit()
    {
        Name = "gram per second",
        Symbol = "g/s",
        CommonCode = "F29",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit KilogramPerDay = new ConvertibleUnit()
    {
        Name = "kilogram per day",
        Symbol = "kg/d",
        CommonCode = "F30",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    public static IConvertibleUnit KilogramPerMinute = new ConvertibleUnit()
    {
        Name = "kilogram per minute",
        Symbol = "kg/min",
        CommonCode = "F31",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit MilligramPerDay = new ConvertibleUnit()
    {
        Name = "milligram per day",
        Symbol = "mg/d",
        CommonCode = "F32",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit MilligramPerMinute = new ConvertibleUnit()
    {
        Name = "milligram per minute",
        Symbol = "mg/min",
        CommonCode = "F33",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0000000166667m,
    };
    public static IConvertibleUnit MilligramPerSecond = new ConvertibleUnit()
    {
        Name = "milligram per second",
        Symbol = "mg/s",
        CommonCode = "F34",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit GramPerDayKelvin = new ConvertibleUnit()
    {
        Name = "gram per day kelvin",
        Symbol = "g/(d·K)",
        CommonCode = "F35",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0000000115741m,
    };
    public static IConvertibleUnit GramPerHourKelvin = new ConvertibleUnit()
    {
        Name = "gram per hour kelvin",
        Symbol = "g/(h·K)",
        CommonCode = "F36",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.000000277778m,
    };
    public static IConvertibleUnit GramPerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "gram per minute kelvin",
        Symbol = "g/(min·K)",
        CommonCode = "F37",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0000166667m,
    };
    public static IConvertibleUnit GramPerSecondKelvin = new ConvertibleUnit()
    {
        Name = "gram per second kelvin",
        Symbol = "g/(s·K)",
        CommonCode = "F38",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit KilogramPerDayKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per day kelvin",
        Symbol = "kg/(d·K)",
        CommonCode = "F39",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    public static IConvertibleUnit KilogramPerHourKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per hour kelvin",
        Symbol = "kg/(h·K)",
        CommonCode = "F40",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit KilogramPerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per minute kelvin",
        Symbol = "kg/(min·K)",
        CommonCode = "F41",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit KilogramPerSecondKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per second kelvin",
        Symbol = "kg/(s·K)",
        CommonCode = "F42",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MilligramPerDayKelvin = new ConvertibleUnit()
    {
        Name = "milligram per day kelvin",
        Symbol = "mg/(d·K)",
        CommonCode = "F43",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit MilligramPerHourKelvin = new ConvertibleUnit()
    {
        Name = "milligram per hour kelvin",
        Symbol = "mg/(h·K)",
        CommonCode = "F44",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit MilligramPerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "milligram per minute kelvin",
        Symbol = "mg/(min·K)",
        CommonCode = "F45",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0000000166667m,
    };
    public static IConvertibleUnit MilligramPerSecondKelvin = new ConvertibleUnit()
    {
        Name = "milligram per second kelvin",
        Symbol = "mg/(s·K)",
        CommonCode = "F46",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit NewtonPerMillimetre = new ConvertibleUnit()
    {
        Name = "newton per millimetre",
        Symbol = "N/mm",
        CommonCode = "F47",
        ConversionGroup = "kilogram / second ** 2",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit PoundforcePerInch = new ConvertibleUnit()
    {
        Name = "poundforce per inch",
        Symbol = "lbf/in",
        CommonCode = "F48",
        ConversionGroup = "kilogram / second ** 2",
        ConversionFactor = 175.127m,
    };
    /// <summary>
    /// A unit of distance equal to 5.5 yards (16 feet 6 inches).
    /// </summary>
    public static IConvertibleUnit RodUnitOfDistance = new ConvertibleUnit()
    {
        Name = "rod [unit of distance]",
        Symbol = "rd (US)",
        CommonCode = "F49",
        ConversionGroup = "meter",
        ConversionFactor = 5.02921m,
    };
    public static IConvertibleUnit MicrometrePerKelvin = new ConvertibleUnit()
    {
        Name = "micrometre per kelvin",
        Symbol = "µm/K",
        CommonCode = "F50",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit CentimetrePerKelvin = new ConvertibleUnit()
    {
        Name = "centimetre per kelvin",
        Symbol = "cm/K",
        CommonCode = "F51",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit MetrePerKelvin = new ConvertibleUnit()
    {
        Name = "metre per kelvin",
        Symbol = "m/K",
        CommonCode = "F52",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MillimetrePerKelvin = new ConvertibleUnit()
    {
        Name = "millimetre per kelvin",
        Symbol = "mm/K",
        CommonCode = "F53",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MilliohmPerMetre = new ConvertibleUnit()
    {
        Name = "milliohm per metre",
        Symbol = "mΩ/m",
        CommonCode = "F54",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit OhmPerMileStatuteMile = new ConvertibleUnit()
    {
        Name = "ohm per mile (statute mile)",
        Symbol = "Ω/mi",
        CommonCode = "F55",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 0.000621371m,
    };
    public static IConvertibleUnit OhmPerKilometre = new ConvertibleUnit()
    {
        Name = "ohm per kilometre",
        Symbol = "Ω/km",
        CommonCode = "F56",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MilliamperePerPoundforcePerSquareInch = new ConvertibleUnit()
    {
        Name = "milliampere per poundforce per square inch",
        Symbol = "mA/(lbf/in²)",
        CommonCode = "F57",
        ConversionGroup = "ampere * meter * second ** 2 / kilogram",
        ConversionFactor = 0.000000145038m,
    };
    public static IConvertibleUnit ReciprocalBar = new ConvertibleUnit()
    {
        Name = "reciprocal bar",
        Symbol = "1/bar",
        CommonCode = "F58",
        ConversionGroup = "1 / bar",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MilliamperePerBar = new ConvertibleUnit()
    {
        Name = "milliampere per bar",
        Symbol = "mA/bar",
        CommonCode = "F59",
        ConversionGroup = "ampere * meter * second ** 2 / kilogram",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit DegreeCelsiusPerBar = new ConvertibleUnit()
    {
        Name = "degree Celsius per bar",
        Symbol = "°C/bar",
        CommonCode = "F60",
        ConversionGroup = "kelvin * meter * second ** 2 / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit KelvinPerBar = new ConvertibleUnit()
    {
        Name = "kelvin per bar",
        Symbol = "K/bar",
        CommonCode = "F61",
        ConversionGroup = "kelvin * meter * second ** 2 / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit GramPerDayBar = new ConvertibleUnit()
    {
        Name = "gram per day bar",
        Symbol = "g/(d·bar)",
        CommonCode = "F62",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.0000000000001157410000000000m,
    };
    public static IConvertibleUnit GramPerHourBar = new ConvertibleUnit()
    {
        Name = "gram per hour bar",
        Symbol = "g/(h·bar)",
        CommonCode = "F63",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000000000277778m,
    };
    public static IConvertibleUnit GramPerMinuteBar = new ConvertibleUnit()
    {
        Name = "gram per minute bar",
        Symbol = "g/(min·bar)",
        CommonCode = "F64",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.000000000166667m,
    };
    public static IConvertibleUnit GramPerSecondBar = new ConvertibleUnit()
    {
        Name = "gram per second bar",
        Symbol = "g/(s·bar)",
        CommonCode = "F65",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit KilogramPerDayBar = new ConvertibleUnit()
    {
        Name = "kilogram per day bar",
        Symbol = "kg/(d·bar)",
        CommonCode = "F66",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000000011574100000000001m,
    };
    public static IConvertibleUnit KilogramPerHourBar = new ConvertibleUnit()
    {
        Name = "kilogram per hour bar",
        Symbol = "kg/(h·bar)",
        CommonCode = "F67",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000000277778m,
    };
    public static IConvertibleUnit KilogramPerMinuteBar = new ConvertibleUnit()
    {
        Name = "kilogram per minute bar",
        Symbol = "kg/(min·bar)",
        CommonCode = "F68",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.000000166667m,
    };
    public static IConvertibleUnit KilogramPerSecondBar = new ConvertibleUnit()
    {
        Name = "kilogram per second bar",
        Symbol = "kg/(s·bar)",
        CommonCode = "F69",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MilligramPerDayBar = new ConvertibleUnit()
    {
        Name = "milligram per day bar",
        Symbol = "mg/(d·bar)",
        CommonCode = "F70",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.000000000000000115741m,
    };
    public static IConvertibleUnit MilligramPerHourBar = new ConvertibleUnit()
    {
        Name = "milligram per hour bar",
        Symbol = "mg/(h·bar)",
        CommonCode = "F71",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000000000000277778m,
    };
    public static IConvertibleUnit MilligramPerMinuteBar = new ConvertibleUnit()
    {
        Name = "milligram per minute bar",
        Symbol = "mg/(min·bar)",
        CommonCode = "F72",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.0000000000001666670000000000m,
    };
    public static IConvertibleUnit MilligramPerSecondBar = new ConvertibleUnit()
    {
        Name = "milligram per second bar",
        Symbol = "mg/(s·bar)",
        CommonCode = "F73",
        ConversionGroup = "meter * second",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit GramPerBar = new ConvertibleUnit()
    {
        Name = "gram per bar",
        Symbol = "g/bar",
        CommonCode = "F74",
        ConversionGroup = "meter * second ** 2",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit MilligramPerBar = new ConvertibleUnit()
    {
        Name = "milligram per bar",
        Symbol = "mg/bar",
        CommonCode = "F75",
        ConversionGroup = "meter * second ** 2",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit MilliamperePerMillimetre = new ConvertibleUnit()
    {
        Name = "milliampere per millimetre",
        Symbol = "mA/mm",
        CommonCode = "F76",
        ConversionGroup = "ampere / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit PascalSecondPerKelvin = new ConvertibleUnit()
    {
        Name = "pascal second per kelvin",
        Symbol = "Pa.s/K",
        CommonCode = "F77",
        ConversionGroup = "kilogram / kelvin / meter / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit InchOfWater = new ConvertibleUnit()
    {
        Name = "inch of water",
        Symbol = "inH₂O",
        CommonCode = "F78",
        ConversionGroup = "kilogram / meter / second ** 2",
        ConversionFactor = 249.08899999999997m,
    };
    public static IConvertibleUnit InchOfMercury = new ConvertibleUnit()
    {
        Name = "inch of mercury",
        Symbol = "inHg",
        CommonCode = "F79",
        ConversionGroup = "kilogram / meter / second ** 2",
        ConversionFactor = 3386.39m,
    };
    /// <summary>
    /// A unit of power defining the amount of power required to move a given volume of water against acceleration of gravity to a specified elevation (pressure head).
    /// </summary>
    public static IConvertibleUnit WaterHorsePower = new ConvertibleUnit()
    {
        Name = "water horse power",
        Symbol = null,
        CommonCode = "F80",
        ConversionGroup = "watt",
        ConversionFactor = 746.043m,
    };
    public static IConvertibleUnit BarPerKelvin = new ConvertibleUnit()
    {
        Name = "bar per kelvin",
        Symbol = "bar/K",
        CommonCode = "F81",
        ConversionGroup = "kilogram / kelvin / meter / second ** 2",
        ConversionFactor = 100000.0m,
    };
    public static IConvertibleUnit HectopascalPerKelvin = new ConvertibleUnit()
    {
        Name = "hectopascal per kelvin",
        Symbol = "hPa/K",
        CommonCode = "F82",
        ConversionGroup = "kilogram / kelvin / meter / second ** 2",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit KilopascalPerKelvin = new ConvertibleUnit()
    {
        Name = "kilopascal per kelvin",
        Symbol = "kPa/K",
        CommonCode = "F83",
        ConversionGroup = "kilogram / kelvin / meter / second ** 2",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MillibarPerKelvin = new ConvertibleUnit()
    {
        Name = "millibar per kelvin",
        Symbol = "mbar/K",
        CommonCode = "F84",
        ConversionGroup = "kilogram / kelvin / meter / second ** 2",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit MegapascalPerKelvin = new ConvertibleUnit()
    {
        Name = "megapascal per kelvin",
        Symbol = "MPa/K",
        CommonCode = "F85",
        ConversionGroup = "kilogram / kelvin / meter / second ** 2",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit PoisePerKelvin = new ConvertibleUnit()
    {
        Name = "poise per kelvin",
        Symbol = "P/K",
        CommonCode = "F86",
        ConversionGroup = "kilogram / kelvin / meter / second",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit VoltPerLitreMinute = new ConvertibleUnit()
    {
        Name = "volt per litre minute",
        Symbol = "V/(l·min)",
        CommonCode = "F87",
        ConversionGroup = "kilogram / ampere / meter / second ** 4",
        ConversionFactor = 16.666700000000002m,
    };
    public static IConvertibleUnit NewtonCentimetre = new ConvertibleUnit()
    {
        Name = "newton centimetre",
        Symbol = "N·cm",
        CommonCode = "F88",
        ConversionGroup = "kilogram * meter ** 2 / second ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit NewtonMetrePerDegree = new ConvertibleUnit()
    {
        Name = "newton metre per degree",
        Symbol = "Nm/°",
        CommonCode = "F89",
        ConversionGroup = "kilogram * meter ** 2 / radian / second ** 2",
        ConversionFactor = 57.295788m,
    };
    public static IConvertibleUnit NewtonMetrePerAmpere = new ConvertibleUnit()
    {
        Name = "newton metre per ampere",
        Symbol = "N·m/A",
        CommonCode = "F90",
        ConversionGroup = "kilogram * meter ** 2 / ampere / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit BarLitrePerSecond = new ConvertibleUnit()
    {
        Name = "bar litre per second",
        Symbol = "bar·l/s",
        CommonCode = "F91",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit BarCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "bar cubic metre per second",
        Symbol = "bar·m³/s",
        CommonCode = "F92",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 100000.0m,
    };
    public static IConvertibleUnit HectopascalLitrePerSecond = new ConvertibleUnit()
    {
        Name = "hectopascal litre per second",
        Symbol = "hPa·l/s",
        CommonCode = "F93",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit HectopascalCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "hectopascal cubic metre per second",
        Symbol = "hPa·m³/s",
        CommonCode = "F94",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit MillibarLitrePerSecond = new ConvertibleUnit()
    {
        Name = "millibar litre per second",
        Symbol = "mbar·l/s",
        CommonCode = "F95",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit MillibarCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "millibar cubic metre per second",
        Symbol = "mbar·m³/s",
        CommonCode = "F96",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit MegapascalLitrePerSecond = new ConvertibleUnit()
    {
        Name = "megapascal litre per second",
        Symbol = "MPa·l/s",
        CommonCode = "F97",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MegapascalCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "megapascal cubic metre per second",
        Symbol = "MPa·m³/s",
        CommonCode = "F98",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit PascalLitrePerSecond = new ConvertibleUnit()
    {
        Name = "pascal litre per second",
        Symbol = "Pa·l/s",
        CommonCode = "F99",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit",
        Symbol = "°F",
        CommonCode = "FAH",
        ConversionGroup = "kelvin",
        ConversionFactor = 0.5555555555555556m,
    };
    public static IConvertibleUnit Farad = new ConvertibleUnit()
    {
        Name = "farad",
        Symbol = "F",
        CommonCode = "FAR",
        ConversionGroup = "farad",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of length defining the number of metres of individual fibre.
    /// </summary>
    public static IUnit FibreMetre = new Unit()
    {
        Name = "fibre metre",
        Symbol = null,
        CommonCode = "FBM",
    };
    /// <summary>
    /// A unit of volume equal to one thousand cubic foot.
    /// </summary>
    public static IUnit ThousandCubicFoot = new Unit()
    {
        Name = "thousand cubic foot",
        Symbol = "kft³",
        CommonCode = "FC",
    };
    /// <summary>
    /// A unit of volume equal to one hundred cubic metres.
    /// </summary>
    public static IUnit HundredCubicMetre = new Unit()
    {
        Name = "hundred cubic metre",
        Symbol = null,
        CommonCode = "FF",
    };
    public static IConvertibleUnit Micromole = new ConvertibleUnit()
    {
        Name = "micromole",
        Symbol = "µmol",
        CommonCode = "FH",
        ConversionGroup = "mole",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of count defining the number of failures that can be expected over a specified time interval. Failure rates of semiconductor components are often specified as FIT (failures in time unit) where 1 FIT = 10⁻⁹ /h.
    /// </summary>
    public static IConvertibleUnit FailuresInTime = new ConvertibleUnit()
    {
        Name = "failures in time",
        Symbol = "FIT",
        CommonCode = "FIT",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.000000000000277778m,
    };
    /// <summary>
    /// A unit of mass defining the number of tons of a flaked substance (flake: a small flattish fragment).
    /// </summary>
    public static IUnit FlakeTon = new Unit()
    {
        Name = "flake ton",
        Symbol = null,
        CommonCode = "FL",
    };
    public static IConvertibleUnit Foot = new ConvertibleUnit()
    {
        Name = "foot",
        Symbol = "ft",
        CommonCode = "FOT",
        ConversionGroup = "meter",
        ConversionFactor = 0.3048m,
    };
    public static IConvertibleUnit PoundPerSquareFoot = new ConvertibleUnit()
    {
        Name = "pound per square foot",
        Symbol = "lb/ft²",
        CommonCode = "FP",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 4.882428m,
    };
    public static IConvertibleUnit FootPerMinute = new ConvertibleUnit()
    {
        Name = "foot per minute",
        Symbol = "ft/min",
        CommonCode = "FR",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.00508m,
    };
    public static IConvertibleUnit FootPerSecond = new ConvertibleUnit()
    {
        Name = "foot per second",
        Symbol = "ft/s",
        CommonCode = "FS",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.3048m,
    };
    public static IConvertibleUnit SquareFoot = new ConvertibleUnit()
    {
        Name = "square foot",
        Symbol = "ft²",
        CommonCode = "FTK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.09290304m,
    };
    public static IConvertibleUnit CubicFoot = new ConvertibleUnit()
    {
        Name = "cubic foot",
        Symbol = "ft³",
        CommonCode = "FTQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.028316849999999998m,
    };
    public static IConvertibleUnit PascalCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "pascal cubic metre per second",
        Symbol = "Pa·m³/s",
        CommonCode = "G01",
        ConversionGroup = "kilogram * meter ** 2 / second ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CentimetrePerBar = new ConvertibleUnit()
    {
        Name = "centimetre per bar",
        Symbol = "cm/bar",
        CommonCode = "G04",
        ConversionGroup = "meter ** 2 * second ** 2 / kilogram",
        ConversionFactor = 0.0000001m,
    };
    public static IConvertibleUnit MetrePerBar = new ConvertibleUnit()
    {
        Name = "metre per bar",
        Symbol = "m/bar",
        CommonCode = "G05",
        ConversionGroup = "meter ** 2 * second ** 2 / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MillimetrePerBar = new ConvertibleUnit()
    {
        Name = "millimetre per bar",
        Symbol = "mm/bar",
        CommonCode = "G06",
        ConversionGroup = "meter ** 2 * second ** 2 / kilogram",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit SquareInchPerSecond = new ConvertibleUnit()
    {
        Name = "square inch per second",
        Symbol = "in²/s",
        CommonCode = "G08",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.00064516m,
    };
    public static IConvertibleUnit SquareMetrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "square metre per second kelvin",
        Symbol = "m²/(s·K)",
        CommonCode = "G09",
        ConversionGroup = "meter ** 2 / kelvin / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit StokesPerKelvin = new ConvertibleUnit()
    {
        Name = "stokes per kelvin",
        Symbol = "St/K",
        CommonCode = "G10",
        ConversionGroup = "meter ** 2 / kelvin / second",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit GramPerCubicCentimetreBar = new ConvertibleUnit()
    {
        Name = "gram per cubic centimetre bar",
        Symbol = "g/(cm³·bar)",
        CommonCode = "G11",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit GramPerCubicDecimetreBar = new ConvertibleUnit()
    {
        Name = "gram per cubic decimetre bar",
        Symbol = "g/(dm³·bar)",
        CommonCode = "G12",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit GramPerLitreBar = new ConvertibleUnit()
    {
        Name = "gram per litre bar",
        Symbol = "g/(l·bar)",
        CommonCode = "G13",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit GramPerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "gram per cubic metre bar",
        Symbol = "g/(m³·bar)",
        CommonCode = "G14",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit GramPerMillilitreBar = new ConvertibleUnit()
    {
        Name = "gram per millilitre bar",
        Symbol = "g/(ml·bar)",
        CommonCode = "G15",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit KilogramPerCubicCentimetreBar = new ConvertibleUnit()
    {
        Name = "kilogram per cubic centimetre bar",
        Symbol = "kg/(cm³·bar)",
        CommonCode = "G16",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 10.0m,
    };
    public static IConvertibleUnit KilogramPerLitreBar = new ConvertibleUnit()
    {
        Name = "kilogram per litre bar",
        Symbol = "kg/(l·bar)",
        CommonCode = "G17",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit KilogramPerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "kilogram per cubic metre bar",
        Symbol = "kg/(m³·bar)",
        CommonCode = "G18",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit NewtonMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "newton metre per kilogram",
        Symbol = "N·m/kg",
        CommonCode = "G19",
        ConversionGroup = "meter ** 2 / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit USGallonPerMinute = new ConvertibleUnit()
    {
        Name = "US gallon per minute",
        Symbol = "gal (US) /min",
        CommonCode = "G2",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00006309020000000001m,
    };
    public static IConvertibleUnit PoundforceFootPerPound = new ConvertibleUnit()
    {
        Name = "poundforce foot per pound",
        Symbol = "lbf·ft/lb",
        CommonCode = "G20",
        ConversionGroup = "meter ** 2 / second ** 2",
        ConversionFactor = 2.98907m,
    };
    public static IConvertibleUnit CupUnitOfVolume = new ConvertibleUnit()
    {
        Name = "cup [unit of volume]",
        Symbol = "cup (US)",
        CommonCode = "G21",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.00023658820000000002m,
    };
    public static IConvertibleUnit Peck = new ConvertibleUnit()
    {
        Name = "peck",
        Symbol = "pk (US)",
        CommonCode = "G23",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.008809768m,
    };
    public static IConvertibleUnit TablespoonUS = new ConvertibleUnit()
    {
        Name = "tablespoon (US)",
        Symbol = "tablespoon (US)",
        CommonCode = "G24",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000014786760000000003m,
    };
    public static IConvertibleUnit TeaspoonUS = new ConvertibleUnit()
    {
        Name = "teaspoon (US)",
        Symbol = "teaspoon (US)",
        CommonCode = "G25",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000004928922m,
    };
    public static IConvertibleUnit Stere = new ConvertibleUnit()
    {
        Name = "stere",
        Symbol = "st",
        CommonCode = "G26",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit CubicCentimetrePerKelvin = new ConvertibleUnit()
    {
        Name = "cubic centimetre per kelvin",
        Symbol = "cm³/K",
        CommonCode = "G27",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit LitrePerKelvin = new ConvertibleUnit()
    {
        Name = "litre per kelvin",
        Symbol = "l/K",
        CommonCode = "G28",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CubicMetrePerKelvin = new ConvertibleUnit()
    {
        Name = "cubic metre per kelvin",
        Symbol = "m³/K",
        CommonCode = "G29",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit ImperialGallonPerMinute = new ConvertibleUnit()
    {
        Name = "Imperial gallon per minute",
        Symbol = "gal (UK) /min",
        CommonCode = "G3",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000757682m,
    };
    public static IConvertibleUnit MillilitrePerKelvin = new ConvertibleUnit()
    {
        Name = "millilitre per kelvin",
        Symbol = "ml/K",
        CommonCode = "G30",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit KilogramPerCubicCentimetre = new ConvertibleUnit()
    {
        Name = "kilogram per cubic centimetre",
        Symbol = "kg/cm³",
        CommonCode = "G31",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerCubicYard = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per cubic yard",
        Symbol = "oz/yd³",
        CommonCode = "G32",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.0370798m,
    };
    public static IConvertibleUnit GramPerCubicCentimetreKelvin = new ConvertibleUnit()
    {
        Name = "gram per cubic centimetre kelvin",
        Symbol = "g/(cm³·K)",
        CommonCode = "G33",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit GramPerCubicDecimetreKelvin = new ConvertibleUnit()
    {
        Name = "gram per cubic decimetre kelvin",
        Symbol = "g/(dm³·K)",
        CommonCode = "G34",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit GramPerLitreKelvin = new ConvertibleUnit()
    {
        Name = "gram per litre kelvin",
        Symbol = "g/(l·K)",
        CommonCode = "G35",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit GramPerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "gram per cubic metre kelvin",
        Symbol = "g/(m³·K)",
        CommonCode = "G36",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit GramPerMillilitreKelvin = new ConvertibleUnit()
    {
        Name = "gram per millilitre kelvin",
        Symbol = "g/(ml·K)",
        CommonCode = "G37",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilogramPerCubicCentimetreKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per cubic centimetre kelvin",
        Symbol = "kg/(cm³·K)",
        CommonCode = "G38",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit KilogramPerLitreKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per litre kelvin",
        Symbol = "kg/(l·K)",
        CommonCode = "G39",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilogramPerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per cubic metre kelvin",
        Symbol = "kg/(m³·K)",
        CommonCode = "G40",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerSecondBar = new ConvertibleUnit()
    {
        Name = "square metre per second bar",
        Symbol = "m²/(s·bar)",
        CommonCode = "G41",
        ConversionGroup = "meter ** 3 * second / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MicrosiemensPerCentimetre = new ConvertibleUnit()
    {
        Name = "microsiemens per centimetre",
        Symbol = "µS/cm",
        CommonCode = "G42",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit MicrosiemensPerMetre = new ConvertibleUnit()
    {
        Name = "microsiemens per metre",
        Symbol = "µS/m",
        CommonCode = "G43",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit NanosiemensPerCentimetre = new ConvertibleUnit()
    {
        Name = "nanosiemens per centimetre",
        Symbol = "nS/cm",
        CommonCode = "G44",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.0000001m,
    };
    public static IConvertibleUnit NanosiemensPerMetre = new ConvertibleUnit()
    {
        Name = "nanosiemens per metre",
        Symbol = "nS/m",
        CommonCode = "G45",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit StokesPerBar = new ConvertibleUnit()
    {
        Name = "stokes per bar",
        Symbol = "St/bar",
        CommonCode = "G46",
        ConversionGroup = "meter ** 3 * second / kilogram",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit CubicCentimetrePerDay = new ConvertibleUnit()
    {
        Name = "cubic centimetre per day",
        Symbol = "cm³/d",
        CommonCode = "G47",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit CubicCentimetrePerHour = new ConvertibleUnit()
    {
        Name = "cubic centimetre per hour",
        Symbol = "cm³/h",
        CommonCode = "G48",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit CubicCentimetrePerMinute = new ConvertibleUnit()
    {
        Name = "cubic centimetre per minute",
        Symbol = "cm³/min",
        CommonCode = "G49",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000166667m,
    };
    public static IConvertibleUnit GallonUSPerHour = new ConvertibleUnit()
    {
        Name = "gallon (US) per hour",
        Symbol = "gal/h",
        CommonCode = "G50",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000010515m,
    };
    public static IConvertibleUnit LitrePerSecond = new ConvertibleUnit()
    {
        Name = "litre per second",
        Symbol = "l/s",
        CommonCode = "G51",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CubicMetrePerDay = new ConvertibleUnit()
    {
        Name = "cubic metre per day",
        Symbol = "m³/d",
        CommonCode = "G52",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    public static IConvertibleUnit CubicMetrePerMinute = new ConvertibleUnit()
    {
        Name = "cubic metre per minute",
        Symbol = "m³/min",
        CommonCode = "G53",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit MillilitrePerDay = new ConvertibleUnit()
    {
        Name = "millilitre per day",
        Symbol = "ml/d",
        CommonCode = "G54",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit MillilitrePerHour = new ConvertibleUnit()
    {
        Name = "millilitre per hour",
        Symbol = "ml/h",
        CommonCode = "G55",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit CubicInchPerHour = new ConvertibleUnit()
    {
        Name = "cubic inch per hour",
        Symbol = "in³/h",
        CommonCode = "G56",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000045519600000000005m,
    };
    public static IConvertibleUnit CubicInchPerMinute = new ConvertibleUnit()
    {
        Name = "cubic inch per minute",
        Symbol = "in³/min",
        CommonCode = "G57",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000273118m,
    };
    public static IConvertibleUnit CubicInchPerSecond = new ConvertibleUnit()
    {
        Name = "cubic inch per second",
        Symbol = "in³/s",
        CommonCode = "G58",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000163871m,
    };
    public static IConvertibleUnit MilliamperePerLitreMinute = new ConvertibleUnit()
    {
        Name = "milliampere per litre minute",
        Symbol = "mA/(l·min)",
        CommonCode = "G59",
        ConversionGroup = "ampere / meter ** 3 / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit VoltPerBar = new ConvertibleUnit()
    {
        Name = "volt per bar",
        Symbol = "V/bar",
        CommonCode = "G60",
        ConversionGroup = "meter ** 3 / ampere / second",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit CubicCentimetrePerDayKelvin = new ConvertibleUnit()
    {
        Name = "cubic centimetre per day kelvin",
        Symbol = "cm³/(d·K)",
        CommonCode = "G61",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit CubicCentimetrePerHourKelvin = new ConvertibleUnit()
    {
        Name = "cubic centimetre per hour kelvin",
        Symbol = "cm³/(h·K)",
        CommonCode = "G62",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit CubicCentimetrePerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "cubic centimetre per minute kelvin",
        Symbol = "cm³/(min·K)",
        CommonCode = "G63",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000000166667m,
    };
    public static IConvertibleUnit CubicCentimetrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "cubic centimetre per second kelvin",
        Symbol = "cm³/(s·K)",
        CommonCode = "G64",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit LitrePerDayKelvin = new ConvertibleUnit()
    {
        Name = "litre per day kelvin",
        Symbol = "l/(d·K)",
        CommonCode = "G65",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000000115741m,
    };
    public static IConvertibleUnit LitrePerHourKelvin = new ConvertibleUnit()
    {
        Name = "litre per hour kelvin",
        Symbol = "l/(h·K)",
        CommonCode = "G66",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000000277778m,
    };
    public static IConvertibleUnit LitrePerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "litre per minute kelvin",
        Symbol = "l/(min·K)",
        CommonCode = "G67",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000166667m,
    };
    public static IConvertibleUnit LitrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "litre per second kelvin",
        Symbol = "l/(s·K)",
        CommonCode = "G68",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CubicMetrePerDayKelvin = new ConvertibleUnit()
    {
        Name = "cubic metre per day kelvin",
        Symbol = "m³/(d·K)",
        CommonCode = "G69",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    public static IConvertibleUnit CubicMetrePerHourKelvin = new ConvertibleUnit()
    {
        Name = "cubic metre per hour kelvin",
        Symbol = "m³/(h·K)",
        CommonCode = "G70",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit CubicMetrePerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "cubic metre per minute kelvin",
        Symbol = "m³/(min·K)",
        CommonCode = "G71",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit CubicMetrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "cubic metre per second kelvin",
        Symbol = "m³/(s·K)",
        CommonCode = "G72",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MillilitrePerDayKelvin = new ConvertibleUnit()
    {
        Name = "millilitre per day kelvin",
        Symbol = "ml/(d·K)",
        CommonCode = "G73",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000000000115741m,
    };
    public static IConvertibleUnit MillilitrePerHourKelvin = new ConvertibleUnit()
    {
        Name = "millilitre per hour kelvin",
        Symbol = "ml/(h·K)",
        CommonCode = "G74",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000000000277778m,
    };
    public static IConvertibleUnit MillilitrePerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "millilitre per minute kelvin",
        Symbol = "ml/(min·K)",
        CommonCode = "G75",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.0000000166667m,
    };
    public static IConvertibleUnit MillilitrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "millilitre per second kelvin",
        Symbol = "ml/(s·K)",
        CommonCode = "G76",
        ConversionGroup = "meter ** 3 / kelvin / second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillimetreToTheFourthPower = new ConvertibleUnit()
    {
        Name = "millimetre to the fourth power",
        Symbol = "mm⁴",
        CommonCode = "G77",
        ConversionGroup = "meter ** 4",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit CubicCentimetrePerDayBar = new ConvertibleUnit()
    {
        Name = "cubic centimetre per day bar",
        Symbol = "cm³/(d·bar)",
        CommonCode = "G78",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.000000000000000115741m,
    };
    public static IConvertibleUnit CubicCentimetrePerHourBar = new ConvertibleUnit()
    {
        Name = "cubic centimetre per hour bar",
        Symbol = "cm³/(h·bar)",
        CommonCode = "G79",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000000000277778m,
    };
    public static IConvertibleUnit CubicCentimetrePerMinuteBar = new ConvertibleUnit()
    {
        Name = "cubic centimetre per minute bar",
        Symbol = "cm³/(min·bar)",
        CommonCode = "G80",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.0000000000001666670000000000m,
    };
    public static IConvertibleUnit CubicCentimetrePerSecondBar = new ConvertibleUnit()
    {
        Name = "cubic centimetre per second bar",
        Symbol = "cm³/(s·bar)",
        CommonCode = "G81",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit LitrePerDayBar = new ConvertibleUnit()
    {
        Name = "litre per day bar",
        Symbol = "l/(d·bar)",
        CommonCode = "G82",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.0000000000001157410000000000m,
    };
    public static IConvertibleUnit LitrePerHourBar = new ConvertibleUnit()
    {
        Name = "litre per hour bar",
        Symbol = "l/(h·bar)",
        CommonCode = "G83",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000000277778m,
    };
    public static IConvertibleUnit LitrePerMinuteBar = new ConvertibleUnit()
    {
        Name = "litre per minute bar",
        Symbol = "l/(min·bar)",
        CommonCode = "G84",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.000000000166667m,
    };
    public static IConvertibleUnit LitrePerSecondBar = new ConvertibleUnit()
    {
        Name = "litre per second bar",
        Symbol = "l/(s·bar)",
        CommonCode = "G85",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit CubicMetrePerDayBar = new ConvertibleUnit()
    {
        Name = "cubic metre per day bar",
        Symbol = "m³/(d·bar)",
        CommonCode = "G86",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000011574100000000001m,
    };
    public static IConvertibleUnit CubicMetrePerHourBar = new ConvertibleUnit()
    {
        Name = "cubic metre per hour bar",
        Symbol = "m³/(h·bar)",
        CommonCode = "G87",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000277778m,
    };
    public static IConvertibleUnit CubicMetrePerMinuteBar = new ConvertibleUnit()
    {
        Name = "cubic metre per minute bar",
        Symbol = "m³/(min·bar)",
        CommonCode = "G88",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.000000166667m,
    };
    public static IConvertibleUnit CubicMetrePerSecondBar = new ConvertibleUnit()
    {
        Name = "cubic metre per second bar",
        Symbol = "m³/(s·bar)",
        CommonCode = "G89",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MillilitrePerDayBar = new ConvertibleUnit()
    {
        Name = "millilitre per day bar",
        Symbol = "ml/(d·bar)",
        CommonCode = "G90",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.000000000000000115741m,
    };
    public static IConvertibleUnit MillilitrePerHourBar = new ConvertibleUnit()
    {
        Name = "millilitre per hour bar",
        Symbol = "ml/(h·bar)",
        CommonCode = "G91",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000000000277778m,
    };
    public static IConvertibleUnit MillilitrePerMinuteBar = new ConvertibleUnit()
    {
        Name = "millilitre per minute bar",
        Symbol = "ml/(min·bar)",
        CommonCode = "G92",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.0000000000001666670000000000m,
    };
    public static IConvertibleUnit MillilitrePerSecondBar = new ConvertibleUnit()
    {
        Name = "millilitre per second bar",
        Symbol = "ml/(s·bar)",
        CommonCode = "G93",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit CubicCentimetrePerBar = new ConvertibleUnit()
    {
        Name = "cubic centimetre per bar",
        Symbol = "cm³/bar",
        CommonCode = "G94",
        ConversionGroup = "meter ** 4 * second ** 2 / kilogram",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit LitrePerBar = new ConvertibleUnit()
    {
        Name = "litre per bar",
        Symbol = "l/bar",
        CommonCode = "G95",
        ConversionGroup = "meter ** 4 * second ** 2 / kilogram",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit CubicMetrePerBar = new ConvertibleUnit()
    {
        Name = "cubic metre per bar",
        Symbol = "m³/bar",
        CommonCode = "G96",
        ConversionGroup = "meter ** 4 * second ** 2 / kilogram",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MillilitrePerBar = new ConvertibleUnit()
    {
        Name = "millilitre per bar",
        Symbol = "ml/bar",
        CommonCode = "G97",
        ConversionGroup = "meter ** 4 * second ** 2 / kilogram",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit MicrohenryPerKiloohm = new ConvertibleUnit()
    {
        Name = "microhenry per kiloohm",
        Symbol = "µH/kΩ",
        CommonCode = "G98",
        ConversionGroup = "second",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit MicrohenryPerOhm = new ConvertibleUnit()
    {
        Name = "microhenry per ohm",
        Symbol = "µH/Ω",
        CommonCode = "G99",
        ConversionGroup = "second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit GallonUSPerDay = new ConvertibleUnit()
    {
        Name = "gallon (US) per day",
        Symbol = "gal (US)/d",
        CommonCode = "GB",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000004381264m,
    };
    public static IConvertibleUnit Gigabecquerel = new ConvertibleUnit()
    {
        Name = "gigabecquerel",
        Symbol = "GBq",
        CommonCode = "GBQ",
        ConversionGroup = "becquerel",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// A unit of mass defining the number of grams of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit GramDryWeight = new Unit()
    {
        Name = "gram, dry weight",
        Symbol = null,
        CommonCode = "GDW",
    };
    public static IConvertibleUnit PoundPerGallonUS = new ConvertibleUnit()
    {
        Name = "pound per gallon (US)",
        Symbol = "lb/gal (US)",
        CommonCode = "GE",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 119.8264m,
    };
    public static IConvertibleUnit GramPerMetreGramPer100Centimetres = new ConvertibleUnit()
    {
        Name = "gram per metre (gram per 100 centimetres)",
        Symbol = "g/m",
        CommonCode = "GF",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of mass defining the number of grams of a fissile isotope (fissile isotope: an isotope whose nucleus is able to be split when irradiated with low energy neutrons).
    /// </summary>
    public static IUnit GramOfFissileIsotope = new Unit()
    {
        Name = "gram of fissile isotope",
        Symbol = "gi F/S",
        CommonCode = "GFI",
    };
    /// <summary>
    /// A unit of count defining the number of units in multiples of 1728 (12 x 12 x 12).
    /// </summary>
    public static IConvertibleUnit GreatGross = new ConvertibleUnit()
    {
        Name = "great gross",
        Symbol = null,
        CommonCode = "GGR",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1728m,
    };
    public static IConvertibleUnit GillUS = new ConvertibleUnit()
    {
        Name = "gill (US)",
        Symbol = "gi (US)",
        CommonCode = "GIA",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.00011829410000000001m,
    };
    /// <summary>
    /// A unit of mass defining the number of grams of a product, including its container.
    /// </summary>
    public static IUnit GramIncludingContainer = new Unit()
    {
        Name = "gram, including container",
        Symbol = null,
        CommonCode = "GIC",
    };
    public static IConvertibleUnit GillUK = new ConvertibleUnit()
    {
        Name = "gill (UK)",
        Symbol = "gi (UK)",
        CommonCode = "GII",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0001420653m,
    };
    /// <summary>
    /// A unit of mass defining the number of grams of a product, including its inner packaging materials.
    /// </summary>
    public static IUnit GramIncludingInnerPackaging = new Unit()
    {
        Name = "gram, including inner packaging",
        Symbol = null,
        CommonCode = "GIP",
    };
    public static IConvertibleUnit GramPerMillilitre = new ConvertibleUnit()
    {
        Name = "gram per millilitre",
        Symbol = "g/ml",
        CommonCode = "GJ",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit GramPerLitre = new ConvertibleUnit()
    {
        Name = "gram per litre",
        Symbol = "g/l",
        CommonCode = "GL",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit DryGallonUS = new ConvertibleUnit()
    {
        Name = "dry gallon (US)",
        Symbol = "dry gal (US)",
        CommonCode = "GLD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.004404884m,
    };
    public static IConvertibleUnit GallonUK = new ConvertibleUnit()
    {
        Name = "gallon (UK)",
        Symbol = "gal (UK)",
        CommonCode = "GLI",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.004546092m,
    };
    public static IConvertibleUnit GallonUS = new ConvertibleUnit()
    {
        Name = "gallon (US)",
        Symbol = "gal (US)",
        CommonCode = "GLL",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.003785412m,
    };
    public static IConvertibleUnit GramPerSquareMetre = new ConvertibleUnit()
    {
        Name = "gram per square metre",
        Symbol = "g/m²",
        CommonCode = "GM",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MilligramPerSquareMetre = new ConvertibleUnit()
    {
        Name = "milligram per square metre",
        Symbol = "mg/m²",
        CommonCode = "GO",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MilligramPerCubicMetre = new ConvertibleUnit()
    {
        Name = "milligram per cubic metre",
        Symbol = "mg/m³",
        CommonCode = "GP",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrogramPerCubicMetre = new ConvertibleUnit()
    {
        Name = "microgram per cubic metre",
        Symbol = "µg/m³",
        CommonCode = "GQ",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Gram = new ConvertibleUnit()
    {
        Name = "gram",
        Symbol = "g",
        CommonCode = "GRM",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit Grain = new ConvertibleUnit()
    {
        Name = "grain",
        Symbol = "gr",
        CommonCode = "GRN",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.00006479891000000001m,
    };
    /// <summary>
    /// A unit of count defining the number of units in multiples of 144 (12 x 12).
    /// </summary>
    public static IConvertibleUnit Gross = new ConvertibleUnit()
    {
        Name = "gross",
        Symbol = "gr",
        CommonCode = "GRO",
        ConversionGroup = "dimensionless",
        ConversionFactor = 144m,
    };
    public static IConvertibleUnit Gigajoule = new ConvertibleUnit()
    {
        Name = "gigajoule",
        Symbol = "GJ",
        CommonCode = "GV",
        ConversionGroup = "joule",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit GigawattHour = new ConvertibleUnit()
    {
        Name = "gigawatt hour",
        Symbol = "GW·h",
        CommonCode = "GWH",
        ConversionGroup = "joule",
        ConversionFactor = 3600000000000.0m,
    };
    public static IConvertibleUnit HenryPerKiloohm = new ConvertibleUnit()
    {
        Name = "henry per kiloohm",
        Symbol = "H/kΩ",
        CommonCode = "H03",
        ConversionGroup = "second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit HenryPerOhm = new ConvertibleUnit()
    {
        Name = "henry per ohm",
        Symbol = "H/Ω",
        CommonCode = "H04",
        ConversionGroup = "second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit MillihenryPerKiloohm = new ConvertibleUnit()
    {
        Name = "millihenry per kiloohm",
        Symbol = "mH/kΩ",
        CommonCode = "H05",
        ConversionGroup = "second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillihenryPerOhm = new ConvertibleUnit()
    {
        Name = "millihenry per ohm",
        Symbol = "mH/Ω",
        CommonCode = "H06",
        ConversionGroup = "second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit PascalSecondPerBar = new ConvertibleUnit()
    {
        Name = "pascal second per bar",
        Symbol = "Pa·s/bar",
        CommonCode = "H07",
        ConversionGroup = "second",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit Microbecquerel = new ConvertibleUnit()
    {
        Name = "microbecquerel",
        Symbol = "µBq",
        CommonCode = "H08",
        ConversionGroup = "becquerel",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit ReciprocalYear = new ConvertibleUnit()
    {
        Name = "reciprocal year",
        Symbol = "1/y",
        CommonCode = "H09",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.000000031688100000000004m,
    };
    public static IConvertibleUnit ReciprocalHour = new ConvertibleUnit()
    {
        Name = "reciprocal hour",
        Symbol = "1/h",
        CommonCode = "H10",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit ReciprocalMonth = new ConvertibleUnit()
    {
        Name = "reciprocal month",
        Symbol = "1/mo",
        CommonCode = "H11",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.00000038025699999999996m,
    };
    public static IConvertibleUnit DegreeCelsiusPerHour = new ConvertibleUnit()
    {
        Name = "degree Celsius per hour",
        Symbol = "°C/h",
        CommonCode = "H12",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit DegreeCelsiusPerMinute = new ConvertibleUnit()
    {
        Name = "degree Celsius per minute",
        Symbol = "°C/min",
        CommonCode = "H13",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit DegreeCelsiusPerSecond = new ConvertibleUnit()
    {
        Name = "degree Celsius per second",
        Symbol = "°C/s",
        CommonCode = "H14",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareCentimetrePerGram = new ConvertibleUnit()
    {
        Name = "square centimetre per gram",
        Symbol = "cm²/g",
        CommonCode = "H15",
        ConversionGroup = "meter ** 2 / kilogram",
        ConversionFactor = 0.1m,
    };
    /// <summary>
    /// Synonym: are
    /// </summary>
    public static IConvertibleUnit SquareDecametre = new ConvertibleUnit()
    {
        Name = "square decametre",
        Symbol = "dam²",
        CommonCode = "H16",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 100m,
    };
    /// <summary>
    /// Synonym: hectare
    /// </summary>
    public static IConvertibleUnit SquareHectometre = new ConvertibleUnit()
    {
        Name = "square hectometre",
        Symbol = "hm²",
        CommonCode = "H18",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 10000m,
    };
    public static IConvertibleUnit CubicHectometre = new ConvertibleUnit()
    {
        Name = "cubic hectometre",
        Symbol = "hm³",
        CommonCode = "H19",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit CubicKilometre = new ConvertibleUnit()
    {
        Name = "cubic kilometre",
        Symbol = "km³",
        CommonCode = "H20",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// A unit of count defining the number of blanks.
    /// </summary>
    public static IUnit Blank = new Unit()
    {
        Name = "blank",
        Symbol = null,
        CommonCode = "H21",
    };
    public static IConvertibleUnit VoltSquareInchPerPoundforce = new ConvertibleUnit()
    {
        Name = "volt square inch per poundforce",
        Symbol = "V/(lbf/in²)",
        CommonCode = "H22",
        ConversionGroup = "meter ** 3 / ampere / second",
        ConversionFactor = 0.00014503774398000002m,
    };
    public static IConvertibleUnit VoltPerInch = new ConvertibleUnit()
    {
        Name = "volt per inch",
        Symbol = "V/in",
        CommonCode = "H23",
        ConversionGroup = "kilogram * meter / ampere / second ** 3",
        ConversionFactor = 39.37007874m,
    };
    public static IConvertibleUnit VoltPerMicrosecond = new ConvertibleUnit()
    {
        Name = "volt per microsecond",
        Symbol = "V/µs",
        CommonCode = "H24",
        ConversionGroup = "volt / second",
        ConversionFactor = 1000000.0m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to the SI base unit Kelvin.
    /// </summary>
    public static IConvertibleUnit PercentPerKelvin = new ConvertibleUnit()
    {
        Name = "percent per kelvin",
        Symbol = "%/K",
        CommonCode = "H25",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit OhmPerMetre = new ConvertibleUnit()
    {
        Name = "ohm per metre",
        Symbol = "Ω/m",
        CommonCode = "H26",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit DegreePerMetre = new ConvertibleUnit()
    {
        Name = "degree per metre",
        Symbol = "°/m",
        CommonCode = "H27",
        ConversionGroup = "radian / meter",
        ConversionFactor = 0.01745329m,
    };
    public static IConvertibleUnit MicrofaradPerKilometre = new ConvertibleUnit()
    {
        Name = "microfarad per kilometre",
        Symbol = "µF/km",
        CommonCode = "H28",
        ConversionGroup = "farad / meter",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit MicrogramPerLitre = new ConvertibleUnit()
    {
        Name = "microgram per litre",
        Symbol = "µg/l",
        CommonCode = "H29",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit SquareMicrometreSquareMicron = new ConvertibleUnit()
    {
        Name = "square micrometre (square micron)",
        Symbol = "µm²",
        CommonCode = "H30",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit AmperePerKilogram = new ConvertibleUnit()
    {
        Name = "ampere per kilogram",
        Symbol = "A/kg",
        CommonCode = "H31",
        ConversionGroup = "ampere / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit AmpereSquaredSecond = new ConvertibleUnit()
    {
        Name = "ampere squared second",
        Symbol = "A²·s",
        CommonCode = "H32",
        ConversionGroup = "ampere ** 2 * second",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit FaradPerKilometre = new ConvertibleUnit()
    {
        Name = "farad per kilometre",
        Symbol = "F/km",
        CommonCode = "H33",
        ConversionGroup = "farad / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit HertzMetre = new ConvertibleUnit()
    {
        Name = "hertz metre",
        Symbol = "Hz·m",
        CommonCode = "H34",
        ConversionGroup = "hertz * meter",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KelvinMetrePerWatt = new ConvertibleUnit()
    {
        Name = "kelvin metre per watt",
        Symbol = "K·m/W",
        CommonCode = "H35",
        ConversionGroup = "kelvin * second ** 3 / kilogram / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MegaohmPerKilometre = new ConvertibleUnit()
    {
        Name = "megaohm per kilometre",
        Symbol = "MΩ/km",
        CommonCode = "H36",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MegaohmPerMetre = new ConvertibleUnit()
    {
        Name = "megaohm per metre",
        Symbol = "MΩ/m",
        CommonCode = "H37",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit Megaampere = new ConvertibleUnit()
    {
        Name = "megaampere",
        Symbol = "MA",
        CommonCode = "H38",
        ConversionGroup = "ampere",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit MegahertzKilometre = new ConvertibleUnit()
    {
        Name = "megahertz kilometre",
        Symbol = "MHz·km",
        CommonCode = "H39",
        ConversionGroup = "hertz * meter",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit NewtonPerAmpere = new ConvertibleUnit()
    {
        Name = "newton per ampere",
        Symbol = "N/A",
        CommonCode = "H40",
        ConversionGroup = "kilogram * meter / ampere / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit NewtonMetreWattToThePowerMinus05 = new ConvertibleUnit()
    {
        Name = "newton metre watt to the power minus 0,5",
        Symbol = "N·m·W⁻⁰‧⁵",
        CommonCode = "H41",
        ConversionGroup = "kilogram * meter ** 2 / second ** 2 / watt ** 0.5",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit PascalPerMetre = new ConvertibleUnit()
    {
        Name = "pascal per metre",
        Symbol = "Pa/m",
        CommonCode = "H42",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SiemensPerCentimetre = new ConvertibleUnit()
    {
        Name = "siemens per centimetre",
        Symbol = "S/cm",
        CommonCode = "H43",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit Teraohm = new ConvertibleUnit()
    {
        Name = "teraohm",
        Symbol = "TΩ",
        CommonCode = "H44",
        ConversionGroup = "ohm",
        ConversionFactor = 1000000000000m,
    };
    public static IConvertibleUnit VoltSecondPerMetre = new ConvertibleUnit()
    {
        Name = "volt second per metre",
        Symbol = "V·s/m",
        CommonCode = "H45",
        ConversionGroup = "kilogram * meter / ampere / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit VoltPerSecond = new ConvertibleUnit()
    {
        Name = "volt per second",
        Symbol = "V/s",
        CommonCode = "H46",
        ConversionGroup = "kilogram * meter ** 2 / ampere / second ** 4",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit WattPerCubicMetre = new ConvertibleUnit()
    {
        Name = "watt per cubic metre",
        Symbol = "W/m³",
        CommonCode = "H47",
        ConversionGroup = "kilogram / meter / second ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Attofarad = new ConvertibleUnit()
    {
        Name = "attofarad",
        Symbol = "aF",
        CommonCode = "H48",
        ConversionGroup = "ampere ** 2 * second ** 4 / kilogram / meter ** 2",
        ConversionFactor = 0.000000000000000001m,
    };
    public static IConvertibleUnit CentimetrePerHour = new ConvertibleUnit()
    {
        Name = "centimetre per hour",
        Symbol = "cm/h",
        CommonCode = "H49",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000000277777778m,
    };
    public static IConvertibleUnit ReciprocalCubicCentimetre = new ConvertibleUnit()
    {
        Name = "reciprocal cubic centimetre",
        Symbol = "cm⁻³",
        CommonCode = "H50",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit DecibelPerKilometre = new ConvertibleUnit()
    {
        Name = "decibel per kilometre",
        Symbol = "dB/km",
        CommonCode = "H51",
        ConversionGroup = "byte / meter",
        ConversionFactor = 0.0001m,
    };
    public static IConvertibleUnit DecibelPerMetre = new ConvertibleUnit()
    {
        Name = "decibel per metre",
        Symbol = "dB/m",
        CommonCode = "H52",
        ConversionGroup = "byte / meter",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit KilogramPerBar = new ConvertibleUnit()
    {
        Name = "kilogram per bar",
        Symbol = "kg/bar",
        CommonCode = "H53",
        ConversionGroup = "meter * second ** 2",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit KilogramPerCubicDecimetreKelvin = new ConvertibleUnit()
    {
        Name = "kilogram per cubic decimetre kelvin",
        Symbol = "(kg/dm³)/K",
        CommonCode = "H54",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilogramPerCubicDecimetreBar = new ConvertibleUnit()
    {
        Name = "kilogram per cubic decimetre bar",
        Symbol = "(kg/dm³)/bar",
        CommonCode = "H55",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit KilogramPerSquareMetreSecond = new ConvertibleUnit()
    {
        Name = "kilogram per square metre second",
        Symbol = "kg/(m²·s)",
        CommonCode = "H56",
        ConversionGroup = "kilogram / meter ** 2 / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit InchPerTwoPiRadiant = new ConvertibleUnit()
    {
        Name = "inch per two pi radiant",
        Symbol = "in/revolution",
        CommonCode = "H57",
        ConversionGroup = "meter / pi / radian",
        ConversionFactor = 0.012700000000000001m,
    };
    public static IConvertibleUnit MetrePerVoltSecond = new ConvertibleUnit()
    {
        Name = "metre per volt second",
        Symbol = "m/(V·s)",
        CommonCode = "H58",
        ConversionGroup = "ampere * second ** 2 / kilogram / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetrePerNewton = new ConvertibleUnit()
    {
        Name = "square metre per newton",
        Symbol = "m²/N",
        CommonCode = "H59",
        ConversionGroup = "meter * second ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit CubicMetrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "cubic metre per cubic metre",
        Symbol = "m³/m³",
        CommonCode = "H60",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit MillisiemensPerCentimetre = new ConvertibleUnit()
    {
        Name = "millisiemens per centimetre",
        Symbol = "mS/cm",
        CommonCode = "H61",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit MillivoltPerMinute = new ConvertibleUnit()
    {
        Name = "millivolt per minute",
        Symbol = "mV/min",
        CommonCode = "H62",
        ConversionGroup = "kilogram * meter ** 2 / ampere / second ** 4",
        ConversionFactor = 0.000016666666670000003m,
    };
    public static IConvertibleUnit MilligramPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "milligram per square centimetre",
        Symbol = "mg/cm²",
        CommonCode = "H63",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit MilligramPerGram = new ConvertibleUnit()
    {
        Name = "milligram per gram",
        Symbol = "mg/g",
        CommonCode = "H64",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillilitrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "millilitre per cubic metre",
        Symbol = "ml/m³",
        CommonCode = "H65",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MillimetrePerYear = new ConvertibleUnit()
    {
        Name = "millimetre per year",
        Symbol = "mm/y",
        CommonCode = "H66",
        ConversionGroup = "meter / second",
        ConversionFactor = 31557.6m,
    };
    public static IConvertibleUnit MillimetrePerHour = new ConvertibleUnit()
    {
        Name = "millimetre per hour",
        Symbol = "mm/h",
        CommonCode = "H67",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000000027777777799999998m,
    };
    public static IConvertibleUnit MillimolePerGram = new ConvertibleUnit()
    {
        Name = "millimole per gram",
        Symbol = "mmol/g",
        CommonCode = "H68",
        ConversionGroup = "mole / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit PicopascalPerKilometre = new ConvertibleUnit()
    {
        Name = "picopascal per kilometre",
        Symbol = "pPa/km",
        CommonCode = "H69",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 0.000000000000001m,
    };
    public static IConvertibleUnit Picosecond = new ConvertibleUnit()
    {
        Name = "picosecond",
        Symbol = "ps",
        CommonCode = "H70",
        ConversionGroup = "second",
        ConversionFactor = 0.000000000001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to a month.
    /// </summary>
    public static IUnit PercentPerMonth = new Unit()
    {
        Name = "percent per month",
        Symbol = "%/mo",
        CommonCode = "H71",
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to 100-fold of the unit bar.
    /// </summary>
    public static IUnit PercentPerHectobar = new Unit()
    {
        Name = "percent per hectobar",
        Symbol = "%/hbar",
        CommonCode = "H72",
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to 10-fold of the SI base unit Kelvin.
    /// </summary>
    public static IConvertibleUnit PercentPerDecakelvin = new ConvertibleUnit()
    {
        Name = "percent per decakelvin",
        Symbol = "%/daK",
        CommonCode = "H73",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit WattPerMetre = new ConvertibleUnit()
    {
        Name = "watt per metre",
        Symbol = "W/m",
        CommonCode = "H74",
        ConversionGroup = "watt / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Decapascal = new ConvertibleUnit()
    {
        Name = "decapascal",
        Symbol = "daPa",
        CommonCode = "H75",
        ConversionGroup = "pascal",
        ConversionFactor = 10m,
    };
    public static IConvertibleUnit GramPerMillimetre = new ConvertibleUnit()
    {
        Name = "gram per millimetre",
        Symbol = "g/mm",
        CommonCode = "H76",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 10.0m,
    };
    /// <summary>
    /// A unit of measure used to describe the breadth of electronic assemblies as an installation standard or mounting dimension.
    /// </summary>
    public static IUnit ModuleWidth = new Unit()
    {
        Name = "module width",
        Symbol = "MW",
        CommonCode = "H77",
    };
    /// <summary>
    /// A unit of distance used for measuring the diameter of small tubes such as urological instruments and catheters.Synonym: French, Charrière, Charrière gauge
    /// </summary>
    public static IConvertibleUnit FrenchGauge = new ConvertibleUnit()
    {
        Name = "French gauge",
        Symbol = "Fg",
        CommonCode = "H79",
        ConversionGroup = "meter",
        ConversionFactor = 0.000333333333m,
    };
    /// <summary>
    /// A unit of measure used to describe the height in rack units of equipment intended for mounting in a 19-inch rack or a 23-inch rack. One rack unit is 1.75 inches (44.45 mm) high.
    /// </summary>
    public static IConvertibleUnit RackUnit = new ConvertibleUnit()
    {
        Name = "rack unit",
        Symbol = "U or RU",
        CommonCode = "H80",
        ConversionGroup = "meter",
        ConversionFactor = 0.04445m,
    };
    public static IConvertibleUnit MillimetrePerMinute = new ConvertibleUnit()
    {
        Name = "millimetre per minute",
        Symbol = "mm/min",
        CommonCode = "H81",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000016666666670000003m,
    };
    /// <summary>
    /// A unit of length defining the number of big points (big point: Adobe software(US) defines the big point to be exactly 1/72 inch (0.013 888 9 inch or 0.352 777 8 millimeters))
    /// </summary>
    public static IConvertibleUnit BigPoint = new ConvertibleUnit()
    {
        Name = "big point",
        Symbol = "bp",
        CommonCode = "H82",
        ConversionGroup = "meter",
        ConversionFactor = 0.0003527778m,
    };
    public static IConvertibleUnit LitrePerKilogram = new ConvertibleUnit()
    {
        Name = "litre per kilogram",
        Symbol = "l/kg",
        CommonCode = "H83",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit GramMillimetre = new ConvertibleUnit()
    {
        Name = "gram millimetre",
        Symbol = "g·mm",
        CommonCode = "H84",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit ReciprocalWeek = new ConvertibleUnit()
    {
        Name = "reciprocal week",
        Symbol = "1/wk",
        CommonCode = "H85",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.0000016479894528679998m,
    };
    /// <summary>
    /// A unit of count defining the number of pieces (piece: a single item, article or exemplar).
    /// </summary>
    public static IUnit PieceH87 = new Unit()
    {
        Name = "piece",
        Symbol = null,
        CommonCode = "H87",
    };
    /// <summary>
    /// A loose or unpacked article.
    /// </summary>
    public static IUnit PieceXPP = new Unit()
    {
        Name = "Piece",
        Symbol = null,
        CommonCode = "XPP",
    };
    public static IConvertibleUnit MegaohmKilometre = new ConvertibleUnit()
    {
        Name = "megaohm kilometre",
        Symbol = "MΩ·km",
        CommonCode = "H88",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to the SI derived unit ohm.
    /// </summary>
    public static IConvertibleUnit PercentPerOhm = new ConvertibleUnit()
    {
        Name = "percent per ohm",
        Symbol = "%/Ω",
        CommonCode = "H89",
        ConversionGroup = "1 / ohm",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to an angle of one degree.
    /// </summary>
    public static IConvertibleUnit PercentPerDegree = new ConvertibleUnit()
    {
        Name = "percent per degree",
        Symbol = "%/°",
        CommonCode = "H90",
        ConversionGroup = "1 / radian",
        ConversionFactor = 0.5729578m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to multiples of ten thousand.
    /// </summary>
    public static IConvertibleUnit PercentPerTenThousand = new ConvertibleUnit()
    {
        Name = "percent per ten thousand",
        Symbol = "%/10000",
        CommonCode = "H91",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to multiples of one hundred thousand.
    /// </summary>
    public static IConvertibleUnit PercentPerOneHundredThousand = new ConvertibleUnit()
    {
        Name = "percent per one hundred thousand",
        Symbol = "%/100000",
        CommonCode = "H92",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.0000001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to multiples of one hundred.
    /// </summary>
    public static IConvertibleUnit PercentPerHundred = new ConvertibleUnit()
    {
        Name = "percent per hundred",
        Symbol = "%/100",
        CommonCode = "H93",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.0001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to multiples of one thousand.
    /// </summary>
    public static IConvertibleUnit PercentPerThousand = new ConvertibleUnit()
    {
        Name = "percent per thousand",
        Symbol = "%/1000",
        CommonCode = "H94",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.00001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to the SI derived unit volt.
    /// </summary>
    public static IConvertibleUnit PercentPerVolt = new ConvertibleUnit()
    {
        Name = "percent per volt",
        Symbol = "%/V",
        CommonCode = "H95",
        ConversionGroup = "1 / volt",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to an atmospheric pressure of one bar.
    /// </summary>
    public static IConvertibleUnit PercentPerBar = new ConvertibleUnit()
    {
        Name = "percent per bar",
        Symbol = "%/bar",
        CommonCode = "H96",
        ConversionGroup = "1 / pascal",
        ConversionFactor = 0.0000001m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to an inch.
    /// </summary>
    public static IConvertibleUnit PercentPerInch = new ConvertibleUnit()
    {
        Name = "percent per inch",
        Symbol = "%/in",
        CommonCode = "H98",
        ConversionGroup = "1 / meter",
        ConversionFactor = 0.3937008m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to a metre.
    /// </summary>
    public static IConvertibleUnit PercentPerMetre = new ConvertibleUnit()
    {
        Name = "percent per metre",
        Symbol = "%/m",
        CommonCode = "H99",
        ConversionGroup = "1 / meter",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of length, typically for yarn.
    /// </summary>
    public static IUnit Hank = new Unit()
    {
        Name = "hank",
        Symbol = null,
        CommonCode = "HA",
    };
    public static IConvertibleUnit Hectobar = new ConvertibleUnit()
    {
        Name = "hectobar",
        Symbol = "hbar",
        CommonCode = "HBA",
        ConversionGroup = "pascal",
        ConversionFactor = 10000000m,
    };
    /// <summary>
    /// A unit of count defining the number of boxes in multiples of one hundred box units.
    /// </summary>
    public static IUnit HundredBoxes = new Unit()
    {
        Name = "hundred boxes",
        Symbol = null,
        CommonCode = "HBX",
    };
    /// <summary>
    /// A unit of count defining the number of units counted in multiples of 100.
    /// </summary>
    public static IUnit HundredCount = new Unit()
    {
        Name = "hundred count",
        Symbol = null,
        CommonCode = "HC",
    };
    /// <summary>
    /// A unit of mass defining the number of hundred kilograms of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit HundredKilogramDryWeight = new Unit()
    {
        Name = "hundred kilogram, dry weight",
        Symbol = null,
        CommonCode = "HDW",
    };
    /// <summary>
    /// A unit of count defining the number of heads (head: a person or animal considered as one of a number).
    /// </summary>
    public static IUnit Head = new Unit()
    {
        Name = "head",
        Symbol = null,
        CommonCode = "HEA",
    };
    public static IConvertibleUnit Hectogram = new ConvertibleUnit()
    {
        Name = "hectogram",
        Symbol = "hg",
        CommonCode = "HGM",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.1m,
    };
    /// <summary>
    /// A unit of volume equal to one hundred cubic foot.
    /// </summary>
    public static IUnit HundredCubicFoot = new Unit()
    {
        Name = "hundred cubic foot",
        Symbol = null,
        CommonCode = "HH",
    };
    /// <summary>
    /// A unit of count defining the number of international units in multiples of 100.
    /// </summary>
    public static IUnit HundredInternationalUnit = new Unit()
    {
        Name = "hundred international unit",
        Symbol = null,
        CommonCode = "HIU",
    };
    /// <summary>
    /// A unit of mass defining the number of hundred kilograms of a product, after deductions.
    /// </summary>
    public static IUnit HundredKilogramNetMass = new Unit()
    {
        Name = "hundred kilogram, net mass",
        Symbol = null,
        CommonCode = "HKM",
    };
    public static IConvertibleUnit Hectolitre = new ConvertibleUnit()
    {
        Name = "hectolitre",
        Symbol = "hl",
        CommonCode = "HLT",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.1m,
    };
    public static IConvertibleUnit MilePerHourStatuteMile = new ConvertibleUnit()
    {
        Name = "mile per hour (statute mile)",
        Symbol = "mile/h",
        CommonCode = "HM",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.44704m,
    };
    /// <summary>
    /// A unit of volume equal to one million cubic metres.
    /// </summary>
    public static IUnit MillionCubicMetre = new Unit()
    {
        Name = "million cubic metre",
        Symbol = "Mm³",
        CommonCode = "HMQ",
    };
    public static IConvertibleUnit Hectometre = new ConvertibleUnit()
    {
        Name = "hectometre",
        Symbol = "hm",
        CommonCode = "HMT",
        ConversionGroup = "meter",
        ConversionFactor = 100m,
    };
    /// <summary>
    /// A unit of volume equal to one hundred litres of pure alcohol.
    /// </summary>
    public static IUnit HectolitreOfPureAlcohol = new Unit()
    {
        Name = "hectolitre of pure alcohol",
        Symbol = null,
        CommonCode = "HPA",
    };
    public static IConvertibleUnit Hertz = new ConvertibleUnit()
    {
        Name = "hertz",
        Symbol = "Hz",
        CommonCode = "HTZ",
        ConversionGroup = "hertz",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Hour = new ConvertibleUnit()
    {
        Name = "hour",
        Symbol = "h",
        CommonCode = "HUR",
        ConversionGroup = "second",
        ConversionFactor = 3600m,
    };
    public static IConvertibleUnit InchPoundPoundInch = new ConvertibleUnit()
    {
        Name = "inch pound (pound inch)",
        Symbol = "in·lb",
        CommonCode = "IA",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 0.0115212m,
    };
    /// <summary>
    /// A unit of count defining the number of persons.
    /// </summary>
    public static IUnit Person = new Unit()
    {
        Name = "person",
        Symbol = null,
        CommonCode = "IE",
    };
    public static IConvertibleUnit Inch = new ConvertibleUnit()
    {
        Name = "inch",
        Symbol = "in",
        CommonCode = "INH",
        ConversionGroup = "meter",
        ConversionFactor = 0.0254m,
    };
    public static IConvertibleUnit SquareInch = new ConvertibleUnit()
    {
        Name = "square inch",
        Symbol = "in²",
        CommonCode = "INK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.00064516m,
    };
    /// <summary>
    /// Synonym: inch cubed
    /// </summary>
    public static IConvertibleUnit CubicInch = new ConvertibleUnit()
    {
        Name = "cubic inch",
        Symbol = "in³",
        CommonCode = "INQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000016387064m,
    };
    /// <summary>
    /// A unit of measure defining the sugar content of a solution, expressed in degrees.
    /// </summary>
    public static IUnit InternationalSugarDegree = new Unit()
    {
        Name = "international sugar degree",
        Symbol = null,
        CommonCode = "ISD",
    };
    public static IConvertibleUnit InchPerSecond = new ConvertibleUnit()
    {
        Name = "inch per second",
        Symbol = "in/s",
        CommonCode = "IU",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.0254m,
    };
    /// <summary>
    /// A unit of count defining the number of international units per gram.
    /// </summary>
    public static IUnit InternationalUnitPerGram = new Unit()
    {
        Name = "international unit per gram",
        Symbol = null,
        CommonCode = "IUG",
    };
    public static IConvertibleUnit InchPerSecondSquared = new ConvertibleUnit()
    {
        Name = "inch per second squared",
        Symbol = "in/s²",
        CommonCode = "IV",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.0254m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to a millimetre.
    /// </summary>
    public static IConvertibleUnit PercentPerMillimetre = new ConvertibleUnit()
    {
        Name = "percent per millimetre",
        Symbol = "%/mm",
        CommonCode = "J10",
        ConversionGroup = "1 / meter",
        ConversionFactor = 10.0m,
    };
    /// <summary>
    /// A unit of pressure equal to one thousandth of a psi (pound-force per square inch).
    /// </summary>
    public static IConvertibleUnit PerMillePerPsi = new ConvertibleUnit()
    {
        Name = "per mille per psi",
        Symbol = "‰/psi",
        CommonCode = "J12",
        ConversionGroup = "1 / pascal",
        ConversionFactor = 0.0000001450377m,
    };
    /// <summary>
    /// A unit of relative density as a measure of how heavy or light a petroleum liquid is compared to water (API: American Petroleum Institute).
    /// </summary>
    public static IUnit DegreeAPI = new Unit()
    {
        Name = "degree API",
        Symbol = "°API",
        CommonCode = "J13",
    };
    /// <summary>
    /// A traditional unit of relative density for liquids. Named after Antoine Baumé.
    /// </summary>
    public static IUnit DegreeBaumeOriginScale = new Unit()
    {
        Name = "degree Baume (origin scale)",
        Symbol = "°Bé",
        CommonCode = "J14",
    };
    /// <summary>
    /// A unit of relative density for liquids heavier than water.
    /// </summary>
    public static IUnit DegreeBaumeUSHeavy = new Unit()
    {
        Name = "degree Baume (US heavy)",
        Symbol = "°Bé (US heavy)",
        CommonCode = "J15",
    };
    /// <summary>
    /// A unit of relative density for liquids lighter than water.
    /// </summary>
    public static IUnit DegreeBaumeUSLight = new Unit()
    {
        Name = "degree Baume (US light)",
        Symbol = "°Bé (US light)",
        CommonCode = "J16",
    };
    /// <summary>
    /// A unit of density as a measure of sugar content, especially of beer wort. Named after Karl Balling.
    /// </summary>
    public static IUnit DegreeBalling = new Unit()
    {
        Name = "degree Balling",
        Symbol = "°Balling",
        CommonCode = "J17",
    };
    /// <summary>
    /// A unit of proportion used in measuring the dissolved sugar-to-water mass ratio of a liquid. Named after Adolf Brix.
    /// </summary>
    public static IUnit DegreeBrix = new Unit()
    {
        Name = "degree Brix",
        Symbol = "°Bx",
        CommonCode = "J18",
    };
    public static IConvertibleUnit DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemical = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour square foot per British thermal unit (thermochemical)",
        Symbol = "°F·h·ft²/Btuth",
        CommonCode = "J19",
        ConversionGroup = "kelvin * meter ** 2 / watt",
        ConversionFactor = 0.176228m,
    };
    public static IConvertibleUnit JoulePerKilogram = new ConvertibleUnit()
    {
        Name = "joule per kilogram",
        Symbol = "J/kg",
        CommonCode = "J2",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit DegreeFahrenheitPerKelvin = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit per kelvin",
        Symbol = "°F/K",
        CommonCode = "J20",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.5555556m,
    };
    public static IConvertibleUnit DegreeFahrenheitPerBar = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit per bar",
        Symbol = "°F/bar",
        CommonCode = "J21",
        ConversionGroup = "kelvin / pascal",
        ConversionFactor = 0.000005555556000000001m,
    };
    public static IConvertibleUnit DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTable = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour square foot per British thermal unit (international table)",
        Symbol = "°F·h·ft²/BtuIT",
        CommonCode = "J22",
        ConversionGroup = "kelvin * meter ** 2 / watt",
        ConversionFactor = 0.1761102m,
    };
    public static IConvertibleUnit DegreeFahrenheitPerHour = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit per hour",
        Symbol = "°F/h",
        CommonCode = "J23",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.00015432100000000002m,
    };
    public static IConvertibleUnit DegreeFahrenheitPerMinute = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit per minute",
        Symbol = "°F/min",
        CommonCode = "J24",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.009259259m,
    };
    public static IConvertibleUnit DegreeFahrenheitPerSecond = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit per second",
        Symbol = "°F/s",
        CommonCode = "J25",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.5555556m,
    };
    public static IConvertibleUnit ReciprocalDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "reciprocal degree Fahrenheit",
        Symbol = "1/°F",
        CommonCode = "J26",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 1.81m,
    };
    /// <summary>
    /// A unit of density as a measure of sugar content of must, the unfermented liqueur from which wine is made. Named after Ferdinand Oechsle.
    /// </summary>
    public static IUnit DegreeOechsle = new Unit()
    {
        Name = "degree Oechsle",
        Symbol = "°Oechsle",
        CommonCode = "J27",
    };
    public static IConvertibleUnit DegreeRankinePerHour = new ConvertibleUnit()
    {
        Name = "degree Rankine per hour",
        Symbol = "°R/h",
        CommonCode = "J28",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.00015432100000000002m,
    };
    public static IConvertibleUnit DegreeRankinePerMinute = new ConvertibleUnit()
    {
        Name = "degree Rankine per minute",
        Symbol = "°R/min",
        CommonCode = "J29",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.009259259m,
    };
    public static IConvertibleUnit DegreeRankinePerSecond = new ConvertibleUnit()
    {
        Name = "degree Rankine per second",
        Symbol = "°R/s",
        CommonCode = "J30",
        ConversionGroup = "kelvin / second",
        ConversionFactor = 0.5555556m,
    };
    /// <summary>
    /// A unit of density for liquids that are heavier than water.  1 degree Twaddle represents a difference in specific gravity of 0.005.
    /// </summary>
    public static IUnit DegreeTwaddell = new Unit()
    {
        Name = "degree Twaddell",
        Symbol = "°Tw",
        CommonCode = "J31",
    };
    public static IConvertibleUnit Micropoise = new ConvertibleUnit()
    {
        Name = "micropoise",
        Symbol = "µP",
        CommonCode = "J32",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MicrogramPerKilogram = new ConvertibleUnit()
    {
        Name = "microgram per kilogram",
        Symbol = "µg/kg",
        CommonCode = "J33",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit MicrogramPerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "microgram per cubic metre kelvin",
        Symbol = "(µg/m³)/K",
        CommonCode = "J34",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit MicrogramPerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "microgram per cubic metre bar",
        Symbol = "(µg/m³)/bar",
        CommonCode = "J35",
        ConversionGroup = "kilogram / meter ** 3 / pascal",
        ConversionFactor = 0.00000000000001m,
    };
    public static IConvertibleUnit MicrolitrePerLitre = new ConvertibleUnit()
    {
        Name = "microlitre per litre",
        Symbol = "µl/l",
        CommonCode = "J36",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of signal transmission speed equal to one signalling event per second.
    /// </summary>
    public static IUnit Baud = new Unit()
    {
        Name = "baud",
        Symbol = "Bd",
        CommonCode = "J38",
    };
    public static IConvertibleUnit BritishThermalUnitMean = new ConvertibleUnit()
    {
        Name = "British thermal unit (mean)",
        Symbol = "Btu",
        CommonCode = "J39",
        ConversionGroup = "joule",
        ConversionFactor = 1055.8700000000001m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTableFootPerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) foot per hour square foot degree Fahrenheit",
        Symbol = "BtuIT·ft/(h·ft²·°F)",
        CommonCode = "J40",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1.730735m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTableInchPerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) inch per hour square foot degree Fahrenheit",
        Symbol = "BtuIT·in/(h·ft²·°F)",
        CommonCode = "J41",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 0.1442279m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTableInchPerSecondSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) inch per second square foot degree Fahrenheit",
        Symbol = "BtuIT·in/(s·ft²·°F)",
        CommonCode = "J42",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 519.2204m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerPoundDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per pound degree Fahrenheit",
        Symbol = "BtuIT/(lb·°F)",
        CommonCode = "J43",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4186.8m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerMinute = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per minute",
        Symbol = "BtuIT/min",
        CommonCode = "J44",
        ConversionGroup = "watt",
        ConversionFactor = 17.584266m,
    };
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSecond = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per second",
        Symbol = "BtuIT/s",
        CommonCode = "J45",
        ConversionGroup = "watt",
        ConversionFactor = 1055.056m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalFootPerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) foot per hour square foot degree Fahrenheit",
        Symbol = "Btuth·ft/(h·ft²·°F)",
        CommonCode = "J46",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1.729577m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerHour = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per hour",
        Symbol = "Btuth/h",
        CommonCode = "J47",
        ConversionGroup = "watt",
        ConversionFactor = 0.2928751m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalInchPerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) inch per hour square foot degree Fahrenheit",
        Symbol = "Btuth·in/(h·ft²·°F)",
        CommonCode = "J48",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 0.1441314m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalInchPerSecondSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) inch per second square foot degree Fahrenheit",
        Symbol = "Btuth·in/(s·ft²·°F)",
        CommonCode = "J49",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 518.8732m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerPoundDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per pound degree Fahrenheit",
        Symbol = "Btuth/(lb·°F)",
        CommonCode = "J50",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4184.0m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerMinute = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per minute",
        Symbol = "Btuth/min",
        CommonCode = "J51",
        ConversionGroup = "watt",
        ConversionFactor = 17.5725m,
    };
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSecond = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per second",
        Symbol = "Btuth/s",
        CommonCode = "J52",
        ConversionGroup = "watt",
        ConversionFactor = 1054.35m,
    };
    public static IConvertibleUnit CoulombSquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "coulomb square metre per kilogram",
        Symbol = "C·m²/kg",
        CommonCode = "J53",
        ConversionGroup = "coulomb * meter ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of signal transmission speed equal to 10⁶ (1000000) signaling events per second.
    /// </summary>
    public static IConvertibleUnit Megabaud = new ConvertibleUnit()
    {
        Name = "megabaud",
        Symbol = "MBd",
        CommonCode = "J54",
        ConversionGroup = "baud",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit WattSecond = new ConvertibleUnit()
    {
        Name = "watt second",
        Symbol = "W·s",
        CommonCode = "J55",
        ConversionGroup = "second * watt",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit BarPerBar = new ConvertibleUnit()
    {
        Name = "bar per bar",
        Symbol = "bar/bar",
        CommonCode = "J56",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit BarrelUKPetroleum = new ConvertibleUnit()
    {
        Name = "barrel (UK petroleum)",
        Symbol = "bbl (UK liq.)",
        CommonCode = "J57",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.15911315m,
    };
    public static IConvertibleUnit BarrelUKPetroleumPerMinute = new ConvertibleUnit()
    {
        Name = "barrel (UK petroleum) per minute",
        Symbol = "bbl (UK liq.)/min",
        CommonCode = "J58",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 2.651886m,
    };
    public static IConvertibleUnit BarrelUKPetroleumPerDay = new ConvertibleUnit()
    {
        Name = "barrel (UK petroleum) per day",
        Symbol = "bbl (UK liq.)/d",
        CommonCode = "J59",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000018415874000000001m,
    };
    public static IConvertibleUnit BarrelUKPetroleumPerHour = new ConvertibleUnit()
    {
        Name = "barrel (UK petroleum) per hour",
        Symbol = "bbl (UK liq.)/h",
        CommonCode = "J60",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000044198100000000006m,
    };
    public static IConvertibleUnit BarrelUKPetroleumPerSecond = new ConvertibleUnit()
    {
        Name = "barrel (UK petroleum) per second",
        Symbol = "bbl (UK liq.)/s",
        CommonCode = "J61",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.15911315m,
    };
    public static IConvertibleUnit BarrelUSPetroleumPerHour = new ConvertibleUnit()
    {
        Name = "barrel (US petroleum) per hour",
        Symbol = "bbl (US)/h",
        CommonCode = "J62",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00004416314m,
    };
    public static IConvertibleUnit BarrelUSPetroleumPerSecond = new ConvertibleUnit()
    {
        Name = "barrel (US petroleum) per second",
        Symbol = "bbl (US)/s",
        CommonCode = "J63",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.1589873m,
    };
    public static IConvertibleUnit BushelUKPerDay = new ConvertibleUnit()
    {
        Name = "bushel (UK) per day",
        Symbol = "bu (UK)/d",
        CommonCode = "J64",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000004209342999999999m,
    };
    public static IConvertibleUnit BushelUKPerHour = new ConvertibleUnit()
    {
        Name = "bushel (UK) per hour",
        Symbol = "bu (UK)/h",
        CommonCode = "J65",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000010102420000000001m,
    };
    public static IConvertibleUnit BushelUKPerMinute = new ConvertibleUnit()
    {
        Name = "bushel (UK) per minute",
        Symbol = "bu (UK)/min",
        CommonCode = "J66",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0006061453000000001m,
    };
    public static IConvertibleUnit BushelUKPerSecond = new ConvertibleUnit()
    {
        Name = "bushel (UK) per second",
        Symbol = "bu (UK)/s",
        CommonCode = "J67",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.03636872m,
    };
    public static IConvertibleUnit BushelUSDryPerDay = new ConvertibleUnit()
    {
        Name = "bushel (US dry) per day",
        Symbol = "bu (US dry)/d",
        CommonCode = "J68",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000004078596m,
    };
    public static IConvertibleUnit BushelUSDryPerHour = new ConvertibleUnit()
    {
        Name = "bushel (US dry) per hour",
        Symbol = "bu (US dry)/h",
        CommonCode = "J69",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000009788631m,
    };
    public static IConvertibleUnit BushelUSDryPerMinute = new ConvertibleUnit()
    {
        Name = "bushel (US dry) per minute",
        Symbol = "bu (US dry)/min",
        CommonCode = "J70",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0005873178m,
    };
    public static IConvertibleUnit BushelUSDryPerSecond = new ConvertibleUnit()
    {
        Name = "bushel (US dry) per second",
        Symbol = "bu (US dry)/s",
        CommonCode = "J71",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.03523907m,
    };
    public static IConvertibleUnit CentinewtonMetre = new ConvertibleUnit()
    {
        Name = "centinewton metre",
        Symbol = "cN·m",
        CommonCode = "J72",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit CentipoisePerKelvin = new ConvertibleUnit()
    {
        Name = "centipoise per kelvin",
        Symbol = "cP/K",
        CommonCode = "J73",
        ConversionGroup = "pascal * second / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CentipoisePerBar = new ConvertibleUnit()
    {
        Name = "centipoise per bar",
        Symbol = "cP/bar",
        CommonCode = "J74",
        ConversionGroup = "second",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit CalorieMean = new ConvertibleUnit()
    {
        Name = "calorie (mean)",
        Symbol = "cal",
        CommonCode = "J75",
        ConversionGroup = "joule",
        ConversionFactor = 4.19002m,
    };
    public static IConvertibleUnit CalorieInternationalTablePerGramDegreeCelsius = new ConvertibleUnit()
    {
        Name = "calorie (international table) per gram degree Celsius",
        Symbol = "calIT/(g·°C)",
        CommonCode = "J76",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4186.8m,
    };
    public static IConvertibleUnit CalorieThermochemicalPerCentimetreSecondDegreeCelsius = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per centimetre second degree Celsius",
        Symbol = "calth/(cm·s·°C)",
        CommonCode = "J78",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 418.40000000000003m,
    };
    public static IConvertibleUnit CalorieThermochemicalPerGramDegreeCelsius = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per gram degree Celsius",
        Symbol = "calth/(g·°C)",
        CommonCode = "J79",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4184.0m,
    };
    public static IConvertibleUnit CalorieThermochemicalPerMinute = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per minute",
        Symbol = "calth/min",
        CommonCode = "J81",
        ConversionGroup = "watt",
        ConversionFactor = 0.06973333000000001m,
    };
    public static IConvertibleUnit CalorieThermochemicalPerSecond = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per second",
        Symbol = "calth/s",
        CommonCode = "J82",
        ConversionGroup = "watt",
        ConversionFactor = 4.184m,
    };
    public static IConvertibleUnit Clo = new ConvertibleUnit()
    {
        Name = "clo",
        Symbol = "clo",
        CommonCode = "J83",
        ConversionGroup = "kelvin * meter ** 2 / watt",
        ConversionFactor = 0.155m,
    };
    public static IConvertibleUnit CentimetrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "centimetre per second kelvin",
        Symbol = "(cm/s)/K",
        CommonCode = "J84",
        ConversionGroup = "meter / kelvin / second",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit CentimetrePerSecondBar = new ConvertibleUnit()
    {
        Name = "centimetre per second bar",
        Symbol = "(cm/s)/bar",
        CommonCode = "J85",
        ConversionGroup = "meter / pascal / second",
        ConversionFactor = 0.0000001m,
    };
    public static IConvertibleUnit CubicCentimetrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "cubic centimetre per cubic metre",
        Symbol = "cm³/m³",
        CommonCode = "J87",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit CubicDecimetrePerDay = new ConvertibleUnit()
    {
        Name = "cubic decimetre per day",
        Symbol = "dm³/d",
        CommonCode = "J90",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000115741m,
    };
    public static IConvertibleUnit CubicDecimetrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "cubic decimetre per cubic metre",
        Symbol = "dm³/m³",
        CommonCode = "J91",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit CubicDecimetrePerMinute = new ConvertibleUnit()
    {
        Name = "cubic decimetre per minute",
        Symbol = "dm³/min",
        CommonCode = "J92",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000166667m,
    };
    public static IConvertibleUnit CubicDecimetrePerSecond = new ConvertibleUnit()
    {
        Name = "cubic decimetre per second",
        Symbol = "dm³/s",
        CommonCode = "J93",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit OunceUKFluidPerDay = new ConvertibleUnit()
    {
        Name = "ounce (UK fluid) per day",
        Symbol = "fl oz (UK)/d",
        CommonCode = "J95",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000003288549m,
    };
    public static IConvertibleUnit OunceUKFluidPerHour = new ConvertibleUnit()
    {
        Name = "ounce (UK fluid) per hour",
        Symbol = "fl oz (UK)/h",
        CommonCode = "J96",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000007892517m,
    };
    public static IConvertibleUnit OunceUKFluidPerMinute = new ConvertibleUnit()
    {
        Name = "ounce (UK fluid) per minute",
        Symbol = "fl oz (UK)/min",
        CommonCode = "J97",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000004735509999999999m,
    };
    public static IConvertibleUnit OunceUKFluidPerSecond = new ConvertibleUnit()
    {
        Name = "ounce (UK fluid) per second",
        Symbol = "fl oz (UK)/s",
        CommonCode = "J98",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00002841306m,
    };
    public static IConvertibleUnit OunceUSFluidPerDay = new ConvertibleUnit()
    {
        Name = "ounce (US fluid) per day",
        Symbol = "fl oz (US)/d",
        CommonCode = "J99",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000003422862m,
    };
    public static IConvertibleUnit JoulePerKelvin = new ConvertibleUnit()
    {
        Name = "joule per kelvin",
        Symbol = "J/K",
        CommonCode = "JE",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MegajoulePerKilogram = new ConvertibleUnit()
    {
        Name = "megajoule per kilogram",
        Symbol = "MJ/kg",
        CommonCode = "JK",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit MegajoulePerCubicMetre = new ConvertibleUnit()
    {
        Name = "megajoule per cubic metre",
        Symbol = "MJ/m³",
        CommonCode = "JM",
        ConversionGroup = "joule / meter ** 3",
        ConversionFactor = 1000000.0m,
    };
    /// <summary>
    /// A count of the number of pipeline joints.
    /// </summary>
    public static IUnit PipelineJoint = new Unit()
    {
        Name = "pipeline joint",
        Symbol = null,
        CommonCode = "JNT",
    };
    public static IConvertibleUnit Joule = new ConvertibleUnit()
    {
        Name = "joule",
        Symbol = "J",
        CommonCode = "JOU",
        ConversionGroup = "joule",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of count defining the number of 100 metre lengths.
    /// </summary>
    public static IUnit HundredMetre = new Unit()
    {
        Name = "hundred metre",
        Symbol = null,
        CommonCode = "JPS",
    };
    /// <summary>
    /// A unit of count defining the number of jewels (jewel: precious stone).
    /// </summary>
    public static IUnit NumberOfJewels = new Unit()
    {
        Name = "number of jewels",
        Symbol = null,
        CommonCode = "JWL",
    };
    /// <summary>
    /// A unit of measure defining the power load measured at predetermined intervals.
    /// </summary>
    public static IUnit KilowattDemand = new Unit()
    {
        Name = "kilowatt demand",
        Symbol = null,
        CommonCode = "K1",
    };
    public static IConvertibleUnit OunceUSFluidPerHour = new ConvertibleUnit()
    {
        Name = "ounce (US fluid) per hour",
        Symbol = "fl oz (US)/h",
        CommonCode = "K10",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000008214869m,
    };
    public static IConvertibleUnit OunceUSFluidPerMinute = new ConvertibleUnit()
    {
        Name = "ounce (US fluid) per minute",
        Symbol = "fl oz (US)/min",
        CommonCode = "K11",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000004928922m,
    };
    public static IConvertibleUnit OunceUSFluidPerSecond = new ConvertibleUnit()
    {
        Name = "ounce (US fluid) per second",
        Symbol = "fl oz (US)/s",
        CommonCode = "K12",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000029573530000000003m,
    };
    public static IConvertibleUnit FootPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "foot per degree Fahrenheit",
        Symbol = "ft/°F",
        CommonCode = "K13",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 0.54864m,
    };
    public static IConvertibleUnit FootPerHour = new ConvertibleUnit()
    {
        Name = "foot per hour",
        Symbol = "ft/h",
        CommonCode = "K14",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.00008466667m,
    };
    public static IConvertibleUnit FootPoundforcePerHour = new ConvertibleUnit()
    {
        Name = "foot poundforce per hour",
        Symbol = "ft·lbf/h",
        CommonCode = "K15",
        ConversionGroup = "watt",
        ConversionFactor = 0.0003766161m,
    };
    public static IConvertibleUnit FootPoundforcePerMinute = new ConvertibleUnit()
    {
        Name = "foot poundforce per minute",
        Symbol = "ft·lbf/min",
        CommonCode = "K16",
        ConversionGroup = "watt",
        ConversionFactor = 0.02259697m,
    };
    public static IConvertibleUnit FootPerPsi = new ConvertibleUnit()
    {
        Name = "foot per psi",
        Symbol = "ft/psi",
        CommonCode = "K17",
        ConversionGroup = "meter / pascal",
        ConversionFactor = 0.0000442075m,
    };
    public static IConvertibleUnit FootPerSecondDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "foot per second degree Fahrenheit",
        Symbol = "(ft/s)/°F",
        CommonCode = "K18",
        ConversionGroup = "meter / kelvin / second",
        ConversionFactor = 0.54864m,
    };
    public static IConvertibleUnit FootPerSecondPsi = new ConvertibleUnit()
    {
        Name = "foot per second psi",
        Symbol = "(ft/s)/psi",
        CommonCode = "K19",
        ConversionGroup = "meter / pascal / second",
        ConversionFactor = 0.0000442075m,
    };
    /// <summary>
    /// A unit of measure defining the reactive power demand equal to one kilovolt ampere of reactive power.
    /// </summary>
    public static IUnit KilovoltAmpereReactiveDemand = new Unit()
    {
        Name = "kilovolt ampere reactive demand",
        Symbol = null,
        CommonCode = "K2",
    };
    public static IConvertibleUnit ReciprocalCubicFoot = new ConvertibleUnit()
    {
        Name = "reciprocal cubic foot",
        Symbol = "1/ft³",
        CommonCode = "K20",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 35.31466m,
    };
    public static IConvertibleUnit CubicFootPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "cubic foot per degree Fahrenheit",
        Symbol = "ft³/°F",
        CommonCode = "K21",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 0.05097033m,
    };
    public static IConvertibleUnit CubicFootPerDay = new ConvertibleUnit()
    {
        Name = "cubic foot per day",
        Symbol = "ft³/d",
        CommonCode = "K22",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000003277413m,
    };
    public static IConvertibleUnit CubicFootPerPsi = new ConvertibleUnit()
    {
        Name = "cubic foot per psi",
        Symbol = "ft³/psi",
        CommonCode = "K23",
        ConversionGroup = "meter ** 3 / pascal",
        ConversionFactor = 0.000004107012m,
    };
    public static IConvertibleUnit GallonUKPerDay = new ConvertibleUnit()
    {
        Name = "gallon (UK) per day",
        Symbol = "gal (UK)/d",
        CommonCode = "K26",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000052616779999999997m,
    };
    public static IConvertibleUnit GallonUKPerHour = new ConvertibleUnit()
    {
        Name = "gallon (UK) per hour",
        Symbol = "gal (UK)/h",
        CommonCode = "K27",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000012628029999999999m,
    };
    public static IConvertibleUnit GallonUKPerSecond = new ConvertibleUnit()
    {
        Name = "gallon (UK) per second",
        Symbol = "gal (UK)/s",
        CommonCode = "K28",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.004546090000000001m,
    };
    /// <summary>
    /// A unit of measure defining the accumulated reactive energy equal to one kilovolt ampere of reactive power per hour.
    /// </summary>
    public static IUnit KilovoltAmpereReactiveHour = new Unit()
    {
        Name = "kilovolt ampere reactive hour",
        Symbol = "kvar·h",
        CommonCode = "K3",
    };
    public static IConvertibleUnit GallonUSLiquidPerSecond = new ConvertibleUnit()
    {
        Name = "gallon (US liquid) per second",
        Symbol = "gal (US liq.)/s",
        CommonCode = "K30",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.003785412m,
    };
    public static IConvertibleUnit GramforcePerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "gramforce per square centimetre",
        Symbol = "gf/cm²",
        CommonCode = "K31",
        ConversionGroup = "pascal",
        ConversionFactor = 98.0665m,
    };
    public static IConvertibleUnit GillUKPerDay = new ConvertibleUnit()
    {
        Name = "gill (UK) per day",
        Symbol = "gi (UK)/d",
        CommonCode = "K32",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00001644274m,
    };
    public static IConvertibleUnit GillUKPerHour = new ConvertibleUnit()
    {
        Name = "gill (UK) per hour",
        Symbol = "gi (UK)/h",
        CommonCode = "K33",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000003946258m,
    };
    public static IConvertibleUnit GillUKPerMinute = new ConvertibleUnit()
    {
        Name = "gill (UK) per minute",
        Symbol = "gi (UK)/min",
        CommonCode = "K34",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.02367755m,
    };
    public static IConvertibleUnit GillUKPerSecond = new ConvertibleUnit()
    {
        Name = "gill (UK) per second",
        Symbol = "gi (UK)/s",
        CommonCode = "K35",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0001420653m,
    };
    public static IConvertibleUnit GillUSPerDay = new ConvertibleUnit()
    {
        Name = "gill (US) per day",
        Symbol = "gi (US)/d",
        CommonCode = "K36",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000013691450000000002m,
    };
    public static IConvertibleUnit GillUSPerHour = new ConvertibleUnit()
    {
        Name = "gill (US) per hour",
        Symbol = "gi (US)/h",
        CommonCode = "K37",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000003285947m,
    };
    public static IConvertibleUnit GillUSPerMinute = new ConvertibleUnit()
    {
        Name = "gill (US) per minute",
        Symbol = "gi (US)/min",
        CommonCode = "K38",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000001971568m,
    };
    public static IConvertibleUnit GillUSPerSecond = new ConvertibleUnit()
    {
        Name = "gill (US) per second",
        Symbol = "gi (US)/s",
        CommonCode = "K39",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00011829410000000001m,
    };
    public static IConvertibleUnit StandardAccelerationOfFreeFall = new ConvertibleUnit()
    {
        Name = "standard acceleration of free fall",
        Symbol = "gn",
        CommonCode = "K40",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 9.80665m,
    };
    public static IConvertibleUnit GrainPerGallonUS = new ConvertibleUnit()
    {
        Name = "grain per gallon (US)",
        Symbol = "gr/gal (US)",
        CommonCode = "K41",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.01711806m,
    };
    public static IConvertibleUnit HorsepowerBoiler = new ConvertibleUnit()
    {
        Name = "horsepower (boiler)",
        Symbol = "boiler hp",
        CommonCode = "K42",
        ConversionGroup = "watt",
        ConversionFactor = 9809.5m,
    };
    public static IConvertibleUnit HorsepowerElectric = new ConvertibleUnit()
    {
        Name = "horsepower (electric)",
        Symbol = "electric hp",
        CommonCode = "K43",
        ConversionGroup = "watt",
        ConversionFactor = 746m,
    };
    public static IConvertibleUnit InchPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "inch per degree Fahrenheit",
        Symbol = "in/°F",
        CommonCode = "K45",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 0.045720000000000004m,
    };
    public static IConvertibleUnit InchPerPsi = new ConvertibleUnit()
    {
        Name = "inch per psi",
        Symbol = "in/psi",
        CommonCode = "K46",
        ConversionGroup = "meter / pascal",
        ConversionFactor = 0.000003683959m,
    };
    public static IConvertibleUnit InchPerSecondDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "inch per second degree Fahrenheit",
        Symbol = "(in/s)/°F",
        CommonCode = "K47",
        ConversionGroup = "meter / kelvin / second",
        ConversionFactor = 0.045720000000000004m,
    };
    public static IConvertibleUnit InchPerSecondPsi = new ConvertibleUnit()
    {
        Name = "inch per second psi",
        Symbol = "(in/s)/psi",
        CommonCode = "K48",
        ConversionGroup = "meter / pascal / second",
        ConversionFactor = 0.000003683959m,
    };
    public static IConvertibleUnit ReciprocalCubicInch = new ConvertibleUnit()
    {
        Name = "reciprocal cubic inch",
        Symbol = "1/in³",
        CommonCode = "K49",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 61023.759000000005m,
    };
    /// <summary>
    /// A unit of signal transmission speed equal to 10³ (1000) signaling events per second.
    /// </summary>
    public static IConvertibleUnit Kilobaud = new ConvertibleUnit()
    {
        Name = "kilobaud",
        Symbol = "kBd",
        CommonCode = "K50",
        ConversionGroup = "baud",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilocalorieMean = new ConvertibleUnit()
    {
        Name = "kilocalorie (mean)",
        Symbol = "kcal",
        CommonCode = "K51",
        ConversionGroup = "joule",
        ConversionFactor = 4190.0199999999995m,
    };
    public static IConvertibleUnit KilocalorieInternationalTablePerHourMetreDegreeCelsius = new ConvertibleUnit()
    {
        Name = "kilocalorie (international table) per hour metre degree Celsius",
        Symbol = "kcal/(m·h·°C)",
        CommonCode = "K52",
        ConversionGroup = "joule / kelvin / meter / second",
        ConversionFactor = 1.163m,
    };
    public static IConvertibleUnit KilocalorieThermochemical = new ConvertibleUnit()
    {
        Name = "kilocalorie (thermochemical)",
        Symbol = "kcalth",
        CommonCode = "K53",
        ConversionGroup = "joule",
        ConversionFactor = 4184.0m,
    };
    public static IConvertibleUnit KilocalorieThermochemicalPerMinute = new ConvertibleUnit()
    {
        Name = "kilocalorie (thermochemical) per minute",
        Symbol = "kcalth/min",
        CommonCode = "K54",
        ConversionGroup = "watt",
        ConversionFactor = 69.73333m,
    };
    public static IConvertibleUnit KilocalorieThermochemicalPerSecond = new ConvertibleUnit()
    {
        Name = "kilocalorie (thermochemical) per second",
        Symbol = "kcalth/s",
        CommonCode = "K55",
        ConversionGroup = "watt",
        ConversionFactor = 4184.0m,
    };
    public static IConvertibleUnit KilomolePerHour = new ConvertibleUnit()
    {
        Name = "kilomole per hour",
        Symbol = "kmol/h",
        CommonCode = "K58",
        ConversionGroup = "mole / second",
        ConversionFactor = 0.277778m,
    };
    public static IConvertibleUnit KilomolePerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "kilomole per cubic metre kelvin",
        Symbol = "(kmol/m³)/K",
        CommonCode = "K59",
        ConversionGroup = "mole / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit Kilolitre = new ConvertibleUnit()
    {
        Name = "kilolitre",
        Symbol = "kl",
        CommonCode = "K6",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KilomolePerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "kilomole per cubic metre bar",
        Symbol = "(kmol/m³)/bar",
        CommonCode = "K60",
        ConversionGroup = "mole / meter ** 3 / pascal",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit KilomolePerMinute = new ConvertibleUnit()
    {
        Name = "kilomole per minute",
        Symbol = "kmol/min",
        CommonCode = "K61",
        ConversionGroup = "mole / second",
        ConversionFactor = 16.6667m,
    };
    public static IConvertibleUnit LitrePerLitre = new ConvertibleUnit()
    {
        Name = "litre per litre",
        Symbol = "l/l",
        CommonCode = "K62",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit ReciprocalLitre = new ConvertibleUnit()
    {
        Name = "reciprocal litre",
        Symbol = "1/l",
        CommonCode = "K63",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per degree Fahrenheit",
        Symbol = "lb/°F",
        CommonCode = "K64",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 0.8164663m,
    };
    public static IConvertibleUnit PoundAvoirdupoisSquareFoot = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) square foot",
        Symbol = "lb·ft²",
        CommonCode = "K65",
        ConversionGroup = "kilogram * meter ** 2",
        ConversionFactor = 0.04214011m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerDay = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per day",
        Symbol = "lb/d",
        CommonCode = "K66",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000005249912m,
    };
    public static IConvertibleUnit PoundPerFootHour = new ConvertibleUnit()
    {
        Name = "pound per foot hour",
        Symbol = "lb/(ft·h)",
        CommonCode = "K67",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.00041337890000000003m,
    };
    public static IConvertibleUnit PoundPerFootSecond = new ConvertibleUnit()
    {
        Name = "pound per foot second",
        Symbol = "lb/(ft·s)",
        CommonCode = "K68",
        ConversionGroup = "pascal * second",
        ConversionFactor = 1.488164m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerCubicFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per cubic foot degree Fahrenheit",
        Symbol = "(lb/ft³)/°F",
        CommonCode = "K69",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 28.83323m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerCubicFootPsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per cubic foot psi",
        Symbol = "(lb/ft³)/psi",
        CommonCode = "K70",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.002323282m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerGallonUK = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per gallon (UK)",
        Symbol = "lb/gal (UK)",
        CommonCode = "K71",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 99.77637m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerHourDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per hour degree Fahrenheit",
        Symbol = "(lb/h)/°F",
        CommonCode = "K73",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0002267962m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerHourPsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per hour psi",
        Symbol = "(lb/h)/psi",
        CommonCode = "K74",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.00000001827445m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerCubicInchDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per cubic inch degree Fahrenheit",
        Symbol = "(lb/in³)/°F",
        CommonCode = "K75",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 49823.84m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerCubicInchPsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per cubic inch psi",
        Symbol = "(lb/in³)/psi",
        CommonCode = "K76",
        ConversionGroup = "kilogram / meter ** 3 / pascal",
        ConversionFactor = 4.014632m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerPsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per psi",
        Symbol = "lb/psi",
        CommonCode = "K77",
        ConversionGroup = "kilogram / pascal",
        ConversionFactor = 0.00006578802m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerMinute = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per minute",
        Symbol = "lb/min",
        CommonCode = "K78",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.007559873m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerMinuteDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per minute degree Fahrenheit",
        Symbol = "lb/(min·°F)",
        CommonCode = "K79",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.01360777m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerMinutePsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per minute psi",
        Symbol = "(lb/min)/psi",
        CommonCode = "K80",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.000001096467m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerSecond = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per second",
        Symbol = "lb/s",
        CommonCode = "K81",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.4535924m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerSecondDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per second degree Fahrenheit",
        Symbol = "(lb/s)/°F",
        CommonCode = "K82",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.8164663m,
    };
    public static IConvertibleUnit PoundAvoirdupoisPerSecondPsi = new ConvertibleUnit()
    {
        Name = "pound (avoirdupois) per second psi",
        Symbol = "(lb/s)/psi",
        CommonCode = "K83",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.00006578802m,
    };
    public static IConvertibleUnit PoundPerCubicYard = new ConvertibleUnit()
    {
        Name = "pound per cubic yard",
        Symbol = "lb/yd³",
        CommonCode = "K84",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.5932764m,
    };
    public static IConvertibleUnit PoundforcePerSquareFoot = new ConvertibleUnit()
    {
        Name = "poundforce per square foot",
        Symbol = "lbf/ft²",
        CommonCode = "K85",
        ConversionGroup = "pascal",
        ConversionFactor = 47.88026m,
    };
    public static IConvertibleUnit PoundforcePerSquareInchDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "poundforce per square inch degree Fahrenheit",
        Symbol = "psi/°F",
        CommonCode = "K86",
        ConversionGroup = "pascal / kelvin",
        ConversionFactor = 12410.56m,
    };
    public static IConvertibleUnit PsiCubicInchPerSecond = new ConvertibleUnit()
    {
        Name = "psi cubic inch per second",
        Symbol = "psi·in³/s",
        CommonCode = "K87",
        ConversionGroup = "meter ** 3 * pascal / second",
        ConversionFactor = 0.112985m,
    };
    public static IConvertibleUnit PsiLitrePerSecond = new ConvertibleUnit()
    {
        Name = "psi litre per second",
        Symbol = "psi·l/s",
        CommonCode = "K88",
        ConversionGroup = "meter ** 3 * pascal / second",
        ConversionFactor = 6.894757m,
    };
    public static IConvertibleUnit PsiCubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "psi cubic metre per second",
        Symbol = "psi·m³/s",
        CommonCode = "K89",
        ConversionGroup = "meter ** 3 * pascal / second",
        ConversionFactor = 6894.7570000000005m,
    };
    public static IConvertibleUnit PsiCubicYardPerSecond = new ConvertibleUnit()
    {
        Name = "psi cubic yard per second",
        Symbol = "psi·yd³/s",
        CommonCode = "K90",
        ConversionGroup = "meter ** 3 * pascal / second",
        ConversionFactor = 5271.42m,
    };
    public static IConvertibleUnit PoundforceSecondPerSquareFoot = new ConvertibleUnit()
    {
        Name = "poundforce second per square foot",
        Symbol = "lbf·s/ft²",
        CommonCode = "K91",
        ConversionGroup = "pascal * second",
        ConversionFactor = 47.88026m,
    };
    public static IConvertibleUnit PoundforceSecondPerSquareInch = new ConvertibleUnit()
    {
        Name = "poundforce second per square inch",
        Symbol = "lbf·s/in²",
        CommonCode = "K92",
        ConversionGroup = "pascal * second",
        ConversionFactor = 6894.7570000000005m,
    };
    public static IConvertibleUnit ReciprocalPsi = new ConvertibleUnit()
    {
        Name = "reciprocal psi",
        Symbol = "1/psi",
        CommonCode = "K93",
        ConversionGroup = "1 / pascal",
        ConversionFactor = 0.0001450377m,
    };
    public static IConvertibleUnit QuartUKLiquidPerDay = new ConvertibleUnit()
    {
        Name = "quart (UK liquid) per day",
        Symbol = "qt (UK liq.)/d",
        CommonCode = "K94",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000131542m,
    };
    public static IConvertibleUnit QuartUKLiquidPerHour = new ConvertibleUnit()
    {
        Name = "quart (UK liquid) per hour",
        Symbol = "qt (UK liq.)/h",
        CommonCode = "K95",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000003157008m,
    };
    public static IConvertibleUnit QuartUKLiquidPerMinute = new ConvertibleUnit()
    {
        Name = "quart (UK liquid) per minute",
        Symbol = "qt (UK liq.)/min",
        CommonCode = "K96",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00001894205m,
    };
    public static IConvertibleUnit QuartUKLiquidPerSecond = new ConvertibleUnit()
    {
        Name = "quart (UK liquid) per second",
        Symbol = "qt (UK liq.)/s",
        CommonCode = "K97",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.001136523m,
    };
    public static IConvertibleUnit QuartUSLiquidPerDay = new ConvertibleUnit()
    {
        Name = "quart (US liquid) per day",
        Symbol = "qt (US liq.)/d",
        CommonCode = "K98",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000001095316m,
    };
    public static IConvertibleUnit QuartUSLiquidPerHour = new ConvertibleUnit()
    {
        Name = "quart (US liquid) per hour",
        Symbol = "qt (US liq.)/h",
        CommonCode = "K99",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000002628758m,
    };
    /// <summary>
    /// A unit of count defining the number of cakes (cake: object shaped into a flat, compact mass).
    /// </summary>
    public static IUnit Cake = new Unit()
    {
        Name = "cake",
        Symbol = null,
        CommonCode = "KA",
    };
    /// <summary>
    /// A unit of catalytic activity defining the catalytic activity of enzymes and other catalysts.
    /// </summary>
    public static IConvertibleUnit Katal = new ConvertibleUnit()
    {
        Name = "katal",
        Symbol = "kat",
        CommonCode = "KAT",
        ConversionGroup = "mole / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information equal to 10³ (1000) characters.
    /// </summary>
    public static IUnit Kilocharacter = new Unit()
    {
        Name = "kilocharacter",
        Symbol = null,
        CommonCode = "KB",
    };
    public static IConvertibleUnit Kilobar = new ConvertibleUnit()
    {
        Name = "kilobar",
        Symbol = "kbar",
        CommonCode = "KBA",
        ConversionGroup = "pascal",
        ConversionFactor = 100000000m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of choline chloride.
    /// </summary>
    public static IUnit KilogramOfCholineChloride = new Unit()
    {
        Name = "kilogram of choline chloride",
        Symbol = "kg C₅ H₁₄ClNO",
        CommonCode = "KCC",
    };
    /// <summary>
    /// A unit of mass defining the net number of kilograms of a product, disregarding the liquid content of the product.
    /// </summary>
    public static IUnit KilogramDrainedNetWeight = new Unit()
    {
        Name = "kilogram drained net weight",
        Symbol = "kg/net eda",
        CommonCode = "KDW",
    };
    /// <summary>
    /// Refer ISO 80000-5 (Quantities and units — Part 5: Thermodynamics)
    /// </summary>
    public static IConvertibleUnit Kelvin = new ConvertibleUnit()
    {
        Name = "kelvin",
        Symbol = "K",
        CommonCode = "KEL",
        ConversionGroup = "kelvin",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams.
    /// </summary>
    public static IConvertibleUnit Kilogram = new ConvertibleUnit()
    {
        Name = "kilogram",
        Symbol = "kg",
        CommonCode = "KGM",
        ConversionGroup = "kilogram",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit KilogramPerSecond = new ConvertibleUnit()
    {
        Name = "kilogram per second",
        Symbol = "kg/s",
        CommonCode = "KGS",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of hydrogen peroxide.
    /// </summary>
    public static IUnit KilogramOfHydrogenPeroxide = new Unit()
    {
        Name = "kilogram of hydrogen peroxide",
        Symbol = "kg H₂O₂",
        CommonCode = "KHY",
    };
    public static IConvertibleUnit Kilohertz = new ConvertibleUnit()
    {
        Name = "kilohertz",
        Symbol = "kHz",
        CommonCode = "KHZ",
        ConversionGroup = "hertz",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilogramPerMillimetreWidth = new ConvertibleUnit()
    {
        Name = "kilogram per millimetre width",
        Symbol = null,
        CommonCode = "KI",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// A unit of mass defining the number of kilograms of a product, including its container.
    /// </summary>
    public static IUnit KilogramIncludingContainer = new Unit()
    {
        Name = "kilogram, including container",
        Symbol = null,
        CommonCode = "KIC",
    };
    /// <summary>
    /// A unit of mass defining the number of kilograms of a product, including its inner packaging materials.
    /// </summary>
    public static IUnit KilogramIncludingInnerPackaging = new Unit()
    {
        Name = "kilogram, including inner packaging",
        Symbol = null,
        CommonCode = "KIP",
    };
    /// <summary>
    /// A unit of information equal to 10³ (1000) segments.
    /// </summary>
    public static IUnit Kilosegment = new Unit()
    {
        Name = "kilosegment",
        Symbol = null,
        CommonCode = "KJ",
    };
    public static IConvertibleUnit Kilojoule = new ConvertibleUnit()
    {
        Name = "kilojoule",
        Symbol = "kJ",
        CommonCode = "KJO",
        ConversionGroup = "joule",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilogramPerMetre = new ConvertibleUnit()
    {
        Name = "kilogram per metre",
        Symbol = "kg/m",
        CommonCode = "KL",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of proportion defining the percentage of dry lactic material in a product.
    /// </summary>
    public static IUnit LacticDryMaterialPercentage = new Unit()
    {
        Name = "lactic dry material percentage",
        Symbol = null,
        CommonCode = "KLK",
    };
    /// <summary>
    /// A unit of illuminance equal to one thousand lux.
    /// </summary>
    public static IConvertibleUnit Kilolux = new ConvertibleUnit()
    {
        Name = "kilolux",
        Symbol = "klx",
        CommonCode = "KLX",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of methylamine.
    /// </summary>
    public static IUnit KilogramOfMethylamine = new Unit()
    {
        Name = "kilogram of methylamine",
        Symbol = "kg met.am.",
        CommonCode = "KMA",
    };
    public static IConvertibleUnit KilometrePerHour = new ConvertibleUnit()
    {
        Name = "kilometre per hour",
        Symbol = "km/h",
        CommonCode = "KMH",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.277778m,
    };
    public static IConvertibleUnit SquareKilometre = new ConvertibleUnit()
    {
        Name = "square kilometre",
        Symbol = "km²",
        CommonCode = "KMK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of weight expressed in kilograms of a substance that fills a volume of one cubic metre.
    /// </summary>
    public static IConvertibleUnit KilogramPerCubicMetre = new ConvertibleUnit()
    {
        Name = "kilogram per cubic metre",
        Symbol = "kg/m³",
        CommonCode = "KMQ",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Kilometre = new ConvertibleUnit()
    {
        Name = "kilometre",
        Symbol = "km",
        CommonCode = "KMT",
        ConversionGroup = "meter",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of nitrogen.
    /// </summary>
    public static IUnit KilogramOfNitrogen = new Unit()
    {
        Name = "kilogram of nitrogen",
        Symbol = "kg N",
        CommonCode = "KNI",
    };
    /// <summary>
    /// Pressure expressed in kN/m2.
    /// </summary>
    public static IConvertibleUnit KilonewtonPerSquareMetre = new ConvertibleUnit()
    {
        Name = "kilonewton per square metre",
        Symbol = "kN/m2",
        CommonCode = "KNM",
        ConversionGroup = "pascal",
        ConversionFactor = 103m,
    };
    /// <summary>
    /// A unit of mass equal to one kilogram of a named substance.
    /// </summary>
    public static IUnit KilogramNamedSubstance = new Unit()
    {
        Name = "kilogram named substance",
        Symbol = null,
        CommonCode = "KNS",
    };
    public static IConvertibleUnit Knot = new ConvertibleUnit()
    {
        Name = "knot",
        Symbol = "kn",
        CommonCode = "KNT",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.514444m,
    };
    /// <summary>
    /// A unit of count defining the number of milligrams of potassium hydroxide per gram of product as a measure of the concentration of potassium hydroxide in the product.
    /// </summary>
    public static IUnit MilliequivalenceCausticPotashPerGramOfProduct = new Unit()
    {
        Name = "milliequivalence caustic potash per gram of product",
        Symbol = null,
        CommonCode = "KO",
    };
    public static IConvertibleUnit Kilopascal = new ConvertibleUnit()
    {
        Name = "kilopascal",
        Symbol = "kPa",
        CommonCode = "KPA",
        ConversionGroup = "pascal",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of potassium hydroxide (caustic potash).
    /// </summary>
    public static IUnit KilogramOfPotassiumHydroxideCausticPotash = new Unit()
    {
        Name = "kilogram of potassium hydroxide (caustic potash)",
        Symbol = "kg KOH",
        CommonCode = "KPH",
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of potassium oxide.
    /// </summary>
    public static IUnit KilogramOfPotassiumOxide = new Unit()
    {
        Name = "kilogram of potassium oxide",
        Symbol = "kg K₂O",
        CommonCode = "KPO",
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of phosphorus pentoxide phosphoric anhydride.
    /// </summary>
    public static IUnit KilogramOfPhosphorusPentoxidePhosphoricAnhydride = new Unit()
    {
        Name = "kilogram of phosphorus pentoxide (phosphoric anhydride)",
        Symbol = null,
        CommonCode = "KPP",
    };
    public static IConvertibleUnit Kiloroentgen = new ConvertibleUnit()
    {
        Name = "kiloroentgen",
        Symbol = "kR",
        CommonCode = "KR",
        ConversionGroup = "coulomb / kilogram",
        ConversionFactor = 0.258m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of a named substance that is 90% dry.
    /// </summary>
    public static IUnit KilogramOfSubstance90Dry = new Unit()
    {
        Name = "kilogram of substance 90 % dry",
        Symbol = "kg 90 % sdt",
        CommonCode = "KSD",
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of sodium hydroxide (caustic soda).
    /// </summary>
    public static IUnit KilogramOfSodiumHydroxideCausticSoda = new Unit()
    {
        Name = "kilogram of sodium hydroxide (caustic soda)",
        Symbol = "kg NaOH",
        CommonCode = "KSH",
    };
    /// <summary>
    /// A unit of count defining the number of kits (kit: tub, barrel or pail).
    /// </summary>
    public static IUnit KitKT = new Unit()
    {
        Name = "kit",
        Symbol = null,
        CommonCode = "KT",
    };
    /// <summary>
    /// A set of articles or implements used for a specific purpose.
    /// </summary>
    public static IUnit KitXKI = new Unit()
    {
        Name = "Kit",
        Symbol = null,
        CommonCode = "XKI",
    };
    public static IConvertibleUnit Kilotonne = new ConvertibleUnit()
    {
        Name = "kilotonne",
        Symbol = "kt",
        CommonCode = "KTN",
        ConversionGroup = "kilogram",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of uranium.
    /// </summary>
    public static IUnit KilogramOfUranium = new Unit()
    {
        Name = "kilogram of uranium",
        Symbol = "kg U",
        CommonCode = "KUR",
    };
    public static IConvertibleUnit KilovoltAmpere = new ConvertibleUnit()
    {
        Name = "kilovolt  ampere",
        Symbol = "kV·A",
        CommonCode = "KVA",
        ConversionGroup = "ampere * volt",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kilovar = new ConvertibleUnit()
    {
        Name = "kilovar",
        Symbol = "kvar",
        CommonCode = "KVR",
        ConversionGroup = "ampere * volt",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Kilovolt = new ConvertibleUnit()
    {
        Name = "kilovolt",
        Symbol = "kV",
        CommonCode = "KVT",
        ConversionGroup = "volt",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit KilogramPerMillimetre = new ConvertibleUnit()
    {
        Name = "kilogram per millimetre",
        Symbol = "kg/mm",
        CommonCode = "KW",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit KilowattHour = new ConvertibleUnit()
    {
        Name = "kilowatt hour",
        Symbol = "kW·h",
        CommonCode = "KWH",
        ConversionGroup = "joule",
        ConversionFactor = 3600000.0m,
    };
    /// <summary>
    /// killowatt year
    /// </summary>
    public static IUnit KilowattYear = new Unit()
    {
        Name = "kilowatt year",
        Symbol = "kW/year",
        CommonCode = "KWY",
    };
    /// <summary>
    /// Kilowatt hour per normalized cubic metre (temperature 0°C and pressure 1013.25 millibars ).
    /// </summary>
    public static IUnit KilowattHourPerNormalizedCubicMetre = new Unit()
    {
        Name = "Kilowatt hour per normalized cubic metre",
        Symbol = null,
        CommonCode = "KWN",
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of tungsten trioxide.
    /// </summary>
    public static IUnit KilogramOfTungstenTrioxide = new Unit()
    {
        Name = "kilogram of tungsten trioxide",
        Symbol = "kg WO₃",
        CommonCode = "KWO",
    };
    /// <summary>
    /// Kilowatt hour per standard cubic metre (temperature 15°C and pressure 1013.25 millibars).
    /// </summary>
    public static IUnit KilowattHourPerStandardCubicMetre = new Unit()
    {
        Name = "Kilowatt hour per standard cubic metre",
        Symbol = null,
        CommonCode = "KWS",
    };
    public static IConvertibleUnit Kilowatt = new ConvertibleUnit()
    {
        Name = "kilowatt",
        Symbol = "kW",
        CommonCode = "KWT",
        ConversionGroup = "watt",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit MillilitrePerKilogram = new ConvertibleUnit()
    {
        Name = "millilitre per kilogram",
        Symbol = "ml/kg",
        CommonCode = "KX",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit QuartUSLiquidPerMinute = new ConvertibleUnit()
    {
        Name = "quart (US liquid) per minute",
        Symbol = "qt (US liq.)/min",
        CommonCode = "L10",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000015772550000000002m,
    };
    public static IConvertibleUnit QuartUSLiquidPerSecond = new ConvertibleUnit()
    {
        Name = "quart (US liquid) per second",
        Symbol = "qt (US liq.)/s",
        CommonCode = "L11",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0009463529m,
    };
    public static IConvertibleUnit MetrePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "metre per second kelvin",
        Symbol = "(m/s)/K",
        CommonCode = "L12",
        ConversionGroup = "meter / kelvin / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MetrePerSecondBar = new ConvertibleUnit()
    {
        Name = "metre per second bar",
        Symbol = "(m/s)/bar",
        CommonCode = "L13",
        ConversionGroup = "meter / pascal / second",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit SquareMetreHourDegreeCelsiusPerKilocalorieInternationalTable = new ConvertibleUnit()
    {
        Name = "square metre hour degree Celsius per kilocalorie (international table)",
        Symbol = "m²·h·°C/kcal",
        CommonCode = "L14",
        ConversionGroup = "kelvin * meter ** 2 * second / joule",
        ConversionFactor = 0.8598452m,
    };
    public static IConvertibleUnit MillipascalSecondPerKelvin = new ConvertibleUnit()
    {
        Name = "millipascal second per kelvin",
        Symbol = "mPa·s/K",
        CommonCode = "L15",
        ConversionGroup = "pascal * second / kelvin",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit MillipascalSecondPerBar = new ConvertibleUnit()
    {
        Name = "millipascal second per bar",
        Symbol = "mPa·s/bar",
        CommonCode = "L16",
        ConversionGroup = "second",
        ConversionFactor = 0.00000001m,
    };
    public static IConvertibleUnit MilligramPerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "milligram per cubic metre kelvin",
        Symbol = "(mg/m³)/K",
        CommonCode = "L17",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit MilligramPerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "milligram per cubic metre bar",
        Symbol = "(mg/m³)/bar",
        CommonCode = "L18",
        ConversionGroup = "kilogram / meter ** 3 / pascal",
        ConversionFactor = 0.00000000001m,
    };
    public static IConvertibleUnit MillilitrePerLitre = new ConvertibleUnit()
    {
        Name = "millilitre per litre",
        Symbol = "ml/l",
        CommonCode = "L19",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit LitrePerMinute = new ConvertibleUnit()
    {
        Name = "litre per minute",
        Symbol = "l/min",
        CommonCode = "L2",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000166667m,
    };
    public static IConvertibleUnit ReciprocalCubicMillimetre = new ConvertibleUnit()
    {
        Name = "reciprocal cubic millimetre",
        Symbol = "1/mm³",
        CommonCode = "L20",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 1000000000.0m,
    };
    public static IConvertibleUnit CubicMillimetrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "cubic millimetre per cubic metre",
        Symbol = "mm³/m³",
        CommonCode = "L21",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit MolePerHour = new ConvertibleUnit()
    {
        Name = "mole per hour",
        Symbol = "mol/h",
        CommonCode = "L23",
        ConversionGroup = "mole / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit MolePerKilogramKelvin = new ConvertibleUnit()
    {
        Name = "mole per kilogram kelvin",
        Symbol = "(mol/kg)/K",
        CommonCode = "L24",
        ConversionGroup = "mole / kelvin / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MolePerKilogramBar = new ConvertibleUnit()
    {
        Name = "mole per kilogram bar",
        Symbol = "(mol/kg)/bar",
        CommonCode = "L25",
        ConversionGroup = "mole / kilogram / pascal",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MolePerLitreKelvin = new ConvertibleUnit()
    {
        Name = "mole per litre kelvin",
        Symbol = "(mol/l)/K",
        CommonCode = "L26",
        ConversionGroup = "mole / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MolePerLitreBar = new ConvertibleUnit()
    {
        Name = "mole per litre bar",
        Symbol = "(mol/l)/bar",
        CommonCode = "L27",
        ConversionGroup = "mole / meter ** 3 / pascal",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit MolePerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "mole per cubic metre kelvin",
        Symbol = "(mol/m³)/K",
        CommonCode = "L28",
        ConversionGroup = "mole / kelvin / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MolePerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "mole per cubic metre bar",
        Symbol = "(mol/m³)/bar",
        CommonCode = "L29",
        ConversionGroup = "mole / meter ** 3 / pascal",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit MolePerMinute = new ConvertibleUnit()
    {
        Name = "mole per minute",
        Symbol = "mol/min",
        CommonCode = "L30",
        ConversionGroup = "mole / second",
        ConversionFactor = 0.016666700000000003m,
    };
    public static IConvertibleUnit MilliroentgenAequivalentMen = new ConvertibleUnit()
    {
        Name = "milliroentgen aequivalent men",
        Symbol = "mrem",
        CommonCode = "L31",
        ConversionGroup = "sievert",
        ConversionFactor = 0.00001m,
    };
    public static IConvertibleUnit NanogramPerKilogram = new ConvertibleUnit()
    {
        Name = "nanogram per kilogram",
        Symbol = "ng/kg",
        CommonCode = "L32",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerDay = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per day",
        Symbol = "oz/d",
        CommonCode = "L33",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0000003281194m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerHour = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per hour",
        Symbol = "oz/h",
        CommonCode = "L34",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000007874867m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerMinute = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per minute",
        Symbol = "oz/min",
        CommonCode = "L35",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.00047249200000000003m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerSecond = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per second",
        Symbol = "oz/s",
        CommonCode = "L36",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.02834952m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerGallonUK = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per gallon (UK)",
        Symbol = "oz/gal (UK)",
        CommonCode = "L37",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 6.236023m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerGallonUS = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per gallon (US)",
        Symbol = "oz/gal (US)",
        CommonCode = "L38",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 7.489152m,
    };
    public static IConvertibleUnit OunceAvoirdupoisPerCubicInch = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per cubic inch",
        Symbol = "oz/in³",
        CommonCode = "L39",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1729.9940000000001m,
    };
    public static IConvertibleUnit OunceAvoirdupoisForce = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois)force",
        Symbol = "ozf",
        CommonCode = "L40",
        ConversionGroup = "newton",
        ConversionFactor = 0.2780139m,
    };
    public static IConvertibleUnit OunceAvoirdupoisForceInch = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois)force inch",
        Symbol = "ozf·in",
        CommonCode = "L41",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.007061552m,
    };
    public static IConvertibleUnit PicosiemensPerMetre = new ConvertibleUnit()
    {
        Name = "picosiemens per metre",
        Symbol = "pS/m",
        CommonCode = "L42",
        ConversionGroup = "siemens / meter",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit PeckUK = new ConvertibleUnit()
    {
        Name = "peck (UK)",
        Symbol = "pk (UK)",
        CommonCode = "L43",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.009092181m,
    };
    public static IConvertibleUnit PeckUKPerDay = new ConvertibleUnit()
    {
        Name = "peck (UK) per day",
        Symbol = "pk (UK)/d",
        CommonCode = "L44",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00000010523359999999999m,
    };
    public static IConvertibleUnit PeckUKPerHour = new ConvertibleUnit()
    {
        Name = "peck (UK) per hour",
        Symbol = "pk (UK)/h",
        CommonCode = "L45",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000025256059999999998m,
    };
    public static IConvertibleUnit PeckUKPerMinute = new ConvertibleUnit()
    {
        Name = "peck (UK) per minute",
        Symbol = "pk (UK)/min",
        CommonCode = "L46",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00015153635m,
    };
    public static IConvertibleUnit PeckUKPerSecond = new ConvertibleUnit()
    {
        Name = "peck (UK) per second",
        Symbol = "pk (UK)/s",
        CommonCode = "L47",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.009092181m,
    };
    public static IConvertibleUnit PeckUSDryPerDay = new ConvertibleUnit()
    {
        Name = "peck (US dry) per day",
        Symbol = "pk (US dry)/d",
        CommonCode = "L48",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000001019649m,
    };
    public static IConvertibleUnit PeckUSDryPerHour = new ConvertibleUnit()
    {
        Name = "peck (US dry) per hour",
        Symbol = "pk (US dry)/h",
        CommonCode = "L49",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000024471579999999997m,
    };
    public static IConvertibleUnit PeckUSDryPerMinute = new ConvertibleUnit()
    {
        Name = "peck (US dry) per minute",
        Symbol = "pk (US dry)/min",
        CommonCode = "L50",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0001468295m,
    };
    public static IConvertibleUnit PeckUSDryPerSecond = new ConvertibleUnit()
    {
        Name = "peck (US dry) per second",
        Symbol = "pk (US dry)/s",
        CommonCode = "L51",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.008809768m,
    };
    public static IConvertibleUnit PsiPerPsi = new ConvertibleUnit()
    {
        Name = "psi per psi",
        Symbol = "psi/psi",
        CommonCode = "L52",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit PintUKPerDay = new ConvertibleUnit()
    {
        Name = "pint (UK) per day",
        Symbol = "pt (UK)/d",
        CommonCode = "L53",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000065770980000000006m,
    };
    public static IConvertibleUnit PintUKPerHour = new ConvertibleUnit()
    {
        Name = "pint (UK) per hour",
        Symbol = "pt (UK)/h",
        CommonCode = "L54",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000001578504m,
    };
    public static IConvertibleUnit PintUKPerMinute = new ConvertibleUnit()
    {
        Name = "pint (UK) per minute",
        Symbol = "pt (UK)/min",
        CommonCode = "L55",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000009471022m,
    };
    public static IConvertibleUnit PintUKPerSecond = new ConvertibleUnit()
    {
        Name = "pint (UK) per second",
        Symbol = "pt (UK)/s",
        CommonCode = "L56",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0005682613m,
    };
    public static IConvertibleUnit PintUSLiquidPerDay = new ConvertibleUnit()
    {
        Name = "pint (US liquid) per day",
        Symbol = "pt (US liq.)/d",
        CommonCode = "L57",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000000005476580000000001m,
    };
    public static IConvertibleUnit PintUSLiquidPerHour = new ConvertibleUnit()
    {
        Name = "pint (US liquid) per hour",
        Symbol = "pt (US liq.)/h",
        CommonCode = "L58",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000001314379m,
    };
    public static IConvertibleUnit PintUSLiquidPerMinute = new ConvertibleUnit()
    {
        Name = "pint (US liquid) per minute",
        Symbol = "pt (US liq.)/min",
        CommonCode = "L59",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000007886275m,
    };
    public static IConvertibleUnit PintUSLiquidPerSecond = new ConvertibleUnit()
    {
        Name = "pint (US liquid) per second",
        Symbol = "pt (US liq.)/s",
        CommonCode = "L60",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0004731765m,
    };
    public static IConvertibleUnit SlugPerDay = new ConvertibleUnit()
    {
        Name = "slug per day",
        Symbol = "slug/d",
        CommonCode = "L63",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.00016891090000000002m,
    };
    public static IConvertibleUnit SlugPerFootSecond = new ConvertibleUnit()
    {
        Name = "slug per foot second",
        Symbol = "slug/(ft·s)",
        CommonCode = "L64",
        ConversionGroup = "pascal * second",
        ConversionFactor = 47.88026m,
    };
    public static IConvertibleUnit SlugPerCubicFoot = new ConvertibleUnit()
    {
        Name = "slug per cubic foot",
        Symbol = "slug/ft³",
        CommonCode = "L65",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 515.3788m,
    };
    public static IConvertibleUnit SlugPerHour = new ConvertibleUnit()
    {
        Name = "slug per hour",
        Symbol = "slug/h",
        CommonCode = "L66",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.004053861000000001m,
    };
    public static IConvertibleUnit SlugPerMinute = new ConvertibleUnit()
    {
        Name = "slug per minute",
        Symbol = "slug/min",
        CommonCode = "L67",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.2432317m,
    };
    public static IConvertibleUnit SlugPerSecond = new ConvertibleUnit()
    {
        Name = "slug per second",
        Symbol = "slug/s",
        CommonCode = "L68",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 14.5939m,
    };
    public static IConvertibleUnit TonnePerKelvin = new ConvertibleUnit()
    {
        Name = "tonne per kelvin",
        Symbol = "t/K",
        CommonCode = "L69",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit TonnePerBar = new ConvertibleUnit()
    {
        Name = "tonne per bar",
        Symbol = "t/bar",
        CommonCode = "L70",
        ConversionGroup = "kilogram / pascal",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit TonnePerDay = new ConvertibleUnit()
    {
        Name = "tonne per day",
        Symbol = "t/d",
        CommonCode = "L71",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0115741m,
    };
    public static IConvertibleUnit TonnePerDayKelvin = new ConvertibleUnit()
    {
        Name = "tonne per day kelvin",
        Symbol = "(t/d)/K",
        CommonCode = "L72",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.0115741m,
    };
    public static IConvertibleUnit TonnePerDayBar = new ConvertibleUnit()
    {
        Name = "tonne per day bar",
        Symbol = "(t/d)/bar",
        CommonCode = "L73",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.000000115741m,
    };
    public static IConvertibleUnit TonnePerHourKelvin = new ConvertibleUnit()
    {
        Name = "tonne per hour kelvin",
        Symbol = "(t/h)/K",
        CommonCode = "L74",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 0.277778m,
    };
    public static IConvertibleUnit TonnePerHourBar = new ConvertibleUnit()
    {
        Name = "tonne per hour bar",
        Symbol = "(t/h)/bar",
        CommonCode = "L75",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.0000027777799999999998m,
    };
    public static IConvertibleUnit TonnePerCubicMetreKelvin = new ConvertibleUnit()
    {
        Name = "tonne per cubic metre kelvin",
        Symbol = "(t/m³)/K",
        CommonCode = "L76",
        ConversionGroup = "kilogram / kelvin / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit TonnePerCubicMetreBar = new ConvertibleUnit()
    {
        Name = "tonne per cubic metre bar",
        Symbol = "(t/m³)/bar",
        CommonCode = "L77",
        ConversionGroup = "kilogram / meter ** 3 / pascal",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit TonnePerMinute = new ConvertibleUnit()
    {
        Name = "tonne per minute",
        Symbol = "t/min",
        CommonCode = "L78",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 16.6667m,
    };
    public static IConvertibleUnit TonnePerMinuteKelvin = new ConvertibleUnit()
    {
        Name = "tonne per minute kelvin",
        Symbol = "(t/min)/K",
        CommonCode = "L79",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 16.6667m,
    };
    public static IConvertibleUnit TonnePerMinuteBar = new ConvertibleUnit()
    {
        Name = "tonne per minute bar",
        Symbol = "(t/min)/bar",
        CommonCode = "L80",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.000166667m,
    };
    public static IConvertibleUnit TonnePerSecond = new ConvertibleUnit()
    {
        Name = "tonne per second",
        Symbol = "t/s",
        CommonCode = "L81",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit TonnePerSecondKelvin = new ConvertibleUnit()
    {
        Name = "tonne per second kelvin",
        Symbol = "(t/s)/K",
        CommonCode = "L82",
        ConversionGroup = "kilogram / kelvin / second",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit TonnePerSecondBar = new ConvertibleUnit()
    {
        Name = "tonne per second bar",
        Symbol = "(t/s)/bar",
        CommonCode = "L83",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.01m,
    };
    public static IConvertibleUnit TonUKShipping = new ConvertibleUnit()
    {
        Name = "ton (UK shipping)",
        Symbol = "British shipping ton",
        CommonCode = "L84",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1.1893m,
    };
    public static IConvertibleUnit TonLongPerDay = new ConvertibleUnit()
    {
        Name = "ton long per day",
        Symbol = "ton (UK)/d",
        CommonCode = "L85",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.0117598m,
    };
    public static IConvertibleUnit TonUSShipping = new ConvertibleUnit()
    {
        Name = "ton (US shipping)",
        Symbol = "(US) shipping ton",
        CommonCode = "L86",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1.1326m,
    };
    public static IConvertibleUnit TonShortPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "ton short per degree Fahrenheit",
        Symbol = "ton (US)/°F",
        CommonCode = "L87",
        ConversionGroup = "kilogram / kelvin",
        ConversionFactor = 1632.932m,
    };
    public static IConvertibleUnit TonShortPerDay = new ConvertibleUnit()
    {
        Name = "ton short per day",
        Symbol = "ton (US)/d",
        CommonCode = "L88",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.01049982m,
    };
    public static IConvertibleUnit TonShortPerHourDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "ton short per hour degree Fahrenheit",
        Symbol = "ton (US)/(h·°F)",
        CommonCode = "L89",
        ConversionGroup = "kelvin * kilogram / second",
        ConversionFactor = 0.4535922m,
    };
    public static IConvertibleUnit TonShortPerHourPsi = new ConvertibleUnit()
    {
        Name = "ton short per hour psi",
        Symbol = "(ton (US)/h)/psi",
        CommonCode = "L90",
        ConversionGroup = "kilogram / pascal / second",
        ConversionFactor = 0.000036548890000000004m,
    };
    public static IConvertibleUnit TonShortPerPsi = new ConvertibleUnit()
    {
        Name = "ton short per psi",
        Symbol = "ton (US)/psi",
        CommonCode = "L91",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.131576m,
    };
    public static IConvertibleUnit TonUKLongPerCubicYard = new ConvertibleUnit()
    {
        Name = "ton (UK long) per cubic yard",
        Symbol = "ton.l/yd³ (UK)",
        CommonCode = "L92",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1328.939m,
    };
    public static IConvertibleUnit TonUSShortPerCubicYard = new ConvertibleUnit()
    {
        Name = "ton (US short) per cubic yard",
        Symbol = "ton.s/yd³ (US)",
        CommonCode = "L93",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 1186.5529999999999m,
    };
    public static IConvertibleUnit TonforceUSShort = new ConvertibleUnit()
    {
        Name = "tonforce (US short)",
        Symbol = "ton.sh-force",
        CommonCode = "L94",
        ConversionGroup = "newton",
        ConversionFactor = 8896.443m,
    };
    public static IConvertibleUnit CommonYear = new ConvertibleUnit()
    {
        Name = "common year",
        Symbol = "y (365 days)",
        CommonCode = "L95",
        ConversionGroup = "second",
        ConversionFactor = 31536000.0m,
    };
    public static IConvertibleUnit SiderealYear = new ConvertibleUnit()
    {
        Name = "sidereal year",
        Symbol = "y (sidereal)",
        CommonCode = "L96",
        ConversionGroup = "second",
        ConversionFactor = 31558150.0m,
    };
    public static IConvertibleUnit YardPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "yard per degree Fahrenheit",
        Symbol = "yd/°F",
        CommonCode = "L98",
        ConversionGroup = "meter / kelvin",
        ConversionFactor = 1.64592m,
    };
    public static IConvertibleUnit YardPerPsi = new ConvertibleUnit()
    {
        Name = "yard per psi",
        Symbol = "yd/psi",
        CommonCode = "L99",
        ConversionGroup = "meter / pascal",
        ConversionFactor = 0.0001326225m,
    };
    public static IConvertibleUnit PoundPerCubicInch = new ConvertibleUnit()
    {
        Name = "pound per cubic inch",
        Symbol = "lb/in³",
        CommonCode = "LA",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 27679.9m,
    };
    /// <summary>
    /// A unit of proportion defining the percentage of lactose in a product that exceeds a defined percentage level.
    /// </summary>
    public static IUnit LactoseExcessPercentage = new Unit()
    {
        Name = "lactose excess percentage",
        Symbol = null,
        CommonCode = "LAC",
    };
    public static IConvertibleUnit Pound = new ConvertibleUnit()
    {
        Name = "pound",
        Symbol = "lb",
        CommonCode = "LBR",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.45359237m,
    };
    public static IConvertibleUnit TroyPoundUS = new ConvertibleUnit()
    {
        Name = "troy pound (US)",
        Symbol = null,
        CommonCode = "LBT",
        ConversionGroup = "gram",
        ConversionFactor = 373.2417m,
    };
    public static IConvertibleUnit LitrePerDay = new ConvertibleUnit()
    {
        Name = "litre per day",
        Symbol = "l/d",
        CommonCode = "LD",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0000000115741m,
    };
    /// <summary>
    /// A unit of count defining the number of leaves.
    /// </summary>
    public static IUnit Leaf = new Unit()
    {
        Name = "leaf",
        Symbol = null,
        CommonCode = "LEF",
    };
    /// <summary>
    /// A unit of count defining the number of feet (12-inch) in length of a uniform width object.
    /// </summary>
    public static IUnit LinearFoot = new Unit()
    {
        Name = "linear foot",
        Symbol = null,
        CommonCode = "LF",
    };
    /// <summary>
    /// A unit of time defining the number of labour hours.
    /// </summary>
    public static IUnit LabourHour = new Unit()
    {
        Name = "labour hour",
        Symbol = null,
        CommonCode = "LH",
    };
    /// <summary>
    /// A unit of distance equal to 0.01 chain.
    /// </summary>
    public static IUnit Link = new Unit()
    {
        Name = "link",
        Symbol = null,
        CommonCode = "LK",
    };
    /// <summary>
    /// A unit of count defining the number of metres in length of a uniform width object.
    /// </summary>
    public static IUnit LinearMetre = new Unit()
    {
        Name = "linear metre",
        Symbol = null,
        CommonCode = "LM",
    };
    /// <summary>
    /// A unit of distance defining the linear extent of an item measured from end to end.
    /// </summary>
    public static IUnit Length = new Unit()
    {
        Name = "length",
        Symbol = null,
        CommonCode = "LN",
    };
    /// <summary>
    /// A unit of count defining the number of lots (lot: a collection of associated items).
    /// </summary>
    public static IUnit LotUnitOfProcurement = new Unit()
    {
        Name = "lot [unit of procurement]",
        Symbol = null,
        CommonCode = "LO",
    };
    /// <summary>
    /// A unit of mass defining the number of pounds of a liquid substance.
    /// </summary>
    public static IUnit LiquidPound = new Unit()
    {
        Name = "liquid pound",
        Symbol = null,
        CommonCode = "LP",
    };
    /// <summary>
    /// A unit of volume equal to one litre of pure alcohol.
    /// </summary>
    public static IUnit LitreOfPureAlcohol = new Unit()
    {
        Name = "litre of pure alcohol",
        Symbol = null,
        CommonCode = "LPA",
    };
    /// <summary>
    /// A unit of count defining the number of layers.
    /// </summary>
    public static IUnit Layer = new Unit()
    {
        Name = "layer",
        Symbol = null,
        CommonCode = "LR",
    };
    /// <summary>
    /// A unit of count defining the number of whole or a complete monetary amounts.
    /// </summary>
    public static IUnit LumpSum = new Unit()
    {
        Name = "lump sum",
        Symbol = null,
        CommonCode = "LS",
    };
    /// <summary>
    /// Synonym: gross ton (2240 lb)
    /// </summary>
    public static IConvertibleUnit TonUKOrLongTonUS = new ConvertibleUnit()
    {
        Name = "ton (UK) or long ton (US)",
        Symbol = "ton (UK)",
        CommonCode = "LTN",
        ConversionGroup = "kilogram",
        ConversionFactor = 1016.0469999999999m,
    };
    public static IConvertibleUnit Litre = new ConvertibleUnit()
    {
        Name = "litre",
        Symbol = "l",
        CommonCode = "LTR",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of mass defining the number of metric tons of lubricating oil.
    /// </summary>
    public static IUnit MetricTonLubricatingOil = new Unit()
    {
        Name = "metric ton, lubricating oil",
        Symbol = null,
        CommonCode = "LUB",
    };
    public static IConvertibleUnit Lumen = new ConvertibleUnit()
    {
        Name = "lumen",
        Symbol = "lm",
        CommonCode = "LUM",
        ConversionGroup = "candela * steradian",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Lux = new ConvertibleUnit()
    {
        Name = "lux",
        Symbol = "lx",
        CommonCode = "LUX",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of 36-inch units in length of a uniform width object.
    /// </summary>
    public static IUnit LinearYard = new Unit()
    {
        Name = "linear yard",
        Symbol = null,
        CommonCode = "LY",
    };
    public static IConvertibleUnit MilligramPerLitre = new ConvertibleUnit()
    {
        Name = "milligram per litre",
        Symbol = "mg/l",
        CommonCode = "M1",
        ConversionGroup = "kilogram / meter ** 3",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit ReciprocalCubicYard = new ConvertibleUnit()
    {
        Name = "reciprocal cubic yard",
        Symbol = "1/yd³",
        CommonCode = "M10",
        ConversionGroup = "1 / meter ** 3",
        ConversionFactor = 1.307951m,
    };
    public static IConvertibleUnit CubicYardPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "cubic yard per degree Fahrenheit",
        Symbol = "yd³/°F",
        CommonCode = "M11",
        ConversionGroup = "meter ** 3 / kelvin",
        ConversionFactor = 1.376199m,
    };
    public static IConvertibleUnit CubicYardPerDay = new ConvertibleUnit()
    {
        Name = "cubic yard per day",
        Symbol = "yd³/d",
        CommonCode = "M12",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000008849014999999999m,
    };
    public static IConvertibleUnit CubicYardPerHour = new ConvertibleUnit()
    {
        Name = "cubic yard per hour",
        Symbol = "yd³/h",
        CommonCode = "M13",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.00021237640000000002m,
    };
    public static IConvertibleUnit CubicYardPerPsi = new ConvertibleUnit()
    {
        Name = "cubic yard per psi",
        Symbol = "yd³/psi",
        CommonCode = "M14",
        ConversionGroup = "meter ** 3 / pascal",
        ConversionFactor = 0.0001108893m,
    };
    public static IConvertibleUnit CubicYardPerMinute = new ConvertibleUnit()
    {
        Name = "cubic yard per minute",
        Symbol = "yd³/min",
        CommonCode = "M15",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.01274258m,
    };
    public static IConvertibleUnit CubicYardPerSecond = new ConvertibleUnit()
    {
        Name = "cubic yard per second",
        Symbol = "yd³/s",
        CommonCode = "M16",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.7645549m,
    };
    public static IConvertibleUnit KilohertzMetre = new ConvertibleUnit()
    {
        Name = "kilohertz metre",
        Symbol = "kHz·m",
        CommonCode = "M17",
        ConversionGroup = "hertz * meter",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit GigahertzMetre = new ConvertibleUnit()
    {
        Name = "gigahertz metre",
        Symbol = "GHz·m",
        CommonCode = "M18",
        ConversionGroup = "hertz * meter",
        ConversionFactor = 1000000000m,
    };
    /// <summary>
    /// An empirical measure for describing wind speed based mainly on observed sea conditions. The Beaufort scale indicates the wind speed by numbers that typically range from 0 for calm, to 12 for hurricane.
    /// </summary>
    public static IUnit Beaufort = new Unit()
    {
        Name = "Beaufort",
        Symbol = "Bft",
        CommonCode = "M19",
    };
    public static IConvertibleUnit ReciprocalMegakelvinOrMegakelvinToThePowerMinusOne = new ConvertibleUnit()
    {
        Name = "reciprocal megakelvin or megakelvin to the power minus one",
        Symbol = "1/MK",
        CommonCode = "M20",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit ReciprocalKilovoltAmpereReciprocalHour = new ConvertibleUnit()
    {
        Name = "reciprocal kilovolt  ampere reciprocal hour",
        Symbol = "1/kVAh",
        CommonCode = "M21",
        ConversionGroup = "1 / ampere / second / volt",
        ConversionFactor = 0.0000002777778m,
    };
    public static IConvertibleUnit MillilitrePerSquareCentimetreMinute = new ConvertibleUnit()
    {
        Name = "millilitre per square centimetre minute",
        Symbol = "(ml/min)/cm²",
        CommonCode = "M22",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000002777778m,
    };
    public static IConvertibleUnit NewtonPerCentimetre = new ConvertibleUnit()
    {
        Name = "newton per centimetre",
        Symbol = "N/cm",
        CommonCode = "M23",
        ConversionGroup = "newton / meter",
        ConversionFactor = 100.0m,
    };
    public static IConvertibleUnit OhmKilometre = new ConvertibleUnit()
    {
        Name = "ohm kilometre",
        Symbol = "Ω·km",
        CommonCode = "M24",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of proportion, equal to 0.01, in relation to a temperature of one degree.
    /// </summary>
    public static IUnit PercentPerDegreeCelsius = new Unit()
    {
        Name = "percent per degree Celsius",
        Symbol = "%/°C",
        CommonCode = "M25",
    };
    public static IConvertibleUnit GigaohmPerMetre = new ConvertibleUnit()
    {
        Name = "gigaohm per metre",
        Symbol = "GΩ/m",
        CommonCode = "M26",
        ConversionGroup = "ohm / meter",
        ConversionFactor = 1000000000.0m,
    };
    public static IConvertibleUnit MegahertzMetre = new ConvertibleUnit()
    {
        Name = "megahertz metre",
        Symbol = "MHz·m",
        CommonCode = "M27",
        ConversionGroup = "hertz * meter",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit KilogramPerKilogram = new ConvertibleUnit()
    {
        Name = "kilogram per kilogram",
        Symbol = "kg/kg",
        CommonCode = "M29",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit ReciprocalVoltAmpereReciprocalSecond = new ConvertibleUnit()
    {
        Name = "reciprocal volt  ampere reciprocal second",
        Symbol = "1/(V·A·s)",
        CommonCode = "M30",
        ConversionGroup = "1 / ampere / second / volt",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit KilogramPerKilometre = new ConvertibleUnit()
    {
        Name = "kilogram per kilometre",
        Symbol = "kg/km",
        CommonCode = "M31",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.001m,
    };
    public static IConvertibleUnit PascalSecondPerLitre = new ConvertibleUnit()
    {
        Name = "pascal second per litre",
        Symbol = "Pa·s/l",
        CommonCode = "M32",
        ConversionGroup = "pascal * second / meter ** 3",
        ConversionFactor = 1000.0m,
    };
    public static IConvertibleUnit MillimolePerLitre = new ConvertibleUnit()
    {
        Name = "millimole per litre",
        Symbol = "mmol/l",
        CommonCode = "M33",
        ConversionGroup = "mole / meter ** 3",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit NewtonMetrePerSquareMetre = new ConvertibleUnit()
    {
        Name = "newton metre per square metre",
        Symbol = "N·m/m²",
        CommonCode = "M34",
        ConversionGroup = "newton / meter",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MillivoltAmpere = new ConvertibleUnit()
    {
        Name = "millivolt  ampere",
        Symbol = "mV·A",
        CommonCode = "M35",
        ConversionGroup = "ampere * volt",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of count defining the number of months expressed in multiples of 30 days, one day equals 24 hours.
    /// </summary>
    public static IConvertibleUnit Unit30dayMonth = new ConvertibleUnit()
    {
        Name = "30day month",
        Symbol = "mo (30 days)",
        CommonCode = "M36",
        ConversionGroup = "second",
        ConversionFactor = 2592000.0m,
    };
    /// <summary>
    /// A unit of count defining the number of years expressed in multiples of 360 days, one day equals 24 hours.
    /// </summary>
    public static IConvertibleUnit ActualPer360 = new ConvertibleUnit()
    {
        Name = "actual/360",
        Symbol = "y (360 days)",
        CommonCode = "M37",
        ConversionGroup = "second",
        ConversionFactor = 31104000.0m,
    };
    /// <summary>
    /// 1000-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit KilometrePerSecondSquared = new ConvertibleUnit()
    {
        Name = "kilometre per second squared",
        Symbol = "km/s²",
        CommonCode = "M38",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// 0,01-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit CentimetrePerSecondSquared = new ConvertibleUnit()
    {
        Name = "centimetre per second squared",
        Symbol = "cm/s²",
        CommonCode = "M39",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// A unit of measure expressed as a monetary amount.
    /// </summary>
    public static IUnit MonetaryValue = new Unit()
    {
        Name = "monetary value",
        Symbol = null,
        CommonCode = "M4",
    };
    /// <summary>
    /// Unit of the length according to the Anglo-American and Imperial system of units divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit YardPerSecondSquared = new ConvertibleUnit()
    {
        Name = "yard per second squared",
        Symbol = "yd/s²",
        CommonCode = "M40",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.9144000000000001m,
    };
    /// <summary>
    /// 0,001-fold of the SI base unit metre divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit MillimetrePerSecondSquared = new ConvertibleUnit()
    {
        Name = "millimetre per second squared",
        Symbol = "mm/s²",
        CommonCode = "M41",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// Unit of the length according to the Imperial system of units divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit MileStatuteMilePerSecondSquared = new ConvertibleUnit()
    {
        Name = "mile (statute mile) per second squared",
        Symbol = "mi/s²",
        CommonCode = "M42",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 1609.344m,
    };
    /// <summary>
    /// Unit to indicate an angle at military zone, equal to the 6400th part of the full circle of the 360° or 2·p·rad.
    /// </summary>
    public static IConvertibleUnit Mil = new ConvertibleUnit()
    {
        Name = "mil",
        Symbol = "mil",
        CommonCode = "M43",
        ConversionGroup = "radian",
        ConversionFactor = 0.0009817477m,
    };
    /// <summary>
    /// Unit to identify an angle of the full circle of 360° or 2·p·rad (Refer ISO/TC12 SI Guide).
    /// </summary>
    public static IConvertibleUnit Revolution = new ConvertibleUnit()
    {
        Name = "revolution",
        Symbol = "rev",
        CommonCode = "M44",
        ConversionGroup = "radian",
        ConversionFactor = 6.283185m,
    };
    /// <summary>
    /// 360 part of a full circle divided by the power of the SI base unit second and the exponent 2.
    /// </summary>
    public static IConvertibleUnit DegreeUnitOfAnglePerSecondSquared = new ConvertibleUnit()
    {
        Name = "degree [unit of angle] per second squared",
        Symbol = "°/s²",
        CommonCode = "M45",
        ConversionGroup = "radian / second",
        ConversionFactor = 0.01745329m,
    };
    /// <summary>
    /// Unit of the angular velocity.
    /// </summary>
    public static IConvertibleUnit RevolutionPerMinute = new ConvertibleUnit()
    {
        Name = "revolution per minute",
        Symbol = "r/min",
        CommonCode = "M46",
        ConversionGroup = "radian / second",
        ConversionFactor = 0.1047198m,
    };
    /// <summary>
    /// Unit of an area, of which the size is given by a diameter of length of 1 mm (0,001 in) based on the formula: area = p·(diameter/2)².
    /// </summary>
    public static IConvertibleUnit CircularMil = new ConvertibleUnit()
    {
        Name = "circular mil",
        Symbol = "cmil",
        CommonCode = "M47",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.0000000005067075m,
    };
    /// <summary>
    /// Unit of the area, which is mainly common in the agriculture and forestry.
    /// </summary>
    public static IConvertibleUnit SquareMileBasedOnUSSurveyFoot = new ConvertibleUnit()
    {
        Name = "square mile (based on U.S. survey foot)",
        Symbol = "mi² (US survey)",
        CommonCode = "M48",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 2589998.0m,
    };
    /// <summary>
    /// Unit of the length according the Anglo-American system of units.
    /// </summary>
    public static IConvertibleUnit ChainBasedOnUSSurveyFoot = new ConvertibleUnit()
    {
        Name = "chain (based on U.S. survey foot)",
        Symbol = "ch (US survey)",
        CommonCode = "M49",
        ConversionGroup = "meter",
        ConversionFactor = 20.116839999999996m,
    };
    public static IConvertibleUnit Microcurie = new ConvertibleUnit()
    {
        Name = "microcurie",
        Symbol = "µCi",
        CommonCode = "M5",
        ConversionGroup = "becquerel",
        ConversionFactor = 37000.0m,
    };
    /// <summary>
    /// Unit commonly used in Great Britain at rural distances: 1 furlong = 40 rods = 10 chains (UK) = 1/8 mile = 1/10 furlong = 220 yards = 660 foot.
    /// </summary>
    public static IConvertibleUnit Furlong = new ConvertibleUnit()
    {
        Name = "furlong",
        Symbol = "fur",
        CommonCode = "M50",
        ConversionGroup = "meter",
        ConversionFactor = 201.168m,
    };
    /// <summary>
    /// Unit commonly used in the United States for ordnance survey._x000D_
    /// </summary>
    public static IConvertibleUnit FootUSSurvey = new ConvertibleUnit()
    {
        Name = "foot (U.S. survey)",
        Symbol = "ft (US survey)",
        CommonCode = "M51",
        ConversionGroup = "meter",
        ConversionFactor = 0.30480060000000003m,
    };
    /// <summary>
    /// Unit commonly used in the United States for ordnance survey.
    /// </summary>
    public static IConvertibleUnit MileBasedOnUSSurveyFoot = new ConvertibleUnit()
    {
        Name = "mile (based on U.S. survey foot)",
        Symbol = "mi (US survey)",
        CommonCode = "M52",
        ConversionGroup = "meter",
        ConversionFactor = 1609.347m,
    };
    /// <summary>
    /// SI base unit metre divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit MetrePerPascal = new ConvertibleUnit()
    {
        Name = "metre per pascal",
        Symbol = "m/Pa",
        CommonCode = "M53",
        ConversionGroup = "meter ** 2 * second ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the translation factor for implementation from rotation to linear movement.
    /// </summary>
    public static IConvertibleUnit MetrePerRadiant = new ConvertibleUnit()
    {
        Name = "metre per radiant",
        Symbol = "m/rad",
        CommonCode = "M55",
        ConversionGroup = "meter / radian",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit for a very short period.
    /// </summary>
    public static IConvertibleUnit Shake = new ConvertibleUnit()
    {
        Name = "shake",
        Symbol = "shake",
        CommonCode = "M56",
        ConversionGroup = "second",
        ConversionFactor = 0.00000001m,
    };
    /// <summary>
    /// Unit of velocity from the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit MilePerMinute = new ConvertibleUnit()
    {
        Name = "mile per minute",
        Symbol = "mi/min",
        CommonCode = "M57",
        ConversionGroup = "meter / second",
        ConversionFactor = 26.8224m,
    };
    /// <summary>
    /// Unit of the velocity from the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit MilePerSecond = new ConvertibleUnit()
    {
        Name = "mile per second",
        Symbol = "mi/s",
        CommonCode = "M58",
        ConversionGroup = "meter / second",
        ConversionFactor = 1609.344m,
    };
    /// <summary>
    /// SI base unit meter divided by the product of SI base unit second and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit MetrePerSecondPascal = new ConvertibleUnit()
    {
        Name = "metre per second pascal",
        Symbol = "(m/s)/Pa",
        CommonCode = "M59",
        ConversionGroup = "meter ** 2 * second / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// SI base unit metre divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit MetrePerHour = new ConvertibleUnit()
    {
        Name = "metre per hour",
        Symbol = "m/h",
        CommonCode = "M60",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// Unit of the length according to the Anglo-American and Imperial system of units divided by the unit common year with 365 days.
    /// </summary>
    public static IConvertibleUnit InchPerYear = new ConvertibleUnit()
    {
        Name = "inch per year",
        Symbol = "in/y",
        CommonCode = "M61",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.0000000008048774m,
    };
    /// <summary>
    /// 1000-fold of the SI base unit metre divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit KilometrePerSecond = new ConvertibleUnit()
    {
        Name = "kilometre per second",
        Symbol = "km/s",
        CommonCode = "M62",
        ConversionGroup = "meter / second",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// Unit inch according to the Anglo-American and Imperial system of units divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit InchPerMinute = new ConvertibleUnit()
    {
        Name = "inch per minute",
        Symbol = "in/min",
        CommonCode = "M63",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.0004233333m,
    };
    /// <summary>
    /// Unit yard according to the Anglo-American and Imperial system of units divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit YardPerSecond = new ConvertibleUnit()
    {
        Name = "yard per second",
        Symbol = "yd/s",
        CommonCode = "M64",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.9144000000000001m,
    };
    /// <summary>
    /// Unit yard according to the Anglo-American and Imperial system of units divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit YardPerMinute = new ConvertibleUnit()
    {
        Name = "yard per minute",
        Symbol = "yd/min",
        CommonCode = "M65",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.01524m,
    };
    /// <summary>
    /// Unit yard according to the Anglo-American and Imperial system of units divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit YardPerHour = new ConvertibleUnit()
    {
        Name = "yard per hour",
        Symbol = "yd/h",
        CommonCode = "M66",
        ConversionGroup = "meter / second",
        ConversionFactor = 0.000254m,
    };
    /// <summary>
    /// Unit of the volume, which is used in the United States to measure/gauge the capacity of reservoirs.
    /// </summary>
    public static IConvertibleUnit AcrefootBasedOnUSSurveyFoot = new ConvertibleUnit()
    {
        Name = "acrefoot (based on U.S. survey foot)",
        Symbol = "acre-ft (US survey)",
        CommonCode = "M67",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1233.489m,
    };
    /// <summary>
    /// Traditional unit of the volume of stacked firewood which has been measured with a cord.
    /// </summary>
    public static IConvertibleUnit Cord128Ft3 = new ConvertibleUnit()
    {
        Name = "cord (128 ft3)",
        Symbol = "cord",
        CommonCode = "M68",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 3.624556m,
    };
    /// <summary>
    /// Unit of volume according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit CubicMileUKStatute = new ConvertibleUnit()
    {
        Name = "cubic mile (UK statute)",
        Symbol = "mi³",
        CommonCode = "M69",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 4168182000.0m,
    };
    public static IConvertibleUnit Microinch = new ConvertibleUnit()
    {
        Name = "microinch",
        Symbol = "µin",
        CommonCode = "M7",
        ConversionGroup = "meter",
        ConversionFactor = 0.0000000254m,
    };
    /// <summary>
    /// Traditional unit of the cargo capacity.
    /// </summary>
    public static IConvertibleUnit TonRegister = new ConvertibleUnit()
    {
        Name = "ton, register",
        Symbol = "RT",
        CommonCode = "M70",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 2.831685m,
    };
    /// <summary>
    /// Power of the SI base unit meter by exponent 3 divided by the derived SI base unit pascal.
    /// </summary>
    public static IConvertibleUnit CubicMetrePerPascal = new ConvertibleUnit()
    {
        Name = "cubic metre per pascal",
        Symbol = "m³/Pa",
        CommonCode = "M71",
        ConversionGroup = "meter ** 4 * second ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Logarithmic relationship to base 10.
    /// </summary>
    public static IConvertibleUnit Bel = new ConvertibleUnit()
    {
        Name = "bel",
        Symbol = "B",
        CommonCode = "M72",
        ConversionGroup = "byte",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// SI base unit kilogram divided by the product of the power of the SI base unit metre with exponent 3 and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit KilogramPerCubicMetrePascal = new ConvertibleUnit()
    {
        Name = "kilogram per cubic metre pascal",
        Symbol = "(kg/m³)/Pa",
        CommonCode = "M73",
        ConversionGroup = "second ** 2 / meter ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// SI base unit kilogram divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit KilogramPerPascal = new ConvertibleUnit()
    {
        Name = "kilogram per pascal",
        Symbol = "kg/Pa",
        CommonCode = "M74",
        ConversionGroup = "meter * second ** 2",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// 1000-fold of the unit of the force pound-force (lbf) according to the Anglo-American system of units with the relationship.
    /// </summary>
    public static IConvertibleUnit Kilopoundforce = new ConvertibleUnit()
    {
        Name = "kilopoundforce",
        Symbol = "kip",
        CommonCode = "M75",
        ConversionGroup = "newton",
        ConversionFactor = 4448.222000000001m,
    };
    /// <summary>
    /// Non SI-conforming unit of the power, which corresponds to a mass of a pound multiplied with the acceleration of a foot per square second.
    /// </summary>
    public static IConvertibleUnit Poundal = new ConvertibleUnit()
    {
        Name = "poundal",
        Symbol = "pdl",
        CommonCode = "M76",
        ConversionGroup = "newton",
        ConversionFactor = 0.138255m,
    };
    /// <summary>
    /// Product of the SI base unit kilogram and the SI base unit metre divided by the power of the SI base unit second by exponent 2.
    /// </summary>
    public static IConvertibleUnit KilogramMetrePerSecondSquared = new ConvertibleUnit()
    {
        Name = "kilogram metre per second squared",
        Symbol = "kg·m/s²",
        CommonCode = "M77",
        ConversionGroup = "kilogram * meter / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 0,001-fold of the unit of the weight, defined as a mass of 1 kg which finds out about a weight strength from 1 kp by the gravitational force at sea level which corresponds to a strength of 9,806 65 newton.
    /// </summary>
    public static IConvertibleUnit Pond = new ConvertibleUnit()
    {
        Name = "pond",
        Symbol = "p",
        CommonCode = "M78",
        ConversionGroup = "newton",
        ConversionFactor = 0.00980665m,
    };
    /// <summary>
    /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2 divided by the unit of time hour.
    /// </summary>
    public static IConvertibleUnit SquareFootPerHour = new ConvertibleUnit()
    {
        Name = "square foot per hour",
        Symbol = "ft²/h",
        CommonCode = "M79",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.0000258064m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit stokes divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit StokesPerPascal = new ConvertibleUnit()
    {
        Name = "stokes per pascal",
        Symbol = "St/Pa",
        CommonCode = "M80",
        ConversionGroup = "meter ** 3 * second / kilogram",
        ConversionFactor = 0.0001m,
    };
    /// <summary>
    /// 0,000 1-fold of the power of the SI base unit metre by exponent 2 divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit SquareCentimetrePerSecond = new ConvertibleUnit()
    {
        Name = "square centimetre per second",
        Symbol = "cm²/s",
        CommonCode = "M81",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.0001m,
    };
    /// <summary>
    /// Power of the SI base unit metre with the exponent 2 divided by the SI base unit second and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit SquareMetrePerSecondPascal = new ConvertibleUnit()
    {
        Name = "square metre per second pascal",
        Symbol = "(m²/s)/Pa",
        CommonCode = "M82",
        ConversionGroup = "meter ** 3 * second / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit for linear mass according to avoirdupois system of units.
    /// </summary>
    public static IConvertibleUnit PoundPerYard = new ConvertibleUnit()
    {
        Name = "pound per yard",
        Symbol = "lb/yd",
        CommonCode = "M84",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 0.4960546m,
    };
    /// <summary>
    /// Non SI-conforming unit of the mass used in the mineralogy to determine the concentration of precious metals in ore according to the mass of the precious metal in milligrams in a sample of the mass of an assay sound (number of troy ounces in a short ton (1 000 lb)).
    /// </summary>
    public static IConvertibleUnit TonAssay = new ConvertibleUnit()
    {
        Name = "ton, assay",
        Symbol = null,
        CommonCode = "M85",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.02916667m,
    };
    /// <summary>
    /// Outdated unit of the mass used in Germany.
    /// </summary>
    public static IConvertibleUnit Pfund = new ConvertibleUnit()
    {
        Name = "pfund",
        Symbol = "pfd",
        CommonCode = "M86",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.5m,
    };
    /// <summary>
    /// SI base unit kilogram divided by the product of the SI base unit second and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit KilogramPerSecondPascal = new ConvertibleUnit()
    {
        Name = "kilogram per second pascal",
        Symbol = "(kg/s)/Pa",
        CommonCode = "M87",
        ConversionGroup = "meter * second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit tonne divided by the unit month.
    /// </summary>
    public static IConvertibleUnit TonnePerMonth = new ConvertibleUnit()
    {
        Name = "tonne per month",
        Symbol = "t/mo",
        CommonCode = "M88",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000380257053768m,
    };
    /// <summary>
    /// Unit tonne divided by the unit year with 365 days.
    /// </summary>
    public static IConvertibleUnit TonnePerYear = new ConvertibleUnit()
    {
        Name = "tonne per year",
        Symbol = "t/y",
        CommonCode = "M89",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.000031688087810000006m,
    };
    public static IUnit MillionBtuPer1000CubicFoot = new Unit()
    {
        Name = "million Btu per 1000 cubic foot",
        Symbol = "MBTU/kft³",
        CommonCode = "M9",
    };
    /// <summary>
    /// 1000-fold of the unit of the mass avoirdupois pound according to the avoirdupois unit system divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit KilopoundPerHour = new ConvertibleUnit()
    {
        Name = "kilopound per hour",
        Symbol = "klb/h",
        CommonCode = "M90",
        ConversionGroup = "kilogram / second",
        ConversionFactor = 0.125997889m,
    };
    /// <summary>
    /// Proportion of the mass consisting of the avoirdupois pound according to the avoirdupois unit system divided by the avoirdupois pound according to the avoirdupois unit system.
    /// </summary>
    public static IConvertibleUnit PoundPerPound = new ConvertibleUnit()
    {
        Name = "pound per pound",
        Symbol = "lb/lb",
        CommonCode = "M91",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Product of the unit pound-force according to the Anglo-American system of units and the unit foot according to the Anglo-American and the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit PoundforceFoot = new ConvertibleUnit()
    {
        Name = "poundforce foot",
        Symbol = "lbf·ft",
        CommonCode = "M92",
        ConversionGroup = "meter * newton",
        ConversionFactor = 1.355818m,
    };
    /// <summary>
    /// Product of the derived SI unit newton and the SI base unit metre divided by the unit radian.
    /// </summary>
    public static IConvertibleUnit NewtonMetrePerRadian = new ConvertibleUnit()
    {
        Name = "newton metre per radian",
        Symbol = "N·m/rad",
        CommonCode = "M93",
        ConversionGroup = "kilogram * meter ** 2 / radian / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of imbalance as a product of the SI base unit kilogram and the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit KilogramMetre = new ConvertibleUnit()
    {
        Name = "kilogram metre",
        Symbol = "kg·m",
        CommonCode = "M94",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Product of the non SI-conforming unit of the force poundal and the unit foot according to the Anglo-American and Imperial system of units .
    /// </summary>
    public static IConvertibleUnit PoundalFoot = new ConvertibleUnit()
    {
        Name = "poundal foot",
        Symbol = "pdl·ft",
        CommonCode = "M95",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.04214011m,
    };
    /// <summary>
    /// Product of the non SI-conforming unit of the force poundal and the unit inch according to the Anglo-American and Imperial system of units .
    /// </summary>
    public static IConvertibleUnit PoundalInch = new ConvertibleUnit()
    {
        Name = "poundal inch",
        Symbol = "pdl·in",
        CommonCode = "M96",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.023091719500545033m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the rotational moment.
    /// </summary>
    public static IConvertibleUnit DyneMetre = new ConvertibleUnit()
    {
        Name = "dyne metre",
        Symbol = "dyn·m",
        CommonCode = "M97",
        ConversionGroup = "meter * newton",
        ConversionFactor = 0.00001m,
    };
    /// <summary>
    /// Product of the SI base unit kilogram and the 0,01-fold of the SI base unit metre divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit KilogramCentimetrePerSecond = new ConvertibleUnit()
    {
        Name = "kilogram centimetre per second",
        Symbol = "kg·(cm/s)",
        CommonCode = "M98",
        ConversionGroup = "kilogram * meter / second",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// Product of the 0,001-fold of the SI base unit kilogram and the 0,01-fold of the SI base unit metre divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit GramCentimetrePerSecond = new ConvertibleUnit()
    {
        Name = "gram centimetre per second",
        Symbol = "g·(cm/s)",
        CommonCode = "M99",
        ConversionGroup = "kilogram * meter / second",
        ConversionFactor = 0.00001m,
    };
    /// <summary>
    /// A unit of electrical reactive power defining the total amount of reactive power across a power system.
    /// </summary>
    public static IUnit MegavoltAmpereReactiveHour = new Unit()
    {
        Name = "megavolt ampere reactive hour",
        Symbol = "Mvar·h",
        CommonCode = "MAH",
    };
    public static IConvertibleUnit Megalitre = new ConvertibleUnit()
    {
        Name = "megalitre",
        Symbol = "Ml",
        CommonCode = "MAL",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit Megametre = new ConvertibleUnit()
    {
        Name = "megametre",
        Symbol = "Mm",
        CommonCode = "MAM",
        ConversionGroup = "meter",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of electrical reactive power represented by a current of one thousand amperes flowing due a potential difference of one thousand volts where the sine of the phase angle between them is 1.
    /// </summary>
    public static IUnit Megavar = new Unit()
    {
        Name = "megavar",
        Symbol = "Mvar",
        CommonCode = "MAR",
    };
    /// <summary>
    /// A unit of power defining the rate of energy transferred or consumed when a current of 1000 amperes flows due to a potential of 1000 volts at unity power factor.
    /// </summary>
    public static IConvertibleUnit Megawatt = new ConvertibleUnit()
    {
        Name = "megawatt",
        Symbol = "MW",
        CommonCode = "MAW",
        ConversionGroup = "watt",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of count defining the number of one thousand brick equivalent units.
    /// </summary>
    public static IUnit ThousandStandardBrickEquivalent = new Unit()
    {
        Name = "thousand standard brick equivalent",
        Symbol = null,
        CommonCode = "MBE",
    };
    /// <summary>
    /// A unit of volume equal to one thousand board foot.
    /// </summary>
    public static IUnit ThousandBoardFoot = new Unit()
    {
        Name = "thousand board foot",
        Symbol = null,
        CommonCode = "MBF",
    };
    public static IConvertibleUnit Millibar = new ConvertibleUnit()
    {
        Name = "millibar",
        Symbol = "mbar",
        CommonCode = "MBR",
        ConversionGroup = "pascal",
        ConversionFactor = 100m,
    };
    public static IConvertibleUnit Microgram = new ConvertibleUnit()
    {
        Name = "microgram",
        Symbol = "µg",
        CommonCode = "MC",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Millicurie = new ConvertibleUnit()
    {
        Name = "millicurie",
        Symbol = "mCi",
        CommonCode = "MCU",
        ConversionGroup = "becquerel",
        ConversionFactor = 37000000.0m,
    };
    /// <summary>
    /// A unit of count defining the number of metric tons of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit AirDryMetricTon = new Unit()
    {
        Name = "air dry metric ton",
        Symbol = null,
        CommonCode = "MD",
    };
    public static IConvertibleUnit Milligram = new ConvertibleUnit()
    {
        Name = "milligram",
        Symbol = "mg",
        CommonCode = "MGM",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit Megahertz = new ConvertibleUnit()
    {
        Name = "megahertz",
        Symbol = "MHz",
        CommonCode = "MHZ",
        ConversionGroup = "hertz",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit SquareMileStatuteMile = new ConvertibleUnit()
    {
        Name = "square mile (statute mile)",
        Symbol = "mi²",
        CommonCode = "MIK",
        ConversionGroup = "kilometer ** 2",
        ConversionFactor = 2.589988m,
    };
    public static IConvertibleUnit Thousand = new ConvertibleUnit()
    {
        Name = "thousand",
        Symbol = null,
        CommonCode = "MIL",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000m,
    };
    public static IConvertibleUnit MinuteUnitOfTime = new ConvertibleUnit()
    {
        Name = "minute [unit of time]",
        Symbol = "min",
        CommonCode = "MIN",
        ConversionGroup = "second",
        ConversionFactor = 60m,
    };
    public static IConvertibleUnit Million = new ConvertibleUnit()
    {
        Name = "million",
        Symbol = null,
        CommonCode = "MIO",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of count defining the number of international units in multiples of 10⁶.
    /// </summary>
    public static IUnit MillionInternationalUnit = new Unit()
    {
        Name = "million international unit",
        Symbol = null,
        CommonCode = "MIU",
    };
    /// <summary>
    /// Synonym: billion (US)
    /// </summary>
    public static IConvertibleUnit Milliard = new ConvertibleUnit()
    {
        Name = "milliard",
        Symbol = null,
        CommonCode = "MLD",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000000000m,
    };
    public static IConvertibleUnit Millilitre = new ConvertibleUnit()
    {
        Name = "millilitre",
        Symbol = "ml",
        CommonCode = "MLT",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit SquareMillimetre = new ConvertibleUnit()
    {
        Name = "square millimetre",
        Symbol = "mm²",
        CommonCode = "MMK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.000001m,
    };
    public static IConvertibleUnit CubicMillimetre = new ConvertibleUnit()
    {
        Name = "cubic millimetre",
        Symbol = "mm³",
        CommonCode = "MMQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000000001m,
    };
    public static IConvertibleUnit Millimetre = new ConvertibleUnit()
    {
        Name = "millimetre",
        Symbol = "mm",
        CommonCode = "MMT",
        ConversionGroup = "meter",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of mass defining the number of kilograms of a product, disregarding the water content of the product.
    /// </summary>
    public static IUnit KilogramDryWeight = new Unit()
    {
        Name = "kilogram, dry weight",
        Symbol = null,
        CommonCode = "MND",
    };
    /// <summary>
    /// Unit of time equal to 1/12 of a year of 365,25 days.
    /// </summary>
    public static IConvertibleUnit Month = new ConvertibleUnit()
    {
        Name = "month",
        Symbol = "mo",
        CommonCode = "MON",
        ConversionGroup = "second",
        ConversionFactor = 2629800.0m,
    };
    public static IConvertibleUnit Megapascal = new ConvertibleUnit()
    {
        Name = "megapascal",
        Symbol = "MPa",
        CommonCode = "MPA",
        ConversionGroup = "pascal",
        ConversionFactor = 1000000m,
    };
    public static IConvertibleUnit CubicMetrePerHour = new ConvertibleUnit()
    {
        Name = "cubic metre per hour",
        Symbol = "m³/h",
        CommonCode = "MQH",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000277778m,
    };
    public static IConvertibleUnit CubicMetrePerSecond = new ConvertibleUnit()
    {
        Name = "cubic metre per second",
        Symbol = "m³/s",
        CommonCode = "MQS",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MetrePerSecondSquared = new ConvertibleUnit()
    {
        Name = "metre per second squared",
        Symbol = "m/s²",
        CommonCode = "MSK",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit SquareMetre = new ConvertibleUnit()
    {
        Name = "square metre",
        Symbol = "m²",
        CommonCode = "MTK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Synonym: metre cubed
    /// </summary>
    public static IConvertibleUnit CubicMetre = new ConvertibleUnit()
    {
        Name = "cubic metre",
        Symbol = "m³",
        CommonCode = "MTQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Metre = new ConvertibleUnit()
    {
        Name = "metre",
        Symbol = "m",
        CommonCode = "MTR",
        ConversionGroup = "meter",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit MetrePerSecond = new ConvertibleUnit()
    {
        Name = "metre per second",
        Symbol = "m/s",
        CommonCode = "MTS",
        ConversionGroup = "meter / second",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit MegavoltAmpere = new ConvertibleUnit()
    {
        Name = "megavolt  ampere",
        Symbol = "MV·A",
        CommonCode = "MVA",
        ConversionGroup = "ampere * volt",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of power defining the total amount of bulk energy transferred or consumed.
    /// </summary>
    public static IConvertibleUnit MegawattHour1000KwH = new ConvertibleUnit()
    {
        Name = "megawatt hour (1000 kW.h)",
        Symbol = "MW·h",
        CommonCode = "MWH",
        ConversionGroup = "joule",
        ConversionFactor = 3600000000.0m,
    };
    /// <summary>
    /// A unit of count defining the number of calories prescribed daily for parenteral/enteral therapy.
    /// </summary>
    public static IUnit PenCalorie = new Unit()
    {
        Name = "pen calorie",
        Symbol = null,
        CommonCode = "N1",
    };
    /// <summary>
    /// Product of the avoirdupois pound according to the avoirdupois unit system and the unit foot according to the Anglo-American and Imperial system of units divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit PoundFootPerSecond = new ConvertibleUnit()
    {
        Name = "pound foot per second",
        Symbol = "lb·(ft/s)",
        CommonCode = "N10",
        ConversionGroup = "kilogram * meter / second",
        ConversionFactor = 0.138255m,
    };
    /// <summary>
    /// Product of the avoirdupois pound according to the avoirdupois unit system and the unit inch according to the Anglo-American and Imperial system of units divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit PoundInchPerSecond = new ConvertibleUnit()
    {
        Name = "pound inch per second",
        Symbol = "lb·(in/s)",
        CommonCode = "N11",
        ConversionGroup = "kilogram * meter / second",
        ConversionFactor = 0.01152125m,
    };
    /// <summary>
    /// Obsolete unit of the power relating to DIN 1301-3:1979: 1 PS = 735,498 75 W.
    /// </summary>
    public static IConvertibleUnit Pferdestaerke = new ConvertibleUnit()
    {
        Name = "Pferdestaerke",
        Symbol = "PS",
        CommonCode = "N12",
        ConversionGroup = "watt",
        ConversionFactor = 735.4988m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure, at which a value of 1 cmHg meets the static pressure, which is generated by a mercury at a temperature of 0 °C with a height of 1 centimetre .
    /// </summary>
    public static IConvertibleUnit CentimetreOfMercury0C = new ConvertibleUnit()
    {
        Name = "centimetre of mercury (0 ºC)",
        Symbol = "cmHg (0 ºC)",
        CommonCode = "N13",
        ConversionGroup = "pascal",
        ConversionFactor = 1333.22m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure, at which a value of 1 cmH2O meets the static pressure, which is generated by a head of water at a temperature of 4 °C with a height of 1 centimetre .
    /// </summary>
    public static IConvertibleUnit CentimetreOfWater4C = new ConvertibleUnit()
    {
        Name = "centimetre of water (4 ºC)",
        Symbol = "cmH₂O (4 °C)",
        CommonCode = "N14",
        ConversionGroup = "pascal",
        ConversionFactor = 98.06380000000001m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 ftH2O is equivalent to the static pressure, which is generated by a head of water at a temperature 39,2°F with a height of 1 foot .
    /// </summary>
    public static IConvertibleUnit FootOfWater392F = new ConvertibleUnit()
    {
        Name = "foot of water (39.2 ºF)",
        Symbol = "ftH₂O (39,2 ºF)",
        CommonCode = "N15",
        ConversionGroup = "pascal",
        ConversionFactor = 2988.98m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inHg meets the static pressure, which is generated by a mercury at a temperature of 32°F with a height of 1 inch.
    /// </summary>
    public static IConvertibleUnit InchOfMercury32F = new ConvertibleUnit()
    {
        Name = "inch of mercury (32 ºF)",
        Symbol = "inHG (32 ºF)",
        CommonCode = "N16",
        ConversionGroup = "pascal",
        ConversionFactor = 3386.38m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inHg meets the static pressure, which is generated by a mercury at a temperature of 60°F with a height of 1 inch.
    /// </summary>
    public static IConvertibleUnit InchOfMercury60F = new ConvertibleUnit()
    {
        Name = "inch of mercury (60 ºF)",
        Symbol = "inHg (60 ºF)",
        CommonCode = "N17",
        ConversionGroup = "pascal",
        ConversionFactor = 3376.85m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inH2O meets the static pressure, which is generated by a head of water at a temperature of 39,2°F with a height of 1 inch .
    /// </summary>
    public static IConvertibleUnit InchOfWater392F = new ConvertibleUnit()
    {
        Name = "inch of water (39.2 ºF)",
        Symbol = "inH₂O (39,2 ºF)",
        CommonCode = "N18",
        ConversionGroup = "pascal",
        ConversionFactor = 249.082m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure according to the Anglo-American and Imperial system for units, whereas the value of 1 inH2O meets the static pressure, which is generated by a head of water at a temperature of 60°F with a height of 1 inch .
    /// </summary>
    public static IConvertibleUnit InchOfWater60F = new ConvertibleUnit()
    {
        Name = "inch of water (60 ºF)",
        Symbol = "inH₂O (60 ºF)",
        CommonCode = "N19",
        ConversionGroup = "pascal",
        ConversionFactor = 248.84m,
    };
    /// <summary>
    /// Non SI-conforming unit of the pressure according to the Anglo-American system of units as the 1000-fold of the unit of the force pound-force divided by the power of the unit inch by exponent 2.
    /// </summary>
    public static IConvertibleUnit KipPerSquareInch = new ConvertibleUnit()
    {
        Name = "kip per square inch",
        Symbol = "ksi",
        CommonCode = "N20",
        ConversionGroup = "pascal",
        ConversionFactor = 6894757.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of pressure by the Imperial system of units according to NIST: 1 pdl/ft² = 1,488 164 Pa.
    /// </summary>
    public static IConvertibleUnit PoundalPerSquareFoot = new ConvertibleUnit()
    {
        Name = "poundal per square foot",
        Symbol = "pdl/ft²",
        CommonCode = "N21",
        ConversionGroup = "pascal",
        ConversionFactor = 1.488164m,
    };
    /// <summary>
    /// Unit of the surface specific mass (avoirdupois ounce according to the avoirdupois system of units according to the surface square inch according to the Anglo-American and Imperial system of units).
    /// </summary>
    public static IConvertibleUnit OunceAvoirdupoisPerSquareInch = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois) per square inch",
        Symbol = "oz/in²",
        CommonCode = "N22",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 43.94185m,
    };
    /// <summary>
    /// Not SI-conforming unit of pressure, whereas a value of 1 mH2O is equivalent to the static pressure, which is produced by one metre high water column .
    /// </summary>
    public static IConvertibleUnit ConventionalMetreOfWater = new ConvertibleUnit()
    {
        Name = "conventional metre of water",
        Symbol = "mH₂O",
        CommonCode = "N23",
        ConversionGroup = "pascal",
        ConversionFactor = 9806.65m,
    };
    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the 0.000 001-fold of the power of the SI base unit meter by exponent 2.
    /// </summary>
    public static IConvertibleUnit GramPerSquareMillimetre = new ConvertibleUnit()
    {
        Name = "gram per square millimetre",
        Symbol = "g/mm²",
        CommonCode = "N24",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// Unit for areal-related mass as a unit pound according to the avoirdupois unit system divided by the power of the unit yard according to the Anglo-American and Imperial system of units with exponent 2.
    /// </summary>
    public static IConvertibleUnit PoundPerSquareYard = new ConvertibleUnit()
    {
        Name = "pound per square yard",
        Symbol = "lb/yd²",
        CommonCode = "N25",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.5424919m,
    };
    /// <summary>
    /// Non SI-conforming unit of the pressure according to the Imperial system of units (poundal by square inch).
    /// </summary>
    public static IConvertibleUnit PoundalPerSquareInch = new ConvertibleUnit()
    {
        Name = "poundal per square inch",
        Symbol = "pdl/in²",
        CommonCode = "N26",
        ConversionGroup = "pascal",
        ConversionFactor = 214.2957m,
    };
    /// <summary>
    /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 4 according to NIST: 1 ft4 = 8,630 975 m4.
    /// </summary>
    public static IConvertibleUnit FootToTheFourthPower = new ConvertibleUnit()
    {
        Name = "foot to the fourth power",
        Symbol = "ft⁴",
        CommonCode = "N27",
        ConversionGroup = "meter ** 4",
        ConversionFactor = 0.008630974999999999m,
    };
    /// <summary>
    /// 0,001 fold of the power of the SI base unit meter by exponent 3 divided by the SI based unit kilogram.
    /// </summary>
    public static IConvertibleUnit CubicDecimetrePerKilogram = new ConvertibleUnit()
    {
        Name = "cubic decimetre per kilogram",
        Symbol = "dm³/kg",
        CommonCode = "N28",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// Power of the unit foot according to the Anglo-American and Imperial system of units by exponent 3 divided by the unit avoirdupois pound according to the avoirdupois unit system.
    /// </summary>
    public static IConvertibleUnit CubicFootPerPound = new ConvertibleUnit()
    {
        Name = "cubic foot per pound",
        Symbol = "ft³/lb",
        CommonCode = "N29",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.062427960000000005m,
    };
    public static IConvertibleUnit PrintPoint = new ConvertibleUnit()
    {
        Name = "print point",
        Symbol = null,
        CommonCode = "N3",
        ConversionGroup = "inch",
        ConversionFactor = 0.0138m,
    };
    /// <summary>
    /// Power of the unit inch according to the Anglo-American and Imperial system of units by exponent 3 divided by the avoirdupois pound according to the avoirdupois unit system .
    /// </summary>
    public static IConvertibleUnit CubicInchPerPound = new ConvertibleUnit()
    {
        Name = "cubic inch per pound",
        Symbol = "in³/lb",
        CommonCode = "N30",
        ConversionGroup = "meter ** 3 / kilogram",
        ConversionFactor = 0.00003612728000000001m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit newton divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit KilonewtonPerMetre = new ConvertibleUnit()
    {
        Name = "kilonewton per metre",
        Symbol = "kN/m",
        CommonCode = "N31",
        ConversionGroup = "newton / meter",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of the surface tension according to the Imperial unit system as quotient poundal by inch.
    /// </summary>
    public static IConvertibleUnit PoundalPerInch = new ConvertibleUnit()
    {
        Name = "poundal per inch",
        Symbol = "pdl/in",
        CommonCode = "N32",
        ConversionGroup = "newton / meter",
        ConversionFactor = 5.44311m,
    };
    /// <summary>
    /// Unit of force per unit length based on the Anglo-American system of units.
    /// </summary>
    public static IConvertibleUnit PoundforcePerYard = new ConvertibleUnit()
    {
        Name = "poundforce per yard",
        Symbol = "lbf/yd",
        CommonCode = "N33",
        ConversionGroup = "newton / meter",
        ConversionFactor = 4.864635m,
    };
    /// <summary>
    /// Non SI-conforming unit of viscosity.
    /// </summary>
    public static IConvertibleUnit PoundalSecondPerSquareFoot = new ConvertibleUnit()
    {
        Name = "poundal second per square foot",
        Symbol = "(pdl/ft²)·s",
        CommonCode = "N34",
        ConversionGroup = "pascal * second",
        ConversionFactor = 1.488164m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit poise divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit PoisePerPascal = new ConvertibleUnit()
    {
        Name = "poise per pascal",
        Symbol = "P/Pa",
        CommonCode = "N35",
        ConversionGroup = "second",
        ConversionFactor = 0.1m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a product of unit of the pressure (newton by square metre) multiplied with the SI base unit second.
    /// </summary>
    public static IConvertibleUnit NewtonSecondPerSquareMetre = new ConvertibleUnit()
    {
        Name = "newton second per square metre",
        Symbol = "(N/m²)·s",
        CommonCode = "N36",
        ConversionGroup = "pascal * second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit KilogramPerMetreSecond = new ConvertibleUnit()
    {
        Name = "kilogram per metre second",
        Symbol = "kg/(m·s)",
        CommonCode = "N37",
        ConversionGroup = "pascal * second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit minute.
    /// </summary>
    public static IConvertibleUnit KilogramPerMetreMinute = new ConvertibleUnit()
    {
        Name = "kilogram per metre minute",
        Symbol = "kg/(m·min)",
        CommonCode = "N38",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.016666700000000003m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit day.
    /// </summary>
    public static IConvertibleUnit KilogramPerMetreDay = new ConvertibleUnit()
    {
        Name = "kilogram per metre day",
        Symbol = "kg/(m·d)",
        CommonCode = "N39",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.000011574100000000002m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a quotient SI base unit kilogram divided by the SI base unit metre and by the unit hour.
    /// </summary>
    public static IConvertibleUnit KilogramPerMetreHour = new ConvertibleUnit()
    {
        Name = "kilogram per metre hour",
        Symbol = "kg/(m·h)",
        CommonCode = "N40",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity as a quotient of the 0,001-fold of the SI base unit kilogram divided by the 0,01-fold of the SI base unit metre and SI base unit second.
    /// </summary>
    public static IConvertibleUnit GramPerCentimetreSecond = new ConvertibleUnit()
    {
        Name = "gram per centimetre second",
        Symbol = "g/(cm·s)",
        CommonCode = "N41",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.1m,
    };
    /// <summary>
    /// Non SI-conforming unit of dynamic viscosity according to the Imperial system of units as product unit of the pressure (poundal by square inch) multiplied by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit PoundalSecondPerSquareInch = new ConvertibleUnit()
    {
        Name = "poundal second per square inch",
        Symbol = "(pdl/in²)·s",
        CommonCode = "N42",
        ConversionGroup = "pascal * second",
        ConversionFactor = 214.2957m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity according to the Anglo-American unit system.
    /// </summary>
    public static IConvertibleUnit PoundPerFootMinute = new ConvertibleUnit()
    {
        Name = "pound per foot minute",
        Symbol = "lb/(ft·min)",
        CommonCode = "N43",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.02480273m,
    };
    /// <summary>
    /// Unit of the dynamic viscosity according to the Anglo-American unit system.
    /// </summary>
    public static IConvertibleUnit PoundPerFootDay = new ConvertibleUnit()
    {
        Name = "pound per foot day",
        Symbol = "lb/(ft·d)",
        CommonCode = "N44",
        ConversionGroup = "pascal * second",
        ConversionFactor = 0.00001722412m,
    };
    /// <summary>
    /// Power of the SI base unit meter by exponent 3 divided by the product of the SI base unit second and the derived SI base unit pascal.
    /// </summary>
    public static IConvertibleUnit CubicMetrePerSecondPascal = new ConvertibleUnit()
    {
        Name = "cubic metre per second pascal",
        Symbol = "(m³/s)/Pa",
        CommonCode = "N45",
        ConversionGroup = "meter ** 4 * second / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the work (force-path).
    /// </summary>
    public static IConvertibleUnit FootPoundal = new ConvertibleUnit()
    {
        Name = "foot poundal",
        Symbol = "ft·pdl",
        CommonCode = "N46",
        ConversionGroup = "joule",
        ConversionFactor = 0.04214011m,
    };
    /// <summary>
    /// Unit of work (force multiplied by path) according to the Imperial system of units as a product unit inch multiplied by poundal.
    /// </summary>
    public static IConvertibleUnit InchPoundal = new ConvertibleUnit()
    {
        Name = "inch poundal",
        Symbol = "in·pdl",
        CommonCode = "N47",
        ConversionGroup = "joule",
        ConversionFactor = 0.0035116770000000004m,
    };
    /// <summary>
    /// Derived SI unit watt divided by the power of the 0,01-fold the SI base unit metre by exponent 2.
    /// </summary>
    public static IConvertibleUnit WattPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "watt per square centimetre",
        Symbol = "W/cm²",
        CommonCode = "N48",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    /// <summary>
    /// Derived SI unit watt divided by the power of the unit inch according to the Anglo-American and Imperial system of units by exponent 2.
    /// </summary>
    public static IConvertibleUnit WattPerSquareInch = new ConvertibleUnit()
    {
        Name = "watt per square inch",
        Symbol = "W/in²",
        CommonCode = "N49",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 1550.003m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSquareFootHour = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per square foot hour",
        Symbol = "BtuIT/(ft²·h)",
        CommonCode = "N50",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 3.154591m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSquareFootHour = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per square foot hour",
        Symbol = "Btuth/(ft²·h)",
        CommonCode = "N51",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 3.152481m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSquareFootMinute = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per square foot minute",
        Symbol = "Btuth/(ft²·min)",
        CommonCode = "N52",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 189.1489m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSquareFootSecond = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per square foot second",
        Symbol = "BtuIT/(ft²·s)",
        CommonCode = "N53",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 11356.53m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSquareFootSecond = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per square foot second",
        Symbol = "Btuth/(ft²·s)",
        CommonCode = "N54",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 11348.929999999998m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSquareInchSecond = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per square inch second",
        Symbol = "BtuIT/(in²·s)",
        CommonCode = "N55",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 1634246.0m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit CalorieThermochemicalPerSquareCentimetreMinute = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per square centimetre minute",
        Symbol = "calth/(cm²·min)",
        CommonCode = "N56",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 697.3333m,
    };
    /// <summary>
    /// Unit of the surface heat flux according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit CalorieThermochemicalPerSquareCentimetreSecond = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per square centimetre second",
        Symbol = "calth/(cm²·s)",
        CommonCode = "N57",
        ConversionGroup = "watt / meter ** 2",
        ConversionFactor = 41840.0m,
    };
    /// <summary>
    /// Unit of the energy density according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerCubicFoot = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per cubic foot",
        Symbol = "BtuIT/ft³",
        CommonCode = "N58",
        ConversionGroup = "joule / meter ** 3",
        ConversionFactor = 37258.95m,
    };
    /// <summary>
    /// Unit of the energy density according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerCubicFoot = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per cubic foot",
        Symbol = "Btuth/ft³",
        CommonCode = "N59",
        ConversionGroup = "joule / meter ** 3",
        ConversionFactor = 37234.03m,
    };
    /// <summary>
    /// Unit of the heat capacity according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per degree Fahrenheit",
        Symbol = "BtuIT/ºF",
        CommonCode = "N60",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1899.1009999999999m,
    };
    /// <summary>
    /// Unit of the heat capacity according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per degree Fahrenheit",
        Symbol = "Btuth/ºF",
        CommonCode = "N61",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1897.83m,
    };
    /// <summary>
    /// Unit of the heat capacity according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per degree Rankine",
        Symbol = "BtuIT/ºR",
        CommonCode = "N62",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1899.1009999999999m,
    };
    /// <summary>
    /// Unit of the heat capacity according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per degree Rankine",
        Symbol = "Btuth/ºR",
        CommonCode = "N63",
        ConversionGroup = "joule / kelvin",
        ConversionFactor = 1897.83m,
    };
    /// <summary>
    /// Unit of the heat capacity (British thermal unit according to the international table according to the Rankine degree) according to the Imperial system of units divided by the unit avoirdupois pound according to the avoirdupois system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerPoundDegreeRankine = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per pound degree Rankine",
        Symbol = "(Btuth/°R)/lb",
        CommonCode = "N64",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4184.0m,
    };
    /// <summary>
    /// Unit of the mass-related heat capacity as quotient 1000-fold of the calorie (international table) divided by the product of the 0,001-fold of the SI base units kilogram and kelvin.
    /// </summary>
    public static IConvertibleUnit KilocalorieInternationalTablePerGramKelvin = new ConvertibleUnit()
    {
        Name = "kilocalorie (international table) per gram kelvin",
        Symbol = "(kcalIT/K)/g",
        CommonCode = "N65",
        ConversionGroup = "joule / kelvin / kilogram",
        ConversionFactor = 4186800.0m,
    };
    /// <summary>
    /// Unit of heat energy according to the Imperial system of units in a reference temperature of 39 °F.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnit39F = new ConvertibleUnit()
    {
        Name = "British thermal unit (39 ºF)",
        Symbol = "Btu (39 ºF)",
        CommonCode = "N66",
        ConversionGroup = "joule",
        ConversionFactor = 1059.6699999999998m,
    };
    /// <summary>
    /// Unit of heat energy according to the Imperial system of units in a reference temperature of 59 °F.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnit59F = new ConvertibleUnit()
    {
        Name = "British thermal unit (59 ºF)",
        Symbol = "Btu (59 ºF)",
        CommonCode = "N67",
        ConversionGroup = "joule",
        ConversionFactor = 1054.8m,
    };
    /// <summary>
    /// Unit of head energy according to the Imperial system of units at a reference temperature of 60 °F.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnit60F = new ConvertibleUnit()
    {
        Name = "British thermal unit (60 ºF)",
        Symbol = "Btu (60 ºF)",
        CommonCode = "N68",
        ConversionGroup = "joule",
        ConversionFactor = 1054.68m,
    };
    /// <summary>
    /// Unit for quantity of heat, which is to be required for 1 g air free water at a constant pressure from 101,325 kPa, to warm up the pressure of standard atmosphere at sea level, from 19,5 °C on 20,5 °C.
    /// </summary>
    public static IConvertibleUnit Calorie20C = new ConvertibleUnit()
    {
        Name = "calorie (20 ºC)",
        Symbol = "cal₂₀",
        CommonCode = "N69",
        ConversionGroup = "dimensionless",
        ConversionFactor = 4.1819m,
    };
    /// <summary>
    /// Unit of heat energy according to the imperial system of units.
    /// </summary>
    public static IConvertibleUnit Quad1015Btuit = new ConvertibleUnit()
    {
        Name = "quad (1015 BtuIT)",
        Symbol = "quad",
        CommonCode = "N70",
        ConversionGroup = "joule",
        ConversionFactor = 1055056000000000000m,
    };
    /// <summary>
    /// Unit of heat energy in commercial use, within the EU defined: 1 thm (EC) = 100 000 BtuIT.
    /// </summary>
    public static IConvertibleUnit ThermEC = new ConvertibleUnit()
    {
        Name = "therm (EC)",
        Symbol = "thm (EC)",
        CommonCode = "N71",
        ConversionGroup = "joule",
        ConversionFactor = 105506000.00000001m,
    };
    /// <summary>
    /// Unit of heat energy in commercial use.
    /// </summary>
    public static IConvertibleUnit ThermUS = new ConvertibleUnit()
    {
        Name = "therm (U.S.)",
        Symbol = "thm (US)",
        CommonCode = "N72",
        ConversionGroup = "joule",
        ConversionFactor = 105480400.00000001m,
    };
    /// <summary>
    /// Unit of the heat energy according to the Imperial system of units divided the unit avoirdupois pound according to the avoirdupois system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerPound = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per pound",
        Symbol = "Btuth/lb",
        CommonCode = "N73",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 2324.444m,
    };
    /// <summary>
    /// Unit of the heat transition coefficient according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per hour square foot degree Fahrenheit",
        Symbol = "BtuIT/(h·ft²·ºF)",
        CommonCode = "N74",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 5.678263m,
    };
    /// <summary>
    /// Unit of the heat transition coefficient according to the imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerHourSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per hour square foot degree Fahrenheit",
        Symbol = "Btuth/(h·ft²·ºF)",
        CommonCode = "N75",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 5.674466m,
    };
    /// <summary>
    /// Unit of the heat transition coefficient according to the imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSecondSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per second square foot degree Fahrenheit",
        Symbol = "BtuIT/(s·ft²·ºF)",
        CommonCode = "N76",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 20441.75m,
    };
    /// <summary>
    /// Unit of the heat transition coefficient according to the imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSecondSquareFootDegreeFahrenheit = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per second square foot degree Fahrenheit",
        Symbol = "Btuth/(s·ft²·ºF)",
        CommonCode = "N77",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 20428.079999999998m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit watt divided by the product of the power of the SI base unit metre by exponent 2 and the SI base unit kelvin.
    /// </summary>
    public static IConvertibleUnit KilowattPerSquareMetreKelvin = new ConvertibleUnit()
    {
        Name = "kilowatt per square metre kelvin",
        Symbol = "kW/(m²·K)",
        CommonCode = "N78",
        ConversionGroup = "watt / kelvin / meter ** 2",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// SI base unit kelvin divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit KelvinPerPascal = new ConvertibleUnit()
    {
        Name = "kelvin per pascal",
        Symbol = "K/Pa",
        CommonCode = "N79",
        ConversionGroup = "kelvin * meter * second ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Derived SI unit watt divided by the product of the SI base unit metre and the unit for temperature degree Celsius.
    /// </summary>
    public static IConvertibleUnit WattPerMetreDegreeCelsius = new ConvertibleUnit()
    {
        Name = "watt per metre degree Celsius",
        Symbol = "W/(m·°C)",
        CommonCode = "N80",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit watt divided by the product of the SI base unit metre and the SI base unit kelvin.
    /// </summary>
    public static IConvertibleUnit KilowattPerMetreKelvin = new ConvertibleUnit()
    {
        Name = "kilowatt per metre kelvin",
        Symbol = "kW/(m·K)",
        CommonCode = "N81",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit watt divided by the product of the SI base unit metre and the unit for temperature degree Celsius.
    /// </summary>
    public static IConvertibleUnit KilowattPerMetreDegreeCelsius = new ConvertibleUnit()
    {
        Name = "kilowatt per metre degree Celsius",
        Symbol = "kW/(m·°C)",
        CommonCode = "N82",
        ConversionGroup = "watt / kelvin / meter",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// SI base unit metre divided by the product of the unit degree Celsius and the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit MetrePerDegreeCelciusMetre = new ConvertibleUnit()
    {
        Name = "metre per degree Celcius metre",
        Symbol = "m/(°C·m)",
        CommonCode = "N83",
        ConversionGroup = "1 / kelvin",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitHourPerBritishThermalUnitInternationalTable = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour per British thermal unit (international table)",
        Symbol = "ºF/(BtuIT/h)",
        CommonCode = "N84",
        ConversionGroup = "kelvin / watt",
        ConversionFactor = 1.895634m,
    };
    /// <summary>
    /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitHourPerBritishThermalUnitThermochemical = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour per British thermal unit (thermochemical)",
        Symbol = "ºF/(Btuth/h)",
        CommonCode = "N85",
        ConversionGroup = "kelvin / watt",
        ConversionFactor = 1.896903m,
    };
    /// <summary>
    /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitSecondPerBritishThermalUnitInternationalTable = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit second per British thermal unit (international table)",
        Symbol = "ºF/(BtuIT/s)",
        CommonCode = "N86",
        ConversionGroup = "kelvin / watt",
        ConversionFactor = 0.0005265651m,
    };
    /// <summary>
    /// Non SI-conforming unit of the thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitSecondPerBritishThermalUnitThermochemical = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit second per British thermal unit (thermochemical)",
        Symbol = "ºF/(Btuth/s)",
        CommonCode = "N87",
        ConversionGroup = "kelvin / watt",
        ConversionFactor = 0.0005269175m,
    };
    /// <summary>
    /// Unit of specific thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitHourSquareFootPerBritishThermalUnitInternationalTableInch = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour square foot per British thermal unit (international table) inch",
        Symbol = "ºF·h·ft²/(BtuIT·in)",
        CommonCode = "N88",
        ConversionGroup = "kelvin * meter / watt",
        ConversionFactor = 6.933472m,
    };
    /// <summary>
    /// Unit of specific thermal resistance according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit DegreeFahrenheitHourSquareFootPerBritishThermalUnitThermochemicalInch = new ConvertibleUnit()
    {
        Name = "degree Fahrenheit hour square foot per British thermal unit (thermochemical) inch",
        Symbol = "ºF·h·ft²/(Btuth·in)",
        CommonCode = "N89",
        ConversionGroup = "kelvin * meter / watt",
        ConversionFactor = 6.938112m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit farad.
    /// </summary>
    public static IConvertibleUnit Kilofarad = new ConvertibleUnit()
    {
        Name = "kilofarad",
        Symbol = "kF",
        CommonCode = "N90",
        ConversionGroup = "farad",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// Reciprocal of the derived SI unit joule.
    /// </summary>
    public static IConvertibleUnit ReciprocalJoule = new ConvertibleUnit()
    {
        Name = "reciprocal joule",
        Symbol = "1/J",
        CommonCode = "N91",
        ConversionGroup = "1 / joule",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 0,000 000 000 001-fold of the derived SI unit siemens.
    /// </summary>
    public static IConvertibleUnit Picosiemens = new ConvertibleUnit()
    {
        Name = "picosiemens",
        Symbol = "pS",
        CommonCode = "N92",
        ConversionGroup = "siemens",
        ConversionFactor = 0.000000000001m,
    };
    /// <summary>
    /// SI base unit ampere divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit AmperePerPascal = new ConvertibleUnit()
    {
        Name = "ampere per pascal",
        Symbol = "A/Pa",
        CommonCode = "N93",
        ConversionGroup = "ampere * meter * second ** 2 / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the electrical charge, where the charge amounts to exactly 1 Fr where the force of 1 dyn on an equal load is performed at a distance of 1 cm.
    /// </summary>
    public static IConvertibleUnit Franklin = new ConvertibleUnit()
    {
        Name = "franklin",
        Symbol = "Fr",
        CommonCode = "N94",
        ConversionGroup = "coulomb",
        ConversionFactor = 0.0000000003335641m,
    };
    /// <summary>
    /// A unit of electric charge defining the amount of charge accumulated by a steady flow of one ampere for one minute..
    /// </summary>
    public static IConvertibleUnit AmpereMinute = new ConvertibleUnit()
    {
        Name = "ampere minute",
        Symbol = "A·min",
        CommonCode = "N95",
        ConversionGroup = "coulomb",
        ConversionFactor = 60m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the electric power which is defined by a force of 2 dyn per cm between two parallel conductors of infinite length with negligible cross-section in the distance of 1 cm.
    /// </summary>
    public static IConvertibleUnit Biot = new ConvertibleUnit()
    {
        Name = "biot",
        Symbol = "Bi",
        CommonCode = "N96",
        ConversionGroup = "ampere",
        ConversionFactor = 10m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the magnetomotive force, which is defined by the work to increase the magnetic potential of a positive common pol with 1 erg.
    /// </summary>
    public static IConvertibleUnit Gilbert = new ConvertibleUnit()
    {
        Name = "gilbert",
        Symbol = "Gi",
        CommonCode = "N97",
        ConversionGroup = "ampere",
        ConversionFactor = 0.7957747000000001m,
    };
    /// <summary>
    /// Derived SI unit volt divided by the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit VoltPerPascal = new ConvertibleUnit()
    {
        Name = "volt per pascal",
        Symbol = "V/Pa",
        CommonCode = "N98",
        ConversionGroup = "meter ** 3 / ampere / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 0,000 000 000 001-fold of the derived SI unit volt.
    /// </summary>
    public static IConvertibleUnit Picovolt = new ConvertibleUnit()
    {
        Name = "picovolt",
        Symbol = "pV",
        CommonCode = "N99",
        ConversionGroup = "volt",
        ConversionFactor = 0.000000000001m,
    };
    public static IConvertibleUnit MilligramPerKilogram = new ConvertibleUnit()
    {
        Name = "milligram per kilogram",
        Symbol = "mg/kg",
        CommonCode = "NA",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// A unit of count defining the number of articles (article: item).
    /// </summary>
    public static IUnit NumberOfArticles = new Unit()
    {
        Name = "number of articles",
        Symbol = null,
        CommonCode = "NAR",
    };
    /// <summary>
    /// A unit of count defining the number of cells (cell: an enclosed or circumscribed space, cavity, or volume).
    /// </summary>
    public static IUnit NumberOfCells = new Unit()
    {
        Name = "number of cells",
        Symbol = null,
        CommonCode = "NCL",
    };
    public static IConvertibleUnit Newton = new ConvertibleUnit()
    {
        Name = "newton",
        Symbol = "N",
        CommonCode = "NEW",
        ConversionGroup = "kilogram * meter / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of messages.
    /// </summary>
    public static IUnit Message = new Unit()
    {
        Name = "message",
        Symbol = null,
        CommonCode = "NF",
    };
    /// <summary>
    /// A unit of count defining the number of instances of nothing.
    /// </summary>
    public static IUnit Nil = new Unit()
    {
        Name = "nil",
        Symbol = "()",
        CommonCode = "NIL",
    };
    /// <summary>
    /// A unit of count defining the number of international units.
    /// </summary>
    public static IUnit NumberOfInternationalUnits = new Unit()
    {
        Name = "number of international units",
        Symbol = null,
        CommonCode = "NIU",
    };
    /// <summary>
    /// A unit of volume defining the number of loads (load: a quantity of items carried or processed at one time).
    /// </summary>
    public static IUnit Load = new Unit()
    {
        Name = "load",
        Symbol = null,
        CommonCode = "NL",
    };
    /// <summary>
    /// Normalised cubic metre (temperature 0°C and pressure 1013.25 millibars )
    /// </summary>
    public static IConvertibleUnit NormalisedCubicMetre = new ConvertibleUnit()
    {
        Name = "Normalised cubic metre",
        Symbol = null,
        CommonCode = "NM3",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit NauticalMile = new ConvertibleUnit()
    {
        Name = "nautical mile",
        Symbol = "n mile",
        CommonCode = "NMI",
        ConversionGroup = "meter",
        ConversionFactor = 1852m,
    };
    /// <summary>
    /// A unit of count defining the number of packs (pack: a collection of objects packaged together).
    /// </summary>
    public static IUnit NumberOfPacks = new Unit()
    {
        Name = "number of packs",
        Symbol = null,
        CommonCode = "NMP",
    };
    /// <summary>
    /// A unit of count defining the number of parts (part: component of a larger entity).
    /// </summary>
    public static IUnit NumberOfParts = new Unit()
    {
        Name = "number of parts",
        Symbol = null,
        CommonCode = "NPT",
    };
    /// <summary>
    /// A unit of mass equal to 2000 pounds, see ton (US).  Refer International Convention on tonnage measurement of Ships.
    /// </summary>
    public static IUnit NetTon = new Unit()
    {
        Name = "net ton",
        Symbol = null,
        CommonCode = "NT",
    };
    public static IConvertibleUnit NewtonMetre = new ConvertibleUnit()
    {
        Name = "newton metre",
        Symbol = "N·m",
        CommonCode = "NU",
        ConversionGroup = "meter * newton",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of proportion equal to 10⁻³. Synonym: per mille
    /// </summary>
    public static IConvertibleUnit PartPerThousand = new ConvertibleUnit()
    {
        Name = "part per thousand",
        Symbol = "‰",
        CommonCode = "NX",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// A unit of count defining the number of panels (panel: a distinct, usually rectangular, section of a surface).
    /// </summary>
    public static IUnit Panel = new Unit()
    {
        Name = "panel",
        Symbol = null,
        CommonCode = "OA",
    };
    /// <summary>
    /// A unit of mass defining the ozone depletion potential in kilograms of a product relative to the calculated depletion for the reference substance, Trichlorofluoromethane (CFC-11).
    /// </summary>
    public static IUnit OzoneDepletionEquivalent = new Unit()
    {
        Name = "ozone depletion equivalent",
        Symbol = null,
        CommonCode = "ODE",
    };
    /// <summary>
    /// A unit of measure calculated by multiplying the mass of the substance in grams and the ozone-depleting potential for the substance.
    /// </summary>
    public static IUnit ODSGrams = new Unit()
    {
        Name = "ODS Grams",
        Symbol = null,
        CommonCode = "ODG",
    };
    /// <summary>
    /// A unit of measure calculated by multiplying the mass of the substance in kilograms and the ozone-depleting potential for the substance.
    /// </summary>
    public static IUnit ODSKilograms = new Unit()
    {
        Name = "ODS Kilograms",
        Symbol = null,
        CommonCode = "ODK",
    };
    /// <summary>
    /// A unit of measure calculated by multiplying the mass of the substance in milligrams and the ozone-depleting potential for the substance.
    /// </summary>
    public static IUnit ODSMilligrams = new Unit()
    {
        Name = "ODS Milligrams",
        Symbol = null,
        CommonCode = "ODM",
    };
    public static IConvertibleUnit Ohm = new ConvertibleUnit()
    {
        Name = "ohm",
        Symbol = "Ω",
        CommonCode = "OHM",
        ConversionGroup = "ohm",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit OuncePerSquareYard = new ConvertibleUnit()
    {
        Name = "ounce per square yard",
        Symbol = "oz/yd²",
        CommonCode = "ON",
        ConversionGroup = "kilogram / meter ** 2",
        ConversionFactor = 0.033905750000000005m,
    };
    public static IConvertibleUnit OunceAvoirdupois = new ConvertibleUnit()
    {
        Name = "ounce (avoirdupois)",
        Symbol = "oz",
        CommonCode = "ONZ",
        ConversionGroup = "kilogram",
        ConversionFactor = 0.02834952m,
    };
    /// <summary>
    /// The number of oscillations per minute.
    /// </summary>
    public static IConvertibleUnit OscillationsPerMinute = new ConvertibleUnit()
    {
        Name = "oscillations per minute",
        Symbol = "o/min",
        CommonCode = "OPM",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.01667m,
    };
    /// <summary>
    /// A unit of time defining the number of overtime hours.
    /// </summary>
    public static IUnit OvertimeHour = new Unit()
    {
        Name = "overtime hour",
        Symbol = null,
        CommonCode = "OT",
    };
    public static IConvertibleUnit FluidOunceUS = new ConvertibleUnit()
    {
        Name = "fluid ounce (US)",
        Symbol = "fl oz (US)",
        CommonCode = "OZA",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000029573530000000003m,
    };
    public static IConvertibleUnit FluidOunceUK = new ConvertibleUnit()
    {
        Name = "fluid ounce (UK)",
        Symbol = "fl oz (UK)",
        CommonCode = "OZI",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.00002841306m,
    };
    /// <summary>
    /// A unit of proportion equal to 0.01.
    /// </summary>
    public static IConvertibleUnit Percent = new ConvertibleUnit()
    {
        Name = "percent",
        Symbol = "% or pct",
        CommonCode = "P1",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// Derived SI unit coulomb divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit CoulombPerMetre = new ConvertibleUnit()
    {
        Name = "coulomb per metre",
        Symbol = "C/m",
        CommonCode = "P10",
        ConversionGroup = "ampere * second / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 1000 fold of the derived SI unit weber.
    /// </summary>
    public static IConvertibleUnit Kiloweber = new ConvertibleUnit()
    {
        Name = "kiloweber",
        Symbol = "kWb",
        CommonCode = "P11",
        ConversionGroup = "weber",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// Unit of magnetic flow density.
    /// </summary>
    public static IConvertibleUnit Gamma = new ConvertibleUnit()
    {
        Name = "gamma",
        Symbol = "γ",
        CommonCode = "P12",
        ConversionGroup = "tesla",
        ConversionFactor = 0.000000001m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit tesla.
    /// </summary>
    public static IConvertibleUnit Kilotesla = new ConvertibleUnit()
    {
        Name = "kilotesla",
        Symbol = "kT",
        CommonCode = "P13",
        ConversionGroup = "tesla",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// Quotient of the derived SI unit joule divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit JoulePerSecond = new ConvertibleUnit()
    {
        Name = "joule per second",
        Symbol = "J/s",
        CommonCode = "P14",
        ConversionGroup = "watt",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Quotient from the derived SI unit joule divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit JoulePerMinute = new ConvertibleUnit()
    {
        Name = "joule per minute",
        Symbol = "J/min",
        CommonCode = "P15",
        ConversionGroup = "watt",
        ConversionFactor = 0.016666700000000003m,
    };
    /// <summary>
    /// Quotient from the derived SI unit joule divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit JoulePerHour = new ConvertibleUnit()
    {
        Name = "joule per hour",
        Symbol = "J/h",
        CommonCode = "P16",
        ConversionGroup = "watt",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// Quotient from the derived SI unit joule divided by the unit day.
    /// </summary>
    public static IConvertibleUnit JoulePerDay = new ConvertibleUnit()
    {
        Name = "joule per day",
        Symbol = "J/d",
        CommonCode = "P17",
        ConversionGroup = "watt",
        ConversionFactor = 0.000011574100000000002m,
    };
    /// <summary>
    /// Quotient from the 1000-fold of the derived SI unit joule divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit KilojoulePerSecond = new ConvertibleUnit()
    {
        Name = "kilojoule per second",
        Symbol = "kJ/s",
        CommonCode = "P18",
        ConversionGroup = "watt",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit KilojoulePerMinute = new ConvertibleUnit()
    {
        Name = "kilojoule per minute",
        Symbol = "kJ/min",
        CommonCode = "P19",
        ConversionGroup = "watt",
        ConversionFactor = 16.666700000000002m,
    };
    public static IConvertibleUnit PoundPerFoot = new ConvertibleUnit()
    {
        Name = "pound per foot",
        Symbol = "lb/ft",
        CommonCode = "P2",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 1.488164m,
    };
    /// <summary>
    /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit KilojoulePerHour = new ConvertibleUnit()
    {
        Name = "kilojoule per hour",
        Symbol = "kJ/h",
        CommonCode = "P20",
        ConversionGroup = "watt",
        ConversionFactor = 0.277778m,
    };
    /// <summary>
    /// Quotient from the 1000-fold of the derived SI unit joule divided by the unit day.
    /// </summary>
    public static IConvertibleUnit KilojoulePerDay = new ConvertibleUnit()
    {
        Name = "kilojoule per day",
        Symbol = "kJ/d",
        CommonCode = "P21",
        ConversionGroup = "watt",
        ConversionFactor = 0.0115741m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit ohm.
    /// </summary>
    public static IConvertibleUnit Nanoohm = new ConvertibleUnit()
    {
        Name = "nanoohm",
        Symbol = "nΩ",
        CommonCode = "P22",
        ConversionGroup = "ohm",
        ConversionFactor = 0.000000001m,
    };
    /// <summary>
    /// Unit of resistivity.
    /// </summary>
    public static IConvertibleUnit OhmCircularmilPerFoot = new ConvertibleUnit()
    {
        Name = "ohm circularmil per foot",
        Symbol = "Ω·cmil/ft",
        CommonCode = "P23",
        ConversionGroup = "meter * ohm",
        ConversionFactor = 0.000000001662426m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit henry.
    /// </summary>
    public static IConvertibleUnit Kilohenry = new ConvertibleUnit()
    {
        Name = "kilohenry",
        Symbol = "kH",
        CommonCode = "P24",
        ConversionGroup = "henry",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// Derived SI unit lumen divided by the power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2.
    /// </summary>
    public static IConvertibleUnit LumenPerSquareFoot = new ConvertibleUnit()
    {
        Name = "lumen per square foot",
        Symbol = "lm/ft²",
        CommonCode = "P25",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 10.763910000000001m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as lumen by square centimetre.
    /// </summary>
    public static IConvertibleUnit Phot = new ConvertibleUnit()
    {
        Name = "phot",
        Symbol = "ph",
        CommonCode = "P26",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    /// <summary>
    /// Non SI conform traditional unit, defined as density of light which impinges on a surface which has a distance of one foot from a light source, which shines with an intensity of an international candle.
    /// </summary>
    public static IConvertibleUnit Footcandle = new ConvertibleUnit()
    {
        Name = "footcandle",
        Symbol = "ftc",
        CommonCode = "P27",
        ConversionGroup = "candela * steradian / meter ** 2",
        ConversionFactor = 10.763910000000001m,
    };
    /// <summary>
    /// SI base unit candela divided by the power of unit inch according to the Anglo-American and Imperial system of units by exponent 2.
    /// </summary>
    public static IConvertibleUnit CandelaPerSquareInch = new ConvertibleUnit()
    {
        Name = "candela per square inch",
        Symbol = "cd/in²",
        CommonCode = "P28",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 1550.003m,
    };
    /// <summary>
    /// Unit of the luminance according to the Anglo-American system of units, defined as emitted or reflected luminance of a lm/ft².
    /// </summary>
    public static IConvertibleUnit Footlambert = new ConvertibleUnit()
    {
        Name = "footlambert",
        Symbol = "ftL",
        CommonCode = "P29",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 3.426259m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as the emitted or reflected luminance by one lumen per square centimetre.
    /// </summary>
    public static IConvertibleUnit Lambert = new ConvertibleUnit()
    {
        Name = "lambert",
        Symbol = "Lb",
        CommonCode = "P30",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 3183.0989999999997m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of luminance, defined as emitted or reflected luminance by one lumen per square centimetre.
    /// </summary>
    public static IConvertibleUnit Stilb = new ConvertibleUnit()
    {
        Name = "stilb",
        Symbol = "sb",
        CommonCode = "P31",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 10000.0m,
    };
    /// <summary>
    /// Base unit SI candela divided by the power of the unit foot according to the Anglo-American and Imperial system of units by exponent 2.
    /// </summary>
    public static IConvertibleUnit CandelaPerSquareFoot = new ConvertibleUnit()
    {
        Name = "candela per square foot",
        Symbol = "cd/ft²",
        CommonCode = "P32",
        ConversionGroup = "candela / meter ** 2",
        ConversionFactor = 10.763910000000001m,
    };
    /// <summary>
    /// 1000-fold of the SI base unit candela.
    /// </summary>
    public static IConvertibleUnit Kilocandela = new ConvertibleUnit()
    {
        Name = "kilocandela",
        Symbol = "kcd",
        CommonCode = "P33",
        ConversionGroup = "candela",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// 0,001-fold of the SI base unit candela.
    /// </summary>
    public static IConvertibleUnit Millicandela = new ConvertibleUnit()
    {
        Name = "millicandela",
        Symbol = "mcd",
        CommonCode = "P34",
        ConversionGroup = "candela",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// Obsolete, non-legal unit of the power in Germany relating to DIN 1301-3:1979: 1 HK = 0,903 cd.
    /// </summary>
    public static IConvertibleUnit Hefnerkerze = new ConvertibleUnit()
    {
        Name = "HefnerKerze",
        Symbol = "HK",
        CommonCode = "P35",
        ConversionGroup = "candela",
        ConversionFactor = 0.903m,
    };
    /// <summary>
    /// Obsolete, non-legal unit of the power in Germany relating to DIN 1301-3:1979: 1 HK = 1,019 cd.
    /// </summary>
    public static IConvertibleUnit InternationalCandle = new ConvertibleUnit()
    {
        Name = "international candle",
        Symbol = "IK",
        CommonCode = "P36",
        ConversionGroup = "candela",
        ConversionFactor = 1.019m,
    };
    /// <summary>
    /// Unit of the areal-related energy transmission according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitInternationalTablePerSquareFoot = new ConvertibleUnit()
    {
        Name = "British thermal unit (international table) per square foot",
        Symbol = "BtuIT/ft²",
        CommonCode = "P37",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 11356.53m,
    };
    /// <summary>
    /// Unit of the areal-related energy transmission according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit BritishThermalUnitThermochemicalPerSquareFoot = new ConvertibleUnit()
    {
        Name = "British thermal unit (thermochemical) per square foot",
        Symbol = "Btuth/ft²",
        CommonCode = "P38",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 11348.929999999998m,
    };
    /// <summary>
    /// Unit of the areal-related energy transmission according to the Imperial system of units.
    /// </summary>
    public static IConvertibleUnit CalorieThermochemicalPerSquareCentimetre = new ConvertibleUnit()
    {
        Name = "calorie (thermochemical) per square centimetre",
        Symbol = "calth/cm²",
        CommonCode = "P39",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 41840.0m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the areal-related energy transmission (as a measure of the incident quantity of heat of solar radiation on the earth's surface).
    /// </summary>
    public static IConvertibleUnit Langley = new ConvertibleUnit()
    {
        Name = "langley",
        Symbol = "Ly",
        CommonCode = "P40",
        ConversionGroup = "joule / meter ** 2",
        ConversionFactor = 41840.0m,
    };
    /// <summary>
    /// 1 Dec := log2 10 ˜ 3,32 according to the logarithm for frequency range between f1 and f2, when f2/f1 = 10.
    /// </summary>
    public static IConvertibleUnit DecadeLogarithmic = new ConvertibleUnit()
    {
        Name = "decade (logarithmic)",
        Symbol = "dec",
        CommonCode = "P41",
        ConversionGroup = "dec",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit of the set as a product of the power of derived SI unit pascal with exponent 2 and the SI base unit second.
    /// </summary>
    public static IConvertibleUnit PascalSquaredSecond = new ConvertibleUnit()
    {
        Name = "pascal squared second",
        Symbol = "Pa²·s",
        CommonCode = "P42",
        ConversionGroup = "kilogram ** 2 / meter ** 2 / second ** 3",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit bel divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit BelPerMetre = new ConvertibleUnit()
    {
        Name = "bel per metre",
        Symbol = "B/m",
        CommonCode = "P43",
        ConversionGroup = "byte / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of quantity of a substance relating that one pound mole of a chemical composition corresponds to the same number of pounds as the molecular weight of one molecule of this composition in atomic mass units.
    /// </summary>
    public static IConvertibleUnit PoundMole = new ConvertibleUnit()
    {
        Name = "pound mole",
        Symbol = "lbmol",
        CommonCode = "P44",
        ConversionGroup = "mole",
        ConversionFactor = 453.5924m,
    };
    /// <summary>
    /// Non SI-conforming unit of the power of the amount of substance non-SI compliant unit of the molar flux relating that a pound mole of a chemical composition the same number of pound corresponds like the molecular weight of a molecule of this composition in atomic mass units.
    /// </summary>
    public static IConvertibleUnit PoundMolePerSecond = new ConvertibleUnit()
    {
        Name = "pound mole per second",
        Symbol = "lbmol/s",
        CommonCode = "P45",
        ConversionGroup = "mole / second",
        ConversionFactor = 453.59239999999994m,
    };
    /// <summary>
    /// Non SI-conforming unit of the power of the amount of substance non-SI compliant unit of the molar flux relating that a pound mole of a chemical composition the same number of pound corresponds like the molecular weight of a molecule of this composition in atomic mass units.
    /// </summary>
    public static IConvertibleUnit PoundMolePerMinute = new ConvertibleUnit()
    {
        Name = "pound mole per minute",
        Symbol = "lbmol/h",
        CommonCode = "P46",
        ConversionGroup = "mole / second",
        ConversionFactor = 7.559873m,
    };
    /// <summary>
    /// 1000-fold of the SI base unit mol divided by the SI base unit kilogram.
    /// </summary>
    public static IConvertibleUnit KilomolePerKilogram = new ConvertibleUnit()
    {
        Name = "kilomole per kilogram",
        Symbol = "kmol/kg",
        CommonCode = "P47",
        ConversionGroup = "mole / kilogram",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of the material molar flux divided by the avoirdupois pound for mass according to the avoirdupois unit system.
    /// </summary>
    public static IConvertibleUnit PoundMolePerPound = new ConvertibleUnit()
    {
        Name = "pound mole per pound",
        Symbol = "lbmol/lb",
        CommonCode = "P48",
        ConversionGroup = "mole / kilogram",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// Product of the derived SI unit newton and the power of SI base unit metre with exponent 2 divided by the SI base unit ampere.
    /// </summary>
    public static IConvertibleUnit NewtonSquareMetrePerAmpere = new ConvertibleUnit()
    {
        Name = "newton square metre per ampere",
        Symbol = "N·m²/A",
        CommonCode = "P49",
        ConversionGroup = "kilogram * meter ** 3 / ampere / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of count defining the number of five-packs (five-pack: set of five items packaged together).
    /// </summary>
    public static IUnit FivePack = new Unit()
    {
        Name = "five pack",
        Symbol = null,
        CommonCode = "P5",
    };
    /// <summary>
    /// Product of the derived SI unit weber and SI base unit metre.
    /// </summary>
    public static IConvertibleUnit WeberMetre = new ConvertibleUnit()
    {
        Name = "weber metre",
        Symbol = "Wb·m",
        CommonCode = "P50",
        ConversionGroup = "kilogram * meter ** 3 / ampere / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// SI base unit mol divided by the product of the SI base unit kilogram and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit MolPerKilogramPascal = new ConvertibleUnit()
    {
        Name = "mol per kilogram pascal",
        Symbol = "(mol/kg)/Pa",
        CommonCode = "P51",
        ConversionGroup = "meter * mole * second ** 2 / kilogram ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// SI base unit mol divided by the product of the power from the SI base unit metre with exponent 3 and the derived SI unit pascal.
    /// </summary>
    public static IConvertibleUnit MolPerCubicMetrePascal = new ConvertibleUnit()
    {
        Name = "mol per cubic metre pascal",
        Symbol = "(mol/m³)/Pa",
        CommonCode = "P52",
        ConversionGroup = "mole * second ** 2 / kilogram / meter ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit for magnetic flux of a magnetic pole (according to the interaction of identical poles of 1 dyn at a distance of a cm).
    /// </summary>
    public static IConvertibleUnit UnitPole = new ConvertibleUnit()
    {
        Name = "unit pole",
        Symbol = "unit pole",
        CommonCode = "P53",
        ConversionGroup = "weber",
        ConversionFactor = 0.0000001256637m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit gray divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit MilligrayPerSecond = new ConvertibleUnit()
    {
        Name = "milligray per second",
        Symbol = "mGy/s",
        CommonCode = "P54",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit gray divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit MicrograyPerSecond = new ConvertibleUnit()
    {
        Name = "microgray per second",
        Symbol = "µGy/s",
        CommonCode = "P55",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit gray divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit NanograyPerSecond = new ConvertibleUnit()
    {
        Name = "nanogray per second",
        Symbol = "nGy/s",
        CommonCode = "P56",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000000001m,
    };
    /// <summary>
    /// SI derived unit gray divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit GrayPerMinute = new ConvertibleUnit()
    {
        Name = "gray per minute",
        Symbol = "Gy/min",
        CommonCode = "P57",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.016666700000000003m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit gray divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit MilligrayPerMinute = new ConvertibleUnit()
    {
        Name = "milligray per minute",
        Symbol = "mGy/min",
        CommonCode = "P58",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.0000166667m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit gray divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit MicrograyPerMinute = new ConvertibleUnit()
    {
        Name = "microgray per minute",
        Symbol = "µGy/min",
        CommonCode = "P59",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.0000000166667m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit gray divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit NanograyPerMinute = new ConvertibleUnit()
    {
        Name = "nanogray per minute",
        Symbol = "nGy/min",
        CommonCode = "P60",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.0000000000166667m,
    };
    /// <summary>
    /// SI derived unit gray divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit GrayPerHour = new ConvertibleUnit()
    {
        Name = "gray per hour",
        Symbol = "Gy/h",
        CommonCode = "P61",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit gray divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit MilligrayPerHour = new ConvertibleUnit()
    {
        Name = "milligray per hour",
        Symbol = "mGy/h",
        CommonCode = "P62",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000000277778m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit gray divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit MicrograyPerHour = new ConvertibleUnit()
    {
        Name = "microgray per hour",
        Symbol = "µGy/h",
        CommonCode = "P63",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000000000277778m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit gray divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit NanograyPerHour = new ConvertibleUnit()
    {
        Name = "nanogray per hour",
        Symbol = "nGy/h",
        CommonCode = "P64",
        ConversionGroup = "gray / second",
        ConversionFactor = 0.000000000000277778m,
    };
    /// <summary>
    /// Derived SI unit sievert divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit SievertPerSecond = new ConvertibleUnit()
    {
        Name = "sievert per second",
        Symbol = "Sv/s",
        CommonCode = "P65",
        ConversionGroup = "sievert / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit sievert divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit MillisievertPerSecond = new ConvertibleUnit()
    {
        Name = "millisievert per second",
        Symbol = "mSv/s",
        CommonCode = "P66",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit sievert divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit MicrosievertPerSecond = new ConvertibleUnit()
    {
        Name = "microsievert per second",
        Symbol = "µSv/s",
        CommonCode = "P67",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.000001m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit sievert divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit NanosievertPerSecond = new ConvertibleUnit()
    {
        Name = "nanosievert per second",
        Symbol = "nSv/s",
        CommonCode = "P68",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.000000001m,
    };
    /// <summary>
    /// Unit for the equivalent tin rate relating to DIN 1301-3:1979: 1 rem/s = 0,01 J/(kg·s) = 1 Sv/s.
    /// </summary>
    public static IConvertibleUnit RemPerSecond = new ConvertibleUnit()
    {
        Name = "rem per second",
        Symbol = "rem/s",
        CommonCode = "P69",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.01m,
    };
    /// <summary>
    /// Derived SI unit sievert divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit SievertPerHour = new ConvertibleUnit()
    {
        Name = "sievert per hour",
        Symbol = "Sv/h",
        CommonCode = "P70",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit sievert divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit MillisievertPerHour = new ConvertibleUnit()
    {
        Name = "millisievert per hour",
        Symbol = "mSv/h",
        CommonCode = "P71",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.000000027777777799999998m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit sievert divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit MicrosievertPerHour = new ConvertibleUnit()
    {
        Name = "microsievert per hour",
        Symbol = "µSv/h",
        CommonCode = "P72",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.0000000000277777778m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit sievert divided by the unit hour.
    /// </summary>
    public static IConvertibleUnit NanosievertPerHour = new ConvertibleUnit()
    {
        Name = "nanosievert per hour",
        Symbol = "nSv/h",
        CommonCode = "P73",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.0000000000000277777778m,
    };
    /// <summary>
    /// Derived SI unit sievert divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit SievertPerMinute = new ConvertibleUnit()
    {
        Name = "sievert per minute",
        Symbol = "Sv/min",
        CommonCode = "P74",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.016666m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit sievert divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit MillisievertPerMinute = new ConvertibleUnit()
    {
        Name = "millisievert per minute",
        Symbol = "mSv/min",
        CommonCode = "P75",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.000016666666670000003m,
    };
    /// <summary>
    /// 0,000 001-fold of the derived SI unit sievert divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit MicrosievertPerMinute = new ConvertibleUnit()
    {
        Name = "microsievert per minute",
        Symbol = "µSv/min",
        CommonCode = "P76",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.00000001666666667m,
    };
    /// <summary>
    /// 0,000 000 001-fold of the derived SI unit sievert divided by the unit minute.
    /// </summary>
    public static IConvertibleUnit NanosievertPerMinute = new ConvertibleUnit()
    {
        Name = "nanosievert per minute",
        Symbol = "nSv/min",
        CommonCode = "P77",
        ConversionGroup = "sievert / second",
        ConversionFactor = 0.00000000001666666667m,
    };
    /// <summary>
    /// Complement of the power of the unit inch according to the Anglo-American and Imperial system of units by exponent 2.
    /// </summary>
    public static IConvertibleUnit ReciprocalSquareInch = new ConvertibleUnit()
    {
        Name = "reciprocal square inch",
        Symbol = "1/in²",
        CommonCode = "P78",
        ConversionGroup = "1 / meter ** 2",
        ConversionFactor = 1550.003m,
    };
    /// <summary>
    /// Unit of the burst index as derived unit for pressure pascal related to the substance, represented as a quotient from the SI base unit kilogram divided by the power of the SI base unit metre by exponent 2.
    /// </summary>
    public static IConvertibleUnit PascalSquareMetrePerKilogram = new ConvertibleUnit()
    {
        Name = "pascal square metre per kilogram",
        Symbol = "Pa/(kg/m²)",
        CommonCode = "P79",
        ConversionGroup = "meter / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 0,001-fold of the derived SI unit pascal divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit MillipascalPerMetre = new ConvertibleUnit()
    {
        Name = "millipascal per metre",
        Symbol = "mPa/m",
        CommonCode = "P80",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// 1000-fold of the derived SI unit pascal divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit KilopascalPerMetre = new ConvertibleUnit()
    {
        Name = "kilopascal per metre",
        Symbol = "kPa/m",
        CommonCode = "P81",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// 100-fold of the derived SI unit pascal divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit HectopascalPerMetre = new ConvertibleUnit()
    {
        Name = "hectopascal per metre",
        Symbol = "hPa/m",
        CommonCode = "P82",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 100.0m,
    };
    /// <summary>
    /// Outdated unit of the pressure divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit StandardAtmospherePerMetre = new ConvertibleUnit()
    {
        Name = "standard atmosphere per metre",
        Symbol = "Atm/m",
        CommonCode = "P83",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 101325.0m,
    };
    /// <summary>
    /// Obsolete and non-legal unit of the pressure which is generated by a 10 metre water column divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit TechnicalAtmospherePerMetre = new ConvertibleUnit()
    {
        Name = "technical atmosphere per metre",
        Symbol = "at/m",
        CommonCode = "P84",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 98066.5m,
    };
    /// <summary>
    /// CGS (Centimetre-Gram-Second system) unit of the pressure divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit TorrPerMetre = new ConvertibleUnit()
    {
        Name = "torr per metre",
        Symbol = "Torr/m",
        CommonCode = "P85",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 133.3224m,
    };
    /// <summary>
    /// Compound unit for pressure (pound-force according to the Anglo-American unit system divided by the power of the unit inch according to the Anglo-American and Imperial system of units with the exponent 2) divided by the unit inch according to the Anglo-American and Imperial system of units .
    /// </summary>
    public static IConvertibleUnit PsiPerInch = new ConvertibleUnit()
    {
        Name = "psi per inch",
        Symbol = "psi/in",
        CommonCode = "P86",
        ConversionGroup = "kilogram / meter ** 2 / second ** 2",
        ConversionFactor = 271447.10000000003m,
    };
    /// <summary>
    /// Unit of volume flow cubic meters by second related to the transmission surface in square metres.
    /// </summary>
    public static IConvertibleUnit CubicMetrePerSecondSquareMetre = new ConvertibleUnit()
    {
        Name = "cubic metre per second square metre",
        Symbol = "(m³/s)/m²",
        CommonCode = "P87",
        ConversionGroup = "meter / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Non SI-conforming unit of fluidity of dynamic viscosity.
    /// </summary>
    public static IConvertibleUnit Rhe = new ConvertibleUnit()
    {
        Name = "rhe",
        Symbol = "rhe",
        CommonCode = "P88",
        ConversionGroup = "meter * second / kilogram",
        ConversionFactor = 10.0m,
    };
    /// <summary>
    /// Unit for length-related rotational moment according to the Anglo-American and Imperial system of units.
    /// </summary>
    public static IConvertibleUnit PoundforceFootPerInch = new ConvertibleUnit()
    {
        Name = "poundforce foot per inch",
        Symbol = "lbf·ft/in",
        CommonCode = "P89",
        ConversionGroup = "kilogram * meter / second ** 2",
        ConversionFactor = 53.37866m,
    };
    /// <summary>
    /// Unit for length-related rotational moment according to the Anglo-American and Imperial system of units.
    /// </summary>
    public static IConvertibleUnit PoundforceInchPerInch = new ConvertibleUnit()
    {
        Name = "poundforce inch per inch",
        Symbol = "lbf·in/in",
        CommonCode = "P90",
        ConversionGroup = "kilogram * meter / second ** 2",
        ConversionFactor = 4.448222m,
    };
    /// <summary>
    /// Traditional unit for the ability of a material to allow the transition of the steam, defined at a temperature of 0 °C as steam transmittance, where the mass of one grain steam penetrates an area of one foot squared at a pressure from one inch mercury per hour.
    /// </summary>
    public static IConvertibleUnit Perm0C = new ConvertibleUnit()
    {
        Name = "perm (0 ºC)",
        Symbol = "perm (0 ºC)",
        CommonCode = "P91",
        ConversionGroup = "kilogram / meter ** 2 / pascal / second",
        ConversionFactor = 0.0000000000572135m,
    };
    /// <summary>
    /// Traditional unit for the ability of a material to allow the transition of the steam, defined at a temperature of 23 °C as steam transmittance at which the mass of one grain of steam penetrates an area of one square foot at a pressure of one inch mercury per hour.
    /// </summary>
    public static IConvertibleUnit Perm23C = new ConvertibleUnit()
    {
        Name = "perm (23 ºC)",
        Symbol = "perm (23 ºC)",
        CommonCode = "P92",
        ConversionGroup = "kilogram / meter ** 2 / pascal / second",
        ConversionFactor = 0.0000000000574525m,
    };
    /// <summary>
    /// Unit byte divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit BytePerSecond = new ConvertibleUnit()
    {
        Name = "byte per second",
        Symbol = "byte/s",
        CommonCode = "P93",
        ConversionGroup = "byte / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// 1000-fold of the unit byte divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit KilobytePerSecond = new ConvertibleUnit()
    {
        Name = "kilobyte per second",
        Symbol = "kbyte/s",
        CommonCode = "P94",
        ConversionGroup = "byte / second",
        ConversionFactor = 1000.0m,
    };
    /// <summary>
    /// 1 000 000-fold of the unit byte divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit MegabytePerSecond = new ConvertibleUnit()
    {
        Name = "megabyte per second",
        Symbol = "Mbyte/s",
        CommonCode = "P95",
        ConversionGroup = "byte / second",
        ConversionFactor = 1000000.0m,
    };
    /// <summary>
    /// Reciprocal of the derived SI unit volt.
    /// </summary>
    public static IConvertibleUnit ReciprocalVolt = new ConvertibleUnit()
    {
        Name = "reciprocal volt",
        Symbol = "1/V",
        CommonCode = "P96",
        ConversionGroup = "ampere * second ** 3 / kilogram / meter ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Reciprocal of the unit radian.
    /// </summary>
    public static IConvertibleUnit ReciprocalRadian = new ConvertibleUnit()
    {
        Name = "reciprocal radian",
        Symbol = "1/rad",
        CommonCode = "P97",
        ConversionGroup = "1 / radian",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the equilibrium constant on the basis of the pressure(ISO 80000-9:2009, 9-35.a).
    /// </summary>
    public static IUnit PascalToThePowerSumOfStoichiometricNumbers = new Unit()
    {
        Name = "pascal to the power sum of stoichiometric numbers",
        Symbol = "PaΣνB",
        CommonCode = "P98",
    };
    /// <summary>
    /// Unit of the equilibrium constant on the basis of the concentration (ISO 80000-9:2009, 9-36.a).
    /// </summary>
    public static IUnit MolePerCubivMetreToThePowerSumOfStoichiometricNumbers = new Unit()
    {
        Name = "mole per cubiv metre to the power sum of stoichiometric numbers",
        Symbol = "(mol/m³)∑νB",
        CommonCode = "P99",
    };
    public static IConvertibleUnit Pascal = new ConvertibleUnit()
    {
        Name = "pascal",
        Symbol = "Pa",
        CommonCode = "PAL",
        ConversionGroup = "pascal",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of count defining the number of pads (pad: block of paper sheets fastened together at one end).
    /// </summary>
    public static IUnit Pad = new Unit()
    {
        Name = "pad",
        Symbol = null,
        CommonCode = "PD",
    };
    /// <summary>
    /// A unit of volume equal to one litre of proof spirits, or the alcohol equivalent thereof. Used for measuring the strength of distilled alcoholic liquors, expressed as a percentage of the alcohol content of a standard mixture at a specific temperature.
    /// </summary>
    public static IUnit ProofLitre = new Unit()
    {
        Name = "proof litre",
        Symbol = null,
        CommonCode = "PFL",
    };
    /// <summary>
    /// A unit of volume equal to one gallon of proof spirits, or the alcohol equivalent thereof. Used for measuring the strength of distilled alcoholic liquors, expressed as a percentage of the alcohol content of a standard mixture at a specific temperature.
    /// </summary>
    public static IUnit ProofGallon = new Unit()
    {
        Name = "proof gallon",
        Symbol = null,
        CommonCode = "PGL",
    };
    /// <summary>
    /// A unit of count defining the number of characters that fit in a horizontal inch.
    /// </summary>
    public static IUnit Pitch = new Unit()
    {
        Name = "pitch",
        Symbol = null,
        CommonCode = "PI",
    };
    /// <summary>
    /// A unit of proportion defining the sugar content of a product, especially in relation to beer.
    /// </summary>
    public static IUnit DegreePlato = new Unit()
    {
        Name = "degree Plato",
        Symbol = "°P",
        CommonCode = "PLA",
    };
    public static IConvertibleUnit PoundPerInchOfLength = new ConvertibleUnit()
    {
        Name = "pound per inch of length",
        Symbol = "lb/in",
        CommonCode = "PO",
        ConversionGroup = "kilogram / meter",
        ConversionFactor = 17.85797m,
    };
    /// <summary>
    /// A unit of quantity defining the degree of thickness of a bound publication, expressed as the number of pages per inch of thickness.
    /// </summary>
    public static IUnit PagePerInch = new Unit()
    {
        Name = "page per inch",
        Symbol = "ppi",
        CommonCode = "PQ",
    };
    /// <summary>
    /// A unit of count defining the number of pairs (pair: item described by two's).
    /// </summary>
    public static IConvertibleUnit Pair = new ConvertibleUnit()
    {
        Name = "pair",
        Symbol = null,
        CommonCode = "PR",
        ConversionGroup = "dimensionless",
        ConversionFactor = 2m,
    };
    public static IConvertibleUnit PoundforcePerSquareInch = new ConvertibleUnit()
    {
        Name = "poundforce per square inch",
        Symbol = "lbf/in²",
        CommonCode = "PS",
        ConversionGroup = "pascal",
        ConversionFactor = 6894.7570000000005m,
    };
    public static IConvertibleUnit DryPintUS = new ConvertibleUnit()
    {
        Name = "dry pint (US)",
        Symbol = "dry pt (US)",
        CommonCode = "PTD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0005506105m,
    };
    public static IConvertibleUnit PintUK = new ConvertibleUnit()
    {
        Name = "pint (UK)",
        Symbol = "pt (UK)",
        CommonCode = "PTI",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000568261m,
    };
    public static IConvertibleUnit LiquidPintUS = new ConvertibleUnit()
    {
        Name = "liquid pint (US)",
        Symbol = "liq pt (US)",
        CommonCode = "PTL",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0004731765m,
    };
    /// <summary>
    /// A quantity of allowance of food allotted to, or enough for, one person.
    /// </summary>
    public static IUnit Portion = new Unit()
    {
        Name = "portion",
        Symbol = "PTN",
        CommonCode = "PTN",
    };
    /// <summary>
    /// Unit of the magnetic dipole moment of the molecule as derived SI unit joule divided by the derived SI unit tesla.
    /// </summary>
    public static IConvertibleUnit JoulePerTesla = new ConvertibleUnit()
    {
        Name = "joule per tesla",
        Symbol = "J/T",
        CommonCode = "Q10",
        ConversionGroup = "ampere * meter ** 2",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Unit of the market value according to the feature of a single feature as a statistical measurement of the existing utilization.
    /// </summary>
    public static IConvertibleUnit Erlang = new ConvertibleUnit()
    {
        Name = "erlang",
        Symbol = "E",
        CommonCode = "Q11",
        ConversionGroup = "E",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Synonym for byte: 1 octet = 8 bit = 1 byte.
    /// </summary>
    public static IConvertibleUnit Octet = new ConvertibleUnit()
    {
        Name = "octet",
        Symbol = "o",
        CommonCode = "Q12",
        ConversionGroup = "bit",
        ConversionFactor = 8m,
    };
    /// <summary>
    /// Unit octet divided by the SI base unit second.
    /// </summary>
    public static IConvertibleUnit OctetPerSecond = new ConvertibleUnit()
    {
        Name = "octet per second",
        Symbol = "o/s",
        CommonCode = "Q13",
        ConversionGroup = "bit / second",
        ConversionFactor = 8.0m,
    };
    /// <summary>
    /// Logarithmic unit for information equal to the content of decision of a sentence of two mutually exclusive events, expressed as a logarithm to base 2.
    /// </summary>
    public static IUnit Shannon = new Unit()
    {
        Name = "shannon",
        Symbol = "Sh",
        CommonCode = "Q14",
    };
    /// <summary>
    /// Logarithmic unit for information equal to the content of decision of a sentence of ten mutually exclusive events, expressed as a logarithm to base 10.
    /// </summary>
    public static IUnit Hartley = new Unit()
    {
        Name = "hartley",
        Symbol = "Hart",
        CommonCode = "Q15",
    };
    /// <summary>
    /// Logarithmic unit for information equal to the content of decision of a sentence of ,718 281 828 459 mutually exclusive events, expressed as a logarithm to base Euler value e.
    /// </summary>
    public static IConvertibleUnit NaturalUnitOfInformation = new ConvertibleUnit()
    {
        Name = "natural unit of information",
        Symbol = "nat",
        CommonCode = "Q16",
        ConversionGroup = "nanotechnical_atmosphere",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// Time related logarithmic unit for information equal to the content of decision of a sentence of two mutually exclusive events, expressed as a logarithm to base 2.
    /// </summary>
    public static IConvertibleUnit ShannonPerSecond = new ConvertibleUnit()
    {
        Name = "shannon per second",
        Symbol = "Sh/s",
        CommonCode = "Q17",
        ConversionGroup = "shannon / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Time related logarithmic unit for information equal to the content of decision of a sentence of ten mutually exclusive events, expressed as a logarithm to base 10.
    /// </summary>
    public static IConvertibleUnit HartleyPerSecond = new ConvertibleUnit()
    {
        Name = "hartley per second",
        Symbol = "Hart/s",
        CommonCode = "Q18",
        ConversionGroup = "hartley / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Time related logarithmic unit for information equal to the content of decision of a sentence of 2,718 281 828 459 mutually exclusive events, expressed as a logarithm to base of the Euler value e.
    /// </summary>
    public static IConvertibleUnit NaturalUnitOfInformationPerSecond = new ConvertibleUnit()
    {
        Name = "natural unit of information per second",
        Symbol = "nat/s",
        CommonCode = "Q19",
        ConversionGroup = "nanotechnical_atmosphere / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the Einstein transition probability for spontaneous or inducing emissions and absorption according to ISO 80000-7:2008, expressed as SI base unit second divided by the SI base unit kilogram.
    /// </summary>
    public static IConvertibleUnit SecondPerKilogramm = new ConvertibleUnit()
    {
        Name = "second per kilogramm",
        Symbol = "s/kg",
        CommonCode = "Q20",
        ConversionGroup = "second / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the first radiation constants c1 = 2·p·h·c0², the value of which is 3,741 771 18·10?¹6-fold   that of the comparative value of the product of the derived SI unit watt multiplied with the power of the SI base unit metre with the exponent 2.
    /// </summary>
    public static IConvertibleUnit WattSquareMetre = new ConvertibleUnit()
    {
        Name = "watt square metre",
        Symbol = "W·m²",
        CommonCode = "Q21",
        ConversionGroup = "kilogram * meter ** 4 / second ** 3",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit of the density of states as an expression of angular frequency as complement of the product of hertz and radiant and the power of SI base unit metre by exponent 3 .
    /// </summary>
    public static IConvertibleUnit SecondPerRadianCubicMetre = new ConvertibleUnit()
    {
        Name = "second per radian cubic metre",
        Symbol = "1/(Hz·rad·m³)",
        CommonCode = "Q22",
        ConversionGroup = "second / meter ** 3 / radian",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Complement of the derived SI unit weber as unit of the Josephson constant, which value is equal to the 384 597,891-fold of the reference value gigahertz divided by volt.
    /// </summary>
    public static IConvertibleUnit WeberToThePowerMinusOne = new ConvertibleUnit()
    {
        Name = "weber to the power minus one",
        Symbol = "1/Wb",
        CommonCode = "Q23",
        ConversionGroup = "ampere * second ** 2 / kilogram / meter ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Complement of the unit inch according to the Anglo-American and Imperial system of units.
    /// </summary>
    public static IConvertibleUnit ReciprocalInch = new ConvertibleUnit()
    {
        Name = "reciprocal inch",
        Symbol = "1/in",
        CommonCode = "Q24",
        ConversionGroup = "1 / meter",
        ConversionFactor = 39.37008m,
    };
    /// <summary>
    /// Unit used at the statement of relative refractive indexes of optical systems as complement of the focal length with correspondence to: 1 dpt = 1/m.
    /// </summary>
    public static IConvertibleUnit Dioptre = new ConvertibleUnit()
    {
        Name = "dioptre",
        Symbol = "dpt",
        CommonCode = "Q25",
        ConversionGroup = "1 / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Value of the quotient from two physical units of the same kind as a numerator and denominator whereas the units are shortened mutually.
    /// </summary>
    public static IConvertibleUnit OnePerOne = new ConvertibleUnit()
    {
        Name = "one per one",
        Symbol = "1/1",
        CommonCode = "Q26",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit for length-related rotational moment as product of the derived SI unit newton and the SI base unit metre divided by the SI base unit metre.
    /// </summary>
    public static IConvertibleUnit NewtonMetrePerMetre = new ConvertibleUnit()
    {
        Name = "newton metre per metre",
        Symbol = "N·m/m²",
        CommonCode = "Q27",
        ConversionGroup = "kilogram * meter / second ** 2",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Unit for the ability of a material to allow the transition of steam.
    /// </summary>
    public static IConvertibleUnit KilogramPerSquareMetrePascalSecond = new ConvertibleUnit()
    {
        Name = "kilogram per square metre pascal second",
        Symbol = "kg/(m²·Pa·s)",
        CommonCode = "Q28",
        ConversionGroup = "kilogram / meter ** 2 / pascal / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Microgram per hectogram.
    /// </summary>
    public static IConvertibleUnit MicrogramPerHectogram = new ConvertibleUnit()
    {
        Name = "microgram per hectogram",
        Symbol = "µg/hg",
        CommonCode = "Q29",
        ConversionGroup = "dimensionless",
        ConversionFactor = 0.00000001m,
    };
    /// <summary>
    /// The activity of the (solvated) hydrogen ion (a logarithmic measure used to state the acidity or alkalinity of a chemical solution).
    /// </summary>
    public static IUnit PhPotentialOfHydrogen = new Unit()
    {
        Name = "pH (potential of Hydrogen)",
        Symbol = "pH",
        CommonCode = "Q30",
    };
    public static IConvertibleUnit KilojoulePerGram = new ConvertibleUnit()
    {
        Name = "kilojoule per gram",
        Symbol = "kJ/g",
        CommonCode = "Q31",
        ConversionGroup = "joule / kilogram",
        ConversionFactor = 1000000.0m,
    };
    public static IConvertibleUnit Femtolitre = new ConvertibleUnit()
    {
        Name = "femtolitre",
        Symbol = "fl",
        CommonCode = "Q32",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000000000000000001m,
    };
    public static IConvertibleUnit Picolitre = new ConvertibleUnit()
    {
        Name = "picolitre",
        Symbol = "pl",
        CommonCode = "Q33",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000000000000001m,
    };
    public static IConvertibleUnit Nanolitre = new ConvertibleUnit()
    {
        Name = "nanolitre",
        Symbol = "nl",
        CommonCode = "Q34",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.000000000001m,
    };
    /// <summary>
    /// A unit of power defining the total amount of bulk energy transferred or consumer per minute.
    /// </summary>
    public static IConvertibleUnit MegawattsPerMinute = new ConvertibleUnit()
    {
        Name = "megawatts per minute",
        Symbol = "MW/min",
        CommonCode = "Q35",
        ConversionGroup = "watt / second",
        ConversionFactor = 173.368m,
    };
    /// <summary>
    /// A unit of the amount of surface area per unit volume of an object or collection of objects.
    /// </summary>
    public static IConvertibleUnit SquareMetrePerCubicMetre = new ConvertibleUnit()
    {
        Name = "square metre per cubic metre",
        Symbol = "m2/m3",
        CommonCode = "Q36",
        ConversionGroup = "1 / meter",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Standard cubic metre (temperature 15°C and pressure 1013.25 millibars ) per day
    /// </summary>
    public static IConvertibleUnit StandardCubicMetrePerDay = new ConvertibleUnit()
    {
        Name = "Standard cubic metre per day",
        Symbol = null,
        CommonCode = "Q37",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    /// <summary>
    /// Standard cubic metre (temperature 15°C and pressure 1013.25 millibars ) per hour
    /// </summary>
    public static IConvertibleUnit StandardCubicMetrePerHour = new ConvertibleUnit()
    {
        Name = "Standard cubic metre per hour",
        Symbol = null,
        CommonCode = "Q38",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// Normalized cubic metre (temperature 0°C and pressure 1013.25 millibars ) per day
    /// </summary>
    public static IConvertibleUnit NormalizedCubicMetrePerDay = new ConvertibleUnit()
    {
        Name = "Normalized cubic metre per day",
        Symbol = null,
        CommonCode = "Q39",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000011574100000000002m,
    };
    /// <summary>
    /// Normalized cubic metre (temperature 0°C and pressure 1013.25 millibars ) per hour
    /// </summary>
    public static IConvertibleUnit NormalizedCubicMetrePerHour = new ConvertibleUnit()
    {
        Name = "Normalized cubic metre per hour",
        Symbol = null,
        CommonCode = "Q40",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.000277778m,
    };
    /// <summary>
    /// Joule per normalised cubic metre (temperature 0°C and pressure 1013.25 millibars).
    /// </summary>
    public static IUnit JoulePerNormalisedCubicMetre = new Unit()
    {
        Name = "Joule per normalised cubic metre",
        Symbol = null,
        CommonCode = "Q41",
    };
    /// <summary>
    /// Joule per standard cubic metre (temperature 15°C and pressure 1013.25 millibars).
    /// </summary>
    public static IUnit JoulePerStandardCubicMetre = new Unit()
    {
        Name = "Joule per standard cubic metre",
        Symbol = null,
        CommonCode = "Q42",
    };
    /// <summary>
    /// Energy in Mega Joules per normalised cubic metre for gas (temperature 0°C and pressure 101325 millibars)
    /// </summary>
    public static IUnit MegaJoulePerNormalisedCubicMetre = new Unit()
    {
        Name = "Mega Joule per Normalised cubic Metre",
        Symbol = "MJ/m³",
        CommonCode = "MNJ",
    };
    /// <summary>
    /// A unit of count defining the number of meals (meal: an amount of food to be eaten on a single occasion).
    /// </summary>
    public static IUnit Meal = new Unit()
    {
        Name = "meal",
        Symbol = null,
        CommonCode = "Q3",
    };
    /// <summary>
    /// A unit of count defining the number of facsimile pages.
    /// </summary>
    public static IUnit PageFacsimile = new Unit()
    {
        Name = "page  facsimile",
        Symbol = null,
        CommonCode = "QA",
    };
    /// <summary>
    /// A unit of time defining the number of quarters (3 months).
    /// </summary>
    public static IUnit QuarterOfAYear = new Unit()
    {
        Name = "quarter (of a year)",
        Symbol = null,
        CommonCode = "QAN",
    };
    /// <summary>
    /// A unit of count defining the number of hardcopy pages (hardcopy page: a page rendered as printed or written output on paper, film, or other permanent medium).
    /// </summary>
    public static IUnit PageHardcopy = new Unit()
    {
        Name = "page  hardcopy",
        Symbol = null,
        CommonCode = "QB",
    };
    /// <summary>
    /// A unit of count for paper, expressed as the number of quires (quire: a number of paper sheets, typically 25).
    /// </summary>
    public static IUnit Quire = new Unit()
    {
        Name = "quire",
        Symbol = "qr",
        CommonCode = "QR",
    };
    public static IConvertibleUnit DryQuartUS = new ConvertibleUnit()
    {
        Name = "dry quart (US)",
        Symbol = "dry qt (US)",
        CommonCode = "QTD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.001101221m,
    };
    public static IConvertibleUnit QuartUK = new ConvertibleUnit()
    {
        Name = "quart (UK)",
        Symbol = "qt (UK)",
        CommonCode = "QTI",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0011365225000000002m,
    };
    public static IConvertibleUnit LiquidQuartUS = new ConvertibleUnit()
    {
        Name = "liquid quart (US)",
        Symbol = "liq qt (US)",
        CommonCode = "QTL",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.0009463529m,
    };
    /// <summary>
    /// A traditional unit of weight equal to 1/4 hundredweight. In the United Kingdom, one quarter equals 28 pounds.
    /// </summary>
    public static IConvertibleUnit QuarterUK = new ConvertibleUnit()
    {
        Name = "quarter (UK)",
        Symbol = "Qr (UK)",
        CommonCode = "QTR",
        ConversionGroup = "kilogram",
        ConversionFactor = 12.70059m,
    };
    /// <summary>
    /// A unit of count defining the number of picas. (pica: typographical length equal to 12 points or 4.22 mm (approx.)).
    /// </summary>
    public static IConvertibleUnit Pica = new ConvertibleUnit()
    {
        Name = "pica",
        Symbol = null,
        CommonCode = "R1",
        ConversionGroup = "meter",
        ConversionFactor = 0.004217518m,
    };
    /// <summary>
    /// A unit of volume equal to one thousand cubic metres.
    /// </summary>
    public static IConvertibleUnit ThousandCubicMetre = new ConvertibleUnit()
    {
        Name = "thousand cubic metre",
        Symbol = null,
        CommonCode = "R9",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of time defining the number of hours of operation.
    /// </summary>
    public static IUnit RunningOrOperatingHour = new Unit()
    {
        Name = "running or operating hour",
        Symbol = null,
        CommonCode = "RH",
    };
    /// <summary>
    /// A unit of count for paper, expressed as the number of reams (ream: a large quantity of paper sheets, typically 500).
    /// </summary>
    public static IUnit Ream = new Unit()
    {
        Name = "ream",
        Symbol = null,
        CommonCode = "RM",
    };
    /// <summary>
    /// A unit of count defining the number of rooms.
    /// </summary>
    public static IUnit Room = new Unit()
    {
        Name = "room",
        Symbol = null,
        CommonCode = "ROM",
    };
    /// <summary>
    /// A unit of mass for paper, expressed as pounds per ream. (ream: a large quantity of paper, typically 500 sheets).
    /// </summary>
    public static IUnit PoundPerReam = new Unit()
    {
        Name = "pound per ream",
        Symbol = null,
        CommonCode = "RP",
    };
    /// <summary>
    /// Refer ISO/TC12 SI Guide
    /// </summary>
    public static IConvertibleUnit RevolutionsPerMinute = new ConvertibleUnit()
    {
        Name = "revolutions per minute",
        Symbol = "r/min",
        CommonCode = "RPM",
        ConversionGroup = "1 / second",
        ConversionFactor = 0.0167m,
    };
    /// <summary>
    /// Refer ISO/TC12 SI Guide
    /// </summary>
    public static IConvertibleUnit RevolutionsPerSecond = new ConvertibleUnit()
    {
        Name = "revolutions per second",
        Symbol = "r/s",
        CommonCode = "RPS",
        ConversionGroup = "1 / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of information typically used for billing purposes, expressed as the number of revenue tons (revenue ton: either a metric ton or a cubic metres, whichever is the larger), moved over a distance of one mile.
    /// </summary>
    public static IUnit RevenueTonMile = new Unit()
    {
        Name = "revenue ton mile",
        Symbol = null,
        CommonCode = "RT",
    };
    /// <summary>
    /// Synonym: foot squared per second
    /// </summary>
    public static IConvertibleUnit SquareFootPerSecond = new ConvertibleUnit()
    {
        Name = "square foot per second",
        Symbol = "ft²/s",
        CommonCode = "S3",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 0.09290304m,
    };
    /// <summary>
    /// Synonym: metre squared per second (square metres/second US)
    /// </summary>
    public static IConvertibleUnit SquareMetrePerSecond = new ConvertibleUnit()
    {
        Name = "square metre per second",
        Symbol = "m²/s",
        CommonCode = "S4",
        ConversionGroup = "meter ** 2 / second",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of time defining the number of half years (6 months).
    /// </summary>
    public static IUnit HalfYear6Months = new Unit()
    {
        Name = "half year (6 months)",
        Symbol = null,
        CommonCode = "SAN",
    };
    /// <summary>
    /// A unit of count defining the number of units in multiples of 20.
    /// </summary>
    public static IConvertibleUnit Score = new ConvertibleUnit()
    {
        Name = "score",
        Symbol = null,
        CommonCode = "SCO",
        ConversionGroup = "dimensionless",
        ConversionFactor = 20m,
    };
    public static IConvertibleUnit Scruple = new ConvertibleUnit()
    {
        Name = "scruple",
        Symbol = null,
        CommonCode = "SCR",
        ConversionGroup = "gram",
        ConversionFactor = 1.295982m,
    };
    public static IConvertibleUnit SecondUnitOfTime = new ConvertibleUnit()
    {
        Name = "second [unit of time]",
        Symbol = "s",
        CommonCode = "SEC",
        ConversionGroup = "second",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of count defining the number of sets (set: a number of objects grouped together).
    /// </summary>
    public static IUnit Set = new Unit()
    {
        Name = "set",
        Symbol = null,
        CommonCode = "SET",
    };
    /// <summary>
    /// A unit of information equal to 64000 bytes.
    /// </summary>
    public static IUnit Segment = new Unit()
    {
        Name = "segment",
        Symbol = null,
        CommonCode = "SG",
    };
    public static IConvertibleUnit Siemens = new ConvertibleUnit()
    {
        Name = "siemens",
        Symbol = "S",
        CommonCode = "SIE",
        ConversionGroup = "ampere / volt",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// Standard cubic metre (temperature 15°C and pressure 1013.25 millibars )
    /// </summary>
    public static IConvertibleUnit StandardCubicMetre = new ConvertibleUnit()
    {
        Name = "Standard cubic metre",
        Symbol = null,
        CommonCode = "SM3",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit MileStatuteMile = new ConvertibleUnit()
    {
        Name = "mile (statute mile)",
        Symbol = "mile",
        CommonCode = "SMI",
        ConversionGroup = "meter",
        ConversionFactor = 1609.344m,
    };
    /// <summary>
    /// A unit of count defining the number of squares (square: rectangular shape).
    /// </summary>
    public static IUnit Square = new Unit()
    {
        Name = "square",
        Symbol = null,
        CommonCode = "SQ",
    };
    /// <summary>
    /// A unit of count defining the number of squares of roofing materials, measured in multiples of 100 square feet.
    /// </summary>
    public static IUnit SquareRoofing = new Unit()
    {
        Name = "square, roofing",
        Symbol = null,
        CommonCode = "SQR",
    };
    /// <summary>
    /// A unit of count defining the number of strips (strip: long narrow piece of an object).
    /// </summary>
    public static IUnit Strip = new Unit()
    {
        Name = "strip",
        Symbol = null,
        CommonCode = "SR",
    };
    /// <summary>
    /// A unit of count defining the number of sticks (stick: slender and often cylindrical piece of a substance).
    /// </summary>
    public static IUnit Stick = new Unit()
    {
        Name = "stick",
        Symbol = null,
        CommonCode = "STC",
    };
    public static IConvertibleUnit StoneUK = new ConvertibleUnit()
    {
        Name = "stone (UK)",
        Symbol = "st",
        CommonCode = "STI",
        ConversionGroup = "kilogram",
        ConversionFactor = 6.350293m,
    };
    /// <summary>
    /// A unit of count defining the number of cigarettes in the smallest unit for stock-taking and/or duty computation.
    /// </summary>
    public static IUnit StickCigarette = new Unit()
    {
        Name = "stick, cigarette",
        Symbol = null,
        CommonCode = "STK",
    };
    /// <summary>
    /// A unit of volume defining the number of litres of a product at a temperature of 15 degrees Celsius, especially in relation to hydrocarbon oils.
    /// </summary>
    public static IUnit StandardLitre = new Unit()
    {
        Name = "standard litre",
        Symbol = null,
        CommonCode = "STL",
    };
    /// <summary>
    /// Synonym: net ton (2000 lb)
    /// </summary>
    public static IConvertibleUnit TonUSOrShortTonUKPerUS = new ConvertibleUnit()
    {
        Name = "ton (US) or short ton (UK/US)",
        Symbol = "ton (US)",
        CommonCode = "STN",
        ConversionGroup = "kilogram",
        ConversionFactor = 907.1846999999999m,
    };
    /// <summary>
    /// A unit of count defining the number of straws (straw: a slender tube used for sucking up liquids).
    /// </summary>
    public static IUnit Straw = new Unit()
    {
        Name = "straw",
        Symbol = null,
        CommonCode = "STW",
    };
    /// <summary>
    /// A unit of count defining the number of skeins (skein: a loosely-coiled bundle of yarn or thread).
    /// </summary>
    public static IUnit Skein = new Unit()
    {
        Name = "skein",
        Symbol = null,
        CommonCode = "SW",
    };
    /// <summary>
    /// A unit of count defining the number of shipments (shipment: an amount of goods shipped or transported).
    /// </summary>
    public static IUnit Shipment = new Unit()
    {
        Name = "shipment",
        Symbol = null,
        CommonCode = "SX",
    };
    /// <summary>
    /// A unit of count defining the number of syringes (syringe: a small device for pumping, spraying and/or injecting liquids through a small aperture).
    /// </summary>
    public static IUnit Syringe = new Unit()
    {
        Name = "syringe",
        Symbol = null,
        CommonCode = "SYR",
    };
    /// <summary>
    /// A unit of count defining the number of lines in service.
    /// </summary>
    public static IUnit TelecommunicationLineInService = new Unit()
    {
        Name = "telecommunication line in service",
        Symbol = null,
        CommonCode = "T0",
    };
    /// <summary>
    /// A unit of count defining the number of pieces in multiples of 1000 (piece: a single item, article or exemplar).
    /// </summary>
    public static IUnit ThousandPiece = new Unit()
    {
        Name = "thousand piece",
        Symbol = null,
        CommonCode = "T3",
    };
    public static IConvertibleUnit KiloampereHourThousandAmpereHour = new ConvertibleUnit()
    {
        Name = "kiloampere hour (thousand ampere hour)",
        Symbol = "kA·h",
        CommonCode = "TAH",
        ConversionGroup = "coulomb",
        ConversionFactor = 3600000.0m,
    };
    /// <summary>
    /// A unit of chemistry defining the amount of potassium hydroxide (KOH) in milligrams that is needed to neutralize the acids in one gram of oil. It is an important quality measurement of crude oil.
    /// </summary>
    public static IUnit TotalAcidNumber = new Unit()
    {
        Name = "total acid number",
        Symbol = "TAN",
        CommonCode = "TAN",
    };
    public static IUnit ThousandSquareInch = new Unit()
    {
        Name = "thousand square inch",
        Symbol = null,
        CommonCode = "TI",
    };
    /// <summary>
    /// A unit of mass defining the number of metric tons of a product, including its container.
    /// </summary>
    public static IUnit MetricTonIncludingContainer = new Unit()
    {
        Name = "metric ton, including container",
        Symbol = null,
        CommonCode = "TIC",
    };
    /// <summary>
    /// A unit of mass defining the number of metric tons of a product, including its inner packaging materials.
    /// </summary>
    public static IUnit MetricTonIncludingInnerPackaging = new Unit()
    {
        Name = "metric ton, including inner packaging",
        Symbol = null,
        CommonCode = "TIP",
    };
    /// <summary>
    /// A unit of information typically used for billing purposes, expressed as the number of tonnes (metric tons) moved over a distance of one kilometre.
    /// </summary>
    public static IConvertibleUnit TonneKilometre = new ConvertibleUnit()
    {
        Name = "tonne kilometre",
        Symbol = "t·km",
        CommonCode = "TKM",
        ConversionGroup = "kilogram * meter",
        ConversionFactor = 1000000m,
    };
    /// <summary>
    /// A unit of mass equal to one thousand grams of imported meat, disregarding less valuable by-products such as the entrails.
    /// </summary>
    public static IUnit KilogramOfImportedMeatLessOffal = new Unit()
    {
        Name = "kilogram of imported meat, less offal",
        Symbol = null,
        CommonCode = "TMS",
    };
    /// <summary>
    /// Synonym: metric ton
    /// </summary>
    public static IConvertibleUnit TonneMetricTon = new ConvertibleUnit()
    {
        Name = "tonne (metric ton)",
        Symbol = "t",
        CommonCode = "TNE",
        ConversionGroup = "kilogram",
        ConversionFactor = 1000m,
    };
    /// <summary>
    /// A unit of count defining the number of items in multiples of 10.
    /// </summary>
    public static IUnit TenPack = new Unit()
    {
        Name = "ten pack",
        Symbol = null,
        CommonCode = "TP",
    };
    /// <summary>
    /// The number of teeth per inch.
    /// </summary>
    public static IConvertibleUnit TeethPerInch = new ConvertibleUnit()
    {
        Name = "teeth per inch",
        Symbol = "TPI",
        CommonCode = "TPI",
        ConversionGroup = "1 / meter",
        ConversionFactor = 0.0254m,
    };
    /// <summary>
    /// A unit of count defining the number of pairs in multiples of 10 (pair: item described by two's).
    /// </summary>
    public static IUnit TenPair = new Unit()
    {
        Name = "ten pair",
        Symbol = null,
        CommonCode = "TPR",
    };
    /// <summary>
    /// A unit of volume equal to one thousand cubic metres per day.
    /// </summary>
    public static IConvertibleUnit ThousandCubicMetrePerDay = new ConvertibleUnit()
    {
        Name = "thousand cubic metre per day",
        Symbol = "km³/d",
        CommonCode = "TQD",
        ConversionGroup = "meter ** 3 / second",
        ConversionFactor = 0.0115741m,
    };
    public static IConvertibleUnit TrillionEUR = new ConvertibleUnit()
    {
        Name = "trillion (EUR)",
        Symbol = null,
        CommonCode = "TRL",
        ConversionGroup = "dimensionless",
        ConversionFactor = 1000000000000000000m,
    };
    /// <summary>
    /// A unit of count defining the number of sets in multiples of 10 (set: a number of objects grouped together).
    /// </summary>
    public static IUnit TenSet = new Unit()
    {
        Name = "ten set",
        Symbol = null,
        CommonCode = "TST",
    };
    /// <summary>
    /// A unit of count defining the number of sticks in multiples of 10000 (stick: slender and often cylindrical piece of a substance).
    /// </summary>
    public static IUnit TenThousandSticks = new Unit()
    {
        Name = "ten thousand sticks",
        Symbol = null,
        CommonCode = "TTS",
    };
    /// <summary>
    /// A unit of count defining the number of treatments (treatment: subjection to the action of a chemical, physical or biological agent).
    /// </summary>
    public static IUnit Treatment = new Unit()
    {
        Name = "treatment",
        Symbol = null,
        CommonCode = "U1",
    };
    /// <summary>
    /// A unit of count defining the number of tablets (tablet: a small flat or compressed solid object).
    /// </summary>
    public static IUnit TabletU2 = new Unit()
    {
        Name = "tablet",
        Symbol = null,
        CommonCode = "U2",
    };
    /// <summary>
    /// A loose or unpacked article in the form of a bar, block or piece.
    /// </summary>
    public static IUnit TabletXT1 = new Unit()
    {
        Name = "Tablet",
        Symbol = null,
        CommonCode = "XT1",
    };
    /// <summary>
    /// A unit of count defining the average number of lines in service.
    /// </summary>
    public static IUnit TelecommunicationLineInServiceAverage = new Unit()
    {
        Name = "telecommunication line in service average",
        Symbol = null,
        CommonCode = "UB",
    };
    /// <summary>
    /// A unit of count defining the number of network access ports.
    /// </summary>
    public static IUnit TelecommunicationPort = new Unit()
    {
        Name = "telecommunication port",
        Symbol = null,
        CommonCode = "UC",
    };
    public static IConvertibleUnit VoltAmperePerKilogram = new ConvertibleUnit()
    {
        Name = "volt  ampere per kilogram",
        Symbol = "V·A / kg",
        CommonCode = "VA",
        ConversionGroup = "ampere * volt / kilogram",
        ConversionFactor = 1.0m,
    };
    public static IConvertibleUnit Volt = new ConvertibleUnit()
    {
        Name = "volt",
        Symbol = "V",
        CommonCode = "VLT",
        ConversionGroup = "volt",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A measure of concentration, typically expressed as the percentage volume of a solute in a solution.
    /// </summary>
    public static IUnit PercentVolume = new Unit()
    {
        Name = "percent volume",
        Symbol = null,
        CommonCode = "VP",
    };
    /// <summary>
    /// A unit of mass defining the number of kilograms of a product, including the water content of the product.
    /// </summary>
    public static IUnit WetKilo = new Unit()
    {
        Name = "wet kilo",
        Symbol = null,
        CommonCode = "W2",
    };
    public static IConvertibleUnit WattPerKilogram = new ConvertibleUnit()
    {
        Name = "watt per kilogram",
        Symbol = "W/kg",
        CommonCode = "WA",
        ConversionGroup = "watt / kilogram",
        ConversionFactor = 1.0m,
    };
    /// <summary>
    /// A unit of mass defining the number of pounds of a material, including the water content of the material.
    /// </summary>
    public static IUnit WetPound = new Unit()
    {
        Name = "wet pound",
        Symbol = null,
        CommonCode = "WB",
    };
    /// <summary>
    /// A unit of volume used for measuring lumber. One board foot equals 1/12 of a cubic foot.
    /// </summary>
    public static IConvertibleUnit Cord = new ConvertibleUnit()
    {
        Name = "cord",
        Symbol = null,
        CommonCode = "WCD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 3.63m,
    };
    /// <summary>
    /// A unit of mass defining the number of tons of a material, including the water content of the material.
    /// </summary>
    public static IUnit WetTon = new Unit()
    {
        Name = "wet ton",
        Symbol = null,
        CommonCode = "WE",
    };
    public static IConvertibleUnit Weber = new ConvertibleUnit()
    {
        Name = "weber",
        Symbol = "Wb",
        CommonCode = "WEB",
        ConversionGroup = "weber",
        ConversionFactor = 1m,
    };
    public static IConvertibleUnit Week = new ConvertibleUnit()
    {
        Name = "week",
        Symbol = "wk",
        CommonCode = "WEE",
        ConversionGroup = "second",
        ConversionFactor = 604800.0m,
    };
    /// <summary>
    /// A unit of volume equal to 231 cubic inches.
    /// </summary>
    public static IUnit WineGallon = new Unit()
    {
        Name = "wine gallon",
        Symbol = null,
        CommonCode = "WG",
    };
    public static IConvertibleUnit WattHour = new ConvertibleUnit()
    {
        Name = "watt hour",
        Symbol = "W·h",
        CommonCode = "WHR",
        ConversionGroup = "joule",
        ConversionFactor = 3600.0m,
    };
    /// <summary>
    /// A unit of time defining the number of working months.
    /// </summary>
    public static IUnit WorkingMonth = new Unit()
    {
        Name = "working month",
        Symbol = null,
        CommonCode = "WM",
    };
    /// <summary>
    /// A unit of volume of finished lumber equal to 165 cubic feet.Synonym: standard cubic foot
    /// </summary>
    public static IConvertibleUnit Standard = new ConvertibleUnit()
    {
        Name = "standard",
        Symbol = "std",
        CommonCode = "WSD",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 4.672m,
    };
    public static IConvertibleUnit Watt = new ConvertibleUnit()
    {
        Name = "watt",
        Symbol = "W",
        CommonCode = "WTT",
        ConversionGroup = "watt",
        ConversionFactor = 1m,
    };
    /// <summary>
    /// A unit of distance used or formerly used by British surveyors.
    /// </summary>
    public static IConvertibleUnit GuntersChain = new ConvertibleUnit()
    {
        Name = "Gunter's chain",
        Symbol = "ch (UK)",
        CommonCode = "X1",
        ConversionGroup = "meter",
        ConversionFactor = 20.1168m,
    };
    public static IConvertibleUnit SquareYard = new ConvertibleUnit()
    {
        Name = "square yard",
        Symbol = "yd²",
        CommonCode = "YDK",
        ConversionGroup = "meter ** 2",
        ConversionFactor = 0.8361274000000001m,
    };
    public static IConvertibleUnit CubicYard = new ConvertibleUnit()
    {
        Name = "cubic yard",
        Symbol = "yd³",
        CommonCode = "YDQ",
        ConversionGroup = "meter ** 3",
        ConversionFactor = 0.764555m,
    };
    public static IConvertibleUnit Yard = new ConvertibleUnit()
    {
        Name = "yard",
        Symbol = "yd",
        CommonCode = "YRD",
        ConversionGroup = "meter",
        ConversionFactor = 0.9144m,
    };
    /// <summary>
    /// A unit of count defining the number of hanging containers.
    /// </summary>
    public static IUnit HangingContainer = new Unit()
    {
        Name = "hanging container",
        Symbol = null,
        CommonCode = "Z11",
    };
    /// <summary>
    /// A unit of count defining the number of pages.
    /// </summary>
    public static IUnit Page = new Unit()
    {
        Name = "page",
        Symbol = null,
        CommonCode = "ZP",
    };
    /// <summary>
    /// A unit of measure as agreed in common between two or more parties.
    /// </summary>
    public static IUnit MutuallyDefinedZZ = new Unit()
    {
        Name = "mutually defined",
        Symbol = null,
        CommonCode = "ZZ",
    };
    public static IUnit MutuallyDefinedXZZ = new Unit()
    {
        Name = "Mutually defined",
        Symbol = null,
        CommonCode = "XZZ",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time, as required by DIN 18451
    /// </summary>
    public static IUnit MetreWeek = new Unit()
    {
        Name = "Metre Week",
        Symbol = "m·wk",
        CommonCode = "MRW",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit SquareMetreWeek = new Unit()
    {
        Name = "Square Metre Week",
        Symbol = "m²· wk",
        CommonCode = "MKW",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit CubicMetreWeek = new Unit()
    {
        Name = "Cubic Metre Week",
        Symbol = "m³·wk",
        CommonCode = "MQW",
    };
    /// <summary>
    /// Unit for measuring the item amount and time as required by DIN 18451
    /// </summary>
    public static IUnit PieceWeek = new Unit()
    {
        Name = "Piece Week",
        Symbol = "piece·k",
        CommonCode = "HWE",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit MetreDay = new Unit()
    {
        Name = "Metre Day",
        Symbol = "m·day",
        CommonCode = "MRD",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit SquareMetreDay = new Unit()
    {
        Name = "Square Metre Day",
        Symbol = "m²·d",
        CommonCode = "MKD",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit CubicMetreDay = new Unit()
    {
        Name = "Cubic Metre Day",
        Symbol = "m³·d",
        CommonCode = "MQD",
    };
    /// <summary>
    /// Unit for measuring the item amount and time as required by DIN 18451
    /// </summary>
    public static IUnit PieceDay = new Unit()
    {
        Name = "Piece Day",
        Symbol = "piece·d",
        CommonCode = "HAD",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit MetreMonth = new Unit()
    {
        Name = "Metre Month",
        Symbol = "m·mo",
        CommonCode = "MRM",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit SquareMetreMonth = new Unit()
    {
        Name = "Square Metre Month",
        Symbol = "m²·mo",
        CommonCode = "MKM",
    };
    /// <summary>
    /// Unit for measuring physical dimensions and time as required by DIN 18451
    /// </summary>
    public static IUnit CubicMetreMonth = new Unit()
    {
        Name = "Cubic Metre Month",
        Symbol = "m³·mo",
        CommonCode = "MQM",
    };
    /// <summary>
    /// Unit for measuring the item amount and time as required by DIN 18451
    /// </summary>
    public static IUnit PieceMonth = new Unit()
    {
        Name = "Piece Month",
        Symbol = "piece·mo",
        CommonCode = "HMO",
    };
    /// <summary>
    /// The decibel watt or dBW is a unit for the measurement of the strength of a signal expressed in decibels relative to one watt.
    /// </summary>
    public static IUnit DecibelWatt = new Unit()
    {
        Name = "Decibel watt",
        Symbol = "dBW",
        CommonCode = "DBW",
    };
    /// <summary>
    /// dBm (sometimes dBmW or decibel-milliwatts) is unit of level used to indicate that a power ratio is expressed in decibels (dB) with reference to one milliwatt (mW).
    /// </summary>
    public static IUnit Decibelmilliwatts = new Unit()
    {
        Name = "Decibelmilliwatts",
        Symbol = "dBm",
        CommonCode = "DBM",
    };
    /// <summary>
    /// Formazin nephelometric unit (FNU) is used for water turbidity level evaluation
    /// </summary>
    public static IUnit FormazinNephelometricUnit = new Unit()
    {
        Name = "Formazin nephelometric unit",
        Symbol = "FNU",
        CommonCode = "FNU",
    };
    /// <summary>
    /// Nephelometric turbidity unit (NTU) is used for water turbidity level evaluation
    /// </summary>
    public static IUnit NephelometricTurbidityUnit = new Unit()
    {
        Name = "Nephelometric turbidity unit",
        Symbol = "NTU",
        CommonCode = "NTU",
    };
    /// <summary>
    /// A unit of frequency equal to 0.001 cycle per second
    /// </summary>
    public static IConvertibleUnit Millihertz = new ConvertibleUnit()
    {
        Name = "millihertz",
        Symbol = "mHz",
        CommonCode = "MTZ",
        ConversionGroup = "hertz",
        ConversionFactor = 0.001m,
    };
    /// <summary>
    /// An SI unit of amount of substance equal to 10−9 moles
    /// </summary>
    public static IConvertibleUnit Nanomole = new ConvertibleUnit()
    {
        Name = "nanomole",
        Symbol = "nmol",
        CommonCode = "Z9",
        ConversionGroup = "mole",
        ConversionFactor = 0.000000001m,
    };
    public static IUnit DrumSteel = new Unit()
    {
        Name = "Drum, steel",
        Symbol = null,
        CommonCode = "X1A",
    };
    public static IUnit DrumAluminium = new Unit()
    {
        Name = "Drum, aluminium",
        Symbol = null,
        CommonCode = "X1B",
    };
    public static IUnit DrumPlywood = new Unit()
    {
        Name = "Drum, plywood",
        Symbol = null,
        CommonCode = "X1D",
    };
    /// <summary>
    /// A packaging container of flexible construction.
    /// </summary>
    public static IUnit ContainerFlexible = new Unit()
    {
        Name = "Container, flexible",
        Symbol = null,
        CommonCode = "X1F",
    };
    public static IUnit DrumFibre = new Unit()
    {
        Name = "Drum, fibre",
        Symbol = null,
        CommonCode = "X1G",
    };
    public static IUnit DrumWooden = new Unit()
    {
        Name = "Drum, wooden",
        Symbol = null,
        CommonCode = "X1W",
    };
    public static IUnit BarrelWooden = new Unit()
    {
        Name = "Barrel, wooden",
        Symbol = null,
        CommonCode = "X2C",
    };
    public static IUnit JerricanSteel = new Unit()
    {
        Name = "Jerrican, steel",
        Symbol = null,
        CommonCode = "X3A",
    };
    public static IUnit JerricanPlastic = new Unit()
    {
        Name = "Jerrican, plastic",
        Symbol = null,
        CommonCode = "X3H",
    };
    /// <summary>
    /// A cloth plastic or paper based bag having the dimensions of the pallet on which it is constructed.
    /// </summary>
    public static IUnit BagSuperBulk = new Unit()
    {
        Name = "Bag, super bulk",
        Symbol = null,
        CommonCode = "X43",
    };
    /// <summary>
    /// A type of plastic bag, typically used to wrap promotional pieces, publications, product samples, and/or catalogues.
    /// </summary>
    public static IUnit BagPolybag = new Unit()
    {
        Name = "Bag, polybag",
        Symbol = null,
        CommonCode = "X44",
    };
    public static IUnit BoxSteel = new Unit()
    {
        Name = "Box, steel",
        Symbol = null,
        CommonCode = "X4A",
    };
    public static IUnit BoxAluminium = new Unit()
    {
        Name = "Box, aluminium",
        Symbol = null,
        CommonCode = "X4B",
    };
    public static IUnit BoxNaturalWood = new Unit()
    {
        Name = "Box, natural wood",
        Symbol = null,
        CommonCode = "X4C",
    };
    public static IUnit BoxPlywood = new Unit()
    {
        Name = "Box, plywood",
        Symbol = null,
        CommonCode = "X4D",
    };
    public static IUnit BoxReconstitutedWood = new Unit()
    {
        Name = "Box, reconstituted wood",
        Symbol = null,
        CommonCode = "X4F",
    };
    public static IUnit BoxFibreboard = new Unit()
    {
        Name = "Box, fibreboard",
        Symbol = null,
        CommonCode = "X4G",
    };
    public static IUnit BoxPlastic = new Unit()
    {
        Name = "Box, plastic",
        Symbol = null,
        CommonCode = "X4H",
    };
    public static IUnit BagWovenPlastic = new Unit()
    {
        Name = "Bag, woven plastic",
        Symbol = null,
        CommonCode = "X5H",
    };
    public static IUnit BagTextile = new Unit()
    {
        Name = "Bag, textile",
        Symbol = null,
        CommonCode = "X5L",
    };
    public static IUnit BagPaper = new Unit()
    {
        Name = "Bag, paper",
        Symbol = null,
        CommonCode = "X5M",
    };
    public static IUnit CompositePackagingPlasticReceptacle = new Unit()
    {
        Name = "Composite packaging, plastic receptacle",
        Symbol = null,
        CommonCode = "X6H",
    };
    public static IUnit CompositePackagingGlassReceptacle = new Unit()
    {
        Name = "Composite packaging, glass receptacle",
        Symbol = null,
        CommonCode = "X6P",
    };
    /// <summary>
    /// A type of portable container designed to store equipment for carriage in an automobile.
    /// </summary>
    public static IUnit CaseCar = new Unit()
    {
        Name = "Case, car",
        Symbol = null,
        CommonCode = "X7A",
    };
    /// <summary>
    /// A case made of wood for retaining substances or articles.
    /// </summary>
    public static IUnit CaseWooden = new Unit()
    {
        Name = "Case, wooden",
        Symbol = null,
        CommonCode = "X7B",
    };
    /// <summary>
    /// A platform or open-ended box, made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
    /// </summary>
    public static IUnit PalletWooden = new Unit()
    {
        Name = "Pallet, wooden",
        Symbol = null,
        CommonCode = "X8A",
    };
    /// <summary>
    /// A receptacle, made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
    /// </summary>
    public static IUnit CrateWooden = new Unit()
    {
        Name = "Crate, wooden",
        Symbol = null,
        CommonCode = "X8B",
    };
    /// <summary>
    /// Loose or unpacked pieces of wood tied or wrapped together.
    /// </summary>
    public static IUnit BundleWooden = new Unit()
    {
        Name = "Bundle, wooden",
        Symbol = null,
        CommonCode = "X8C",
    };
    public static IUnit IntermediateBulkContainerRigidPlastic = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic",
        Symbol = null,
        CommonCode = "XAA",
    };
    /// <summary>
    /// Containment vessel made of fibre used for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptacleFibre = new Unit()
    {
        Name = "Receptacle, fibre",
        Symbol = null,
        CommonCode = "XAB",
    };
    /// <summary>
    /// Containment vessel made of paper for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptaclePaper = new Unit()
    {
        Name = "Receptacle, paper",
        Symbol = null,
        CommonCode = "XAC",
    };
    /// <summary>
    /// Containment vessel made of wood for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptacleWooden = new Unit()
    {
        Name = "Receptacle, wooden",
        Symbol = null,
        CommonCode = "XAD",
    };
    public static IUnit Aerosol = new Unit()
    {
        Name = "Aerosol",
        Symbol = null,
        CommonCode = "XAE",
    };
    /// <summary>
    /// Standard sized pallet of dimensions 80 centimeters by 60 centimeters (cms).
    /// </summary>
    public static IUnit PalletModularCollars80Cms60Cms = new Unit()
    {
        Name = "Pallet, modular, collars 80cms * 60cms",
        Symbol = null,
        CommonCode = "XAF",
    };
    /// <summary>
    /// Pallet load secured with transparent plastic film that has been wrapped around and then shrunk tightly.
    /// </summary>
    public static IUnit PalletShrinkwrapped = new Unit()
    {
        Name = "Pallet, shrinkwrapped",
        Symbol = null,
        CommonCode = "XAG",
    };
    /// <summary>
    /// Standard sized pallet of dimensions 100centimeters by 110 centimeters (cms).
    /// </summary>
    public static IUnit Pallet100Cms110Cms = new Unit()
    {
        Name = "Pallet, 100cms * 110cms",
        Symbol = null,
        CommonCode = "XAH",
    };
    public static IUnit Clamshell = new Unit()
    {
        Name = "Clamshell",
        Symbol = null,
        CommonCode = "XAI",
    };
    /// <summary>
    /// Container used in the transport of linear material such as yarn.
    /// </summary>
    public static IUnit Cone = new Unit()
    {
        Name = "Cone",
        Symbol = null,
        CommonCode = "XAJ",
    };
    public static IUnit AmpouleNonprotected = new Unit()
    {
        Name = "Ampoule, nonprotected",
        Symbol = null,
        CommonCode = "XAM",
    };
    public static IUnit AmpouleProtected = new Unit()
    {
        Name = "Ampoule, protected",
        Symbol = null,
        CommonCode = "XAP",
    };
    public static IUnit Atomizer = new Unit()
    {
        Name = "Atomizer",
        Symbol = null,
        CommonCode = "XAT",
    };
    public static IUnit Capsule = new Unit()
    {
        Name = "Capsule",
        Symbol = null,
        CommonCode = "XAV",
    };
    /// <summary>
    /// A band use to retain multiple articles together.
    /// </summary>
    public static IUnit Belt = new Unit()
    {
        Name = "Belt",
        Symbol = null,
        CommonCode = "XB4",
    };
    public static IUnit Barrel = new Unit()
    {
        Name = "Barrel",
        Symbol = null,
        CommonCode = "XBA",
    };
    public static IUnit Bobbin = new Unit()
    {
        Name = "Bobbin",
        Symbol = null,
        CommonCode = "XBB",
    };
    public static IUnit BottlecratePerBottlerack = new Unit()
    {
        Name = "Bottlecrate / bottlerack",
        Symbol = null,
        CommonCode = "XBC",
    };
    public static IUnit Board = new Unit()
    {
        Name = "Board",
        Symbol = null,
        CommonCode = "XBD",
    };
    public static IUnit Bundle = new Unit()
    {
        Name = "Bundle",
        Symbol = null,
        CommonCode = "XBE",
    };
    public static IUnit BalloonNonprotected = new Unit()
    {
        Name = "Balloon, nonprotected",
        Symbol = null,
        CommonCode = "XBF",
    };
    /// <summary>
    /// A receptacle made of flexible material with an open or closed top.
    /// </summary>
    public static IUnit Bag = new Unit()
    {
        Name = "Bag",
        Symbol = null,
        CommonCode = "XBG",
    };
    public static IUnit Bunch = new Unit()
    {
        Name = "Bunch",
        Symbol = null,
        CommonCode = "XBH",
    };
    public static IUnit Bin = new Unit()
    {
        Name = "Bin",
        Symbol = null,
        CommonCode = "XBI",
    };
    public static IUnit Bucket = new Unit()
    {
        Name = "Bucket",
        Symbol = null,
        CommonCode = "XBJ",
    };
    public static IUnit Basket = new Unit()
    {
        Name = "Basket",
        Symbol = null,
        CommonCode = "XBK",
    };
    public static IUnit BaleCompressed = new Unit()
    {
        Name = "Bale, compressed",
        Symbol = null,
        CommonCode = "XBL",
    };
    public static IUnit Basin = new Unit()
    {
        Name = "Basin",
        Symbol = null,
        CommonCode = "XBM",
    };
    public static IUnit BaleNoncompressed = new Unit()
    {
        Name = "Bale, noncompressed",
        Symbol = null,
        CommonCode = "XBN",
    };
    /// <summary>
    /// A narrow-necked cylindrical shaped vessel without external protective packing material.
    /// </summary>
    public static IUnit BottleNonprotectedCylindrical = new Unit()
    {
        Name = "Bottle, nonprotected, cylindrical",
        Symbol = null,
        CommonCode = "XBO",
    };
    public static IUnit BalloonProtected = new Unit()
    {
        Name = "Balloon, protected",
        Symbol = null,
        CommonCode = "XBP",
    };
    /// <summary>
    /// A narrow-necked cylindrical shaped vessel with external protective packing material.
    /// </summary>
    public static IUnit BottleProtectedCylindrical = new Unit()
    {
        Name = "Bottle, protected cylindrical",
        Symbol = null,
        CommonCode = "XBQ",
    };
    public static IUnit Bar = new Unit()
    {
        Name = "Bar",
        Symbol = null,
        CommonCode = "XBR",
    };
    /// <summary>
    /// A narrow-necked bulb shaped vessel without external protective packing material.
    /// </summary>
    public static IUnit BottleNonprotectedBulbous = new Unit()
    {
        Name = "Bottle, nonprotected, bulbous",
        Symbol = null,
        CommonCode = "XBS",
    };
    public static IUnit Bolt = new Unit()
    {
        Name = "Bolt",
        Symbol = null,
        CommonCode = "XBT",
    };
    public static IUnit Butt = new Unit()
    {
        Name = "Butt",
        Symbol = null,
        CommonCode = "XBU",
    };
    /// <summary>
    /// A narrow-necked bulb shaped vessel with external protective packing material.
    /// </summary>
    public static IUnit BottleProtectedBulbous = new Unit()
    {
        Name = "Bottle, protected bulbous",
        Symbol = null,
        CommonCode = "XBV",
    };
    public static IUnit BoxForLiquids = new Unit()
    {
        Name = "Box, for liquids",
        Symbol = null,
        CommonCode = "XBW",
    };
    public static IUnit Box = new Unit()
    {
        Name = "Box",
        Symbol = null,
        CommonCode = "XBX",
    };
    public static IUnit BoardInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Board, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XBY",
    };
    public static IUnit BarsInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Bars, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XBZ",
    };
    public static IUnit CanRectangular = new Unit()
    {
        Name = "Can, rectangular",
        Symbol = null,
        CommonCode = "XCA",
    };
    public static IUnit CrateBeer = new Unit()
    {
        Name = "Crate, beer",
        Symbol = null,
        CommonCode = "XCB",
    };
    public static IUnit Churn = new Unit()
    {
        Name = "Churn",
        Symbol = null,
        CommonCode = "XCC",
    };
    public static IUnit CanWithHandleAndSpout = new Unit()
    {
        Name = "Can, with handle and spout",
        Symbol = null,
        CommonCode = "XCD",
    };
    public static IUnit Creel = new Unit()
    {
        Name = "Creel",
        Symbol = null,
        CommonCode = "XCE",
    };
    public static IUnit Coffer = new Unit()
    {
        Name = "Coffer",
        Symbol = null,
        CommonCode = "XCF",
    };
    public static IUnit Cage = new Unit()
    {
        Name = "Cage",
        Symbol = null,
        CommonCode = "XCG",
    };
    public static IUnit Chest = new Unit()
    {
        Name = "Chest",
        Symbol = null,
        CommonCode = "XCH",
    };
    public static IUnit Canister = new Unit()
    {
        Name = "Canister",
        Symbol = null,
        CommonCode = "XCI",
    };
    public static IUnit Coffin = new Unit()
    {
        Name = "Coffin",
        Symbol = null,
        CommonCode = "XCJ",
    };
    public static IUnit Cask = new Unit()
    {
        Name = "Cask",
        Symbol = null,
        CommonCode = "XCK",
    };
    public static IUnit Coil = new Unit()
    {
        Name = "Coil",
        Symbol = null,
        CommonCode = "XCL",
    };
    public static IUnit ContainerNotOtherwiseSpecifiedAsTransportEquipment = new Unit()
    {
        Name = "Container, not otherwise specified as transport equipment",
        Symbol = null,
        CommonCode = "XCN",
    };
    public static IUnit CarboyNonprotected = new Unit()
    {
        Name = "Carboy, nonprotected",
        Symbol = null,
        CommonCode = "XCO",
    };
    public static IUnit CarboyProtected = new Unit()
    {
        Name = "Carboy, protected",
        Symbol = null,
        CommonCode = "XCP",
    };
    /// <summary>
    /// Package containing a charge such as propelling explosive for firearms or ink toner for a printer.
    /// </summary>
    public static IUnit Cartridge = new Unit()
    {
        Name = "Cartridge",
        Symbol = null,
        CommonCode = "XCQ",
    };
    public static IUnit Crate = new Unit()
    {
        Name = "Crate",
        Symbol = null,
        CommonCode = "XCR",
    };
    public static IUnit Case = new Unit()
    {
        Name = "Case",
        Symbol = null,
        CommonCode = "XCS",
    };
    public static IUnit Carton = new Unit()
    {
        Name = "Carton",
        Symbol = null,
        CommonCode = "XCT",
    };
    public static IUnit Cup = new Unit()
    {
        Name = "Cup",
        Symbol = null,
        CommonCode = "XCU",
    };
    public static IUnit Cover = new Unit()
    {
        Name = "Cover",
        Symbol = null,
        CommonCode = "XCV",
    };
    public static IUnit CageRoll = new Unit()
    {
        Name = "Cage, roll",
        Symbol = null,
        CommonCode = "XCW",
    };
    public static IUnit CanCylindrical = new Unit()
    {
        Name = "Can, cylindrical",
        Symbol = null,
        CommonCode = "XCX",
    };
    public static IUnit Cylinder = new Unit()
    {
        Name = "Cylinder",
        Symbol = null,
        CommonCode = "XCY",
    };
    public static IUnit Canvas = new Unit()
    {
        Name = "Canvas",
        Symbol = null,
        CommonCode = "XCZ",
    };
    public static IUnit CrateMultipleLayerPlastic = new Unit()
    {
        Name = "Crate, multiple layer, plastic",
        Symbol = null,
        CommonCode = "XDA",
    };
    public static IUnit CrateMultipleLayerWooden = new Unit()
    {
        Name = "Crate, multiple layer, wooden",
        Symbol = null,
        CommonCode = "XDB",
    };
    public static IUnit CrateMultipleLayerCardboard = new Unit()
    {
        Name = "Crate, multiple layer, cardboard",
        Symbol = null,
        CommonCode = "XDC",
    };
    public static IUnit CageCommonwealthHandlingEquipmentPoolCHEP = new Unit()
    {
        Name = "Cage, Commonwealth Handling Equipment Pool  (CHEP)",
        Symbol = null,
        CommonCode = "XDG",
    };
    /// <summary>
    /// A box mounted on a pallet base under the control of CHEP.
    /// </summary>
    public static IUnit BoxCommonwealthHandlingEquipmentPoolCHEPEurobox = new Unit()
    {
        Name = "Box, Commonwealth Handling Equipment Pool (CHEP), Eurobox",
        Symbol = null,
        CommonCode = "XDH",
    };
    public static IUnit DrumIron = new Unit()
    {
        Name = "Drum, iron",
        Symbol = null,
        CommonCode = "XDI",
    };
    public static IUnit DemijohnNonprotected = new Unit()
    {
        Name = "Demijohn, nonprotected",
        Symbol = null,
        CommonCode = "XDJ",
    };
    public static IUnit CrateBulkCardboard = new Unit()
    {
        Name = "Crate, bulk, cardboard",
        Symbol = null,
        CommonCode = "XDK",
    };
    public static IUnit CrateBulkPlastic = new Unit()
    {
        Name = "Crate, bulk, plastic",
        Symbol = null,
        CommonCode = "XDL",
    };
    public static IUnit CrateBulkWooden = new Unit()
    {
        Name = "Crate, bulk, wooden",
        Symbol = null,
        CommonCode = "XDM",
    };
    public static IUnit Dispenser = new Unit()
    {
        Name = "Dispenser",
        Symbol = null,
        CommonCode = "XDN",
    };
    public static IUnit DemijohnProtected = new Unit()
    {
        Name = "Demijohn, protected",
        Symbol = null,
        CommonCode = "XDP",
    };
    public static IUnit Drum = new Unit()
    {
        Name = "Drum",
        Symbol = null,
        CommonCode = "XDR",
    };
    public static IUnit TrayOneLayerNoCoverPlastic = new Unit()
    {
        Name = "Tray, one layer no cover, plastic",
        Symbol = null,
        CommonCode = "XDS",
    };
    public static IUnit TrayOneLayerNoCoverWooden = new Unit()
    {
        Name = "Tray, one layer no cover, wooden",
        Symbol = null,
        CommonCode = "XDT",
    };
    public static IUnit TrayOneLayerNoCoverPolystyrene = new Unit()
    {
        Name = "Tray, one layer no cover, polystyrene",
        Symbol = null,
        CommonCode = "XDU",
    };
    public static IUnit TrayOneLayerNoCoverCardboard = new Unit()
    {
        Name = "Tray, one layer no cover, cardboard",
        Symbol = null,
        CommonCode = "XDV",
    };
    public static IUnit TrayTwoLayersNoCoverPlasticTray = new Unit()
    {
        Name = "Tray, two layers no cover, plastic tray",
        Symbol = null,
        CommonCode = "XDW",
    };
    public static IUnit TrayTwoLayersNoCoverWooden = new Unit()
    {
        Name = "Tray, two layers no cover, wooden",
        Symbol = null,
        CommonCode = "XDX",
    };
    public static IUnit TrayTwoLayersNoCoverCardboard = new Unit()
    {
        Name = "Tray, two layers no cover, cardboard",
        Symbol = null,
        CommonCode = "XDY",
    };
    public static IUnit BagPlastic = new Unit()
    {
        Name = "Bag, plastic",
        Symbol = null,
        CommonCode = "XEC",
    };
    public static IUnit CaseWithPalletBase = new Unit()
    {
        Name = "Case, with pallet base",
        Symbol = null,
        CommonCode = "XED",
    };
    public static IUnit CaseWithPalletBaseWooden = new Unit()
    {
        Name = "Case, with pallet base, wooden",
        Symbol = null,
        CommonCode = "XEE",
    };
    public static IUnit CaseWithPalletBaseCardboard = new Unit()
    {
        Name = "Case, with pallet base, cardboard",
        Symbol = null,
        CommonCode = "XEF",
    };
    public static IUnit CaseWithPalletBasePlastic = new Unit()
    {
        Name = "Case, with pallet base, plastic",
        Symbol = null,
        CommonCode = "XEG",
    };
    public static IUnit CaseWithPalletBaseMetal = new Unit()
    {
        Name = "Case, with pallet base, metal",
        Symbol = null,
        CommonCode = "XEH",
    };
    public static IUnit CaseIsothermic = new Unit()
    {
        Name = "Case, isothermic",
        Symbol = null,
        CommonCode = "XEI",
    };
    public static IUnit Envelope = new Unit()
    {
        Name = "Envelope",
        Symbol = null,
        CommonCode = "XEN",
    };
    /// <summary>
    /// A flexible containment bag made of plastic, typically for the transportation bulk non-hazardous cargoes using standard size shipping containers.
    /// </summary>
    public static IUnit Flexibag = new Unit()
    {
        Name = "Flexibag",
        Symbol = null,
        CommonCode = "XFB",
    };
    public static IUnit CrateFruit = new Unit()
    {
        Name = "Crate, fruit",
        Symbol = null,
        CommonCode = "XFC",
    };
    public static IUnit CrateFramed = new Unit()
    {
        Name = "Crate, framed",
        Symbol = null,
        CommonCode = "XFD",
    };
    /// <summary>
    /// A flexible containment tank made of plastic, typically for the transportation bulk non-hazardous cargoes using standard size shipping containers.
    /// </summary>
    public static IUnit Flexitank = new Unit()
    {
        Name = "Flexitank",
        Symbol = null,
        CommonCode = "XFE",
    };
    public static IUnit Firkin = new Unit()
    {
        Name = "Firkin",
        Symbol = null,
        CommonCode = "XFI",
    };
    public static IUnit Flask = new Unit()
    {
        Name = "Flask",
        Symbol = null,
        CommonCode = "XFL",
    };
    public static IUnit Footlocker = new Unit()
    {
        Name = "Footlocker",
        Symbol = null,
        CommonCode = "XFO",
    };
    public static IUnit Filmpack = new Unit()
    {
        Name = "Filmpack",
        Symbol = null,
        CommonCode = "XFP",
    };
    public static IUnit Frame = new Unit()
    {
        Name = "Frame",
        Symbol = null,
        CommonCode = "XFR",
    };
    public static IUnit Foodtainer = new Unit()
    {
        Name = "Foodtainer",
        Symbol = null,
        CommonCode = "XFT",
    };
    /// <summary>
    /// Wheeled flat bedded device on which trays or other regular shaped items are packed for transportation purposes.
    /// </summary>
    public static IUnit CartFlatbed = new Unit()
    {
        Name = "Cart, flatbed",
        Symbol = null,
        CommonCode = "XFW",
    };
    public static IUnit BagFlexibleContainer = new Unit()
    {
        Name = "Bag, flexible container",
        Symbol = null,
        CommonCode = "XFX",
    };
    /// <summary>
    /// A narrow-necked metal cylinder for retention of liquefied or compressed gas.
    /// </summary>
    public static IUnit BottleGas = new Unit()
    {
        Name = "Bottle, gas",
        Symbol = null,
        CommonCode = "XGB",
    };
    public static IUnit Girder = new Unit()
    {
        Name = "Girder",
        Symbol = null,
        CommonCode = "XGI",
    };
    /// <summary>
    /// A container with a capacity of one gallon.
    /// </summary>
    public static IUnit ContainerGallon = new Unit()
    {
        Name = "Container, gallon",
        Symbol = null,
        CommonCode = "XGL",
    };
    /// <summary>
    /// Containment vessel made of glass for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptacleGlass = new Unit()
    {
        Name = "Receptacle, glass",
        Symbol = null,
        CommonCode = "XGR",
    };
    /// <summary>
    /// Tray containing flat items stacked on top of one another.
    /// </summary>
    public static IUnit TrayContainingHorizontallyStackedFlatItems = new Unit()
    {
        Name = "Tray, containing horizontally stacked flat items",
        Symbol = null,
        CommonCode = "XGU",
    };
    /// <summary>
    /// A sack made of gunny or burlap, used for transporting coarse commodities, such as grains, potatoes, and other agricultural products.
    /// </summary>
    public static IUnit BagGunny = new Unit()
    {
        Name = "Bag, gunny",
        Symbol = null,
        CommonCode = "XGY",
    };
    public static IUnit GirdersInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Girders, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XGZ",
    };
    public static IUnit BasketWithHandlePlastic = new Unit()
    {
        Name = "Basket, with handle, plastic",
        Symbol = null,
        CommonCode = "XHA",
    };
    public static IUnit BasketWithHandleWooden = new Unit()
    {
        Name = "Basket, with handle, wooden",
        Symbol = null,
        CommonCode = "XHB",
    };
    public static IUnit BasketWithHandleCardboard = new Unit()
    {
        Name = "Basket, with handle, cardboard",
        Symbol = null,
        CommonCode = "XHC",
    };
    public static IUnit Hogshead = new Unit()
    {
        Name = "Hogshead",
        Symbol = null,
        CommonCode = "XHG",
    };
    /// <summary>
    /// A purpose shaped device with a hook at the top for hanging items from a rail.
    /// </summary>
    public static IUnit Hanger = new Unit()
    {
        Name = "Hanger",
        Symbol = null,
        CommonCode = "XHN",
    };
    public static IUnit Hamper = new Unit()
    {
        Name = "Hamper",
        Symbol = null,
        CommonCode = "XHR",
    };
    public static IUnit PackageDisplayWooden = new Unit()
    {
        Name = "Package, display, wooden",
        Symbol = null,
        CommonCode = "XIA",
    };
    public static IUnit PackageDisplayCardboard = new Unit()
    {
        Name = "Package, display, cardboard",
        Symbol = null,
        CommonCode = "XIB",
    };
    public static IUnit PackageDisplayPlastic = new Unit()
    {
        Name = "Package, display, plastic",
        Symbol = null,
        CommonCode = "XIC",
    };
    public static IUnit PackageDisplayMetal = new Unit()
    {
        Name = "Package, display, metal",
        Symbol = null,
        CommonCode = "XID",
    };
    public static IUnit PackageShow = new Unit()
    {
        Name = "Package, show",
        Symbol = null,
        CommonCode = "XIE",
    };
    /// <summary>
    /// A flexible tubular package or skin, possibly transparent, often used for containment of foodstuffs (e.g. salami sausage).
    /// </summary>
    public static IUnit PackageFlow = new Unit()
    {
        Name = "Package, flow",
        Symbol = null,
        CommonCode = "XIF",
    };
    public static IUnit PackagePaperWrapped = new Unit()
    {
        Name = "Package, paper wrapped",
        Symbol = null,
        CommonCode = "XIG",
    };
    public static IUnit DrumPlastic = new Unit()
    {
        Name = "Drum, plastic",
        Symbol = null,
        CommonCode = "XIH",
    };
    /// <summary>
    /// Packaging material made out of cardboard that facilitates the separation of individual glass or plastic bottles.
    /// </summary>
    public static IUnit PackageCardboardWithBottleGripholes = new Unit()
    {
        Name = "Package, cardboard, with bottle gripholes",
        Symbol = null,
        CommonCode = "XIK",
    };
    /// <summary>
    /// Lidded stackable rigid tray compliant with CEN TS 14482:2002.
    /// </summary>
    public static IUnit TrayRigidLiddedStackableCENTS144822002 = new Unit()
    {
        Name = "Tray, rigid, lidded stackable (CEN TS 14482:2002)",
        Symbol = null,
        CommonCode = "XIL",
    };
    public static IUnit Ingot = new Unit()
    {
        Name = "Ingot",
        Symbol = null,
        CommonCode = "XIN",
    };
    public static IUnit IngotsInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Ingots, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XIZ",
    };
    /// <summary>
    /// A flexible containment bag, widely used for storage, transportation and handling of powder, flake or granular materials. Typically constructed from woven polypropylene (PP) fabric in the form of cubic bags.
    /// </summary>
    public static IUnit BagJumbo = new Unit()
    {
        Name = "Bag, jumbo",
        Symbol = null,
        CommonCode = "XJB",
    };
    public static IUnit JerricanRectangular = new Unit()
    {
        Name = "Jerrican, rectangular",
        Symbol = null,
        CommonCode = "XJC",
    };
    public static IUnit Jug = new Unit()
    {
        Name = "Jug",
        Symbol = null,
        CommonCode = "XJG",
    };
    public static IUnit Jar = new Unit()
    {
        Name = "Jar",
        Symbol = null,
        CommonCode = "XJR",
    };
    public static IUnit Jutebag = new Unit()
    {
        Name = "Jutebag",
        Symbol = null,
        CommonCode = "XJT",
    };
    public static IUnit JerricanCylindrical = new Unit()
    {
        Name = "Jerrican, cylindrical",
        Symbol = null,
        CommonCode = "XJY",
    };
    public static IUnit Keg = new Unit()
    {
        Name = "Keg",
        Symbol = null,
        CommonCode = "XKG",
    };
    /// <summary>
    /// A collection of bags, cases and/or containers which hold personal belongings for a journey.
    /// </summary>
    public static IUnit Luggage = new Unit()
    {
        Name = "Luggage",
        Symbol = null,
        CommonCode = "XLE",
    };
    public static IUnit Log = new Unit()
    {
        Name = "Log",
        Symbol = null,
        CommonCode = "XLG",
    };
    public static IUnit Lot = new Unit()
    {
        Name = "Lot",
        Symbol = null,
        CommonCode = "XLT",
    };
    /// <summary>
    /// A wooden box for the transportation and storage of fruit or vegetables.
    /// </summary>
    public static IUnit Lug = new Unit()
    {
        Name = "Lug",
        Symbol = null,
        CommonCode = "XLU",
    };
    /// <summary>
    /// A wooden or metal container used for packing household goods and personal effects.
    /// </summary>
    public static IUnit Liftvan = new Unit()
    {
        Name = "Liftvan",
        Symbol = null,
        CommonCode = "XLV",
    };
    public static IUnit LogsInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Logs, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XLZ",
    };
    /// <summary>
    /// Containment box made of metal for retaining substances or articles.
    /// </summary>
    public static IUnit CrateMetal = new Unit()
    {
        Name = "Crate, metal",
        Symbol = null,
        CommonCode = "XMA",
    };
    public static IUnit BagMultiply = new Unit()
    {
        Name = "Bag, multiply",
        Symbol = null,
        CommonCode = "XMB",
    };
    public static IUnit CrateMilk = new Unit()
    {
        Name = "Crate, milk",
        Symbol = null,
        CommonCode = "XMC",
    };
    /// <summary>
    /// A type of containment box made of metal for retaining substances or articles, not otherwise specified as transport equipment.
    /// </summary>
    public static IUnit ContainerMetal = new Unit()
    {
        Name = "Container, metal",
        Symbol = null,
        CommonCode = "XME",
    };
    /// <summary>
    /// Containment vessel made of metal for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptacleMetal = new Unit()
    {
        Name = "Receptacle, metal",
        Symbol = null,
        CommonCode = "XMR",
    };
    public static IUnit SackMultiwall = new Unit()
    {
        Name = "Sack, multiwall",
        Symbol = null,
        CommonCode = "XMS",
    };
    public static IUnit Mat = new Unit()
    {
        Name = "Mat",
        Symbol = null,
        CommonCode = "XMT",
    };
    /// <summary>
    /// Containment vessel wrapped with plastic for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptaclePlasticWrapped = new Unit()
    {
        Name = "Receptacle, plastic wrapped",
        Symbol = null,
        CommonCode = "XMW",
    };
    public static IUnit Matchbox = new Unit()
    {
        Name = "Matchbox",
        Symbol = null,
        CommonCode = "XMX",
    };
    public static IUnit NotAvailable = new Unit()
    {
        Name = "Not available",
        Symbol = null,
        CommonCode = "XNA",
    };
    public static IUnit UnpackedOrUnpackaged = new Unit()
    {
        Name = "Unpacked or unpackaged",
        Symbol = null,
        CommonCode = "XNE",
    };
    public static IUnit UnpackedOrUnpackagedSingleUnit = new Unit()
    {
        Name = "Unpacked or unpackaged, single unit",
        Symbol = null,
        CommonCode = "XNF",
    };
    public static IUnit UnpackedOrUnpackagedMultipleUnits = new Unit()
    {
        Name = "Unpacked or unpackaged, multiple units",
        Symbol = null,
        CommonCode = "XNG",
    };
    public static IUnit Nest = new Unit()
    {
        Name = "Nest",
        Symbol = null,
        CommonCode = "XNS",
    };
    public static IUnit Net = new Unit()
    {
        Name = "Net",
        Symbol = null,
        CommonCode = "XNT",
    };
    public static IUnit NetTubePlastic = new Unit()
    {
        Name = "Net, tube, plastic",
        Symbol = null,
        CommonCode = "XNU",
    };
    public static IUnit NetTubeTextile = new Unit()
    {
        Name = "Net, tube, textile",
        Symbol = null,
        CommonCode = "XNV",
    };
    /// <summary>
    /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 40 centimeters x 60 centimeters.
    /// </summary>
    public static IUnit PalletCHEP40CmX60Cm = new Unit()
    {
        Name = "Pallet, CHEP 40 cm x 60 cm",
        Symbol = null,
        CommonCode = "XOA",
    };
    /// <summary>
    /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 80 centimeters x 120 centimeters.
    /// </summary>
    public static IUnit PalletCHEP80CmX120Cm = new Unit()
    {
        Name = "Pallet, CHEP 80 cm x 120 cm",
        Symbol = null,
        CommonCode = "XOB",
    };
    /// <summary>
    /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 100 centimeters x 120 centimeters.
    /// </summary>
    public static IUnit PalletCHEP100CmX120Cm = new Unit()
    {
        Name = "Pallet, CHEP 100 cm x 120 cm",
        Symbol = null,
        CommonCode = "XOC",
    };
    /// <summary>
    /// Australian standard pallet of dimensions 116.5 centimeters x 116.5 centimeters.
    /// </summary>
    public static IUnit PalletAS40681993 = new Unit()
    {
        Name = "Pallet, AS 40681993",
        Symbol = null,
        CommonCode = "XOD",
    };
    /// <summary>
    /// ISO standard pallet of dimensions 110 centimeters x 110 centimeters, prevalent in Asia - Pacific region.
    /// </summary>
    public static IUnit PalletISOT11 = new Unit()
    {
        Name = "Pallet, ISO T11",
        Symbol = null,
        CommonCode = "XOE",
    };
    /// <summary>
    /// A pallet equivalent shipping platform of unknown dimensions or unknown weight.
    /// </summary>
    public static IUnit PlatformUnspecifiedWeightOrDimension = new Unit()
    {
        Name = "Platform, unspecified weight or dimension",
        Symbol = null,
        CommonCode = "XOF",
    };
    /// <summary>
    /// A solid piece of a hard substance, such as granite, having one or more flat sides.
    /// </summary>
    public static IUnit Block = new Unit()
    {
        Name = "Block",
        Symbol = null,
        CommonCode = "XOK",
    };
    /// <summary>
    /// A standard cardboard container of large dimensions for storing for example vegetables, granules of plastics or other dry products.
    /// </summary>
    public static IUnit Octabin = new Unit()
    {
        Name = "Octabin",
        Symbol = null,
        CommonCode = "XOT",
    };
    /// <summary>
    /// A type of containment box that serves as the outer shipping container, not otherwise specified as transport equipment.
    /// </summary>
    public static IUnit ContainerOuter = new Unit()
    {
        Name = "Container, outer",
        Symbol = null,
        CommonCode = "XOU",
    };
    /// <summary>
    /// Standard pallet with dimensions 80 X 60 cm.
    /// </summary>
    public static IUnit PalletISO01Per2EUROPallet = new Unit()
    {
        Name = "Pallet ISO 0  1/2 EURO Pallet",
        Symbol = null,
        CommonCode = "XOG",
    };
    /// <summary>
    /// Standard pallet with dimensions 80 X 120 cm.
    /// </summary>
    public static IUnit PalletISO11Per1EUROPallet = new Unit()
    {
        Name = "Pallet ISO 1  1/1 EURO Pallet",
        Symbol = null,
        CommonCode = "XOH",
    };
    /// <summary>
    /// Standard pallet with dimensions 100 X 120 cm.
    /// </summary>
    public static IUnit PalletISO22Per1EUROPallet = new Unit()
    {
        Name = "Pallet ISO 2 – 2/1 EURO Pallet",
        Symbol = null,
        CommonCode = "XOI",
    };
    /// <summary>
    /// Standard pallet with dimensions 60 X 40 cm.
    /// </summary>
    public static IUnit Unit1Per4EUROPallet = new Unit()
    {
        Name = "1/4 EURO Pallet",
        Symbol = null,
        CommonCode = "XOJ",
    };
    /// <summary>
    /// Standard pallet with dimensions 40 X 30 cm.
    /// </summary>
    public static IUnit Unit1Per8EUROPallet = new Unit()
    {
        Name = "1/8 EURO Pallet",
        Symbol = null,
        CommonCode = "XOL",
    };
    /// <summary>
    /// A standard pallet with standard dimensions 80 x 120cm made of a synthetic material for hygienic reasons.
    /// </summary>
    public static IUnit SyntheticPalletISO1 = new Unit()
    {
        Name = "Synthetic pallet ISO 1",
        Symbol = null,
        CommonCode = "XOM",
    };
    /// <summary>
    /// A standard pallet with standard dimensions 100 x 120cm made of a synthetic material for hygienic reasons.
    /// </summary>
    public static IUnit SyntheticPalletISO2 = new Unit()
    {
        Name = "Synthetic pallet ISO 2",
        Symbol = null,
        CommonCode = "XON",
    };
    /// <summary>
    /// Pallet provided by the wholesaler.
    /// </summary>
    public static IUnit WholesalerPallet = new Unit()
    {
        Name = "Wholesaler pallet",
        Symbol = null,
        CommonCode = "XOP",
    };
    /// <summary>
    /// Pallet with dimensions 80 X 100 cm.
    /// </summary>
    public static IUnit Pallet80X100Cm = new Unit()
    {
        Name = "Pallet 80 X 100 cm",
        Symbol = null,
        CommonCode = "XOQ",
    };
    /// <summary>
    /// Pallet with dimensions 60 X 100 cm.
    /// </summary>
    public static IUnit Pallet60X100Cm = new Unit()
    {
        Name = "Pallet 60 X 100 cm",
        Symbol = null,
        CommonCode = "XOR",
    };
    /// <summary>
    /// Pallet need not be returned to the point of expedition
    /// </summary>
    public static IUnit OnewayPallet = new Unit()
    {
        Name = "Oneway pallet",
        Symbol = null,
        CommonCode = "XOS",
    };
    /// <summary>
    /// Pallet must be returned to the point of expedition.
    /// </summary>
    public static IUnit ReturnablePallet = new Unit()
    {
        Name = "Returnable pallet",
        Symbol = null,
        CommonCode = "XOV",
    };
    /// <summary>
    /// A non-rigid container made of fabric, paper, plastic, etc, with an opening at the top which can be closed and which is suitable for use on pallets
    /// </summary>
    public static IUnit LargeBagPalletSized = new Unit()
    {
        Name = "Large bag, pallet sized",
        Symbol = null,
        CommonCode = "XOW",
    };
    /// <summary>
    /// A wheeled pallet with raised rim for the storing and transporting of loads. Dimensions: 81 x 67 x 135 cm (length x width x height).
    /// </summary>
    public static IUnit AWheeledPalletWithRaisedRim81X67X135 = new Unit()
    {
        Name = "A wheeled pallet with raised rim (81 x 67 x 135)",
        Symbol = null,
        CommonCode = "XOX",
    };
    /// <summary>
    /// A wheeled pallet with raised rim for the storing and transporting of loads. Dimensions: 81 x 72 x 135 cm (length x width x height).
    /// </summary>
    public static IUnit AWheeledPalletWithRaisedRim81X72X135 = new Unit()
    {
        Name = "A Wheeled pallet with raised rim (81 x 72 x 135)",
        Symbol = null,
        CommonCode = "XOY",
    };
    /// <summary>
    /// A wheeled pallet with raised rim for the storing and transporting of loads. Dimensions: 81 x 60 x 16 cm (length x width x height).
    /// </summary>
    public static IUnit WheeledPalletWithRaisedRim81X60X16 = new Unit()
    {
        Name = "Wheeled pallet with raised rim ( 81 x 60 x 16)",
        Symbol = null,
        CommonCode = "XOZ",
    };
    /// <summary>
    /// A two sided cage mounted on wheels with fixing strap. Dimensions: 900 x 770 x 1513 cm (length x width x height).
    /// </summary>
    public static IUnit TwoSidedCageOnWheelsWithFixingStrap = new Unit()
    {
        Name = "Two sided cage on wheels with fixing strap",
        Symbol = null,
        CommonCode = "XO1",
    };
    /// <summary>
    /// A low cart for the transportation and storage of groceries, milk, etc.
    /// </summary>
    public static IUnit Trolley = new Unit()
    {
        Name = "Trolley",
        Symbol = null,
        CommonCode = "XO2",
    };
    /// <summary>
    /// Oneway pallet with dimensions 80 X 60 cm.
    /// </summary>
    public static IUnit OnewayPalletISO01Per2EUROPallet = new Unit()
    {
        Name = "Oneway pallet ISO 0  1/2 EURO Pallet",
        Symbol = null,
        CommonCode = "XO3",
    };
    /// <summary>
    /// Oneway pallet with dimensions 80 X 120 cm.
    /// </summary>
    public static IUnit OnewayPalletISO11Per1EUROPallet = new Unit()
    {
        Name = "Oneway pallet ISO 1  1/1 EURO Pallet",
        Symbol = null,
        CommonCode = "XO4",
    };
    /// <summary>
    /// Oneway pallet with dimensions 100 X 120 cm.
    /// </summary>
    public static IUnit OnewayPalletISO22Per1EUROPallet = new Unit()
    {
        Name = "Oneway pallet ISO 2  2/1 EURO Pallet",
        Symbol = null,
        CommonCode = "XO5",
    };
    /// <summary>
    /// Pallet with non-standard dimensions
    /// </summary>
    public static IUnit PalletWithExceptionalDimensions = new Unit()
    {
        Name = "Pallet with exceptional dimensions",
        Symbol = null,
        CommonCode = "XO6",
    };
    /// <summary>
    /// Wooden pallet with dimensions 40 cm x 80 cm.
    /// </summary>
    public static IUnit WoodenPallet40CmX80Cm = new Unit()
    {
        Name = "Wooden pallet  40 cm x 80 cm",
        Symbol = null,
        CommonCode = "XO7",
    };
    /// <summary>
    /// SRS (Svenska Retursystem) standard synthetic pallet of dimensions 60 cm x 80 cm.
    /// </summary>
    public static IUnit PlasticPalletSRS60CmX80Cm = new Unit()
    {
        Name = "Plastic pallet SRS 60 cm x 80 cm",
        Symbol = null,
        CommonCode = "XO8",
    };
    /// <summary>
    /// SRS (Svenska Retursystem) standard synthetic pallet of dimensions 80 cm x 120 cm.
    /// </summary>
    public static IUnit PlasticPalletSRS80CmX120Cm = new Unit()
    {
        Name = "Plastic pallet SRS 80 cm x 120 cm",
        Symbol = null,
        CommonCode = "XO9",
    };
    /// <summary>
    /// Commonwealth Handling Equipment Pool (CHEP) standard pallet of dimensions 60 centimeters x 80 centimeters.
    /// </summary>
    public static IUnit CHEPPallet60CmX80Cm = new Unit()
    {
        Name = "CHEP pallet 60 cm x 80 cm",
        Symbol = null,
        CommonCode = "XP1",
    };
    /// <summary>
    /// LPR (La Pallet Rouge) standard pallet of dimensions 60 cm x 80 cm.
    /// </summary>
    public static IUnit LPRPallet60CmX80Cm = new Unit()
    {
        Name = "LPR pallet 60 cm x 80 cm",
        Symbol = null,
        CommonCode = "XP3",
    };
    /// <summary>
    /// LPR (La Pallet Rouge) standard pallet of dimensions 80 cm x 120 cm.
    /// </summary>
    public static IUnit LPRPallet80CmX120Cm = new Unit()
    {
        Name = "LPR pallet 80 cm x 120 cm",
        Symbol = null,
        CommonCode = "XP4",
    };
    /// <summary>
    /// A shallow, wide, open container, usually of metal.
    /// </summary>
    public static IUnit Pan = new Unit()
    {
        Name = "Pan",
        Symbol = null,
        CommonCode = "XP2",
    };
    /// <summary>
    /// Small package.
    /// </summary>
    public static IUnit Packet = new Unit()
    {
        Name = "Packet",
        Symbol = null,
        CommonCode = "XPA",
    };
    public static IUnit PalletBoxCombinedOpenendedBoxAndPallet = new Unit()
    {
        Name = "Pallet, box Combined openended box and pallet",
        Symbol = null,
        CommonCode = "XPB",
    };
    public static IUnit Parcel = new Unit()
    {
        Name = "Parcel",
        Symbol = null,
        CommonCode = "XPC",
    };
    /// <summary>
    /// Standard sized pallet of dimensions 80 centimeters by 100 centimeters (cms).
    /// </summary>
    public static IUnit PalletModularCollars80Cms100Cms = new Unit()
    {
        Name = "Pallet, modular, collars 80cms * 100cms",
        Symbol = null,
        CommonCode = "XPD",
    };
    /// <summary>
    /// Standard sized pallet of dimensions 80 centimeters by 120 centimeters (cms).
    /// </summary>
    public static IUnit PalletModularCollars80Cms120Cms = new Unit()
    {
        Name = "Pallet, modular, collars 80cms * 120cms",
        Symbol = null,
        CommonCode = "XPE",
    };
    /// <summary>
    /// A small open top enclosure for retaining animals.
    /// </summary>
    public static IUnit Pen = new Unit()
    {
        Name = "Pen",
        Symbol = null,
        CommonCode = "XPF",
    };
    public static IUnit Plate = new Unit()
    {
        Name = "Plate",
        Symbol = null,
        CommonCode = "XPG",
    };
    public static IUnit Pitcher = new Unit()
    {
        Name = "Pitcher",
        Symbol = null,
        CommonCode = "XPH",
    };
    public static IUnit Pipe = new Unit()
    {
        Name = "Pipe",
        Symbol = null,
        CommonCode = "XPI",
    };
    public static IUnit Punnet = new Unit()
    {
        Name = "Punnet",
        Symbol = null,
        CommonCode = "XPJ",
    };
    /// <summary>
    /// Standard packaging unit.
    /// </summary>
    public static IUnit Package = new Unit()
    {
        Name = "Package",
        Symbol = null,
        CommonCode = "XPK",
    };
    public static IUnit Pail = new Unit()
    {
        Name = "Pail",
        Symbol = null,
        CommonCode = "XPL",
    };
    public static IUnit Plank = new Unit()
    {
        Name = "Plank",
        Symbol = null,
        CommonCode = "XPN",
    };
    public static IUnit Pouch = new Unit()
    {
        Name = "Pouch",
        Symbol = null,
        CommonCode = "XPO",
    };
    /// <summary>
    /// Containment vessel made of plastic for retaining substances or articles.
    /// </summary>
    public static IUnit ReceptaclePlastic = new Unit()
    {
        Name = "Receptacle, plastic",
        Symbol = null,
        CommonCode = "XPR",
    };
    public static IUnit Pot = new Unit()
    {
        Name = "Pot",
        Symbol = null,
        CommonCode = "XPT",
    };
    public static IUnit Tray = new Unit()
    {
        Name = "Tray",
        Symbol = null,
        CommonCode = "XPU",
    };
    public static IUnit PipesInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Pipes, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XPV",
    };
    /// <summary>
    /// Platform or open-ended box, usually made of wood, on which goods are retained for ease of mechanical handling during transport and storage.
    /// </summary>
    public static IUnit Pallet = new Unit()
    {
        Name = "Pallet",
        Symbol = null,
        CommonCode = "XPX",
    };
    public static IUnit PlatesInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Plates, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XPY",
    };
    public static IUnit PlanksInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Planks, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XPZ",
    };
    public static IUnit DrumSteelNonremovableHead = new Unit()
    {
        Name = "Drum, steel, nonremovable head",
        Symbol = null,
        CommonCode = "XQA",
    };
    public static IUnit DrumSteelRemovableHead = new Unit()
    {
        Name = "Drum, steel, removable head",
        Symbol = null,
        CommonCode = "XQB",
    };
    public static IUnit DrumAluminiumNonremovableHead = new Unit()
    {
        Name = "Drum, aluminium, nonremovable head",
        Symbol = null,
        CommonCode = "XQC",
    };
    public static IUnit DrumAluminiumRemovableHead = new Unit()
    {
        Name = "Drum, aluminium, removable head",
        Symbol = null,
        CommonCode = "XQD",
    };
    public static IUnit DrumPlasticNonremovableHead = new Unit()
    {
        Name = "Drum, plastic, nonremovable head",
        Symbol = null,
        CommonCode = "XQF",
    };
    public static IUnit DrumPlasticRemovableHead = new Unit()
    {
        Name = "Drum, plastic, removable head",
        Symbol = null,
        CommonCode = "XQG",
    };
    public static IUnit BarrelWoodenBungType = new Unit()
    {
        Name = "Barrel, wooden, bung type",
        Symbol = null,
        CommonCode = "XQH",
    };
    public static IUnit BarrelWoodenRemovableHead = new Unit()
    {
        Name = "Barrel, wooden, removable head",
        Symbol = null,
        CommonCode = "XQJ",
    };
    public static IUnit JerricanSteelNonremovableHead = new Unit()
    {
        Name = "Jerrican, steel, nonremovable head",
        Symbol = null,
        CommonCode = "XQK",
    };
    public static IUnit JerricanSteelRemovableHead = new Unit()
    {
        Name = "Jerrican, steel, removable head",
        Symbol = null,
        CommonCode = "XQL",
    };
    public static IUnit JerricanPlasticNonremovableHead = new Unit()
    {
        Name = "Jerrican, plastic, nonremovable head",
        Symbol = null,
        CommonCode = "XQM",
    };
    public static IUnit JerricanPlasticRemovableHead = new Unit()
    {
        Name = "Jerrican, plastic, removable head",
        Symbol = null,
        CommonCode = "XQN",
    };
    public static IUnit BoxWoodenNaturalWoodOrdinary = new Unit()
    {
        Name = "Box, wooden, natural wood, ordinary",
        Symbol = null,
        CommonCode = "XQP",
    };
    public static IUnit BoxWoodenNaturalWoodWithSiftProofWalls = new Unit()
    {
        Name = "Box, wooden, natural wood, with sift proof walls",
        Symbol = null,
        CommonCode = "XQQ",
    };
    public static IUnit BoxPlasticExpanded = new Unit()
    {
        Name = "Box, plastic, expanded",
        Symbol = null,
        CommonCode = "XQR",
    };
    public static IUnit BoxPlasticSolid = new Unit()
    {
        Name = "Box, plastic, solid",
        Symbol = null,
        CommonCode = "XQS",
    };
    public static IUnit Rod = new Unit()
    {
        Name = "Rod",
        Symbol = null,
        CommonCode = "XRD",
    };
    public static IUnit Ring = new Unit()
    {
        Name = "Ring",
        Symbol = null,
        CommonCode = "XRG",
    };
    public static IUnit RackClothingHanger = new Unit()
    {
        Name = "Rack, clothing hanger",
        Symbol = null,
        CommonCode = "XRJ",
    };
    public static IUnit Rack = new Unit()
    {
        Name = "Rack",
        Symbol = null,
        CommonCode = "XRK",
    };
    /// <summary>
    /// Cylindrical rotatory device with a rim at each end on which materials are wound.
    /// </summary>
    public static IUnit Reel = new Unit()
    {
        Name = "Reel",
        Symbol = null,
        CommonCode = "XRL",
    };
    public static IUnit Roll = new Unit()
    {
        Name = "Roll",
        Symbol = null,
        CommonCode = "XRO",
    };
    /// <summary>
    /// Containment material made of red mesh netting for retaining articles (e.g. trees).
    /// </summary>
    public static IUnit Rednet = new Unit()
    {
        Name = "Rednet",
        Symbol = null,
        CommonCode = "XRT",
    };
    public static IUnit RodsInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Rods, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XRZ",
    };
    public static IUnit Sack = new Unit()
    {
        Name = "Sack",
        Symbol = null,
        CommonCode = "XSA",
    };
    public static IUnit Slab = new Unit()
    {
        Name = "Slab",
        Symbol = null,
        CommonCode = "XSB",
    };
    public static IUnit CrateShallow = new Unit()
    {
        Name = "Crate, shallow",
        Symbol = null,
        CommonCode = "XSC",
    };
    public static IUnit Spindle = new Unit()
    {
        Name = "Spindle",
        Symbol = null,
        CommonCode = "XSD",
    };
    public static IUnit Seachest = new Unit()
    {
        Name = "Seachest",
        Symbol = null,
        CommonCode = "XSE",
    };
    public static IUnit Sachet = new Unit()
    {
        Name = "Sachet",
        Symbol = null,
        CommonCode = "XSH",
    };
    /// <summary>
    /// A low movable platform or pallet to facilitate the handling and transport of goods.
    /// </summary>
    public static IUnit Skid = new Unit()
    {
        Name = "Skid",
        Symbol = null,
        CommonCode = "XSI",
    };
    public static IUnit CaseSkeleton = new Unit()
    {
        Name = "Case, skeleton",
        Symbol = null,
        CommonCode = "XSK",
    };
    /// <summary>
    /// Hard plastic sheeting primarily used as the base on which to stack goods to optimise the space within a container. May be used as an alternative to a palletized packaging.
    /// </summary>
    public static IUnit Slipsheet = new Unit()
    {
        Name = "Slipsheet",
        Symbol = null,
        CommonCode = "XSL",
    };
    public static IUnit Sheetmetal = new Unit()
    {
        Name = "Sheetmetal",
        Symbol = null,
        CommonCode = "XSM",
    };
    /// <summary>
    /// A packaging container used in the transport of such items as wire, cable, tape and yarn.
    /// </summary>
    public static IUnit Spool = new Unit()
    {
        Name = "Spool",
        Symbol = null,
        CommonCode = "XSO",
    };
    public static IUnit SheetPlasticWrapping = new Unit()
    {
        Name = "Sheet, plastic wrapping",
        Symbol = null,
        CommonCode = "XSP",
    };
    public static IUnit CaseSteel = new Unit()
    {
        Name = "Case, steel",
        Symbol = null,
        CommonCode = "XSS",
    };
    public static IUnit Sheet = new Unit()
    {
        Name = "Sheet",
        Symbol = null,
        CommonCode = "XST",
    };
    public static IUnit Suitcase = new Unit()
    {
        Name = "Suitcase",
        Symbol = null,
        CommonCode = "XSU",
    };
    public static IUnit EnvelopeSteel = new Unit()
    {
        Name = "Envelope, steel",
        Symbol = null,
        CommonCode = "XSV",
    };
    /// <summary>
    /// Goods retained in a transparent plastic film that has been wrapped around and then shrunk tightly on to the goods.
    /// </summary>
    public static IUnit Shrinkwrapped = new Unit()
    {
        Name = "Shrinkwrapped",
        Symbol = null,
        CommonCode = "XSW",
    };
    public static IUnit Sleeve = new Unit()
    {
        Name = "Sleeve",
        Symbol = null,
        CommonCode = "XSY",
    };
    public static IUnit SheetsInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Sheets, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XSZ",
    };
    public static IUnit Tub = new Unit()
    {
        Name = "Tub",
        Symbol = null,
        CommonCode = "XTB",
    };
    public static IUnit Teachest = new Unit()
    {
        Name = "Teachest",
        Symbol = null,
        CommonCode = "XTC",
    };
    public static IUnit TubeCollapsible = new Unit()
    {
        Name = "Tube, collapsible",
        Symbol = null,
        CommonCode = "XTD",
    };
    /// <summary>
    /// A specially constructed container for transporting liquids and gases in bulk.
    /// </summary>
    public static IUnit TankContainerGeneric = new Unit()
    {
        Name = "Tank container, generic",
        Symbol = null,
        CommonCode = "XTG",
    };
    public static IUnit Tierce = new Unit()
    {
        Name = "Tierce",
        Symbol = null,
        CommonCode = "XTI",
    };
    public static IUnit TankRectangular = new Unit()
    {
        Name = "Tank, rectangular",
        Symbol = null,
        CommonCode = "XTK",
    };
    public static IUnit TubWithLid = new Unit()
    {
        Name = "Tub, with lid",
        Symbol = null,
        CommonCode = "XTL",
    };
    public static IUnit Tin = new Unit()
    {
        Name = "Tin",
        Symbol = null,
        CommonCode = "XTN",
    };
    public static IUnit Tun = new Unit()
    {
        Name = "Tun",
        Symbol = null,
        CommonCode = "XTO",
    };
    public static IUnit Trunk = new Unit()
    {
        Name = "Trunk",
        Symbol = null,
        CommonCode = "XTR",
    };
    public static IUnit Truss = new Unit()
    {
        Name = "Truss",
        Symbol = null,
        CommonCode = "XTS",
    };
    /// <summary>
    /// A capacious bag or basket.
    /// </summary>
    public static IUnit BagTote = new Unit()
    {
        Name = "Bag, tote",
        Symbol = null,
        CommonCode = "XTT",
    };
    public static IUnit Tube = new Unit()
    {
        Name = "Tube",
        Symbol = null,
        CommonCode = "XTU",
    };
    /// <summary>
    /// A tube made of plastic, metal or cardboard fitted with a nozzle, containing a liquid or semi-liquid product, e.g. silicon.
    /// </summary>
    public static IUnit TubeWithNozzle = new Unit()
    {
        Name = "Tube, with nozzle",
        Symbol = null,
        CommonCode = "XTV",
    };
    /// <summary>
    /// A lightweight pallet made from heavy duty corrugated board.
    /// </summary>
    public static IUnit PalletTriwall = new Unit()
    {
        Name = "Pallet, triwall",
        Symbol = null,
        CommonCode = "XTW",
    };
    public static IUnit TankCylindrical = new Unit()
    {
        Name = "Tank, cylindrical",
        Symbol = null,
        CommonCode = "XTY",
    };
    public static IUnit TubesInBundlePerBunchPerTruss = new Unit()
    {
        Name = "Tubes, in bundle/bunch/truss",
        Symbol = null,
        CommonCode = "XTZ",
    };
    public static IUnit Uncaged = new Unit()
    {
        Name = "Uncaged",
        Symbol = null,
        CommonCode = "XUC",
    };
    /// <summary>
    /// A type of package composed of a single item or object, not otherwise specified as a unit of transport equipment.
    /// </summary>
    public static IUnit UnitUnece = new Unit()
    {
        Name = "Unit",
        Symbol = null,
        CommonCode = "XUN",
    };
    public static IUnit Vat = new Unit()
    {
        Name = "Vat",
        Symbol = null,
        CommonCode = "XVA",
    };
    public static IUnit BulkGasAt1031MbarAnd15C = new Unit()
    {
        Name = "Bulk, gas (at 1031 mbar and 15°C)",
        Symbol = null,
        CommonCode = "XVG",
    };
    public static IUnit Vial = new Unit()
    {
        Name = "Vial",
        Symbol = null,
        CommonCode = "XVI",
    };
    /// <summary>
    /// A type of wooden crate.
    /// </summary>
    public static IUnit Vanpack = new Unit()
    {
        Name = "Vanpack",
        Symbol = null,
        CommonCode = "XVK",
    };
    public static IUnit BulkLiquid = new Unit()
    {
        Name = "Bulk, liquid",
        Symbol = null,
        CommonCode = "XVL",
    };
    public static IUnit BulkSolidLargeParticlesNodules = new Unit()
    {
        Name = "Bulk, solid, large particles (“nodules”)",
        Symbol = null,
        CommonCode = "XVO",
    };
    public static IUnit Vacuumpacked = new Unit()
    {
        Name = "Vacuumpacked",
        Symbol = null,
        CommonCode = "XVP",
    };
    public static IUnit BulkLiquefiedGasAtAbnormalTemperaturePerPressure = new Unit()
    {
        Name = "Bulk, liquefied gas (at abnormal temperature/pressure)",
        Symbol = null,
        CommonCode = "XVQ",
    };
    /// <summary>
    /// A self-propelled means of conveyance.
    /// </summary>
    public static IUnit Vehicle = new Unit()
    {
        Name = "Vehicle",
        Symbol = null,
        CommonCode = "XVN",
    };
    public static IUnit BulkSolidGranularParticlesGrains = new Unit()
    {
        Name = "Bulk, solid, granular particles (“grains”)",
        Symbol = null,
        CommonCode = "XVR",
    };
    /// <summary>
    /// Loose or unpacked scrap metal transported in bulk form.
    /// </summary>
    public static IUnit BulkScrapMetal = new Unit()
    {
        Name = "Bulk, scrap metal",
        Symbol = null,
        CommonCode = "XVS",
    };
    public static IUnit BulkSolidFineParticlesPowders = new Unit()
    {
        Name = "Bulk, solid, fine particles (“powders”)",
        Symbol = null,
        CommonCode = "XVY",
    };
    /// <summary>
    /// A reusable container made of metal, plastic, textile, wood or composite materials used to facilitate transportation of bulk solids and liquids in manageable volumes.
    /// </summary>
    public static IUnit IntermediateBulkContainer = new Unit()
    {
        Name = "Intermediate bulk container",
        Symbol = null,
        CommonCode = "XWA",
    };
    public static IUnit Wickerbottle = new Unit()
    {
        Name = "Wickerbottle",
        Symbol = null,
        CommonCode = "XWB",
    };
    public static IUnit IntermediateBulkContainerSteel = new Unit()
    {
        Name = "Intermediate bulk container, steel",
        Symbol = null,
        CommonCode = "XWC",
    };
    public static IUnit IntermediateBulkContainerAluminium = new Unit()
    {
        Name = "Intermediate bulk container, aluminium",
        Symbol = null,
        CommonCode = "XWD",
    };
    public static IUnit IntermediateBulkContainerMetal = new Unit()
    {
        Name = "Intermediate bulk container, metal",
        Symbol = null,
        CommonCode = "XWF",
    };
    public static IUnit IntermediateBulkContainerSteelPressurised10Kpa = new Unit()
    {
        Name = "Intermediate bulk container, steel, pressurised > 10 kpa",
        Symbol = null,
        CommonCode = "XWG",
    };
    public static IUnit IntermediateBulkContainerAluminiumPressurised10Kpa = new Unit()
    {
        Name = "Intermediate bulk container, aluminium, pressurised > 10 kpa",
        Symbol = null,
        CommonCode = "XWH",
    };
    public static IUnit IntermediateBulkContainerMetalPressure10Kpa = new Unit()
    {
        Name = "Intermediate bulk container, metal, pressure 10 kpa",
        Symbol = null,
        CommonCode = "XWJ",
    };
    public static IUnit IntermediateBulkContainerSteelLiquid = new Unit()
    {
        Name = "Intermediate bulk container, steel, liquid",
        Symbol = null,
        CommonCode = "XWK",
    };
    public static IUnit IntermediateBulkContainerAluminiumLiquid = new Unit()
    {
        Name = "Intermediate bulk container, aluminium, liquid",
        Symbol = null,
        CommonCode = "XWL",
    };
    public static IUnit IntermediateBulkContainerMetalLiquid = new Unit()
    {
        Name = "Intermediate bulk container, metal, liquid",
        Symbol = null,
        CommonCode = "XWM",
    };
    public static IUnit IntermediateBulkContainerWovenPlasticWithoutCoatPerLiner = new Unit()
    {
        Name = "Intermediate bulk container, woven plastic, without coat/liner",
        Symbol = null,
        CommonCode = "XWN",
    };
    public static IUnit IntermediateBulkContainerWovenPlasticCoated = new Unit()
    {
        Name = "Intermediate bulk container, woven plastic, coated",
        Symbol = null,
        CommonCode = "XWP",
    };
    public static IUnit IntermediateBulkContainerWovenPlasticWithLiner = new Unit()
    {
        Name = "Intermediate bulk container, woven plastic, with liner",
        Symbol = null,
        CommonCode = "XWQ",
    };
    public static IUnit IntermediateBulkContainerWovenPlasticCoatedAndLiner = new Unit()
    {
        Name = "Intermediate bulk container, woven plastic, coated and liner",
        Symbol = null,
        CommonCode = "XWR",
    };
    public static IUnit IntermediateBulkContainerPlasticFilm = new Unit()
    {
        Name = "Intermediate bulk container, plastic film",
        Symbol = null,
        CommonCode = "XWS",
    };
    public static IUnit IntermediateBulkContainerTextileWithOutCoatPerLiner = new Unit()
    {
        Name = "Intermediate bulk container, textile with out coat/liner",
        Symbol = null,
        CommonCode = "XWT",
    };
    public static IUnit IntermediateBulkContainerNaturalWoodWithInnerLiner = new Unit()
    {
        Name = "Intermediate bulk container, natural wood, with inner liner",
        Symbol = null,
        CommonCode = "XWU",
    };
    public static IUnit IntermediateBulkContainerTextileCoated = new Unit()
    {
        Name = "Intermediate bulk container, textile, coated",
        Symbol = null,
        CommonCode = "XWV",
    };
    public static IUnit IntermediateBulkContainerTextileWithLiner = new Unit()
    {
        Name = "Intermediate bulk container, textile, with liner",
        Symbol = null,
        CommonCode = "XWW",
    };
    public static IUnit IntermediateBulkContainerTextileCoatedAndLiner = new Unit()
    {
        Name = "Intermediate bulk container, textile, coated and liner",
        Symbol = null,
        CommonCode = "XWX",
    };
    public static IUnit IntermediateBulkContainerPlywoodWithInnerLiner = new Unit()
    {
        Name = "Intermediate bulk container, plywood, with inner liner",
        Symbol = null,
        CommonCode = "XWY",
    };
    public static IUnit IntermediateBulkContainerReconstitutedWoodWithInnerLiner = new Unit()
    {
        Name = "Intermediate bulk container, reconstituted wood, with inner liner",
        Symbol = null,
        CommonCode = "XWZ",
    };
    public static IUnit BagWovenPlasticWithoutInnerCoatPerLiner = new Unit()
    {
        Name = "Bag, woven plastic, without inner coat/liner",
        Symbol = null,
        CommonCode = "XXA",
    };
    public static IUnit BagWovenPlasticSiftProof = new Unit()
    {
        Name = "Bag, woven plastic, sift proof",
        Symbol = null,
        CommonCode = "XXB",
    };
    public static IUnit BagWovenPlasticWaterResistant = new Unit()
    {
        Name = "Bag, woven plastic, water resistant",
        Symbol = null,
        CommonCode = "XXC",
    };
    public static IUnit BagPlasticsFilm = new Unit()
    {
        Name = "Bag, plastics film",
        Symbol = null,
        CommonCode = "XXD",
    };
    public static IUnit BagTextileWithoutInnerCoatPerLiner = new Unit()
    {
        Name = "Bag, textile, without inner coat/liner",
        Symbol = null,
        CommonCode = "XXF",
    };
    public static IUnit BagTextileSiftProof = new Unit()
    {
        Name = "Bag, textile, sift proof",
        Symbol = null,
        CommonCode = "XXG",
    };
    public static IUnit BagTextileWaterResistant = new Unit()
    {
        Name = "Bag, textile, water resistant",
        Symbol = null,
        CommonCode = "XXH",
    };
    public static IUnit BagPaperMultiwall = new Unit()
    {
        Name = "Bag, paper, multiwall",
        Symbol = null,
        CommonCode = "XXJ",
    };
    public static IUnit BagPaperMultiwallWaterResistant = new Unit()
    {
        Name = "Bag, paper, multiwall, water resistant",
        Symbol = null,
        CommonCode = "XXK",
    };
    public static IUnit CompositePackagingPlasticReceptacleInSteelDrum = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in steel drum",
        Symbol = null,
        CommonCode = "XYA",
    };
    public static IUnit CompositePackagingPlasticReceptacleInSteelCrateBox = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in steel crate box",
        Symbol = null,
        CommonCode = "XYB",
    };
    public static IUnit CompositePackagingPlasticReceptacleInAluminiumDrum = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in aluminium drum",
        Symbol = null,
        CommonCode = "XYC",
    };
    public static IUnit CompositePackagingPlasticReceptacleInAluminiumCrate = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in aluminium crate",
        Symbol = null,
        CommonCode = "XYD",
    };
    public static IUnit CompositePackagingPlasticReceptacleInWoodenBox = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in wooden box",
        Symbol = null,
        CommonCode = "XYF",
    };
    public static IUnit CompositePackagingPlasticReceptacleInPlywoodDrum = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in plywood drum",
        Symbol = null,
        CommonCode = "XYG",
    };
    public static IUnit CompositePackagingPlasticReceptacleInPlywoodBox = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in plywood box",
        Symbol = null,
        CommonCode = "XYH",
    };
    public static IUnit CompositePackagingPlasticReceptacleInFibreDrum = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in fibre drum",
        Symbol = null,
        CommonCode = "XYJ",
    };
    public static IUnit CompositePackagingPlasticReceptacleInFibreboardBox = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in fibreboard box",
        Symbol = null,
        CommonCode = "XYK",
    };
    public static IUnit CompositePackagingPlasticReceptacleInPlasticDrum = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in plastic drum",
        Symbol = null,
        CommonCode = "XYL",
    };
    public static IUnit CompositePackagingPlasticReceptacleInSolidPlasticBox = new Unit()
    {
        Name = "Composite packaging, plastic receptacle in solid plastic box",
        Symbol = null,
        CommonCode = "XYM",
    };
    public static IUnit CompositePackagingGlassReceptacleInSteelDrum = new Unit()
    {
        Name = "Composite packaging, glass receptacle in steel drum",
        Symbol = null,
        CommonCode = "XYN",
    };
    public static IUnit CompositePackagingGlassReceptacleInSteelCrateBox = new Unit()
    {
        Name = "Composite packaging, glass receptacle in steel crate box",
        Symbol = null,
        CommonCode = "XYP",
    };
    public static IUnit CompositePackagingGlassReceptacleInAluminiumDrum = new Unit()
    {
        Name = "Composite packaging, glass receptacle in aluminium drum",
        Symbol = null,
        CommonCode = "XYQ",
    };
    public static IUnit CompositePackagingGlassReceptacleInAluminiumCrate = new Unit()
    {
        Name = "Composite packaging, glass receptacle in aluminium crate",
        Symbol = null,
        CommonCode = "XYR",
    };
    public static IUnit CompositePackagingGlassReceptacleInWoodenBox = new Unit()
    {
        Name = "Composite packaging, glass receptacle in wooden box",
        Symbol = null,
        CommonCode = "XYS",
    };
    public static IUnit CompositePackagingGlassReceptacleInPlywoodDrum = new Unit()
    {
        Name = "Composite packaging, glass receptacle in plywood drum",
        Symbol = null,
        CommonCode = "XYT",
    };
    public static IUnit CompositePackagingGlassReceptacleInWickerworkHamper = new Unit()
    {
        Name = "Composite packaging, glass receptacle in wickerwork hamper",
        Symbol = null,
        CommonCode = "XYV",
    };
    public static IUnit CompositePackagingGlassReceptacleInFibreDrum = new Unit()
    {
        Name = "Composite packaging, glass receptacle in fibre drum",
        Symbol = null,
        CommonCode = "XYW",
    };
    public static IUnit CompositePackagingGlassReceptacleInFibreboardBox = new Unit()
    {
        Name = "Composite packaging, glass receptacle in fibreboard box",
        Symbol = null,
        CommonCode = "XYX",
    };
    public static IUnit CompositePackagingGlassReceptacleInExpandablePlasticPack = new Unit()
    {
        Name = "Composite packaging, glass receptacle in expandable plastic pack",
        Symbol = null,
        CommonCode = "XYY",
    };
    public static IUnit CompositePackagingGlassReceptacleInSolidPlasticPack = new Unit()
    {
        Name = "Composite packaging, glass receptacle in solid plastic pack",
        Symbol = null,
        CommonCode = "XYZ",
    };
    public static IUnit IntermediateBulkContainerPaperMultiwall = new Unit()
    {
        Name = "Intermediate bulk container, paper, multiwall",
        Symbol = null,
        CommonCode = "XZA",
    };
    public static IUnit BagLarge = new Unit()
    {
        Name = "Bag, large",
        Symbol = null,
        CommonCode = "XZB",
    };
    public static IUnit IntermediateBulkContainerPaperMultiwallWaterResistant = new Unit()
    {
        Name = "Intermediate bulk container, paper, multiwall, water resistant",
        Symbol = null,
        CommonCode = "XZC",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticWithStructuralEquipmentSolids = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, with structural equipment, solids",
        Symbol = null,
        CommonCode = "XZD",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticFreestandingSolids = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, freestanding, solids",
        Symbol = null,
        CommonCode = "XZF",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticWithStructuralEquipmentPressurised = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, with structural equipment, pressurised",
        Symbol = null,
        CommonCode = "XZG",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticFreestandingPressurised = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, freestanding, pressurised",
        Symbol = null,
        CommonCode = "XZH",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticWithStructuralEquipmentLiquids = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, with structural equipment, liquids",
        Symbol = null,
        CommonCode = "XZJ",
    };
    public static IUnit IntermediateBulkContainerRigidPlasticFreestandingLiquids = new Unit()
    {
        Name = "Intermediate bulk container, rigid plastic, freestanding, liquids",
        Symbol = null,
        CommonCode = "XZK",
    };
    public static IUnit IntermediateBulkContainerCompositeRigidPlasticSolids = new Unit()
    {
        Name = "Intermediate bulk container, composite, rigid plastic, solids",
        Symbol = null,
        CommonCode = "XZL",
    };
    public static IUnit IntermediateBulkContainerCompositeFlexiblePlasticSolids = new Unit()
    {
        Name = "Intermediate bulk container, composite, flexible plastic, solids",
        Symbol = null,
        CommonCode = "XZM",
    };
    public static IUnit IntermediateBulkContainerCompositeRigidPlasticPressurised = new Unit()
    {
        Name = "Intermediate bulk container, composite, rigid plastic, pressurised",
        Symbol = null,
        CommonCode = "XZN",
    };
    public static IUnit IntermediateBulkContainerCompositeFlexiblePlasticPressurised = new Unit()
    {
        Name = "Intermediate bulk container, composite, flexible plastic, pressurised",
        Symbol = null,
        CommonCode = "XZP",
    };
    public static IUnit IntermediateBulkContainerCompositeRigidPlasticLiquids = new Unit()
    {
        Name = "Intermediate bulk container, composite, rigid plastic, liquids",
        Symbol = null,
        CommonCode = "XZQ",
    };
    public static IUnit IntermediateBulkContainerCompositeFlexiblePlasticLiquids = new Unit()
    {
        Name = "Intermediate bulk container, composite, flexible plastic, liquids",
        Symbol = null,
        CommonCode = "XZR",
    };
    public static IUnit IntermediateBulkContainerComposite = new Unit()
    {
        Name = "Intermediate bulk container, composite",
        Symbol = null,
        CommonCode = "XZS",
    };
    public static IUnit IntermediateBulkContainerFibreboard = new Unit()
    {
        Name = "Intermediate bulk container, fibreboard",
        Symbol = null,
        CommonCode = "XZT",
    };
    public static IUnit IntermediateBulkContainerFlexible = new Unit()
    {
        Name = "Intermediate bulk container, flexible",
        Symbol = null,
        CommonCode = "XZU",
    };
    public static IUnit IntermediateBulkContainerMetalOtherThanSteel = new Unit()
    {
        Name = "Intermediate bulk container, metal, other than steel",
        Symbol = null,
        CommonCode = "XZV",
    };
    public static IUnit IntermediateBulkContainerNaturalWood = new Unit()
    {
        Name = "Intermediate bulk container, natural wood",
        Symbol = null,
        CommonCode = "XZW",
    };
    public static IUnit IntermediateBulkContainerPlywood = new Unit()
    {
        Name = "Intermediate bulk container, plywood",
        Symbol = null,
        CommonCode = "XZX",
    };
    public static IUnit IntermediateBulkContainerReconstitutedWood = new Unit()
    {
        Name = "Intermediate bulk container, reconstituted wood",
        Symbol = null,
        CommonCode = "XZY",
    };
#endregion
}