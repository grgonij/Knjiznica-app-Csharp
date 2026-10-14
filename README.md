# Evidencija knjižnice

Jednostavna desktop aplikacija za vođenje evidencije knjiga, izrađena u C#-u i Windows Formsu kao projektni zadatak iz kolegija *C# programiranje* (Veleučilište u Bjelovaru).

## Mogućnosti

- Dodavanje fizičkih knjiga i e-knjiga (s formatom datoteke)
- Posuđivanje i vraćanje knjiga uz provjeru dostupnosti
- Označavanje knjiga kao pročitanih
- Filtriranje popisa (prikaz samo dostupnih knjiga)
- Dvoklik na knjigu otvara prozor s detaljima (naslov, autor, ISBN, format, posuđena, pročitana)
- Automatsko spremanje i učitavanje podataka iz JSON datoteke

## Tehnologije

- C# / .NET 8
- Windows Forms
- `System.Text.Json` za serijalizaciju
- `async` / `await` za rad s datotekama

## Struktura projekta

```
KnjiznicaApp/
├── Models/          Knjiga, EKnjiga, IPosudivo, ISBNInfo
├── Exceptions/      KnjigaNijeDostupnaException
├── Services/        KnjigaRepozitorij (spremanje/učitavanje JSON-a)
├── MainForm.cs      glavni prozor s popisom knjiga
├── AddBookForm.cs   prozor za dodavanje knjige
├── BookDetailsForm.cs  prozor s detaljima o knjizi
└── Program.cs
```

## Primijenjeni OOP koncepti

| Koncept | Gdje |
|---|---|
| Nasljeđivanje | `EKnjiga : Knjiga` |
| Virtualna metoda i override | `PrikaziInfo()` |
| Sučelje | `IPosudivo` |
| Enkapsulacija | svojstvo `Dostupna` (`private set`) |
| Struktura | `ISBNInfo` |
| Prilagođena iznimka | `KnjigaNijeDostupnaException` |
| Generička kolekcija | `List<Knjiga>` |

## Pokretanje

1. Otvori `KnjiznicaApp.csproj` u Visual Studiju 2022.
2. Pokreni projekt (F5).

Podaci se spremaju u datoteku `knjige.json` uz izvršnu datoteku aplikacije.
