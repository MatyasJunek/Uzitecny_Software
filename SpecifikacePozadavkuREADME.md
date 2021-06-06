# Seznam aut
## Verze 2.3
### Matyáš Junek
#### 25. 5. 2021
* Úvod
  * Účel
    * Program je pro každého, kdo hledá nové auto, nebo kdo přemýšlí o výhodné koupi. **Je náhradou za zbytečné a pomalé otevírání a závírání oken prohlížeče**, které Vám navíc zpomalují počítač.
  * Konvence dokumentu
    * Každý termín v dokumentu bude vyznačen *kurzívou*, důležité části budou **zvýrazněny**. 
  * Pro koho je dokument určený
    * **Dokument je určený pro uživatele, kteří chtějí podrobnou zprávu o programu**. Může sloužit také jako návod, nebo jako základ pro vývojáře, kteří by chtěli program vylepšit.
  * Odkazy na ostatní dokumenty
    * [SRS](https://github.com/MatyasJunek/Uzitecny_Software/blob/master/SRS_README.md), [Nákres](https://github.com/MatyasJunek/Uzitecny_Software/blob/master/Specifications_Drawing.png)  
* Scénáře
  * Všechny reálné způsoby použití
    * Hlavním využitím programu je **srovnávání a přehledné prohlížení aut před jejich nákupem**. Je možné ho také použít pro pamatování oblíbených vozidel, nebo pro automobilové nadšence. Je využitelný také jako základ pro tvorbu podobných programů ostatními vývojáři.
  * Detaily, motivace, „živé“ příklady
    * Prvním oknem je **samotný seznam**, ve kterém si můžete listovat. Druhým je poměření aut, ve kterém zblízka vidíte dvě auta vedle sebe a jsou **zvýrazněné jejich výhody na nevýhody**. Třetím je okno pro **přidání auta, kterým můžete rozšířit svůj seznam** a poslední je úprava auta pro případnou **opravu chyby**, snížení ceny vozidla, nebo smazání položky ze seznamu.  
  * Vymezení rozsahu
    * V softwaru nebude zakomponováno **automatické vyplnění informací pomocí odkazu**. Bylo by to nepraktické zejména, protože by uživatel mohl pracovat pouze se stránkami, pro které by byla tato funkce naprogramována.
  * Na co se nebude klást důraz
    * Důraz se nebude klást na vizuální **dokonalost, složitost, ani bezpečnost**.
* Celková hrubá architektura
  * Pracocní tok
    * Program by měl být **jednoduchý a lehce použitelný**. Při používání by se měl uživatel cítil lépe, než při používání oken prohlížeče.   
  * Detaily
    * Při prohlížení aut je možné si **zkopírovat odkaz pomocí tlačítka**. Při upravování a vytváření nového auta do seznamu nemůžete do *textboxu* "Cena" a "Najeto" psát jiné znaky, než číslice. Dále není možné vytvořit, ani upravit auto, pokud nejsou všechny *textboxy* naplněny alespoň nějakými znaky.
  * Všechny možné toky programu a jejich projevy
    * Pokud program po spuštění nenalezne stávající seznam, vytvoří si vlastní s několika základními auty. Poté je načte do seznamu, ve kterém můžete listovat. Můžete si zde zkopírovat odkaz k právě prohlíženému autu, upravit ho, nebo přidat nové. V okně s úpravami máte možnost změnit jednotlivé specifikace vozidla, nebo ho smazat ze seznamu pomocí tlačítka. Kliknitím na tlačítko "přidat auto" se vám otevře okno, ve kterém můžete vytvořit nové auto na svůj seznam. Dvoukliknutím na dvě různá vozidla je můžete "poměřit" zblízka. Program Vám zvýrazní lepší a horší prametry jednotlivých aut pomocí barev (červená a zelená).
* Otevřené otázky
  * Části, na kterých se zatím nedosáhlo shody
    * Program postrádá obrázek k autu, protože není jisté, zda tato funkce nebude spíše nadbytěčná.
