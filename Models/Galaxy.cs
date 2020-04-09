using System;
using PhoneAssignment.Interfaces;

namespace PhoneAssignment.Models
{
    public class Galaxy: Phone, IRingable
    {
        public Galaxy(string version, int charge, string carrier, string ring) : base(version,  charge,  carrier,  ring)
        {
            VersionNumber = version;
            BatteryPercentage = charge;
            Carrier = carrier;
            Ringtone = ring;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Your Galaxy, {VersionNumber} is {BatteryPercentage}% charged. Your carrier is {Carrier}.");
        }
        public override int Charge()
        {
            BatteryPercentage += 20;
            return BatteryPercentage;
        }
        public override bool IsCharged
        {
            get
            {
                return BatteryPercentage >= 20;
            }
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
                return "Charge your phone!";
            }
        }
        public string Unlock()
        {
            return "unlocked with DNA recognition";
        }

    }
}