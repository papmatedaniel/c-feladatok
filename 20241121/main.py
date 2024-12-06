class Versenyzo:
    def __init__(self, egysor):
        darabok = egysor.strip().split('\t')
        self.helyezes = int(darabok[0])
        self.neve = darabok[1]
        self.iskola = darabok[2]
        self.telepules = darabok[3]
        self.eredmeny = int(darabok[4])
        self.szakmacsoport = darabok[5]


def f1():
    with open("eredmenyek.txt", "r", encoding="utf-8") as file:
        return [Versenyzo(i) for i in file]


def f2():
    print(f"Versenyzők száma: {len(versenyzok)}")


def f3():
    statisztika = {}
    for i in versenyzok:
        statisztika[i.szakmacsoport] = statisztika.get(i.szakmacsoport, 0) + 1
    for i in statisztika.items():
        print(i)


def f4():
    for i in versenyzok:
        if i.szakmacsoport == "gépész":
            with open("gepesz.txt", "a", encoding="utf-8") as file1:
                file1.write(f"{i.neve}\t{i.iskola}\t{i.telepules}\n")
        if i.szakmacsoport == "környezetvédelem":
            with open("kvedelem.txt", "a", encoding="utf-8") as file1:
                file1.write(f"{i.neve}\t{i.iskola}\t{i.telepules}\n")


def f5():
    for i in versenyzok:
        if i.neve.split()[1] == "Ábrahám":
            print(f"{i.helyezes} {i.neve} {i.iskola} {i.telepules} {i.eredmeny} {i.szakmacsoport}")


def f6():
    dobogosok = {"gépész":[], "informatika":[], "környezetvédelem":[]}
    for i in versenyzok:
        dobogosok[i.szakmacsoport].append((i.neve, i.helyezes))

    for i in dobogosok.keys():
        dobogosok[i] = sorted(dobogosok[i], key=lambda x: x[1])
        print(f"{i} - {dobogosok[i][1][0]}")


def f7():
    print(f"Egerből {sum([1 for i in versenyzok if i.telepules == 'Eger'])} db. versenyző volt")


def f8():
    bpstatisztika = {}
    for i in versenyzok:
        if i.telepules == "Budapest":
            bpstatisztika[i.szakmacsoport] = bpstatisztika.get(i.szakmacsoport, 0) + 1
    for i in bpstatisztika.items():
        print(f"{i[0]} - {i[1]}")


def f9():
    bpvagyvidek = 0
    for i in versenyzok:
        if i.szakmacsoport == "környezetvédelem":
            if i.telepules == "Budapest":
                bpvagyvidek += 1
            else:
                bpvagyvidek -= 1
    if bpvagyvidek > 0:
        print("Budapesten voltak többen")
    else:
        print("Vidéken voltak többen")


def f10():
    bptop, kptop = [], []
    for i in versenyzok:
        if i.iskola == "Eötvös":
            if i.telepules == "Budapest":
                bptop.append((i.neve, i.helyezes))
            else:
                kptop.append((i.neve, i.helyezes))

    print(f"Budapesti  Eötvös legjobbja: {max(bptop, key=lambda x: x[1])[0]}")
    print(f"Kaposvári  Eötvös legjobbja: {max(kptop, key=lambda x: x[1])[0]}")


def f11():
    for i in versenyzok:
        if i.iskola == "Bláthy":
            print(f"{i.eredmeny} {i.helyezes} {i.iskola} {i.neve} {i.szakmacsoport} {i.telepules}")


def f12():
    [print(i) for i in {i.szakmacsoport for i in versenyzok}]


def f13():
    csongszakhelyezesek = {"informatika":[], "gépész":[], "környezetvédelem":[]}
    for i in versenyzok:
        if i.telepules == "Csongrád":
            csongszakhelyezesek[i.szakmacsoport].append(i.helyezes)
    for i in csongszakhelyezesek.items():
        print(f"{i[0]} - {i[1]}")


def f14():
    print(f"A budapesti Eötvös iskolából: {sum([1 for i in versenyzok if i.iskola == 'Eötvös' and i.telepules == 'Budapest' and i.szakmacsoport == 'környezetvédelem'])} diák indult.")


def f15():
    for i in versenyzok:
        if i.telepules == "Dombóvár":
            print(f"Dombóvár: {i.neve}")
        if i.telepules == "Püspökladány":
            print(f"Püspökladány: {i.neve}")


def f16():
    ganziskola = ["", 0]
    for i in versenyzok:
        if i.iskola == "Ganz":
            ganziskola[0] = i.telepules
            ganziskola[1] += 1
    print(f"Ganz iskola {ganziskola[0]} településen van és {ganziskola[1]} diák jár")


def f17():
    legjobbszalek = ["", "", "", 0]
    for i in versenyzok:
        if i.eredmeny > legjobbszalek[3]:
            legjobbszalek[3] = i.eredmeny
            legjobbszalek[2] = i.neve
            legjobbszalek[1] = i.iskola
            legjobbszalek[0] = i.szakmacsoport
    print(f"A legjobb %-os eredményt: {legjobbszalek[2]} érte el, iskolája: {legjobbszalek[1]} szakmacsoport: {legjobbszalek[0]}")


def f18():
    molnarvagynagy = 0
    for i in versenyzok:
        if i.neve.split()[0] == "Molnár":
            molnarvagynagy += 1
        if i.neve.split()[0] == "Nagy":
            molnarvagynagy += 1
    if molnarvagynagy > 0:
        print("Molnár vezetélnevűből több diák van")
    else:
        print("Nagy vezetélnevűből több diák van")


def f19():
    print(f"Összen {len({i.iskola for i in versenyzok})} iskolából voltak")


def f20():
    legtobben = {}
    for i in versenyzok:
        legtobben[i.iskola] = legtobben.get(i.iskola, 0) + 1
    print(f"A legtöbben a {max(legtobben, key=lambda x: legtobben[x])} iskolából jöttek")



if __name__ == "__main__":
    versenyzok = f1()
    f2()
    f3()
    f4()
    f5()
    f6()
    f7()
    f8()
    f9()
    f10()
    f11()
    f12()
    f13()
    f14()
    f15()
    f16()
    f17()
    f18()
    f19()
    f20()
    input("\nNyomj entert: ")