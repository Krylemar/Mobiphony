namespace AutoDjambazi.Models
{
    public class Phone
    {
        public required int Id { get; set; }



        // Dimentions
        public required double Length { get; set; }
        public required double Width { get; set; }
        public required double Thickness { get; set; }



        public int SIM { get; set; }        // Can be changed based on what value we want to pass



        public int IPRating { get; set; }        // Can be changed based on what value we want to pass



        // Display
        public required double Dsize { get; set; }
        public required double Matrix { get; set; }
        public required double RefreshRate { get; set; }
        public required double Brightness { get; set; }
        public required double Resolution { get; set; }
        public string ScrProtection { get; set; }
    


        // Hardware
        public required string Chipset { get; set; }
        public required string CPU { get; set; }
        public required string GPU { get; set; }
        public required int RAM { get; set; }
        public required double InternalStorage { get; set; }
        public required double ExpStorageLimit { get; set; }
        public required string USBType { get; set; }
        public required bool FingerPrint { get; set; }
        public required bool FaceRec { get; set; }
        public required double BatCapacity { get; set; }
        public required double BatChargingWattage { get; set; }
        // MC == Main Camera
        public required double MCMP { get; set; }
        public required string MCVideo { get; set; }
        public required string MCFeatures { get; set; }
        // SC == Selfie Camera
        public required double SCMP { get; set; }
        public required string SCVideo { get; set; }
        public required string SCFeatures { get; set; }



        // Software
        public required string OS { get; set; }
        public required double WiFiSpeed { get; set; }
        public required double BluetoothVersion { get; set; }
        public required double USBVersion { get; set; }
        public required bool NFC { get; set; }



        public required double Price { get; set; }
    }
}
