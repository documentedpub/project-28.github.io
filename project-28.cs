int periodLocation = 0;
string myString = "";
string mySentence = "";

string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation +1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        System.Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    System.Console.WriteLine(mySentence);
}
