using System.Collections.Generic;
using System.Linq;
using EDEngineer.Models;

namespace EDEngineer.Utils
{
    public class ItemNameConverter
    {
        public static readonly Dictionary<string, Rarity> Rarities = new Dictionary<string, Rarity>
        {
            {"Aberrant Shield Pattern Analysis", Rarity.Rare},
            {"Abnormal Compact Emission Data", Rarity.VeryRare},
            {"Adaptive Encryptors Capture", Rarity.VeryRare},
            {"Anomalous Bulk Scan Data", Rarity.VeryCommon},
            {"Anomalous FSD Telemetry", Rarity.Common},
            {"Antimony", Rarity.VeryRare},
            {"Arsenic", Rarity.Standard},
            {"Articulation Motors", Rarity.Standard},
            {"Atypical Disrupted Wake Echoes", Rarity.VeryCommon},
            {"Atypical Encryption Archives", Rarity.Rare},
            {"Basic Conductors", Rarity.VeryCommon},
            {"Biotech Conductors", Rarity.VeryRare},
            {"Bromellite", Rarity.Standard},
            {"Cadmium", Rarity.Rare},
            {"Carbon", Rarity.VeryCommon},
            {"Chemical Distillery", Rarity.Standard},
            {"Chemical Manipulators", Rarity.Rare},
            {"Chemical Processors", Rarity.Common},
            {"Chemical Storage Units", Rarity.VeryCommon},
            {"Chromium", Rarity.Common},
            {"Classified Scan Databanks", Rarity.Standard},
            {"Classified Scan Fragment", Rarity.VeryRare},
            {"CMM Composite", Rarity.Standard},
            {"Compact Composites", Rarity.VeryCommon},
            {"Compound Shielding", Rarity.Rare},
            {"Conductive Ceramics", Rarity.Standard},
            {"Conductive Components", Rarity.Common},
            {"Conductive Polymers", Rarity.Rare},
            {"Configurable Components", Rarity.Rare},
            {"Core Dynamics Composites", Rarity.VeryRare},
            {"Cracked Industrial Firmware", Rarity.Standard},
            {"Crystal Shards", Rarity.VeryCommon},
            {"Datamined Wake Exceptions", Rarity.VeryRare},
            {"Decoded Emission Data", Rarity.Rare},
            {"Distorted Shield Cycle Recordings", Rarity.VeryCommon},
            {"Divergent Scan Data", Rarity.Rare},
            {"Eccentric Hyperspace Trajectories", Rarity.Rare},
            {"Electrochemical Arrays", Rarity.Standard},
            {"Emergency Power Cells", Rarity.Standard},
            {"Energy Grid Assembly", Rarity.Standard},
            {"Exceptional Scrambled Emission Data", Rarity.VeryCommon},
            {"Exhaust Manifold", Rarity.Standard},
            {"Exquisite Focus Crystals", Rarity.VeryRare},
            {"Filament Composites", Rarity.Common},
            {"Flawed Focus Crystals", Rarity.Common},
            {"Focus Crystals", Rarity.Standard},
            {"Galvanising Alloys", Rarity.Common},
            {"Germanium", Rarity.Common},
            {"Grid Resistors", Rarity.VeryCommon},
            {"Hardware Diagnostic Sensor", Rarity.Standard},
            {"Heat Conduction Wiring", Rarity.VeryCommon},
            {"Heat Dispersion Plate", Rarity.Common},
            {"Heat Exchangers", Rarity.Standard},
            {"Heat Resistant Ceramics", Rarity.Common},
            {"Heat Vanes", Rarity.Rare},
            {"Heatsink Interlink", Rarity.Standard},
            {"High Density Composites", Rarity.Standard},
            {"HN Shock Mount", Rarity.Standard},
            {"Hybrid Capacitors", Rarity.Common},
            {"Imperial Shielding", Rarity.VeryRare},
            {"Improvised Components", Rarity.VeryRare},
            {"Inconsistent Shield Soak Analysis", Rarity.Common},
            {"Insulating Membrane", Rarity.Standard},
            {"Ion Distributor", Rarity.Standard},
            {"Iron", Rarity.VeryCommon},
            {"Irregular Emission Data", Rarity.Common},
            {"Magnetic Emitter Coil", Rarity.Standard},
            {"Manganese", Rarity.Common},
            {"Mechanical Components", Rarity.Standard},
            {"Mechanical Equipment", Rarity.Common},
            {"Mechanical Scrap", Rarity.VeryCommon},
            {"Mercury", Rarity.Rare},
            {"Micro Controllers", Rarity.Rare},
            {"Micro-Weave Cooling Hoses", Rarity.Standard},
            {"Military Grade Alloys", Rarity.VeryRare},
            {"Military Supercapacitors", Rarity.VeryRare},
            {"Modified Consumer Firmware", Rarity.Common},
            {"Modified Embedded Firmware", Rarity.VeryRare},
            {"Modular Terminals", Rarity.Standard},
            {"Molybdenum", Rarity.Standard},
            {"Nanobreakers", Rarity.Standard},
            {"Neofabric Insulation", Rarity.Standard},
            {"Nickel", Rarity.VeryCommon},
            {"Niobium", Rarity.Standard},
            {"Open Symmetric Keys", Rarity.Standard},
            {"Osmium", Rarity.Standard},
            {"Peculiar Shield Frequency Data", Rarity.VeryRare},
            {"Pharmaceutical Isolators", Rarity.VeryRare},
            {"Phase Alloys", Rarity.Standard},
            {"Phosphorus", Rarity.VeryCommon},
            {"Platinum", Rarity.Standard},
            {"Polonium", Rarity.VeryRare},
            {"Polymer Capacitors", Rarity.Rare},
            {"Power Converter", Rarity.Standard},
            {"Power Transfer Bus", Rarity.Standard},
            {"Praseodymium", Rarity.Standard},
            {"Precipitated Alloys", Rarity.Standard},
            {"Proprietary Composites", Rarity.Rare},
            {"Proto Heat Radiators", Rarity.VeryRare},
            {"Proto Light Alloys", Rarity.Rare},
            {"Proto Radiolic Alloys", Rarity.VeryRare},
            {"Radiation Baffle", Rarity.Standard},
            {"Refined Focus Crystals", Rarity.Rare},
            {"Reinforced Mounting Plate", Rarity.Standard},
            {"Ruthenium", Rarity.VeryRare},
            {"Salvaged Alloys", Rarity.VeryCommon},
            {"Samarium", Rarity.Standard},
            {"Security Firmware Patch", Rarity.Rare},
            {"Selenium", Rarity.Standard},
            {"Shield Emitters", Rarity.Common},
            {"Shielding Sensors", Rarity.Standard},
            {"Specialised Legacy Firmware", Rarity.VeryCommon},
            {"Strange Wake Solutions", Rarity.Standard},
            {"Sulphur", Rarity.VeryCommon},
            {"Tagged Encryption Codes", Rarity.Common},
            {"Technetium", Rarity.VeryRare},
            {"Telemetry Suite", Rarity.Standard},
            {"Tellurium", Rarity.VeryRare},
            {"Tempered Alloys", Rarity.VeryCommon},
            {"Thermic Alloys", Rarity.Rare},
            {"Tin", Rarity.Rare},
            {"Tungsten", Rarity.Standard},
            {"Unexpected Emission Data", Rarity.Standard},
            {"Unidentified Scan Archives", Rarity.Common},
            {"Unknown Fragment", Rarity.VeryRare},
            {"Untypical Shield Scans", Rarity.Standard},
            {"Unusual Encrypted Files", Rarity.VeryCommon},
            {"Vanadium", Rarity.Common},
            {"Worn Shield Emitters", Rarity.VeryCommon},
            {"Yttrium", Rarity.VeryRare},
            {"Zinc", Rarity.Common},
            {"Zirconium", Rarity.Standard}
        };

        public static string[] MaterialNames { get; } =
            {
                // materials
                "Antimony",
                "Arsenic",
                "Basic Conductors",
                "Biotech Conductors",
                "Cadmium",
                "Carbon",
                "Chemical Distillery",
                "Chemical Manipulators",
                "Chemical Processors",
                "Chemical Storage Units",
                "Chromium",
                "Compact Composites",
                "Compound Shielding",
                "Conductive Ceramics",
                "Conductive Components",
                "Conductive Polymers",
                "Configurable Components",
                "Core Dynamics Composites",
                "Crystal Shards",
                "Electrochemical Arrays",
                "Exquisite Focus Crystals",
                "Filament Composites",
                "Flawed Focus Crystals",
                "Focus Crystals",
                "Galvanising Alloys",
                "Germanium",
                "Grid Resistors",
                "Heat Conduction Wiring",
                "Heat Dispersion Plate",
                "Heat Exchangers",
                "Heat Resistant Ceramics",
                "Heat Vanes",
                "High Density Composites",
                "Hybrid Capacitors",
                "Imperial Shielding",
                "Improvised Components",
                "Iron",
                "Manganese",
                "Mechanical Components",
                "Mechanical Equipment",
                "Mechanical Scrap",
                "Mercury",
                "Military Grade Alloys",
                "Military Supercapacitors",
                "Molybdenum",
                "Nickel",
                "Niobium",
                "Pharmaceutical Isolators",
                "Phase Alloys",
                "Phosphorus",
                "Polonium",
                "Polymer Capacitors",
                "Precipitated Alloys",
                "Proprietary Composites",
                "Proto Heat Radiators",
                "Proto Light Alloys",
                "Proto Radiolic Alloys",
                "Refined Focus Crystals",
                "Ruthenium",
                "Salvaged Alloys",
                "Selenium",
                "Shield Emitters",
                "Shielding Sensors",
                "Sulphur",
                "Technetium",
                "Tellurium",
                "Tempered Alloys",
                "Thermic Alloys",
                "Tin",
                "Tungsten",
                "Unknown Fragment",
                "Vanadium",
                "Worn Shield Emitters",
                "Yttrium",
                "Zinc",
                "Zirconium"
            };

        public static string[] DataNames { get; } =
            {
                // data
                "Aberrant Shield Pattern Analysis",
                "Abnormal Compact Emission Data",
                "Adaptive Encryptors Capture",
                "Anomalous Bulk Scan Data",
                "Anomalous FSD Telemetry",
                "Atypical Disrupted Wake Echoes",
                "Atypical Encryption Archives",
                "Classified Scan Databanks",
                "Classified Scan Fragment",
                "Cracked Industrial Firmware",
                "Datamined Wake Exceptions",
                "Decoded Emission Data",
                "Distorted Shield Cycle Recordings",
                "Divergent Scan Data",
                "Eccentric Hyperspace Trajectories",
                "Exceptional Scrambled Emission Data",
                "Inconsistent Shield Soak Analysis",
                "Irregular Emission Data",
                "Modified Consumer Firmware",
                "Modified Embedded Firmware",
                "Open Symmetric Keys",
                "Pattern Obelisk Data",
                "Peculiar Shield Frequency Data",
                "Security Firmware Patch",
                "Specialised Legacy Firmware",
                "Strange Wake Solutions",
                "Tagged Encryption Codes",
                "Unexpected Emission Data",
                "Unidentified Scan Archives",
                "Untypical Shield Scans",
                "Unusual Encrypted Files"
            };

        public static string[] CommodityNames { get; } =
            {
                "Articulation Motors",
                "Bromellite",
                "CMM Composite",
                "Emergency Power Cells",
                "Energy Grid Assembly",
                "Exhaust Manifold",
                "Hardware Diagnostic Sensor",
                "Heatsink Interlink",
                "HN Shock Mount",
                "Insulating Membrane",
                "Ion Distributor",
                "Magnetic Emitter Coil",
                "Micro Controllers",
                "Micro-Weave Cooling Hoses",
                "Modular Terminals",
                "Nanobreakers",
                "Neofabric Insulation",
                "Osmium",
                "Platinum",
                "Power Converter",
                "Power Transfer Bus",
                "Praseodymium",
                "Radiation Baffle",
                "Reinforced Mounting Plate",
                "Samarium",
                "Telemetry Suite"
            };

        public static IEnumerable<string> Names { get; } = MaterialNames.Concat(DataNames).Concat(CommodityNames);

        public static bool TryGet(string key, out string name)
        {
            if (key == "shielddensityreports")
            {
                name = "Untypical Shield Scans";
                return true;
            }

            if (key == "encodedscandata")
            {
                name = "Divergent Scan Data";
                return true;
            }

            if (key == "ancienthistoricaldata")
            {
                name = "Pattern Obelisk Data";
                return true;
            }

            if (key == "archivedemissiondata")
            {
                name = "Irregular Emission Data";
                return true;
            }

            if (key == "compactemissionsdata")
            {
                name = "Abnormal Compact Emission Data";
                return true;
            }

            var formattedKey = key.ToLowerInvariant();
            name = Names.FirstOrDefault(n => n.ToLowerInvariant() == formattedKey) ?? Names.FirstOrDefault(n => n.ToLowerInvariant().Replace(" ", "").Contains(formattedKey));

            return name != null;
        }
    }
}