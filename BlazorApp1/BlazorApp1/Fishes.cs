using System.Reflection;

namespace BlazorApp1
{

    public partial class Fishes
    {

        public string FisheryManagement { get; set; }
        public string Habitat { get; set; }
        public string HabitatImpacts { get; set; }
        public SpeciesIllustrationPhoto[] ImageGallery { get; set; }
        public string Location { get; set; }
        public object Management { get; set; }
        public string NoaaFisheriesRegion { get; set; }
        public string Population { get; set; }
        public string PopulationStatus { get; set; }
        public string ScientificName { get; set; }
        public string SpeciesAliases { get; set; }
        public SpeciesIllustrationPhoto SpeciesIllustrationPhoto { get; set; }
        public string SpeciesName { get; set; }
        public object AnimalHealth { get; set; }
        public string Availability { get; set; }
        public string Biology { get; set; }
        public string Bycatch { get; set; }
        public long Calories { get; set; }
        public string Carbohydrate { get; set; }
        public string Cholesterol { get; set; }
        public string Color { get; set; }
        public object DiseaseTreatmentAndPrevention { get; set; }
        public object DiseasesInSalmon { get; set; }
        public object DisplayedSeafoodProfileIllustration { get; set; }
        public object EcosystemServices { get; set; }
        public object EnvironmentalConsiderations { get; set; }
        public object EnvironmentalEffects { get; set; }
        public object FarmingMethods { get; set; }
        public object TemperatureFarmingMethods { get; set; }
        public string FatTotal { get; set; }
        public object TemperatureFeeds { get; set; }
        public object Feeds { get; set; }
        public string FiberTotalDietary { get; set; }
        public string FishingRate { get; set; }
        public string Harvest { get; set; }
        public string HarvestType { get; set; }
        public string HealthBenefits { get; set; }
        public object TemperatureHumanHealth { get; set; }
        public object HumanHealth { get; set; }
        public string PhysicalDescription { get; set; }
        public object Production { get; set; }
        public string Protein { get; set; }
        public string Quote { get; set; }
        public string QuoteBackgroundColor { get; set; }
        public string Research { get; set; }
        public string SaturatedFattyAcidsTotal { get; set; }
        public string Selenium { get; set; }
        public string ServingWeight { get; set; }
        public long Servings { get; set; }
        public string Sodium { get; set; }
        public string Source { get; set; }
        public string SugarsTotal { get; set; }
        public string Taste { get; set; }
        public string Texture { get; set; }
        public string Path { get; set; }
        public string LastUpdate { get; set; }
        public string[] names = { "Crimson-Jobfish", "White-Hake", "Atlantic-Chub-Mackerel", "Shortfin-Squid", "American-Lobster", "Yellowtail-Rockfish", "Bocaccio", "Sugar-Kelp", "Sablefish", "Atlantic-Halibut", "Shortspine-Thornyhead", "Canary-Rockfish", "Black-Grouper", "Striped-Marlin", "Blueline-Tilefish", "Red-Hake", "Atlantic-Sharpnose-Shark", "Pacific-Sardine", "Pacific-Oyster", "Hard-Clam/Northern-Quahog", "Geoduck-", "Eastern-Oyster", "Blue-Mussel", "Atlantic-Salmon", "Butterfish", "Winter-Skate", "Pink-Salmon", "Atlantic-Northern-Shrimp", "North-Pacific-Swordfish", "Atlantic-Mackerel", "Atlantic-Bigeye-Tuna", "North-Atlantic-Albacore-Tuna", "Acadian-Redfish", "Atlantic-Skipjack-Tuna", "Atlantic-Sea-Scallop", "Atlantic-Salmon", "Atlantic-Pollock", "Atlantic-Yellowfin-Tuna", "Longfin-Inshore-Squid", "Scup", "Pink-Shrimp", "White-Shrimp", "Silver-Hake", "Pacific-Skipjack-Tuna", "North-Atlantic-Swordfish", "Brown-Rock-Shrimp", "Yellowtail-Flounder", "Winter-Flounder", "Coho-Salmon", "Chum-Salmon", "Brown-Shrimp", "Pacific-Mackerel", "Pacific-Bluefin-Tuna", "Opah", "Atlantic-Herring", "Vermilion-Snapper", "Atlantic-Blacktip-Shark", "Haddock", "Chinook-Salmon", "Pacific-Bigeye-Tuna", "Atlantic-Shortfin-Mako-Shark", "Atlantic-Common-Thresher-Shark", "Yellowfin-Sole", "Pacific-Yellowfin-Tuna", "Pacific-Whiting", "Spanish-Mackerel", "Rock-Sole", "Pacific-Wahoo", "King-Mackerel", "Greenland-Turbot", "California-Market-Squid", "Atlantic-Wahoo", "Gag-Grouper", "Flathead-Sole", "Summer-Flounder", "Rex-Sole", "Red-Grouper", "English-Sole", "Dover-Sole", "Caribbean-Spiny-Lobster", "Pacific-Albacore-Tuna", "Wreckfish", "Queen-Conch", "Red-King-Crab", "Pacific-Spiny-Dogfish", "Pacific-Halibut", "Atlantic-Spiny-Dogfish", "Arrowtooth-Flounder", "Alaska-Snow-Crab", "Ocean-Quahog", "Gray-Triggerfish", "Bluefish", "Black-Sea-Bass", "Petrale-Sole", "Greater-Amberjack", "Pacific-Common-Thresher-Shark", "Pacific-Cod", "Pacific-Blue-Marlin", "Northern-Anchovy", "Lingcod", "Atlantic-Striped-Bass", "Atlantic-Surfclam", "Pacific-Shortfin-Mako-Shark", "Pacific-Ocean-Perch", "Pacific-Mahimahi", "Widow-Rockfish", "Western-Atlantic-Bluefin-Tuna", "Tilefish", "Red-Snapper", "Sockeye-Salmon", "Sablefish", "Alaska-Pollock", "Monkfish", "Atlantic-Mahi-Mahi", "Cobia", "Atlantic-Cod" };

    }

    public partial class SpeciesIllustrationPhoto
    {
        public Uri Src { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
    }

}
