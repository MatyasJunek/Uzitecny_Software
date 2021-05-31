# Seznam aut
## Verze 2.3
### Matyáš Junek
#### 25. 5. 2021
* Úvod
  * Účel
    * Program je pro každého, kdo hledá nové auto, nebo kdo přemýšlí o výhodné koupi. Je náhradou za zbytečné a pomalé otevírání a závírání oken prohlížeče, které Vám navíc zpomalují počítač.
  * Konvence dokumentu 
  * Pro koho je dokument určený
    * Dokument je určený pro uživatele, kteří chtějí podrobnou zprávu o pragramu.
  * Odkazy na ostatní dokumenty
    * https://github.com/MatyasJunek/Uzitecny_Software/blob/master/SRS_README.md  
* Scénáře
  * Všechny reálné způsoby použití
    * Hlavním využitím programu je srovnávání a přehledné prohlížení aut. Dá se také použít pro pamatování oblíbených vozidel, nebo pro automobilové nadšence.
  * Typy uživatelských rolí, „personas“
    * V programu je pouze jedna uživatelská role.
  * Detaily, motivace, „živé“ příklady  
  * Vymezení rozsahu
    * V softwaru nebude zakomponováno automatické vyplnění informací pomocí odkazu.
  * Na co se nebude klást důraz
    * Důraz se nebude klást na vizuální dokonalost.
* Celková hrubá architektura
  * Pracocní tok
    * Program by měl být jednoduchý a lehce použitelný.
  * Hlavní moduly
    * Prvním oknem je samotný seznam, ve kterém si můžete listovat. Druhým je poměření aut, ve kterém zblízka vidíte dvě auta vedle sebe a jsou zvýrazněné jejich výhody na nevýhody. Třetím je okno pro přidání auta, kterým můžete rozšířit svůj seznam a poslední je úprava auta pro případnou opravu chyby, snížení ceny vozidla, nebo smazání položky ze seznamu.
  * Detaily
    * Program se skládá až čtyř oken - seznam aut, porovnání, editace, přidání             
  * Všechny možné toky programu a jejich projevy
    * Pokud program po spuštění nenalezne stávající seznam, vytvoří si vlastní s několika auty. Poté je načte do seznamu, ve kterém můžete listovat. Můžete si zde zkopírovat odkaz k právě prohlíženému autu, upravit ho, nebo přidat nové. V okně s úpravami máte možnost změnit jednotlivé specifikace vozidla, nebo ho smazat ze seznamu pomocí tlačítka. Kliknitím na tlačítko "přidat auto" se vám otevře okno, ve kterém můžete vytvořit nové auto na svůj seznam. Dvoukliknutím na dvě různá vozidla je můžete "poměřit" zblízka.
  * Všechny dohodnté principy
* Otevřené otázky
  * Části, na kterých se zatím nedosáhlo shody
    * Program postrádá obrázek k autu, není ale jisté, zda je nutné je dělat.
  * Poznámky k realizaci    
