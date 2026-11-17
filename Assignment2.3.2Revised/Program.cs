/* Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

Use the format specifiers to display currency, % symbol. */
decimal billTotal = 0;
decimal grandTotal = 0;
decimal tipPercentage = 0;



Console.WriteLine("Please enter your bill amount:");
billTotal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please enter tip percentage number:");
tipPercentage = Convert.ToDecimal(Console.ReadLine());
tipPercentage = tipPercentage / 100;
Console.WriteLine($"Thank you for tipping {tipPercentage:P0}!");
grandTotal = TipCalculator(billTotal, tipPercentage);
Console.WriteLine($"Your grand total today was {grandTotal:C2}!");


Console.WriteLine("Have a nice day! Come again!");


 static decimal TipCalculator(decimal billTotal, decimal tipPercentage)
{

decimal grandTotal = 0;
grandTotal = (tipPercentage * billTotal) + billTotal;
return grandTotal;
}