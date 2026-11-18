using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Állati_kalandok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] karact = {"cica","hollo","kutya"};
            string aktualChar = "";
            ConsoleKey bile, billentyu, bile2;
            ConsoleKey elsoes, elsoesNO, masodikes , masodikesNO , harmadikes, harmadikesNO, negyedikES, negyedikesNO;
            ConsoleKey labirint, labirint1, labirint2, labirint3, labcica, labcicaNO, labhollo, labholloNO, labkutya, labkutyaNO;
        kezdet:
            Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("             ÁLLATI KALANDOK");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine( "Nyomj le egy billentyüt a folytatáshoz..." );
            bile = Console.ReadKey(true).Key;
            Console.ResetColor();
            Console.WriteLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Válaszd ki mivel szeretnél lenni:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Cica(Warlock): Harc esetén plusz +20 hp-ja van, és varázslatokkal harcol. ");
            Console.WriteLine("Holló(Rogue): Harc esetén remekül rejtőzködik +40 stamina, és két tőrrel harcol. ");
            Console.WriteLine("Kutya(Paladin): Harc esetén pajzsal védi magát +30 védelem, és egy nagy kalapáccsal harcol.");
            Console.WriteLine("\n Cica = A \n Holló = B \n Kutya = C");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            billentyu = Console.ReadKey(true).Key;
            if (billentyu == ConsoleKey.A)
            {
                Console.WriteLine("* A cicát választottad!☺ *");
                Console.WriteLine();
                Console.WriteLine(" /\\_/\\\r\n( o.o )\r\n > ^ <");
                aktualChar = karact[0];

            }
            else if (billentyu == ConsoleKey.B)
            {
                Console.WriteLine("* A hollót választottad!☺ *");
                Console.WriteLine();
                Console.WriteLine(" ,_\r\n  >' )\r\n  ( ( \\\r\nmrf''|\\");
                aktualChar = karact[1];
            }
            else if (billentyu == ConsoleKey.C) 
            {
                Console.WriteLine("* A kutyát választottad!☺ *");
                Console.WriteLine();
                Console.WriteLine("         __\r\n        /  \\\r\n       / ..|\\\r\n      (_\\  |_)\r\n      /  \\@' \r\n     /     \\\r\n_   /  `   |\r\n\\\\/  \\  | _\\\r\n \\   /_ || \\\\_\r\n  \\____)|_) \\_)");
            }

            bile2= Console.ReadKey(true).Key;
            if (bile2 == ConsoleKey.Enter)
                Console.Clear();
            else
                Thread.Sleep(500);

        nevadas:
            Console.ResetColor();
            Console.WriteLine("Mi a karaktered neve:");
            string nev = Console.ReadLine();
            if (nev == "") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Adj meg egy nevet!!");
                nev = "";
                goto nevadas;
                
            }

            else if (nev.Length > 20) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Adj meg egy rövidebb nevet!");
                nev = "";
                goto nevadas;
            }

            Thread.Sleep(500);
            Console.Clear();
            string kiindulo = "  Mikor felkeltél, és magad mellé pillantottál, a gazdád ágya vetetlen volt, és csak a hűlt helyét találtad, ami tőle szokatlan. \n Az egész házat felkutatod, de mivel a ház teljesen üres, úgy gondolod kimész az udvarra. Ahogy kilépsz és körbe nézel a világ mintha a feje tetejére állt volna.A szokásos megszokott környezet helyett, most egyetlen egy ösvény tárul a szemed elé.";
            string[] szavakindulo = kiindulo.Split(' ');
            foreach (string szo in szavakindulo)
            {
                Console.Write(szo + " ");
                Thread.Sleep(120);
            }
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Elindulsz az ösvényen vagy visszamész a házba aludni??");
            Console.ResetColor();
            Console.WriteLine("\n Elindulsz: Enter \n Visszamész: ESC");
            elsoes = Console.ReadKey(true).Key;
            if (elsoes == ConsoleKey.Enter) {
                Console.Clear();
                    string osveny = "  Elindulsz az ösvényen, egy kis idő múlva egy magas fáról furcsa zaj szűrődik le, mikor felnézel megpillantasz egy mókust, akinek a lába beakadt két faág közé.";
                string[] szavakosveny = osveny.Split(' ');
                foreach (string szo in szavakosveny)
                {
                Console.Write(szo + " ");
                Thread.Sleep(120);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                             &(`)&&  & &&\r\n                        && &\\/&\\|& (`)|/&&&&\r\n                        &\\/(/&/&||/&  /_/&/_&\r\n                     &(`)&\\/&|(,)/& \\/&&& & (`)\r\n                 &&&&_\\_&&_\\ |& |&&&/&&_/_& &&\r\n                    (`) &&&& &| &| /& & (`)& /&&\r\n                     &&_---&--\\&&|&&-&&--&-(`)~\r\n                       &&      |||}\r\n                           Y  {||{\r\n                           {}_}|||}\r\n                               ||}\r\n                         , -=-~'{`.-^- _\r\n                               `}\r\n                                 {");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Tovább haladsz vagy megpróbálsz segíteni?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Segítesz: Enter\nTovább haladsz: ESC");
                Console.ResetColor();
                masodikes = Console.ReadKey(true).Key;
                if (masodikes == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (aktualChar == "cica")
                    {
                        string macska1= "Felmászol a fára, és egy varázslat segítségével kiszabadítod a mókust a fa fogságából.\nA mókus köszönet képpen egy mogyoróból faragott iránytűt ajándékoz neked, megköszöni a segítséget, majd elszalad.\nÖsszezavarodva lemászol a fáról, és tovább folytatod az utad.";
                        string[] macska1szo = macska1.Split(' ');
                        foreach (string szo in macska1szo)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(120);
                        }
                        Thread.Sleep(8000);
                    }
                    else if (aktualChar == "hollo")
                    {
                        string hollo1 = "Felröppensz hozzá a fára, és a tőreiddel levágod az ágakat, amelyek fogságban tartják szegény párát.\nA mókus köszönet képpen egy mogyoróból faragott iránytűt ajándékoz neked, megköszöni a segítséget, majd elszalad.\nÖsszezavarodva leröppensz a fáról, és tovább folytatod az utad. ";
                        string[] hollo1szo = hollo1.Split(' ');
                        foreach (string szo in hollo1szo)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(120);
                        }
                        Thread.Sleep(8000);
                    }
                    else if (aktualChar == "kutya")
                    {
                        string kutya1 = "A nagy kalapácsoddal, a fa aljára ütsz egyet, amitől kidől, a mókus kiszabadúl, de ijedtében elszalad, te pedig könnyeket morzsolva, tovább mész az ösvényen. ";
                        string[] kutya1szo = kutya1.Split(' ');
                        foreach (string szo in kutya1szo)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(120);
                        }
                        Thread.Sleep(7000);
                    }

                    Console.Clear();
                    string denever = "Nézelődöl, mindenfelé majd egy furcsa kapun sétálsz át, és egy magas domb tárul a szemed elé. Az alján egy kétségbeesett denevért pillantasz meg. \n A denevér hozzád szól és azt mondja 'Kedves , ma egy gonosz boszorkány varázslattal egy föld lavinát zúdított a medálomra, ami egy családi örökség. Segítenél visszaszerezni?” ";
                    string[] deneverszo = denever.Split(' ');
                    foreach (string szo in deneverszo)
                    {
                        Console.Write(szo + " ");
                        Thread.Sleep(120);
                        if (szo == "'Kedves")
                        {
                            Console.Write(nev);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("     ,*-~\"`^\"*u_                                _u*\"^`\"~-*,\r\n  p!^       /  jPw                            w9j \\        ^!p\r\nw^.._      /      \"\\_                      _/\"     \\        _.^w\r\n     *_   /          \\_      _    _      _/         \\     _*\r\n       q /           / \\q   ( `--` )   p/ \\          \\   p\r\n       jj5****._    /    ^\\_) o  o (_/^    \\    _.****6jj\r\n                *_ /      \"==) ;; (==\"      \\ _*\r\n                 `/.w***,   /(    )\\   ,***w.\\\"\r\n                  ^ ilmk ^c/ )    ( \\c^      ^\r\n                          'V')_)(_('V'\r\n                              `` ``");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Segítesz visszaszerezni vagy tovább mész?");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Segítesz: Enter\nTovább haladsz: ESC");
                    Console.ResetColor();
                    harmadikes = Console.ReadKey(true).Key;
                    if (harmadikes == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        if (aktualChar == "cica")
                        {
                            string macska2 = "Megpróbálsz varázslattal segíteni, de a varázserőd cserben hagy. Mire a denevér megszólal “A gonosz boszorkány, átokkal súlytotta a dombot, nem hat rá semmilyen varázslat.” erre te megpróbálsz ásni, de hamar elfáradsz így a denevér elhajt téged, te pedig szomorúan tovább sétálsz az ösvényen.";
                            string[] macska2szo = macska2.Split(' ');
                            foreach (string szo in macska2szo)
                            {
                                Console.Write(szo + " ");
                                Thread.Sleep(120);
                            }
                            Thread.Sleep(9000);
                        }
                        else if (aktualChar == "hollo")
                        {
                            string hollo2 = "Felrepülsz a domb tetejére, először megpróbálod kikapirgálni, de nem sikerül, így előveszed a tőröket és megpróbálod erővel kiszabadítani a medált, de a tőrök majdnem eltörnek, ezért üres kézzel vissza repülsz a domb aljára a denevérhez, aki könnyek között elhajt, így tovább sétálsz az ösvényen.";
                            string[] hollo2szo = hollo2.Split(' ');
                            foreach (string szo in hollo2szo)
                            {
                                Console.Write(szo + " ");
                                Thread.Sleep(120);
                            }
                            Thread.Sleep(9000);
                        }
                        else if (aktualChar == "kutya")
                        {
                            string kutya2 = "Felcsillan a szemed és elkezdesz ásni, egy kis idő múlva, a medállal a szádba lépsz a denevér elé, aki örömkönnyek között csatolja fel a nyakára a láncot. Köszönet képpen pedig egy nagyobb kalapácsot ad ajándékba, majd eltűnik, te pedig folytatod az utadat.";
                            string[] kutya2szo = kutya2.Split(' ');
                            foreach (string szo in kutya2szo)
                            {
                                Console.Write(szo + " ");
                                Thread.Sleep(120);
                            }
                            Thread.Sleep(9000);
                        }
                        Console.Clear();
                        string vorosbegy = "Ahogy mész tovább az úton eléd ugrik egy vörösbegy és össze vissza ordibál,”Segítség, segítség a kölykeimet elrabolták, és kicserélték őket!!!A fészkemet pedig befoglalta egy kakukk!!.”";
                        string[] vorosSZo = vorosbegy.Split(' ');
                        foreach (string szo in vorosSZo)
                        {
                            Console.Write(szo + " ");
                            Thread.Sleep(120);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\\|             |/_\r\n_-  \\_   _/\"=_   _/  -_\r\n-_    `-'(   )`-'    _-\r\n `=.__.=-(   )-=.__.='\r\n         |/-\\|\r\ncjr      Y   Y");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Segítesz kiszabadítani a fiókákat vagy tovább haladsz?");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Segítesz: Enter\nTovább haladsz: ESC");
                        Console.ResetColor();
                        negyedikES = Console.ReadKey(true).Key;
                        if (negyedikES == ConsoleKey.Enter) {
                            Console.Clear();
                            if (aktualChar == "cica")
                            {
                                string cica3 = "Felmászol a fára, és megeszed a fészekben tartózkodó kakukkokat és a tojásaikat, majd egy varázslattal vissza teleportálod a vörösbegy tojásait. Lemászol a fáról, a vörösbegy pedig, köszönetképpen felkap téged, és egy labirintus előtt letesz majd ezt mondja neked “Ennél tovább már nem tudlak téged vinni, de a labirintus végén megtalálod, akit keresel, de vigyázz nem lesz harcmentes az utazás.” mondja majd elrepül.";
                                string[] cica3szo = cica3.Split(' ');
                                foreach (string szo in cica3szo)
                                {
                                    Console.Write(szo + " ");
                                    Thread.Sleep(120);
                                }
                                Thread.Sleep(500);
                            }
                            else if (aktualChar == "hollo")
                            {
                                string hollo3 = "Felszállsz a fára, és előkapod a két tört, amivel megfenyegeted a betolakodó kakukk családot, hogy azonnali hatállyal el kellene hagyni az ingatlant. De a kakukkok nem repülnek el, így kénytelen vagy szembe szállni velük, ezért leszúrod őket, a tojásaikat, pedig ledobálod. Majd elrepülsz a vörösbegy tojásaiért, aki köszönet képpen elnavigál egy labirintushoz.";
                                string[] hollo3szo = hollo3.Split(' ');
                                foreach (string szo in hollo3szo)
                                {
                                    Console.Write(szo + " ");
                                    Thread.Sleep(120);
                                }
                                Thread.Sleep(500);
                            }
                            else if (aktualChar == "kutya")
                            {
                                string kutya3 = "A földre csapsz egyet az új kalapácsoddal, ami egy nagyobb földrengést idéz elő, a fészek leesik a fáról a tojásokkal együtt, a kakukk pedig ijedtében elröppen, majd a vörösbegy tojásaival tér vissza. A kismadár megörül, és átvisz az aknamezőn, egyenesen a labirintus elé.";
                                string[] kutya3szo = kutya3.Split(' ');
                                foreach (string szo in kutya3szo)
                                {
                                    Console.Write(szo + " ");
                                    Thread.Sleep(120);
                                }
                                Thread.Sleep(500);
                            }
                            
                            Console.WriteLine();
                            Console.WriteLine("A labirintus előtt állsz, aminek a teteje teljesen zárt, és bentről furcsa zajok szűrődnek ki.");
                            Console.WriteLine();
                            Console.WriteLine("Bemész vagy ijedten elfutsz ?");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Bemész: Enter\nIjedten elfutsz: ESC");
                            Console.ResetColor();
                            labirint = Console.ReadKey(true).Key;
                            if (labirint == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                if (aktualChar == "cica")
                                {
                                    string cica4 = "Előveszed az iránytűt, amit a mókustól kaptál, amire az van írva, hogy “kövesd, hogy megtaláld a helyes utat.” Szerencsédre az iránytű kivezet a labirintusból, de ahogy kiérsz meglátod a gazdád rácsok fogságában, ami előtt a gonosz boszorkány áll.";
                                    string[] cica4szo = cica4.Split(' ');
                                    foreach (string szo in cica4szo)
                                    {
                                        Console.Write(szo + " ");
                                        Thread.Sleep(120);
                                    }
                                    Thread.Sleep(7000);
                                    Console.WriteLine();
                                    Console.WriteLine("Szembe szállsz vele vagy elfutsz??");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Szembe szálsz: Enter\nIjedten elfutsz: ESC");
                                    Console.ResetColor ();
                                    labirint1 = Console.ReadKey(true).Key;
                                    if (labirint1 == ConsoleKey.Enter)
                                    {
                                        Console.Clear();
                                        string cica5 = ("Használod a varázserőd, mielőtt észre venne egy tűzgolyót lősz rá, ami –90hp-t sebez a boszorkányra, mielőtt bevihetnéd az utolsó varázslatot a boszorkány egy erős átokkal súlyt, de a képességednek köszönhetően felgyógyulsz és megölöd a boszorkányt.\nA gazdád körűli rácsok eltűnnek te pedig boldogan szaladsz oda hozzá.\nMajd felébredsz a puha ágyadban.\nVége.... szeretnéd újra kezdeni?\nIgen: Enter\nNem: ESC ");
                                        string[] cica5szo = cica5.Split(' ');
                                        foreach (string szo in cica5szo)
                                        {
                                            Console.Write(szo + " ");
                                            Thread.Sleep(120);
                                        }
                                        labcica = Console.ReadKey(true).Key;
                                        if (labcica == ConsoleKey.Enter)
                                        {
                                            goto kezdet;
                                        }
                                        else if (labcica == ConsoleKey.Escape)
                                            Environment.Exit(0);

                                    }
                                    else if (labirint1 == ConsoleKey.Escape)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nem találsz ki, az iránytű elromlik. Vége van a játéknak szeretnéd újra kezdeni? ");
                                        Console.ResetColor();
                                        Console.WriteLine("Igen: Enter\nNem: ESC");
                                        labcicaNO = Console.ReadKey(true).Key;
                                        if (labcicaNO == ConsoleKey.Enter)
                                            goto kezdet;
                                        else if (labcicaNO == ConsoleKey.Escape)
                                            Environment.Exit(0);
                                    }

                                }
                                    else if (aktualChar == "hollo")
                                {
                                    string hollo4 = "Előveszed az iránytűt, amit a mókustól kaptál, amire az van írva, hogy “kövesd, hogy megtaláld a helyes utat.” Szerencsédre az iránytű kivezet a labirintusból, de ahogy kiérsz meglátod a gazdád rácsok fogságában, ami előtt a gonosz boszorkány áll.";
                                    string[] hollo4szo = hollo4.Split(' ');
                                    foreach (string szo in hollo4szo)
                                    {
                                        Console.Write(szo + " ");
                                        Thread.Sleep(120);
                                    }
                                    Thread.Sleep(7000);
                                    Console.WriteLine();
                                    Console.WriteLine("Szembe szállsz vele vagy elfutsz??");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Szembe szálsz: Enter\nIjedten elfutsz: ESC");
                                    Console.ResetColor ();
                                    labirint2 = Console.ReadKey(true).Key;
                                    if (labirint2 == ConsoleKey.Enter)
                                    {
                                        Console.Clear();
                                        string hollo5 = ("Láthatatlanná válsz, és a boszorkány mögé lopódzol majd a két törrel leszúrod, a boszorkány pedig eltűnik. Kiszabadítod a gazdádat, majd a vállára repülsz. \nFelébredsz a gazdád az ágyban alszik és semmi baja. \nVége.... szeretnéd újra kezdeni? \nIgen: Enter \nNem: ESC ");
                                        string[] hollo5szo = hollo5.Split(' ');
                                        foreach (string szo in hollo5szo)
                                        {
                                            Console.Write(szo + " ");
                                            Thread.Sleep(120);
                                        }
                                        labhollo = Console.ReadKey(true).Key;
                                        if (labhollo == ConsoleKey.Enter)
                                        {
                                            goto kezdet;
                                        }
                                        else if (labhollo == ConsoleKey.Escape)
                                            Environment.Exit(0);

                                    }
                                    else if (labirint2 == ConsoleKey.Escape)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nem találsz ki, az iránytű elromlik. Vége van a játéknak szeretnéd újra kezdeni? ");
                                        Console.ResetColor();
                                        Console.WriteLine("Igen: Enter\nNem: ESC");
                                        labholloNO = Console.ReadKey(true).Key;
                                        if (labholloNO == ConsoleKey.Enter)
                                            goto kezdet;
                                        else if (labholloNO == ConsoleKey.Escape)
                                            Environment.Exit(0);
                                    }

                                }
                                else
                                {
                                    string kutya4 = "A szimatod segítségével követed a gazdid szagát, és kijutsz a labirintusból hozzá, de meglátod, hogy a boszorka tartja fogva. Aki azonnal gonosz varázslatot küld feléd, de te a pajzsoddal kivéded, ami sajnos eltörik.";
                                    string[] kutya4szo = kutya4.Split(' ');
                                    foreach (string szo in kutya4szo)
                                    {
                                        Console.Write(szo + " ");
                                        Thread.Sleep(120);
                                    }
                                    Thread.Sleep(5000);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Szembe szállsz vele vagy elfutsz??");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Szembe szálsz: Enter\nIjedten elfutsz: ESC");
                                    Console.ResetColor();
                                    labirint3 = Console.ReadKey(true).Key;
                                    if (labirint3 == ConsoleKey.Enter)
                                    {
                                        Console.Clear();
                                        string kutya5 = ("A kalapácsodat a boszorkány felé dobod, aki egy varázslat segítségével eltűnik előle, és nem tér vissza. Kiszabadítod a gazdádat, majd megnyalogatod az arcát.\nFelébredsz a gazdád az ágyban alszik és semmi baja. \nVége....  szeretnéd újra kezdeni?\nIgen: Enter\nNem: ESC ");
                                        string[] kutya5szo = kutya5.Split(' ');
                                        foreach (string szo in kutya5szo)
                                        {
                                            Console.Write(szo + " ");
                                            Thread.Sleep(120);
                                        }
                                        labkutya = Console.ReadKey(true).Key;
                                        if (labkutya == ConsoleKey.Enter)
                                        {
                                            goto kezdet;
                                        }
                                        else if (labkutya == ConsoleKey.Escape)
                                            Environment.Exit(0);

                                    }
                                    else if (labirint3 == ConsoleKey.Escape)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nem találsz ki, az iránytű elromlik. Vége van a játéknak szeretnéd újra kezdeni? ");
                                        Console.ResetColor();
                                        Console.WriteLine("Igen: Enter\nNem: ESC");
                                        labkutyaNO = Console.ReadKey(true).Key;
                                        if (labkutyaNO == ConsoleKey.Enter)
                                            goto kezdet;
                                        else if (labkutyaNO == ConsoleKey.Escape)
                                            Environment.Exit(0);
                                    }

                                }

                            }


                            else if (labirint == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ráfutsz az aknamezőre, és felrobban az egész erdő. Vége van a játéknak, szeretnéd újra kezdeni? ");
                                Console.ResetColor ();
                                Console.WriteLine("Igen: Enter\nNem: ESC");
                                negyedikesNO = Console.ReadKey(true).Key;
                                if (negyedikesNO == ConsoleKey.Enter)
                                    goto kezdet;
                                else if (negyedikesNO == ConsoleKey.Escape)
                                    Environment.Exit(0);
                            }

                        }
                        else if (negyedikES == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Felrobban az egész erdő, mivel aknára lépsz. Vége van a játéknak szeretnéd újra kezdeni? ");
                            Console.ResetColor();
                            Console.WriteLine("Igen: Enter\nNem: ESC");
                            negyedikesNO = Console.ReadKey(true).Key;
                            if (negyedikesNO == ConsoleKey.Enter)
                                goto kezdet;
                            else if (negyedikesNO == ConsoleKey.Escape)
                                Environment.Exit(0);
                        }
                    }
                    else if (harmadikes == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rád zúdul a domb meghaltál. Vége van a játéknak szeretnéd újra kezdeni?");
                        Console.ResetColor();
                        Console.WriteLine("Igen: Enter\nNem: ESC");
                        harmadikesNO = Console.ReadKey(true).Key;
                        if (harmadikesNO == ConsoleKey.Enter)
                            goto kezdet;
                        else if (harmadikesNO == ConsoleKey.Escape)
                            Environment.Exit(0);
                    }
                }
                else if (masodikes == ConsoleKey.Escape) { 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rád esett a fa, meghaltál.Vége van a játéknak szeretnéd újra kezdeni ?");
                    Console.ResetColor();
                    Console.WriteLine("Igen: Enter\nNem: ESC");
                    masodikesNO = Console.ReadKey(true).Key;
                    if (masodikesNO == ConsoleKey.Enter)
                        goto kezdet;
                    else if (masodikesNO == ConsoleKey.Escape)
                        Environment.Exit(0);
                }
            }
            else if (elsoes == ConsoleKey.Escape) { 
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Visszamentél a házba aludni: vége van a játéknak szeretnéd újra kezdeni ?");
                Console.ResetColor();
                Console.WriteLine("Igen: Enter\nNem: ESC");
                elsoesNO = Console.ReadKey(true).Key;
                if (elsoesNO == ConsoleKey.Enter)
                    goto kezdet; 
                else if (elsoesNO == ConsoleKey.Escape)
                    Environment.Exit(0);

                
            }
            Console.ReadKey();
        }
    }
}
