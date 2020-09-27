namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats 
        { 
            get
            {
                int value = TotalFirstClassSeats - BookedFirstClassSeats;
                return value;
            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats 
        { 
            get
            {
                int value = TotalCoachSeats - BookedCoachSeats;
                return value;
            }
                }
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool seatStatus = false;
            if ((forFirstClass == true) && (totalNumberOfSeats <= AvailableFirstClassSeats))
            {
                seatStatus = true;
                BookedFirstClassSeats += totalNumberOfSeats;
            }
            else if ((forFirstClass == false) && (totalNumberOfSeats <= AvailableCoachSeats))
            {
                seatStatus = true;
                BookedCoachSeats += totalNumberOfSeats;

            }
            return seatStatus;

        }
    }
}
