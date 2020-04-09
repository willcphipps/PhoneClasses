namespace PhoneAssignment.Models
{
    public abstract class Phone
    {
        protected string VersionNumber;
        protected int BatteryPercentage;
        protected string Carrier;
        protected string Ringtone;
        public abstract bool IsCharged{get;}
        public Phone(string version, int charge, string carrier, string ring)
        {
            VersionNumber = version;
            BatteryPercentage = charge;
            Carrier = carrier;
            Ringtone = ring;
        }
        
        public abstract void DisplayInfo();
        public abstract int Charge();
    }
}