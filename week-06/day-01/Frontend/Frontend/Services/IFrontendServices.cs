namespace Frontend.Services
{
    public interface IFrontendServices
    {
        int Sum(int until);
        int Factor(int until);
        int Sum(int[] intArray);
        int Multiply(int[] intArray);
        int[] Double(int[] intArray);
    }
}