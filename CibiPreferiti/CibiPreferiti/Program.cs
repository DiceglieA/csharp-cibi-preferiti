//- La lunghezza della classifica
string[] cibiPreferiti = { "Carne", "Pesce", "Pasta", "Verdura" };
Console.WriteLine("la lunghezza della classifica è " + cibiPreferiti.Length);

//- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
for ( int i = 0; i < cibiPreferiti.Length; i++ )
{
    Console.WriteLine( (i) + cibiPreferiti[i] );
}

// -Il vostro cibo top (prima posizione della classifica)

Console.WriteLine("il primo in classifica è " + cibiPreferiti[0]);

//- Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

Console.WriteLine("L'ultimo in classifica è " + cibiPreferiti[3]);

//il cibo di mezza classifica

Console.WriteLine("A metà classifica c'è " + cibiPreferiti[cibiPreferiti.Length / 2]);

