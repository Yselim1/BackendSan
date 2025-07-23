using BackendSan.Models.Common;

namespace BackendSan.Models.Responses.Booking;

public class BeginTransactionResponse
{
    public TransactionBody Body { get; set; }
    public HeaderDto Header { get; set; }
}

public class TransactionBody
{
    public string TransactionId { get; set; }
    public string ExpiresOn { get; set; }
    public ReservationData ReservationData { get; set; }
    public int Status { get; set; }
    public int TransactionType { get; set; }
}

public class ReservationData
{
    public List<Traveller> Travellers { get; set; }
    public ReservationInfo ReservationInfo { get; set; }
    public List<Service> Services { get; set; }
    public PaymentDetail PaymentDetail { get; set; }
    public List<object> Invoices { get; set; } // Replace with specific class if needed
}

public class Traveller
{
    public string TravellerId { get; set; }
    public int Type { get; set; }
    public int Title { get; set; }
    public List<Title> AvailableTitles { get; set; }
    public List<object> AvailableAcademicTitles { get; set; } // Replace with specific class if needed
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsLeader { get; set; }
    public string BirthDate { get; set; }
    public Nationality Nationality { get; set; }
    public string IdentityNumber { get; set; }
    public PassportInfo PassportInfo { get; set; }
    public Address Address { get; set; }
    public object DestinationAddress { get; set; } // Replace with specific class if needed
    public List<TravellerService> Services { get; set; }
    public int OrderNumber { get; set; }
    public string BirthDateFrom { get; set; }
    public string BirthDateTo { get; set; }
    public List<string> RequiredFields { get; set; }
    public List<object> Documents { get; set; } // Replace with specific class if needed
    public int PassengerType { get; set; }
    public Dictionary<string, string> AdditionalFields { get; set; }
    public List<object> InsertFields { get; set; } // Replace with specific class if needed
    public int Status { get; set; }
}

public class Title
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Nationality
{
    public string TwoLetterCode { get; set; }
}

public class PassportInfo
{
    public string serial { get; set; }
    public string number { get; set; }
    public string ExpireDate { get; set; }
    public string IssueDate { get; set; }
    public string CitizenshipCountryCode { get; set; }
}

public class Address
{
    public ContactPhone ContactPhone { get; set; } // Replace with specific class if needed
    public string Email { get; set; }
    public string AddressLine { get; set; }
    public string ZipCode { get; set; }
    public City City { get; set; }
    public Country Country { get; set; }
}



public class City
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Country
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class TravellerService
{
    public string Id { get; set; }
    public int Type { get; set; }
    public Price Price { get; set; }
    public int PassengerType { get; set; }
}

public class Price
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}

public class ReservationInfo
{
    public string BookingNumber { get; set; }
    public Market Market { get; set; }
    public Operator Operator { get; set; }
    public Agency Agency { get; set; }
    public AgencyUser AgencyUser { get; set; }
    public string BeginDate { get; set; }
    public string EndDate { get; set; }
    public string Note { get; set; }
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
    public List<object> Documents { get; set; } // Replace with specific class if needed
    public List<object> OtherDocuments { get; set; } // Replace with specific class if needed
    public ReservableInfo ReservableInfo { get; set; }
    public int PaymentFrom { get; set; }
    public CountryDetail DepartureCountry { get; set; }
    public CityDetail DepartureCity { get; set; }
    public CountryDetail ArrivalCountry { get; set; }
    public CityDetail ArrivalCity { get; set; }
    public string CreateDate { get; set; }
    public string ChangeDate { get; set; }
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

public class Market
{
    public string Code { get; set; }
}

public class Operator
{
    public string Code { get; set; }
}

public class Agency
{
    public string Code { get; set; }
    public string Name { get; set; }
    public AgencyCountry Country { get; set; }
    public AgencyAddress Address { get; set; }
    public bool OwnAgency { get; set; }
    public bool AceExport { get; set; }
    public ContactInfo ContactInfo { get; set; }
}

public class AgencyCountry
{
    public string InternationalCode { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
}

public class AgencyAddress
{
    public AddressCountry Country { get; set; }
    public AddressCity City { get; set; }
    public List<string> AddressLines { get; set; }
    public string ZipCode { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}

public class AddressCountry
{
    public string InternationalCode { get; set; }
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}

public class AddressCity
{
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}

public class ContactInfo
{
    public ContactCountry Country { get; set; }
    public ContactCity City { get; set; }
}

public class ContactCountry
{
    public string Name { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
}

public class ContactCity
{
    public string Name { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
}

public class AgencyUser
{
    public Office Office { get; set; }
    public AgencyUserOperator Operator { get; set; }
    public AgencyUserMarket Market { get; set; }
    public AgencyUserAgency Agency { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}

public class Office
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class AgencyUserOperator
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool AgencyCanDiscountCommission { get; set; }
}

public class AgencyUserMarket
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class AgencyUserAgency
{
    public string Code { get; set; }
    public string Name { get; set; }
    public bool OwnAgency { get; set; }
    public bool AceExport { get; set; }
}

public class Commission
{
    public decimal Percent { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}

public class ReservableInfo
{
    public bool Reservable { get; set; }
}

public class CountryDetail
{
    public string Code { get; set; }
    public string InternationalCode { get; set; }
    public string Name { get; set; }
    public string InternationalName { get; set; }
    public int Type { get; set; }
    public string ParentId { get; set; }
    public string CountryId { get; set; }
    public string ChangeDate { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}

public class CityDetail
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string InternationalName { get; set; }
    public int Type { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string ParentId { get; set; }
    public string CountryId { get; set; }
    public string ChangeDate { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}

public class Service
{
    public int OrderNumber { get; set; }
    public string Note { get; set; }
    public CountryDetail DepartureCountry { get; set; }
    public CityDetail DepartureCity { get; set; }
    public CountryDetail ArrivalCountry { get; set; }
    public CityDetail ArrivalCity { get; set; }
    public ServiceDetails ServiceDetails { get; set; }
    public string PartnerServiceId { get; set; }
    public bool IsMainService { get; set; }
    public bool IsRefundable { get; set; }
    public bool Bundle { get; set; }
    public List<CancellationPolicy> CancellationPolicies { get; set; }
    public List<object> Documents { get; set; } // Replace with specific class if needed
    public string EncryptedServiceNumber { get; set; }
    public List<object> PriceBreakDowns { get; set; } // Replace with specific class if needed
    public decimal Commission { get; set; }
    public ReservableInfo ReservableInfo { get; set; }
    public int Unit { get; set; }
    public List<object> ConditionalSpos { get; set; } // Replace with specific class if needed
    public bool IsThirdPartyOwnProvider { get; set; }
    public bool IsThirdPartyOwnOffer { get; set; }
    public ThirdPartyInformation ThirdPartyInformation { get; set; }
    public int ConfirmationStatus { get; set; }
    public int ServiceStatus { get; set; }
    public int ProductType { get; set; }
    public bool CreateServiceTypeIfNotExists { get; set; }
    public string Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string BeginDate { get; set; }
    public string EndDate { get; set; }
    public int Adult { get; set; }
    public int Child { get; set; }
    public int Infant { get; set; }
    public Price Price { get; set; }
    public bool IncludePackage { get; set; }
    public bool Compulsory { get; set; }
    public bool IsExtraService { get; set; }
    public int Provider { get; set; }
    public List<string> Travellers { get; set; }
    public bool ThirdPartyRecord { get; set; }
    public int RecordId { get; set; }
    public Dictionary<string, string> AdditionalFields { get; set; }
    public int? ServiceGroup { get; set; }
    public string MainServiceId { get; set; }
}

public class ServiceDetails
{
    public string ServiceId { get; set; }
    public string Thumbnail { get; set; }
    public HotelDetail HotelDetail { get; set; }
    public int Night { get; set; }
    public string RoomCode { get; set; }
    public string Room { get; set; }
    public string BoardCode { get; set; }
    public string Board { get; set; }
    public string Accom { get; set; }
    public string Star { get; set; }
    public GeoLocation GeoLocation { get; set; }
    public int? PriceType { get; set; }
    public ExtraServiceDetail ExtraServiceDetail { get; set; }
}

public class HotelDetail
{
    public HotelAddress Address { get; set; }
    public string FaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string HomePage { get; set; }
    public Location TransferLocation { get; set; }
    public int StopSaleGuaranteed { get; set; }
    public int StopSaleStandart { get; set; }
    public List<object> Restrictions { get; set; } // Replace with specific class if needed
    public List<object> Handicaps { get; set; } // Replace with specific class if needed
    public GeoLocation Geolocation { get; set; }
    public int Stars { get; set; }
    public Location Location { get; set; }
    public Country Country { get; set; }
    public City City { get; set; }
    public bool HasChannelManagerOffer { get; set; }
    public string Thumbnail { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
}

public class HotelAddress
{
    public List<string> AddressLines { get; set; }
    public string ZipCode { get; set; }
}

public class Location
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string ParentId { get; set; }
    public string CountryId { get; set; }
    public int Provider { get; set; }
    public bool IsTopRegion { get; set; }
    public bool OwnLocation { get; set; }
    public string Id { get; set; }
}

public class GeoLocation
{
    public string Longitude { get; set; }
    public string Latitude { get; set; }
}

public class ExtraServiceDetail
{
    public bool Show { get; set; }
    public bool Compulsory { get; set; }
    public bool Free { get; set; }
}

public class CancellationPolicy
{
    public string DueDate { get; set; }
    public Price Price { get; set; }
    public int Provider { get; set; }
}

public class ThirdPartyInformation
{
    public List<object> Infos { get; set; } // Replace with specific class if needed
}

public class PaymentDetail
{
    public List<PaymentPlan> PaymentPlan { get; set; }
    public List<object> PaymentInfo { get; set; } // Replace with specific class if needed
}

public class PaymentPlan
{
    public int PaymentNo { get; set; }
    public string DueDate { get; set; }
    public PaymentPrice Price { get; set; }
    public bool PaymentStatus { get; set; }
}

public class PaymentPrice
{
    public decimal Percent { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}