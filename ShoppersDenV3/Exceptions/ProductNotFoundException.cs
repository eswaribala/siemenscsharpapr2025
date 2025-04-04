namespace ShoppersDenV3.Exceptions
{
    [Serializable]
    internal class ProductNotFoundException : ApplicationException
    {
        public ProductNotFoundException()
        {
        }

        public ProductNotFoundException(string message) : base(message)
        {
        }

        public ProductNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}