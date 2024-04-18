using System.ComponentModel.DataAnnotations;

namespace Mobiphony.Models
{
    public class Phone
    {
        [Key]
        public  int Id { get; set; }

        public required string Model { get; set; }

        // Dimentions
        public  double Length { get; set; }
        public  double Width { get; set; }
        public  double Thickness { get; set; }



        public int SIM { get; set; }        // Can be changed based on what value we want to pass



        public int IPRating { get; set; }        // Can be changed based on what value we want to pass



        // Display
        public  double Dsize { get; set; }
        public  double Matrix { get; set; }
        public  double RefreshRate { get; set; }
        public  double Brightness { get; set; }
        public  double Resolution { get; set; }
        public  string? ScrProtection { get; set; }
    


        // Hardware
        public  string? Chipset { get; set; }
        public  string? CPU { get; set; }
        public  string? GPU { get; set; }
        public  int RAM { get; set; }
        public  double InternalStorage { get; set; }
        public  double ExpStorageLimit { get; set; }
        public  string? USBType { get; set; }
        public  bool FingerPrint { get; set; }
        public  bool FaceRec { get; set; }
        public  double BatCapacity { get; set; }
        public  double BatChargingWattage { get; set; }
        // MC == Main Camera
        public  double MCMP { get; set; }
        public  string? MCVideo { get; set; }
        public  string? MCFeatures { get; set; }
        // SC == Selfie Camera
        public  double SCMP { get; set; }
        public  string? SCVideo { get; set; }
        public  string? SCFeatures { get; set; }
        // Software
        public  string? OS { get; set; }
        public  double WiFiSpeed { get; set; }
        public  double BluetoothVersion { get; set; }
        public  double USBVersion { get; set; }
        public  bool NFC { get; set; }



        public  double Price { get; set; }
    }
}
