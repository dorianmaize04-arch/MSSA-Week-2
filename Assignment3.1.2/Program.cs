/* If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false */
int YearNumber = 0;
bool IfYearIsLeap(int YearNumber)
{
  if (YearNumber % 400 == 0)
  {
    return true;

  }

  else if (YearNumber % 100 == 0)

  {
    return false;
  }
  
  else if (YearNumber % 4 == 0)
  {
    return true;
  }
  else
  {
    return false;
  }

}

Console.WriteLine(IfYearIsLeap(2024));




