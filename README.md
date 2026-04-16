# RestavracijaGUI 
 
Seminarska naloga za predmet OPR – 3. letnik
 
## Opis projekta
 
**RestavracijaGUI** je namizna aplikacija za upravljanje naročil v restavraciji, razvita v programskem jeziku C# z grafičnim vmesnikom Windows Forms (.NET Framework 4.7.2).
 
Aplikacija omogoča natakarjem, da:
- pregledajo meni restavracije (hrana in pijača),
- dodajajo in odstranjujejo jedi iz naročila,
- upravljajo naročila za do 10 miz hkrati,
- zaključijo račun z izbranim popustom in prikazom skupnega zneska z DDV.
Projekt je razdeljen na dve komponenti:
- **RestavracijaLib** – knjižnica razredov (logika aplikacije)
- **RestavracijaGUI** – Windows Forms aplikacija (grafični vmesnik)
---
 
## Struktura projekta
 
```
RestavracijaGUI/
├── RestavracijaGUI.sln          # Visual Studio rešitev
├── RestavracijaGUI/             # GUI projekt (Windows Forms)
│   ├── Form1.cs                 # Glavna forma – logika vmesnika
│   ├── Form1.Designer.cs        # Samodejno generirani GUI elementi
│   ├── Program.cs               # Vstopna točka aplikacije
│   └── RestavracijaGUI.csproj
├── RestavracijaLib/             # Knjižnica razredov
│   ├── Izdelek.cs               # Abstraktni razred za meniške postavke
│   ├── Hrana.cs                 # Podrazred za hrano
│   ├── Pijaca.cs                # Podrazred za pijačo
│   ├── Narocilo.cs              # Razred za naročilo mize
│   ├── PostavkaNarocila.cs      # Razred za posamezno postavko naročila
│   ├── Racun.cs                 # Razred za račun (deduje od Narocilo)
│   ├── ICenik.cs                # Vmesnik za izračun končne cene
│   └── RestavracijaLib.csproj
├── README.md
├── TehnicnaDokumentacija.xml
└── PorociloPestiranja.md
```
 
---
 
## Navodila za namestitev in poganjanje
 
### Zahteve
 
- **Visual Studio 2022
- **.NET Framework 4.7.2** (vgrajeno v Windows 10/11, ni potrebna ločena namestitev)
- Operacijski sistem: Windows
### Koraki
 
1. **Klonirajte repozitorij:**
   ```
   git clone https://github.com/pintarziga-git/OPR.git
   ```
 
2. **Odprite rešitev v Visual Studiu:**
   - Odprite datoteko `RestavracijaGUI.sln`
3. **Zgradite rešitev:**
   - V meniju izberite `Build → Build Solution` (ali pritisnite `Ctrl+Shift+B`)
4. **Zaženite aplikacijo:**
   - Pritisnite `F5` ali kliknite `Start`
> Nobenih dodatnih paketov (NuGet) ni potrebno namestiti. Projekt deluje takoj po kloniranju.
 
---
 
## Navodila za uporabo
 
### Glavno okno
 
Ob zagonu se odpre glavno okno aplikacije z naslednjimi elementi:
 
| Element | Opis |
|---|---|
| **Meni (zgornji seznam)** | Seznam vseh jedi in pijač restavracije |
| **Naročilo (spodnji seznam)** | Postavke trenutnega naročila za izbrano mizo |
| **Izbira mize** | Spustni meni za izbiro ene od 10 miz |
| **Izbira popusta** | Spustni meni za izbiro popusta (0%, 10%, 20%, 30%) |
| **Skupaj / Z DDV** | Prikaz trenutnega zneska naročila |
 
### Korak za korakom
 
1. **Izberite mizo** iz spustnega menija (1–10). Vsaka miza ima svoje naročilo.
2. **Dodajte jed ali pijačo:**
   - Kliknite na postavko v **meniju** (zgornji seznam)
   - Kliknite gumb **Dodaj**
   - Postavka se pojavi v naročilu; če je bila že dodana, se količina poveča
3. **Odstranite postavko:**
   - Kliknite na postavko v **naročilu** (spodnji seznam)
   - Kliknite gumb **Odstrani**
   - Če je količina > 1, se zmanjša za 1; sicer se postavka popolnoma odstrani
4. **Novo naročilo:**
   - Kliknite gumb **Novo naročilo**, da pobrišete trenutno naročilo za izbrano mizo
5. **Zaključek računa:**
   - Izberite popust iz spustnega menija
   - Kliknite gumb **Zaključi račun**
   - Prikaže se okno z računom: skupaj, z DDV, popust in končna cena
---
 
## OOP koncepti v projektu
 
| Koncept | Primer v kodi |
|---|---|
| **Abstraktni razred** | `Izdelek` – osnova za `Hrana` in `Pijaca` |
| **Dedovanje** | `Hrana : Izdelek`, `Pijaca : Izdelek`, `Racun : Narocilo` |
| **Polimorfizem** | Metoda `Opis()` se različno izvede v `Hrana` in `Pijaca` |
| **Vmesnik (interface)** | `ICenik` – zagotavlja metodo `KoncnaCena()` |
| **Enkapsulacija** | Lastnosti z get/set, zasebni člani |
| **static** | `stevec` v `Narocilo` za samodejno oštevilčevanje |
| **const** | `DDV = 0.22m` v `Narocilo` |
| **readonly** | `Ustvarjeno` (datum nastanka naročila) |
| **Indekser** | `this[int index]` v `Narocilo` |
| **Generične zbirke** | `List<Izdelek>`, `Dictionary<int, Narocilo>` |
 
---
 
## Avtor
 
Žiga Pintar, 3. letnik
