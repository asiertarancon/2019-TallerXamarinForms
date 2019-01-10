using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaEvents.Models;

namespace XamaEvents.Services
{
    public class MockDataStore : IDataStore<Event>
    {
        List<Event> _items;

        public MockDataStore()
        {
            _items = new List<Event>()
            {
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Taller Xamarin Forms",
                    DateStart = new DateTime(2019, 1, 11, 17, 0, 0),
                    DateEnd = new DateTime(2019, 1, 11, 21, 0, 0),
                    Description = "En esta ocasión, Asier Tarancón, impartirá un Taller de Xamarin Forms. Durante estas 4 horas veremos dónde encaja Xamarin entre las distintas opciones de desarrollo multiplataforma. Hablaremos de sus ventajas y las razones por las que puede ser un buen framework para este tipo de aplicaciones. Pero es un taller, y como tal, la mayor parte del tiempo la dedicaremos a programar una aplicación. Desde 0, y utilizando las más novedosas herramientas que nos provee Xamarin, como son Shell o CollectionView (ambas aún en preview). Al finalizar el taller, serás capaz de crear una aplicación desde 0, entender las diferentes partes que la componen, y empezar a jugar con los distintos controles y posibilidades que nos ofrece el framework.",
                    Image = "https://www.riojadotnet.com/Media/Default/images/Eventos/tallerXamarinForms/tallerXamarinForms_carrusel.png",
                    Organizer = "Rioja{dotnet}"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Desarrollo de una aplicación empresarial internacional",
                    DateStart = new DateTime(2018, 12, 27, 19, 30, 0),
                    DateEnd = new DateTime(2018, 12, 27, 20, 30, 0),
                    Description = "En esta charla, Luis Sagasta, responsable de desarrollo de la empresa riojana Siam, nos contará su experiencia en el desarrollo de Chemeter, una aplicación de escritorio usada por más de 1000 empresas en todo el mundo. Nos explicará cómo ha sido todo el proceso durante los 10 años de desarrollo de la aplicación y su distribución a más de 35 países.",
                    Image = "https://www.riojadotnet.com/Media/Default/images/Eventos/AppInternacional/appInternacional_carrusel.png",
                    Organizer = "Rioja{dotnet}"
                },                
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Global Day of Coderetreat 2018",
                    DateStart = new DateTime(2018, 11, 17, 9, 0, 0),
                    DateEnd = new DateTime(2018, 11, 17, 18, 00, 0),
                    Description = "El Global Day of Coderetreat es un evento que se celebra simultáneamente en más de 100 ciudades del mundo. Orientado a desarrolladores de software, de cualquier lenguaje de programación (Java, C#, Php, Python, Visual Basic...), que quieren perfeccionar las buenas prácticas en el arte del desarrollo.",
                    Image = "http://www.riojadotnet.com/Media/Default/images/Eventos/globaldayofcoderetreat2018/coderetreat2018.png",
                    Organizer = "Rioja{dotnet}"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "DevOps: automatizando el despliegue de aplicaciones ASP.NET",
                    DateStart = new DateTime(2018, 10, 26, 18, 00, 0),
                    DateEnd = new DateTime(2018, 10, 26, 19, 40, 0),
                    Description = "Llevamos tiempo trabajando en una nueva aplicación web y llega el momento de ponerla en producción. Aquí es cuando pensamos, no hay problema, lo documentamos bien y los de operaciones se encargan, que seguro que todo va como la seda.",
                    Image = "http://www.riojadotnet.com/Media/Default/images/Eventos/devopsaspnet/devopsaspnet.png",
                    Organizer = "Rioja{dotnet}"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Xamarin Forms & App Center",
                    DateStart = new DateTime(2018, 6, 29, 17, 00, 0),
                    DateEnd = new DateTime(2018, 6, 29, 18, 30, 0),
                    Description = "En la charla veremos Xamarin Forms como un framework que nos permite desarrollar aplicaciones multiplataforma compartiendo toda la lógica de negocio y desarrollando una única interfaz para todas las plataformas. Veremos también App Center como una nueva herramienta de Microsoft que nos ayudará en todo el ciclo de vida de la aplicación móvil",
                    Image = "https://www.riojadotnet.com/Media/Default/images/Eventos/XamarinForms/xamarinForms.png",
                    Organizer = "Rioja{dotnet}"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Mejorando el proceso de embarque en los aeropuertos a través de deep learning",
                    DateStart = new DateTime(2018, 12, 5, 17, 00, 0),
                    DateEnd = new DateTime(2018, 12, 5, 18, 30, 0),
                    Description = "Usando como base un algoritmo de detección de maletas basado en redes neuronales haremos un recorrido por las distintas arquitecturas de red, empezando por una convolución hasta llegar al state of the art. Veremos además una arquitectura cloud de despliegue de modelos a través de un Edge Device como las Deep Lens de Amazon.",
                    Image = "https://secure.meetupstatic.com/photos/event/2/d/b/9/highres_476711705.jpeg",
                    Organizer = "Universidad de La Rioja"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Wintermeeting in 'La Trastienda' [Team-building]",
                    DateStart = new DateTime(2018, 11, 10, 14, 00, 0),
                    DateEnd = new DateTime(2018, 11, 10, 18, 00, 0),
                    Description = "Hacemos un Team-building, esta vez hay que registrarse plazas limitadas.",
                    Image = "https://secure.meetupstatic.com/photos/event/b/9/d/0/highres_475727568.jpeg",
                    Organizer = "GDG La Rioja"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Un podcast: Bueno para tí y bueno para tus clientes",
                    DateStart = new DateTime(2018, 11, 28, 20, 00, 0),
                    DateEnd = new DateTime(2018, 11, 28, 21, 00, 0),
                    Description = "Se dará a conocer las ventajas de este medio de comunicación para mejorar la imagen de marca y/o marca personal. Se indicará que se necesita para alojar un podcast en nuestro propio WordPress, como difundirlo a los distintos sitios (Apple y Google Podcast, IVoox, Spotify) así como consejos y errores a evitar. La mayor parte de la charla estará destinada a resolver dudas y dar a conocer podcast que hayan logrado ese objetivo",
                    Image = "https://secure.meetupstatic.com/photos/event/d/4/8/c/600_474054412.jpeg",
                    Organizer = "Rioja Wordpress"
                },

            };
        }
        public async Task<bool> AddItemAsync(Event item)
        {
            if (!_items.Any(i => i.Id == item.Id))
                _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            _items.Remove(_items.First(i => i.Id == id));
            return await Task.FromResult(true);
        }

        public async Task<Event> GetItemAsync(string id)
        {
            return await Task.FromResult(_items.FirstOrDefault(i => i.Id == id));
        }

        public async Task<IEnumerable<Event>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }

        public async Task<bool> UpdateItemAsync(Event item)
        {
            var oldItem = _items.FirstOrDefault(i => i.Id == item.Id);
            if (!(oldItem is null))
            {
                _items.Remove(oldItem);
            }
            _items.Add(item);
            return await Task.FromResult(true);
        }
    }
}
