namespace CKK.Logic.Exceptions
{
    [Serializable]
    public class InvalidIdException : Exception
    {
        string errMsg;
        int errCode;
        public InvalidIdException()
        {
            errMsg = "No error message provided";
            errCode = 0x1;
        }

        public InvalidIdException(string Error_Message, int Error_Code)
        {
            errMsg = Error_Message;
            errCode = Error_Code;
        }
    }
}
