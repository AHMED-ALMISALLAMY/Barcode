using System;
namespace Barcode.BL
{
    public class Item
    {

        #region variables

        public int CategoryNumber { get; set; }

        public decimal ItemPrice { get; set; }

        public int ItemNumber { get; set; }

        public string ItemName { get; set; }
        #endregion



        #region Methods

        public string GetFormatedCategoryNumber(int number)
        {
            string NewNumber = number.ToString();

            string returnedNumber = string.Empty;

            for (int i = 0; i < 3 - NewNumber.Length; i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }


        public string GetFormatedItemPrice(decimal number)
        {
            string NewNumber = number.ToString();

            string returnedNumber = string.Empty;

            for (int i = 0; i < 5 - NewNumber.Length;i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }


        public string GetFormatedItemNumber(int number)
        {
            string NewNumber = number.ToString();

            string returnedNumber = string.Empty;

            for (int i = 0; i < 5 - NewNumber.Length;i++)
            {
                returnedNumber += "0";
            }
            return returnedNumber + NewNumber;
        }
        #endregion
    }
}
