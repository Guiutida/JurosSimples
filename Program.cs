﻿double capital, juros, tempo, total;

Console.Clear();

Console.WriteLine("Capital [c] (R$).......:");
capital = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Taxa de juros [i] (%)..:");
juros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Tempo [t] (meses)......:");
tempo = Convert.ToDouble(Console.ReadLine());
 
 juros = capital * (juros/100) * tempo;

total = capital + juros;
    Console.WriteLine($"Juros (R$).....: {juros}");
    Console.WriteLine($"Montante (R$)..: {total}");
    Console.WriteLine("obrigado!");
