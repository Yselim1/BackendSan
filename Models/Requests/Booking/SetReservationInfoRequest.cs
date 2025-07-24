namespace BackendSan.Models.Requests.Booking;

public class SetReservationInfoRequest
{
    public string TransactionId { get; set; }
    public List<TravellerRequest> Travellers { get; set; }
    public CustomerInfoRequest? CustomerInfo { get; set; }
    public string ReservationNote { get; set; }
    public string AgencyReservationNumber { get; set; }
}

public class TravellerRequest
{
    public string TravellerId { get; set; }
    public int Type { get; set; }
    public int Title { get; set; }
    public int PassengerType { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsLeader { get; set; }
    public DateTime BirthDate { get; set; }
    public int? Gender { get; set; }
    public NationalityRequest Nationality { get; set; }
    public string IdentityNumber { get; set; }
    public PassportInfoRequest PassportInfo { get; set; }
    public AddressRequest Address { get; set; }
    public object DestinationAddress { get; set; }
    public int OrderNumber { get; set; }
    public List<object> Documents { get; set; }
    public List<object> InsertFields { get; set; }
    public int Status { get; set; }
}

public class NationalityRequest
{
    public string TwoLetterCode { get; set; }
}

public class PassportInfoRequest
{
    public string? Serial { get; set; }
    public string? Number { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime IssueDate { get; set; }
    public string? CitizenshipCountryCode { get; set; }
}

public class AddressRequest
{
    public ContactPhoneRequest ContactPhone { get; set; }
    public string? Phone { get; set; }
    public string Email { get; set; }
    public string? Address { get; set; }
    public string ZipCode { get; set; }
    public CityRequest City { get; set; }
    public CountryRequest Country { get; set; }
}

public class ContactPhoneRequest
{
    public string? CountryCode { get; set; }
    public string? AreaCode { get; set; }
    public string? PhoneNumber { get; set; }
}

public class CityRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class CountryRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class CustomerInfoRequest
{
    public bool IsCompany { get; set; }
    public PassportInfoRequest? PassportInfo { get; set; }
    public CustomerAddressRequest? Address { get; set; }
    public object TaxInfo { get; set; }
    public int Title { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string BirthDate { get; set; }
    public string IdentityNumber { get; set; }
}

public class CustomerAddressRequest
{
    public CustomerCityRequest City { get; set; }
    public CustomerCountryRequest Country { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
}

public class CustomerCityRequest
{
    public string Name { get; set; }
}

public class CustomerCountryRequest
{
    public string Name { get; set; }
}