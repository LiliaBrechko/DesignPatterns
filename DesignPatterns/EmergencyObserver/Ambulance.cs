namespace EmergencyObserver
{
    public class Ambulance : EmergencyObserver
    {
        public Ambulance(int brigadeNumber) : base(brigadeNumber)
        {
        }
        public override void OnEmergencyOccurred(object sender, EmergencyEventArgs e)
        {
            if (e.EmergencyType == EmergencyType.ambulance || e.EmergencyType == EmergencyType.criminal || e.EmergencyType == EmergencyType.fire)
            {
                Console.WriteLine($"Ambulance brigade {BrigadeNumber} is responding to {e.EmergencyType} at {e.Location}");

            }

        }

    }
}
