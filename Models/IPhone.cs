using System;
using PhoneAssignment.Interfaces;

namespace PhoneAssignment.Models
{
    public class IPhone: Phone, IRingable
    {
        public IPhone(string version, int charge, string carrier, string ring) : base(version, charge, carrier, ring)
        {
            VersionNumber = version;
            BatteryPercentage = charge;
            Carrier = carrier;
            Ringtone = ring;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Your IPhone, {VersionNumber} is {BatteryPercentage}% charged. Your carrier is {Carrier}.");
        }
        public override bool IsCharged
        {
            get
            {
                return BatteryPercentage >= 5;
            }
        }
        public override int Charge()
        {
            BatteryPercentage += 20;
            return BatteryPercentage;
        }
    
        public string Ring()
        {
            if(IsCharged)
            {
                BatteryPercentage -= 10;
                return Ringtone;
            }
            else
            {
                BatteryPercentage -= 5;
                return "Charge Your Phone!";
            }
        }
        public string Unlock()
        {
            return "Unlocked with mind control.";
        }
        
        
    }
}