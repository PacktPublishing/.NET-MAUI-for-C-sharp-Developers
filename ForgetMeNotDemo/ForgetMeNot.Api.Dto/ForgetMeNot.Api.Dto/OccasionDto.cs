using ForgetMeNot.Api.Domain;

namespace ForgetMeNot.Api.Dto
{

    public class OccasionDto
    {
        public OccasionDto()
        {

        }

        public OccasionDto(Occasion occasion)
        {
            Id = occasion.Id;
            OccasionName = occasion.OccasionName;
            Date = occasion.Date;
            NumDaysToNotify = occasion.NumDaysToNotify;
        }

        public Guid Id { get; set; }
        public string? OccasionName { get; set; }
        public DateTime Date { get; set; }
        public int NumDaysToNotify { get; set; }
    }
}
