using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Maddalena
{
    public enum AdministrativeRegionCode
    {
        CA_ON,
        CA_QC,
        CA_NS,
        CA_NB,
        CA_MB,
        CA_BC,
        CA_PE,
        CA_SK,
        CA_AB,
        CA_NL,
        CA_NT,
        CA_YT,
        CA_NU,
        US_AL,
        US_AK,
        US_AZ,
        US_AR,
        US_CA,
        US_CO,
        US_CT,
        US_DE,
        US_FL,
        US_GA,
        US_HI,
        US_ID,
        US_IL,
        US_IN,
        US_IA,
        US_KS,
        US_KY,
        US_LA,
        US_ME,
        US_MD,
        US_MA,
        US_MI,
        US_MN,
        US_MS,
        US_MO,
        US_MT,
        US_NE,
        US_NV,
        US_NH,
        US_NJ,
        US_NM,
        US_NY,
        US_NC,
        US_ND,
        US_OH,
        US_OK,
        US_OR,
        US_PA,
        US_RI,
        US_SC,
        US_SD,
        US_TN,
        US_TX,
        US_UT,
        US_VT,
        US_VA,
        US_WA,
        US_WV,
        US_WI,
        US_WY,
        US_DC,
        US_AS,
        US_GU,
        US_MP,
        US_PR,
        US_UM,
        US_VI
    }

    public partial class AdministrativeRegion
    {
        public string CommonName { get; private set; }
        public string OfficialName { get; private set; }
        public AdministrativeRegionCode AdministrativeRegionCode { get; private set; }
        public string AdministrativeRegionShortCode
        {
            get
            {
                var name = AdministrativeRegionCode.ToString();
                return name.Contains('_') ? name.Substring(name.IndexOf('_') + 1) : name;
            }
        }
        public string Capital { get; private set; }
        public string[] AlternativeSpellings { get; private set; }
        public double Area { get; private set; }

        public override bool Equals(object obj)
        {
            var item = obj as AdministrativeRegion;

            if (item == null) return false;

            return this.AdministrativeRegionCode == item.AdministrativeRegionCode;
        }

        public override int GetHashCode()
        {
            return (int)this.AdministrativeRegionCode;
        }

        public override string ToString()
        {
            return CommonName;
        }

        public static AdministrativeRegion Parse(string value)
        {
            AdministrativeRegionCode code;
            if (Enum.TryParse(value, true, out code)) return FromCode(code);

            return null;
        }

        public static AdministrativeRegion FromCode(AdministrativeRegionCode cc)
        {
            return All.FirstOrDefault(x => x.AdministrativeRegionCode == cc);
        }

        public static IEnumerable<AdministrativeRegion> All
        {
            get
            {
                foreach (var k in typeof(AdministrativeRegion).GetRuntimeProperties().Where(x => x.PropertyType == typeof(AdministrativeRegion)))
                {
                    yield return k.GetValue(null) as AdministrativeRegion;
                }
            }
        }

        public static AdministrativeRegion Ontario
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Ontario",
                    OfficialName = "Province of Ontario",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_ON,
                    Capital = "Toronto",
                    AlternativeSpellings = new[] { "ON" },
                    Area = 1076395
                };
            }
        }

        public static AdministrativeRegion Quebec
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Québec",
                    OfficialName = "Province of Québec",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_QC,
                    Capital = "Quebec City",
                    AlternativeSpellings = new[] { "QC" },
                    Area = 1542056
                };
            }
        }

        public static AdministrativeRegion NovaScotia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Nova Scotia",
                    OfficialName = "Province of Nova Scotia",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NS,
                    Capital = "Halifax",
                    AlternativeSpellings = new[] { "NS" },
                    Area = 55284
                };
            }
        }

        public static AdministrativeRegion NewBrunswick
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "New Brunswick",
                    OfficialName = "Province of New Brunswick",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NB,
                    Capital = "Fredericton",
                    AlternativeSpellings = new[] { "NB" },
                    Area = 72907
                };
            }
        }

        public static AdministrativeRegion Manitoba
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Manitoba",
                    OfficialName = "Province of Manitoba",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_MB,
                    Capital = "Winnipeg",
                    AlternativeSpellings = new[] { "MB" },
                    Area = 649950
                };
            }
        }

        public static AdministrativeRegion BritishColumbia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "British Columbia",
                    OfficialName = "Province of British Columbia",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_BC,
                    Capital = "Victoria",
                    AlternativeSpellings = new[] { "BC" },
                    Area = 944735
                };
            }
        }

        public static AdministrativeRegion PrinceEdwardIsland
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Prince Edward Island",
                    OfficialName = "Province of Prince Edward Island",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_PE,
                    Capital = "Charlottetown",
                    AlternativeSpellings = new[] { "PE", "PEI" },
                    Area = 5660
                };
            }
        }

        public static AdministrativeRegion Saskatchewan
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Saskatchewan",
                    OfficialName = "Province of Saskatchewan",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_SK,
                    Capital = "Regina",
                    AlternativeSpellings = new[] { "SK" },
                    Area = 651900
                };
            }
        }

        public static AdministrativeRegion Alberta
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Alberta",
                    OfficialName = "Province of Alberta",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_AB,
                    Capital = "Edmonton",
                    AlternativeSpellings = new[] { "AB" },
                    Area = 661848
                };
            }
        }

        public static AdministrativeRegion NewfoundlandAndLabrador
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Newfoundland And Labrador",
                    OfficialName = "Province of Newfoundland And Labrador",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NL,
                    Capital = "St. John's",
                    AlternativeSpellings = new[] { "AB" },
                    Area = 405720
                };
            }
        }

        public static AdministrativeRegion NorthwestTerritories
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Northwest Territories",
                    OfficialName = "Northwest Territories",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NT,
                    Capital = "Yellowknife",
                    AlternativeSpellings = new[] { "NT" },
                    Area = 1346106
                };
            }
        }

        public static AdministrativeRegion Yukon
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Yukon",
                    OfficialName = "Yukon Territory",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NT,
                    Capital = "Whitehorse",
                    AlternativeSpellings = new[] { "NT" },
                    Area = 482443
                };
            }
        }

        public static AdministrativeRegion Nunavut
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Nunavut",
                    OfficialName = "Nunavut Territory",
                    AdministrativeRegionCode = AdministrativeRegionCode.CA_NU,
                    Capital = "Iqaluit",
                    AlternativeSpellings = new[] { "NU" },
                    Area = 2038722
                };
            }
        }

        public static AdministrativeRegion Alabama
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Alabama",
                    OfficialName = "State of Alabama",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_AL,
                    Capital = "Montgomery",
                    AlternativeSpellings = new[] { "AL" },
                    Area = 135767
                };
            }
        }

        public static AdministrativeRegion Alaska
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Alaska",
                    OfficialName = "State of Alaska",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_AK,
                    Capital = "Juneau",
                    AlternativeSpellings = new[] { "AK" },
                    Area = 1723337
                };
            }
        }

        public static AdministrativeRegion Arizona
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Arizona",
                    OfficialName = "State of Arizona",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_AZ,
                    Capital = "Phoenix",
                    AlternativeSpellings = new[] { "AZ" },
                    Area = 295234
                };
            }
        }

        public static AdministrativeRegion Arkansas
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Arkansas",
                    OfficialName = "State of Arkansas",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_AR,
                    Capital = "Little Rock",
                    AlternativeSpellings = new[] { "AR" },
                    Area = 137732
                };
            }
        }

        public static AdministrativeRegion California
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "California",
                    OfficialName = "State of California",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_CA,
                    Capital = "Sacramento",
                    AlternativeSpellings = new[] { "CA" },
                    Area = 423967
                };
            }
        }

        public static AdministrativeRegion Colorado
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Colorado",
                    OfficialName = "State of Colorado",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_CO,
                    Capital = "Denver",
                    AlternativeSpellings = new[] { "CO" },
                    Area = 269601
                };
            }
        }

        public static AdministrativeRegion Connecticut
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Connecticut",
                    OfficialName = "State of Connecticut",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_CT,
                    Capital = "Hartford",
                    AlternativeSpellings = new[] { "CT" },
                    Area = 14357
                };
            }
        }

        public static AdministrativeRegion Delaware
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Delaware",
                    OfficialName = "State of Delaware",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_DE,
                    Capital = "Dover",
                    AlternativeSpellings = new[] { "DE" },
                    Area = 6446
                };
            }
        }

        public static AdministrativeRegion Florida
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Florida",
                    OfficialName = "State of Florida",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_FL,
                    Capital = "Tallahassee",
                    AlternativeSpellings = new[] { "FL" },
                    Area = 170312
                };
            }
        }

        public static AdministrativeRegion Georgia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Georgia",
                    OfficialName = "State of Georgia",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_GA,
                    Capital = "Atlanta",
                    AlternativeSpellings = new[] { "GA" },
                    Area = 153910
                };
            }
        }

        public static AdministrativeRegion Hawaii
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Hawaii",
                    OfficialName = "State of Hawaii",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_HI,
                    Capital = "Honolulu",
                    AlternativeSpellings = new[] { "HI" },
                    Area = 28313
                };
            }
        }

        public static AdministrativeRegion Idaho
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Idaho",
                    OfficialName = "State of Idaho",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_ID,
                    Capital = "Boise",
                    AlternativeSpellings = new[] { "ID" },
                    Area = 216443
                };
            }
        }

        public static AdministrativeRegion Illinois
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Illinois",
                    OfficialName = "State of Illinois",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_IL,
                    Capital = "Springfield",
                    AlternativeSpellings = new[] { "IL" },
                    Area = 149995
                };
            }
        }

        public static AdministrativeRegion Indiana
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Indiana",
                    OfficialName = "State of Indiana",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_IN,
                    Capital = "Indianapolis",
                    AlternativeSpellings = new[] { "IN" },
                    Area = 94326
                };
            }
        }

        public static AdministrativeRegion Iowa
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Iowa",
                    OfficialName = "State of Iowa",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_IA,
                    Capital = "Des Moines",
                    AlternativeSpellings = new[] { "IA" },
                    Area = 145746
                };
            }
        }

        public static AdministrativeRegion Kansas
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Kansas",
                    OfficialName = "State of Kansas",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_KS,
                    Capital = "Topeka",
                    AlternativeSpellings = new[] { "KS" },
                    Area = 213100
                };
            }
        }

        public static AdministrativeRegion Kentucky
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Kentucky",
                    OfficialName = "Commonwealth of Kentucky",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_KY,
                    Capital = "Frankfort",
                    AlternativeSpellings = new[] { "KY" },
                    Area = 104656
                };
            }
        }

        public static AdministrativeRegion Louisiana
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Louisiana",
                    OfficialName = "State of Louisiana",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_LA,
                    Capital = "Baton Rouge",
                    AlternativeSpellings = new[] { "LA" },
                    Area = 135659
                };
            }
        }

        public static AdministrativeRegion Maine
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Maine",
                    OfficialName = "State of Maine",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_ME,
                    Capital = "Augusta",
                    AlternativeSpellings = new[] { "ME" },
                    Area = 91633
                };
            }
        }

        public static AdministrativeRegion Maryland
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Maryland",
                    OfficialName = "State of Maryland",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MD,
                    Capital = "Annapolis",
                    AlternativeSpellings = new[] { "MD" },
                    Area = 32131
                };
            }
        }

        public static AdministrativeRegion Massachusetts
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Massachusetts",
                    OfficialName = "Commonwealth of Massachusetts",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MA,
                    Capital = "Boston",
                    AlternativeSpellings = new[] { "MA" },
                    Area = 27336
                };
            }
        }

        public static AdministrativeRegion Michigan
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Michigan",
                    OfficialName = "State of Michigan",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MI,
                    Capital = "Lansing",
                    AlternativeSpellings = new[] { "MI" },
                    Area = 250487
                };
            }
        }

        public static AdministrativeRegion Minnesota
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Minnesota",
                    OfficialName = "State of Minnesota",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MN,
                    Capital = "St. Paul",
                    AlternativeSpellings = new[] { "MN" },
                    Area = 225163
                };
            }
        }

        public static AdministrativeRegion Mississippi
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Mississippi",
                    OfficialName = "State of Mississippi",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MS,
                    Capital = "Jackson",
                    AlternativeSpellings = new[] { "MS" },
                    Area = 125438
                };
            }
        }

        public static AdministrativeRegion Missouri
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Missouri",
                    OfficialName = "State of Missouri",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MO,
                    Capital = "Jefferson City",
                    AlternativeSpellings = new[] { "MO" },
                    Area = 180540
                };
            }
        }

        public static AdministrativeRegion Montana
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Montana",
                    OfficialName = "State of Montana",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MT,
                    Capital = "Helena",
                    AlternativeSpellings = new[] { "MT" },
                    Area = 380831
                };
            }
        }

        public static AdministrativeRegion Nebraska
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Nebraska",
                    OfficialName = "State of Nebraska",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NE,
                    Capital = "Lincoln",
                    AlternativeSpellings = new[] { "NE" },
                    Area = 200330
                };
            }
        }

        public static AdministrativeRegion Nevada
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Nevada",
                    OfficialName = "State of Nevada",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NV,
                    Capital = "Carson City",
                    AlternativeSpellings = new[] { "NV" },
                    Area = 286380
                };
            }
        }

        public static AdministrativeRegion NewHampshire
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "New Hampshire",
                    OfficialName = "State of New Hampshire",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NH,
                    Capital = "Concord",
                    AlternativeSpellings = new[] { "NH" },
                    Area = 24214
                };
            }
        }

        public static AdministrativeRegion NewJersey
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "New Jersey",
                    OfficialName = "State of New Jersey",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NJ,
                    Capital = "Trenton",
                    AlternativeSpellings = new[] { "NJ" },
                    Area = 22591
                };
            }
        }

        public static AdministrativeRegion NewMexico
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "New Mexico",
                    OfficialName = "State of New Mexico",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NM,
                    Capital = "Santa Fe",
                    AlternativeSpellings = new[] { "NM" },
                    Area = 314917
                };
            }
        }

        public static AdministrativeRegion NewYork
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "New York",
                    OfficialName = "State of New York",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NY,
                    Capital = "Albany",
                    AlternativeSpellings = new[] { "NY" },
                    Area = 141297
                };
            }
        }

        public static AdministrativeRegion NorthCarolina
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "North Carolina",
                    OfficialName = "State of North Carolina",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_NC,
                    Capital = "Raleigh",
                    AlternativeSpellings = new[] { "NC" },
                    Area = 139391
                };
            }
        }

        public static AdministrativeRegion NorthDakota
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "North Dakota",
                    OfficialName = "State of North Dakota",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_ND,
                    Capital = "Bismarck",
                    AlternativeSpellings = new[] { "ND" },
                    Area = 183108
                };
            }
        }

        public static AdministrativeRegion Ohio
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Ohio",
                    OfficialName = "State of Ohio",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_OH,
                    Capital = "Columbus",
                    AlternativeSpellings = new[] { "OH" },
                    Area = 116098
                };
            }
        }

        public static AdministrativeRegion Oklahoma
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Oklahoma",
                    OfficialName = "State of Oklahoma",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_OK,
                    Capital = "Oklahoma City",
                    AlternativeSpellings = new[] { "OK" },
                    Area = 181037
                };
            }
        }

        public static AdministrativeRegion Oregon
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Oregon",
                    OfficialName = "State of Oregon",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_OR,
                    Capital = "Salem",
                    AlternativeSpellings = new[] { "OR" },
                    Area = 254799
                };
            }
        }

        public static AdministrativeRegion Pennsylvania
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Pennsylvania",
                    OfficialName = "Commonwealth of Pennsylvania",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_PA,
                    Capital = "Harrisburg",
                    AlternativeSpellings = new[] { "PA" },
                    Area = 119280
                };
            }
        }

        public static AdministrativeRegion RhodeIsland
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Rhode Island",
                    OfficialName = "State of Rhode Island",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_RI,
                    Capital = "Providence",
                    AlternativeSpellings = new[] { "RI" },
                    Area = 4001
                };
            }
        }

        public static AdministrativeRegion SouthCarolina
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "South Carolina",
                    OfficialName = "State of South Carolina",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_SC,
                    Capital = "Columbia",
                    AlternativeSpellings = new[] { "SC" },
                    Area = 82933
                };
            }
        }

        public static AdministrativeRegion SouthDakota
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "South Dakota",
                    OfficialName = "State of South Dakota",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_SD,
                    Capital = "Pierre",
                    AlternativeSpellings = new[] { "SD" },
                    Area = 199729
                };
            }
        }

        public static AdministrativeRegion Tennessee
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Tennessee",
                    OfficialName = "State of Tennessee",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_TN,
                    Capital = "Nashville",
                    AlternativeSpellings = new[] { "TN" },
                    Area = 109153
                };
            }
        }

        public static AdministrativeRegion Texas
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Texas",
                    OfficialName = "State of Texas",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_TX,
                    Capital = "Austin",
                    AlternativeSpellings = new[] { "TX" },
                    Area = 695662
                };
            }
        }

        public static AdministrativeRegion Utah
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Utah",
                    OfficialName = "State of Utah",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_UT,
                    Capital = "Salt Lake City",
                    AlternativeSpellings = new[] { "UT" },
                    Area = 219882
                };
            }
        }

        public static AdministrativeRegion Vermont
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Vermont",
                    OfficialName = "State of Vermont",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_VT,
                    Capital = "Montpelier",
                    AlternativeSpellings = new[] { "VT" },
                    Area = 24906
                };
            }
        }

        public static AdministrativeRegion Virginia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Virginia",
                    OfficialName = "Commonwealth of Virginia",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_VA,
                    Capital = "Richmond",
                    AlternativeSpellings = new[] { "VA" },
                    Area = 110787
                };
            }
        }

        public static AdministrativeRegion Washington
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Washington",
                    OfficialName = "State of Washington",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_WA,
                    Capital = "Olympia",
                    AlternativeSpellings = new[] { "WA" },
                    Area = 184661
                };
            }
        }

        public static AdministrativeRegion WestVirginia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "West Virginia",
                    OfficialName = "State of West Virginia",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_WV,
                    Capital = "Charleston",
                    AlternativeSpellings = new[] { "WV" },
                    Area = 62756
                };
            }
        }

        public static AdministrativeRegion Wisconsin
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Wisconsin",
                    OfficialName = "State of Wisconsin",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_WI,
                    Capital = "Madison",
                    AlternativeSpellings = new[] { "WI" },
                    Area = 169635
                };
            }
        }

        public static AdministrativeRegion Wyoming
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Wyoming",
                    OfficialName = "State of Wyoming",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_WY,
                    Capital = "Cheyenne",
                    AlternativeSpellings = new[] { "WY" },
                    Area = 253335
                };
            }
        }

        public static AdministrativeRegion DistrictOfColumbia
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "District of Columbia",
                    OfficialName = "District of Columbia",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_DC,
                    Capital = "Washington",
                    AlternativeSpellings = new[] { "DC" },
                    Area = 176
                };
            }
        }

        public static AdministrativeRegion AmericanSamoa
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "American Samoa",
                    OfficialName = "Unincorporated Territory of American Samoa",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_AS,
                    Capital = "Pago Pago",
                    AlternativeSpellings = new[] { "AS" },
                    Area = 199
                };
            }
        }

        public static AdministrativeRegion Guam
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Guam",
                    OfficialName = "Unincorporated Territory of Guam",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_GU,
                    Capital = "Hagåtña",
                    AlternativeSpellings = new[] { "GU" },
                    Area = 540
                };
            }
        }

        public static AdministrativeRegion NorthernMarianaIslands
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Northern Mariana Islands",
                    OfficialName = "Commonwealth of the Northern Mariana Islands",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_MP,
                    Capital = "Saipan",
                    AlternativeSpellings = new[] { "MP" },
                    Area = 464
                };
            }
        }

        public static AdministrativeRegion PuertoRico
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "Puerto Rico",
                    OfficialName = "Commonwealth of Puerto Rico",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_PR,
                    Capital = "San Juan",
                    AlternativeSpellings = new[] { "PR" },
                    Area = 9104
                };
            }
        }

        public static AdministrativeRegion UnitedStatesVirginIslands
        {
            get
            {
                return new AdministrativeRegion
                {
                    CommonName = "United States Virgin Islands",
                    OfficialName = "Virgin Islands of the United States",
                    AdministrativeRegionCode = AdministrativeRegionCode.US_VI,
                    Capital = "Charlotte Amalie",
                    AlternativeSpellings = new[] { "VI", "USVI",  "US Virgin Islands", "American Virgin Islands" },
                    Area = 346
                };
            }
        }
    }
}
