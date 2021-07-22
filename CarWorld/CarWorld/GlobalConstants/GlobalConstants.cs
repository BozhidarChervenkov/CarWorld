namespace CarWorld.GlobalConstants
{
    public static class GlobalConstants
    {
        // Home page constants:

        public const int HomeCarsPerPage = 8;
        public const int HomeCarDescriptionLength = 80;

        // Cars/All page constants:

        public const int MinStartingPageNumber = 1;
        public const int MaxCarsPerPageCount = 12;
        public const int AllPageCarDescriptionLength = 70;

        // Model validation constants:

        public const string CarPriceFormat = "decimal(18,2)";

        public const int CarDescriptionMinLength = 10;
        public const int CarDescriptionMaxLength = 600;

        public const int CarYearMin = 1500;
        public const int CarYearMax = 2500;

        public const int MakeNameMinLenght = 2;
        public const int MakeNameMaxLenght = 20;

        public const int ModelNameMinLenght = 2;
        public const int ModelNameMaxLenght = 25;

        public const int BodyTypeNameMinLenght = 2;
        public const int BodyTypeNameMaxLenght =25;

        public const int PictureUrlMinLenght = 5;
        public const int PictureUrlMaxLenght =1500;

        public const int ShowTitleMinLenght = 5;
        public const int ShowTitleMaxLenght = 50;

        public const int ShowDescriptionMinLenght = 10;
        public const int ShowDescriptionMaxLenght = 600;
    }
}
