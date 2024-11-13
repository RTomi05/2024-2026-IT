
"""


# Mentés funkció
def save_data(filename, data):
    with open(filename, 'w') as file:
        file.write(data)

# Betöltés funkció
def load_data(filename):
    with open(filename, 'r') as file:
        return file.read()

# Tesztelés
save_data("data.txt", "Ez egy minta adat.")
print(load_data("data.txt"))

# Betöltés egy szövegrész alapján
def load_line_by_keyword(filename, keyword):
    with open(filename, 'r') as file:
        for line in file:
            if keyword in line:  # Ha a kulcsszó szerepel a sorban
                return line.strip()  # Visszaadja azt a sort
    return "A keresett kifejezés nem található."

# Tesztelés
save_data("data.txt", "Ez egy teszt szöveg.")
ezkell = load_line_by_keyword("data.txt", "hoppá")  # Kiválasztja az első sort, ha "teszt" szerepel benne
print(ezkell)

"""

def saving(filename, var1, var2, var3):
    with open(filename, 'w') as file:
        # Az értékeket egy sorba írjuk, vesszővel elválasztva
        file.write(f"{var1},{var2},{var3}\n")

def loading(filename):
    with open(filename, 'r') as file:
        # Beolvassuk az egyetlen sort és szétválasztjuk a változókat
        line = file.readline()
        var1, var2, var3 = line.strip().split(',')
        # Visszaadjuk a három változót megfelelő típusban
        return var1, var2, var3

# Tesztelés
a = 10
b = 20.5
c = "Hello"

# Mentés
saving("variables.txt", a, b, c)

# Betöltés
loaded_a, loaded_b, loaded_c = loading("variables.txt")
print(loaded_a, loaded_b, loaded_c)

proba = (loaded_a)
print(proba)

print("JÓ!")
