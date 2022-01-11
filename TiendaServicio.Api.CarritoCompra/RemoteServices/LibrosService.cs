using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TiendaServicio.Api.CarritoCompra.RemoteInterface;
using TiendaServicio.Api.CarritoCompra.RemoteModel;

namespace TiendaServicio.Api.CarritoCompra.RemoteServices
{
    public class LibrosService : ILibrosService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<LibrosService> _logger;

        public LibrosService(IHttpClientFactory httpClient, ILogger<LibrosService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<(bool resultado, LibroRemote Libro, string ErrorMessage)> GetLibro(Guid LibroId)
        {
            try
            {
                //El servicio que voy a consumir, esta en el startUp
                var cliente = _httpClient.CreateClient("Libros");
                var response = await cliente.GetAsync($"api/LibroMaterial({LibroId}");

                if (response.IsSuccessStatusCode)
                {
                    //Despliego el valor de response
                    var contenido = await response.Content.ReadAsStringAsync();
                    //Todo el formato json, y para que no haya problema de min y may
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    //desestructuracion, ya tiene toda la data de libro
                    var resultado = JsonSerializer.Deserialize<LibroRemote>(contenido, options);
                    return (true, resultado,null);
                }
                return (false, null, response.ReasonPhrase);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return (false, null, e.Message);
            }
        }
    }
}
