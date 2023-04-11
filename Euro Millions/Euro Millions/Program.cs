using Euro_Millions;


// Set a title
Console.Title = "Lotto Generator";


// Instantiate the lottogenerator
LottoGenerator lottoGenerator = new();


// Wait for user commanding the start
Console.WriteLine("PRESS ENTER TO START THE LOTTOMACHINE");
Console.ReadLine();
Console.WriteLine("YOUR NUMBERS FOR THIS SESSION:");


#region Assign random values

// Return hashsets of normal and special values randomly generated
Tuple<HashSet<int>, HashSet<int>> SelectionOfToday = lottoGenerator.GenerateRandomValues();

// Assign normal values
HashSet<int> NormalNumbers = SelectionOfToday.Item1;

// Assign special values
HashSet<int> SpecialNumbers = SelectionOfToday.Item2;

#endregion Assign random values


#region Assign conversation string

// Return string of normal and special string for the conversation
Tuple<string, string> Selections = lottoGenerator.ShowSelection(NormalNumbers, SpecialNumbers);

// Assign normal string
string SelectionNormal = Selections.Item1;

// Assign special string
string SelectionSpecial = Selections.Item2;

#endregion Assign conversation string


// Print selection to console
Console.WriteLine($"Normal: {SelectionNormal}\nSpecial: {SelectionSpecial}");


while (true) Console.ReadLine();