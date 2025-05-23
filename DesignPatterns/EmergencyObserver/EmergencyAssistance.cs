namespace EmergencyObserver
{
    public class EmergencyAssistance
    {
        public EventHandler<EmergencyEventArgs> EmergencyOccurred;

        public void EmergencyCall(string location, EmergencyType emergencyType)
        {
            Console.WriteLine($"Emergency call received: {emergencyType} at {location}");
            if (EmergencyOccurred == null)
            {
                Console.WriteLine("No subscribers.");
                return;
            }
            foreach (Delegate subscriber in EmergencyOccurred.GetInvocationList())
            {
                try
                {
                    subscriber.DynamicInvoke(this, new EmergencyEventArgs(emergencyType, location));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error notifying a service: {ex.Message}");
                }
            }
        }
    }
}
