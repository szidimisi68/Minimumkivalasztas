import time
import random
szamok_darab = int(input("Hány darab szám generálódjon?: "))
legnagyobb_generalhato_szam = int(input("Mekkora legyen a legnagyobb lehetséges szám?: "))
vizsgalando_szamok = [random.randint(1, legnagyobb_generalhato_szam) for szam in range(szamok_darab)]
print("A generált számsor:", end=" ")
print(*vizsgalando_szamok)


def minimum_kivalasztas(szamok):
    ciklus_kezdeti_ideje = time.time_ns()
    for i in range(len(szamok)-1):
        minimum = i
        for j in range(i+1, len(szamok)):
            if szamok[minimum] > szamok[j]:
                minimum = j
        szamok[i], szamok[minimum] = szamok[minimum], szamok[i]
    return szamok, time.time_ns() - ciklus_kezdeti_ideje


eredmeny = minimum_kivalasztas(vizsgalando_szamok)
print("A rendezett számsor:", end=" ")
print(*eredmeny[0])
print(f"\nRendezési idő: {eredmeny[1] / 1000000000} mp")
