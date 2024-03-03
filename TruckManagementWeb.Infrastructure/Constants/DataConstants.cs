namespace TruckManagementWeb.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int TruckPlateMinLength = 6;
        public const int TruckPlateMaxLength = 10;

        public const int TruckBrandMinLength = 4;
        public const int TruckBrandMaxLength = 40;

        public const int TruckModelMinLength = 2;
        public const int TruckModelMaxLength = 30;

        public const int CompanyNameMinLength = 5;
        public const int CompanyNameMaxLength = 50;

        public const int CompanyVatMinLength = 7;
        public const int CompanyVatMaxLength = 13;

        public const int CompanyCountryMinLength = 2;
        public const int CompanyCountryMaxLength = 30;

        public const int CompanyTownMinLength = 2;
        public const int CompanyTownMaxLength = 50;

        public const int CompanyAddressMinLength = 5;
        public const int CompanyAddressMaxLength = 60;

        public const int LoadingPostCodeMinLength = 5;
        public const int LoadingPostCodeMaxLength = 10;

        public const int DeliveryPostCodeMinLength = 5;
        public const int DeliveryPostCodeMaxLength = 10;

        public const int ExpenseNotesMinLength = 5;
        public const int ExpenseNotesMaxLength = 100;

        public const string DecimalColumnType = "decimal(18,2)";

        public const int TruckProductionYearMinYear = 2000;
        public const int TruckProductionYearMaxYear = 2050;

        public const int TruckInitialMinMileage = 1;
        public const int TruckInitialMaxMileage = 2_500_000;
    }
}
