<Query Kind="Program" />

// Program zamieniajacy stopy na cale

class stopy_na_cale  // definiowanie klasy
{
	static int zamiana(int stopy) // metoda o typie liczby calkowitej
	{
		int nowy = stopy *12;
		return nowy;
	}
	static void Main() // metoda glowna 
	{
		Console.WriteLine(zamiana(10));
		Console.WriteLine(zamiana(20));
		Console.WriteLine(zamiana(30));
	}
}