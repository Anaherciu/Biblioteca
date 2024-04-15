# Proiect_Biblioteca

Aplicatie de gestionare a unei biblioteci , care contine urmatoarele componente:
- Document.cs,
- Book.cs,
- Magazine.cs
Aceste clase definesc modelele de baza pentru documente, carti si reviste.
Fiecare document are un titlu (Title), iar cartile au si un autor (Author), iar revistele au un nr de editie (IssueNumber).
Clasele cartilor si revistelor extind clasa de baza Document, mostenindu-i proprietatile si adaugandu-le pe cele specifice.

Factory Pattern
- DocumentFactory.cs 
Clasa DocumentFactory ofera o metoda statica CreateDocument, care primeste un tip (T) si alte argumente necesare pentru a crea un document de tipul specificat.
In functie de tipul specificat (Book sau Magazine), se creeaza si se returneaza instante corespunzatoare.

Strategy Pattern
- SortByAuthor.cs
- SortByTitle.cs
- SortStrategy.cs
Interfata ISortStrategy defineste o metoda Sort, iar clasele SortByAuthor si SortByTitle sunt 2 strategii diferite de sortare .
Implementarile acestor clase definesc modul in care documentele sunt sortate in functie de autor sau titlu. 
