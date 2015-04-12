namespace OnCheckin.Business
{
    public interface IAdditionService
    {
        int AddTwoNumbersTogether(int firstNumber, int secondNumber);
    }

    public class AdditionService : IAdditionService
    {
        public int AddTwoNumbersTogether(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
