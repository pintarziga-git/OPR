# Poročilo testiranja – RestavracijaGUI

**Projekt:** RestavracijaGUI  
**Avtor:** Žiga Pintar  
**Datum testiranja:** 13. 3. 2026  
**Okolje:** Visual Studio 2022, .NET Framework 4.7.2, Windows 11  

---

## 1. Namen testiranja

Namen poročila je dokumentirati ročno funkcionalno testiranje aplikacije RestavracijaGUI. Testirane so bile vse ključne funkcionalnosti: dodajanje in odstranjevanje postavk, upravljanje več miz, izračun zneskov ter zaključevanje računov s popustom.

---

## 2. Testni primeri

### Test 1 – Zagon aplikacije

| Polje | Vrednost |
|---|---|
| **ID testa** | T01 |
| **Naziv** | Zagon aplikacije |
| **Opis** | Aplikacija se odpre brez napak, meni je napolnjen, miza 1 je privzeto izbrana |
| **Koraki** | 1. Odpri rešitev v VS 2022. 2. Pritisni F5. |
| **Pričakovani rezultat** | Prikaže se okno Form1 z menijem (7 postavk), naročilo je prazno, ComboBox kaže mizo 1. |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 2 – Dodajanje jedi v naročilo

| Polje | Vrednost |
|---|---|
| **ID testa** | T02 |
| **Naziv** | Dodaj jed iz menija |
| **Opis** | Klik na jed v meniju in gumb Dodaj doda postavko v naročilo |
| **Koraki** | 1. Klikni na "Hamburger" v meniju. 2. Klikni gumb **Dodaj**. |
| **Pričakovani rezultat** | V listBoxNarocilo se pojavi "Hamburger x 1 = 7.20 €". Skupaj: 7.20 €, Z DDV: 8.78 €. |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 3 – Večkratno dodajanje istega izdelka

| Polje | Vrednost |
|---|---|
| **ID testa** | T03 |
| **Naziv** | Povečanje količine obstoječe postavke |
| **Opis** | Ponoven klik na isti izdelek in Dodaj poveča količino, ne doda nove vrstice |
| **Koraki** | 1. Dodaj "Voda" dvakrat. |
| **Pričakovani rezultat** | V naročilu je samo ena vrstica "Voda x 2 = 3.00 €". |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 4 – Odstranjevanje postavke (zmanjšanje količine)

| Polje | Vrednost |
|---|---|
| **ID testa** | T04 |
| **Naziv** | Zmanjšaj količino postavke |
| **Opis** | Klik na postavko z količino > 1 in Odstrani zmanjša količino za 1 |
| **Koraki** | 1. Dodaj "Sok" trikrat. 2. Klikni na "Sok x 3" v naročilu. 3. Klikni gumb **Odstrani**. |
| **Pričakovani rezultat** | Postavka postane "Sok x 2 = 4.40 €". |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 5 – Popolna odstranitev postavke

| Polje | Vrednost |
|---|---|
| **ID testa** | T05 |
| **Naziv** | Odstrani postavko z količino 1 |
| **Opis** | Klik na postavko z količino 1 in Odstrani jo v celoti izbriše iz naročila |
| **Koraki** | 1. Dodaj "Kava" enkrat. 2. Klikni na "Kava x 1". 3. Klikni **Odstrani**. |
| **Pričakovani rezultat** | Postavka "Kava" izgine iz listBoxNarocilo. |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 6 – Upravljanje naročil na več mizah

| Polje | Vrednost |
|---|---|
| **ID testa** | T06 |
| **Naziv** | Neodvisna naročila za različne mize |
| **Opis** | Naročilo vsake mize se hrani ločeno |
| **Koraki** | 1. Na mizi 1 dodaj "Pica Klasika". 2. Preklopi na mizo 3. 3. Dodaj "Solata". 4. Preklopi nazaj na mizo 1. |
| **Pričakovani rezultat** | Miza 1 kaže "Pica Klasika x 1", miza 3 kaže "Solata x 1". |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 7 – Novo naročilo

| Polje | Vrednost |
|---|---|
| **ID testa** | T07 |
| **Naziv** | Gumb Novo naročilo pobriše obstoječe naročilo |
| **Opis** | Klik na Novo naročilo ustvari novo prazno naročilo za trenutno mizo |
| **Koraki** | 1. Dodaj nekaj postavk na mizo 2. 2. Klikni **Novo naročilo**. |
| **Pričakovani rezultat** | Naročilo je prazno, skupaj kaže 0.00 €, številka naročila se poveča. |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 8 – Izračun z DDV

| Polje | Vrednost |
|---|---|
| **ID testa** | T08 |
| **Naziv** | Pravilen izračun DDV (22 %) |
| **Opis** | Preveriti, da aplikacija pravilno izračuna znesek z 22 % DDV |
| **Koraki** | 1. Dodaj "Hamburger" (7.20 €) in "Sok" (2.20 €). Skupaj: 9.40 €. |
| **Pričakovani rezultat** | Z DDV: 9.40 × 1.22 = 11.47 € |
| **Dejanski rezultat** | ✅ Prikazano: 11.47 € |
| **Status** | **USPEŠNO** |

---

### Test 9 – Zaključek računa z 10 % popustom

| Polje | Vrednost |
|---|---|
| **ID testa** | T09 |
| **Naziv** | Račun s popustom |
| **Opis** | Zaključevanje računa s 10 % popustom prikaže pravilen končni znesek |
| **Koraki** | 1. Dodaj "Pica Margerita" (8.50 €). 2. Nastavi popust 10 %. 3. Klikni **Zaključi račun**. |
| **Pričakovani rezultat** | Skupaj: 8.50 €, Z DDV: 10.37 €, Popust: 10 %, Končna cena: 9.33 € |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim. |
| **Status** | **USPEŠNO** |

---

### Test 10 – Zaključek računa brez postavk

| Polje | Vrednost |
|---|---|
| **ID testa** | T10 |
| **Naziv** | Račun praznega naročila |
| **Opis** | Zaključevanje računa na praznem naročilu ne povzroči napake |
| **Koraki** | 1. Ne dodaj nobene postavke. 2. Klikni **Zaključi račun**. |
| **Pričakovani rezultat** | Prikaže se sporočilo z vsemi vrednostmi 0.00 €. |
| **Dejanski rezultat** | ✅ Prikaže se račun: 0.00 €, brez napake. |
| **Status** | **USPEŠNO** |

---

### Test 11 – Dodajanje brez izbire v meniju

| Polje | Vrednost |
|---|---|
| **ID testa** | T11 |
| **Naziv** | Klik Dodaj brez izbrane postavke |
| **Opis** | Gumb Dodaj brez izbire v meniju ne povzroči napake |
| **Koraki** | 1. Ne izberi ničesar v meniju. 2. Klikni **Dodaj**. |
| **Pričakovani rezultat** | Naročilo ostane nespremenjeno, brez napake ali izjeme. |
| **Dejanski rezultat** | ✅ Skladno s pričakovanim (metoda preveri `SelectedItem == null`). |
| **Status** | **USPEŠNO** |

---

### Test 12 – Vmesnik ICenik prek polimorfizma

| Polje | Vrednost |
|---|---|
| **ID testa** | T12 |
| **Naziv** | Uporaba vmesnika ICenik |
| **Opis** | Objekt tipa Racun je dostopen prek referenčnega tipa ICenik |
| **Koraki** | Interno (koda v `buttonZakljuciRacun_Click`): `ICenik cenik = r; decimal znesek = cenik.KoncnaCena();` |
| **Pričakovani rezultat** | Metoda `KoncnaCena()` se pokliče prek vmesnika brez napake. |
| **Dejanski rezultat** | ✅ Koda se izvede brez izjeme, polimorfizem deluje. |
| **Status** | **USPEŠNO** |

---

## 3. Povzetek rezultatov

| Skupaj testov | Uspešnih | Neuspešnih |
|---|---|---|
| 12 | **12** | **0** |

---

## 4. Ugotovitve

Vsi testirani primeri so bili uspešni. Aplikacija pravilno:
- shranjuje naročila ločeno za vsako mizo,
- izvaja izračune z DDV in popustom,
- ščiti pred neveljavam vnosom (ni izbire v meniju, prazno naročilo),
- implementira OOP koncepte (dedovanje, polimorfizem, vmesnik).

Aplikacija je primerna za oddajo v okviru seminarske naloge OPR.
