namespace EmergencyObserver
{
    public abstract class EmergencyObserver
    {
        public int BrigadeNumber { get; set; }
        public EmergencyObserver(int brigadeNumber)
        {
            BrigadeNumber = brigadeNumber;
        }

        public abstract void OnEmergencyOccurred(object sender, EmergencyEventArgs e);

    }
}
