using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Sklep.Models;
using Sklep.Migrations;
using System.Data.Entity.Migrations;

namespace Sklep.DAL
{
    public class PrzedmiotInitializer : MigrateDatabaseToLatestVersion<PrzedmiotContext, Configuration>
    {

        public static void SeedPrzedmiotData(PrzedmiotContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() {KategoriaId=1, NazwaKategorii = "Płyty główne", NazwaPlikuIkony="plytyglowne.png", OpisKategorii="Płyta główna to jeden z pierwszych elementów, który montujemy w obudowie, podczas składania komputera PC. Do płyt głównych podłączane są wszystkie inne podzespoły i to one w dużej mierze determinuje możliwość późniejszego rozbudowania naszego zestawu. Z tego względu warto dobrze przemyśleć zakup konkretnego modelu – zdecydowanie lepiej skupić się na rozwiązaniach przyszłościowych. Jak wybrać płytę główną do komputera lub płytę główną do gier? Główna linia podziału biegnie między płytami głównymi kompatybilnymi z procesorami Intel lub dedykowanymi procesorom AMD."},
                new Kategoria() {KategoriaId=2, NazwaKategorii = "Karty graficzne", NazwaPlikuIkony="kartygraficzne.png", OpisKategorii="Karty graficzne odpowiadają za generowanie obrazu, który następnie może być wyświetlany na ekranie monitora lub telewizora. Właściwości obrazu zależą od zastosowanej karty graficznej oraz w mniejszym stopniu od pozostałych podzespołów komputera. Zaawansowane oprogramowanie graficzne oraz najnowsze gry będą wymagały zastosowania bardzo wydajnych układów."},
                new Kategoria() {KategoriaId=3, NazwaKategorii = "Karty dźwiękowe", NazwaPlikuIkony="kartydzwiekowe.png", OpisKategorii="Karty dźwiękowe to części PC, które odpowiadają za obsługę funkcji audio. Podzespoły określane też jako karty muzyczne czuwają nad odtwarzaniem i nagrywaniem dźwięku w komputerze. Choć płyty główne mają zintegrowane karty dźwiękowe, taka dodatkowa pozwala osiągnąć wyższą jakość audio i zapewnia zgodność z nowoczesnymi standardami."},
                new Kategoria() {KategoriaId=4, NazwaKategorii = "Dyski", NazwaPlikuIkony="dyski.png", OpisKategorii="Dyski zapewniają powierzchnię do przechowywania oprogramowania systemowego, dokumentów, multimediów i innych danych. Dzielimy je ze względu na typ nośnika, format nośnika oraz jego przeznaczenie. Modele należące do poszczególnych grup różnią się dodatkowo pojemnością."},
                new Kategoria() {KategoriaId=5, NazwaKategorii = "Myszki", NazwaPlikuIkony = "myszki.png", OpisKategorii="Urządzenie wskazujące używane podczas pracy z interfejsem graficznym systemu komputerowego."},
                new Kategoria() {KategoriaId=6, NazwaKategorii = "Klawiatury", NazwaPlikuIkony="laptop.png", OpisKategorii="Uporządkowany zestaw klawiszy służący do ręcznego sterowania urządzeniem lub ręcznego wprowadzania danych."}

            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var przedmiot = new List<Przedmiot>
            {
                new Przedmiot() {NazwaPrzedmiotu="ASUS H110M-K", ProducentPrzedmiotu="Asus", KategoriaId = 1, CenaPrzedmiotu = 209, Bestseller=true, NazwaPlikuObrazka="asus-h110m-k.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Standard płyty: micro-ATX. Gniazdo procesora: Socket 1151. Chipset płyty głównej: Intel H110"},
                new Przedmiot() {NazwaPrzedmiotu="MSI Z370-A PRO", ProducentPrzedmiotu="MSI", KategoriaId = 1, CenaPrzedmiotu = 469, Bestseller=true, NazwaPlikuObrazka="MSIZ370-APRO.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Standard płyty: ATX. Gniazdo procesora: Socket 1151. Chipset płyty głównej: Intel Z370"},
                new Przedmiot() {NazwaPrzedmiotu="Gigabyte X299 DESIGNARE EX", ProducentPrzedmiotu="MSI", KategoriaId = 1, CenaPrzedmiotu = 2149, Bestseller=true, NazwaPlikuObrazka="GigabyteX299.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Standard płyty: ATX. Gniazdo procesora: Socket 2066. Chipset płyty głównej: Intel X299"},
                new Przedmiot() {NazwaPrzedmiotu="NVIDIA GeForce GTX 1050 2GB", ProducentPrzedmiotu="MSI", KategoriaId = 2, CenaPrzedmiotu = 788, Bestseller=true, NazwaPlikuObrazka="NVIDIAGTX1050.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Typ złącza: PCI-Express x16, Szyna danych pamięci: 128bit, Typ zastosowanej pamięci: GDDR5 2048 MB"},
                new Przedmiot() {NazwaPrzedmiotu="Sapphire Radeon RX 580 4G NITRO+", ProducentPrzedmiotu="Asus", KategoriaId = 2, CenaPrzedmiotu = 1512, Bestseller=true, NazwaPlikuObrazka="Radeon-RX580NITRO+.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Typ złącza: PCI-Express x16, Szyna danych pamięci: 256bit, Typ zastosowanej pamięci: GDDR5 4096 MB"},
                new Przedmiot() {NazwaPrzedmiotu="Creative Sound Blaster ZxR", ProducentPrzedmiotu="Creative", KategoriaId = 3, CenaPrzedmiotu = 641, Bestseller=true, NazwaPlikuObrazka="Blaster-ZxR.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Sztandarowa, wysokiej wydajności karta dźwiękowa PCIe. Najwyzsza jakosc dzwieku podczas sluchania i tworzenia muzyki dzieki technologii Sound Blaster i komponentom o jakosci studyjnej."},
                new Przedmiot() {NazwaPrzedmiotu="Asus Strix Soar", ProducentPrzedmiotu="Asus", KategoriaId = 3, CenaPrzedmiotu = 319, Bestseller=true, NazwaPlikuObrazka="Strix-Soar.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Strix Soar to karta dźwiękowa dla graczy wyposażona w podzespoły o wysokiej wydajności, która spełni wymogi najbardziej wymagających graczy, oczekujących czystego, pełnego dźwięku. Strix Soar dostarcza bogaty, głęboki i czysty dźwięk o współczynniku sygnału do szumu na poziomie 116dB, a wzmacniacz słuchawkowy 600 omów zapewnia mocny bas. Proste, ale potężne narzędzie Sonic Studio umożliwia pełną kontrolę karty dźwiękowej i ustawień dźwięku w grze."},
                new Przedmiot() {NazwaPrzedmiotu="Creative SB Audigy RX", ProducentPrzedmiotu="Creative", KategoriaId = 3, CenaPrzedmiotu = 249, Bestseller=true, NazwaPlikuObrazka="Audigy-RX.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Sound Blaster Audigy Rx to zaawansowana karta dzwiekowa, która stanowi idealne rozszerzenie podstawowego ukladu dzwiekowego na plycie glównej w celu zapewnienia wciagajacego dzwieku przestrzennego o jakosci kinowej. Zaawansowany uklad zaprojektowany na potrzeby przetwarzania przez nasz legendarny mechanizm poglosu EAX sprawia, ze uzytkownicy karty Sound Blaster Audigy Rx moga spodziewac sie doskonalego dzwieku wielokanalowego 7.1."},
                new Przedmiot() {NazwaPrzedmiotu="WD Red 4TB", ProducentPrzedmiotu="WD", KategoriaId = 4, CenaPrzedmiotu = 569, Bestseller=true, NazwaPlikuObrazka="WD-Red.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu=""},
                new Przedmiot() {NazwaPrzedmiotu="Seagate IronWolf 2TB", ProducentPrzedmiotu="Seagate", KategoriaId = 4, CenaPrzedmiotu = 309, Bestseller=true, NazwaPlikuObrazka="IronWolf-2TB.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Dysk IronWolf idealnie sprawdza się we wszelkich zastosowaniach związanych z pamięcią NAS. Stale uruchomiony dysk IronWolf został ulepszony o technologię AgileArray™ zapewniającą optymalną niezawodność i sprawność systemu. Technologia Multi-user oraz ekstremalnie wysokie wskaźniki obciążenia pracą pozwalają dyskom IronWolf utrzymywać jakość i rozwijać się wraz z przedsiębiorstwem."},
                new Przedmiot() {NazwaPrzedmiotu="Logitech M185 Niebieska", ProducentPrzedmiotu="Logitech", KategoriaId = 5, CenaPrzedmiotu = 69, Bestseller=true, NazwaPlikuObrazka="logitech-m185.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Logitech M185 to mysz bezprzewodowa o wyprofilowanym kształcie. Została wyposażona w niewielki bezprzewodowy odbiornik, który dzięki swym rozmiarom może być stale podłączony do komputera. Stabilna łączność bezprzewodowa zapewnia transmisję danych bez zakłóceń. Może działać nawet do 12 miesięcy bez konieczności wymiany baterii."},
                new Przedmiot() {NazwaPrzedmiotu="Asus Cerberus Czarna", ProducentPrzedmiotu="Asus", KategoriaId = 5, CenaPrzedmiotu = 99, Bestseller=true, NazwaPlikuObrazka="asus-cerberus.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="ASUS Cerberus Optical Gaming Mouse to myszka, która jest odpowiedzią na potrzeby nawet tych bardziej wymagających graczy. Jej sercem jest sensor optyczny, który charakteryzuje się bardzo wysoką czułością i pracuje w rozdzielczości od 500 do nawet 2500 DPI. Jest to bardzo istotne w wielu różnych gatunkach gier wideo – od pierwszoosobowych strzelanek, przez zręcznościówki, aż po dynamiczne strategie czasu rzeczywistego. Gryzoń przykuwa uwagę nie tylko tym co wewnątrz, ale też wyglądem."},
                new Przedmiot() {NazwaPrzedmiotu="Logitech MX Master 2S", ProducentPrzedmiotu="Logitech", KategoriaId = 5, CenaPrzedmiotu = 368, Bestseller=true, NazwaPlikuObrazka="logitech-mx.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="MX Master 2S to nowa mysz flagowa Logitech®, którą cechuje wygodny, ręcznie wyrzeźbiony kształt, oszałamiający styl, zasilanie akumulatorem oraz zaawansowane funkcje, które przenoszą obsługę wielu komputerów na zupełnie nowy poziom dzięki technologii FLOW."},
                new Przedmiot() {NazwaPrzedmiotu="Razer Blackwidow Chroma V2", ProducentPrzedmiotu="Razer", KategoriaId = 5, CenaPrzedmiotu = 599, Bestseller=true, NazwaPlikuObrazka="razer-blackwidow.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Mechaniczna klawiatura do gier Razer BlackWidow miała swoją premierę w 2010 r. i szybko stała się najpopularniejszą i najlepiej sprzedającą się klawiaturą do gier na świecie oraz ulubieńcem zawodowych graczy. Cztery lata później przedstawiliśmy Razer™ Mechanical Switch, które sprawiły Razer BlackWidow jeszcze lepszą dzięki pierwszym na świecie mechanicznym przełącznikom klawiszy stworzonym specjalnie z myślą o graczach."},
                new Przedmiot() {NazwaPrzedmiotu="Logitech K270", ProducentPrzedmiotu="Logitech", KategoriaId = 5, CenaPrzedmiotu = 119, Bestseller=true, NazwaPlikuObrazka="LogitechK270.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Logitech K270"},
                new Przedmiot() {NazwaPrzedmiotu="Logic LK-12 czarna", ProducentPrzedmiotu="Logic", KategoriaId = 5, CenaPrzedmiotu = 19, Bestseller=true, NazwaPlikuObrazka="Logic-lk12.png",
                DataDodania=DateTime.Now, OpisPrzedmiotu="Logic LK-12 to niezwykle wygodna i ergonomiczna klawiatura, którą cechuje prostota oraz funkcjonalność. Standardowy układ klawiszy z pełnym blokiem numerycznym umożliwia wygodne i łatwe korzystanie z klawiatury. "},

            };
            przedmiot.ForEach(k => context.Przedmioty.AddOrUpdate(k));
            context.SaveChanges();

            }
        }
    }
