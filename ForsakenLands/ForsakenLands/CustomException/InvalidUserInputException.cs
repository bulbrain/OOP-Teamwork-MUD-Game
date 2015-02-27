namespace ForsakenLands.CustomException
{
    using System;

    public class InvalidUserInputException : ApplicationException
    {
        public InvalidUserInputException(string msg)
            : base(msg)
        {
        }

        public InvalidUserInputException(string msg, string name)
            : base(msg + " " + name)
        {
            this.ErrorName = name;
        }

        public string ErrorName { get; set; }
    }
}
