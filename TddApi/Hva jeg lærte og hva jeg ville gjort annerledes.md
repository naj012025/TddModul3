Hva jeg lærte, og hva jeg ville gjort annerledes siden jeg startet
Lærte – Testing og TDD

Red-Green-testing er et bra utviklingsverktøy. Det å skrive tester først gjorde at jeg måtte tenke annerledes, og ga meg mer forståelse for hvordan koden skulle se ut.

Jeg merket samtidig at Test Driven Development (TDD) var betydelig vanskeligere enn å skrive tester etterpå. Men jeg ser poenget med TDD, siden det bidrar til mer robust kode og gir deg en sikkerhet mot at du ødelegger eksisterende funksjonalitet ved endringer senere i programutviklingen.

Det jeg ville gjort annerledes

Jeg ville begynt med TDD mye tidligere i læreprosessen min, slik at det hadde blitt en mer naturlig del av hvordan jeg tenker når jeg skriver kode. Jeg merker samtidig at jeg fortsatt må lese og lære betydelig mer om temaet.

Lærte – API

Jeg valgte å lage en annen type API enn en vanlig Todo API. Jeg lagde et API med Player XP og Monster.

Jeg lærte mye om hvordan man sender XP til serveren, og hvordan man setter opp modeller og tester for dette i et API.

Jeg hadde også planer om å lage en combat sequence, men så at dette ikke var nødvendig for denne oppgaven, så jeg valgte å droppe det denne gangen.

Det var likevel lærerikt fordi jeg måtte lese om mange nye ting rundt API-utvikling, og fikk prøvd andre måter å sette opp og mappe ting på enn i en vanlig Todo-liste.

Det jeg ville gjort annerledes

Jeg ville fokusert ChatGPT mer på å guide meg gjennom prosjektet på en mer laserfokusert måte. Dette har jeg fikset i ettertid.

Jeg skal også lære mer om generisk API-oppsett og skrive flere API-er mer og mer fra memory. Det er den måten jeg merker at jeg lærer mest på.

Lærte – Andre gjennomgang av modulen

Andre gang jeg har gått gjennom modulen, merker jeg at forståelsen min har blitt bedre på flere områder:

DTO: Jeg forstår bedre at en DTO bestemmer hvilken data som blir gjort tilgjengelig gjennom API-et til brukere eller andre systemer som trenger denne informasjonen.
Data / Database: Jeg har fått bedre forståelse for hvordan data og databasen henger sammen med resten av API-et.
Controllers: Jeg forstår bedre hva en Controller faktisk gjør, og hvilken rolle den har i API-et.
Excalidraw: Dette er ikke helt noe for meg, men jeg ser poenget med det for fremvisning og visualisering. Å skrive ting i 1-, 2-, 3-lister og bare gjøre det passer meg bedre.
Jo mindre ekstra ting som står i veien for det jeg vil fikse, jo bedre fungerer det for meg.
pgAdmin: Det å sette opp tilgang i API-et og koble det sammen med databasen ble mer åpenbart for meg, så jeg husker prosessen bedre nå.
YAML og Docker: Det samme gjelder oppsett av YAML og Docker. Jeg har fått bedre forståelse for hvordan dette settes opp og henger sammen.
Det jeg ville gjort annerledes

Jeg ville ikke utsatt dette så lenge. Etter første gjennomgang var jeg veldig fokusert på andre ting når det gjaldt API.

Spesielt oppsett av Docker og pgAdmin var noe jeg måtte få bedre kontroll på. Jeg måtte derfor lage en bedre læringsstruktur for meg selv, noe jeg nå har gjort.

Addendum – Det jeg lærte

Jeg fikk jobbet med Token Security igjen. Jeg lærte mye om dagens tema fra timen om tokens, og ble guidet gjennom oppsettet via ChatGPT. Underveis oppstod det mange spørsmål som jeg fant svarene på.

Jeg har også laget en huskeliste over ting jeg skal lese mer om, blant annet syntaks og oppsett av hashing av passord, mer om token-oppsett i API-oppgaven og generelt security-oppsett for API-er.

JWT

Jeg lærte at jeg under appsettings.json hadde en for kort secret i Jwt:Key, noe som gjorde at jeg fikk Internal Server Error.

OpenAPI

Jeg fant også ut at en feil oppstod da jeg oppgraderte OpenAPI i .csproj til en nyere versjon. Dette førte til build errors. Jeg lærte hvordan jeg kan fikse dette neste gang det skjer. Jeg gikk tilbake til forrige versjon, 2.11, og da var alt oppe og gikk igjen.

Ting jeg skulle ønske jeg hadde fikset tidligere

Som nevnt øverst fokuserte jeg mye på modulen som kom etter denne. Derfor gjorde jeg lite REST API-arbeid der, og jobbet mer med TCP for chat og lignende i fordypningsoppgavene.

Debugging

Det har også vært lærerikt å finne ut av ting selv. Debugging er gøy når problemene blir fikset, og jeg merker at jeg blir flinkere og flinkere til å finne løsninger på feil jeg selv lager.

Jeg hadde blant annet et problem hvor jeg ikke kunne legge til nye brukere i databasen gjennom pgAdmin. Problemet var knyttet til primary key. Da jeg seedet min første testbruker, la jeg manuelt inn at brukeren skulle ha Id = 1.

Da API-et senere skulle registrere en ny bruker, oppstod det derfor en konflikt med ID-en. Jeg fikset dette med en SQL-query ved hjelp av ChatGPT, men fant selv ut at dette var selve problemet ved å lese feilmeldingen i Internal Server Error.

Teksten er skrevet av meg. ChatGPT er kun brukt til språklig redigering, retting av skrivefeil og forbedring av tekststruktur.