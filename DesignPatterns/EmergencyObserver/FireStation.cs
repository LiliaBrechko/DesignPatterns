namespace EmergencyObserver
{
    public class FireStation : EmergencyObserver
    {
        public FireStation(int brigadeNumber) : base(brigadeNumber)
        {
        }
        public override void OnEmergencyOccurred(object sender, EmergencyEventArgs e)
        {
            if (e.EmergencyType == EmergencyType.fire)
            {
                Console.WriteLine($"Fire station brigade {BrigadeNumber} is responding to {e.EmergencyType} at {e.Location}");
            }

        }
    }
}
