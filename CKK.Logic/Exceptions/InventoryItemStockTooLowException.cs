namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException : Exception
    {
        string errMsg;
        int errCode;
        public InventoryItemStockTooLowException()
        {
            errMsg = "No error message provided";
            errCode = 0x1;
        }

        public InventoryItemStockTooLowException(string Error_Message, int Error_Code)
        {
            errMsg = Error_Message;
            errCode = Error_Code;
        }
    }
}
