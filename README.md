Opis projekta

Projekt RestavracijaGUI je namizna aplikacija, razvita v programskem jeziku C#. Predstavlja preprosto simulacijo delovanja restavracije, kjer uporabnik upravlja z izdelki in naročili. Aplikacija je namenjena prikazu osnovnih principov objektno usmerjenega programiranja ter dela z grafičnim uporabniškim vmesnikom (Windows Forms).

Namen projekta

Glavni namen projekta je bil:

prikaz uporabe objektno usmerjenega programiranja (razredi, objekti, lastnosti, metode),
razviti osnovni grafični uporabniški vmesnik,
povezati logiko programa z uporabniškimi dejanji (dogodki),
prikazati praktičen primer uporabe programiranja v realnem okolju (restavracija).
Funkcionalnosti

Aplikacija omogoča:

dodajanje izdelkov (npr. jedi ali pijače),
ustvarjanje naročil,
prikaz seznama naročenih izdelkov,
izračun skupne cene naročila,
odstranjevanje izdelkov iz naročila.
Struktura projekta

Projekt je sestavljen iz več ključnih delov:

Model (razredi)

V tem delu so definirani razredi, ki predstavljajo osnovne podatke:

Izdelek (ime, cena),
Naročilo (seznam izdelkov, skupna cena),
po potrebi tudi Cenik ali podobni pomožni razredi.
Uporabniški vmesnik (GUI)

Grafični vmesnik je izdelan z uporabo Windows Forms. Vključuje:

obrazec (Form),
gumbe za dodajanje in odstranjevanje,
seznam (npr. ListBox) za prikaz naročila.
Programska logika

Ta del povezuje uporabniški vmesnik z razredi. Vključuje:

obdelavo klikov na gumbe,
dodajanje in odstranjevanje elementov,
izračun skupne cene.
Uporabljene tehnologije
C#
.NET (Windows Forms)
Visual Studio
Zagon aplikacije
Projekt odpri v programu Visual Studio.
Zaženi aplikacijo s tipko F5 ali gumbom Start.
Odpre se okno aplikacije, kjer lahko začneš z uporabo.
Možne nadgradnje
povezava z bazo podatkov,
shranjevanje naročil,
dodajanje uporabniških računov,
izboljšan uporabniški vmesnik,
dodatne funkcionalnosti (filtri, statistika).
