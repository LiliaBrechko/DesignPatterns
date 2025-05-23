namespace EmergencyObserver
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmergencyAssistance emergencyAssistance = new EmergencyAssistance();

            FireStation fireStation = new FireStation(1);
            Police police = new Police(2);
            Ambulance ambulance = new Ambulance(3);

            emergencyAssistance.EmergencyOccurred += police.OnEmergencyOccurred;
            emergencyAssistance.EmergencyOccurred += ambulance.OnEmergencyOccurred;
            emergencyAssistance.EmergencyOccurred += fireStation.OnEmergencyOccurred;

            emergencyAssistance.EmergencyCall("123 Main St", EmergencyType.fire);
            emergencyAssistance.EmergencyCall("456 Elm St", EmergencyType.criminal);
            emergencyAssistance.EmergencyCall("789 Oak St", EmergencyType.ambulance);

        }
    }
}
