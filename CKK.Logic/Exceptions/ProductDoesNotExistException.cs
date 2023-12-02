namespace CKK.Logic.Exceptions
{
    public class ProductDoesNotExistException : Exception
    {
        string errMsg;
        int errCode;
        public ProductDoesNotExistException()
        {
            errMsg = "No error message provided";
            errCode = 0x1;
        }

        public ProductDoesNotExistException(string Error_Message, int Error_Code)
        {
            errMsg = Error_Message;
            errCode = Error_Code;
        }
    }
}
