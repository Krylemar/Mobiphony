using System;
using System.Collections.Generic;

namespace Mobiphony.Models;

public partial class Phone
{
    public int Id { get; set; }

    public int Brand { get; set; }

    public string Model { get; set; } = null!;

    public double Length { get; set; }

    public double Width { get; set; }

    public double Thickness { get; set; }

    public double Weight { get; set; }

    public int Sim { get; set; }

    public string Iprating { get; set; } = null!;

    public double DisplaySize { get; set; }

    public int Matrix { get; set; }

    public int RefreshRate { get; set; }

    public int Brightness { get; set; }

    public string Resolution { get; set; } = null!;

    public string? ScreenProtection { get; set; }

    public string? Chipset { get; set; }

    public string? Cpu { get; set; }

    public string? Gpu { get; set; }

    public int Ram { get; set; }

    public int InternalStorage { get; set; }

    public int ExpStorageLimit { get; set; }

    public string? Usbtype { get; set; }

    public bool FingerPrint { get; set; }

    public bool FaceRec { get; set; }

    public int BatCapacity { get; set; }

    public int BatChargingWattage { get; set; }

    public int MainCamPhoto { get; set; }

    public string? MainCamVideo { get; set; }

    public int SelfCamPhoto { get; set; }

    public string? SselfCamVideo { get; set; }

    public string Os { get; set; } = null!;

    public string WiFiSpeed { get; set; } = null!;

    public double BluetoothVersion { get; set; }

    public decimal Price { get; set; }

    public string? PurchaseLink { get; set; }

    public string? ImgLink { get; set; }

    public double Rating { get; set; }

    public virtual Brand? BrandNavigation { get; set; }

    public virtual DisplayMatrix? MatrixNavigation { get; set; }

    public virtual ICollection<CameraFeature> CameraFeatures { get; set; } = new List<CameraFeature>();

    public virtual ICollection<Feature> Features { get; set; } = new List<Feature>();
}
