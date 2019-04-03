using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadee
{
    class CheckFacade
    {

        private AvionApi avionAPI;
        private HotelApi hotelAPI;
        private AtraccionesApi atraccionesApi;

        public CheckFacade()
        {
            avionAPI = new AvionApi();
            hotelAPI = new HotelApi();
            atraccionesApi = new AtraccionesApi();
        }

        public void buscar(String fechaIda, String fechaVuelta, String origen, String destino)
        {
            avionAPI.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
            hotelAPI.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
            atraccionesApi.BuscarAtracciones(fechaIda, fechaVuelta, destino);
        }
    }
}
