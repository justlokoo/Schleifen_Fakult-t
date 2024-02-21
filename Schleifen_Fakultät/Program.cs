using System; 

class Program // Definiert eine Klasse. Dies ist eine Container-Klasse für die Ausführungslogik des Programms.
{
    static void Main() // Die Main-Methode ist der Einstiegspunkt des Programms. 'static' bedeutet, dass diese Methode auf Klassenebene und nicht auf Instanzebene existiert. 'void' zeigt an, dass diese Methode keinen Wert zurückgibt.
    {
        Console.WriteLine("Fakultät berechnen\n"); // Gibt eine Zeile Text auf der Konsole aus, die das Programm einführt.
        Console.WriteLine("Bitte geben Sie eine Zahl ein:"); // Fordert den Benutzer auf, eine Zahl einzugeben.
        
        int n = Convert.ToInt32(Console.ReadLine()); // Liest die Benutzereingabe, konvertiert sie in einen Integer und weist sie der Variablen 'n' zu.
        long fakultaet = 1; // Initialisiert die Variable 'fakultaet' mit 1. 'long' wird verwendet, um große Ergebnisse speichern zu können.
        
        Console.WriteLine("\nBerechnung:"); // Gibt eine Überschrift für die folgende Berechnung aus.
        for (int i = 1; i <= n; i++) // Eine Schleife, die von 1 bis 'n' läuft. 'i' wird in jedem Schritt um 1 erhöht.
        {
            fakultaet *= i; // Multipliziert 'fakultaet' mit 'i' bei jedem Durchlauf der Schleife.
            Console.WriteLine($"{i}! = {fakultaet}"); // Zeigt die Zwischenergebnisse der Fakultätsberechnung.
        }
        
        Console.WriteLine($"\nDie Fakultät von {n} lautet {fakultaet}"); // Gibt das Endergebnis der Fakultätsberechnung aus.

        Console.WriteLine("\nDrücken Sie eine beliebige Taste, um das Programm zu beenden."); // Taste drücken um das Programm zu beenden.
        Console.ReadKey(); 
    }
}
