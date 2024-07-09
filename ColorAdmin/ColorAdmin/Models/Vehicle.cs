using System.ComponentModel.DataAnnotations;

namespace ColorAdmin.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public string LicensePlate { get; set; }
        [RegularExpression(@"^[A-HJ-NPR-Z0-9]{17}$", ErrorMessage = "VIN number must be a valid 17-character VIN.")]
        public string VinNumber { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        [RegularExpression(@"^(19\d{2}|20[0-2][0-4])$", ErrorMessage = "Year of manufacture must be a valid four-digit year.")]
        public int YearOfManufacture { get; set; }
        public string IdentificationCard { get; set; }
        public string TypeOfVehicle { get; set; }
        public string MapMarkerColor { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Map marker size must be 0 or greater.")]
        public int MapMarkerSize { get; set; }
        public string DefaultDriver { get; set; }
        [RegularExpression(@"^[0-9]{1,20}$", ErrorMessage = "Phone number must be between 1 and 20 digits.")]
        public string DefaultDriverPhone { get; set; }
        public string? EngineNumber { get; set; }
        public string? Picture { get; set; }
        public string? WorkingSchedule { get; set; }
        public bool CarpoolAvailability { get; set; }
        public string? Device { get; set; }
        public string? IMEI { get; set; }
        public string? ICCID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? TID { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
    }

}
