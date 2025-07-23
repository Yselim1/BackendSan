using BackendSan.Models.Common;

namespace BackendSan.Models.Responses.Booking;

public class SetReservationInfoResponse
{
    public TransactionReponseBody Body { get; set; }
    public HeaderDto Header  { get; set; }
    
}

public class TransactionReponseBody
{
    public string TransactionId { get; set; }
    public DateTime ExpiresOn { get; set; }
    public ReservationResponseData ReservationData { get; set; }
    public int Status { get; set; }
    public int TransactionType { get; set; }
}

public class ReservationResponseData
{
    public List<TravellerResponse> Travellers { get; set; }
    public CustomerInfo CustomerInfo { get; set; }
    public ReservationInfo ReservationInfo { get; set; }
    public List<Service> Services { get; set; }
    public PaymentDetail PaymentDetail { get; set; }
    public List<object> Invoices { get; set; }
}

public class TravellerResponse
{
    public string TravellerId { get; set; }
    public int Type { get; set; }
    public int Title { get; set; }
    public List<TitleInfo> AvailableTitles { get; set; }
    public List<object> AvailableAcademicTitles { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsLeader { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public Nationality Nationality { get; set; }
    public string IdentityNumber { get; set; }
    public PassportInfo PassportInfo { get; set; }
    public AddressResponse Address { get; set; }
    public object DestinationAddress { get; set; }
    public List<TravellerService> Services { get; set; }
    public int Gender { get; set; }
    public bool IsTurkishCitizen { get; set; }
    public int OrderNumber { get; set; }
    public DateTime BirthDateFrom { get; set; }
    public DateTime BirthDateTo { get; set; }
    public List<string> RequiredFields { get; set; }
    public List<object> Documents { get; set; }
    public int PassengerType { get; set; }
    public Dictionary<string, string> AdditionalFields { get; set; }
    public List<object> InsertFields { get; set; }
    public int Status { get; set; }
}

public class TitleInfo
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class NationalityResponse
{
    public string Name { get; set; }
    public string TwoLetterCode { get; set; }
    public string ThreeLetterCode { get; set; }
    public string NumericCode { get; set; }
    public string IsdCode { get; set; }
}

public class PassportInfoResponse
{
    public string Serial { get; set; }
    public string Number { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime IssueDate { get; set; }
    public string CitizenshipCountryCode { get; set; }
}

public class AddressResponse
{
    public ContactPhone ContactPhone { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string AddressLine { get; set; }
    public string ZipCode { get; set; }
    public City City { get; set; }
    public Country Country { get; set; }
}

public class ContactPhone
{
    public string CountryCode { get; set; }
    public string? AreaCode { get; set; }
    public string PhoneNumber { get; set; }
}

public class CityResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class CountryResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class TravellerServiceResponse
{
    public string Id { get; set; }
    public int Type { get; set; }
    public Price Price { get; set; }
    public int PassengerType { get; set; }
}

public class PriceResponse
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}

public class CustomerInfo
{
    public bool IsCompany { get; set; }
    public int Title { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public PassportInfoResponse PassportInfo { get; set; }
    public CustomerAddress Address { get; set; }
    public object TaxInfo { get; set; }
    public string IdentityNumber { get; set; }
    public bool UpdateIfExists { get; set; }
    public bool UpdateOnlyNullFields { get; set; }
    public bool IsDefault { get; set; }
}



public class CustomerAddress
{
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public CustomerCity City { get; set; }
    public CustomerCountry Country { get; set; }
}

public class CustomerCity
{
    public string Name { get; set; }
}

public class CustomerCountry
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class ReservationInfoResponse
    {
        public string BookingNumber { get; set; }
        public Market Market { get; set; }
        public Operator Operator { get; set; }
        public Agency Agency { get; set; }
        public AgencyUser AgencyUser { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public string AgencyReservationNumber { get; set; }
        public Price SalePrice { get; set; }
        public Price SupplementDiscount { get; set; }
        public Price PassengerEB { get; set; }
        public Price AgencyEB { get; set; }
        public Price PassengerAmountToPay { get; set; }
        public Price AgencyAmountToPay { get; set; }
        public Price Discount { get; set; }
        public Price AgencyBalance { get; set; }
        public Price PassengerBalance { get; set; }
        public Commission AgencyCommission { get; set; }
        public Commission BrokerCommission { get; set; }
        public Commission AgencySupplementCommission { get; set; }
        public Price PromotionAmount { get; set; }
        public Price PriceToPay { get; set; }
        public Price AgencyPriceToPay { get; set; }
        public Price PassengerPriceToPay { get; set; }
        public Price TotalPrice { get; set; }
        public int ReservationStatus { get; set; }
        public int ConfirmationStatus { get; set; }
        public int PaymentStatus { get; set; }
        public List<object> Documents { get; set; }
        public List<object> OtherDocuments { get; set; }
        public ReservableInfo ReservableInfo { get; set; }
        public int PaymentFrom { get; set; }
        public CountryDetail DepartureCountry { get; set; }
        public CityDetail DepartureCity { get; set; }
        public CountryDetail ArrivalCountry { get; set; }
        public CityDetail ArrivalCity { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public Dictionary<string, string> AdditionalFields { get; set; }
        public string AdditionalCode1 { get; set; }
        public string AdditionalCode2 { get; set; }
        public string AdditionalCode3 { get; set; }
        public string AdditionalCode4 { get; set; }
        public string AdditionalCode5 { get; set; }
        public string AdditionalCode6 { get; set; }
        public string AdditionalCode7 { get; set; }
        public string AdditionalCode8 { get; set; }
        public decimal AgencyDiscount { get; set; }
        
        public bool HasAvailablePromotionCode { get; set; }
    }