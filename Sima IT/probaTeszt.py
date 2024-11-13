
import random

def saving(filename, var1, var2):
    with open(filename, 'w') as file:
        # Az értékeket egy sorba írjuk, vesszővel elválasztva
        file.write(f"{var1},{var2}\n")

def loading(filename):
    with open(filename, 'r') as file:
        # Beolvassuk az egyetlen sort és szétválasztjuk a változókat
        line = file.readline()
        var1, var2 = line.strip().split(',')
        # Visszaadjuk a kettő változót megfelelő típusban
        return var1, var2

def startUp():
    
    global mp
    global ov
    mp = 50
    ov = 50

    print("Üdvözlünk a játékban!")
    ujvagynem = int(input("Új játékot kezdesz?""\n""1: Igen!\n2: Nem, a savedata betöltése!\n"))
    ujvagynemEldontott = False
    while ujvagynemEldontott != True:
        if ujvagynem == 1:
            print("Magyar Péter támogatottsága: ", mp, "\n" + "Orbán Viktor támogatottsága: ", ov)
            break
            
        else:
            mp, ov = loading("savedata.txt")
            print("Magyar Péter támogatottsága: ", mp, "\n" + "Orbán Viktor támogatottsága: ", ov)
            break
            

def Szavazas():
    

    szavazatok = {
        "Magyar Péter": mp,
        "Orbán Viktor": ov
    }

    # Összes szavazat számítása
    osszes_szavazat = sum(szavazatok.values())

    # Százalékos eredmények kiszámítása
    szazalekok = {}
    for fel, szavazat in szavazatok.items():
        szazalekok[fel] = (szavazat / osszes_szavazat) * 100

    # Ha szükséges, korrekciós faktor alkalmazása, hogy pontosan 100%-ot kapjunk
    ossz_szazalek = sum(szazalekok.values())
    if ossz_szazalek != 100:
        korrekcio = 100 / ossz_szazalek
        for fel in szazalekok:
            szazalekok[fel] *= korrekcio

    # Eredmények kiíratása
    for fel, szazalek in szazalekok.items():
        print(f"{fel}: {szazalek:.2f}%")



startUp()
print("Elért a végére a program.")
input()


print("\n")
#Szavazas()
saving("savedata.txt", mp, ov)






























#Tippek



# Mentés
#saving("savedata.txt", a, b, c)

# Betöltés
#loaded_a, loaded_b, loaded_c = loading("savedata.txt")
#print(loaded_a, loaded_b, loaded_c)

#proba = (loaded_a)
#print(proba)