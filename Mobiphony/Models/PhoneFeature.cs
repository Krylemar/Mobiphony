namespace Mobiphony.Models
{
    public class PhoneFeature
    {
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
