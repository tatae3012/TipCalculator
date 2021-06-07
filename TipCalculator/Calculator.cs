namespace TipCalculator
{
    // Class Calculator provides properties and metods to calculate final tip and bill amount
    // and two public functions that are used to access the calculated tip and bill amount.
    //START
    class Calculator
    {
        // The amount of bill generated.
        private double _bill;
        // The percentage of tip to be distributed.
        private double _tipPercent;
        // The number of people present.
        private int _count;         

        // Constuctor Calculator initializes the data with input values.
        public Calculator(double billText, double tipPercentText, int countText)
        {
            this._bill = billText;
            this._tipPercent = tipPercentText;
            this._count = countText;
        }

        // The method CalculateTipAmount calculates and returns the total tip amount to be distributed.
        private double CalculateTipAmount()
        {
            double tipAmount = (this._tipPercent / 100) * this._bill;
            return tipAmount;
        }

        // The method CalculateTipPerPerson calculates and returns the tip amount to be paid by each person.
        private double CalculateTipPerPerson()
        {
            double tipAmount = CalculateTipAmount();
            double tipPerPerson = tipAmount / this._count;
            return tipPerPerson;
        }

        // The method CalculateBillPerPerson calculates and returns the bill amount to be paid by each person.
        private double CalculateBillPerPerson()
        {
            double tipAmount = CalculateTipAmount();
            double sum = this._bill + tipAmount;
            double total = sum / this._count;
            return total;
        }

        // The public method TipPerPerson returns calculated tip per person to object calls from same 
        // as well as other classes.
        public double TipPerPerson()
        {
            double tipR = CalculateTipPerPerson();
            return tipR;
        }

        // The public method BillPerPerson returns calculated bill per person to object calls from same 
        // as well as other classes.
        public double BillPerPerson()
        {
            double billR = CalculateBillPerPerson();
            return billR;
        }
    } // END
}
