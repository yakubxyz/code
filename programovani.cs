using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Maturita
{
    class Program
    {
        // /t - moje označení pro položky které v sobě nemají vlastní kod.
        // Nan - neexistující pojem/otázka nedává smysl (, sřílím od boku).
        #region 1 - Algoritmus a jeho vlastnosti /t
        /*
         * Algoritmus - přesný postup operací jejichž provedením bude daný typ úlohy vyřešen.
         * Algoritmická úloha - Nan, úloha kterou lze vyřešit nějakým algoritmem.
         * Program - posloupnost operací, které počítač provede k realizaci úlohy, uložen v jakékoliv paměti, jakýkoliv kod.
         * Proces - posloupnost operací, které počítač provede k realizaci úlohy, uložen v operační paměti, strojový kod.
         * 
         * Vlastnosti algoritmu:
         *      Hromadnost - schopný řešit množství podobných problémů, nejen konkrétní.
         *      Determinovanost - stejný vstup -> stejný výstup.
         *      Rezultativnost - algoritmus vrátí konkrétní výsledek
         *      Elementárnost - konečný počet jednoduchých příkazů.
         *      Konečnost - konečný počet kroků.
         *      Determinismus - každý krok je jednoznačný.
         * 
         * Správnost algoritmu je třeba ověřit, metoda ověřování:
         *      Zadat hodnoty se známou odpovědí, většinou se soustředíme na možné výjimky.
         * 
         * Větvení programu - if, switch.
         * Cyklus - for, while.
         * Zásady pstrukturovaného programování:
         *      Příkazy vykonávány pořadě.
         *      V závislosti na stavu některé příkazy (ne)vykonáváme - viz. větvení.
         *      Opakování dokud nedosáhneme výsledku - viz. cyklus.
         *      
         * Realizace programu na počítači:
         *      Program zapsán v programovacím jazyce (C#) je převeden do strojového kodu. Tím se pak počítač řídí.
         */
        #endregion
        #region 2 - Podmíněné příkazy /t
        /*
         * Podmíněný příkaz - if.
         * Syntaxe:
         *      if(podmínka)
         *          {pokud je podmínka pravdivá}
         *      else //není potřeba používat, součást úplného podmíněného příkazu.
         *          {pokud je podmínka nepravdivá}
         * 
         * Semantika:
         *      Blok else není nutné použít - pokud:
         *          není nutné nic měnit při nepravdivé podmínce.
         *          blok if zpracuje data do konce (data nepošle dál a tak je blok else nezapsaný).
         * 
         * Jak lze dodržet zásadu strukturovanosti algoritmu? Nan, podmíněné příkazy umožňují větvení algoritmu.
         * 
         * Relační a logické operátory:
         *      Relační:
         *          > - je větší, priorita 1 (stejná priorita se pak čte/provádí z leva do prava).
         *          >= - je větší nebo rovno, 1.
         *          < - je menší, 1.
         *          <= - je menší nebo rovno, 1.
         *          == - je shodné, 2.
         *          != - není zhodné, 2.
         *      Logické:
         *          && - a zároveň, 3.
         *          || - nebo, 4.
         * 
         * Vícenásobné větvení:
         * if()
         * else if()
         *      else if() ...
        */
        #endregion
        #region 3 - Příkazy opakování /t
        /*
         * Pojmy cyklu:
         *      Inicializace - Nan, deklarace typu cyklu (for, while).
         *      Tělo - obsahuje příkazy provedené při každé iteraci (opakování).
         *      Podmínka - zapsána v závorce vedle inicializace, určuje počet opakování/do kdy se má cyklus opakovat.
         *      
         * Cyklus s podmínkou na začátku:
         *      for(deklarace řídící proměnné; podmínka; změna řídící proměnné)
         *      {tělo}
         *      
         *      while(podmínka)
         *      {tělo}
         * 
         * Cyklus s podmínkou na konci:
         *      do
         *      {tělo}
         *      while(podmínka);
         *      
         * For:
         *      Syntaxe - viz. cyklus s podmínkou na začátku.
         *      Semantika - Nan, stejně jako všechny cykli s podmínkou na začátku, nemusí vykonat příkazy těla ani jednou.
         *      Požadavky na řídící proměnnou - Nan, musí mít numerickou hodnotu - int, double, char (ano, i char má numerickou hodnotu).
         * 
         * Konstanta x proměnná:
         *      Konstanta je neměnná, předem daný počet opakování.
         *      Proměnná může mít jakoukoliv hodnotu - 0, 5, ... POZOR - může se stát chyba - nekonečná smyčka.
         * 
         * Můžeme používat vřazené cykly? Ano.
         * Pravidla? Nan, řídící proměnné se musí jmenovat jinak.
         */
        #endregion
        #region 4 - Efektivnost algoritmu /t
        /*
         * Proveďte rozbor a porovnejte efektivnost programů.
         *      Sry, tady jen random bit k tomu jak rozlišit časovou efektivitu programů, pro loupáky:
         *          Cyklus - podle podmínky, za každý cyklus se násobí n, POZOR při n/2 se pořád násobí n.
         *          Další odhadové metody jsou nepřesné.
         *      Základní programy:
         *          Bubble sort - čas - n^2, paměť - 1
         *          Insert sort - n^2, 1
         *          Select sort - n^2, 1
         *          Quick sort - nlog(n), 0
         *          Iterativní search - n, 0
         *          Binary search - log(n), 0
         * 
         * Časová efektivnost - závislost délky zpracování dat na množství zadaných dat.
         * Paměťová efektivnost - závislost potřebné paměti navíc na množství zadaných dat.
         * Vždy se počítá efektivita v nejhorším případě.
         * Vzájemně si často odporují - optimalizace pro jedno zhorší druhé.
         * Algoritmus se dá vždy optimalizovat, ale ne vždy stojí výsledný rozdíl za čas navíc strávený programováním.
         * 
         * S optimalizací nemám jak pomoct přesně. Pravděpodobně se bude jednat o opakované procházení už seřazeného pole.
         * 
         * Závislost na jazyku - každý jazyk je jinak efektivní na rychlost a paměť. Obecně platí, že v nižších jazycích se dá lépe optimalizovat.
         *      Nižší jazyk - jazyk blyžší strojovému kodu.
         */
        #endregion
        #region 5 - Vstup a výstup dat /t
        /*
         * Read - slouží k získávání dat ze souboru, klávesnice, konzole, editačního pole, ...
         * Write - slouží k vypisování dat do souboru, do konzole, editačního pole, ...
         *      Editační pole - pole ve forms do kterého můžete zapisovat a vypisovat data.
         * 
         * Soubor - hlavička - kodovaní/typ souboru
         *                     velikost souboru
         *          vlastní obsah souboru
         * Tisk do řádku - WriteLine()
         * Střídání hodnot a textu: ("text1 {0} text2", 2) -> text1 2 text2
         *                          ("text1 " + 2 + " text2") -> text1 2 text2
         * 
         * Vstupní zařízení - myš, klávesnice, hlasový vstup, rozpoznávání textu, ...
         * Výstupní zařízení - monitor, tiskárna, reproduktor, ...
         */
        #endregion
        #region 6 - Popis typu /t
        /*
         * Datový typ - typ informace uložený v paměti.
         * Ordinální (jednoduchý - Nan) - má konečný počet možných hodnot - bool, int, double, char.
         * Strukturovaný - potenciálně nekonečný typ - string, pole, list.
         * 
         * Reálná čísla - 1/32 bit znaménko, 8/32 bitů posun znaménka, 23/32 bitů hodnota.
         * Celá čísla - 1/32 bit znaménko, 31 bitů hodnota.
         * 
         * Přeplnění:
         *      Hodnota je mimo možný rozsah pro daný datový typ.
         *      Ošetřeno operací modulo při sčítání - ((2^31)-1)(maximální hodnota int) + 1 = -(2^31)(minimální hodnota int).
         *      Při pokusu o nastavení hodnoty mimo limit dojde k chybě.
         * 
         * Přesnost:
         *      Celá čísla - jiné typy mají jiná maxima a minima, přesnost je stejná (na jednotky), short < int < long.
         *      Reálná čísla - větší typy mají větší přesnost a rozsah, float < double < decimal.
         */
        #endregion
        #region 7 - Zpracování textu /t
        /*
         * Reprezentace textu:
         *      char - 1 znak - 0 až 2^16 v základním kodovaní (UNICODE).
         *      string - neomezený počet znaků, můžeme s ním pracovat i jako s listem charů.
         * Operace a funkce:
         *      delete - smaže znaky od dané pozice dál, nebo určité množství znaků od pozice.
         *      replace - podobné chování jako delete, nahrazuje znaky za nové.
         *      split - rozdělí string na pole stringů, argumentem je dělící znak.
         *      format - formátování proměnných proo textovou reprezentaci.
         *      + - operace sčítání: string - připojí nový string.
         *                          char - změní uložený znak.
         * 
         * Kodovaní:
         *      ASCII - 256 znaků.
         *      UNICODE - 2^16 znaků.
         * 
         * Uložení:
         *      Hlavička - 20 bytů.
         *      Text - 2 bytů/znak.
         * 
         * Textové editory - pouze text, bez formátování - Notepad, PSPad, Textpad, ...
         * Textové procesory - formátování textu, obrázky, ... - Word
         */
        #endregion
        #region 8 - Datový typ soubor /t
        /*
         * Soubor - jakákoliv data uložená na ROM.
         * Pro práci se soubory používáme knihovnu System.IO.
         * 
         * Datový typ/kodovaní souboru deklarujeme při vytváření souboru.
         * Další práce se soubory ošetřují knihovny jiných programů - systém, editační program, ...
         * 
         * Pro čtení - StreamReader.
         * Pro psaní - StreamWriter.
         * Pro čtení i psaní zároveň - FileStream.
         * 
         * Operace:
         *      Read - čtení ze souboru.
         *      Write - zápis do souboru.
         *      Flush - přepsání záznamu uložených v RAM do ROM.
         *      Close - Provede Flush a vymaže instanci souboru z RAM.
         */
        #endregion
        #region 9 - Indexované proměnné, jednorozměrné pole /t
        /*
         * Bohužel tady vůbec nevím co v té praxi.
         * Možná seřadit vzestupně/sestupně.
         * 
         * Indexované proměnné - string, pole, list.
         * 
         * Praxe - indexovanaPromenna[cislo 0 až rozsah-1] - vrati hodnotu na dané pozici.
         * 
         * Problematika - v různých jazycích se začíná od 0, 1, nebo od libovolného čísla.
         */
        #endregion
        #region 10 - Dvojrozměrné pole /t
        /*
         * Deklarace:
         *      int[,] pole = new int[x, y];
         * 
         * Statické pole - má předem daný rozměr. Proměnnou, či konstantou daná velikost.
         * 
         * Ukládání - postupně řádky sloupce, kod viz. 22, práce s polem.
         * 
         * Prohledávání - postupně řádky sloupce, kod viz. 22, práce s polem.
         * 
         * Výměnny/součty řádků/sloupců - kod viz. 22, práce s polem.
         * 
         * Diagonály:
         *  \ diagonála - X == Y.
         *  nad \ - X > Y.
         *  pod \ - X < Y.
         *  / diagonála - X + Y == šířka - 1, nebo výška - 1.
         *  nad / - X + Y < šířka - 1, nebo výška - 1.
         *  pod / - X + Y > šířka - 1, nebo výška - 1.
         */
        #endregion
        #region 11 - Dynamické datové struktury /t
        /*
         * Dynamické - nemají předem stanovený rozměr, mohou se do nekonečna zvětšovat, spojový seznam, fronta, zásobník.
         * Seznam - ukládá vždy hodnotu a adresu dalšího prvku.
         * Ukazatel - slouží k ukládání adres proměnných, deklarace - int *ukazatel = & proměnnáNaKterouUkazuje.
         * 
         * Deklarace seznamu - LinkedList<int> seznam = new LinkedList<int>();
         * Metody:
         *      AddFirst - přidá prvek na první (nultou) pozici.
         *      AddLast - přidá prvek na poslední pozici.
         *      AddBefore - přidá před prvek s danou hodnotou.
         *      AddAfter - přidá za prvek s danou hodnotou.
         *      RemoveFirst - odebere první prvek.
         *      RemoveLast - odebere poslední prvek.
         *      Remove - odebere prvek s danou hodnotou.
         */
        #endregion
        #region 12 - Zásobníky a fronty /t
        /*
         * Zásobník - (LIFO) last in first out.
         * Fronta - (FIFO) first in first out.
         * 
         * Deklarace:
         *      Zásobník - Stack<int> zasobnik = new Stack<int>()
         *      Fronta - Queue<int> fronta = new Queue<int>()
         * 
         * Práce s prvky:
         *      Zásobník:
         *          Push - přidá nový prvek.
         *          Peek - vrátí hodnotu na řadě.
         *          Pop - vrátí hodnotu A smaže co je na řadě.
         *      Fronta:
         *          Enqueue - přidá prvek.
         *          Peek - vrátí hodnotu na řadě.
         *          Dequeue - smaže hodnotu co je na řadě.
         */
        #endregion
        #region 13 - Procedury a funkce, metody
        /*
         * Procedura - sled příkazů mimo vlastní program (main), nevrací hodnotu (void).
         * Funkce - sled příkazů mimo vlastní program (main), vrací hodnotu (int, string, ...).
         * Metoda - sled příkazů který se vztahuje k datové struktuře/třídě.
         * 
         * Volání procedur s parametry:
         *      typu hodnota - předem daný průběh procedury.
         *      typu proměnná - průběh procedury se mění v závislosti na hodnotě proměnné.
         * 
         * Pojmy:
         *      Hierarchická struktura programu - Nan, program je zapsán po řadě jak probíhá.
         *      Tvorba programu shora dolů - úlohu si postupně dělíme na menší, zvládnutelnější problémy, často se používá při návrhu programu.
         *      Modularita - program je rozdělen na samostatně funkční celky (procedury, funkce).
         *      Modifikovatelnost - Nan, kolik různých věcí je program schopný zvládnout při drobných úpravách.
         */
        public static int Mocnina(int Základ, int Exponent)
        {
            int výsledek = 1;
            for (int i = 0; i < Exponent; i++)
            {
                výsledek *= Základ;
            }
            return výsledek;
        }
        #endregion
        #region 14 - Rekurze /t
        /*
         * Rekurze, rekurzivní volání a rekurzivní metody - volají sami sebe dokud nedosáhnou ukončovací podmínky.
         * Přímá rekurze - Nan.
         * 
         * Výhody:
         *      Kratší zápis.
         *      Minimální paměťové nároky.
         * Nevýhody:
         *      Musí se s nimi umět dělat.
         *      Jsou méně předvídatelné - drbná chyba způsobí naprosté selhání.
         * 
         * Omezující podmínky:
         *      Mohou rychle přetéct - faktorial.
         *      Mohou být časově náročné - kombinační čísla.
         * 
         * Jednoduchou rekurzi lze nahradit cyklem.
         * 
         * Trasování - před spoštěním si klikněte do rekurze, zmáčkněte f9, udělá se vám v levo červená tečka.
         *      Spusťe program, jakmile se dostanete do rekurze objeví se vám okna - v nich hledejte hodnoty proměnných.
         *      f5 vám pak skočí na další iteraci rekurze.
         *      
         * Kod viz. 22, rekurze.
         */
        #endregion
        #region 15 - Řazení /t
        /*
         * Popište algoritmy:
         *      Bubble sort - z dvou sousedících vybere větší, posune ho do prava, pokud tam už není, opakuje dokud nedosáhne konce, pak jde zase na začátek.
         *      Insert sort - vybere číslo z neseřazené části, prochází seřazenou část dokud nenajde správnou pozici, opakuj.
         *      Select sort - vyhledává největší/nejmenší číslo z neseřazené části, dá ho na začátek/konec seřazené části.
         * 
         * Divide et impera - rozděl a panuj, rekurzivní metoda, zvolí bod, rozdělí seznam na větší a menší, rekurze na obě části, quick sort.
         *                  Efektivnost - nlog(n)
         * 
         * Další třídící algoritmy - Distribuční algoritmy - řadí čísla postupně na hromádky podle jejich číslic - Efektivnost - n.
         * 
         * kod viz. 22, řadící algoritmy.
         */
        #endregion
        #region 16 - Vyhledávání
        /*
         * Cílem vyhledávání je zjistit jestli se prvek v poli nachází, a pokud ano, tak na které pozici.
         * 
         * Pojmy:
         *      Sekvenční vyhledávání - procházíme každý prvek, používáme v neseřazeném poli.
         *      Binární vyhledávání - každým krokem půlíme interval ve kterém se hledaný prvek může nacházet, lze použít pouze v seřazeném poli.
         *      Zarážka: break - ukončí cyklus.
         *              continue - skočí na novou iteraci cyklu.
         *              return - opustí metodu a vrátí hodnotu.
         * 
         * Vícerozměrné pole - prohledáváme postupně celé pole po řádcích, sloupcích, atd. 
         */
        #region kod
        public static int SekvencniVyhledavani(int[] Pole, int HledanéČíslo)
        {
            int length = Pole.Length;
            for (int i = 0; i < length; i++)
            {
                if (Pole[i] == HledanéČíslo)
                {
                    return i;
                }
            }
            return -1;
        }//vrátí -1 pokud hledané číslo není v poli
        public static int BinarniVyhledavani(int[] Pole, int HledanéČíslo)
        {
            int length = Pole.Length;
            int minPozice = 0, maxPozice = length - 1;
            while (minPozice <= maxPozice)
            {
                int střed = (minPozice + maxPozice) / 2;
                if (HledanéČíslo == Pole[střed]) return ++střed;
                if (HledanéČíslo < Pole[střed])
                {
                    maxPozice = střed - 1;
                }
                else
                {
                    minPozice = střed + 1;
                }
            }
            return -1;
        }//vrátí -1 pokud hledané číslo není v poli
        #endregion
        #endregion
        #region 17 - Součty řad, výpočet z rekurentních vzorců.
        /*
         * Rekurentní vztah - vyjádření čísla pomocí nekonečé řady, kde každý člen je menší než předchozí.
         * Druhy řad:
         *      Konvergentní - každým krokem se blíží nějaké limitě.
         *      Divergentní - nemá limitu.
         * 
         * Způsoby ukončení:
         *      Přesnost.
         *      Počet opakování.
         *      Dosažení hodnoty.
         *      Čas.
         * 
         * Trasování - před spoštěním si klikněte do rekurze, zmáčkněte f9, udělá se vám v levo červená tečka.
         *      Spusťe program, jakmile se dostanete do rekurze objeví se vám okna - v nich hledejte hodnoty proměnných.
         *      f5 vám pak skočí na další iteraci rekurze.
         */
        #region kod
        //tady už mi došla trpělivost pro dnes, tohle vám nějak bude stačit, sry.
        #region PI
        //N je přesnost v 0.1 formátu.
        public static decimal viktoryn(int cycle)   //začni na 4, for (int i = 1; viktoryn(i) > -N; i++) pi += viktoryn(i);
        {
            decimal output = (- (decimal)4 / ((4 * cycle) - 1)) + ((decimal)4 / ((4 * cycle) + 1));
            return output;
        }
        public static decimal trinasobky (int cycle)    //začni na 3, for (int i = 0; trinasobky(i) > N; i++) pi += trinasobky(i);
        {
            decimal delitel1 = ((4 * cycle) + 2) * ((4 * cycle) + 3) * ((4 * cycle) + 4);
            decimal delitel2 = ((4 * cycle) + 4) * ((4 * cycle) + 5) * ((4 * cycle) + 6);
            decimal output = (4 / delitel1) - (4 / delitel2);
            return output;
        }
        public static decimal nadva(int cycle)      //začni na 3, for (int i = 0; nadva(i) > N; i++) pi += nadva(i);
        {
            long delenec = 6;
            for (int i = 0; i <= cycle; i++) delenec *= (2 * i) + 1;
            long delitel = 2;
            for (int i = 2; i <= ((cycle * 2) + 3); i++) delitel *= 2;
            for (int i = 2; i <= ((cycle * 2) + 4); i += 2)
            {
                if (i == ((cycle * 2) + 4))
                {
                    delitel *= (i - 1);
                    break;
                }
                delitel *= i;
            }
            decimal output = (decimal)delenec / delitel;
            return output;
        }
        #endregion
        #region Sin
        /*
         static public double PowFac(double basic, int pow)
        {
            double power = 1d;
            for (int j = 0; j < pow; j++) power *= basic;
            int factoriali = 1;
            for (int j = 1; j <= pow; j++) factoriali *= j;
            double output = power / factoriali;
            return output;
        }
        static void Main(string[] args)
        {
            Console.Write("x (e na kolikatou, kolik stupnu, kolik radianu) = ");
            double x1 = double.Parse(Console.ReadLine());
            double x2r = x1;
            double x2d = x1 * Math.PI / 180;
            Console.Write("presnost = ");
            double N = double.Parse(Console.ReadLine());
            double e = 2;
            double eplus = 1d;
            for (int i = 2; eplus > N; i++)
            {
                eplus /= i;
                e += eplus;
            }
            double ex = 1;
            for (int j = 0; j < x1; j++) ex *= e;
            double sinxr = 0;
            double sinxd = 0;
            for (int i = 0; PowFac(x2r, i) > N; i++)
            {
                switch (i % 4)
                {
                    default:                        
                        break;
                    case 1:
                        sinxr += PowFac(x2r, i);
                        sinxd += PowFac(x2d, i);
                        break;
                    case 3:
                        sinxr -= PowFac(x2r, i);
                        sinxd -= PowFac(x2d, i);
                        break;
                }
            }
            Console.WriteLine("e na {0} je {1}", x1, ex);
            Console.WriteLine("sinus {0}° je {1}", x1, sinxd);
            Console.WriteLine("sinus {0}(rad) je {1}", x1, sinxr);
            Console.ReadKey();
        }
         */
        #endregion
        #region Cosin
        /*
         static public double PowFac(double basic, double pow, int factor)
        {
            double power = 1d;
            for (int j = 0; j < pow; j++) power *= basic;
            int factoriali = 1;
            for (int j = 1; j <= factor; j++) factoriali *= j;
            double output = power / factoriali;
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zvol - stupne = 1, radiany = 2");
            int DR = int.Parse(Console.ReadLine());
            if (DR == 1) Console.Write("x (kolik stupnu) = ");
            else Console.Write("x (kolik radianu) = ");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = x1;
            if (DR == 1) x2 = x1 * Math.PI / 180; 
            Console.Write("presnost = ");
            double N = double.Parse(Console.ReadLine());
            if (N > 0.9) N = PowFac(0.1, N, 1);
            double cosx = 1;
            for (int i = 1; PowFac(x2, i, i) > N; i++)
            {
                if (DR == 1) switch (i % 4)
                {
                    default:
                        break;
                    case 0:
                        cosx += PowFac(x2, i, i);
                        break;
                    case 2:
                        cosx -= PowFac(x2, i, i);
                        break;
                }
                else switch (i % 4)
                {
                    default:
                        break;
                    case 0:
                        cosx += PowFac(x2, i, i);
                        break;
                    case 2:
                        cosx -= PowFac(x2, i, i);
                        break;
                }
            }
            if (DR == 1) Console.WriteLine("cosinus {0}° je {1}", x1, cosx);
            else Console.WriteLine("cosinus {0}(rad) je {1}", x1, cosx);
            Console.ReadKey();
        }
         */
        #endregion
        #endregion
        #endregion
        #region 18 - Numerické metody
        /*
         * Metody řešení rovnic:
         *      Metoda tečen - řešení je hledáno pomocí tečen na graf funkce - užívá se derivace funkce.
         *      Metoda sečen - jsou vytvořeny 2 sečny funkce v intervalu, ty pak určí nový (menší) interval.
         *      Metoda půlení intervalu - každou iterací půlíme interval ve kterém hledáme výsledek.
         * 
         * Způsoby ukončení:
         *      Přesnost.
         *      Počet opakování.
         *      Čas.
         * 
         * Interpolace - nalezení přibližného řešení v daném intervalu.
         */
        #region kod
        public static double MetodaPuleniIntervalu(double Přesnost, double DolníHranice, double HorníHranice)
        {
            double vysledek = (DolníHranice + HorníHranice) / 2;
            if (Math.Abs(funkce(vysledek)) < Přesnost) return vysledek;
            if (funkce(vysledek) > 0)
                if (funkce(DolníHranice) > 0) return MetodaPuleniIntervalu(Přesnost, vysledek, HorníHranice);
                else return MetodaPuleniIntervalu(Přesnost, DolníHranice, vysledek);
            else if (funkce(DolníHranice) < 0) return MetodaPuleniIntervalu(Přesnost, vysledek, HorníHranice);
                else return MetodaPuleniIntervalu(Přesnost, DolníHranice, vysledek);
        }
        public static double MetodaSecen(double Přesnost, double DolníHranice, double HorníHranice)
        {
            double vysledek = DolníHranice;
            while (Math.Abs(funkce(vysledek)) > Přesnost)
            {
                vysledek = HorníHranice - ((funkce(HorníHranice) * (HorníHranice - DolníHranice)) / (funkce(HorníHranice) - funkce(DolníHranice)));
                DolníHranice = HorníHranice;
                HorníHranice = vysledek;
            }
            return vysledek;
        }
        public static double funkce(double x) => x;
        #endregion
        #endregion
        #region 19 - Zpracování úloh lineární algebry
        /*
         * Upřímně, asi nejhorší otázka.
         * 
         * Matice - čtvercové, či obdelníkové schéma čísel.
         * Typy matic:
         *      Řádková - 1 x n pole.
         *      Sloupcová - n x 1 pole.
         *      Čtvercová - n x n pole.
         *      Obdelníková - n x m pole.
         *      Nulová - všechny prvky == 0;
         *      Digonální - jediné nenulové prvky jsou na hlavní (\) diagonále.
         *      Trojúhelníková - prvky pod/nad hlavní diagonálou == 0, horní/dolní trojúhelníková matice.
         *      Jednotková - Diagonální, všechny prvky na hlavní diagonále == 1.
         * 
         * Operace s maticemi - viz. kod.
         * 
         * Načítání - matice == dvojrozměrné pole.
         * 
         * Transponnovaná matice - viz. kod.
         * Inverzní matice - není kod, obtížnost naprogramování podobná jako soustava rovnic o n neznámých.
         * 
         * N rovnic - není snad třeba vysvětlovat.
         * Problémy - na hlavní diagonále se může vyskytnout 0, je třeba prohodit řádky.
         * Podmínky - stejný počet rovnic a neznámých.
         */
        #region kod
        public static int[,] ScitaniMatic(int[,] Matice1, int[,] Matice2)
        {
            int X = Matice1.GetLength(0), Y = Matice1.GetLength(1);
            int[,] vysledek = new int[X, Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    vysledek[i, j] = Matice1[i, j] + Matice2[i, j];
                }
            }
            return vysledek;
        }
        public static int[,] NasobeniMatic(int[,] Matice1, int[,] Matice2)
        {
            int X = Matice1.GetLength(0), Y = Matice1.GetLength(1);
            int[,] vysledek = new int[X, Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    for (int k = 0; k < X; k++)
                    {
                        vysledek[i, j] += Matice1[i, k] * Matice2[k, j];
                    }
                }
            }
            return vysledek;
        }
        public static int[,] TranspoziceMatice(int[,] Matice)
        {
            int X = Matice.GetLength(0), Y = Matice.GetLength(1);
            int[,] vysledek = new int[Y, X];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    vysledek[j, i] = Matice[i, j];
                }
            }
            return vysledek;
        }
        #endregion
        #endregion
        #region 20 - Tabulky a taabulkové procesory, algoritmy statistiky
        /*
         * Tabulky - způsob ukládání dat.
         * Tabulkové procesory - zpracování dat v tabulkách, Excel.
         * Algoritmy statistiky - slouží ke statistické analýze dat.
         * 
         * Zbytek je v kod.
         */
        #region Kod
        public static decimal AritmetickyPrumer(int[] input)
        {
            decimal output = 0M;
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++) output += input[i];
            return output / inputLength;
        }
        public static decimal GeometrickyPrumer(int[] input)
        {
            decimal output = 0M;
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++) output += (decimal)Math.Log(input[i]);
            return (decimal)Math.Exp((double)output / inputLength);
        }
        public static decimal HarmonickyPrumer(int[] input)
        {
            decimal output = 0M;
            foreach (int i in input) output += (decimal)1 / i;
            return input.Length / output;
        }
        public static decimal KvadratickyPrumer(int[] input)
        {
            decimal output = 0M;
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++) output += (decimal)input[i] * input[i] / inputLength;
            return (decimal)Math.Sqrt((double)output);
        }
        public static int[] VazeneVysledky(int[] input)
        {
            int[] output = new int[input[input.Length - 1] + 1];
            foreach (int i in input) output[i]++;
            return output;
        }//pomocná funkce, nepoužívat, vytvoří pole, na pozici čísla je vždy jeho četnost v seznamu
        public static decimal Modus(int[] input)
        {
            int[] vahy = VazeneVysledky(input);
            int vysledek = 0;
            int maximalniPocet = 0;
            foreach (int i in vahy) //najde největší číslo
            {
                if (vahy[i] > maximalniPocet)
                {
                    maximalniPocet = vahy[i];
                    vysledek = i;
                }
            }
            return vysledek;
        }
        public static decimal PrumernaAbsolutniOdchylka(int[] input)
        {
            decimal output = 0M;
            int inputLength = input.Length;
            decimal aritmetickyPrumer = AritmetickyPrumer(input);
            for (int i = 0; i < inputLength; i++) output += Math.Abs(input[i] - aritmetickyPrumer);
            return output / inputLength;
        }
        public static decimal PrumernaRelativniOdchylka(int[] input)
        {
            return 100 * PrumernaAbsolutniOdchylka(input) / AritmetickyPrumer(input);
        }
        public static decimal Rozptyl(int[] input)
        {
            decimal output = 0M;
            int inputLength = input.Length;
            decimal aritmetickyPrumer = AritmetickyPrumer(input);
            for (int i = 0; i < inputLength; i++) output += (input[i] - aritmetickyPrumer) * (input[i] - aritmetickyPrumer);
            return output / inputLength;
        }
        public static decimal SmerodatnaOdchylka(int[] input)
        {
            return (decimal)Math.Sqrt((double)Rozptyl(input));
        }
        public static decimal VyberovaSmerodatnaOdchylka(int[] input)
        {
            decimal output = 0, aritmetickyPrumer = AritmetickyPrumer(input);
            int inputLength = input.Length, lowInputLength = inputLength - 1;
            for (int i = 0; i < inputLength; i++)
            {
                output += ((input[i] - aritmetickyPrumer) * (input[i] - aritmetickyPrumer)) / lowInputLength;
            }
            return (decimal)Math.Sqrt((double)output);
        }
        public static decimal VariacniKoeficient(int[] input)
        {
            return SmerodatnaOdchylka (input) / AritmetickyPrumer(input);
        }
        public static decimal Median(int[] input)
        {
            return (decimal)(input[input.Length / 2 - input.Length % 2] + input[input.Length / 2 * 1 - 1]) / 2; //sečte prostřední 2 členy u sudého, sečte 2* prostřední člen u lichého, podělí 2
        }
        public static void StatistickaAnalyza(int[] input)
        {
            Console.WriteLine("Harmonicky prumer = " + (HarmonickyPrumer(input)));
            Console.WriteLine("Geometricky prumer = " + (GeometrickyPrumer(input)));
            Console.WriteLine("Aritmeticky prumer = " + (AritmetickyPrumer(input)));
            Console.WriteLine("Kvadraticky prumer = " + (KvadratickyPrumer(input)));
            //následující metody fungují jen na seřazeném seznamu
            Console.WriteLine("Median = " + (Median(input)));
            Console.WriteLine("Modus = " + (Modus(input)));
            Console.WriteLine("Prumerna absolutni odchylka = " + (PrumernaAbsolutniOdchylka(input)));
            Console.WriteLine("Prumerna relativni odchylka = " + (PrumernaRelativniOdchylka(input)));
            Console.WriteLine("Rozptyl = " + (Rozptyl(input)));
            Console.WriteLine("Smerodatna odchylka = " + (SmerodatnaOdchylka(input)));
            Console.WriteLine("Vyberova smerodatna odchylka = " + (VyberovaSmerodatnaOdchylka(input)));
            Console.WriteLine("Variacni koeficient = " + (VariacniKoeficient(input)));
        }//použití funkcí
        #endregion
        #endregion
        #region 21 - Počítačová grafika /t
        /*
         * Tady té teorie moc není.
         * 
         * K zpracování grafiky je třeba grafická karta.
         * 
         * Grafické editory:
         *      Bitmapové - malování, GIMP, Photoshop - JPEG, PNG.
         *      Vektorové - Zoner Calisto, Adobe Illustrator - PDF, EPS, SVG.
         */
        #endregion
        #region 22 - Kusy programů co se dají použít ve více otázkách
        #region Práce s polem
        public static int[] NactiNahodnePole(int N)
        {
            int[] Return = new int[N];
            Random Ran = new Random();
            for (int i = 0; i < N; i++) Return[i] = Ran.Next(2048);
            return Return;
        }
        public static int[,] Nacitani2PoleConsole(int X, int Y)
        {
            int[,] pole = new int[X, Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Console.Write("Zapište hodnotu v {0}. sloupci {1}. řádku.", i, j);
                    pole[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return pole;
        }
        public static int[,] Nacitani2PoleSoubor(int X, int Y)
        {
            StreamReader Soubor = new StreamReader("");//doplň název/adresu.
            int[,] pole = new int[X, Y];
            string radek;
            for (int j = 0; j < Y; j++)
            {
                radek = Soubor.ReadLine();
                for (int i = 0; i < X; i++)
                {
                    pole[i, j] = int.Parse(radek.Split(' ')[i]);//pokud tady hází chybu, dej " " místo ' '.
                }
            }
            return pole;
        }
        public static void Prohledavani2Pole(int[,] Pole, int HledanýPrvek)
        {
            int X = Pole.GetLength(0), Y = Pole.GetLength(1);//získej rozměry pole
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (Pole[i, j] == HledanýPrvek)
                    {
                        Console.WriteLine("{2} se nachází v {0}. sloupci {1}. řádku.", i, j, HledanýPrvek);
                        goto konec;//Skoč na label konec. Není jednosušší způsob jak se ze smyčky dostat. Funguje pokud hledáme jen jedno řešení.
                    }
                }
            }
            Console.WriteLine("{0} se v poli nenachází", HledanýPrvek);
        konec:;//Label konec.
        }
        public static int ScitaniSloupcu(int[,] Pole, int Sloupec)
        {
            int součet = 0, Y = Pole.GetLength(1);
            for (int j = 0; j < Y; j++)
            {
                součet += Pole[Sloupec, j];
            }
            return součet;
        }
        public static int ScitaniRadku(int[,] Pole, int Radek)
        {
            int součet = 0, X = Pole.GetLength(0);
            for (int i = 0; i < X; i++)
            {
                součet += Pole[i, Radek];
            }
            return součet;
        }
        public static int[,] ProhozeniRadku(int[,] Pole, int Radek1, int Radek2)
        {
            int X = Pole.GetLength(0), pomocnáProměnná = 0;
            for (int i = 0; i < X; i++)
            {
                pomocnáProměnná = Pole[i, Radek1];
                Pole[i, Radek1] = Pole[i, Radek2];
                Pole[i, Radek2] = pomocnáProměnná;
            }
            return Pole;
        }
        public static int[,] ProhozeniSloupce(int[,] Pole, int Sloupec1, int Sloupec2)
        {
            int Y = Pole.GetLength(1), pomocnáProměnná = 0;
            for (int j = 0; j < Y; j++)
            {
                pomocnáProměnná = Pole[Sloupec1, j];
                Pole[Sloupec1, j] = Pole[Sloupec2, j];
                Pole[Sloupec2, j] = pomocnáProměnná;
            }
            return Pole;
        }
        #endregion
        #region Rekurze
        public static int Faktorial(int Faktoriál)
        {
            if (Faktoriál < 2) return 1;
            return Faktoriál * Faktorial(Faktoriál - 1);
        }
        public static int KombinacniCisla(int n, int k)//n nad k
        {
            if (k == 0 || k == n) return 1;
            return KombinacniCisla(n - 1, k - 1) + KombinacniCisla(n - 1, k);
        }
        public static int FibonaccihoPosloupnost(int ČisloČlenu)
        {
            if (ČisloČlenu < 3) return 1;
            return FibonaccihoPosloupnost(ČisloČlenu - 1) + FibonaccihoPosloupnost(ČisloČlenu - 2);
        }
        #endregion
        #region Řadící algoritmy
        public static int[] Prehod(int[] Pole, int X, int Y)
        {
            int H = Pole[X];
            Pole[X] = Pole[Y];
            Pole[Y] = H;
            return Pole;
        }
        public static int[] SelectSort(int[] Pole)
        {
            for (int i = 0; i < Pole.Length; i++)
            {
                int Min = Pole[i];
                int Imin = i;
                for (int j = i + 1; j < Pole.Length; j++)
                {
                    if (Pole[j] < Min)
                    {
                        Min = Pole[j];
                        Imin = j;
                    }
                }
                Pole = Prehod(Pole, Imin, i);
            }
            return Pole;
        }
        public static int[] InsertSort(int[] Pole)
        {
            for (int i = 1; i < Pole.Length; i++)
            {
                int Help = Pole[i];
                int j = i - 1;
                while (j >= 0 && Pole[j] > Help)
                {
                    Pole[j + 1] = Pole[j];
                    j--;
                }
                Pole[j + 1] = Help;
            }
            return Pole;
        }
        public static int[] BubbleSort(int[] Pole)
        {
            bool swapped;
            for (int i = 0; i < Pole.Length - 1; i++)
            {
                swapped = true;
                for (int j = 0; j < Pole.Length - i - 1; j++)
                {
                    if (Pole[j + 1] > Pole[j])
                    {
                        Prehod(Pole, j, j + 1);
                        swapped = false;
                    }
                }
                if (swapped) break;
            }
            return Pole;
        }
        static void QuickSort(int[] Pole, int left, int right)
        {
            if (left < right)
            {
                int partitionIndex = Partition(Pole, left, right);
                if (partitionIndex >1) QuickSort(Pole, left, partitionIndex - 1);
                if (partitionIndex + 1 < right) QuickSort(Pole, partitionIndex + 1, right);
            }
        }
        static int Partition(int[] Pole, int left, int right)
        {
            int pivot = Pole[left];
            while (true)
            {
                while (Pole[left] < pivot)
                {
                    left++;
                }

                while (Pole[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (Pole[left] == Pole[right]) return right;
                    Pole = Prehod(Pole, left, right);
                }
                else return right;
            }
        }
        #endregion
        #region Římské číslice
        public static int RimskeNaArabske(string ŘímskéČíslo)
        {
            int[] hodnoty = { 1, 5, 10, 50, 100, 500, 1000 };
            char[] pismena = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int vysledek = 0;
            for (int i = 0; i < 7; i++)
            {
                foreach (char j in ŘímskéČíslo)
                {
                    if (j == pismena[i]) vysledek += hodnoty[i];
                }
            }
        return vysledek;
        }
        public static string ArabskeNaRimske(int ArabskéČíslo)
        {
            int[] hodnoty = { 1, 5, 10, 50, 100, 500, 1000 };
            char[] pismena = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            string vysledek = "";
            for (int i = 6; i > -1; i--)
            {
                for (int j = 0; j < (ArabskéČíslo / hodnoty[i]); j++)
                {
                    vysledek += pismena[i];
                }
                ArabskéČíslo -= hodnoty[i] * (ArabskéČíslo / hodnoty[i]);
            }
            return vysledek;
        }
        #endregion
        #region Změna soustavy
        public static string PrevodZ10DoNizsi(int Číslo, int Dawyt)//Proměnnou Dawyt pomocí ctrl+H vyměnte za vyši soustavu a odstraňte ji z argumentů metody.
        {
            string vysledek = "";
            Stack<int> zasobnik = new Stack<int>();
            do
            {
                zasobnik.Push(Číslo % Dawyt);
                Číslo /= Dawyt;
            } while (Číslo > Dawyt);
            while (zasobnik.Count != 0) vysledek += String.Format("{0}", zasobnik.Pop());
            return vysledek;
        }
        public static int PrevodZNizsiDo10(string Číslo, int Dawyt)//Proměnnou Dawyt pomocí ctrl+H vyměnte za vyši soustavu a odstraňte ji z argumentů metody.
        {
            int vysledek = 0;
            int cisloLength = Číslo.Length - 1;
            for (int i = cisloLength; i > -1; i--)
            {
                vysledek += (int)Math.Pow(Dawyt, cisloLength - i) * int.Parse(Číslo[i].ToString());
            }
            return vysledek;
        }
        //Následující funkce lze použít pro převod z jakékoliv, kdyby jste potřebovali.
        public static string PrevodZ10DoVyssi(int Číslo, int Dawyt)//Proměnnou Dawyt pomocí ctrl+H vyměnte za vyši soustavu a odstraňte ji z argumentů metody.
        {
            string vysledek = "";
            char[] symboly = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};//Doplň víc pokud potřeba, je jich 16.
            Stack<char> zasobnik = new Stack<char>();
            do
            {
                zasobnik.Push(symboly[Číslo % Dawyt]);
                Číslo /= Dawyt;
            } while (Číslo > Dawyt);
            while (zasobnik.Count != 0) vysledek += String.Format("{0}", zasobnik.Pop());
            return vysledek;
        }
        public static int PrevodZVyssiDo10(string Číslo, int Dawyt)//Proměnnou Dawyt pomocí ctrl+H vyměnte za vyši soustavu a odstraňte ji z argumentů metody.
        {
            int vysledek = 0;
            int cisloLength = Číslo.Length - 1;
            int temp = 0;
            char[] symboly = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };//Doplň víc pokud potřeba, je jich 16.
            for (int i = cisloLength; i > -1; i--)
            {
                for (int j = 0; j < Dawyt; j++)
                {
                    if (Číslo[i] == symboly[j])
                    {
                        temp = j;
                        break;
                    }
                }
                vysledek += (int)Math.Pow(Dawyt, cisloLength - i) * temp;
            }
            return vysledek;
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
        }
    }
}
