namespace EmergencyObserver
{
    public class EmergencyEventArgs : EventArgs
    {
        public EmergencyType EmergencyType { get; set; }
        public string Location { get; set; }

        public EmergencyEventArgs(EmergencyType emergencyType, string location)
        {
            EmergencyType = emergencyType;
            Location = location;
        }
    }
}
