DigiD 6.19.2.0 — gedecompileerde C#

Alle 12 DigiD-dlls uit app/ plus de twee taalresource-dlls (en/es)
zijn met ILSpyCmd 9.1.0.7988 gedecompileerd. Er zijn 14 projecten en
1.120 C#-bestanden. Elke assembly heeft een eigen map en csproj.
Microsoft-, System- en andere dependency-dlls zijn alleen gebruikt voor
het oplossen van verwijzingen; ze zijn niet afzonderlijk gedecompileerd.
Sommige DigiD-assemblies bevatten zelf automatisch gegenereerde
Microsoft.Maui-typen. Die zitten daarom wel in hun uitvoer.

Startpunten
DigiD.Mobile/: hoofdapp, viewmodels, services en ingebedde appsettings
DigiD.Common.Http/: gedeelde HTTP-client
DigiD.Common/: instellingen en gedeelde logica
DigiD.Common.EID/, DigiD.Common.RDA/, DigiD.Common.NFC/: identiteitsdocumenten
DigiD.Common.Resources/ en en/es/: teksten en vertalingen

Alle decompilerprocessen zijn succesvol geëindigd. Dit is gereconstrueerde
code: oorspronkelijke opmerkingen, projectstructuur en sommige lokale
variabelenamen komen niet terug. Projectbestanden en resources zijn
geëxporteerd om de code te kunnen bekijken; de geëxporteerde csproj kan een onjuist targetframework bevatten
(de hoofdapp staat bijvoorbeeld op netcoreapp1.0, terwijl de echte app
.NET 10 gebruikt). Opnieuw bouwen is niet getest.

ILSpy: https://github.com/icsharpcode/ILSpy
