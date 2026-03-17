1. Fast-Forward jest wykonywany, gdy gałąź docelowa nie zmieniła się od momentu odgałęzienia nowej gałęzi roboczej. Nie trzeba wtedy nic scalać tylko przesunąć wskaźniki gałęzi głównej do przodu na najnowszym commicie.
   Mege commit jest, gdy na oby gałęziach pojawiły się niezależne, nowe zmiany.
2. W praktyce merge łączy gałęzie, tworząc nowy commit łączący, co zacxhowuje prawdziwą, historię rozgałęzień, która czasem jest skomplikowana. Rebase jakby przepisuje historie, przenosi commity z bocznej gałęzi
na sam szczyt gałęzi głównej, tworząc prostą historię bez dodatkowych commitów.
