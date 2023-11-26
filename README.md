# Ćwiczenia 26.11.2023 - Podstawy Programowania

## Zadanie 1
### Zadanie 2.1 - Twierdzenie Pitagorasa
Zaimplementuj twierdzenie Pitagorasa a^2+b^2=c^2. Oblicz długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych a = 3.5 i b = 6. Wynik obliczeń wyświetl w konsoli.

## Zadanie 2
### Zadanie 2.2 - Kalkulator BMI
Zaimplementuj kalkulator BMI (wskaźnik masy ciała, ang. body mass index) masa ciała [kg]/wzrost^2 [m]. Użytkownik jest proszony o podanie swojej wagi i wzrostu. Wynik obliczeń wyświetl w konsoli.

## Zadanie 3
### Zadanie 2.3 - Kantor
Zaimplementuj kalkulator walutowy. Sprawdź obecne kursy wymiany walut i zakoduj je na stałe. Użytkownik jest proszony o podanie kwoty w PLN oraz waluty docelowej (do wyboru EUR, CHF, GBP). Niech program najpierw przelicza kwotę na walutę pośrednią w USD, a następnie na walutę docelową. Wynik przewalutowania wyświetl w konsoli.

## Zadanie 4
### Zadanie 2.4 - Kontrola dostępu
Zasymuluj kontrolę dostępu do zasobów na podstawie wieku. Użytkownik jest proszony o podanie swojego wieku. Niech program na tej podstawie podejmie decyzję, czy użytkownik może dostać dostęp. Rozważ trzy przypadki:
- Jeżeli użytkownik ma +18 lat, niech program wypisze w konsoli "Access granted"
- Jeżeli użytkownik ma 15 - 18 lat, niech program zada dodatkowe pytanie "Do you have parental consent?". Jeżeli tak, niech program wypisze w konsoli "Access granted, jeżeli nie - "Access denied"
- Jeżeli użytkownik ma mniej niż 15 lat, niech program wypisze w konsoli "Access denied"

## Zadanie 5
### Zadanie 2.5 - Pierwiastki równania kwadratowego
Napisz program, który oblicza pierwiastki równania kwadratowego ax2 + bx + c = 0. Zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury przez użytkownika. Wszystkie zmienne wyświetl na ekranie z dokładnością do dwóch miejsc po przecinku.

## Zadanie 6 
### Zadanie 3.1 - Pętla for
Napisz program, który za pomocą pętli for dla danych wartości x zmieniających się w przedziale od 0 do 10 obliczy wartość funkcji y = root(3^2)*x. Wynik wyświetl w konsoli.
Uwaga: root() oznacza pierwiastek z liczby znajdującej się w nawiasie. Pamiętaj o prawidłowej kolejności wykonywania działań!

## Zadanie 7
### Zadanie 3.2 - Pętla while
Napisz aplikację z zastosowaniem pętli while, która będzie pobiera wartości liczbowe od użytkownika w zakresie 0-10, dopóki nie poda on wartości 5. Po wpisaniu przez użytkownika wartości 5, aplikacja powinna:
- obliczyć sumę wszystkich elementów podniesioną do kwadratu
- znaleźć najmniejszy element (minimum)

Wyniki obliczeń wypisz w konsoli.

## Zadanie 8
### Zadanie 3.3 - Pętla do ... while
Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite z przedziału od 1 do 20 podniesione do kwadratu. Wynik obliczeń wyświetl w konsoli.

## Zadanie 9
### Zadanie 3.4 - Pętla foreach
Wywołaj pętlę foreach na elementach `pets = {"cat", "dog", "parrot", "guinea pig"}`. Wyświetl elementy w konsoli. Jeżeli pętla trafi na element „dog”, niech program wyświetli komunikat „End” i wyjdzie z pętli.
- Uwaga 1: rozważ użycie instrukcji break
- Uwaga 2: nie wszystkie elementy zostaną wyświetlone w konsoli, ale możesz zastosować instrukcję continue by to zmienić

## Zadanie 10
### Zadanie 3.5 - Liczba Pi
Stwórz projekt w postaci aplikacji konsolowej.

Napisz program, który za pomocą metody Monte Carlo oblicza liczbę Pi z określoną dokładnością. Skorzystaj z rysunku pomocniczego i następującej listy kroków:

1. Wpisz koło o promieniu r w kwadrat o boku 2r
2. Losowo wygeneruj punkty i umieść je w kwadracie
3. Wyznacz liczbę punktów, które znajdują się jednocześnie w kwadracie i kole
4. Niech promień r będzie wyznaczony przez stosunek liczby punktów znajdujących się w kole do liczby punktów znajdujących się w kwadracie
5. Pi~4.0·r

Dodatkowo należy zmierzyć czas obliczeń sekwencyjnych.
