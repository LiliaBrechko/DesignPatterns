namespace EmergencyObserver
{
    public class Police : EmergencyObserver
    {
        public Police(int brigadeNumber) : base(brigadeNumber)
        {
        }
        public override void OnEmergencyOccurred(object sender, EmergencyEventArgs e)
        {
            if (e.EmergencyType == EmergencyType.fire || e.EmergencyType == EmergencyType.criminal)
            {
                Console.WriteLine($"Police brigade {BrigadeNumber} is responding to {e.EmergencyType} at {e.Location}");
            }

        }

    }

}
