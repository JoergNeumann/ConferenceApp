using ConferenceApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using ConferenceApp.Contracts;

namespace ConferenceApp.Models
{
    public class SessionService
    {
        private static object _lockObject = new object();
        private static SessionService _current;
        private List<Speaker> _speakers;
        private List<Session> _sessions;
        private List<Topic> _menu;
        private ObservableCollection<Session> _favorites;

        private SessionService()
        {
            _speakers = new List<Speaker>
            {
                new Speaker { Id = 1, Name = "Rainer Stropek", Company = "software architects gmbh", Bio = "Rainer Stropek ist seit über zwanzig Jahren als Unternehmer in der IT-Industrie tätig. Er gründete und führte in dieser Zeit mehrere IT-Dienstleistungsunternehmen und entwickelt im Augenblick in seiner Firma „software architects“ mit seinem Team die preisgekrönte Software „time cockpit“. Rainer hat Abschlüsse an der Höheren Technischen Schule für MIS, Leonding (AT) sowie der University of Derby (UK). Er ist Autor mehrerer Fachbücher und Artikel in Magazinen im Umfeld von Microsoft .NET und C#. Seine technischen Schwerpunkte sind C# und das .NET Framework, XAML/WinRT/WPF/Silverlight, die Windows-Azure-Plattform sowie SQL Server. Seit 2010 ist Rainer MVP für Windows Azure und seit 2015 Microsoft Regional Director. Rainer tritt regelmäßig als Speaker und Trainer auf namhaften Konferenzen in Deutschland, Österreich und der Schweiz auf (z. B. BASTA!, SAPPHIRE, MS BigDays, MS Architecture Conference, MS TechEd, OOP, ADC, DEVCamp etc.). Darüber hinaus ist er Trainer bei www.IT-Visions.de.", ImageUri = "RainerStropek.jpg" },
                new Speaker { Id = 2, Name = "Christian Weyer", Company = "Thinktecture AG", Bio = "Christian Weyer ist ein bekannter Veteran in der Konzeption und Implementierung verteilter Anwendungsarchitekturen für Windows- und .NET-basierte Systeme. Mit seiner Firma Thinktecture AG hat er sich in den vergangenen siebzehn Jahren auf End-to-End-Aspekte verteilter Softwaresysteme konzentriert. Sein Werkzeugkasten umfasst Technologien wie HTML5, JavaScript, AngularJS, .NET, ASP.NET Web API, SignalR und Azure. Seit einigen Jahren ist er ein großer Freund von leichtgewichtigen Architekturen auf Basis von Web-APIs und Push-Services mit Anwendungs-UIs, die mehrere Plattformen und Geräte umspannen können. Christian ist MVP für ASP.NET und Microsoft Regional Director für Deutschland.", ImageUri = "ChristianWeyer.jpg" },
                new Speaker { Id = 3, Name = "Holger Schwichtenberg", Company = "www.IT-Visions.de/5Minds IT-Solutions", Bio = "Dr. Holger Schwichtenberg (alias „DOTNET-DOKTOR“) ist Leiter des renommierten .NET-Expertennetzwerks www.IT-Visions.de, das zahlreiche Unternehmen in Europa durch Beratung, Schulung, Coaching und Support unterstützt. Zudem ist er Entwicklungsleiter beim Softwareentwicklungsdienstleister 5Minds IT-Solutions GmbH & Co. KG (http://www.5Minds.de).Dr. Holger Schwichtenberg gehört durch seine Auftritte auf nationalen und internationalen Fachkonferenzen sowie zahlreiche Fachbücher für Addison-Wesley, Microsoft Press und den Carl Hanser Verlag zu den bekanntesten .NET-Experten in Deutschland. Darüber hinaus ist er ständiger Mitarbeiter der Fachzeitschriften Windows Developer, dotnetpro und iX sowie bei heise.de. Von Microsoft ist er für sein .NET-Fachwissen ausgezeichnet als Microsoft Most Valuable Professional (MVP) für ASP.NET. Sein Webblog finden Sie unter http://www.dotnet-doktor.de. Bei Twitter folgen Sie ihm unter „DOTNETDOKTOR“.", ImageUri = "HolgerSchwichtenberg.jpg" },
                new Speaker { Id = 4, Name = "Oliver Sturm", Company = "DevExpress", Bio = "Oliver Sturm is the Training Director at DevExpress. In over twenty years he has gathered great experience as a software developer and architect, consultant, trainer, speaker and writer. He is a long-time Microsoft C# MVP.", ImageUri = "OliverSturm.jpg" },
                new Speaker { Id = 5, Name = "Dominick Baier", Company = "Unabhängiger Sicherheitsberater", Bio = "Dominick Baier ist ein unabhängiger Sicherheitsberater mit einem Schwerpunkt auf Identity und Access Control. Er unterstützt Kunden weltweit bei dem Design und der Implementierung von Authentifizierung und Autorisierung in verteilten Web- und nativen Anwendungen. Er ist der Co-Autor des weitverbreiteten OpenID-Connect- und OAuth-2.0-Frameworks „IdentityServer“ (http://identityserver.io), hat ein paar Bücher geschrieben, bloggt bei http://leastprivilege.com und ist auf Twitter unter @leastprivilege zu finden.", ImageUri = "DominickBaier.jpg" },
                new Speaker { Id = 6, Name = "Manfred Steyer", Company = "www.SOFTWAREarchitekt.at/www.IT-Visions.de", Bio = "Manfred Steyer (www.softwarearchitekt.at) betreut als Trainer und Berater für moderne Webarchitekturen Firmen im gesamten deutschen Sprachraum. Dabei fokussiert er sich auf Angular 2. Manfred hat Bücher bei O’Reilly, Microsoft Press und dem Carl Hanser Hanser veröffentlicht, schreibt für Heise Online sowie den Windows Developer und ist Mitglied im Expertennetzwerk www.IT-Visions.de. Für seine Aktivitäten wurde er von Google als Developer Expert (GDE) und von Microsoft mit dem MVP-Award ausgezeichnet. Sein Wissen gibt er regelmäßig auf Konferenzen weiter.", ImageUri = "ManfredSteyer.jpg" },
            };
            _sessions = new List<Session>()
            {
                new Session { Id = 1, Title = "C#-Revolution", Speakers = new List<Speaker> { _speakers[0] }, Speaker="Rainer Stropek, software architects gmbh", Date = "09:00 bis 17:00 Uhr", Room = "", Description = "Was für eine Flut an Neuigkeiten in der C#-Welt, die nächste Visual-Studio-Version, C# 7, .NET Core u. v. m. ñ Zeit, sich wieder einmal einen Tag Auszeit vom Alltag zu nehmen und gemeinsam mit Rainer Stropek die neuesten Entwicklungen kennenzulernen. Rainer stellt diesmal C# 7 und Neuigkeiten in der .NET-Core-Plattform in den Mittelpunkt seines Workshops. Ergänzt werden diese beiden Themen durch Vorstellung neuer Funktionen in Visual Studio und aktueller Tools rund um die .NET-Entwicklung aus der Open-Source-Community. Wie immer wird Rainer primär anhand von Beispielen die Themen behandeln und Slides als Workshopnachlese zur Verfügung stellen.", Day = 1 },
                new Session { Id = 2, Title = "Moderne Businessanwendungen mit HTML5, Angular 2 und Co.", Speakers = new List<Speaker> { _speakers[1] }, Speaker="Christian Weyer, Thinktecture AG", Date = "09:00 bis 17.00 Uhr", Room = "", Description = "Alle reden darüber: Mobile, Apps, Webtechnologien und Cloud. Die Welt besteht nicht mehr aus Windows alleine, und Ihr Job als Entwickler ändert sich. In diesem Workshop zeigen Thorsten Hans und Christian Weyer interessierten .NET-Entwicklern, welche architekturellen Ideen und Konzepte hinter modernen Businessanwendungen auf Basis von HTML5, Angular 2 und TypeScript stecken. Sehen Sie praktische Lösungen für eine Reihe diverser Problem- und Fragestellungen. Wie kann man device- und plattformübergreifend Businessanwendungen mit Angular 2 bauen? Wie kann man dies für Windows (Desktop und UWP-Apps), für iOS, für Android und fürs Web gleichermaßen realisieren? Wie können diese Anwendungen auf Daten und Anwendungslogik zugreifen und zwar bitte auf Basis von serverseitigem .NET? Wie kann ich den Zugriff auf Services und Daten interoperabel und flexibel absichern? Kommen Sie und sehen Sie Antworten auf all diese interessanten Fragen. Moderne Businessanwendungen in Action!", Day = 1 },
				new Session { Id = 3, Title = "Datenzugriff mit Entity Framework und Entity Framework Core", Speakers = new List<Speaker> { _speakers[2] }, Speaker = "Holger Schwichtenberg, www.IT-Visions.de/5Minds IT-Solutions", Date = "09:00 bis 17:00 Uhr", Room = "", Description="Microsoft bezeichnet das Entity Framework als „recommended data access technology for new applications“. Das DataSet steht zunehmend im Abseits. Das sollte Grund genug sein, sich den Object-relational Mapper jetzt als Alternative zum DataSet anzusehen. An diesem Tag erhalten Sie einen umfassenden Streifzug durch die Möglichkeiten von Entity Framework, wobei das Code-based Modeling (alias Code First) im Mittelpunkt steht, denn der grafische EDMX-Designer ist auch schon wieder ein Auslaufmodell. Zunächst geht es um das Basiswissen: Entitätsklassen, Kontextklassen,\r\nForward Engineering mit Datenbankschemagenerierung oder Reverse Engineering bestehender Datenbanken und LINQ, die CRUD-Operationen und die Handhabung von Beziehungen einschließlich der Ladestrategien. Im Laufe des Nachmittags steigt der Workshop tiefer in das Entity Framework ein mit Architekturfragen sowie Tipps und Tricks: Performanceoptimierung mit NoTracking, First und Second Level Caching, direkte Verwendung von SQL, Stored Procedure und Table Valued Functions anstelle von LINQ, Custom Conventions, Detached Entities, Konfliktfeststellung und -behandlung und Eingriff in die Innereien von Entity Framework am Beispiel des Szenarios „Soft Delete“. Hinweis: Dieser Workshop ist eine reine Vorführung der Trainer inkl. Möglichkeiten, individuelle Fragen zu stellen. Aufgrund der Stoffmenge sind Teilnehmerübungen am PC nicht sinnvoll und daher nicht vorgesehen.\r", Day = 1 },
                new Session { Id = 4, Title = ".NET-Programmierer und Architekten: Strategien 2017", Speakers = new List<Speaker> { _speakers[3] }, Speaker = "Oliver Sturm, DevExpress", Date = "09:00 bis 17:00 Uhr", Room = "", Description="Auch 2017 stehen Programmierer und Architekten mit Hintergrund in .NET wieder vor Strategiefragen. Sollte man noch Clientanwendungen schreiben? Ist XAML oder HTML die Zukunft? JavaScript, TypeScript, C# oder F#? Wie sieht Datenzugriff eigentlich in der neuen verteilten Welt der modernen Apps aus? Dienste finde ich gut, aber ich höre, man braucht jetzt immer mehr davon? Wie groß ist eigentlich ein Microservice? Gibt es noch Webserver? Wieso muss man plötzlich alles mit Docker machen? Muss ich jetzt auch Open Source machen? In diesem ganztägigen Workshop bringt Oliver Sie auf den Stand 2017 zu den Möglichkeiten und Chancen, denen sich Programmierer und Architekten gegenüber sehen, aus einer technischen Perspektive und vor dem Hintergrund von .NET. Es gibt viel Raum für Ihre Fragen und für Diskussionen.", Day = 1 },
                new Session { Id = 5, Title = "Identity und Access Control für moderne Anwendungen und APIs", Speakers = new List<Speaker> { _speakers[4] }, Speaker = "Dominick Baier, Unabhängiger Sicherheitsberater", Date = "09:00 bis 17:00 Uhr", Room = "", Description="Moderne Anwendungen brauchen moderne Sicherheit ñ das gilt umso mehr für die heutzutage sehr typischen mobilen Web-/Native-basierenden Architekturen und die dazugehörigen API-Backends. Wer solche Anwendungen realisieren möchte, sollte sich mit dem modernen Securitystack, bestehend aus OpenID Connect, OAuth 2.0 und JSON Web Tokens sowie deren Implementierung, in ASP.NET und MVC und Web API auskennen. Dieser Workshop gibt einen Überblick über die relevanten Technologien und Protokolle für das Front- bzw. Backend und demonstriert deren Implementierung mit dem .NET Framework, ASP.NET Core, Xamarin und JavaScript.", Day = 1 },
                new Session { Id = 6, Title = "Moderne Webanwendungen mit Angular 2", Speakers = new List<Speaker> { _speakers[5] }, Speaker = "Manfred Steyer, www.SOFTWAREarchitekt.at/www.IT-Visions.de", Date = "09:00 bis 17.00 Uhr", Room = "", Description="Seit Jahren unterstützt Googles populäres Anwendungsframework AngularJS bei der Entwicklung benutzerfreundlicher und wartbarer JavaScript-Anwendungen. Angular 2 bringt einen Neustart mit atemberaubender Performance und Komponentenorientierung. Daneben werden aufstrebende Standards, wie ECMAScript 6 oder Web Components, adressiert und dank TypeScript wird auch eine statische Typisierung geboten. In diesem Workshop lernen Sie dieses Flaggschiffframework für Single Page Applications anhand einer Beispielanwendung kennen. Sie lernen die grundlegenden Konzepte von Angular 2 samt einer typischen Projektstruktur kennen und sehen, wie damit ein Anwendungsfall umgesetzt wird.", Day = 1 },
            };
            _menu = new List<Topic>
            {
                new Topic { Id = 2, Title = "Sprecher" },
                new Topic { Id = 3, Title = "Sessions" }
            };
            _favorites = new ObservableCollection<Session>();

			// Favoriten aus den gespeicherten Settings ermitteln
			var settingsService = DependencyService.Get<IUserPreferences>();
			if (settingsService != null)
			{
				foreach (var session in _sessions)
				{
					var value = settingsService.GetString(session.Id.ToString());
					if (value != null)
					{
						var isFavorite = bool.Parse(value);
						if (isFavorite)
						{
							this.AddFavorite(session);
						}
					}
				}
			}
        }

        public List<Session> GetSessions()
        {
            return _sessions;
        }

        public List<Speaker> GetSpeakers()
        {
            return _speakers;
        }

        public ObservableCollection<Session> GetFavorites()
        {
            return _favorites;
        }

		public bool IsFavorite(Session session)
		{
			return Favorites.Contains(session);
		}
        
		public void AddFavorite(Session session)
        {
            this.Favorites.Add(session);
			var settingsService = DependencyService.Get<IUserPreferences>();
			if (settingsService != null)
			{
				settingsService.SetString(session.Id.ToString(), true.ToString());
			}
		}

        public void RemoveFavorite(Session session)
        {
            this.Favorites.Remove(session);
			var settingsService = DependencyService.Get<IUserPreferences>();
			if (settingsService != null)
			{
				settingsService.SetString(session.Id.ToString(), false.ToString());
			}
		}

        public static SessionService Current
        {
            get
            {
                lock (_lockObject)
                {
                    if (_current == null)
                    {
                        _current = new SessionService();
                    }
                    return _current;
                }
            }
        }

        public ObservableCollection<Session> Favorites { get { return _favorites; } }
        public List<Speaker> Speakers { get { return _speakers; } }
        public List<Session> Sessions { get { return _sessions; } }
        public List<Topic> Menu { get { return _menu; } }
        public static Speaker SampleSpeaker { get { return Current._speakers[0]; } }
        public static Session SampleSession { get { return Current._sessions[0]; } }
    }

    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
