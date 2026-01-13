namespace ApiProject.WebApi.Dtos.ReservationDtos
{
    public class CreateReservationDto
    {
        
        public string NameSurmane { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int CountofPeople { get; set; }
        public int Message { get; set; }
        public string ReservationStatus { get; set; }
    }
}
