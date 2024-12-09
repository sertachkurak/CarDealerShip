namespace CarDealership.Common
{

    public static class Constants
    {
        public static class VehicleCategoryValidations
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 10;
        }

        public static class VehicleTypeValidations
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 10;
        }

        public static class VehicleValidations
        {
            public const int MakeMinLength = 2;
            public const int MakeMaxLength = 20;

            public const int ModelMinLength = 2;
            public const int ModelMaxLength = 20;

            public const int FuelTypeMinLength = 3;
            public const int FuelTypeMaxLength = 12;

            public const int GearBoxMinLength = 5;
            public const int GearBoxMaxLength = 12;

            public const int DoorsMinCount = 2;
            public const int DoorsMaxCount = 5;

            public const int SeatsMinCount = 2;
            public const int SeatsMaxCount = 7;

            public const int TankMinCapacity = 30;
            public const int TankMaxCapacity = 120;

            public const int HorsepowerMinLength = 70;
            public const int HorsepowerMaxLength = 800;


            public const int MinCubage = 1200;
            public const int MaxCubage = 6000;


            public const int ImageUrlMaxLength = 300;
        }

        public static class LocationValidations
        {
            public const int NameMaxLength = 30;
        }

        public static class PurposeValidations
        {
            public const int NameMaxLength = 20;
        }

        public static class ManagerValidations
        {
            public const int PhoneNumberMinLength = 6;
            public const int PhoneNumberMaxLength = 16;
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 40;
        }

        public static class MessageConstants
        {
            public const string ErrorMessage = "ErrorMessage";
            public const string WarningMessage = "WarningMessage";
            public const string SuccessMessage = "SuccessMessage";
        }

        public static class AdminConstants
        {
            public const string AdminRoleName = "Admin";
        }
    }
}
